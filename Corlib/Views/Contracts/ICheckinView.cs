using Corlib.Views.ViewModels;
using System;
using System.Collections.Generic;

namespace Corlib.Views.Contracts
{
   public interface ICheckinView : IView
   {
      MemberViewModel Member { get; set; }
      IEnumerable<MembershipViewModel> Memberships { set; }
      MembershipViewModel CheckedMembership { get; }
      DateTime Date { get; }

      event Action MemberSearch;
      event Action SaveCheckin;
   }
}
