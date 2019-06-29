using AccessControl.About;
using AccessControl.Help;
using Corlib;
using Corlib.Config;
using Corlib.Views.Contracts;
using DevExpress.XtraEditors;
using System;
using System.Windows.Forms;

namespace AccessControl.MemberLogin
{
   public partial class MemberLoginView : XtraForm, IMemberLoginView
   {
      public MemberLoginView()
      {
         InitializeComponent();
      }

      #region IMemberLoginView
      public string ViewText
      {
         set { Text = value; }
      }

      public void ShowView()
      {
         Show();
      }

      public void HideView()
      {
         Hide();
      }

      public void CloseView()
      {
         Close();
      }

      public void Notify(string message, MessageType type)
      {
         lbMessage.Text = message;
      }

      public bool Confirm(string message)
      {
         return true;
      }

      public void ShowAboutView()
      {
         var view = new AboutView();
         view.ShowDialog();
      }

      public void ShowErrorMessage(string message)
      {
         MessageBox.Show(message, AppConfig.AppName, MessageBoxButtons.OK, MessageBoxIcon.Error);
      }

      public event Action<int> Login;
      #endregion

      private void MemberLoginView_Load(object sender, EventArgs e)
      {
         lbCopyleft.Text = $"Brugnner © {DateTime.Today.Year}";
         txtDNI.Focus();
      }

      private void txtDNI_KeyPress(object sender, KeyPressEventArgs e)
      {
         if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            e.Handled = true;

         if (e.KeyChar == (char)Keys.Enter)
            TryLogin();

         if (e.KeyChar == '-')
            Clear();

         if (e.KeyChar == '*')
            ShowHelp();
      }

      private void TryLogin()
      {
         int.TryParse(txtDNI.Text, out int dni);
         Login(dni);
      }

      private void Clear()
      {
         lbMessage.Text = string.Empty;
         txtDNI.Clear();
         txtDNI.Focus();
      }

      private void ShowHelp()
      {
         var view = new AccessControlHelpView();
         view.ShowDialog();
      }
   }
}