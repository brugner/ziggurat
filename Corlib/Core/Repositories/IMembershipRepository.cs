using Corlib.Core.Domain;
using System;
using System.Collections.Generic;

namespace Corlib.Core.Repositories
{
   interface IMembershipRepository : IRepository<Membership>
   {
      IList<Tuple<string, int>> GetCountGroupedByTrainingName();
   }
}
