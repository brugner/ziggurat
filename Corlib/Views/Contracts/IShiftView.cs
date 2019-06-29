using System;

namespace Corlib.Views.Contracts
{
   public interface IShiftView : IView
   {
      string ViewText { set; }
      int Number { get; set; }
      int[] Days { get; set; }
      DateTime StartTime { get; set; }
      DateTime EndTime { get; set; }
      byte? Quota { get; set; }

      void InitializeView();

      event Action SaveShift;
   }
}
