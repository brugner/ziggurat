using Corlib.Core.Domain;

namespace Corlib.Core.Repositories
{
	internal interface IPaymentRepository : IRepository<Payment>
	{
		decimal GetSumLast30Days();
	}
}
