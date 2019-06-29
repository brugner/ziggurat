namespace Corlib.Services.Contracts
{
   public interface IDatabaseBackupService
   {
      void Backup(bool overwrite = false);
   }
}
