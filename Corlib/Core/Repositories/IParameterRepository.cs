using Corlib.Core.Domain;

namespace Corlib.Core.Repositories
{
   internal interface IParameterRepository : IRepository<Parameter>
   {
      Parameter Get();
   }
}
