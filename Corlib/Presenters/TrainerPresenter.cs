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
   class TrainerPresenter : ITrainerPresenter
   {
      private readonly ITrainerView _view;
      private IUnitOfWork _unitOfWork;
      private Trainer _trainer;
      private bool _isNewTrainer;

      public TrainerPresenter(ITrainerView view, TrainerViewModel trainerViewModel)
      {
         _view = view;
         ServiceLocator.SetView(GetView());

         WireViewEvents();
         LoadRelatedData();
         _view.InitializeView();

         _isNewTrainer = trainerViewModel == null;

         if (_isNewTrainer)
            PrepareViewForNewTrainer();
         else
            ShowTrainerData(trainerViewModel);
      }

      #region ITrainerPresenter
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
         _view.SaveTrainer += OnSaveTrainer;
         _view.DeleteTrainer += OnDeleteTrainer;
         _view.MoreCities += OnMoreCities;
         _view.ProfilePictureClicked += OnProfilePictureClicked;
         _view.CheckDuplicatedDNI += OnCheckDuplicatedDNI;
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

      private void PrepareViewForNewTrainer()
      {
         _view.ViewText = "Agregar entrenador";
      }

      private void ShowTrainerData(TrainerViewModel trainerViewModel)
      {
         using (_unitOfWork = UnitOfWorkFactory.Create())
         {
            _trainer = _unitOfWork.Trainers.Get(x => x.Id == trainerViewModel.Id, "City");
         }

         _view.Id = _trainer.Id;
         _view.DNI = _trainer.DNI;
         _view.FirstName = _trainer.FirstName;
         _view.LastName = _trainer.LastName;
         _view.DateOfBirth = _trainer.DateOfBirth;
         _view.Gender = _trainer.Gender;
         _view.Address = _trainer.Address;
         _view.City = Mapper.Map<CityViewModel>(_trainer.City);
         _view.MobilePhoneAreaCode = _trainer.MobilePhoneAreaCode;
         _view.MobilePhoneNumber = _trainer.MobilePhoneNumber;
         _view.HomePhone = _trainer.HomePhone;
         _view.Email = _trainer.Email;
         _view.JoiningDate = _trainer.JoiningDate;
         _view.UpdatedAt = _trainer.UpdatedAt;
         _view.ProfilePicturePath = File.Exists(_trainer.ProfilePicturePath) ? _trainer.ProfilePicturePath : null;
         _view.ProfilePictureSizeMode = _trainer.ProfilePictureSizeMode;

         _view.ViewText = $"{_trainer.FirstName} {_trainer.LastName}";
      }

      private void OnSaveTrainer(object sender, EventArgs<AfterSaveAction> e)
      {
         using (_unitOfWork = UnitOfWorkFactory.Create())
         {
            if (_isNewTrainer)
               _trainer = new Trainer();
            else
               _trainer = _unitOfWork.Trainers.Get(_view.Id.Value);

            _trainer.FirstName = _view.FirstName;
            _trainer.DNI = _view.DNI;
            _trainer.FirstName = _view.FirstName;
            _trainer.LastName = _view.LastName;
            _trainer.DateOfBirth = _view.DateOfBirth;
            _trainer.Gender = _view.Gender;
            _trainer.Address = _view.Address;
            _trainer.CityId = _view.City.Id;
            _trainer.MobilePhoneAreaCode = _view.MobilePhoneAreaCode;
            _trainer.MobilePhoneNumber = _view.MobilePhoneNumber;
            _trainer.HomePhone = _view.HomePhone;
            _trainer.Email = _view.Email;
            _trainer.UpdatedAt = DateTime.Now;
            _trainer.ProfilePicturePath = Helper.SavePictureAndGetPath(_view.ProfilePicturePath, Entity.Trainer, _trainer.Id);
            _trainer.ProfilePictureSizeMode = _view.ProfilePictureSizeMode;

            if (_isNewTrainer)
            {
               _trainer.JoiningDate = DateTime.Now;
               _unitOfWork.Trainers.Add(_trainer);
            }

            ServiceLocator.RunnerService.Run(() =>
            {
               _unitOfWork.Complete();

               if (e.Value == AfterSaveAction.Nothing)
               {
                  ShowTrainerData(new TrainerViewModel(id: _trainer.Id));
                  _view.Notify("El entrenador se guardó exitosamente", MessageType.Information);
               }
               else if (e.Value == AfterSaveAction.Close)
                  _view.CloseView();
               else
                  _view.InitializeView();
            }, "Ha ocurrido un error al intentar guardar el entrenador. Por favor, intenta nuevamente.");
         }
      }

      private void OnDeleteTrainer()
      {
         if (_view.Id == null)
            return;

         if (_view.Confirm("¿Está seguro que desea eliminar al entrenador?"))
         {
            using (_unitOfWork = UnitOfWorkFactory.Create())
            {
               _trainer = _unitOfWork.Trainers.Get(_view.Id.Value);
               _unitOfWork.Trainers.Delete(_trainer);
               _unitOfWork.Complete();
               _view.CloseView();
            }
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

      private bool OnCheckDuplicatedDNI()
      {
         using (_unitOfWork = UnitOfWorkFactory.Create())
         {
            var trainer = _unitOfWork.Trainers.Find(x => x.DNI == _view.DNI).FirstOrDefault();

            if (trainer != null)
               if (_view.Id == trainer.Id)
                  return false;
               else
                  return true;
            else
               return _view.Id != trainer?.Id;
         }
      }
   }
}
