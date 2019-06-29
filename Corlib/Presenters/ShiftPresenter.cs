using Corlib.Core;
using Corlib.Factories;
using Corlib.Presenters.Contracts;
using Corlib.Services;
using Corlib.Views.Contracts;
using Corlib.Views.ViewModels;
using System.Linq;

namespace Corlib.Presenters
{
   class ShiftPresenter : IShiftPresenter
   {
      private readonly IShiftView _view;
      private IUnitOfWork _unitOfWork;
      private bool _isNewShift;
      private int? _trainingId;

      public ShiftPresenter(IShiftView view, ShiftViewModel shiftViewModel, int? trainingId)
      {
         _view = view;
         _isNewShift = shiftViewModel == null;
         SavedShift = shiftViewModel;
         _trainingId = trainingId;
         ServiceLocator.SetView(GetView());

         WireViewEvents();
         _view.InitializeView();

         if (_isNewShift)
            PrepareViewForNewShift();
         else
            ShowShiftData(shiftViewModel);
      }

      #region IShiftPresenter
      public ShiftViewModel SavedShift { get; set; }
      public bool IsDirty { get; set; }

      public void ShowView()
      {
         _view.ShowView();
      }

      public IView GetView()
      {
         return _view;
      }
      #endregion

      private void ShowShiftData(ShiftViewModel shiftViewModel)
      {
         using (_unitOfWork = UnitOfWorkFactory.Create())
         {
            _view.Number = shiftViewModel.Number;
            _view.Days = shiftViewModel.Days;
            _view.StartTime = shiftViewModel.StartTime;
            _view.EndTime = shiftViewModel.EndTime;
            _view.Quota = shiftViewModel.Quota;

            _view.ViewText = $"Turno #{shiftViewModel.Number}";
         }
      }

      private void PrepareViewForNewShift()
      {
         _view.ViewText = "Agregar turno";
         _view.Number = GetShiftNumber();
      }

      private void WireViewEvents()
      {
         _view.SaveShift += OnSaveShift;
      }

      private void OnSaveShift()
      {
         using (_unitOfWork = UnitOfWorkFactory.Create())
         {
            if (_isNewShift)
               SavedShift = new ShiftViewModel();

            SavedShift.Number = _view.Number;
            SavedShift.Days = _view.Days;
            SavedShift.StartTime = _view.StartTime;
            SavedShift.EndTime = _view.EndTime;

            if (!_isNewShift) // controla que el nuevo cupo sea igual o mayor a la cantidad de miembros que ya hay anotados
            {
               var currentMembersCount = GetCurrentMembersCount();

               if (_view.Quota < currentMembersCount)
               {
                  _view.Notify($"No es posible seleccionar un cupo de {_view.Quota} porque actualmente hay {currentMembersCount} miembros anotados en este turno.", MessageType.Warning);
                  return;
               }
               else
                  SavedShift.Quota = _view.Quota;
            }

            SavedShift.DisplayName = Helper.GetShiftDisplayName(_view.Number, _view.Days, _view.StartTime, _view.EndTime, _view.Quota);

            IsDirty = true;
            _view.CloseView();
         }
      }

      private byte GetCurrentMembersCount()
      {
         using (_unitOfWork = UnitOfWorkFactory.Create())
         {
            return _unitOfWork.Shifts.GetCurrentMembersCount(SavedShift.Id);
         }
      }

      private int GetShiftNumber()
      {
         if (_trainingId == null)
            return 1;

         using (_unitOfWork = UnitOfWorkFactory.Create())
         {
            var shifts = _unitOfWork.Shifts.Find(x => x.TrainingId == _trainingId).ToList();

            if (shifts.Count == 0)
               return 1;

            return shifts.Max(x => x.Number) + 1;
         }
      }
   }
}
