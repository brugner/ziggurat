using Corlib;
using Corlib.Config;
using Corlib.Views.Contracts;
using DevExpress.XtraEditors;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Management.Members.Contacts
{
   public partial class ContactView : XtraForm, IContactView
   {
      #region IContactView
      public string ViewText
      {
         set { Text = value; }
      }

      private int id;
      public int Id
      {
         get { return id; }
         set { id = value; }
      }

      public string ContactName
      {
         get { return txtContactName.Text; }
         set { txtContactName.Text = value; }
      }

      public string PhoneNumber1
      {
         get { return txtPhoneNumber1.Text; }
         set { txtPhoneNumber1.Text = value; }
      }

      public string PhoneNumber2
      {
         get { return txtPhoneNumber2.Text; }
         set { txtPhoneNumber2.Text = value; }
      }

      public bool IsDoctor
      {
         get { return chkIsDoctor.Checked; }
         set { chkIsDoctor.Checked = value; }
      }

      public void CloseView()
      {
         Close();
      }

      public void Notify(string message, MessageType type)
      {

      }

      public bool Confirm(string message)
      {
         return true;
      }

      public void ShowView()
      {
         ShowDialog();
      }

      public event Action SaveContact;
      #endregion

      public ContactView()
      {
         InitializeComponent();
      }

      private void btnOK_Click(object sender, EventArgs e)
      {
         if (IsFormValid())
            SaveContact();
      }

      #region Validation
      private bool IsFormValid()
      {
         if (FormValidator.HasValidationErrors(Controls))
            return false;

         return true;
      }


      private void txtContactName_Validating(object sender, System.ComponentModel.CancelEventArgs e)
      {
         if (string.IsNullOrWhiteSpace(txtContactName.Text.Trim()))
         {
            errorProvider.SetError(txtContactName, AppConfig.Parameters.ValidationMessages.RequiredField);
            e.Cancel = true;
            return;
         }
         else
            errorProvider.SetError(txtContactName, string.Empty);
      }

      private void txtPhoneNumber1_Validating(object sender, System.ComponentModel.CancelEventArgs e)
      {
         if (string.IsNullOrWhiteSpace(txtPhoneNumber1.Text.Trim()))
         {
            errorProvider.SetError(txtPhoneNumber1, AppConfig.Parameters.ValidationMessages.EnterAtLeastAPhone);
            e.Cancel = true;
            return;
         }
         else
            errorProvider.SetError(txtPhoneNumber1, string.Empty);
      }

      private void txtPhoneNumber1_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
      {
         if (!char.IsControl(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Space && Regex.IsMatch(e.KeyChar.ToString(), @"[^0-9^+^\- \/]"))
            e.Handled = true;
      }
      #endregion
   }
}