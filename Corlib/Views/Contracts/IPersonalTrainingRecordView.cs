using System;

namespace Corlib.Views.Contracts
{
   public interface IPersonalTrainingRecordView : IView
   {
      string ViewText { set; }
      DateTime Date { get; set; }
      int? Weight { get; set; }
      int? MemberHeight { get; set; }
      int? Neck { get; set; }
      int? Shoulders { get; set; }
      int? Chest { get; set; }
      int? Waist { get; set; }
      int? Forearms { get; set; }
      int? Thighs { get; set; }
      int? Calves { get; set; }
      int? Biceps { get; set; }
      int? Buttocks { get; set; }
      string Comment { get; set; }

      event Action SaveRecord;
   }
}
