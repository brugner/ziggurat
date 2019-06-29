using Corlib.Core.Domain;

namespace Corlib.Core.Repositories
{
   internal interface IProductRepository : IRepository<Product>
   {
      bool CanBeDeleted(int id);
   }
}
