using System;

namespace Corlib.Views.ViewModels
{
   public class PersonalTrainingRecordViewModel : ViewModel
   {
      public int Id { get; set; }
      public int MemberId { get; set; }
      public DateTime Date { get; set; }
      public int? Weight { get; set; }
      public int? Height { get; set; }
      public int? Neck { get; set; }
      public int? Shoulders { get; set; }
      public int? Chest { get; set; }
      public int? Waist { get; set; }
      public int? Forearms { get; set; }
      public int? Thighs { get; set; }
      public int? Calves { get; set; }
      public int? Biceps { get; set; }
      public int? Buttocks { get; set; }
      public string Comment { get; set; }
   }
}
