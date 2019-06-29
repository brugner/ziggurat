using AutoMapper;
using Corlib.Config;
using Corlib.Core;
using Corlib.Core.Domain;
using Corlib.Factories;
using Corlib.Presenters.Contracts;
using Corlib.Services;
using Corlib.Views.Contracts;
using Corlib.Views.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Corlib.Presenters
{
	public class MemberDashboardPresenter : IMemberDashboardPresenter
	{
		private IMemberDashboardView _view;
		private IUnitOfWork _unitOfWork;
		private Member _member;
		private Ad _ad;
		private int _dni;

		public MemberDashboardPresenter(IMemberDashboardView view, int dni)
		{
			_view = view;
			_dni = dni;
			ServiceLocator.SetView(GetView());

			WireViewEvents();
			ShowMemberData();
			ShowAd();
			ShowMessages();
		}

		#region IMemberDashboardPresenter
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
			_view.NewCheckin += OnNewCheckin;
		}

		private void OnNewCheckin()
		{
			try
			{
				using (_unitOfWork = UnitOfWorkFactory.Create())
				{
					var checkin = new Checkin();
					var membershipId = _view.ActiveMemberships.Where(x => x.LineNumber == _view.SelectedMembershipLineNumber).FirstOrDefault()?.Id;

					if (!membershipId.HasValue)
					{
						_view.Notify("El número ingresado no se corresponde con ninguna actividad. Por favor, intenta nuevamente.", MessageType.Error);
						return;
					}

					checkin.MembershipId = membershipId.Value;
					checkin.Date = DateTime.Now;

					_unitOfWork.Checkins.Add(checkin);
					_unitOfWork.Complete();
					_view.Notify("Asistencia registrada exitosamente!", MessageType.Information);
					_view.CloseView();
				}
			}
			catch (Exception ex)
			{
				_view.Notify("Ha ocurrido un eror al intentar registrar la asistencia. Por favor, intenta nuevamente.", MessageType.Error);
				ServiceLocator.SentryService.ReportError(ex);
			}
		}

		private void ShowMemberData()
		{
			using (_unitOfWork = UnitOfWorkFactory.Create())
			{
				_member = _unitOfWork.Members.Get(x => x.DNI == _dni && !x.IsDeleted);
				_view.Title = "Bienvenid" + (_member.Gender == "M" ? "o" : "a") + " a " + AppConfig.Parameters.Gym.Name;
				_view.MemberName = _member.FirstName + " " + _member.LastName;
				_view.MemberProfilePicturePath = _member.ProfilePicturePath;
				_view.MemberProfilePictureSizeMode = _member.ProfilePictureSizeMode;
				_view.ActiveMemberships = GetMemberships();

				_view.CheckinsSeriesData = ServiceLocator.StatisticsService.GetCheckinSeriesData(30, _member.Id);
				_view.JoiningDate = _member.JoiningDate.ToString("dddd dd 'de' MMMM 'de' yyyy 'a las' hh:mm");
				_view.TotalCheckinCount = _unitOfWork.Members.GetTotalCheckins(_member.Id);
				_view.LastCheckin = _unitOfWork.Members.GetLastCheckin(_member.Id);
				_view.FavoriteTraining = _unitOfWork.Members.GetFavoriteTraining(_member.Id);
				_view.FavoriteProduct = _unitOfWork.Members.GetFavoriteProduct(_member.Id);

				int days = GetBirthdayDaysCount();
				if (days > 1)
				{
					_view.BirthdayDaysCount = $"Faltan {days} días para  tu cumpleaños ☺";
					_view.IsTodayBirthday = false;
				}
				else if (days == 1)
				{
					_view.BirthdayDaysCount = $"Mañana es tu cumpleaños ☺";
					_view.IsTodayBirthday = false;
				}
				else
				{
					_view.BirthdayDaysCount = "¡Feliz cumpleaños! ☺";
					_view.IsTodayBirthday = true;
				}
			}
		}

		private IEnumerable<ActiveMembershipViewModel> GetMemberships()
		{
			var memberships = _unitOfWork.Memberships.Find(x => x.MemberId == _member.Id && x.Status == MembershipStatus.ACTIVE, "Training").ToList();
			var membershipsToRemove = new List<Membership>();

			foreach (var membership in memberships)
			{
				var startDate = new DateTime(membership.StartDate.Year, membership.StartDate.Month, membership.StartDate.Day);

				if (startDate > DateTime.Today)
					membershipsToRemove.Add(membership);
			}

			foreach (var membershipToRemove in membershipsToRemove)
				memberships.Remove(membershipToRemove);

			var activeMemberships = new List<ActiveMembershipViewModel>();

			for (byte i = 0; i < memberships.Count; i++)
			{
				activeMemberships.Add(new ActiveMembershipViewModel
				{
					Id = memberships[i].Id,
					LineNumber = (byte)(i + 1),
					TrainingName = memberships[i].Training.Name,
					StartDate = memberships[i].StartDate,
					EndDate = memberships[i].EndDate
				});
			}

			return activeMemberships;
		}

		private int GetBirthdayDaysCount()
		{
			var today = DateTime.Today;
			var next = _member.DateOfBirth.AddYears(today.Year - _member.DateOfBirth.Year);

			if (next < today)
				next = next.AddYears(1);

			return (next - today).Days;
		}

		private void ShowAd()
		{
			using (_unitOfWork = UnitOfWorkFactory.Create())
			{
				_ad = _unitOfWork.Ads.Get();

				if (_ad == null)
					return;

				if (DateTime.Today >= _ad.StartDate && DateTime.Today <= _ad.EndDate)
				{
					_view.AdText = _ad.AdText;
					_view.Image1Path = _ad.Image1Path;
					_view.Image1SizeMode = _ad.Image1SizeMode;
					_view.Image2Path = _ad.Image2Path;
					_view.Image2SizeMode = _ad.Image2SizeMode;
					_view.Image3Path = _ad.Image3Path;
					_view.Image3SizeMode = _ad.Image3SizeMode;
				}
			}
		}

		private void ShowMessages()
		{
			using (_unitOfWork = UnitOfWorkFactory.Create())
			{
				var messages = _unitOfWork.Messages.GetUnreadMessagesToMember(_member.Id);

				foreach (var message in messages)
				{
					_view.ShowMessage(Mapper.Map<MessageViewModel>(message));

					var readBy = message.ReadBy?.ToList() ?? new List<int>();
					readBy.Add(_member.Id);
					message.ReadBy = readBy.ToArray();
				}

				_unitOfWork.Complete();
			}
		}
	}
}
