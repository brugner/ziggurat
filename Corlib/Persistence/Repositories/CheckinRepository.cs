using Corlib.Core.Domain;
using Corlib.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Corlib.Persistence.Repositories
{
	internal class CheckinRepository : Repository<Checkin>, ICheckinRepository
	{
		public ZigguratContext ZigguratContext { get { return Context as ZigguratContext; } }

		public CheckinRepository(ZigguratContext context) : base(context)
		{

		}

		public IList<Tuple<DateTime, int>> GetCountGroupedByDate(int days)
		{
			var from = DateTime.Today.AddDays(days * -1);
			var to = DateTime.Today.AddDays(1);

			return ZigguratContext.Checkins.Where(x => x.Date >= from && x.Date <= to)
						.GroupBy(x => new { x.Date.Day, x.Date.Month, x.Date.Year })
						.Select(g => new { g.Key, Count = g.Count() })
						.AsEnumerable()
						.Select(g => new Tuple<DateTime, int>(new DateTime(g.Key.Year, g.Key.Month, g.Key.Day), g.Count)).ToList();
		}

		public IList<Tuple<DateTime, int>> GetCountGroupedByDate(int days, int memberId)
		{
			var from = DateTime.Today.AddDays(days * -1);
			var to = DateTime.Today.AddDays(1);

			return ZigguratContext.Checkins.Where(x => x.Date >= from && x.Date <= to && x.Membership.MemberId == memberId)
						.GroupBy(x => new { x.Date.Day, x.Date.Month, x.Date.Year })
						.Select(g => new { g.Key, Count = g.Count() })
						.AsEnumerable()
						.Select(g => new Tuple<DateTime, int>(new DateTime(g.Key.Year, g.Key.Month, g.Key.Day), g.Count)).ToList();
		}

		public IList<Tuple<string, int>> GetCountGroupedByTraining()
		{
			return ZigguratContext.Checkins
						.GroupBy(x => x.Membership.Training.Name)
						.Select(g => new { g.Key, Count = g.Count() })
						.AsEnumerable()
						.Select(g => new Tuple<string, int>(g.Key, g.Count)).ToList();

		}
		public decimal GetMonthlyAverage()
		{
			string sql = @"SELECT CAST((COUNT(*) / (
								 SELECT TOP 1 COUNT(*) OVER () AS TotalRecords
								 FROM Checkins
								 GROUP BY YEAR(Date), MONTH(Date)
							)) AS MONEY) FROM Checkins";

			return ZigguratContext.Database.SqlQuery<decimal>(sql).FirstOrDefault();
		}

		public int GetCountLast30Days()
		{
			var from = DateTime.Today.AddDays(-30);
			var to = DateTime.Today;

			return ZigguratContext.Checkins.Count(x => x.Date >= from && x.Date <= to);
		}
	}
}
