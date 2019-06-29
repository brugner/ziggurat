using Corlib;
using Corlib.Config;
using Corlib.Views.Contracts;
using DevExpress.XtraEditors;
using System;

namespace Management.Members.Notes
{
   public partial class NoteView : XtraForm, INoteView
   {
      public NoteView()
      {
         InitializeComponent();
      }

      #region INoteView
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

      public string NoteText
      {
         get { return txtNoteText.Text; }
         set { txtNoteText.Text = value; }
      }

      public DateTime Date
      {
         set { lbDateTime.Text = value.ToShortDateString() + " " + value.ToShortTimeString(); }
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

      public event Action SaveNote;
      #endregion

      private void btnOK_Click(object sender, EventArgs e)
      {
         if (IsFormValid())
            SaveNote();
      }

      #region Validation
      private bool IsFormValid()
      {
         if (FormValidator.HasValidationErrors(Controls))
            return false;

         return true;
      }
      #endregion

      private void NoteView_Load(object sender, EventArgs e)
      {
         lbDateTime.Text = DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString();
      }

      private void txtNoteText_Validating(object sender, System.ComponentModel.CancelEventArgs e)
      {
         if (string.IsNullOrWhiteSpace(txtNoteText.Text.Trim()))
         {
            errorProvider.SetError(txtNoteText, AppConfig.Parameters.ValidationMessages.RequiredField);
            e.Cancel = true;
            return;
         }
         else
            errorProvider.SetError(txtNoteText, string.Empty);
      }
   }
}