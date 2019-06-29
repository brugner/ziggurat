using System;

namespace Corlib.Views.ViewModels
{
   public class PaymentViewModel : ViewModel
   {
      public int Id { get; set; }
      public DateTime Date { get; set; }
      public string Concept { get; set; }
      public decimal Amount { get; set; }
      public string Comment { get; set; }
   }
}
