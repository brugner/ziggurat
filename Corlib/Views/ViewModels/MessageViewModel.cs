using System;

namespace Corlib.Views.ViewModels
{
   public class MessageViewModel : ViewModel
   {
      public int Id { get; set; }
      public string Subject { get; set; }
      public int[] RecipientsIds { get; set; }
      public string RecipientsNames { get; set; }
      public string Body { get; set; }
      public DateTime Date { get; set; }
      public int[] ReadByIds { get; set; }
      public string ReadByNames { get; set; }
   }
}
