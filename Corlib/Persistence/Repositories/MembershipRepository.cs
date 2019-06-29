using Corlib.Core.Domain;
using Corlib.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Corlib.Persistence.Repositories
{
   internal class MembershipRepository : Repository<Membership>, IMembershipRepository
   {
      public ZigguratContext ZigguratContext
      {
         get { return Context as ZigguratContext; }
      }

      public MembershipRepository(ZigguratContext context) : base(context)
      {

      }

      public IList<Tuple<string, int>> GetCountGroupedByTrainingName()
      {
         return ZigguratContext.Memberships.Where(x => x.Status == MembershipStatus.ACTIVE)
                  .GroupBy(x => x.Training.Name)
                  .Select(g => new { g.Key, Count = g.Count() })
                  .AsEnumerable()
                  .Select(g => new Tuple<string, int>(g.Key, g.Count)).ToList();
      }
   }
}
