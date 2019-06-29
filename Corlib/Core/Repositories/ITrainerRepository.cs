using Corlib.Core.Domain;

namespace Corlib.Core.Repositories
{
   internal interface ITrainerRepository : IRepository<Trainer>
   {
      void Delete(Trainer trainer);
   }
}
