using System.Data;

namespace Corlib.Views.Contracts
{
	public interface IStatisticsView : IView
	{
		int TotalMembers { set; }
		decimal ActiveMembersPercentage { set; }
		decimal DailyAverageCheckins { set; }
		decimal MonthlyAverageCheckins { set; }
		string MostPopularTraining { set; }
		string MostSoldProduct { set; }
		int CheckinsLast30Days { set; }
		int SalesLast30Days { set; }
		decimal PaymentsLast30Days { set; }
		DataTable MembershipsSeriesData { set; }
		DataTable MembersJoiningDateSeriesData { set; }
		DataTable MembersByGenderSeriesData { set; }
		DataTable CheckinsSeriesData { set; }
		DataTable CheckinsByTrainingSeriesData { set; }
		DataTable SalesByCategorySeriesData { set; }
		DataTable SalesAmountLast30DaysSeriesData { set; }
	}
}
