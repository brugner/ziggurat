using Corlib.Core.Domain;
using Corlib.Core.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace Corlib.Persistence.Repositories
{
   class MemberFinancialMovementRepository : Repository<MemberFinancialMovement>, IMemberFinancialMovementRepository
   {
      public MemberFinancialMovementRepository(ZigguratContext context) : base(context)
      {

      }

      public ZigguratContext ZigguratContext
      {
         get { return Context as ZigguratContext; }
      }

      public decimal GetBalance(int memberId)
      {
         var lastMovement = ZigguratContext.MemberFinancialMovements.Where(x => x.MemberId == memberId).OrderByDescending(x => x.Date).FirstOrDefault();
         return lastMovement?.Balance ?? 0;
      }

      public decimal GetBalanceBefore(int memberId, int movementId)
      {
         var theMovementBefore = ZigguratContext.MemberFinancialMovements.Where(x => x.MemberId == memberId && x.Id < movementId).OrderByDescending(x => x.Id).FirstOrDefault();
         return theMovementBefore?.Balance ?? 0;
      }

      public IEnumerable<MemberFinancialMovement> GetLast100(int memberId)
      {
         return ZigguratContext.MemberFinancialMovements.Where(x => x.MemberId == memberId).OrderByDescending(x => x.Date).Take(100).ToList();
      }
   }
}
