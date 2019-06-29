using Corlib.Core.Domain;

namespace Corlib.Core.Repositories
{
   internal interface ITrainingRepository : IRepository<Training>
   {
      void Delete(Training training);
   }
}
