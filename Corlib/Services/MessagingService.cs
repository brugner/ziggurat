using Corlib.Services.Contracts;
using Corlib.Views.Contracts;
using System;

namespace Corlib.Services
{
   class MessagingService : IMessagingService
   {
      private IView _view;

      public MessagingService(IView view)
      {
         _view = view ?? throw new ArgumentNullException("view");
      }

      public void Notify(string message, MessageType messageType)
      {
         _view.Notify(message, messageType);
      }
   }
}
