using Corlib.Core.Domain;
using Corlib.Core.Repositories;
using System.Linq;

namespace Corlib.Persistence.Repositories
{
   internal class AdRepository : Repository<Ad>, IAdRepository
   {
      public ZigguratContext ZigguratContext { get { return Context as ZigguratContext; } }

      public AdRepository(ZigguratContext context) : base(context)
      {

      }

      public Ad Get()
      {
         return ZigguratContext.Ads.FirstOrDefault();
      }
   }
}
