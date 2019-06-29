using Corlib.Core.Domain;
using Corlib.Core.Repositories;
using System;
using System.Linq;

namespace Corlib.Persistence.Repositories
{
	internal class PaymentRepository : Repository<Payment>, IPaymentRepository
	{
		public ZigguratContext ZigguratContext { get { return Context as ZigguratContext; } }

		public PaymentRepository(ZigguratContext context) : base(context)
		{

		}

		public decimal GetSumLast30Days()
		{
			var from = DateTime.Today.AddDays(-30);
			var to = DateTime.Today;

			return ZigguratContext.Payments.Where(x => x.Date >= from && x.Date <= to).Sum(x => x.Amount);
		}
	}
}
