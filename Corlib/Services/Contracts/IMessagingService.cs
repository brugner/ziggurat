namespace Corlib.Services.Contracts
{
   public interface IMessagingService
   {
      void Notify(string message, MessageType error);
   }
}
