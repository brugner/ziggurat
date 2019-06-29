using AutoMapper;
using Corlib.Core;
using Corlib.Core.Domain;
using Corlib.Factories;
using Corlib.Presenters.Contracts;
using Corlib.Services;
using Corlib.Views.Contracts;
using Corlib.Views.ViewModels;
using System;
using System.Collections.Generic;
using System.Transactions;

namespace Corlib.Presenters
{
   class MembershipPresenter : IMembershipPresenter
   {
      private IMembershipView _view;
      private IUnitOfWork _unitOfWork;
      private Membership _membership;
      private int _memberId;
      private bool _isNewMembership;

      public MembershipPresenter(IMembershipView view, MembershipViewModel membershipViewModel, int memberId)
      {
         _view = view;
         _isNewMembership = membershipViewModel == null;
         _memberId = memberId;
         ServiceLocator.SetView(GetView());

         WireViewEvents();
         LoadRelatedData();
         _view.InitializeView();

         if (_isNewMembership)
            PrepareViewForNewMembership();
         else
            ShowMembershipData(membershipViewModel);
      }

      #region IMembershipPresenter
      public void ShowView()
      {
         _view.ShowView();
      }

      public IView GetView()
      {
         return _view;
      }

      public void Renew(MembershipViewModel membershipViewModel)
      {
         ServiceLocator.RunnerService.Run(() =>
         {
            if (!_view.Confirm("Se creará una membresía nueva con los mismos datos de la membresía anterior. ¿Desea continuar?"))
               return;

            using (_unitOfWork = UnitOfWorkFactory.Create())
            {
               _membership = _unitOfWork.Memberships.Get(x => x.Id == membershipViewModel.Id, "Training", "Shift");

               if (!_unitOfWork.Shifts.HasFreeQuota(_membership.ShiftId))
               {
                  _view.Notify("Este turno ya tiene el cupo completo. Por favor, seleccione otro o modifique el cupo del mismo.", MessageType.Warning);
                  return;
               }

               var newMembership = new Membership();
               newMembership.MemberId = _membership.MemberId;
               newMembership.TrainingId = _membership.TrainingId;
               newMembership.ShiftId = _membership.ShiftId;
               newMembership.Length = _membership.Length;
               newMembership.StartDate = DateTime.Today;
               newMembership.EndDate = GetEndDate(newMembership.Length, membershipViewModel.StartDate, membershipViewModel.EndDate);
               newMembership.Price = _membership.Price;
               newMembership.Status = MembershipStatus.ACTIVE;
               _unitOfWork.Memberships.Add(newMembership);

               var member = _unitOfWork.Members.Get(_membership.MemberId);
               member.Memberships.Add(newMembership);

               _unitOfWork.Complete();
               _view.Notify("La membresía se renovó exitosamente", MessageType.Information);
            }
         }, "Ha ocurrido un error al intentar renovar la membresía. Por favor, intenta nuevamente.");
      }
      #endregion

      private void ShowMembershipData(MembershipViewModel membershipViewModel)
      {
         using (_unitOfWork = UnitOfWorkFactory.Create())
         {
            _membership = _unitOfWork.Memberships.Get(x => x.Id == membershipViewModel.Id, "Training", "Shift");
         }

         _view.Id = _membership.Id;
         _view.TrainingId = _membership.TrainingId;
         _view.ShiftId = _membership.ShiftId;
         _view.Length = _membership.Length;
         _view.StartDate = _membership.StartDate;
         _view.EndDate = _membership.EndDate;
         _view.Price = _membership.Price;
         _view.Status = _membership.Status;
         _view.IsFullyPaid = _membership.IsFullyPaid;
      }

      private void PrepareViewForNewMembership()
      {
         _view.ViewText = "Agregar membresía";
         _view.Status = MembershipStatus.ACTIVE;
      }

      private void WireViewEvents()
      {
         _view.SaveMembership += OnSaveMembership;
      }

      private void OnSaveMembership()
      {
         using (var scope = new TransactionScope(TransactionScopeOption.Required))
         {
            using (_unitOfWork = UnitOfWorkFactory.Create())
            {
               if (!_unitOfWork.Shifts.HasFreeQuota(_view.ShiftId))
               {
                  _view.Notify("Este turno ya tiene el cupo completo. Por favor, seleccione otro o modifique el cupo del mismo.", MessageType.Warning);
                  return;
               }

               var member = _unitOfWork.Members.Get(x => x.Id == _memberId, "Memberships");
               Membership membership;

               if (_isNewMembership)
                  membership = new Membership();
               else
                  membership = _unitOfWork.Memberships.Get(_membership.Id);

               membership.TrainingId = _view.TrainingId;
               membership.ShiftId = _view.ShiftId;
               membership.Length = _view.Length;
               membership.StartDate = _view.StartDate;
               membership.EndDate = _view.EndDate;
               membership.Price = _view.Price;
               membership.Status = _view.Status;
               membership.IsFullyPaid = _view.IsFullyPaid;

               if (_isNewMembership)
               {
                  _unitOfWork.Memberships.Add(membership);
                  member.Memberships.Add(membership);
               }

               ServiceLocator.RunnerService.Run(() =>
               {
                  _unitOfWork.Complete();

                  var trainingName = _unitOfWork.Trainings.Get(_view.TrainingId).Name;
                  var financialService = new FinancialService(_unitOfWork);
                  financialService.RegisterMovement(member.Id, $"{trainingName} {membership.StartDate.ToString("dd/MM/yyyy")}-{membership.EndDate.ToString("dd/MM/yyyy")}", debit: membership.Price, credit: 0, membershipId: membership.Id);
                  _unitOfWork.Complete();
               }, "Ha ocurrido un error al intentar registrar la membresía. Por favor, intenta nuevamente.");
            }

            scope.Complete();
            _view.Notify("La membresía se guardó exitosamente", MessageType.Information);
            _view.CloseView();
         }
      }

      #region Helpers
      public void LoadRelatedData()
      {
         using (_unitOfWork = UnitOfWorkFactory.Create())
         {
            var trainings = _unitOfWork.Trainings.Find(x => !x.IsDeleted, "Shifts");
            _view.Trainings = Mapper.Map<IList<TrainingViewModel>>(trainings);
         }
      }

      private DateTime GetEndDate(int length, DateTime previousMembershipStartDate, DateTime previousMembershipEndDate)
      {
         int days = 0;

         if (length == MembershipLength.WEEK)
            days = 6;
         else if (length == MembershipLength.MONTH)
            days = 29;
         else if (length == MembershipLength.QUARTER)
            days = 89;
         else if (length == MembershipLength.OTHER)
            days = (int)(previousMembershipEndDate - previousMembershipStartDate).TotalDays;

         return DateTime.Today.AddDays(days);
      }
      #endregion
   }
}
