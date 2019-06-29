namespace Management.User
{
	partial class UserProfileView
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserProfileView));
			this.defaultLookAndFeel = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
			this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
			this.btnChangePassword = new DevExpress.XtraEditors.SimpleButton();
			this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
			this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
			this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
			this.txtCurrentPassword = new System.Windows.Forms.TextBox();
			this.txtConfirmPassword = new System.Windows.Forms.TextBox();
			this.txtNewPassword = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
			this.SuspendLayout();
			// 
			// defaultLookAndFeel
			// 
			this.defaultLookAndFeel.LookAndFeel.SkinName = "Office 2016 Colorful";
			// 
			// errorProvider
			// 
			this.errorProvider.ContainerControl = this;
			this.errorProvider.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider.Icon")));
			// 
			// btnChangePassword
			// 
			this.btnChangePassword.Location = new System.Drawing.Point(290, 108);
			this.btnChangePassword.Name = "btnChangePassword";
			this.btnChangePassword.Size = new System.Drawing.Size(120, 23);
			this.btnChangePassword.TabIndex = 3;
			this.btnChangePassword.Text = "Cambiar contraseña";
			this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
			// 
			// labelControl1
			// 
			this.labelControl1.Location = new System.Drawing.Point(12, 30);
			this.labelControl1.Name = "labelControl1";
			this.labelControl1.Size = new System.Drawing.Size(92, 13);
			this.labelControl1.TabIndex = 1;
			this.labelControl1.Text = "Contraseña actual:";
			// 
			// labelControl2
			// 
			this.labelControl2.Location = new System.Drawing.Point(12, 57);
			this.labelControl2.Name = "labelControl2";
			this.labelControl2.Size = new System.Drawing.Size(93, 13);
			this.labelControl2.TabIndex = 2;
			this.labelControl2.Text = "Contraseña nueva:";
			// 
			// labelControl3
			// 
			this.labelControl3.Location = new System.Drawing.Point(12, 84);
			this.labelControl3.Name = "labelControl3";
			this.labelControl3.Size = new System.Drawing.Size(108, 13);
			this.labelControl3.TabIndex = 3;
			this.labelControl3.Text = "Confirmar contraseña:";
			// 
			// txtCurrentPassword
			// 
			this.txtCurrentPassword.Location = new System.Drawing.Point(126, 27);
			this.txtCurrentPassword.MaxLength = 256;
			this.txtCurrentPassword.Name = "txtCurrentPassword";
			this.txtCurrentPassword.Size = new System.Drawing.Size(284, 21);
			this.txtCurrentPassword.TabIndex = 0;
			this.txtCurrentPassword.UseSystemPasswordChar = true;
			// 
			// txtConfirmPassword
			// 
			this.txtConfirmPassword.Location = new System.Drawing.Point(126, 81);
			this.txtConfirmPassword.MaxLength = 256;
			this.txtConfirmPassword.Name = "txtConfirmPassword";
			this.txtConfirmPassword.Size = new System.Drawing.Size(284, 21);
			this.txtConfirmPassword.TabIndex = 2;
			this.txtConfirmPassword.UseSystemPasswordChar = true;
			// 
			// txtNewPassword
			// 
			this.txtNewPassword.Location = new System.Drawing.Point(126, 54);
			this.txtNewPassword.MaxLength = 256;
			this.txtNewPassword.Name = "txtNewPassword";
			this.txtNewPassword.Size = new System.Drawing.Size(284, 21);
			this.txtNewPassword.TabIndex = 1;
			this.txtNewPassword.UseSystemPasswordChar = true;
			// 
			// UserProfileView
			// 
			this.AcceptButton = this.btnChangePassword;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(431, 144);
			this.Controls.Add(this.txtNewPassword);
			this.Controls.Add(this.txtConfirmPassword);
			this.Controls.Add(this.txtCurrentPassword);
			this.Controls.Add(this.labelControl3);
			this.Controls.Add(this.labelControl2);
			this.Controls.Add(this.labelControl1);
			this.Controls.Add(this.btnChangePassword);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "UserProfileView";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Mi perfil";
			this.Load += new System.EventHandler(this.UserProfileView_Load);
			((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel;
		private System.Windows.Forms.ErrorProvider errorProvider;
		private System.Windows.Forms.TextBox txtNewPassword;
		private System.Windows.Forms.TextBox txtConfirmPassword;
		private System.Windows.Forms.TextBox txtCurrentPassword;
		private DevExpress.XtraEditors.LabelControl labelControl3;
		private DevExpress.XtraEditors.LabelControl labelControl2;
		private DevExpress.XtraEditors.LabelControl labelControl1;
		private DevExpress.XtraEditors.SimpleButton btnChangePassword;
	}
}