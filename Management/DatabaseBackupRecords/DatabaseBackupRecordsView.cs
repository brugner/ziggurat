using Corlib;
using Corlib.Config;
using Corlib.Views.Contracts;
using Corlib.Views.ViewModels;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Management.DatabaseBackupRecords
{
   public partial class DatabaseBackupRecordsView : XtraForm, IDatabaseBackupRecordsView
   {
      public DatabaseBackupRecordsView()
      {
         InitializeComponent();
      }

      #region IDatabaseBackupRecordsView
      public IEnumerable<DatabaseBackupRecordViewModel> DatabaseBackupRecords
      {
         set { gridControlRecords.DataSource = value; }
      }

      public void CloseView()
      {
         Close();
      }

      public void Notify(string message, MessageType type)
      {
         var icon = MessageBoxIcon.Information;

         if (type == MessageType.Error)
            icon = MessageBoxIcon.Error;
         else if (type == MessageType.Warning)
            icon = MessageBoxIcon.Exclamation;

         XtraMessageBox.Show(message, AppConfig.AppName, MessageBoxButtons.OK, icon);
      }

      public bool Confirm(string message)
      {
         return XtraMessageBox.Show(message, AppConfig.AppName, MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK;
      }

      public void ShowView()
      {
         ShowDialog();
      }

      public event Action Backup;
      public event Action OpenBackupDirectory;
      #endregion

      private void DatabaseBackupRecordsView_Load(object sender, EventArgs e)
      {
         defaultLookAndFeel.LookAndFeel.SkinName = AppConfig.Parameters.Skin;
      }

      private void btnBackup_Click(object sender, EventArgs e)
      {
         Backup();
      }

      private void btnOpenBackupFolder_Click(object sender, EventArgs e)
      {
         OpenBackupDirectory();
      }
   }
}