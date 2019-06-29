using System;

namespace Corlib.Views.ViewModels
{
   public class NoteViewModel : ViewModel
   {
      public int Id { get; set; }
      public int MemberId { get; set; }
      public string Text { get; set; }
      public DateTime Date { get; set; }
   }
}
