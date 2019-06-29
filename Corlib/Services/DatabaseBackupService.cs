using Corlib.Config;
using Corlib.Core.Domain;
using Corlib.Factories;
using Corlib.Services.Contracts;
using System;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;

namespace Corlib.Services
{
   class DatabaseBackupService : IDatabaseBackupService
   {
      private readonly string _backupDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Backup");
      private readonly string _dbName = new SqlConnectionStringBuilder(ConfigurationManager.ConnectionStrings["Ziggurat"].ConnectionString).InitialCatalog;
      private string _backupFileName = string.Empty;

      public void Backup(bool overwrite = false)
      {
         if (!AppConfig.Environment.IsProduction)
            return;

         if (IsTodayBackupDone() && !overwrite)
            return;

         CreateBackupDirectoryIfNotExists();
         GenerateBackupFileName();
         ExecuteBackupCommand();
         SaveBackupRecord();
      }

      private bool IsTodayBackupDone()
      {
         using (var unitOfWork = UnitOfWorkFactory.Create())
         {
            return unitOfWork.DatabaseBackupRecords.IsTodayBackupDone();
         }
      }

      private void CreateBackupDirectoryIfNotExists()
      {
         if (!Directory.Exists(_backupDirectory))
            Directory.CreateDirectory(_backupDirectory);
      }

      private void GenerateBackupFileName()
      {
         _backupFileName = Path.Combine(_backupDirectory, _dbName) + "-" + DateTime.Today.ToString("yyyy-MM-dd") + ".bak";
      }

      private void ExecuteBackupCommand()
      {
         using (var connection = new SqlConnection(ConfigurationManager.ConnectionStrings["Ziggurat"].ConnectionString))
         {
            var query = $"BACKUP DATABASE {_dbName} TO DISK='{_backupFileName}'";

            using (var command = new SqlCommand(query, connection))
            {
               connection.Open();
               command.ExecuteNonQuery();
            }
         }
      }

      private void SaveBackupRecord()
      {
         using (var unitOfWork = UnitOfWorkFactory.Create())
         {
            var backupRecord = new DatabaseBackupRecord
            {
               Date = DateTime.Now,
               Path = _backupFileName
            };

            unitOfWork.DatabaseBackupRecords.Add(backupRecord);
            unitOfWork.Complete();
         }
      }
   }
}
