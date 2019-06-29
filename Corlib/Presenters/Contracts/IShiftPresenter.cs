using Corlib.Views.ViewModels;

namespace Corlib.Presenters.Contracts
{
   interface IShiftPresenter : IPresenter
   {
      ShiftViewModel SavedShift { get; set; }
      bool IsDirty { get; set; }
   }
}
