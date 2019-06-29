using Corlib.Core.Domain;
using Corlib.Core.Repositories;

namespace Corlib.Persistence.Repositories
{
   internal class ContactRepository : Repository<Contact>, IContactRepository
   {
      public ContactRepository(ZigguratContext context) : base(context)
      {

      }

      public ZigguratContext ZigguratContext
      {
         get { return Context as ZigguratContext; }
      }
   }
}
