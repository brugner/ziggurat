using Corlib.Core.Domain;
using Corlib.Core.Repositories;
using System.Linq;

namespace Corlib.Persistence.Repositories
{
   internal class ShiftRepository : Repository<Shift>, IShiftRepository
   {
      public ZigguratContext ZigguratContext
      {
         get { return Context as ZigguratContext; }
      }

      public ShiftRepository(ZigguratContext context) : base(context)
      {

      }

      public bool HasFreeQuota(int id)
      {
         var quota = ZigguratContext.Shifts.Where(x => x.Id == id).Select(x => x.Quota).SingleOrDefault();

         if (quota == null) // turno sin cupo
            return true;

         var memberships = ZigguratContext.Memberships.Where(x => x.Status == MembershipStatus.ACTIVE && x.ShiftId == id).Count();

         return memberships + 1 <= quota;
      }

      public byte? GetAvailableQuota(int id)
      {
         var quota = ZigguratContext.Shifts.Where(x => x.Id == id).Select(x => x.Quota).SingleOrDefault();
         var memberships = GetCurrentMembersCount(id);

         if (!quota.HasValue)
            return null;

         return (byte)(quota.Value - memberships);
      }

      public byte GetCurrentMembersCount(int id)
      {
         return (byte)ZigguratContext.Memberships.Where(x => x.Status == MembershipStatus.ACTIVE && x.ShiftId == id).Count();
      }
   }
}
