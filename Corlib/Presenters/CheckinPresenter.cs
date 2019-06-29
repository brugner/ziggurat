using AutoMapper;
using Corlib.Builders;
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
   class CheckinPresenter : ICheckinPresenter
   {
      private ICheckinView _view;
      private IUnitOfWork _unitOfWork;
      private MemberViewModel _memberViewModel;

      public CheckinPresenter(ICheckinView view, MemberViewModel viewModel)
      {
         _view = view;
         _memberViewModel = viewModel;
         ServiceLocator.SetView(GetView());

         WireViewEvents();
         LoadViewData();
      }

      #region ICheckinPresenter
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
         _view.MemberSearch += OnMemberSearch;
         _view.SaveCheckin += OnSaveCheckin;
      }

      private void OnSaveCheckin()
      {
         if (!_view.Confirm("¿Está seguro que desea registrar la asistencia?"))
            return;

         ServiceLocator.RunnerService.Run(() =>
         {
            using (_unitOfWork = UnitOfWorkFactory.Create())
            {
               var checkin = new Checkin
               {
                  MembershipId = _view.CheckedMembership.Id,
                  Date = _view.Date
               };

               _unitOfWork.Checkins.Add(checkin);
               _unitOfWork.Complete();
               _view.Notify("La asistencia se ha registrado correctamente", MessageType.Information);
               _view.CloseView();
            }
         }, "Ha ocurrido un error al intentar registrar la asistencia. Por favor, intente nuevamente.");
      }

      private void OnMemberSearch()
      {
         var presenter = PresenterBuilder<IMemberSearchPresenter, IMemberSearchView>.Build();
         presenter.ShowView();

         _memberViewModel = presenter.SelectedMember;
         LoadViewData();
      }

      private void LoadViewData()
      {
         if (_memberViewModel == null)
         {
            ClearView();
            return;
         }

         _view.Member = _memberViewModel;
         _view.Memberships = GetMemberships();
      }

      private IEnumerable<MembershipViewModel> GetMemberships()
      {
         using (_unitOfWork = UnitOfWorkFactory.Create())
         {
            var memberships = _unitOfWork.Memberships.Find(x => x.MemberId == _memberViewModel.Id && x.Status == MembershipStatus.ACTIVE, "Training");
            return Mapper.Map<IEnumerable<MembershipViewModel>>(memberships);
         }
      }

      private void ClearView()
      {
         _view.Member = null;
         _view.Memberships = null;
      }
   }
}
