using Corlib.Views.ViewModels;
using System;
using System.Collections.Generic;

namespace Corlib.Views.Contracts
{
   public interface IMemberView : IView
   {
      string ViewText { set; }

      int? Id { get; set; }
      int DNI { get; set; }
      string FirstName { get; set; }
      string LastName { get; set; }
      DateTime DateOfBirth { get; set; }
      string Gender { get; set; }
      string Address { get; set; }
      CityViewModel City { get; set; }
      IEnumerable<CityViewModel> Cities { get; set; }
      int? MobilePhoneAreaCode { get; set; }
      long? MobilePhoneNumber { get; set; }
      string HomePhone { get; set; }
      string Email { get; set; }
      string Occupation { get; set; }
      string Organization { get; set; }
      string Conditions { get; set; }
      string Medicine { get; set; }
      bool Smoke { get; set; }
      bool Alcohol { get; set; }
      bool Diet { get; set; }
      bool IsStudying { get; set; }
      bool IsWorking { get; set; }
      bool IsFirstTimeAtGym { get; set; }
      string OtherSports { get; set; }
      string Lead { get; set; }
      DateTime JoiningDate { set; }
      DateTime UpdatedAt { set; }
      string ProfilePicturePath { get; set; }
      byte ProfilePictureSizeMode { get; set; }
      IEnumerable<MembershipViewModel> Memberships { get; set; }
      IEnumerable<ContactViewModel> Contacts { get; set; }
      IEnumerable<PaymentViewModel> Payments { get; set; }
      IEnumerable<NoteViewModel> Notes { get; set; }
      IEnumerable<MemberFinancialMovementViewModel> FinancialMovements { get; set; }
      IEnumerable<PersonalTrainingRecordViewModel> PersonalTrainingRecords { get; set; }
      string FinancialBalanceSign { get; set; }
      string LastCheckin { set; }
      int TotalCheckins { set; }

      void InitializeView();
      void AddCity(CityViewModel selectedCity);
      void ShowChangeProfilePictureDialog();

      event EventHandler<EventArgs<AfterSaveAction>> SaveMember;
      event Action DeleteMember;
      event Action<EventArgs<ContactViewModel>> ShowContact;
      event Action<int> DeleteContact;
      event Action<EventArgs<NoteViewModel>> ShowNote;
      event Action<int> DeleteNote;
      event Action MoreCities;
      event Action ProfilePictureClicked;
      event Action<EventArgs<MembershipViewModel>> ShowMembership;
      event Action<EventArgs<MembershipViewModel>> RenewMembership;
      event Action<EventArgs<MembershipViewModel>> DeactivateMembership;
      event Action<int> DeleteMembership;
      event Action NewPayment;
      event Action<int> DeletePayment;
      event Action NewCheckin;
      event Action PrintMemberInfo;
      event Action PrintFinancialMovementsReport;
      event Action<int> PrintReceipt;
      event Action<EventArgs<PersonalTrainingRecordViewModel>> ShowPersonalTrainingRecord;
      event Action<int> DeletePersonalTrainingRecord;
      event Action PrintPersonalTrainingRecordsReport;
      event Func<bool> CheckDuplicatedDNI;
      event Action ShowBMICalculator;
   }
}
