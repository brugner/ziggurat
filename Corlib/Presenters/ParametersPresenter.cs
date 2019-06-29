using AutoMapper;
using Corlib.Core;
using Corlib.Core.Domain;
using Corlib.Factories;
using Corlib.Presenters.Contracts;
using Corlib.Services;
using Corlib.Views.Contracts;
using Corlib.Views.ViewModels;
using System.Collections.Generic;
using System.Linq;

namespace Corlib.Presenters
{
   class ParametersPresenter : IParametersPresenter
   {
      private readonly IParametersView _view;
      private IUnitOfWork _unitOfWork;
      private Parameter _parameters;

      public ParametersPresenter(IParametersView view)
      {
         _view = view;
         ServiceLocator.SetView(GetView());

         WireViewEvents();
         ShowData();
      }

      #region IParametersPresenter
      public bool ParametersChanged { get; set; }

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
         _view.Save += OnSave;
      }

      private void OnSave()
      {
         using (_unitOfWork = UnitOfWorkFactory.Create())
         {
            _parameters = _unitOfWork.Parameters.Get();
            _parameters.GymName = _view.GymName;
            _parameters.GymAddress = _view.GymAddress;
            _parameters.GymCityId = _view.City.Id;
            _parameters.GymPhone = _view.GymPhone;
            _parameters.GymEmail = _view.GymEmail;
            _parameters.GymFacebook = _view.GymFacebook;
            _parameters.GymTwitter = _view.GymTwitter;
            _parameters.GymInstagram = _view.GymInstagram;
            _parameters.RequiredField = _view.RequiredField;
            _parameters.InvalidEmailAddress = _view.InvalidEmailAddress;
            _parameters.EnterAtLeastAPhone = _view.EnterAtLeastAPhone;
            _parameters.EnterMobilePhoneAreaCode = _view.EnterMobilePhoneAreaCode;
            _parameters.EnterPhoneNumber = _view.EnterPhoneNumber;
            _parameters.SelectAtLeastOne = _view.SelectAtLeastOne;
            _parameters.Skin = _view.Skin;
            _unitOfWork.Complete();

            ParametersChanged = true;
            _view.CloseView();
         }
      }

      private void ShowData()
      {
         using (_unitOfWork = UnitOfWorkFactory.Create())
         {
            _parameters = _unitOfWork.Parameters.Get();
            _view.GymName = _parameters.GymName;

            var cities = new List<City>();
            cities.Add(_unitOfWork.Cities.GetGymCity());
            cities.AddRange(_unitOfWork.Cities.GetCitiesWithMembers());
            cities = cities.Distinct().ToList();

            _view.Cities = Mapper.Map<IList<CityViewModel>>(cities);
            _view.City = Mapper.Map<CityViewModel>(_unitOfWork.Cities.Get(_parameters.GymCityId));

            _view.GymAddress = _parameters.GymAddress;
            _view.GymPhone = _parameters.GymPhone;
            _view.GymEmail = _parameters.GymEmail;
            _view.GymFacebook = _parameters.GymFacebook;
            _view.GymTwitter = _parameters.GymTwitter;
            _view.GymInstagram = _parameters.GymInstagram;

            _view.RequiredField = _parameters.RequiredField;
            _view.InvalidEmailAddress = _parameters.InvalidEmailAddress;
            _view.EnterAtLeastAPhone = _parameters.EnterAtLeastAPhone;
            _view.EnterMobilePhoneAreaCode = _parameters.EnterMobilePhoneAreaCode;
            _view.EnterPhoneNumber = _parameters.EnterPhoneNumber;
            _view.SelectAtLeastOne = _parameters.SelectAtLeastOne;
            _view.Skin = _parameters.Skin;
         }
      }
   }
}
