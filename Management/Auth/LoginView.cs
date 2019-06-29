using Corlib;
using Corlib.Config;
using Corlib.Views.Contracts;
using Corlib.Views.ViewModels;
using DevExpress.XtraEditors;
using System;

namespace Management.Auth
{
   public partial class LoginView : XtraForm, ILoginView
   {
      public LoginView()
      {
         InitializeComponent();
      }

      #region ILoginView
      public string LoginResultMessage
      {
         get { return lbMessage.Text; }
         set { lbMessage.Text = value; }
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

      }

      public bool Confirm(string message)
      {
         return true;
      }

      public event Action<EventArgs<UserViewModel>> Login;
      #endregion

      private void LoginView_Load(object sender, EventArgs e)
      {
         defaultLookAndFeel.LookAndFeel.SkinName = AppConfig.Parameters.Skin;
         lbCopyright.Text = $"Brugnner © {DateTime.Today.Year}";
      }

      private void btnLogin_Click(object sender, EventArgs e)
      {
         Login(new EventArgs<UserViewModel>(new UserViewModel(txtUsername.Text, txtPassword.Text)));
      }

      private void txtUsername_TextChanged(object sender, EventArgs e)
      {
         lbMessage.Text = string.Empty;
      }

      private void txtPassword_TextChanged(object sender, EventArgs e)
      {
         lbMessage.Text = string.Empty;
      }
   }
}