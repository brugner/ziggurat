using Corlib.Views.ViewModels;
using System;
using System.Collections.Generic;

namespace Corlib.Views.Contracts
{
   public interface IDatabaseBackupRecordsView : IView
   {
      IEnumerable<DatabaseBackupRecordViewModel> DatabaseBackupRecords { set; }

      event Action Backup;
      event Action OpenBackupDirectory;
   }
}
