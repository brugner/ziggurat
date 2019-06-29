using Corlib;
using Corlib.Config;
using Corlib.Views.Contracts;
using DevExpress.XtraEditors;
using System;
using System.Windows.Forms;

namespace Management.Members.PersonalTrainingRecords
{
   public partial class PersonalTrainingRecordView : XtraForm, IPersonalTrainingRecordView
   {
      public PersonalTrainingRecordView()
      {
         InitializeComponent();
      }

      #region IPersonalTrainingRecordView
      public string ViewText
      {
         set { Text = value; }
      }

      public DateTime Date
      {
         get { return dtpDate.Value; }
         set { dtpDate.Value = value; }
      }

      public int? Weight
      {
         get { return !string.IsNullOrEmpty(txtWeight.Text) ? Convert.ToInt32(txtWeight.Text) : new int?(); }
         set { if (value.HasValue) txtWeight.Text = value.ToString(); }
      }

      public int? MemberHeight
      {
         get { return !string.IsNullOrEmpty(txtHeight.Text) ? Convert.ToInt32(txtHeight.Text) : new int?(); }
         set { if (value.HasValue) txtHeight.Text = value.ToString(); }
      }

      public int? Neck
      {
         get { return !string.IsNullOrEmpty(txtNeck.Text) ? Convert.ToInt32(txtNeck.Text) : new int?(); }
         set { if (value.HasValue) txtNeck.Text = value.ToString(); }
      }

      public int? Shoulders
      {
         get { return !string.IsNullOrEmpty(txtShoulders.Text) ? Convert.ToInt32(txtShoulders.Text) : new int?(); }
         set { if (value.HasValue) txtShoulders.Text = value.ToString(); }
      }

      public int? Chest
      {
         get { return !string.IsNullOrEmpty(txtChest.Text) ? Convert.ToInt32(txtChest.Text) : new int?(); }
         set { if (value.HasValue) txtChest.Text = value.ToString(); }
      }

      public int? Waist
      {
         get { return !string.IsNullOrEmpty(txtWaist.Text) ? Convert.ToInt32(txtWaist.Text) : new int?(); }
         set { if (value.HasValue) txtWaist.Text = value.ToString(); }
      }

      public int? Forearms
      {
         get { return !string.IsNullOrEmpty(txtForearms.Text) ? Convert.ToInt32(txtForearms.Text) : new int?(); }
         set { if (value.HasValue) txtForearms.Text = value.ToString(); }
      }

      public int? Thighs
      {
         get { return !string.IsNullOrEmpty(txtThighs.Text) ? Convert.ToInt32(txtThighs.Text) : new int?(); }
         set { if (value.HasValue) txtThighs.Text = value.ToString(); }
      }

      public int? Calves
      {
         get { return !string.IsNullOrEmpty(txtCalves.Text) ? Convert.ToInt32(txtCalves.Text) : new int?(); }
         set { if (value.HasValue) txtCalves.Text = value.ToString(); }
      }

      public int? Biceps
      {
         get { return !string.IsNullOrEmpty(txtBiceps.Text) ? Convert.ToInt32(txtBiceps.Text) : new int?(); }
         set { if (value.HasValue) txtBiceps.Text = value.ToString(); }
      }

      public int? Buttocks
      {
         get { return !string.IsNullOrEmpty(txtButtocks.Text) ? Convert.ToInt32(txtButtocks.Text) : new int?(); }
         set { if (value.HasValue) txtButtocks.Text = value.ToString(); }
      }

      public string Comment
      {
         get { return txtComment.Text; }
         set { txtComment.Text = value; }
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

      public event Action SaveRecord;
      #endregion

      private void PersonalTrainingRecordView_Load(object sender, EventArgs e)
      {
         defaultLookAndFeel.LookAndFeel.SkinName = AppConfig.Parameters.Skin;
      }

      private void btnOK_Click(object sender, EventArgs e)
      {
         SaveRecord();
      }
   }
}