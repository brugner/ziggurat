using System;

namespace Corlib.Views.ViewModels
{
   public class MembershipViewModel : ViewModel
   {
      public int Id { get; set; }
      public string TrainingName { get; set; }
      public DateTime StartDate { get; set; }
      public DateTime EndDate { get; set; }
      public decimal Price { get; set; }
      public byte StatusCode { get; set; }
      public string StatusName { get; set; }
   }
}
