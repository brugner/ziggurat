namespace Management.Members.Contacts
{
   partial class ContactView
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ContactView));
			this.defaultLookAndFeel = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
			this.txtContactName = new System.Windows.Forms.TextBox();
			this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
			this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
			this.btnOK = new DevExpress.XtraEditors.SimpleButton();
			this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
			this.txtPhoneNumber1 = new System.Windows.Forms.TextBox();
			this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
			this.txtPhoneNumber2 = new System.Windows.Forms.TextBox();
			this.chkIsDoctor = new System.Windows.Forms.CheckBox();
			this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
			((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
			this.SuspendLayout();
			// 
			// defaultLookAndFeel
			// 
			this.defaultLookAndFeel.LookAndFeel.SkinName = "Office 2016 Colorful";
			// 
			// txtContactName
			// 
			this.txtContactName.Location = new System.Drawing.Point(81, 16);
			this.txtContactName.MaxLength = 50;
			this.txtContactName.Name = "txtContactName";
			this.txtContactName.Size = new System.Drawing.Size(191, 21);
			this.txtContactName.TabIndex = 0;
			this.txtContactName.Validating += new System.ComponentModel.CancelEventHandler(this.txtContactName_Validating);
			// 
			// labelControl1
			// 
			this.labelControl1.Location = new System.Drawing.Point(12, 19);
			this.labelControl1.Name = "labelControl1";
			this.labelControl1.Size = new System.Drawing.Size(41, 13);
			this.labelControl1.TabIndex = 1;
			this.labelControl1.Text = "Nombre:";
			// 
			// btnCancel
			// 
			this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCancel.CausesValidation = false;
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Location = new System.Drawing.Point(197, 124);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 5;
			this.btnCancel.Text = "Cancelar";
			// 
			// btnOK
			// 
			this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnOK.Location = new System.Drawing.Point(116, 124);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(75, 23);
			this.btnOK.TabIndex = 4;
			this.btnOK.Text = "Aceptar";
			this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
			// 
			// labelControl2
			// 
			this.labelControl2.Location = new System.Drawing.Point(12, 46);
			this.labelControl2.Name = "labelControl2";
			this.labelControl2.Size = new System.Drawing.Size(63, 13);
			this.labelControl2.TabIndex = 5;
			this.labelControl2.Text = "Teléfono #1:";
			// 
			// txtPhoneNumber1
			// 
			this.txtPhoneNumber1.Location = new System.Drawing.Point(81, 43);
			this.txtPhoneNumber1.MaxLength = 50;
			this.txtPhoneNumber1.Name = "txtPhoneNumber1";
			this.txtPhoneNumber1.Size = new System.Drawing.Size(191, 21);
			this.txtPhoneNumber1.TabIndex = 1;
			this.txtPhoneNumber1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPhoneNumber1_KeyPress);
			this.txtPhoneNumber1.Validating += new System.ComponentModel.CancelEventHandler(this.txtPhoneNumber1_Validating);
			// 
			// labelControl3
			// 
			this.labelControl3.Location = new System.Drawing.Point(12, 73);
			this.labelControl3.Name = "labelControl3";
			this.labelControl3.Size = new System.Drawing.Size(63, 13);
			this.labelControl3.TabIndex = 7;
			this.labelControl3.Text = "Teléfono #2:";
			// 
			// txtPhoneNumber2
			// 
			this.txtPhoneNumber2.Location = new System.Drawing.Point(81, 70);
			this.txtPhoneNumber2.MaxLength = 50;
			this.txtPhoneNumber2.Name = "txtPhoneNumber2";
			this.txtPhoneNumber2.Size = new System.Drawing.Size(191, 21);
			this.txtPhoneNumber2.TabIndex = 2;
			this.txtPhoneNumber2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPhoneNumber1_KeyPress);
			// 
			// chkIsDoctor
			// 
			this.chkIsDoctor.AutoSize = true;
			this.chkIsDoctor.Location = new System.Drawing.Point(81, 97);
			this.chkIsDoctor.Name = "chkIsDoctor";
			this.chkIsDoctor.Size = new System.Drawing.Size(73, 17);
			this.chkIsDoctor.TabIndex = 3;
			this.chkIsDoctor.Text = "Es médico";
			this.chkIsDoctor.UseVisualStyleBackColor = true;
			// 
			// errorProvider
			// 
			this.errorProvider.ContainerControl = this;
			this.errorProvider.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider.Icon")));
			// 
			// ContactView
			// 
			this.AcceptButton = this.btnOK;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnCancel;
			this.ClientSize = new System.Drawing.Size(292, 159);
			this.Controls.Add(this.chkIsDoctor);
			this.Controls.Add(this.labelControl3);
			this.Controls.Add(this.txtPhoneNumber2);
			this.Controls.Add(this.labelControl2);
			this.Controls.Add(this.txtPhoneNumber1);
			this.Controls.Add(this.btnOK);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.labelControl1);
			this.Controls.Add(this.txtContactName);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "ContactView";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "ContactView";
			((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

      }

      #endregion

      private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel;
      private System.Windows.Forms.TextBox txtContactName;
      private DevExpress.XtraEditors.LabelControl labelControl1;
      private DevExpress.XtraEditors.SimpleButton btnCancel;
      private DevExpress.XtraEditors.SimpleButton btnOK;
      private DevExpress.XtraEditors.LabelControl labelControl2;
      private System.Windows.Forms.TextBox txtPhoneNumber1;
      private DevExpress.XtraEditors.LabelControl labelControl3;
      private System.Windows.Forms.TextBox txtPhoneNumber2;
      private System.Windows.Forms.CheckBox chkIsDoctor;
      private System.Windows.Forms.ErrorProvider errorProvider;
   }
}