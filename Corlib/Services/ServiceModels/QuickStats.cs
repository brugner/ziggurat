namespace Corlib.Services.ServiceModels
{
	public class QuickStats
	{
		public int TotalMembers { get; internal set; }
		public decimal ActiveMembersPercentage { get; internal set; }
		public decimal DailyAverageCheckins { get; internal set; }
		public decimal MonthlyAverageCheckins { get; internal set; }
		public string MostPopularTraining { get; internal set; }
		public string MostSoldProduct { get; internal set; }
		public int CheckinsLast30Days { get; internal set; }
		public int SalesLast30Days { get; internal set; }
		public decimal PaymentsLast30Days { get; internal set; }
	}
}
