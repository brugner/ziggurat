using System;
using System.Drawing;

namespace Corlib.Views.ViewModels
{
   public class CheckinViewModel : ViewModel
   {
      public int Id { get; set; }
      public string MemberFullName { get; set; }
      public string TrainingName { get; set; }
      public DateTime Date { get; set; }
      public string ProfilePicturePath { get; set; }
      public Image ProfilePicture { get; set; }
   }
}
