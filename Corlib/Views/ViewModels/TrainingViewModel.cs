using System.Collections.Generic;

namespace Corlib.Views.ViewModels
{
   public class TrainingViewModel : ViewModel
   {
      public int Id { get; set; }
      public string Name { get; set; }
      public decimal ClassPrice { get; set; }
      public decimal WeekPrice { get; set; }
      public decimal MonthPrice { get; set; }
      public decimal QuarterPrice { get; set; }
      public IList<TrainerViewModel> Trainers { get; set; }
      public string TrainersNames { get; set; }
      public string ShiftsSummary { get; set; }
      public IList<ShiftViewModel> Shifts { get; set; }

      public TrainingViewModel()
      {

      }

      public TrainingViewModel(int id)
      {
         Id = id;
      }
   }
}
