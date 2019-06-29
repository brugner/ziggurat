using Corlib.Core.Domain;

namespace Corlib.Core.Repositories
{
   internal interface IUserRepository : IRepository<User>
   {
      User Get(string username);
   }
}
