using System;

namespace Corlib.Views.ViewModels
{
   public class MemberFinancialMovementViewModel : ViewModel
   {
      public int Id { get; set; }
      public DateTime? Date { get; set; }
      public string Concept { get; set; }
      public decimal? Debit { get; set; }
      public decimal? Credit { get; set; }
      public decimal Balance { get; set; }
   }
}
