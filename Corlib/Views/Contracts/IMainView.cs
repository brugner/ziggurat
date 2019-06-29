using Corlib.Views.ViewModels;
using System;
using System.Collections.Generic;
using System.Data;

namespace Corlib.Views.Contracts
{
	public interface IMainView : IView
	{
		string ViewText { set; }
		string Username { set; }
		IEnumerable<MemberViewModel> Members { get; set; }
		string SelectedMemberFullName { set; }
		string SelectedMemberDNI { set; }
		string SelectedMemberAddress { set; }
		string SelectedMemberMobilePhone { set; }
		string SelectedMemberProfilePicturePath { set; }
		byte SelectedMemberProfilePictureSizeMode { set; }
		IEnumerable<MembershipViewModel> SelectedMemberActiveMemberships { set; }
		string SelectedMemberLastCheckin { set; }
		int SelectedMemberTotalCheckins { set; }
		IEnumerable<TrainerViewModel> Trainers { get; set; }
		IEnumerable<TrainingViewModel> Trainings { get; set; }
		IEnumerable<CheckinViewModel> Checkins { get; set; }
		IEnumerable<ProductViewModel> Products { get; set; }
		IEnumerable<SaleViewModel> Sales { get; set; }
		DataTable CheckinsSeriesData { set; }
		DataTable MembershipsSeriesData { set; }
		int TotalMembers { set; }
		decimal ActiveMembers { set; }
		decimal DailyAverageCheckins { set; }
		decimal MonthlyAverageCheckins { set; }
		string MostPopularTraining { set; }
		string MostSoldProduct { set; }
		IEnumerable<BirthdayViewModel> WeekBirthdays { set; }
		string StatusBarMessage { set; }

		event EventHandler<EventArgs<MemberViewModel>> SelectedMemberChanged;
		event Action<EventArgs<MemberViewModel>> ShowMember;
		event Action<EventArgs<MemberViewModel>> DeleteMember;
		event Action<EventArgs<ProductViewModel>> ShowProduct;
		event Action<EventArgs<ProductViewModel>> DeleteProduct;
		event Action<EventArgs<TrainerViewModel>> ShowTrainer;
		event Action<EventArgs<TrainerViewModel>> DeleteTrainer;
		event Action<EventArgs<TrainingViewModel>> ShowTraining;
		event Action<EventArgs<TrainingViewModel>> DeleteTraining;
		event Action<EventArgs<MemberViewModel>> NewCheckin;
		event Action<int> DeleteCheckin;
		event Action RefreshDashboardData;
		event Action RefreshMembers;
		event Action RefreshCheckins;
		event Action ShowMessages;
		event Action ShowAdConfiguration;
		event Action<EventArgs<MemberViewModel>> NewMessageToMember;
		event Action ShowParameters;
		event Func<bool> ViewClosing;
		event Action ShowProductTypes;
		event Action NewSale;
		event Action ShowShiftsAndQuotas;
		event Action ShowReports;
		event Action PrintProductsReport;
		event Action<int> PrintMemberInfoReport;
		event Action PrintMembersReport;
		event Action ShowDeletedMembers;
		event Action ShowDatabaseBackupRecords;
		event Action ShowIMCCalculator;
		event Action ViewLoaded;
		event Action ShowHelp;
		event Action ShowUserProfile;
		event Action ShowStatistics;
	}
}
