using Corlib.Core.Domain;
using System.Data.Entity.ModelConfiguration;

namespace Corlib.Config.ModelConfiguration
{
   class DatabaseBackupRecordModelConfiguration : EntityTypeConfiguration<DatabaseBackupRecord>
   {
      public DatabaseBackupRecordModelConfiguration()
      {
         Property(x => x.Path).IsRequired();
         Property(x => x.Date).IsRequired();
      }
   }
}
