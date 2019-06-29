using Corlib.Core.Domain;
using Corlib.Core.Repositories;
using System.Linq;

namespace Corlib.Persistence.Repositories
{
   internal class UserRepository : Repository<User>, IUserRepository
   {
      public UserRepository(ZigguratContext context) : base(context)
      {

      }

      public ZigguratContext ZigguratContext
      {
         get { return Context as ZigguratContext; }
      }

      public User Get(string username)
      {
         return ZigguratContext.Users.Where(x => x.Username == username).SingleOrDefault();
      }
   }
}
