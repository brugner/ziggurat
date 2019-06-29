using System;

namespace Corlib.Views.ViewModels
{
   public class ActiveMembershipViewModel : ViewModel
   {
      public int Id { get; set; }
      public byte LineNumber { get; set; }
      public string TrainingName { get; set; }
      public DateTime StartDate { get; set; }
      public DateTime EndDate { get; set; }
   }
}
