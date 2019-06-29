using Corlib.Views.ViewModels;
using System;
using System.Collections.Generic;
using System.Data;

namespace Corlib.Views.Contracts
{
   public interface IMemberDashboardView : IView
   {
      string Title { set; }
      string MemberName { set; }
      string MemberProfilePicturePath { set; }
      byte MemberProfilePictureSizeMode { set; }
      IEnumerable<ActiveMembershipViewModel> ActiveMemberships { get; set; }
      string AdText { set; }
      string Image1Path { set; }
      byte Image1SizeMode { set; }
      string Image2Path { set; }
      byte Image2SizeMode { set; }
      string Image3Path { set; }
      byte Image3SizeMode { set; }
      DataTable CheckinsSeriesData { set; }
      string JoiningDate { set; }
      int TotalCheckinCount { set; }
      string LastCheckin { set; }
      string FavoriteTraining { set; }
      string FavoriteProduct { set; }
      string BirthdayDaysCount { set; }
      bool IsTodayBirthday { get; set; }
      byte SelectedMembershipLineNumber { get; }

      void ShowMessage(MessageViewModel messageViewModel);

      event Action NewCheckin;
   }
}
