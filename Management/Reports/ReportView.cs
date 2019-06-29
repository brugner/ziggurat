using Corlib;
using Corlib.Config;
using Corlib.Views.Contracts;
using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
using System.Windows.Forms;

namespace Management.Reports
{
   public partial class ReportView : XtraForm, IReportView
   {
      public ReportView()
      {
         InitializeComponent();
      }

      #region IReportView
      public string ViewText
      {
         set { Text = value; }
      }

      public XtraReport ReportFile
      {
         set { documentViewer1.DocumentSource = value; }
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
      #endregion
   }
}