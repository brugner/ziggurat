using Corlib.Views.ViewModels;
using System;
using System.Collections.Generic;

namespace Corlib.Views.Contracts
{
   public interface IMessageView : IView
   {
      string ViewText { set; }
      string Subject { get; set; }
      string MessageBody { get; set; }
      IEnumerable<MemberViewModel> Recipients { get; set; }
      DateTime Date { set; }

      void InitializeView();
      void DisableFields();

      event Action AddRecipient;
      event Action AddAllRecipients;
      event Action RemoveAllRecipients;
      event Action<EventArgs<MemberViewModel>> RemoveOneRecipient;
      event Action SendMessage;
   }
}
