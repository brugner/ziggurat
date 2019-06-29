using System;
using System.Collections.Generic;

namespace Corlib.Core.Domain
{
   public class Sale
   {
      public int Id { get; set; }
      public int Number { get; set; }
      public int MemberId { get; set; }
      public Member Member { get; set; }
      public DateTime Date { get; set; }
      public virtual ICollection<SaleItem> SaleItems { get; set; }
      public string Comment { get; set; }
      public bool IsFullyPaid { get; set; }
      public virtual ICollection<Payment> Payments { get; set; }
   }
}
