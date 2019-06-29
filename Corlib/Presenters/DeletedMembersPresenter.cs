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
   class DeletedMembersPresenter : IDeletedMembersPresenter
   {
      private readonly IDeletedMembersView _view;
      private IUnitOfWork _unitOfWork;

      public DeletedMembersPresenter(IDeletedMembersView view)
      {
         _view = view;
         ServiceLocator.SetView(GetView());

         WireViewEvents();
         RefreshMembersList();
      }

      #region IDeletedMembersPresenter
      public void ShowView()
      {
         _view.ShowView();
      }

      public IView GetView()
      {
         return _view;
      }
      #endregion

      private void WireViewEvents()
      {
         _view.RestoreMember += OnRestoreMember;
      }

      private void OnRestoreMember(int id)
      {
         if (_view.Confirm("¿Esta seguro que desea restaurar el miembro seleccionado?"))
         {
            ServiceLocator.RunnerService.Run(() =>
            {
               using (_unitOfWork = UnitOfWorkFactory.Create())
               {
                  var member = _unitOfWork.Members.Get(id);
                  member.DeletedAt = null;
                  member.IsDeleted = false;

                  _unitOfWork.Complete();
                  RefreshMembersList();
                  _view.Notify("El miembro se restauró exitosamente", MessageType.Information);
               }
            }, "Ha ocurrido un error al intentar restaurar el miembro. Por favor, intente nuevamente");
         }
      }

      #region Helpers
      private void RefreshMembersList()
      {
         using (_unitOfWork = UnitOfWorkFactory.Create())
         {
            var members = _unitOfWork.Members.Find(x => x.IsDeleted, "City");
            var membersViewModels = Mapper.Map<IEnumerable<Member>, IEnumerable<MemberViewModel>>(members);
            _view.Members = membersViewModels;
         }
      }
      #endregion
   }
}
