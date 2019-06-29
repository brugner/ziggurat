using System;

namespace Corlib.Core.Domain
{
   public class Note
   {
      public int Id { get; set; }
      public int MemberId { get; set; }
      public virtual Member Member { get; set; }
      public string Text { get; set; }
      public DateTime Date { get; set; }
   }
}
