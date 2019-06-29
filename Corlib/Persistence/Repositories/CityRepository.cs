using Corlib.Config;
using Corlib.Core.Domain;
using Corlib.Core.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace Corlib.Persistence.Repositories
{
   internal class CityRepository : Repository<City>, ICityRepository
   {
      public ZigguratContext ZigguratContext
      {
         get { return Context as ZigguratContext; }
      }

      public CityRepository(ZigguratContext context) : base(context)
      {

      }

      public IEnumerable<City> GetCitiesWithMembers()
      {
         return ZigguratContext.Cities.Where(x => x.Members.Count > 0).ToList();
      }

      public City GetGymCity()
      {
         return ZigguratContext.Cities.Where(x => x.Id == AppConfig.Parameters.Gym.CityId).FirstOrDefault();
      }
   }
}
