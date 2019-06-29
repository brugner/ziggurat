using Corlib.Views.ViewModels;
using System;
using System.Collections.Generic;

namespace Corlib.Views.Contracts
{
   public interface ITrainerView : IView
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
      IList<CityViewModel> Cities { get; set; }
      int? MobilePhoneAreaCode { get; set; }
      long? MobilePhoneNumber { get; set; }
      string HomePhone { get; set; }
      string Email { get; set; }
      DateTime JoiningDate { set; }
      DateTime UpdatedAt { set; }
      string ProfilePicturePath { get; set; }
      byte ProfilePictureSizeMode { get; set; }

      void InitializeView();
      void AddCity(CityViewModel selectedCity);
      void ShowChangeProfilePictureDialog();

      event EventHandler<EventArgs<AfterSaveAction>> SaveTrainer;
      event Action DeleteTrainer;
      event Action MoreCities;
      event Action ProfilePictureClicked;
      event Func<bool> CheckDuplicatedDNI;
   }
}
