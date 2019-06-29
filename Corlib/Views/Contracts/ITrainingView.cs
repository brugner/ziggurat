using Corlib.Views.ViewModels;
using System;
using System.Collections.Generic;

namespace Corlib.Views.Contracts
{
   public interface ITrainingView : IView
   {
      int? Id { get; set; }
      string ViewText { set; }
      string TrainingName { get; set; }
      decimal ClassPrice { get; set; }
      decimal WeekPrice { get; set; }
      decimal MonthPrice { get; set; }
      decimal QuarterPrice { get; set; }
      IList<TrainerViewModel> Trainers { get; set; }
      IList<TrainerViewModel> SelectedTrainers { get; set; }
      IList<ShiftViewModel> Shifts { get; set; }
      DateTime CreatedAt { set; }
      DateTime UpdatedAt { set; }

      void InitializeView();

      event EventHandler<EventArgs<AfterSaveAction>> SaveTraining;
      event Action DeleteTraining;
      event Action<EventArgs<ShiftViewModel>> ShowShift;
      event Action<EventArgs<ShiftViewModel>> RemoveShift;
      event Func<bool> ClosingView;
   }
}
