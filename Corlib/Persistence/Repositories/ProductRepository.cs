using Corlib.Core.Domain;
using Corlib.Core.Repositories;
using System.Linq;

namespace Corlib.Persistence.Repositories
{
   internal class ProductRepository : Repository<Product>, IProductRepository
   {
      public ProductRepository(ZigguratContext context) : base(context)
      {

      }

      public ZigguratContext ZigguratContext
      {
         get { return Context as ZigguratContext; }
      }

      public bool CanBeDeleted(int id)
      {
         return !ZigguratContext.SalesItems.Any(x => x.ProductId == id);
      }
   }
}
