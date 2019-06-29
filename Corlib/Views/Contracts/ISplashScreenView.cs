using System;

namespace Corlib.Views.Contracts
{
   public interface ISplashScreenView : IView
   {
      event Action ReadyToClose;
   }
}
