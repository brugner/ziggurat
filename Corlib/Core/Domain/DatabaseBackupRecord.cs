using System;

namespace Corlib.Core.Domain
{
   public class DatabaseBackupRecord
   {
      public int Id { get; set; }
      public DateTime Date { get; set; }
      public string Path { get; set; }
   }
}
