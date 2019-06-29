using Corlib.Core.Domain;
using Corlib.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Corlib.Persistence.Repositories
{
	internal class SaleRepository : Repository<Sale>, ISaleRepository
	{
		public ZigguratContext ZigguratContext { get { return Context as ZigguratContext; } }

		public SaleRepository(ZigguratContext context) : base(context)
		{

		}

		public int GetNewNumber()
		{
			if (ZigguratContext.Sales.Count() == 0)
				return 1;

			return ZigguratContext.Sales.Max(x => x.Number) + 1;
		}

		public int GetCountLast30Days()
		{
			var from = DateTime.Today.AddDays(-30);
			var to = DateTime.Today;

			return ZigguratContext.Sales.Count(x => x.Date >= from && x.Date <= to);
		}

		public IList<Tuple<string, int>> GetCountGroupedByCategory()
		{
			return ZigguratContext.SalesItems
						.GroupBy(x => x.Product.ProductType.Name)
						.Select(g => new { g.Key, Count = g.Count() })
						.AsEnumerable()
						.Select(g => new Tuple<string, int>(g.Key, g.Count)).ToList();
		}

		public IList<Tuple<DateTime, decimal>> GetAmountGroupedByDate(int days)
		{
			var from = DateTime.Today.AddDays(days * -1);
			var to = DateTime.Today.AddDays(1);

			return ZigguratContext.SalesItems.Where(x => x.Sale.Date >= from && x.Sale.Date <= to)
						.GroupBy(x => new { x.Sale.Date.Day, x.Sale.Date.Month, x.Sale.Date.Year })
						.Select(g => new { g.Key, Amount = g.Sum(x => x.Price * x.Quantity) })
						.AsEnumerable()
						.Select(g => new Tuple<DateTime, decimal>(new DateTime(g.Key.Year, g.Key.Month, g.Key.Day), g.Amount)).ToList();
		}
	}
}
