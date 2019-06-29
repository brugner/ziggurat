using Corlib;
using Corlib.Config;
using Corlib.Views.Contracts;
using Corlib.Views.ViewModels;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Management.Extensions;

namespace Management.Members.Memberships
{
   public partial class MembershipView : XtraForm, IMembershipView
   {
      public MembershipView()
      {
         InitializeComponent();
      }

      #region IMembershipView
      public string ViewText
      {
         set { Text = value; }
      }

      public int? Id
      {
         get
         {
            if (txtId.Text.Length == 0)
               return null;

            return Convert.ToInt32(txtId.Text);
         }
         set
         {
            txtId.Text = value.HasValue ? value.Value.ToString() : string.Empty;
         }
      }

      public int TrainingId
      {
         get { return ((TrainingViewModel)cboTraining.SelectedItem).Id; }
         set { cboTraining.SelectedValue = value; }
      }

      public int ShiftId
      {
         get { return clbShifts.CheckedItems.Cast<ShiftViewModel>().ToArray()[0].Id; }
         set
         {
            var list = (List<ShiftViewModel>)clbShifts.DataSource;
            var index = list.FindIndex(x => x.Id == value);

            if (index != -1)
               clbShifts.SetItemChecked(index, true);
         }
      }

      public int Length
      {
         get { return cboLength.SelectedIndex; }
         set { cboLength.SelectedIndex = value; }
      }

      public DateTime StartDate
      {
         get { return dtpStartDate.Value; }
         set { dtpStartDate.Value = value; }
      }

      public DateTime EndDate
      {
         get { return dtpEndDate.Value; }
         set { dtpEndDate.Value = value; }
      }

      public decimal Price
      {
         get { return numPrice.Value; }
         set { numPrice.Value = value; }
      }

      public byte Status
      {
         get { return (byte)lbStatus.Tag; }
         set
         {
            lbStatus.Tag = value;
            if (value == MembershipStatus.ACTIVE)
               lbStatus.Text = "Estado: activa";
            else if (value == MembershipStatus.EXPIRED)
               lbStatus.Text = "Estado: vencida";
         }
      }

      private bool _isFullyPaid;

      public bool IsFullyPaid
      {
         get { return _isFullyPaid; }
         set { _isFullyPaid = value; }
      }


      public IList<TrainingViewModel> Trainings
      {
         get { return (List<TrainingViewModel>)cboTraining.DataSource; }
         set
         {
            cboTraining.DataSource = value;
            cboTraining.DisplayMember = "Name";
            cboTraining.ValueMember = "Id";
            cboTraining.Refresh();
         }
      }

      public void InitializeView()
      {
         this.ClearControls();
         cboLength.SelectedIndex = 0;
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

      public event Action SaveMembership;
      #endregion

      private void MembershipView_Load(object sender, EventArgs e)
      {
         defaultLookAndFeel.LookAndFeel.SkinName = AppConfig.Parameters.Skin;
      }

      private void cboLength_SelectedIndexChanged(object sender, EventArgs e)
      {
         SetMembershipEndDate();
         SetMembershipPrice();
      }

      private void dtpStartDate_ValueChanged(object sender, EventArgs e)
      {
         SetMembershipLength();

         if (dtpStartDate.Value > dtpEndDate.Value)
            dtpEndDate.Value = dtpStartDate.Value;
      }

      private void dtpEndDate_ValueChanged(object sender, EventArgs e)
      {
         SetMembershipLength();

         if (dtpEndDate.Value >= DateTime.Today)
            Status = MembershipStatus.ACTIVE;
         else
            Status = MembershipStatus.EXPIRED;

         if (dtpEndDate.Value < dtpStartDate.Value)
            dtpStartDate.Value = dtpEndDate.Value;
      }

      private void cboTraining_SelectedIndexChanged(object sender, EventArgs e)
      {
         var selectedTraining = (TrainingViewModel)cboTraining.SelectedItem;

         clbShifts.DataSource = selectedTraining.Shifts;
         clbShifts.Refresh();

         SetMembershipPrice();
      }

      private void SetMembershipLength()
      {
         var days = dtpEndDate.Value.Subtract(dtpStartDate.Value).Days;

         if (days == 0)
            cboLength.SelectedIndex = MembershipLength.CLASS;
         else if (days == 6)
            cboLength.SelectedIndex = MembershipLength.WEEK;
         else if (days == 29)
            cboLength.SelectedIndex = MembershipLength.MONTH;
         else if (days == 89)
            cboLength.SelectedIndex = MembershipLength.QUARTER;
         else
            cboLength.SelectedIndex = MembershipLength.OTHER;
      }

      private void SetMembershipEndDate()
      {
         if (cboLength.SelectedIndex == MembershipLength.CLASS)
            dtpEndDate.Value = dtpStartDate.Value.AddDays(0);
         else if (cboLength.SelectedIndex == MembershipLength.WEEK)
            dtpEndDate.Value = dtpStartDate.Value.AddDays(6);
         else if (cboLength.SelectedIndex == MembershipLength.MONTH)
            dtpEndDate.Value = dtpStartDate.Value.AddDays(29);
         else if (cboLength.SelectedIndex == MembershipLength.QUARTER)
            dtpEndDate.Value = dtpStartDate.Value.AddDays(89);
      }

      private void SetMembershipPrice()
      {
         var selectedTraining = (TrainingViewModel)cboTraining.SelectedItem;

         if (selectedTraining != null)
         {
            if (cboLength.SelectedIndex == MembershipLength.CLASS)
               numPrice.Value = selectedTraining.ClassPrice;
            else if (cboLength.SelectedIndex == MembershipLength.WEEK)
               numPrice.Value = selectedTraining.WeekPrice;
            else if (cboLength.SelectedIndex == MembershipLength.MONTH)
               numPrice.Value = selectedTraining.MonthPrice;
            else if (cboLength.SelectedIndex == MembershipLength.QUARTER)
               numPrice.Value = selectedTraining.QuarterPrice;
         }
         else
         {
            numPrice.Value = 0.00M;
         }
      }

      private void clbShifts_Click(object sender, EventArgs e)
      {
         clbShifts.UnCheckAll();
         clbShifts.CheckSelectedItems();
      }

      private void btnOK_Click(object sender, EventArgs e)
      {
         if (IsFormValid())
            SaveMembership();
      }

      #region Validation
      private bool IsFormValid()
      {
         if (FormValidator.HasValidationErrors(Controls))
            return false;

         return true;
      }

      private void cboTraining_Validating(object sender, System.ComponentModel.CancelEventArgs e)
      {
         if (cboTraining.SelectedItem == null)
         {
            errorProvider.SetError(cboTraining, AppConfig.Parameters.ValidationMessages.RequiredField);
            e.Cancel = true;
            return;
         }
         else
            errorProvider.SetError(cboTraining, string.Empty);
      }

      private void clbShifts_Validating(object sender, System.ComponentModel.CancelEventArgs e)
      {
         if (clbShifts.CheckedItemsCount == 0)
         {
            errorProvider.SetError(clbShifts, AppConfig.Parameters.ValidationMessages.SelectAtLeastOne);
            e.Cancel = true;
            return;
         }
         else
            errorProvider.SetError(clbShifts, string.Empty);
      }
      #endregion
   }
}