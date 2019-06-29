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
using System.Linq;

namespace Corlib.Presenters
{
   class TrainingPresenter : ITrainingPresenter
   {
      private readonly ITrainingView _view;
      private IUnitOfWork _unitOfWork;
      private Training _training;
      private bool _isNewTraining;
      private bool AreShiftsDirty { get; set; }

      public TrainingPresenter(ITrainingView view, TrainingViewModel trainingViewModel)
      {
         _view = view;
         ServiceLocator.SetView(GetView());

         WireViewEvents();
         LoadRelatedData();
         _view.InitializeView();

         _isNewTraining = trainingViewModel == null;

         if (_isNewTraining)
            PrepareViewForNewTraining();
         else
            ShowTrainingData(trainingViewModel);
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
         _view.SaveTraining += OnSaveTraining;
         _view.DeleteTraining += OnDeleteTraining;
         _view.ShowShift += OnShowShift;
         _view.RemoveShift += OnRemoveShift;
         _view.ClosingView += OnClosingView;
      }

      private void OnSaveTraining(object sender, EventArgs<AfterSaveAction> e)
      {
         using (_unitOfWork = UnitOfWorkFactory.Create())
         {
            if (_isNewTraining)
               _training = new Training();
            else
               _training = _unitOfWork.Trainings.Get(x => x.Id == _view.Id.Value, "Trainers", "Shifts");

            _training.Name = _view.TrainingName;
            _training.ClassPrice = _view.ClassPrice;
            _training.WeekPrice = _view.WeekPrice;
            _training.MonthPrice = _view.MonthPrice;
            _training.QuarterPrice = _view.QuarterPrice;

            // agrega trainers segun la vista
            foreach (var trainer in _view.SelectedTrainers)
               if (!_training.Trainers.Any(x => x.Id == trainer.Id))
                  _training.Trainers.Add(_unitOfWork.Trainers.Get(trainer.Id));

            // quita trainers segun la vista
            var removedTrainers = new List<Trainer>();
            foreach (var trainer in _training.Trainers)
               if (!_view.SelectedTrainers.Any(x => x.Id == trainer.Id))
                  removedTrainers.Add(trainer);

            foreach (var trainer in removedTrainers)
               _training.Trainers.Remove(trainer);

            // agrega shifts segun la vista
            foreach (var shiftViewModel in _view.Shifts)
            {
               var shift = _unitOfWork.Shifts.Get(shiftViewModel.Id);
               var isNew = false;

               if (shift == null)
               {
                  isNew = true;
                  shift = new Shift();
               }

               shift.Number = shiftViewModel.Number;
               shift.Days = shiftViewModel.Days;
               shift.StartTime = shiftViewModel.StartTime;
               shift.EndTime = shiftViewModel.EndTime;
               shift.Quota = shiftViewModel.Quota;

               if (isNew)
               {
                  _unitOfWork.Shifts.Add(shift);
                  _training.Shifts.Add(shift);
               }
            }

            _training.UpdatedAt = DateTime.Now;

            if (_isNewTraining)
            {
               _training.CreatedAt = DateTime.Now;
               _unitOfWork.Trainings.Add(_training);
            }

            ServiceLocator.RunnerService.Run(() =>
            {
               _unitOfWork.Complete();
               AreShiftsDirty = false;

               if (e.Value == AfterSaveAction.Nothing)
               {
                  ShowTrainingData(new TrainingViewModel(id: _training.Id));
                  _view.Notify("La actividad se guardó exitosamente", MessageType.Information);
               }
               else if (e.Value == AfterSaveAction.Close)
                  _view.CloseView();
               else
                  _view.InitializeView();
            });
         }
      }

      private void OnDeleteTraining()
      {
         if (_view.Id == null)
            return;

         if (_view.Confirm("¿Está seguro que desea eliminar la actividad?"))
         {
            using (_unitOfWork = UnitOfWorkFactory.Create())
            {
               _training = _unitOfWork.Trainings.Get(_view.Id.Value);
               _unitOfWork.Trainings.Delete(_training);
               _unitOfWork.Complete();
               _view.CloseView();
            }
         }
      }

      private void OnShowShift(EventArgs<ShiftViewModel> e)
      {
         var presenter = PresenterBuilder<IShiftPresenter, IShiftView>.Build(e.Value, _view.Id);
         presenter.ShowView();

         if (presenter?.SavedShift.Id == 0)
         {
            var shifts = _view.Shifts;
            if (shifts == null) shifts = new List<ShiftViewModel>();
            shifts.Add(presenter.SavedShift);
            _view.Shifts = shifts;
         }

         _view.Shifts = _view.Shifts?.Distinct().ToList();
         AreShiftsDirty = presenter.IsDirty;
      }

      private void OnRemoveShift(EventArgs<ShiftViewModel> e)
      {

         if (!_view.Confirm("¿Esta seguro que desea eliminar el turno seleccionado?"))
            return;

         ServiceLocator.RunnerService.Run(() =>
         {
            if (e.Value.Id == 0)
            {
               _view.Shifts.Remove(e.Value);
               return;
            }

            using (_unitOfWork = UnitOfWorkFactory.Create())
            {
               var memberships = _unitOfWork.Memberships.Find(x => x.ShiftId == e.Value.Id);

               if (memberships.Count() > 0)
               {
                  _view.Notify("No es posible eliminar este turno ya que posee membresías asociadas.", MessageType.Warning);
                  return;
               }

               var shift = _unitOfWork.Shifts.Get(e.Value.Id);
               _unitOfWork.Shifts.Remove(shift);

               var training = _unitOfWork.Trainings.Get(_training.Id);
               training.Shifts.Remove(shift);

               _unitOfWork.Complete();
               _view.Shifts = Mapper.Map<IList<ShiftViewModel>>(_unitOfWork.Shifts.Find(x => x.TrainingId == _training.Id));
               _view.Notify("El turno se eliminó exitosamente", MessageType.Information);
            }
         });
      }

      private bool OnClosingView()
      {
         if (_view.Shifts == null || _view.Shifts.Count == 0)
            return true;

         if (AreShiftsDirty)
            return _view.Confirm("Ha modificado uno o más turnos de esta actividad. Si cierra la ventana sin guardar, estos cambios se perderán.\n\n¿Está seguro que desea salir?");
         else
            return true;
      }

      #region Helpers
      public void LoadRelatedData()
      {
         using (_unitOfWork = UnitOfWorkFactory.Create())
         {
            var trainers = _unitOfWork.Trainers.Find(x => !x.IsDeleted);
            _view.Trainers = Mapper.Map<IList<TrainerViewModel>>(trainers);
         }
      }

      private void PrepareViewForNewTraining()
      {
         _view.ViewText = "Agregar actividad";
      }

      private void ShowTrainingData(TrainingViewModel trainingViewModel)
      {
         using (_unitOfWork = UnitOfWorkFactory.Create())
         {
            _training = _unitOfWork.Trainings.Get(x => x.Id == trainingViewModel.Id, "Trainers", "Shifts");
         }

         _view.Id = _training.Id;
         _view.TrainingName = _training.Name;
         _view.ClassPrice = _training.ClassPrice;
         _view.WeekPrice = _training.WeekPrice;
         _view.MonthPrice = _training.MonthPrice;
         _view.QuarterPrice = _training.QuarterPrice;
         _view.SelectedTrainers = Mapper.Map<IList<TrainerViewModel>>(_training.Trainers);
         _view.Shifts = Mapper.Map<IList<ShiftViewModel>>(_training.Shifts);
         _view.CreatedAt = _training.CreatedAt;
         _view.UpdatedAt = _training.UpdatedAt;

         _view.ViewText = $"{_training.Name}";
      }
      #endregion
   }
}
