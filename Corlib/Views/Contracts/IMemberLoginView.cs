using System;

namespace Corlib.Views.Contracts
{
   public interface IMemberLoginView : IView
   {
      string ViewText { set; }

      event Action<int> Login;

      void HideView();
      void ShowAboutView();
      void ShowErrorMessage(string message);
   }
}
