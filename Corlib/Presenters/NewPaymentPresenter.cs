using AutoMapper;
using Corlib.Builders;
using Corlib.Core;
using Corlib.Core.Domain;
using Corlib.Extensions;
using Corlib.Factories;
using Corlib.Presenters.Contracts;
using Corlib.Services;
using Corlib.Views.Contracts;
using Corlib.Views.ViewModels;
using System.Collections.Generic;
using System.Linq;
using System.Transactions;

namespace Corlib.Presenters
{
   class NewPaymentPresenter : INewPaymentPresenter
   {
      private readonly INewPaymentView _view;
      private IUnitOfWork _unitOfWork;
      private int _memberId;

      public NewPaymentPresenter(INewPaymentView view, int memberId)
      {
         _view = view;
         _memberId = memberId;
         ServiceLocator.SetView(GetView());

         WireViewEvents();
         LoadRelatedData();
         _view.InitializeView();

         PrepareViewForNewPayment();
      }

      #region IPaymentPresenter
      public void ShowView()
      {
         _view.ShowView();
      }

      public IView GetView()
      {
         return _view;
      }
      #endregion

      private void WireViewEvents()
      {
         _view.SavePayment += OnSavePayment;
      }

      private void OnSavePayment()
      {
         Payment payment = null;

         ServiceLocator.RunnerService.Run(() =>
         {
            using (var scope = new TransactionScope(TransactionScopeOption.Required))
            {
               using (_unitOfWork = UnitOfWorkFactory.Create())
               {
                  payment = new Payment
                  {
                     Amount = _view.Amount,
                     Date = _view.Date,
                     Comment = _view.Comment
                  };

                  var concept = string.Empty;

                  if (_view.CheckedDebt.IsMembership())
                  {
                     var membership = _unitOfWork.Memberships.Get(x => x.Id == _view.CheckedDebt.MembershipId, "Training", "Payments");
                     payment.MembershipId = _view.CheckedDebt.MembershipId;
                     payment.Membership = membership;
                     payment.Concept = GetPaymentConcept(membership);

                     if (payment.Amount + membership.Payments.Sum(x => x.Amount) >= membership.Price)
                        membership.IsFullyPaid = true;

                     _unitOfWork.Payments.Add(payment);
                     membership.Payments.Add(payment);

                     concept = $"Pago {membership.Training.Name} {membership.StartDate.ToString("dd/MM/yyyy")}-{membership.EndDate.ToString("dd/MM/yyyy")}";
                  }
                  else
                  {
                     var sale = _unitOfWork.Sales.Get(x => x.Id == _view.CheckedDebt.SaleId, "SaleItems", "Payments");
                     payment.SaleId = _view.CheckedDebt.SaleId;
                     payment.Sale = sale;
                     payment.Concept = GetPaymentConcept(sale);

                     if (payment.Amount + sale.Payments.Sum(x => x.Amount) >= sale.SaleItems.Sum(x => x.Price * x.Quantity))
                        sale.IsFullyPaid = true;

                     _unitOfWork.Payments.Add(payment);
                     sale.Payments.Add(payment);

                     concept = payment.Concept;
                  }

                  _unitOfWork.Complete();

                  var financialService = new FinancialService(_unitOfWork);
                  financialService.RegisterMovement(_memberId, concept, debit: 0, credit: payment.Amount, membershipId: payment.MembershipId, saleId: payment.SaleId, paymentId: payment.Id);

                  _unitOfWork.Complete();
               }

               scope.Complete();
               _view.Notify("El pago se registró exitosamente", MessageType.Information);
            }
         }, "Ha ocurrido un error al intentar guardar el pago. Por favor, intenta nuevamente.");


         if (payment?.Id > 0)
         {
            if (_view.Confirm("¿Desea imprimir el recibo?"))
            {
               var config = new ReportConfigurationViewModel
               {
                  ViewText = "Recibo de pago",
                  Report = Report.Receipt,
                  DataMember = "Query",
                  Parameters = Helper.GetReceiptReportParameters(payment.Id)
               };

               PresenterBuilder<IReportPresenter, IReportView>.Build(config).ShowView();
            }
         }

         _view.CloseView();
      }

      #region Helpers
      private void LoadRelatedData()
      {
         using (_unitOfWork = UnitOfWorkFactory.Create())
         {
            var memberships = _unitOfWork.Memberships.Find(x => x.MemberId == _memberId && !x.IsFullyPaid, "Training", "Payments");
            var sales = _unitOfWork.Sales.Find(x => x.MemberId == _memberId && !x.IsFullyPaid, "SaleItems", "Payments");

            var debts = Mapper.Map<IEnumerable<DebtViewModel>>(memberships).ToList();
            debts.AddRange(Mapper.Map<IEnumerable<DebtViewModel>>(sales));

            _view.Debts = debts;
         }
      }

      private void PrepareViewForNewPayment()
      {
         _view.ViewText = "Registrar pago";
      }

      private string GetPaymentConcept(Membership membership)
      {
         return $"Pago membresía {membership.Training.Name} {membership.StartDate.ToString("dd/MM/yyyy")}-{membership.EndDate.ToString("dd/MM/yyyy")}".Truncate(200);
      }

      private string GetPaymentConcept(Sale sale)
      {
         return $"Pago venta #{sale.Number}";
      }
      #endregion
   }
}
