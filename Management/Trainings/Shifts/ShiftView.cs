using Corlib;
using Corlib.Config;
using Corlib.Views.Contracts;
using DevExpress.XtraEditors;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Management.Trainings.Shifts
{
   public partial class ShiftView : XtraForm, IShiftView
   {
      public ShiftView()
      {
         InitializeComponent();
      }

      #region IShiftView
      public string ViewText
      {
         set { Text = value; }
      }

      public int Number
      {
         get { return Convert.ToInt32(txtNumber.Text); }
         set { txtNumber.Text = value.ToString(); }
      }

      public int[] Days
      {
         get
         {
            int[] indexes = clbDays.CheckedIndices.Cast<int>().ToArray();
            return indexes;
         }
         set
         {
            clbDays.UnCheckAll();

            for (int i = 0; i < value.Length; i++)
               clbDays.SetItemCheckState(value[i], CheckState.Checked);
         }
      }

      public DateTime StartTime
      {
         get { return dtpStartTime.Value; }
         set { dtpStartTime.Value = value; }
      }

      public DateTime EndTime
      {
         get { return dtpEndTime.Value; }
         set { dtpEndTime.Value = value; }
      }

      public byte? Quota
      {
         get
         {
            if (checkQuota.Checked)
               return null;
            else
               return (byte)numQuota.Value;
         }
         set
         {
            if (value.HasValue)
               numQuota.Value = value.Value;
            else
            {
               numQuota.Value = 1;
               checkQuota.Checked = true;
            }
         }
      }

      public void InitializeView()
      {
         var list = new[] {
            new { Id = 1, Name = "Lunes" },
            new { Id = 1, Name = "Martes" },
            new { Id = 3, Name = "Miércoles" },
            new { Id = 4, Name = "Jueves" },
            new { Id = 5, Name = "Viernes" },
            new { Id = 6, Name = "Sábado" },
            new { Id = 7, Name = "Domingo" }

         }.ToList();

         clbDays.DataSource = list;
         clbDays.ValueMember = "Id";
         clbDays.DisplayMember = "Name";
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
         return true;
      }

      public void ShowView()
      {
         ShowDialog();
      }

      public event Action SaveShift;
      #endregion

      private void ShiftView_Load(object sender, EventArgs e)
      {
         defaultLookAndFeel.LookAndFeel.SkinName = AppConfig.Parameters.Skin;
      }

      private void btnOK_Click(object sender, EventArgs e)
      {
         if (IsFormValid())
            SaveShift();
      }

      #region Validation
      private bool IsFormValid()
      {
         if (FormValidator.HasValidationErrors(Controls))
            return false;

         return true;
      }

      private void clbDays_Validating(object sender, System.ComponentModel.CancelEventArgs e)
      {
         if (clbDays.CheckedItemsCount == 0)
         {
            errorProvider.SetError(clbDays, AppConfig.Parameters.ValidationMessages.SelectAtLeastOne);
            e.Cancel = true;
            return;
         }
         else
            errorProvider.SetError(clbDays, string.Empty);
      }
      #endregion

      private void checkQuota_CheckedChanged(object sender, EventArgs e)
      {
         numQuota.Enabled = !checkQuota.Checked;
      }
   }
}