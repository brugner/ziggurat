using Corlib.Services.ServiceModels;
using Corlib.Views.ViewModels;
using System.Collections.Generic;
using System.Data;

namespace Corlib.Services.Contracts
{
	public interface IStatisticsService
	{
		DataTable GetCheckinSeriesData(int days);
		DataTable GetCheckinSeriesData(int days, int memberId);
		DataTable GetMembershipsSeriesData();
		IEnumerable<BirthdayViewModel> GetWeekBirthdays();
		QuickStats GetQuickStats(QuickStatsOption options);
		DataTable GetMembersJoiningDateSeriesData();
		DataTable GetMembersByGenderSeriesData();
		DataTable GetCheckinsByTrainingSeriesData();
		DataTable GetSalesByCategorySeriesData();
		DataTable GetSalesAmountLastDaysSeriesData(int days);
	}
}
