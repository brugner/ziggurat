using Corlib.Views.ViewModels;
using System;
using System.Collections.Generic;

namespace Corlib.Views.Contracts
{
   public interface IMessagesView : IView
   {
      IEnumerable<MessageViewModel> Messages { get; set; }

      void InitializeView();

      event EventHandler<EventArgs<MessageViewModel>> ShowMessage;
   }
}
