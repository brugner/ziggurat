using Corlib.Views.ViewModels;
using System;
using System.Collections.Generic;

namespace Corlib.Views.Contracts
{
   public interface IParametersView : IView
   {
      string GymName { get; set; }
      string GymAddress { get; set; }
      CityViewModel City { get; set; }
      string GymPhone { get; set; }
      string GymEmail { get; set; }
      string GymFacebook { get; set; }
      string GymTwitter { get; set; }
      string GymInstagram { get; set; }
      string RequiredField { get; set; }
      string InvalidEmailAddress { get; set; }
      string EnterAtLeastAPhone { get; set; }
      string EnterMobilePhoneAreaCode { get; set; }
      string EnterPhoneNumber { get; set; }
      string SelectAtLeastOne { get; set; }
      string Skin { get; set; }
      IList<CityViewModel> Cities { get; set; }

      event Action Save;
   }
}
