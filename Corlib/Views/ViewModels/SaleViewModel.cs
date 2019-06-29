using System;

namespace Corlib.Views.ViewModels
{
   public class SaleViewModel : ViewModel
   {
      public int Id { get; set; }
      public int Number { get; set; }
      public DateTime Date { get; set; }
      public string MemberName { get; set; }
      public string Summary { get; set; }
      public decimal Amount { get; set; }
   }
}
