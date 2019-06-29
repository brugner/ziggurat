using Corlib.Core.Domain;

namespace Corlib.Core.Repositories
{
   internal interface IAdRepository : IRepository<Ad>
   {
      Ad Get();
   }
}
