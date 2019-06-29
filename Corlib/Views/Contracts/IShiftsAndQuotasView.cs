using Corlib.Views.ViewModels;
using System;
using System.Collections.Generic;

namespace Corlib.Views.Contracts
{
   public interface IShiftsAndQuotasView : IView
   {
      IEnumerable<ShiftViewModel> Shifts { get; set; }
      string TrainingName { set; }
      string DaysNames { set; }
      string ShiftTime { set; }
      string Quota { set; }
      string AvailableQuota { set; }
      IEnumerable<MemberViewModel> Members { get; set; }

      event Action<EventArgs<ShiftViewModel>> SelectedShiftChanged;
   }
}
