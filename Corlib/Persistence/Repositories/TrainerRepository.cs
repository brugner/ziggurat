using Corlib.Core.Domain;
using Corlib.Core.Repositories;
using System;

namespace Corlib.Persistence.Repositories
{
   internal class TrainerRepository : Repository<Trainer>, ITrainerRepository
   {
      public ZigguratContext ZigguratContext
      {
         get { return Context as ZigguratContext; }
      }

      public TrainerRepository(ZigguratContext context) : base(context)
      {

      }

      public void Delete(Trainer trainer)
      {
         trainer.IsDeleted = true;
         trainer.DeletedAt = DateTime.Now;
      }
   }
}
