using Corlib.Core.Domain;
using System.Collections.Generic;

namespace Corlib.Core.Repositories
{
   internal interface IMemberFinancialMovementRepository : IRepository<MemberFinancialMovement>
   {
      decimal GetBalance(int memberId);
      IEnumerable<MemberFinancialMovement> GetLast100(int memberId);
      decimal GetBalanceBefore(int memberId, int movementId);
   }
}
