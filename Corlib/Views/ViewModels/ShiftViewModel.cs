using System;

namespace Corlib.Views.ViewModels
{
   public class ShiftViewModel : ViewModel
   {
      public int Id { get; set; }
      public int Number { get; set; }
      public int[] Days { get; set; }
      public DateTime StartTime { get; set; }
      public DateTime EndTime { get; set; }
      public string DisplayName { get; set; }
      public byte? Quota { get; set; }
      public string TrainingName { get; set; }
      public string DaysNames { get; set; }
   }
}
