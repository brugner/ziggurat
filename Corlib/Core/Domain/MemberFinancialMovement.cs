using System;

namespace Corlib.Core.Domain
{
   public class MemberFinancialMovement
   {
      public int Id { get; set; }
      public int MemberId { get; set; }
      public virtual Member Member { get; set; }
      public DateTime Date { get; set; }
      public string Concept { get; set; }
      public decimal Debit { get; set; }
      public decimal Credit { get; set; }
      public decimal Balance { get; set; }
      public int? MembershipId { get; set; }
      public int? SaleId { get; set; }
      public int? PaymentId { get; set; }
   }
}
