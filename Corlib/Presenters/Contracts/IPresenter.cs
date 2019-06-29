using Corlib.Views.Contracts;

namespace Corlib.Presenters.Contracts
{
   public interface IPresenter
   {
      void ShowView();
      IView GetView();
   }
}
