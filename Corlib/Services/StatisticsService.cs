using AutoMapper;
using Corlib.Core;
using Corlib.Factories;
using Corlib.Services.Contracts;
using Corlib.Services.ServiceModels;
using Corlib.Views.ViewModels;
using NLog;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace Corlib.Services
{
	public class StatisticsService : IStatisticsService
	{
		private IUnitOfWork _unitOfWork;
		private static Logger _logger = LogManager.GetCurrentClassLogger();

		public DataTable GetCheckinSeriesData(int days)
		{
			using (_unitOfWork = UnitOfWorkFactory.Create())
			{
				var table = new DataTable("Checkins");
				table.Columns.Add("Argument", typeof(DateTime));
				table.Columns.Add("Value", typeof(int));

				var checkinsStats = _unitOfWork.Checkins.GetCountGroupedByDate(days);

				for (int i = 0; i < days; i++)
				{
					// basicamente rellena los valores faltantes con ceros para que siempre halla la misma cantidad items que de días solicitados
					var date = DateTime.Today.AddDays(i * -1);
					int count = checkinsStats.Where(x => x.Item1.Year == date.Year && x.Item1.Month == date.Month && x.Item1.Day == date.Day).Select(x => x.Item2).FirstOrDefault();

					DataRow row = null;
					row = table.NewRow();
					row["Argument"] = date;
					row["Value"] = count;
					table.Rows.Add(row);
				}

				return table;
			}
		}

		public DataTable GetCheckinSeriesData(int days, int memberId)
		{
			using (_unitOfWork = UnitOfWorkFactory.Create())
			{
				var table = new DataTable("Checkins");
				table.Columns.Add("Argument", typeof(DateTime));
				table.Columns.Add("Value", typeof(int));

				var checkinsStats = _unitOfWork.Checkins.GetCountGroupedByDate(days, memberId);

				for (int i = 0; i < days; i++)
				{
					// basicamente rellena los valores faltantes con ceros para que siempre halla la misma cantidad items que de días solicitados
					var date = DateTime.Today.AddDays(i * -1);
					int count = checkinsStats.Where(x => x.Item1.Year == date.Year && x.Item1.Month == date.Month && x.Item1.Day == date.Day).Select(x => x.Item2).FirstOrDefault();

					DataRow row = null;
					row = table.NewRow();
					row["Argument"] = date;
					row["Value"] = count;
					table.Rows.Add(row);
				}

				return table;
			}
		}

		public DataTable GetCheckinsByTrainingSeriesData()
		{
			using (_unitOfWork = UnitOfWorkFactory.Create())
			{
				var table = new DataTable("CheckinsByTraining");
				table.Columns.Add("Argument", typeof(string));
				table.Columns.Add("Value", typeof(int));

				var checkinsStats = _unitOfWork.Checkins.GetCountGroupedByTraining();

				foreach (var item in checkinsStats)
				{
					DataRow row = null;
					row = table.NewRow();
					row["Argument"] = item.Item1;
					row["Value"] = item.Item2;
					table.Rows.Add(row);
				}

				return table;
			}
		}

		public DataTable GetMembersJoiningDateSeriesData()
		{
			using (_unitOfWork = UnitOfWorkFactory.Create())
			{
				var table = new DataTable("MembersJoiningDate");
				table.Columns.Add("Argument", typeof(DateTime));
				table.Columns.Add("Value", typeof(int));

				var membersJoiningDateStats = _unitOfWork.Members.GetCountGroupedByJoiningDate();

				foreach (var item in membersJoiningDateStats)
				{
					DataRow row = null;
					row = table.NewRow();
					row["Argument"] = item.Item1;
					row["Value"] = item.Item2;
					table.Rows.Add(row);
				}

				return table;
			}
		}

		public DataTable GetMembersByGenderSeriesData()
		{
			using (_unitOfWork = UnitOfWorkFactory.Create())
			{
				var table = new DataTable("MembersByGender");
				table.Columns.Add("Argument", typeof(string));
				table.Columns.Add("Value", typeof(int));

				var membersByGenderStats = _unitOfWork.Members.GetCountGroupedByGender();

				foreach (var item in membersByGenderStats)
				{
					DataRow row = null;
					row = table.NewRow();
					row["Argument"] = item.Item1 == "F" ? "Mujeres" : "Hombres";
					row["Value"] = item.Item2;
					table.Rows.Add(row);
				}

				return table;
			}
		}

		public DataTable GetMembershipsSeriesData()
		{
			using (_unitOfWork = UnitOfWorkFactory.Create())
			{
				var table = new DataTable("Memberships");
				table.Columns.Add("Argument", typeof(string));
				table.Columns.Add("Value", typeof(int));

				var stats = _unitOfWork.Memberships.GetCountGroupedByTrainingName();

				foreach (var stat in stats)
				{
					DataRow row = null;
					row = table.NewRow();
					row["Argument"] = stat.Item1;
					row["Value"] = stat.Item2;
					table.Rows.Add(row);
				}

				return table;
			}
		}

		public DataTable GetSalesByCategorySeriesData()
		{
			using (_unitOfWork = UnitOfWorkFactory.Create())
			{
				var table = new DataTable("SalesByCategory");
				table.Columns.Add("Argument", typeof(string));
				table.Columns.Add("Value", typeof(int));

				var salesStats = _unitOfWork.Sales.GetCountGroupedByCategory();

				foreach (var item in salesStats)
				{
					DataRow row = null;
					row = table.NewRow();
					row["Argument"] = item.Item1;
					row["Value"] = item.Item2;
					table.Rows.Add(row);
				}

				return table;
			}
		}

		public DataTable GetSalesAmountLastDaysSeriesData(int days)
		{
			using (_unitOfWork = UnitOfWorkFactory.Create())
			{
				var table = new DataTable("SalesAmountLastDays");
				table.Columns.Add("Argument", typeof(DateTime));
				table.Columns.Add("Value", typeof(decimal));

				var salesStats = _unitOfWork.Sales.GetAmountGroupedByDate(days);

				for (int i = 0; i < days; i++)
				{
					// basicamente rellena los valores faltantes con ceros para que siempre halla la misma cantidad items que de días solicitados
					var date = DateTime.Today.AddDays(i * -1);
					decimal amount = salesStats.Where(x => x.Item1.Year == date.Year && x.Item1.Month == date.Month && x.Item1.Day == date.Day).Select(x => x.Item2).FirstOrDefault();

					DataRow row = null;
					row = table.NewRow();
					row["Argument"] = date;
					row["Value"] = amount;
					table.Rows.Add(row);
				}

				return table;
			}
		}

		public QuickStats GetQuickStats(QuickStatsOption options)
		{
			var stats = new QuickStats();

			if (IsTotalMembersSet(options))
				stats.TotalMembers = GetTotalMembers();

			if (IsActiveMembersSet(options))
				stats.ActiveMembersPercentage = GetActiveMembersPercentage();

			if (IsDailyAverageCheckinsSet(options))
				stats.DailyAverageCheckins = GetDailyAverageCheckins();

			if (IsMonthlyAverageCheckinsSet(options))
				stats.MonthlyAverageCheckins = GetMonthlyAverageCheckins();

			if (IsMostPopularTrainingSet(options))
				stats.MostPopularTraining = GetMostPopularTraining();

			if (IsMostSoldProductSet(options))
				stats.MostSoldProduct = GetMostSoldProduct();

			if (IsCheckinsLast30DaysSet(options))
				stats.CheckinsLast30Days = GetCheckinsLast30Days();

			if (IsSalesLast30DaysSet(options))
				stats.SalesLast30Days = GetSalesLast30Days();

			if (IsPaymentsLast30DaysSet(options))
				stats.PaymentsLast30Days = GetPaymentsLast30Days();

			return stats;
		}

		public IEnumerable<BirthdayViewModel> GetWeekBirthdays()
		{
			using (_unitOfWork = UnitOfWorkFactory.Create())
			{
				return Mapper.Map<IEnumerable<BirthdayViewModel>>(_unitOfWork.Members.GetBirthdays());
			}
		}

		#region Helpers
		private bool IsTotalMembersSet(QuickStatsOption options)
		{
			return (options & QuickStatsOption.TotalMembers) == QuickStatsOption.TotalMembers;
		}

		private bool IsActiveMembersSet(QuickStatsOption options)
		{
			return (options & QuickStatsOption.ActiveMembers) == QuickStatsOption.ActiveMembers;
		}

		private bool IsDailyAverageCheckinsSet(QuickStatsOption options)
		{
			return (options & QuickStatsOption.DailyAverageCheckins) == QuickStatsOption.DailyAverageCheckins;
		}

		private bool IsMonthlyAverageCheckinsSet(QuickStatsOption options)
		{
			return (options & QuickStatsOption.MonthlyAverageCheckins) == QuickStatsOption.MonthlyAverageCheckins;
		}

		private bool IsMostPopularTrainingSet(QuickStatsOption options)
		{
			return (options & QuickStatsOption.MostPopularTraining) == QuickStatsOption.MostPopularTraining;
		}

		private bool IsMostSoldProductSet(QuickStatsOption options)
		{
			return (options & QuickStatsOption.MostSoldProduct) == QuickStatsOption.MostSoldProduct;
		}

		private bool IsCheckinsLast30DaysSet(QuickStatsOption options)
		{
			return (options & QuickStatsOption.CheckinsLast30Days) == QuickStatsOption.CheckinsLast30Days;
		}

		private bool IsSalesLast30DaysSet(QuickStatsOption options)
		{
			return (options & QuickStatsOption.SalesLast30Days) == QuickStatsOption.SalesLast30Days;
		}

		private bool IsPaymentsLast30DaysSet(QuickStatsOption options)
		{
			return (options & QuickStatsOption.PaymentsLast30Days) == QuickStatsOption.PaymentsLast30Days;
		}

		private int GetTotalMembers()
		{
			try
			{
				using (_unitOfWork = UnitOfWorkFactory.Create())
				{
					return _unitOfWork.Members.GetAll().Count();
				}
			}
			catch (Exception ex)
			{
				_logger.Error(ex);
				return 0;
			}
		}

		private decimal GetActiveMembersPercentage()
		{
			try
			{
				using (_unitOfWork = UnitOfWorkFactory.Create())
				{
					var total = _unitOfWork.Members.GetAll().Count();
					var active = _unitOfWork.Memberships.Find(x => x.Status == MembershipStatus.ACTIVE).GroupBy(x => x.MemberId).Count();

					return (active * 100) / total;
				}
			}
			catch (Exception ex)
			{
				_logger.Error(ex);
				return 0;
			}
		}

		private decimal GetDailyAverageCheckins()
		{
			try
			{
				using (_unitOfWork = UnitOfWorkFactory.Create())
				{
					var checkins = _unitOfWork.Checkins.GetAll();
					var totalCheckins = checkins.Count();
					var firstCheckinDate = checkins.First()?.Date;

					if (firstCheckinDate == null)
						return 0;

					var totalDays = (DateTime.Today - firstCheckinDate.Value).TotalDays;

					var result = totalCheckins / (decimal)totalDays;
					return Math.Round(result, 2);
				}
			}
			catch (Exception ex)
			{
				_logger.Error(ex);
				return 0;
			}
		}

		private decimal GetMonthlyAverageCheckins()
		{
			try
			{
				using (_unitOfWork = UnitOfWorkFactory.Create())
				{
					return Math.Round(_unitOfWork.Checkins.GetMonthlyAverage(), 2);
				}
			}
			catch (Exception ex)
			{
				_logger.Error(ex);
				return 0;
			}
		}

		private string GetMostPopularTraining()
		{
			try
			{
				using (_unitOfWork = UnitOfWorkFactory.Create())
				{
					var activeMemberships = _unitOfWork.Memberships.Find(x => x.Status == MembershipStatus.ACTIVE).GroupBy(x => x.TrainingId);
					var mostPopularTrainingId = activeMemberships.OrderByDescending(x => x.Count()).FirstOrDefault()?.Key;

					if (mostPopularTrainingId.HasValue)
						return _unitOfWork.Trainings.Get(mostPopularTrainingId.Value).Name;
					else
						return "Ninguna";
				}
			}
			catch (Exception ex)
			{
				_logger.Error(ex);
				return string.Empty;
			}
		}

		private string GetMostSoldProduct()
		{
			try
			{
				using (_unitOfWork = UnitOfWorkFactory.Create())
				{
					var salesItems = _unitOfWork.SaleItems.GetAll().GroupBy(x => x.ProductId);
					var mostSoldProductId = salesItems.OrderByDescending(x => x.Count()).FirstOrDefault()?.Key;

					if (mostSoldProductId.HasValue)
						return _unitOfWork.Products.Get(mostSoldProductId.Value).Name;
					else
						return "Ninguno";
				}
			}
			catch (Exception ex)
			{
				_logger.Error(ex);
				return string.Empty;
			}
		}

		private int GetCheckinsLast30Days()
		{
			try
			{
				using (_unitOfWork = UnitOfWorkFactory.Create())
				{
					return _unitOfWork.Checkins.GetCountLast30Days();
				}
			}
			catch (Exception ex)
			{
				_logger.Error(ex);
				return 0;
			}
		}

		private int GetSalesLast30Days()
		{
			try
			{
				using (_unitOfWork = UnitOfWorkFactory.Create())
				{
					return _unitOfWork.Sales.GetCountLast30Days();
				}
			}
			catch (Exception ex)
			{
				_logger.Error(ex);
				return 0;
			}
		}

		private decimal GetPaymentsLast30Days()
		{
			try
			{
				using (_unitOfWork = UnitOfWorkFactory.Create())
				{
					return _unitOfWork.Payments.GetSumLast30Days();
				}
			}
			catch (Exception ex)
			{
				_logger.Error(ex);
				return 0;
			}
		}
		#endregion
	}
}
