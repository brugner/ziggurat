using System;

namespace Corlib.Core.Domain
{
   public class Payment
   {
      public int Id { get; set; }
      public int? MembershipId { get; set; }
      public virtual Membership Membership { get; set; }
      public int? SaleId { get; set; }
      public virtual Sale Sale { get; set; }
      public string Concept { get; set; }
      public decimal Amount { get; set; }
      public DateTime Date { get; set; }
      public string Comment { get; set; }
   }
}
