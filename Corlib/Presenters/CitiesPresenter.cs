using AutoMapper;
using Corlib.Core;
using Corlib.Core.Domain;
using Corlib.Factories;
using Corlib.Presenters.Contracts;
using Corlib.Services;
using Corlib.Views.Contracts;
using Corlib.Views.ViewModels;
using System.Collections.Generic;

namespace Corlib.Presenters
{
   public class CitiesPresenter : ICitiesPresenter
   {
      private readonly ICitiesView _view;
      private IUnitOfWork _unitOfWork;
      public CityViewModel SelectedCity { get; set; }

      public CitiesPresenter(ICitiesView view)
      {
         _view = view;
         ServiceLocator.SetView(GetView());

         WireViewEvents();
         RefreshCityList();
      }

      #region ICitiesPresenter
      public void ShowView()
      {
         _view.ShowView();
      }

      public IView GetView()
      {
         return _view;
      }
      #endregion

      private void RefreshCityList()
      {
         using (_unitOfWork = UnitOfWorkFactory.Create())
         {
            var cities = _unitOfWork.Cities.GetAll("State");
            _view.Cities = Mapper.Map<IEnumerable<City>, IEnumerable<CityViewModel>>(cities);
         }
      }

      private void WireViewEvents()
      {
         _view.CitySelected += OnCitySelected;
      }

      private void OnCitySelected()
      {
         SelectedCity = _view.SelectedCity;
         _view.CloseView();
      }
   }
}
