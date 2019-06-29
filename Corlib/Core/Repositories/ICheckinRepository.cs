using Corlib.Core.Domain;
using System;
using System.Collections.Generic;

namespace Corlib.Core.Repositories
{
	internal interface ICheckinRepository : IRepository<Checkin>
	{
		IList<Tuple<DateTime, int>> GetCountGroupedByDate(int days);
		IList<Tuple<DateTime, int>> GetCountGroupedByDate(int days, int memberId);
		decimal GetMonthlyAverage();
		int GetCountLast30Days();
		IList<Tuple<string, int>> GetCountGroupedByTraining();
	}
}
