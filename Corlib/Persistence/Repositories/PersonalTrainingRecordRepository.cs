using Corlib.Core.Domain;
using Corlib.Core.Repositories;

namespace Corlib.Persistence.Repositories
{
   internal class PersonalTrainingRecordRepository : Repository<PersonalTrainingRecord>, IPersonalTrainingRecordRepository
   {
      public PersonalTrainingRecordRepository(ZigguratContext context) : base(context)
      {

      }

      public ZigguratContext ZigguratContext
      {
         get { return Context as ZigguratContext; }
      }
   }
}
