using Corlib.Core.Domain;
using Corlib.Core.Repositories;
using System;

namespace Corlib.Persistence.Repositories
{
   internal class TrainingRepository : Repository<Training>, ITrainingRepository
   {
      public ZigguratContext ZigguratContext
      {
         get { return Context as ZigguratContext; }
      }

      public TrainingRepository(ZigguratContext context) : base(context)
      {

      }

      public void Delete(Training training)
      {
         training.IsDeleted = true;
         training.DeletedAt = DateTime.Now;
      }
   }
}
