using Corlib.Presenters.Contracts;
using Corlib.Services;
using Corlib.Views.Contracts;

namespace Corlib.Presenters
{
	class StatisticsPresenter : IStatisticsPresenter
	{
		private IStatisticsView _view;

		public StatisticsPresenter(IStatisticsView view)
		{
			_view = view;
			ServiceLocator.SetView(GetView());

			WireViewEvents();
			RefreshQuickStatsData();
			RefreshMemberCharts();
			RefreshCheckinsData();
			RefreshSalesData();
		}

		#region IStatisticsPresenter
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

		}

		private void RefreshQuickStatsData()
		{
			var quickStats = ServiceLocator.StatisticsService.GetQuickStats(
				QuickStatsOption.TotalMembers | QuickStatsOption.ActiveMembers |
				QuickStatsOption.DailyAverageCheckins | QuickStatsOption.MonthlyAverageCheckins |
				QuickStatsOption.MostPopularTraining | QuickStatsOption.MostSoldProduct |
				QuickStatsOption.CheckinsLast30Days | QuickStatsOption.SalesLast30Days |
				QuickStatsOption.PaymentsLast30Days);

			_view.TotalMembers = quickStats.TotalMembers;
			_view.ActiveMembersPercentage = quickStats.ActiveMembersPercentage;
			_view.DailyAverageCheckins = quickStats.DailyAverageCheckins;
			_view.MonthlyAverageCheckins = quickStats.MonthlyAverageCheckins;
			_view.MostPopularTraining = quickStats.MostPopularTraining;
			_view.MostSoldProduct = quickStats.MostSoldProduct;
			_view.CheckinsLast30Days = quickStats.CheckinsLast30Days;
			_view.SalesLast30Days = quickStats.SalesLast30Days;
			_view.PaymentsLast30Days = quickStats.PaymentsLast30Days;
		}

		private void RefreshMemberCharts()
		{
			_view.MembershipsSeriesData = ServiceLocator.StatisticsService.GetMembershipsSeriesData();
			_view.MembersJoiningDateSeriesData = ServiceLocator.StatisticsService.GetMembersJoiningDateSeriesData();
			_view.MembersByGenderSeriesData = ServiceLocator.StatisticsService.GetMembersByGenderSeriesData();
		}

		private void RefreshCheckinsData()
		{
			_view.CheckinsSeriesData = ServiceLocator.StatisticsService.GetCheckinSeriesData(30);
			_view.CheckinsByTrainingSeriesData = ServiceLocator.StatisticsService.GetCheckinsByTrainingSeriesData();
		}

		private void RefreshSalesData()
		{
			_view.SalesByCategorySeriesData = ServiceLocator.StatisticsService.GetSalesByCategorySeriesData();
			_view.SalesAmountLast30DaysSeriesData = ServiceLocator.StatisticsService.GetSalesAmountLastDaysSeriesData(30);
		}
	}
}
