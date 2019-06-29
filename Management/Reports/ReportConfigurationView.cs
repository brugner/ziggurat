using Corlib;
using Corlib.Config;
using Corlib.Views.Contracts;
using Corlib.Views.ViewModels;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Management.Reports
{
   public partial class ReportConfigurationView : XtraForm, IReportConfigurationView
   {
      public ReportConfigurationView()
      {
         InitializeComponent();
      }

      #region IReportConfigurationView
      public Report SelectedReport
      {
         get { return (Report)lbReports.SelectedIndex; }
      }

      public DateTime CheckinsDateFrom
      {
         get { return dtpFrom.Value; }
      }

      public DateTime CheckinsDateTo
      {
         get { return dtpTo.Value; }
      }

      public DateTime SalesDateFrom
      {
         get { return dtpSalesFrom.Value; }
      }

      public DateTime SalesDateTo
      {
         get { return dtpSalesTo.Value; }
      }

      public IEnumerable<TrainingViewModel> Trainings
      {
         get
         {
            return (IEnumerable<TrainingViewModel>)clbTrainings.DataSource;
         }
         set
         {
            clbTrainings.DisplayMember = "Name";
            clbTrainings.ValueMember = "Id";
            clbTrainings.DataSource = value;
         }
      }

      public IEnumerable<TrainingViewModel> SelectedTrainings
      {
         get
         {
            var list = new List<TrainingViewModel>();

            foreach (var item in clbTrainings.CheckedItems)
               list.Add((TrainingViewModel)item);

            return list;
         }
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

      public event Action ShowReport;
      #endregion

      private void btnOK_Click(object sender, EventArgs e)
      {
         if (IsFormValid())
            ShowReport();
      }

      private void ReportConfigurationView_Load(object sender, EventArgs e)
      {
         defaultLookAndFeel.LookAndFeel.SkinName = AppConfig.Parameters.Skin;
         lbReports.SelectedIndex = 0;
      }

      private void lbReports_SelectedIndexChanged(object sender, EventArgs e)
      {
         foreach (var groupbox in Controls.OfType<GroupBox>())
            groupbox.Visible = lbReports.SelectedItem.ToString() == groupbox.Tag.ToString();
      }

      #region Validation
      private bool IsFormValid()
      {
         var groupbox = Controls.OfType<GroupBox>().Where(x => x.Visible).FirstOrDefault();

         if (FormValidator.HasValidationErrors(groupbox.Controls))
            return false;

         return true;
      }

      private void clbTrainings_Validating(object sender, System.ComponentModel.CancelEventArgs e)
      {
         if (SelectedTrainings.Count() == 0)
         {
            errorProvider.SetError(clbTrainings, AppConfig.Parameters.ValidationMessages.SelectAtLeastOne);
            e.Cancel = true;
            return;
         }
         else
            errorProvider.SetError(clbTrainings, string.Empty);
      }
      #endregion
   }
}