using Corlib.Views.ViewModels;
using System;
using System.Collections.Generic;

namespace Corlib.Views.Contracts
{
   public interface ICitiesView : IView
   {
      IEnumerable<CityViewModel> Cities { get; set; }
      CityViewModel SelectedCity { get; }

      event Action CitySelected;
   }
}
