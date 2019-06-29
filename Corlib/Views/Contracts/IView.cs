namespace Corlib.Views.Contracts
{
   public interface IView
   {
      void ShowView();
      void CloseView();
      void Notify(string message, MessageType type);
      bool Confirm(string message);
   }
}
