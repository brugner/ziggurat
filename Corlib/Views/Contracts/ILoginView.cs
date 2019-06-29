using Corlib.Views.ViewModels;
using System;

namespace Corlib.Views.Contracts
{
   public interface ILoginView : IView
   {
      string LoginResultMessage { get; set; }

      void HideView();

      event Action<EventArgs<UserViewModel>> Login;
   }
}
