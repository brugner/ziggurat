using System;

namespace Corlib.Views.ViewModels
{
   public class DatabaseBackupRecordViewModel : ViewModel
   {
      public int Id { get; set; }
      public DateTime Date { get; set; }
      public string Path { get; set; }
   }
}
