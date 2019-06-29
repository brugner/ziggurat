using Corlib.Views.ViewModels;

namespace Corlib.Presenters.Contracts
{
   interface IMemberSearchPresenter : IPresenter
   {
      MemberViewModel SelectedMember { get; }
   }
}
