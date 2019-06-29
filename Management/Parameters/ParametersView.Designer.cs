namespace Management.Parameters
{
   partial class ParametersView
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ParametersView));
			this.defaultLookAndFeel = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
			this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
			this.cboSkin = new System.Windows.Forms.ComboBox();
			this.gbAppearance = new System.Windows.Forms.GroupBox();
			this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
			this.btnOK = new DevExpress.XtraEditors.SimpleButton();
			this.gbValidations = new System.Windows.Forms.GroupBox();
			this.txtSelectAtLeastOne = new System.Windows.Forms.TextBox();
			this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
			this.txtEnterPhoneNumber = new System.Windows.Forms.TextBox();
			this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
			this.txtEnterMobilePhoneAreaCode = new System.Windows.Forms.TextBox();
			this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
			this.txtEnterAtLeastAPhone = new System.Windows.Forms.TextBox();
			this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
			this.txtInvalidEmailAddress = new System.Windows.Forms.TextBox();
			this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
			this.txtRequiredField = new System.Windows.Forms.TextBox();
			this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
			this.gbGym = new System.Windows.Forms.GroupBox();
			this.txtGymInstagram = new System.Windows.Forms.TextBox();
			this.labelControl15 = new DevExpress.XtraEditors.LabelControl();
			this.txtGymTwitter = new System.Windows.Forms.TextBox();
			this.labelControl14 = new DevExpress.XtraEditors.LabelControl();
			this.txtGymFacebook = new System.Windows.Forms.TextBox();
			this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
			this.txtGymEmail = new System.Windows.Forms.TextBox();
			this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
			this.txtGymPhone = new System.Windows.Forms.TextBox();
			this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
			this.txtGymAddress = new System.Windows.Forms.TextBox();
			this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
			this.cboCity = new System.Windows.Forms.ComboBox();
			this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
			this.txtGymName = new System.Windows.Forms.TextBox();
			this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
			this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
			this.gbAppearance.SuspendLayout();
			this.gbValidations.SuspendLayout();
			this.gbGym.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
			this.SuspendLayout();
			// 
			// defaultLookAndFeel
			// 
			this.defaultLookAndFeel.LookAndFeel.SkinName = "Office 2016 Colorful";
			// 
			// labelControl1
			// 
			this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelControl1.Appearance.Options.UseFont = true;
			this.labelControl1.Location = new System.Drawing.Point(9, 23);
			this.labelControl1.Name = "labelControl1";
			this.labelControl1.Size = new System.Drawing.Size(35, 14);
			this.labelControl1.TabIndex = 0;
			this.labelControl1.Text = "Tema:";
			// 
			// cboSkin
			// 
			this.cboSkin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboSkin.FormattingEnabled = true;
			this.cboSkin.Items.AddRange(new object[] {
            "Office 2016 Colorful",
            "Office 2016 Dark",
            "Office 2013 White",
            "Visual Studio 2013 Light",
            "Office 2010 Silver"});
			this.cboSkin.Location = new System.Drawing.Point(155, 20);
			this.cboSkin.Name = "cboSkin";
			this.cboSkin.Size = new System.Drawing.Size(324, 22);
			this.cboSkin.TabIndex = 1;
			// 
			// gbAppearance
			// 
			this.gbAppearance.BackColor = System.Drawing.Color.Transparent;
			this.gbAppearance.Controls.Add(this.labelControl1);
			this.gbAppearance.Controls.Add(this.cboSkin);
			this.gbAppearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gbAppearance.Location = new System.Drawing.Point(452, 214);
			this.gbAppearance.Name = "gbAppearance";
			this.gbAppearance.Size = new System.Drawing.Size(502, 49);
			this.gbAppearance.TabIndex = 3;
			this.gbAppearance.TabStop = false;
			this.gbAppearance.Text = "Apariencia";
			// 
			// btnCancel
			// 
			this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCancel.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCancel.Appearance.Options.UseFont = true;
			this.btnCancel.CausesValidation = false;
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Location = new System.Drawing.Point(879, 275);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 5;
			this.btnCancel.Text = "Cancelar";
			// 
			// btnOK
			// 
			this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnOK.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnOK.Appearance.Options.UseFont = true;
			this.btnOK.Location = new System.Drawing.Point(798, 275);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(75, 23);
			this.btnOK.TabIndex = 4;
			this.btnOK.Text = "Aceptar";
			this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
			// 
			// gbValidations
			// 
			this.gbValidations.BackColor = System.Drawing.Color.Transparent;
			this.gbValidations.Controls.Add(this.txtSelectAtLeastOne);
			this.gbValidations.Controls.Add(this.labelControl7);
			this.gbValidations.Controls.Add(this.txtEnterPhoneNumber);
			this.gbValidations.Controls.Add(this.labelControl6);
			this.gbValidations.Controls.Add(this.txtEnterMobilePhoneAreaCode);
			this.gbValidations.Controls.Add(this.labelControl5);
			this.gbValidations.Controls.Add(this.txtEnterAtLeastAPhone);
			this.gbValidations.Controls.Add(this.labelControl4);
			this.gbValidations.Controls.Add(this.txtInvalidEmailAddress);
			this.gbValidations.Controls.Add(this.labelControl3);
			this.gbValidations.Controls.Add(this.txtRequiredField);
			this.gbValidations.Controls.Add(this.labelControl2);
			this.gbValidations.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gbValidations.Location = new System.Drawing.Point(452, 12);
			this.gbValidations.Name = "gbValidations";
			this.gbValidations.Size = new System.Drawing.Size(502, 196);
			this.gbValidations.TabIndex = 2;
			this.gbValidations.TabStop = false;
			this.gbValidations.Text = "Validaciones";
			// 
			// txtSelectAtLeastOne
			// 
			this.txtSelectAtLeastOne.Location = new System.Drawing.Point(155, 161);
			this.txtSelectAtLeastOne.MaxLength = 50;
			this.txtSelectAtLeastOne.Name = "txtSelectAtLeastOne";
			this.txtSelectAtLeastOne.Size = new System.Drawing.Size(324, 22);
			this.txtSelectAtLeastOne.TabIndex = 6;
			this.txtSelectAtLeastOne.Validating += new System.ComponentModel.CancelEventHandler(this.txtSelectAtLeastOne_Validating);
			// 
			// labelControl7
			// 
			this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelControl7.Appearance.Options.UseFont = true;
			this.labelControl7.Location = new System.Drawing.Point(11, 161);
			this.labelControl7.Name = "labelControl7";
			this.labelControl7.Size = new System.Drawing.Size(138, 14);
			this.labelControl7.TabIndex = 10;
			this.labelControl7.Text = "Selecciona al menos uno:";
			// 
			// txtEnterPhoneNumber
			// 
			this.txtEnterPhoneNumber.Location = new System.Drawing.Point(155, 133);
			this.txtEnterPhoneNumber.MaxLength = 50;
			this.txtEnterPhoneNumber.Name = "txtEnterPhoneNumber";
			this.txtEnterPhoneNumber.Size = new System.Drawing.Size(324, 22);
			this.txtEnterPhoneNumber.TabIndex = 5;
			this.txtEnterPhoneNumber.Validating += new System.ComponentModel.CancelEventHandler(this.txtEnterPhoneNumber_Validating);
			// 
			// labelControl6
			// 
			this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelControl6.Appearance.Options.UseFont = true;
			this.labelControl6.Location = new System.Drawing.Point(11, 134);
			this.labelControl6.Name = "labelControl6";
			this.labelControl6.Size = new System.Drawing.Size(107, 14);
			this.labelControl6.TabIndex = 8;
			this.labelControl6.Text = "Ingresa el teléfono:";
			// 
			// txtEnterMobilePhoneAreaCode
			// 
			this.txtEnterMobilePhoneAreaCode.Location = new System.Drawing.Point(155, 105);
			this.txtEnterMobilePhoneAreaCode.MaxLength = 50;
			this.txtEnterMobilePhoneAreaCode.Name = "txtEnterMobilePhoneAreaCode";
			this.txtEnterMobilePhoneAreaCode.Size = new System.Drawing.Size(324, 22);
			this.txtEnterMobilePhoneAreaCode.TabIndex = 4;
			this.txtEnterMobilePhoneAreaCode.Validating += new System.ComponentModel.CancelEventHandler(this.txtEnterMobilePhoneAreaCode_Validating);
			// 
			// labelControl5
			// 
			this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelControl5.Appearance.Options.UseFont = true;
			this.labelControl5.Location = new System.Drawing.Point(11, 107);
			this.labelControl5.Name = "labelControl5";
			this.labelControl5.Size = new System.Drawing.Size(130, 14);
			this.labelControl5.TabIndex = 6;
			this.labelControl5.Text = "Ingresa la característica:";
			// 
			// txtEnterAtLeastAPhone
			// 
			this.txtEnterAtLeastAPhone.Location = new System.Drawing.Point(155, 77);
			this.txtEnterAtLeastAPhone.MaxLength = 50;
			this.txtEnterAtLeastAPhone.Name = "txtEnterAtLeastAPhone";
			this.txtEnterAtLeastAPhone.Size = new System.Drawing.Size(324, 22);
			this.txtEnterAtLeastAPhone.TabIndex = 3;
			this.txtEnterAtLeastAPhone.Validating += new System.ComponentModel.CancelEventHandler(this.txtEnterAtLeastAPhone_Validating);
			// 
			// labelControl4
			// 
			this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelControl4.Appearance.Options.UseFont = true;
			this.labelControl4.Location = new System.Drawing.Point(11, 80);
			this.labelControl4.Name = "labelControl4";
			this.labelControl4.Size = new System.Drawing.Size(109, 14);
			this.labelControl4.TabIndex = 4;
			this.labelControl4.Text = "Mínimo un teléfono:";
			// 
			// txtInvalidEmailAddress
			// 
			this.txtInvalidEmailAddress.Location = new System.Drawing.Point(155, 49);
			this.txtInvalidEmailAddress.MaxLength = 50;
			this.txtInvalidEmailAddress.Name = "txtInvalidEmailAddress";
			this.txtInvalidEmailAddress.Size = new System.Drawing.Size(324, 22);
			this.txtInvalidEmailAddress.TabIndex = 2;
			this.txtInvalidEmailAddress.Validating += new System.ComponentModel.CancelEventHandler(this.txtInvalidEmailAddress_Validating);
			// 
			// labelControl3
			// 
			this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelControl3.Appearance.Options.UseFont = true;
			this.labelControl3.Location = new System.Drawing.Point(11, 53);
			this.labelControl3.Name = "labelControl3";
			this.labelControl3.Size = new System.Drawing.Size(72, 14);
			this.labelControl3.TabIndex = 2;
			this.labelControl3.Text = "Email inváido:";
			// 
			// txtRequiredField
			// 
			this.txtRequiredField.Location = new System.Drawing.Point(155, 21);
			this.txtRequiredField.MaxLength = 50;
			this.txtRequiredField.Name = "txtRequiredField";
			this.txtRequiredField.Size = new System.Drawing.Size(324, 22);
			this.txtRequiredField.TabIndex = 1;
			this.txtRequiredField.Validating += new System.ComponentModel.CancelEventHandler(this.txtRequiredField_Validating);
			// 
			// labelControl2
			// 
			this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelControl2.Appearance.Options.UseFont = true;
			this.labelControl2.Location = new System.Drawing.Point(11, 26);
			this.labelControl2.Name = "labelControl2";
			this.labelControl2.Size = new System.Drawing.Size(97, 14);
			this.labelControl2.TabIndex = 0;
			this.labelControl2.Text = "Campo requerido:";
			// 
			// gbGym
			// 
			this.gbGym.BackColor = System.Drawing.Color.Transparent;
			this.gbGym.Controls.Add(this.txtGymInstagram);
			this.gbGym.Controls.Add(this.labelControl15);
			this.gbGym.Controls.Add(this.txtGymTwitter);
			this.gbGym.Controls.Add(this.labelControl14);
			this.gbGym.Controls.Add(this.txtGymFacebook);
			this.gbGym.Controls.Add(this.labelControl13);
			this.gbGym.Controls.Add(this.txtGymEmail);
			this.gbGym.Controls.Add(this.labelControl12);
			this.gbGym.Controls.Add(this.txtGymPhone);
			this.gbGym.Controls.Add(this.labelControl9);
			this.gbGym.Controls.Add(this.txtGymAddress);
			this.gbGym.Controls.Add(this.labelControl8);
			this.gbGym.Controls.Add(this.cboCity);
			this.gbGym.Controls.Add(this.labelControl10);
			this.gbGym.Controls.Add(this.txtGymName);
			this.gbGym.Controls.Add(this.labelControl11);
			this.gbGym.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gbGym.Location = new System.Drawing.Point(12, 12);
			this.gbGym.Name = "gbGym";
			this.gbGym.Size = new System.Drawing.Size(434, 251);
			this.gbGym.TabIndex = 1;
			this.gbGym.TabStop = false;
			this.gbGym.Text = "Gimnasio";
			// 
			// txtGymInstagram
			// 
			this.txtGymInstagram.Location = new System.Drawing.Point(87, 217);
			this.txtGymInstagram.MaxLength = 75;
			this.txtGymInstagram.Name = "txtGymInstagram";
			this.txtGymInstagram.Size = new System.Drawing.Size(324, 22);
			this.txtGymInstagram.TabIndex = 8;
			// 
			// labelControl15
			// 
			this.labelControl15.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelControl15.Appearance.Options.UseFont = true;
			this.labelControl15.Location = new System.Drawing.Point(11, 221);
			this.labelControl15.Name = "labelControl15";
			this.labelControl15.Size = new System.Drawing.Size(58, 14);
			this.labelControl15.TabIndex = 13;
			this.labelControl15.Text = "Instagram:";
			// 
			// txtGymTwitter
			// 
			this.txtGymTwitter.Location = new System.Drawing.Point(87, 189);
			this.txtGymTwitter.MaxLength = 75;
			this.txtGymTwitter.Name = "txtGymTwitter";
			this.txtGymTwitter.Size = new System.Drawing.Size(324, 22);
			this.txtGymTwitter.TabIndex = 7;
			// 
			// labelControl14
			// 
			this.labelControl14.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelControl14.Appearance.Options.UseFont = true;
			this.labelControl14.Location = new System.Drawing.Point(11, 193);
			this.labelControl14.Name = "labelControl14";
			this.labelControl14.Size = new System.Drawing.Size(45, 14);
			this.labelControl14.TabIndex = 11;
			this.labelControl14.Text = "Twitter:";
			// 
			// txtGymFacebook
			// 
			this.txtGymFacebook.Location = new System.Drawing.Point(87, 161);
			this.txtGymFacebook.MaxLength = 75;
			this.txtGymFacebook.Name = "txtGymFacebook";
			this.txtGymFacebook.Size = new System.Drawing.Size(324, 22);
			this.txtGymFacebook.TabIndex = 6;
			// 
			// labelControl13
			// 
			this.labelControl13.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelControl13.Appearance.Options.UseFont = true;
			this.labelControl13.Location = new System.Drawing.Point(11, 165);
			this.labelControl13.Name = "labelControl13";
			this.labelControl13.Size = new System.Drawing.Size(56, 14);
			this.labelControl13.TabIndex = 9;
			this.labelControl13.Text = "Facebook:";
			// 
			// txtGymEmail
			// 
			this.txtGymEmail.Location = new System.Drawing.Point(87, 133);
			this.txtGymEmail.MaxLength = 50;
			this.txtGymEmail.Name = "txtGymEmail";
			this.txtGymEmail.Size = new System.Drawing.Size(324, 22);
			this.txtGymEmail.TabIndex = 5;
			this.txtGymEmail.Validating += new System.ComponentModel.CancelEventHandler(this.txtGymEmail_Validating);
			// 
			// labelControl12
			// 
			this.labelControl12.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelControl12.Appearance.Options.UseFont = true;
			this.labelControl12.Location = new System.Drawing.Point(11, 137);
			this.labelControl12.Name = "labelControl12";
			this.labelControl12.Size = new System.Drawing.Size(31, 14);
			this.labelControl12.TabIndex = 7;
			this.labelControl12.Text = "Email:";
			// 
			// txtGymPhone
			// 
			this.txtGymPhone.Location = new System.Drawing.Point(87, 105);
			this.txtGymPhone.MaxLength = 50;
			this.txtGymPhone.Name = "txtGymPhone";
			this.txtGymPhone.Size = new System.Drawing.Size(324, 22);
			this.txtGymPhone.TabIndex = 4;
			this.txtGymPhone.Validating += new System.ComponentModel.CancelEventHandler(this.txtGymPhone_Validating);
			// 
			// labelControl9
			// 
			this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelControl9.Appearance.Options.UseFont = true;
			this.labelControl9.Location = new System.Drawing.Point(11, 109);
			this.labelControl9.Name = "labelControl9";
			this.labelControl9.Size = new System.Drawing.Size(53, 14);
			this.labelControl9.TabIndex = 5;
			this.labelControl9.Text = "Teléfono:";
			// 
			// txtGymAddress
			// 
			this.txtGymAddress.Location = new System.Drawing.Point(87, 49);
			this.txtGymAddress.MaxLength = 50;
			this.txtGymAddress.Name = "txtGymAddress";
			this.txtGymAddress.Size = new System.Drawing.Size(324, 22);
			this.txtGymAddress.TabIndex = 2;
			this.txtGymAddress.Validating += new System.ComponentModel.CancelEventHandler(this.txtGymAddress_Validating);
			// 
			// labelControl8
			// 
			this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelControl8.Appearance.Options.UseFont = true;
			this.labelControl8.Location = new System.Drawing.Point(11, 53);
			this.labelControl8.Name = "labelControl8";
			this.labelControl8.Size = new System.Drawing.Size(53, 14);
			this.labelControl8.TabIndex = 3;
			this.labelControl8.Text = "Dirección:";
			// 
			// cboCity
			// 
			this.cboCity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboCity.FormattingEnabled = true;
			this.cboCity.Items.AddRange(new object[] {
            "Office 2016 Colorful",
            "Office 2016 Dark",
            "Office 2013 White",
            "Visual Studio 2013 Light",
            "Office 2010 Silver"});
			this.cboCity.Location = new System.Drawing.Point(87, 77);
			this.cboCity.Name = "cboCity";
			this.cboCity.Size = new System.Drawing.Size(324, 22);
			this.cboCity.TabIndex = 3;
			// 
			// labelControl10
			// 
			this.labelControl10.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelControl10.Appearance.Options.UseFont = true;
			this.labelControl10.Location = new System.Drawing.Point(11, 80);
			this.labelControl10.Name = "labelControl10";
			this.labelControl10.Size = new System.Drawing.Size(53, 14);
			this.labelControl10.TabIndex = 2;
			this.labelControl10.Text = "Localidad:";
			// 
			// txtGymName
			// 
			this.txtGymName.Location = new System.Drawing.Point(87, 21);
			this.txtGymName.MaxLength = 50;
			this.txtGymName.Name = "txtGymName";
			this.txtGymName.Size = new System.Drawing.Size(324, 22);
			this.txtGymName.TabIndex = 1;
			this.txtGymName.Validating += new System.ComponentModel.CancelEventHandler(this.txtGymName_Validating);
			// 
			// labelControl11
			// 
			this.labelControl11.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelControl11.Appearance.Options.UseFont = true;
			this.labelControl11.Location = new System.Drawing.Point(11, 26);
			this.labelControl11.Name = "labelControl11";
			this.labelControl11.Size = new System.Drawing.Size(47, 14);
			this.labelControl11.TabIndex = 0;
			this.labelControl11.Text = "Nombre:";
			// 
			// errorProvider
			// 
			this.errorProvider.ContainerControl = this;
			this.errorProvider.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider.Icon")));
			// 
			// ParametersView
			// 
			this.AcceptButton = this.btnOK;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnCancel;
			this.ClientSize = new System.Drawing.Size(966, 310);
			this.Controls.Add(this.gbGym);
			this.Controls.Add(this.gbValidations);
			this.Controls.Add(this.btnOK);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.gbAppearance);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.LookAndFeel.SkinName = "Office 2016 Colorful";
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "ParametersView";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Parámetros";
			this.Load += new System.EventHandler(this.ParametersView_Load);
			this.gbAppearance.ResumeLayout(false);
			this.gbAppearance.PerformLayout();
			this.gbValidations.ResumeLayout(false);
			this.gbValidations.PerformLayout();
			this.gbGym.ResumeLayout(false);
			this.gbGym.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
			this.ResumeLayout(false);

      }

      #endregion

      private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel;
      private DevExpress.XtraEditors.LabelControl labelControl1;
      private System.Windows.Forms.ComboBox cboSkin;
      private System.Windows.Forms.GroupBox gbAppearance;
      private DevExpress.XtraEditors.SimpleButton btnCancel;
      private DevExpress.XtraEditors.SimpleButton btnOK;
      private System.Windows.Forms.GroupBox gbValidations;
      private System.Windows.Forms.TextBox txtRequiredField;
      private DevExpress.XtraEditors.LabelControl labelControl2;
      private System.Windows.Forms.TextBox txtEnterAtLeastAPhone;
      private DevExpress.XtraEditors.LabelControl labelControl4;
      private System.Windows.Forms.TextBox txtInvalidEmailAddress;
      private DevExpress.XtraEditors.LabelControl labelControl3;
      private System.Windows.Forms.TextBox txtEnterPhoneNumber;
      private DevExpress.XtraEditors.LabelControl labelControl6;
      private System.Windows.Forms.TextBox txtEnterMobilePhoneAreaCode;
      private DevExpress.XtraEditors.LabelControl labelControl5;
      private System.Windows.Forms.GroupBox gbGym;
      private System.Windows.Forms.ComboBox cboCity;
      private DevExpress.XtraEditors.LabelControl labelControl10;
      private System.Windows.Forms.TextBox txtGymName;
      private DevExpress.XtraEditors.LabelControl labelControl11;
      private System.Windows.Forms.TextBox txtSelectAtLeastOne;
      private DevExpress.XtraEditors.LabelControl labelControl7;
      private System.Windows.Forms.TextBox txtGymInstagram;
      private DevExpress.XtraEditors.LabelControl labelControl15;
      private System.Windows.Forms.TextBox txtGymTwitter;
      private DevExpress.XtraEditors.LabelControl labelControl14;
      private System.Windows.Forms.TextBox txtGymFacebook;
      private DevExpress.XtraEditors.LabelControl labelControl13;
      private System.Windows.Forms.TextBox txtGymEmail;
      private DevExpress.XtraEditors.LabelControl labelControl12;
      private System.Windows.Forms.TextBox txtGymPhone;
      private DevExpress.XtraEditors.LabelControl labelControl9;
      private System.Windows.Forms.TextBox txtGymAddress;
      private DevExpress.XtraEditors.LabelControl labelControl8;
      private System.Windows.Forms.ErrorProvider errorProvider;
   }
}