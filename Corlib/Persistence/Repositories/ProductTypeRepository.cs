using Corlib.Core.Domain;
using Corlib.Core.Repositories;

namespace Corlib.Persistence.Repositories
{
   internal class ProductTypeRepository : Repository<ProductType>, IProductTypeRepository
   {
      public ProductTypeRepository(ZigguratContext context) : base(context)
      {

      }

      public ZigguratContext ZigguratContext
      {
         get { return Context as ZigguratContext; }
      }
   }
}
