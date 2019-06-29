using Corlib.Core.Domain;
using Corlib.Core.Repositories;
using Corlib.Services;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Corlib.Persistence.Repositories
{
	internal class MemberRepository : Repository<Member>, IMemberRepository
	{
		public ZigguratContext ZigguratContext { get { return Context as ZigguratContext; } }

		public MemberRepository(ZigguratContext context) : base(context)
		{

		}

		public void Delete(Member member)
		{
			member.IsDeleted = true;
			member.DeletedAt = DateTime.Now;
		}

		public string GetFullName(int id)
		{
			var member = ZigguratContext.Members.Where(x => x.Id == id).FirstOrDefault();
			return member.FirstName + " " + member.LastName;
		}

		public IEnumerable<Member> GetAll(int[] ids)
		{
			return ZigguratContext.Members.Where(x => ids.Contains(x.Id)).ToList();
		}

		public IEnumerable<Member> GetBirthdays()
		{
			string sql = @"SELECT * FROM Members
								WHERE DATEADD(YEAR, DATEPART(YEAR, GETDATE()) - DATEPART(YEAR, DateOfBirth), DateOfBirth)
								BETWEEN CAST(DATEADD(DAY, -3, GETDATE()) AS DATE) AND CAST(DATEADD(DAY, 4, GETDATE()) - 1 AS DATE)
								AND IsDeleted = 0
								ORDER BY MONTH(DateOfBirth), DAY(DateOfBirth)";

			return ZigguratContext.Database.SqlQuery<Member>(sql).ToList();
		}

		public string GetLastCheckin(int id)
		{
			var trainingName = ZigguratContext.Checkins
				.Where(x => x.Membership.MemberId == id)
				.OrderByDescending(x => x.Date)
				?.Take(1)
				?.Select(x => x.Membership.Training.Name).SingleOrDefault();

			var checkinDate = ZigguratContext.Checkins
				.Where(x => x.Membership.MemberId == id)
				.OrderByDescending(x => x.Date)
				?.Take(1)
				?.Select(x => x.Date).SingleOrDefault();

			if (!string.IsNullOrEmpty(trainingName))
				return trainingName + " - " + checkinDate.Value.ToString("dddd d \'de\' MMMM \'de\' yyyy \'a las\' hh:mm");
			else
				return "No hay datos";
		}

		public int GetTotalCheckins(int id)
		{
			return ZigguratContext.Checkins.Where(x => x.Membership.MemberId == id).Count();
		}

		public string GetFavoriteTraining(int id)
		{
			try
			{
				var memberships = ZigguratContext.Memberships.Where(x => x.MemberId == id).GroupBy(x => x.TrainingId);
				var mostPopularTrainingId = memberships.OrderByDescending(x => x.Count()).FirstOrDefault()?.Key;

				if (mostPopularTrainingId.HasValue)
					return ZigguratContext.Trainings.Where(x => x.Id == mostPopularTrainingId.Value).FirstOrDefault()?.Name;
				else
					return "Ninguna";
			}
			catch (Exception ex)
			{
				ServiceLocator.SentryService.ReportError(ex);
				return string.Empty;
			}
		}

		public string GetFavoriteProduct(int id)
		{
			try
			{
				var salesItems = ZigguratContext.SalesItems.Where(x => x.Sale.MemberId == id).GroupBy(x => x.ProductId);
				var mostSoldProductId = salesItems.OrderByDescending(x => x.Count()).FirstOrDefault()?.Key;

				if (mostSoldProductId.HasValue)
					return ZigguratContext.Products.Where(x => x.Id == mostSoldProductId.Value).FirstOrDefault()?.Name;
				else
					return "Ninguno";
			}
			catch (Exception ex)
			{
				ServiceLocator.SentryService.ReportError(ex);
				return string.Empty;
			}
		}

		public IList<Tuple<DateTime, int>> GetCountGroupedByJoiningDate()
		{
			return ZigguratContext.Members
						.GroupBy(x => x.JoiningDate)
						.Select(g => new { g.Key, Count = g.Count() })
						.AsEnumerable()
						.Select(g => new Tuple<DateTime, int>(new DateTime(g.Key.Year, g.Key.Month, g.Key.Day), g.Count)).ToList();
		}

		public IList<Tuple<string, int>> GetCountGroupedByGender()
		{
			return ZigguratContext.Members
						.GroupBy(x => x.Gender)
						.Select(g => new { g.Key, Count = g.Count() })
						.AsEnumerable()
						.Select(g => new Tuple<string, int>(g.Key, g.Count)).ToList();
		}
	}
}
