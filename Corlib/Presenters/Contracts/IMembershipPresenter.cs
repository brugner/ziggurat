using Corlib.Views.ViewModels;

namespace Corlib.Presenters.Contracts
{
   interface IMembershipPresenter : IPresenter
   {
      void Renew(MembershipViewModel membershipViewModel);
   }
}
