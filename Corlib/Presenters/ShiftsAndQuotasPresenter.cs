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
   class ShiftsAndQuotasPresenter : IShiftsAndQuotasPresenter
   {
      private readonly IShiftsAndQuotasView _view;
      private IUnitOfWork _unitOfWork;

      public ShiftsAndQuotasPresenter(IShiftsAndQuotasView view)
      {
         _view = view;
         ServiceLocator.SetView(GetView());

         WireViewEvents();
         LoadShifts();
      }

      #region IShiftsAndQuotasPresenter
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

         _view.SelectedShiftChanged += OnSelectedShiftChanged;
      }

      private void OnSelectedShiftChanged(EventArgs<ShiftViewModel> e)
      {
         using (_unitOfWork = UnitOfWorkFactory.Create())
         {
            _view.TrainingName = e.Value.TrainingName;
            _view.DaysNames = e.Value.DaysNames;
            _view.ShiftTime = e.Value.StartTime.ToString("hh:mm") + " - " + e.Value.EndTime.ToString("hh:mm");
            _view.Quota = e.Value.Quota.HasValue ? e.Value.Quota.Value.ToString() : "Libre";
            _view.AvailableQuota = _unitOfWork.Shifts.GetAvailableQuota(e.Value.Id).ToString();

            var memberships = _unitOfWork.Memberships.Find(x => x.ShiftId == e.Value.Id && x.Status == MembershipStatus.ACTIVE, "Member");
            var members = new List<Member>();

            foreach (var membership in memberships)
               members.Add(membership.Member);

            _view.Members = Mapper.Map<IEnumerable<MemberViewModel>>(members);
         }
      }

      #region Helpers
      private void LoadShifts()
      {
         using (_unitOfWork = UnitOfWorkFactory.Create())
         {
            var shifts = _unitOfWork.Shifts.GetAll("Training");
            _view.Shifts = Mapper.Map<IEnumerable<ShiftViewModel>>(shifts);
         }
      }
      #endregion
   }
}
