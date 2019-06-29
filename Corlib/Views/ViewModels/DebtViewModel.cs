using System;

namespace Corlib.Views.ViewModels
{
   public class DebtViewModel : ViewModel
   {
      public bool IsSelected { get; set; }
      public int MembershipId { get; set; }
      public int SaleId { get; set; }
      public DateTime Date { get; set; }
      public string Origin { get; set; }
      public string Description { get; set; }
      public decimal Amount { get; set; }
      public decimal DebtAmount { get; set; }
   }
}
