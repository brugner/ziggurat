using Corlib.Core.Domain;
using System.Collections.Generic;

namespace Corlib.Core.Repositories
{
   internal interface ICityRepository : IRepository<City>
   {
      IEnumerable<City> GetCitiesWithMembers();
      City GetGymCity();
   }
}
