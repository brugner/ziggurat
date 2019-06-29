using Corlib;
using Corlib.Config;
using Corlib.Views.Contracts;
using Corlib.Views.ViewModels;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Management.Messages
{
   public partial class MessageView : XtraForm, IMessageView
   {
      public MessageView()
      {
         InitializeComponent();
      }

      #region IMessageView
      public string ViewText
      {
         set { Text = value; }
      }

      public string Subject
      {
         get { return txtSubject.Text; }
         set { txtSubject.Text = value; }
      }

      public IEnumerable<MemberViewModel> Recipients
      {
         get { return (IEnumerable<MemberViewModel>)lbcRecipients.DataSource; }
         set
         {
            lbcRecipients.DataSource = value;
            lbcRecipients.ValueMember = "Id";
            lbcRecipients.DisplayMember = "FullName";
         }
      }

      public string MessageBody
      {
         get { return txtBody.Text; }
         set { txtBody.Text = value; }
      }

      public DateTime Date
      {
         set { lbDateTime.Text = value.ToShortDateString() + " " + value.ToShortTimeString(); }
      }

      public void InitializeView()
      {
         txtSubject.Select();
      }

      public void ShowView()
      {
         ShowDialog();
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

      public void DisableFields()
      {
         txtSubject.Enabled = false;
         txtBody.Enabled = false;
         lbcRecipients.Enabled = false;
         btnSend.Enabled = false;
         linkAddRecipient.Enabled = false;
         linkAddAllRecipients.Enabled = false;
         linkRemoveAllRecipients.Enabled = false;
      }

      public event Action AddRecipient;
      public event Action AddAllRecipients;
      public event Action RemoveAllRecipients;
      public event Action<EventArgs<MemberViewModel>> RemoveOneRecipient;
      public event Action SendMessage;
      #endregion

      private void MessageView_Load(object sender, EventArgs e)
      {
         defaultLookAndFeel.LookAndFeel.SkinName = AppConfig.Parameters.Skin;
      }

      private void linkAddRecipient_Click(object sender, System.EventArgs e)
      {
         AddRecipient();
      }

      private void linkAddAllRecipients_Click(object sender, System.EventArgs e)
      {
         AddAllRecipients();
      }

      private void linkRemoveAllRecipients_Click(object sender, System.EventArgs e)
      {
         RemoveAllRecipients();
      }

      private void lbcRecipients_DoubleClick(object sender, EventArgs e)
      {
         var recipient = (MemberViewModel)lbcRecipients.SelectedItem;
         RemoveOneRecipient(new EventArgs<MemberViewModel>(recipient));
      }

      #region Validation
      private bool IsFormValid()
      {
         if (FormValidator.HasValidationErrors(Controls))
            return false;

         return true;
      }

      private void txtSubject_Validating(object sender, System.ComponentModel.CancelEventArgs e)
      {
         if (string.IsNullOrWhiteSpace(txtSubject.Text.Trim()))
         {
            errorProvider.SetError(txtSubject, AppConfig.Parameters.ValidationMessages.RequiredField);
            e.Cancel = true;
            return;
         }
         else
            errorProvider.SetError(txtSubject, string.Empty);
      }

      private void lbcRecipients_Validating(object sender, System.ComponentModel.CancelEventArgs e)
      {
         if (lbcRecipients.ItemCount == 0)
         {
            errorProvider.SetError(lbcRecipients, AppConfig.Parameters.ValidationMessages.SelectAtLeastOne);
            e.Cancel = true;
            return;
         }
         else
            errorProvider.SetError(lbcRecipients, string.Empty);
      }

      private void txtBody_Validating(object sender, System.ComponentModel.CancelEventArgs e)
      {
         if (string.IsNullOrWhiteSpace(txtBody.Text.Trim()))
         {
            errorProvider.SetError(txtBody, AppConfig.Parameters.ValidationMessages.RequiredField);
            e.Cancel = true;
            return;
         }
         else
            errorProvider.SetError(txtBody, string.Empty);
      }
      #endregion

      private void btnSend_Click(object sender, EventArgs e)
      {
         if (IsFormValid())
            SendMessage();
      }

      private void btnCancel_Click(object sender, EventArgs e)
      {
         Close();
      }
   }
}