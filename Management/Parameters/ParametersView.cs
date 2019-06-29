using Corlib;
using Corlib.Config;
using Corlib.Views.Contracts;
using Corlib.Views.ViewModels;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Management.Parameters
{
   public partial class ParametersView : XtraForm, IParametersView
   {
      public ParametersView()
      {
         InitializeComponent();
      }

      #region IParametersView

      public string GymName
      {
         get { return txtGymName.Text; }
         set { txtGymName.Text = value; }
      }

      public string GymAddress
      {
         get { return txtGymAddress.Text; }
         set { txtGymAddress.Text = value; }
      }

      public IList<CityViewModel> Cities
      {
         get { return (List<CityViewModel>)cboCity.DataSource; }
         set
         {
            cboCity.DataSource = value;
            cboCity.DisplayMember = "Name";
            cboCity.ValueMember = "Id";
            cboCity.Refresh();
         }
      }

      public CityViewModel City
      {
         get { return (CityViewModel)cboCity.SelectedItem; }
         set { cboCity.SelectedValue = value.Id; }
      }

      public string GymPhone
      {
         get { return txtGymPhone.Text; }
         set { txtGymPhone.Text = value; }
      }

      public string GymEmail
      {
         get { return txtGymEmail.Text; }
         set { txtGymEmail.Text = value; }
      }

      public string GymFacebook
      {
         get { return txtGymFacebook.Text; }
         set { txtGymFacebook.Text = value; }
      }

      public string GymTwitter
      {
         get { return txtGymTwitter.Text; }
         set { txtGymTwitter.Text = value; }
      }

      public string GymInstagram
      {
         get { return txtGymInstagram.Text; }
         set { txtGymInstagram.Text = value; }
      }

      public string RequiredField
      {
         get { return txtRequiredField.Text; }
         set { txtRequiredField.Text = value; }
      }

      public string InvalidEmailAddress
      {
         get { return txtInvalidEmailAddress.Text; }
         set { txtInvalidEmailAddress.Text = value; }
      }

      public string EnterAtLeastAPhone
      {
         get { return txtEnterAtLeastAPhone.Text; }
         set { txtEnterAtLeastAPhone.Text = value; }
      }

      public string EnterMobilePhoneAreaCode
      {
         get { return txtEnterMobilePhoneAreaCode.Text; }
         set { txtEnterMobilePhoneAreaCode.Text = value; }
      }

      public string EnterPhoneNumber
      {
         get { return txtEnterPhoneNumber.Text; }
         set { txtEnterPhoneNumber.Text = value; }
      }

      public string SelectAtLeastOne
      {
         get { return txtSelectAtLeastOne.Text; }
         set { txtSelectAtLeastOne.Text = value; }
      }

      public string Skin
      {
         get { return cboSkin.GetItemText(cboSkin.SelectedItem); }
         set { cboSkin.SelectedItem = value; }
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

      public event Action Save;
      #endregion

      private void ParametersView_Load(object sender, EventArgs e)
      {
         defaultLookAndFeel.LookAndFeel.SkinName = AppConfig.Parameters.Skin;
      }

      private void btnOK_Click(object sender, EventArgs e)
      {
         if (IsFormValid())
            Save();
      }

      #region Validation
      private bool IsFormValid()
      {
         if (FormValidator.HasValidationErrors(gbGym.Controls))
            return false;

         if (FormValidator.HasValidationErrors(gbValidations.Controls))
            return false;

         return true;
      }

      private void txtGymName_Validating(object sender, System.ComponentModel.CancelEventArgs e)
      {
         if (string.IsNullOrWhiteSpace(txtGymName.Text.Trim()))
         {
            errorProvider.SetError(txtGymName, AppConfig.Parameters.ValidationMessages.RequiredField);
            e.Cancel = true;
            return;
         }
         else
            errorProvider.SetError(txtGymName, string.Empty);
      }

      private void txtGymAddress_Validating(object sender, System.ComponentModel.CancelEventArgs e)
      {
         if (string.IsNullOrWhiteSpace(txtGymAddress.Text.Trim()))
         {
            errorProvider.SetError(txtGymAddress, AppConfig.Parameters.ValidationMessages.RequiredField);
            e.Cancel = true;
            return;
         }
         else
            errorProvider.SetError(txtGymAddress, string.Empty);
      }

      private void txtGymPhone_Validating(object sender, System.ComponentModel.CancelEventArgs e)
      {
         if (string.IsNullOrWhiteSpace(txtGymPhone.Text.Trim()))
         {
            errorProvider.SetError(txtGymPhone, AppConfig.Parameters.ValidationMessages.RequiredField);
            e.Cancel = true;
            return;
         }
         else
            errorProvider.SetError(txtGymPhone, string.Empty);
      }

      private void txtGymEmail_Validating(object sender, System.ComponentModel.CancelEventArgs e)
      {
         if (string.IsNullOrWhiteSpace(txtGymEmail.Text.Trim()))
         {
            errorProvider.SetError(txtGymEmail, AppConfig.Parameters.ValidationMessages.RequiredField);
            e.Cancel = true;
            return;
         }
         else
            errorProvider.SetError(txtGymEmail, string.Empty);
      }

      private void txtRequiredField_Validating(object sender, System.ComponentModel.CancelEventArgs e)
      {
         if (string.IsNullOrWhiteSpace(txtRequiredField.Text.Trim()))
         {
            errorProvider.SetError(txtRequiredField, AppConfig.Parameters.ValidationMessages.RequiredField);
            e.Cancel = true;
            return;
         }
         else
            errorProvider.SetError(txtRequiredField, string.Empty);
      }

      private void txtInvalidEmailAddress_Validating(object sender, System.ComponentModel.CancelEventArgs e)
      {
         if (string.IsNullOrWhiteSpace(txtInvalidEmailAddress.Text.Trim()))
         {
            errorProvider.SetError(txtInvalidEmailAddress, AppConfig.Parameters.ValidationMessages.RequiredField);
            e.Cancel = true;
            return;
         }
         else
            errorProvider.SetError(txtInvalidEmailAddress, string.Empty);
      }

      private void txtEnterAtLeastAPhone_Validating(object sender, System.ComponentModel.CancelEventArgs e)
      {
         if (string.IsNullOrWhiteSpace(txtEnterAtLeastAPhone.Text.Trim()))
         {
            errorProvider.SetError(txtEnterAtLeastAPhone, AppConfig.Parameters.ValidationMessages.RequiredField);
            e.Cancel = true;
            return;
         }
         else
            errorProvider.SetError(txtEnterAtLeastAPhone, string.Empty);
      }

      private void txtEnterMobilePhoneAreaCode_Validating(object sender, System.ComponentModel.CancelEventArgs e)
      {
         if (string.IsNullOrWhiteSpace(txtEnterMobilePhoneAreaCode.Text.Trim()))
         {
            errorProvider.SetError(txtEnterMobilePhoneAreaCode, AppConfig.Parameters.ValidationMessages.RequiredField);
            e.Cancel = true;
            return;
         }
         else
            errorProvider.SetError(txtEnterMobilePhoneAreaCode, string.Empty);
      }

      private void txtEnterPhoneNumber_Validating(object sender, System.ComponentModel.CancelEventArgs e)
      {
         if (string.IsNullOrWhiteSpace(txtEnterPhoneNumber.Text.Trim()))
         {
            errorProvider.SetError(txtEnterPhoneNumber, AppConfig.Parameters.ValidationMessages.RequiredField);
            e.Cancel = true;
            return;
         }
         else
            errorProvider.SetError(txtEnterPhoneNumber, string.Empty);
      }

      private void txtSelectAtLeastOne_Validating(object sender, System.ComponentModel.CancelEventArgs e)
      {
         if (string.IsNullOrWhiteSpace(txtSelectAtLeastOne.Text.Trim()))
         {
            errorProvider.SetError(txtSelectAtLeastOne, AppConfig.Parameters.ValidationMessages.RequiredField);
            e.Cancel = true;
            return;
         }
         else
            errorProvider.SetError(txtSelectAtLeastOne, string.Empty);
      }
      #endregion
   }
}