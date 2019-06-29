using Corlib.Core.Domain;
using System;
using System.Collections.Generic;

namespace Corlib.Core.Repositories
{
	internal interface ISaleRepository : IRepository<Sale>
	{
		int GetNewNumber();
		int GetCountLast30Days();
		IList<Tuple<string, int>> GetCountGroupedByCategory();
		IList<Tuple<DateTime, decimal>> GetAmountGroupedByDate(int days);
	}
}
