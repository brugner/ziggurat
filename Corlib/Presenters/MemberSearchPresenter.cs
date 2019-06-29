using AutoMapper;
using Corlib.Core;
using Corlib.Core.Domain;
using Corlib.Factories;
using Corlib.Presenters.Contracts;
using Corlib.Services;
using Corlib.Views.Contracts;
using Corlib.Views.ViewModels;
using System.Collections.Generic;

namespace Corlib.Presenters
{
   class MemberSearchPresenter : IMemberSearchPresenter
   {
      private readonly IMemberSearchView _view;
      private IUnitOfWork _unitOfWork;
      public MemberViewModel SelectedMember { get; set; }

      public MemberSearchPresenter(IMemberSearchView view)
      {
         _view = view;
         ServiceLocator.SetView(GetView());

         WireViewEvents();
         ReloadMembersList();
      }

      private void WireViewEvents()
      {
         _view.MemberSelected += OnMemberSelected;
      }

      #region ISearchMemberPresenter
      public void ShowView()
      {
         _view.ShowView();
      }

      public IView GetView()
      {
         return _view;
      }
      #endregion

      private void ReloadMembersList()
      {
         using (_unitOfWork = UnitOfWorkFactory.Create())
         {
            var members = _unitOfWork.Members.Find(x => !x.IsDeleted, "City");
            var membersViewModels = Mapper.Map<IEnumerable<Member>, IEnumerable<MemberViewModel>>(members);
            _view.Members = membersViewModels;
         }
      }

      private void OnMemberSelected()
      {
         SelectedMember = _view.SelectedMember;
         _view.CloseView();
      }
   }
}
