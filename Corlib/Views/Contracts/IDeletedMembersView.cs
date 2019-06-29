using Corlib.Views.ViewModels;
using System;
using System.Collections.Generic;

namespace Corlib.Views.Contracts
{
   public interface IDeletedMembersView : IView
   {
      IEnumerable<MemberViewModel> Members { get; set; }

      event Action<int> RestoreMember;
   }
}
