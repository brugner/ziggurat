using System;

namespace Corlib.Views.Contracts
{
   public interface INoteView : IView
   {
      string ViewText { set; }

      int Id { get; set; }
      string NoteText { get; set; }
      DateTime Date { set; }

      event Action SaveNote;
   }
}
