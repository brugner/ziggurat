using System;

namespace Corlib.Views.ViewModels
{
   public class MemberViewModel : ViewModel
   {
      public int Id { get; internal set; }
      public string FullName { get; internal set; }
      public int DNI { get; internal set; }
      public int Age { get; internal set; }
      public string MobilePhone { get; internal set; }
      public string Address { get; set; }
      public string CityName { get; internal set; }
      public string ProfilePicturePath { get; internal set; }
      public byte ProfilePictureSizeMode { get; internal set; }
      public DateTime DeletedAt { get; internal set; }

      public MemberViewModel()
      {

      }

      public MemberViewModel(int id)
      {
         Id = id;
      }
   }
}
