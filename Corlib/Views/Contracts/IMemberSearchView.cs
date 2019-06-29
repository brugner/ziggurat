using Corlib.Views.ViewModels;
using System;
using System.Collections.Generic;

namespace Corlib.Views.Contracts
{
   public interface IMemberSearchView : IView
   {
      IEnumerable<MemberViewModel> Members { get; set; }
      MemberViewModel SelectedMember { get; }

      event Action MemberSelected;
   }
}
