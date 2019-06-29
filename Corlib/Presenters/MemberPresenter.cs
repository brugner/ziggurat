using AutoMapper;
using Corlib.Builders;
using Corlib.Core;
using Corlib.Core.Domain;
using Corlib.Factories;
using Corlib.Presenters.Contracts;
using Corlib.Services;
using Corlib.Views.Contracts;
using Corlib.Views.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Corlib.Presenters
{
   class MemberPresenter : IMemberPresenter
   {
      private readonly IMemberView _view;
      private IUnitOfWork _unitOfWork;
      private Member _member;
      private bool _isNewMember;

      public MemberPresenter(IMemberView view, MemberViewModel memberViewModel)
      {
         _view = view;
         ServiceLocator.SetView(GetView());
         _isNewMember = memberViewModel == null;

         WireViewEvents();
         LoadRelatedData();
         _view.InitializeView();

         if (_isNewMember)
            PrepareViewForNewMember();
         else
            ShowMemberData(memberViewModel);
      }

      #region IMemberPresenter
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
         _view.SaveMember += OnSaveMember;
         _view.DeleteMember += OnDeleteMember;
         _view.ShowContact += OnShowContact;
         _view.DeleteContact += OnDeleteContact;
         _view.ShowNote += OnShowNote;
         _view.DeleteNote += OnDeleteNote;
         _view.MoreCities += OnMoreCities;
         _view.ProfilePictureClicked += OnProfilePictureClicked;
         _view.ShowMembership += OnShowMembership;
         _view.RenewMembership += OnRenewMembership;
         _view.DeactivateMembership += OnDeactivateMembership;
         _view.DeleteMembership += OnDeleteMembership;
         _view.NewPayment += OnNewPayment;
         _view.DeletePayment += OnDeletePayment;
         _view.NewCheckin += OnNewCheckin;
         _view.PrintMemberInfo += OnPrintMemberInfo;
         _view.PrintFinancialMovementsReport += OnPrintFinancialMovementsReport;
         _view.PrintReceipt += OnPrintReceipt;
         _view.ShowPersonalTrainingRecord += OnShowPersonalTrainingRecord;
         _view.DeletePersonalTrainingRecord += OnDeletePersonalTrainingRecord;
         _view.PrintPersonalTrainingRecordsReport += OnPrintPersonalTrainingRecordsReport;
         _view.CheckDuplicatedDNI += OnCheckDuplicatedDNI;
         _view.ShowBMICalculator += OnShowBMICalculator;
      }

      private void OnSaveMember(object sender, EventArgs<AfterSaveAction> e)
      {
         using (_unitOfWork = UnitOfWorkFactory.Create())
         {
            if (_isNewMember)
               _member = new Member();
            else
               _member = _unitOfWork.Members.Get(_view.Id.Value);

            _member.FirstName = _view.FirstName;
            _member.DNI = _view.DNI;
            _member.FirstName = _view.FirstName;
            _member.LastName = _view.LastName;
            _member.DateOfBirth = _view.DateOfBirth;
            _member.Gender = _view.Gender;
            _member.Address = _view.Address;
            _member.CityId = _view.City.Id;
            _member.MobilePhoneAreaCode = _view.MobilePhoneAreaCode;
            _member.MobilePhoneNumber = _view.MobilePhoneNumber;
            _member.HomePhone = _view.HomePhone;
            _member.Email = _view.Email;
            _member.Occupation = _view.Occupation;
            _member.Organization = _view.Organization;
            _member.Conditions = _view.Conditions;
            _member.Medicine = _view.Medicine;
            _member.Smoke = _view.Smoke;
            _member.Alcohol = _view.Alcohol;
            _member.Diet = _view.Diet;
            _member.IsStudying = _view.IsStudying;
            _member.IsWorking = _view.IsWorking;
            _member.IsFirstTimeAtGym = _view.IsFirstTimeAtGym;
            _member.OtherSports = _view.OtherSports;
            _member.Lead = _view.Lead;
            _member.UpdatedAt = DateTime.Now;
            _member.ProfilePicturePath = Helper.SavePictureAndGetPath(_view.ProfilePicturePath, Entity.Member, _member.Id);
            _member.ProfilePictureSizeMode = _view.ProfilePictureSizeMode;

            if (_isNewMember)
            {
               _member.JoiningDate = DateTime.Now;
               _unitOfWork.Members.Add(_member);
            }

            ServiceLocator.RunnerService.Run(() =>
            {
               _unitOfWork.Complete();

               if (e.Value == AfterSaveAction.Nothing)
               {
                  ShowMemberData(new MemberViewModel(id: _member.Id));
                  _view.Notify("El miembro se guardó exitosamente", MessageType.Information);
               }
               else if (e.Value == AfterSaveAction.Close)
                  _view.CloseView();
               else
                  _view.InitializeView();
            }, "Ha ocurrido un error al intentar guardar el miembro. Por favor, intenta nuevamente.");
         }
      }

      private void OnDeleteMember()
      {
         if (_view.Id == null)
            return;

         if (_view.Confirm("¿Está seguro que desea eliminar al miembro?"))
         {
            using (_unitOfWork = UnitOfWorkFactory.Create())
            {
               _member = _unitOfWork.Members.Get(_view.Id.Value);
               _unitOfWork.Members.Delete(_member);
               _unitOfWork.Complete();
               _view.CloseView();
            }
         }
      }

      private void OnShowContact(EventArgs<ContactViewModel> e)
      {
         PresenterBuilder<IContactPresenter, IContactView>.Build(e.Value, _member.Id).ShowView();
         RefreshContactList();
      }

      private void OnDeleteContact(int id)
      {
         using (_unitOfWork = UnitOfWorkFactory.Create())
         {
            var contact = _unitOfWork.Contacts.Get(id);
            _unitOfWork.Contacts.Remove(contact);
            _unitOfWork.Complete();
            RefreshContactList();
         }
      }

      private void OnShowNote(EventArgs<NoteViewModel> e)
      {
         PresenterBuilder<IContactPresenter, IContactView>.Build(e.Value, _member.Id).ShowView();
         RefreshNotesList();
      }

      private void OnDeleteNote(int id)
      {
         using (_unitOfWork = UnitOfWorkFactory.Create())
         {
            var note = _unitOfWork.Notes.Get(id);
            _unitOfWork.Notes.Remove(note);
            _unitOfWork.Complete();
            RefreshNotesList();
         }
      }

      private void OnMoreCities()
      {
         var presenter = PresenterBuilder<ICitiesPresenter, ICitiesView>.Build();
         presenter.ShowView();

         if (presenter.SelectedCity != null && _view.Cities.FirstOrDefault(x => x.Id == presenter.SelectedCity.Id) == null)
            _view.AddCity(presenter.SelectedCity);
      }

      private void OnProfilePictureClicked()
      {
         _view.ShowChangeProfilePictureDialog();
      }

      private void OnShowMembership(EventArgs<MembershipViewModel> e)
      {
         PresenterBuilder<IMembershipPresenter, IMembershipView>.Build(e.Value, _member.Id).ShowView();
         RefreshMembershipsList();
         RefreshFinancialMovements();
      }

      private void OnRenewMembership(EventArgs<MembershipViewModel> e)
      {
         var presenter = PresenterBuilder<IMembershipPresenter, IMembershipView>.Build(e.Value);
         presenter.Renew(e.Value);

         RefreshMembershipsList();
         RefreshFinancialMovements();
      }

      private void OnDeactivateMembership(EventArgs<MembershipViewModel> e)
      {
         if (_view.Confirm("¿Está seguro que desea dar de baja la membresía seleccionada?"))
         {
            ServiceLocator.RunnerService.Run(() =>
            {
               using (_unitOfWork = UnitOfWorkFactory.Create())
               {
                  var membership = _unitOfWork.Memberships.Get(e.Value.Id);
                  membership.Status = MembershipStatus.EXPIRED;

                  _unitOfWork.Complete();
                  RefreshMembershipsList();
                  _view.Notify("Membresía dada de baja exitosamente", MessageType.Information);
               }
            });
         }
      }

      private void OnDeleteMembership(int id)
      {
         if (_view.Confirm("¿Está seguro que desea eliminar la membresía seleccionada?"))
         {
            ServiceLocator.RunnerService.Run(() =>
            {
               using (_unitOfWork = UnitOfWorkFactory.Create())
               {
                  var membership = _unitOfWork.Memberships.Get(x => x.Id == id, "Payments");

                  if (membership.Payments.Count > 0)
                  {
                     _view.Notify("No es posible eliminar la membresía ya que existen pagos asociados a la misma", MessageType.Error);
                     return;
                  }

                  _unitOfWork.Memberships.Remove(membership);

                  var financialService = new FinancialService(_unitOfWork);
                  financialService.DeleteMovement(_member.Id, FinancialMovementReference.Membership, membership.Id);

                  _unitOfWork.Complete();
                  RefreshMembershipsList();
                  RefreshFinancialMovements();
                  _view.Notify("Membresía eliminada exitosamente", MessageType.Information);
               }
            }, "Ha ocurrido un error al intentar eliminar la membresía. Por favor, intenta nuevamente.");
         }
      }

      private void OnNewPayment()
      {
         PresenterBuilder<INewPaymentPresenter, INewPaymentView>.Build(_member.Id).ShowView();
         RefreshPaymentsList();
         RefreshFinancialMovements();
      }

      private void OnDeletePayment(int id)
      {
         if (!_view.Confirm("¿Está seguro que desea eliminar el pago seleccionado?"))
            return;

         using (_unitOfWork = UnitOfWorkFactory.Create())
         {
            var payment = _unitOfWork.Payments.Get(x => x.Id == id, "Membership");
            var membership = _unitOfWork.Memberships.Get(x => x.Id == payment.MembershipId, "Payments");

            membership.Payments.Remove(payment);
            _unitOfWork.Payments.Remove(payment);

            if (membership.Payments.Sum(x => x.Amount) < membership.Price)
               membership.IsFullyPaid = false;

            var financialService = new FinancialService(_unitOfWork);
            financialService.DeleteMovement(_member.Id, FinancialMovementReference.Payment, id);

            _unitOfWork.Complete();
            RefreshPaymentsList();
            RefreshFinancialMovements();
            _view.Notify("El pago ha sido eliminado exitosamente", MessageType.Information);
         }
      }

      private void OnNewCheckin()
      {
         var memberViewModel = Mapper.Map<MemberViewModel>(_member);
         PresenterBuilder<ICheckinPresenter, ICheckinView>.Build(memberViewModel).ShowView();

         using (_unitOfWork = UnitOfWorkFactory.Create())
         {
            _view.LastCheckin = _unitOfWork.Members.GetLastCheckin(_member.Id);
            _view.TotalCheckins = _unitOfWork.Members.GetTotalCheckins(_member.Id);
         }
      }

      private void OnPrintMemberInfo()
      {
         var config = new ReportConfigurationViewModel
         {
            ViewText = "Ficha personal",
            Report = Report.MemberInfo,
            DataMember = "Query",
            Parameters = Helper.GetMemberReportParameters(_member.Id)
         };

         PresenterBuilder<IReportPresenter, IReportView>.Build(config).ShowView();
      }

      private void OnPrintFinancialMovementsReport()
      {
         var config = new ReportConfigurationViewModel
         {
            ViewText = "Movimientos financieros",
            Report = Report.FinancialMovements,
            DataMember = "Query",
            Parameters = Helper.GetMemberReportParameters(_member.Id)
         };

         PresenterBuilder<IReportPresenter, IReportView>.Build(config).ShowView();
      }

      private void OnPrintReceipt(int paymentId)
      {
         var config = new ReportConfigurationViewModel
         {
            ViewText = "Recibo de pago",
            Report = Report.Receipt,
            DataMember = "Query",
            Parameters = Helper.GetReceiptReportParameters(paymentId)
         };

         PresenterBuilder<IReportPresenter, IReportView>.Build(config).ShowView();
      }

      private void OnShowPersonalTrainingRecord(EventArgs<PersonalTrainingRecordViewModel> e)
      {
         PresenterBuilder<IPersonalTrainingRecordPresenter, IPersonalTrainingRecordView>.Build(e.Value, _member.Id).ShowView();
         RefreshPersonalTrainingRecordsList();
      }

      private void OnDeletePersonalTrainingRecord(int id)
      {
         using (_unitOfWork = UnitOfWorkFactory.Create())
         {
            var record = _unitOfWork.PersonalTrainingRecords.Get(id);
            _unitOfWork.PersonalTrainingRecords.Remove(record);

            _unitOfWork.Complete();
            RefreshPersonalTrainingRecordsList();
         }
      }

      private void OnPrintPersonalTrainingRecordsReport()
      {
         var config = new ReportConfigurationViewModel
         {
            ViewText = "Personal training",
            Report = Report.PersonalTrainingRecords,
            DataMember = "Query",
            Parameters = Helper.GetMemberReportParameters(_member.Id)
         };

         PresenterBuilder<IReportPresenter, IReportView>.Build(config).ShowView();
      }

      private bool OnCheckDuplicatedDNI()
      {
         using (_unitOfWork = UnitOfWorkFactory.Create())
         {
            var member = _unitOfWork.Members.Find(x => x.DNI == _view.DNI).FirstOrDefault();

            if (member != null)
               if (_view.Id == member.Id)
                  return false;
               else
                  return true;
            else
               return _view.Id != member?.Id;
         }
      }

      private void OnShowBMICalculator()
      {
         PresenterBuilder<IBMICalculatorPresenter, IBMICalculatorView>.Build().ShowView();
      }

      #region Helpers
      private void ShowMemberData(MemberViewModel memberViewModel)
      {
         using (_unitOfWork = UnitOfWorkFactory.Create())
         {
            _member = _unitOfWork.Members.Get(x => x.Id == memberViewModel.Id, "City");

            _view.Id = _member.Id;
            _view.DNI = _member.DNI;
            _view.FirstName = _member.FirstName;
            _view.LastName = _member.LastName;
            _view.DateOfBirth = _member.DateOfBirth;
            _view.Gender = _member.Gender;
            _view.Address = _member.Address;
            _view.City = Mapper.Map<CityViewModel>(_member.City);
            _view.MobilePhoneAreaCode = _member.MobilePhoneAreaCode;
            _view.MobilePhoneNumber = _member.MobilePhoneNumber;
            _view.HomePhone = _member.HomePhone;
            _view.Email = _member.Email;
            _view.Occupation = _member.Occupation;
            _view.Organization = _member.Organization;
            _view.Conditions = _member.Conditions;
            _view.Medicine = _member.Medicine;
            _view.Smoke = _member.Smoke;
            _view.Alcohol = _member.Alcohol;
            _view.Diet = _member.Diet;
            _view.IsStudying = _member.IsStudying;
            _view.IsWorking = _member.IsWorking;
            _view.IsFirstTimeAtGym = _member.IsFirstTimeAtGym;
            _view.OtherSports = _member.OtherSports;
            _view.Lead = _member.Lead;
            _view.JoiningDate = _member.JoiningDate;
            _view.UpdatedAt = _member.UpdatedAt;
            _view.ProfilePicturePath = File.Exists(_member.ProfilePicturePath) ? _member.ProfilePicturePath : null;
            _view.ProfilePictureSizeMode = _member.ProfilePictureSizeMode;
            _view.LastCheckin = _unitOfWork.Members.GetLastCheckin(_member.Id);
            _view.TotalCheckins = _unitOfWork.Members.GetTotalCheckins(_member.Id);
         }

         RefreshMembershipsList();
         RefreshPaymentsList();
         RefreshFinancialMovements();
         RefreshContactList();
         RefreshNotesList();
         RefreshPersonalTrainingRecordsList();

         _view.ViewText = $"{_member.FirstName} {_member.LastName}";
      }

      private void PrepareViewForNewMember()
      {
         _view.ViewText = "Agregar miembro";
      }

      public void LoadRelatedData()
      {
         using (_unitOfWork = UnitOfWorkFactory.Create())
         {
            var cities = new List<City>();
            cities.Add(_unitOfWork.Cities.GetGymCity());
            cities.AddRange(_unitOfWork.Cities.GetCitiesWithMembers());
            cities = cities.Distinct().ToList();

            _view.Cities = Mapper.Map<IList<CityViewModel>>(cities);
         }
      }

      private void RefreshMembershipsList()
      {
         using (_unitOfWork = UnitOfWorkFactory.Create())
         {
            var memberships = _unitOfWork.Memberships.Find(x => x.MemberId == _member.Id, "Training").OrderByDescending(x => x.Id).Take(144).OrderBy(x => x.Status);
            _view.Memberships = Mapper.Map<IEnumerable<MembershipViewModel>>(memberships);
         }
      }

      private void RefreshContactList()
      {
         using (_unitOfWork = UnitOfWorkFactory.Create())
         {
            var contacts = _unitOfWork.Contacts.Find(x => x.MemberId == _view.Id.Value);
            _view.Contacts = Mapper.Map<IEnumerable<ContactViewModel>>(contacts);
         }
      }

      private void RefreshPaymentsList()
      {
         using (_unitOfWork = UnitOfWorkFactory.Create())
         {
            var memberships = _unitOfWork.Memberships.Find(x => x.MemberId == _member.Id, "Payments");
            var sales = _unitOfWork.Sales.Find(x => x.MemberId == _member.Id, "Payments");
            var payments = new List<Payment>();

            foreach (var membership in memberships.Where(x => x.Payments != null))
               payments.AddRange(membership.Payments);

            foreach (var sale in sales.Where(x => x.Payments != null))
               payments.AddRange(sale.Payments);

            _view.Payments = Mapper.Map<IEnumerable<PaymentViewModel>>(payments).OrderByDescending(x => x.Date);
         }
      }

      private void RefreshNotesList()
      {
         using (_unitOfWork = UnitOfWorkFactory.Create())
         {
            var notes = _unitOfWork.Notes.Find(x => x.MemberId == _view.Id.Value);
            _view.Notes = Mapper.Map<IEnumerable<NoteViewModel>>(notes);
         }
      }

      private void RefreshFinancialMovements()
      {
         using (_unitOfWork = UnitOfWorkFactory.Create())
         {
            var last100Movements = _unitOfWork.MemberFinancialMovements.GetLast100(_member.Id);

            if (last100Movements.Count() == 0)
            {
               _view.FinancialMovements = null;
               return;
            }

            var movementsViewModel = Mapper.Map<IEnumerable<MemberFinancialMovementViewModel>>(last100Movements).ToList();
            movementsViewModel = movementsViewModel.OrderByDescending(x => x.Date).ToList();

            var finalBalance = GetFinalBalanceViewModel(last100Movements.First().Balance);
            movementsViewModel.Insert(0, finalBalance);

            var balanceBefore = GetBalanceBeforeViewModel(_unitOfWork.MemberFinancialMovements.GetBalanceBefore(_member.Id, last100Movements.Min(x => x.Id)));
            movementsViewModel.Add(balanceBefore);

            _view.FinancialMovements = movementsViewModel;
            _view.FinancialBalanceSign = finalBalance.Balance > 0 ? "-" : "+";
         }
      }

      private void RefreshPersonalTrainingRecordsList()
      {
         using (_unitOfWork = UnitOfWorkFactory.Create())
         {
            var records = _unitOfWork.PersonalTrainingRecords.Find(x => x.MemberId == _view.Id.Value);
            _view.PersonalTrainingRecords = Mapper.Map<IEnumerable<PersonalTrainingRecordViewModel>>(records);
         }
      }

      private static MemberFinancialMovementViewModel GetBalanceBeforeViewModel(decimal balance)
      {
         var initialBalance = new MemberFinancialMovementViewModel
         {
            Date = null,
            Concept = "Saldo anterior",
            Debit = null,
            Credit = null,
            Balance = balance
         };

         return initialBalance;
      }

      private static MemberFinancialMovementViewModel GetFinalBalanceViewModel(decimal balance)
      {
         var finalBalance = new MemberFinancialMovementViewModel
         {
            Date = null,
            Concept = "Saldo final",
            Debit = null,
            Credit = null,
            Balance = balance
         };

         return finalBalance;
      }
      #endregion
   }
}
