using Corlib.Core.Domain;
using Corlib.Core.Repositories;

namespace Corlib.Persistence.Repositories
{
   internal class SaleItemRepository : Repository<SaleItem>, ISaleItemRepository
   {
      public SaleItemRepository(ZigguratContext context) : base(context)
      {

      }

      public ZigguratContext ZigguratContext
      {
         get { return Context as ZigguratContext; }
      }
   }
}
