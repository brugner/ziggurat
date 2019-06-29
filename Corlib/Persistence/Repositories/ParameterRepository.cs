using Corlib.Core.Domain;
using Corlib.Core.Repositories;
using System.Linq;

namespace Corlib.Persistence.Repositories
{
   internal class ParameterRepository : Repository<Parameter>, IParameterRepository
   {
      public ZigguratContext ZigguratContext
      {
         get { return Context as ZigguratContext; }
      }

      public ParameterRepository(ZigguratContext context) : base(context)
      {

      }

      public Parameter Get()
      {
         return ZigguratContext.Parameters.FirstOrDefault();
      }
   }
}
