using Corlib;
using Corlib.Config;
using Corlib.Views.Contracts;
using Corlib.Views.ViewModels;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Management.Checkins
{
   public partial class CheckinView : XtraForm, ICheckinView
   {
      public CheckinView()
      {
         InitializeComponent();
      }

      #region ICheckinView
      private MemberViewModel _member;
      public MemberViewModel Member
      {
         get { return _member; }
         set
         {
            if (value != null)
            {
               txtMemberFullName.Text = value.FullName;
               _member = value;
            }
            else
            {
               txtMemberFullName.Clear();
               _member = null;
            }
         }
      }

      public IEnumerable<MembershipViewModel> Memberships
      {
         set
         {
            rgTrainings.Properties.Items.Clear();

            if (value != null)
            {
               foreach (var membership in value)
               {
                  string description = $"{membership.TrainingName} ({membership.StartDate.ToShortDateString()}-{membership.EndDate.ToShortDateString()})";
                  rgTrainings.Properties.Items.Add(new RadioGroupItem(membership.Id, description, true, membership));
               }
            }
         }
      }

      public MembershipViewModel CheckedMembership
      {
         get { return (MembershipViewModel)rgTrainings.Properties.Items[rgTrainings.SelectedIndex].Tag; }
      }

      public DateTime Date
      {
         get { return dtpDateTime.Value; }
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

      public event Action MemberSearch;
      public event Action SaveCheckin;
      #endregion

      private void CheckinView_Load(object sender, EventArgs e)
      {
         defaultLookAndFeel.LookAndFeel.SkinName = AppConfig.Parameters.Skin;
      }

      private void linkMemberSearch_Click(object sender, EventArgs e)
      {
         MemberSearch();
      }

      private void btnOK_Click(object sender, EventArgs e)
      {
         if (IsFormValid())
            SaveCheckin();
      }

      private void txtMemberFullName_TextChanged(object sender, EventArgs e)
      {
         errorProvider.SetError(txtMemberFullName, string.Empty);
      }

      private void rgTrainings_SelectedIndexChanged(object sender, EventArgs e)
      {
         errorProvider.SetError(rgTrainings, string.Empty);
      }

      #region Validation
      private bool IsFormValid()
      {
         if (FormValidator.HasValidationErrors(Controls))
            return false;

         return true;
      }

      private void txtMemberFullName_Validating(object sender, System.ComponentModel.CancelEventArgs e)
      {
         if (string.IsNullOrWhiteSpace(txtMemberFullName.Text))
         {
            errorProvider.SetError(txtMemberFullName, AppConfig.Parameters.ValidationMessages.SelectAtLeastOne);
            e.Cancel = true;
            return;
         }
         else
            errorProvider.SetError(txtMemberFullName, string.Empty);

         if (rgTrainings.SelectedIndex == -1)
         {
            errorProvider.SetError(rgTrainings, AppConfig.Parameters.ValidationMessages.SelectAtLeastOne);
            e.Cancel = true;
            return;
         }
         else
            errorProvider.SetError(rgTrainings, string.Empty);
      }
      #endregion
   }
}