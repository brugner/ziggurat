using Corlib.Core.Domain;

namespace Corlib.Core.Repositories
{
   internal interface IDatabaseBackupRecordRepository : IRepository<DatabaseBackupRecord>
   {
      bool IsTodayBackupDone();
   }
}
