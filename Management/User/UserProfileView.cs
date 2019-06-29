using Corlib;
using Corlib.Config;
using Corlib.Views.Contracts;
using DevExpress.XtraEditors;
using System;
using System.Windows.Forms;

namespace Management.User
{
	public partial class UserProfileView : XtraForm, IUserProfileView
	{
		public UserProfileView()
		{
			InitializeComponent();
		}

		#region IUserProfileView
		public string CurrentPassword
		{
			get { return txtCurrentPassword.Text; }
			set { txtCurrentPassword.Text = value; }
		}

		public string NewPassword
		{
			get { return txtNewPassword.Text; }
			set { txtNewPassword.Text = value; }
		}

		public string ConfirmPassword
		{
			get { return txtConfirmPassword.Text; }
			set { txtConfirmPassword.Text = value; }
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
			Show();
		}

		public event Action ChangePassword;
		#endregion

		private void UserProfileView_Load(object sender, EventArgs e)
		{
			defaultLookAndFeel.LookAndFeel.SkinName = AppConfig.Parameters.Skin;
		}

		private void btnChangePassword_Click(object sender, EventArgs e)
		{
			ChangePassword();
		}
	}
}