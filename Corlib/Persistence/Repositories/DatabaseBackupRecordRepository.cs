using Corlib.Core.Domain;
using Corlib.Core.Repositories;
using System;
using System.Linq;

namespace Corlib.Persistence.Repositories
{
   internal class DatabaseBackupRecordRepository : Repository<DatabaseBackupRecord>, IDatabaseBackupRecordRepository
   {
      public ZigguratContext ZigguratContext { get { return Context as ZigguratContext; } }

      public DatabaseBackupRecordRepository(ZigguratContext context) : base(context)
      {

      }

      public bool IsTodayBackupDone()
      {
         var today = DateTime.Today;
         var todayRecord = ZigguratContext.DatabaseBackupRecords.Where(x => x.Date.Year == today.Year && x.Date.Month == today.Month && x.Date.Day == today.Day).SingleOrDefault();

         return todayRecord != null;
      }
   }
}
