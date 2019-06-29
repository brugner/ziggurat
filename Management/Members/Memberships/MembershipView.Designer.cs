namespace Management.Members.Memberships
{
   partial class MembershipView
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MembershipView));
			this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
			this.cboTraining = new System.Windows.Forms.ComboBox();
			this.clbShifts = new DevExpress.XtraEditors.CheckedListBoxControl();
			this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
			this.label37 = new System.Windows.Forms.Label();
			this.cboLength = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
			this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
			this.numPrice = new System.Windows.Forms.NumericUpDown();
			this.label35 = new System.Windows.Forms.Label();
			this.label38 = new System.Windows.Forms.Label();
			this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
			this.defaultLookAndFeel = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
			this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
			this.btnOK = new DevExpress.XtraEditors.SimpleButton();
			this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
			this.txtId = new System.Windows.Forms.TextBox();
			this.lbStatus = new DevExpress.XtraEditors.LabelControl();
			((System.ComponentModel.ISupportInitialize)(this.clbShifts)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numPrice)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
			this.SuspendLayout();
			// 
			// labelControl1
			// 
			this.labelControl1.Location = new System.Drawing.Point(12, 35);
			this.labelControl1.Name = "labelControl1";
			this.labelControl1.Size = new System.Drawing.Size(48, 13);
			this.labelControl1.TabIndex = 0;
			this.labelControl1.Text = "Actividad:";
			// 
			// cboTraining
			// 
			this.cboTraining.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboTraining.FormattingEnabled = true;
			this.cboTraining.Location = new System.Drawing.Point(66, 32);
			this.cboTraining.Name = "cboTraining";
			this.cboTraining.Size = new System.Drawing.Size(315, 21);
			this.cboTraining.TabIndex = 1;
			this.cboTraining.SelectedIndexChanged += new System.EventHandler(this.cboTraining_SelectedIndexChanged);
			this.cboTraining.Validating += new System.ComponentModel.CancelEventHandler(this.cboTraining_Validating);
			// 
			// clbShifts
			// 
			this.clbShifts.CheckOnClick = true;
			this.clbShifts.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Radio;
			this.clbShifts.Cursor = System.Windows.Forms.Cursors.Default;
			this.clbShifts.DisplayMember = "DisplayName";
			this.clbShifts.Location = new System.Drawing.Point(12, 81);
			this.clbShifts.Name = "clbShifts";
			this.clbShifts.Size = new System.Drawing.Size(369, 120);
			this.clbShifts.TabIndex = 2;
			this.clbShifts.ValueMember = "Id";
			this.clbShifts.Click += new System.EventHandler(this.clbShifts_Click);
			this.clbShifts.Validating += new System.ComponentModel.CancelEventHandler(this.clbShifts_Validating);
			// 
			// labelControl2
			// 
			this.labelControl2.Location = new System.Drawing.Point(12, 62);
			this.labelControl2.Name = "labelControl2";
			this.labelControl2.Size = new System.Drawing.Size(28, 13);
			this.labelControl2.TabIndex = 3;
			this.labelControl2.Text = "Turno";
			// 
			// label37
			// 
			this.label37.AutoSize = true;
			this.label37.Location = new System.Drawing.Point(9, 211);
			this.label37.Name = "label37";
			this.label37.Size = new System.Drawing.Size(53, 13);
			this.label37.TabIndex = 48;
			this.label37.Text = "Duración:";
			// 
			// cboLength
			// 
			this.cboLength.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboLength.FormattingEnabled = true;
			this.cboLength.Items.AddRange(new object[] {
            "Clase",
            "Semana",
            "Mes",
            "Trimestre",
            "Otro"});
			this.cboLength.Location = new System.Drawing.Point(83, 208);
			this.cboLength.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.cboLength.Name = "cboLength";
			this.cboLength.Size = new System.Drawing.Size(298, 21);
			this.cboLength.TabIndex = 3;
			this.cboLength.SelectedIndexChanged += new System.EventHandler(this.cboLength_SelectedIndexChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(9, 272);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(68, 13);
			this.label1.TabIndex = 60;
			this.label1.Text = "Vencimiento:";
			// 
			// dtpEndDate
			// 
			this.dtpEndDate.Location = new System.Drawing.Point(83, 266);
			this.dtpEndDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.dtpEndDate.Name = "dtpEndDate";
			this.dtpEndDate.Size = new System.Drawing.Size(298, 21);
			this.dtpEndDate.TabIndex = 5;
			this.dtpEndDate.ValueChanged += new System.EventHandler(this.dtpEndDate_ValueChanged);
			// 
			// dtpStartDate
			// 
			this.dtpStartDate.Location = new System.Drawing.Point(83, 237);
			this.dtpStartDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.dtpStartDate.Name = "dtpStartDate";
			this.dtpStartDate.Size = new System.Drawing.Size(298, 21);
			this.dtpStartDate.TabIndex = 4;
			this.dtpStartDate.ValueChanged += new System.EventHandler(this.dtpStartDate_ValueChanged);
			// 
			// numPrice
			// 
			this.numPrice.AutoSize = true;
			this.numPrice.DecimalPlaces = 2;
			this.numPrice.Location = new System.Drawing.Point(83, 295);
			this.numPrice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.numPrice.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
			this.numPrice.Name = "numPrice";
			this.numPrice.Size = new System.Drawing.Size(88, 21);
			this.numPrice.TabIndex = 6;
			this.numPrice.ThousandsSeparator = true;
			// 
			// label35
			// 
			this.label35.AutoSize = true;
			this.label35.Location = new System.Drawing.Point(9, 243);
			this.label35.Name = "label35";
			this.label35.Size = new System.Drawing.Size(36, 13);
			this.label35.TabIndex = 56;
			this.label35.Text = "Inicio:";
			// 
			// label38
			// 
			this.label38.AutoSize = true;
			this.label38.Location = new System.Drawing.Point(9, 297);
			this.label38.Name = "label38";
			this.label38.Size = new System.Drawing.Size(40, 13);
			this.label38.TabIndex = 58;
			this.label38.Text = "Precio:";
			// 
			// errorProvider
			// 
			this.errorProvider.ContainerControl = this;
			this.errorProvider.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider.Icon")));
			// 
			// defaultLookAndFeel
			// 
			this.defaultLookAndFeel.LookAndFeel.SkinName = "Office 2016 Colorful";
			// 
			// btnCancel
			// 
			this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCancel.CausesValidation = false;
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Location = new System.Drawing.Point(306, 332);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 8;
			this.btnCancel.Text = "Cancelar";
			// 
			// btnOK
			// 
			this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnOK.Location = new System.Drawing.Point(225, 332);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(75, 23);
			this.btnOK.TabIndex = 7;
			this.btnOK.Text = "Aceptar";
			this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
			// 
			// labelControl3
			// 
			this.labelControl3.Location = new System.Drawing.Point(12, 12);
			this.labelControl3.Name = "labelControl3";
			this.labelControl3.Size = new System.Drawing.Size(14, 13);
			this.labelControl3.TabIndex = 61;
			this.labelControl3.Text = "Id:";
			// 
			// txtId
			// 
			this.txtId.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtId.Location = new System.Drawing.Point(66, 12);
			this.txtId.Name = "txtId";
			this.txtId.ReadOnly = true;
			this.txtId.Size = new System.Drawing.Size(60, 14);
			this.txtId.TabIndex = 62;
			this.txtId.TabStop = false;
			// 
			// lbStatus
			// 
			this.lbStatus.Appearance.Options.UseTextOptions = true;
			this.lbStatus.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
			this.lbStatus.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
			this.lbStatus.Location = new System.Drawing.Point(225, 13);
			this.lbStatus.Name = "lbStatus";
			this.lbStatus.Size = new System.Drawing.Size(156, 13);
			this.lbStatus.TabIndex = 63;
			// 
			// MembershipView
			// 
			this.AcceptButton = this.btnOK;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnCancel;
			this.ClientSize = new System.Drawing.Size(405, 367);
			this.Controls.Add(this.lbStatus);
			this.Controls.Add(this.txtId);
			this.Controls.Add(this.labelControl3);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnOK);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dtpEndDate);
			this.Controls.Add(this.dtpStartDate);
			this.Controls.Add(this.numPrice);
			this.Controls.Add(this.label35);
			this.Controls.Add(this.label38);
			this.Controls.Add(this.label37);
			this.Controls.Add(this.cboLength);
			this.Controls.Add(this.labelControl2);
			this.Controls.Add(this.clbShifts);
			this.Controls.Add(this.cboTraining);
			this.Controls.Add(this.labelControl1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "MembershipView";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "MembershipView";
			this.Load += new System.EventHandler(this.MembershipView_Load);
			((System.ComponentModel.ISupportInitialize)(this.clbShifts)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numPrice)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

      }

      #endregion

      private DevExpress.XtraEditors.LabelControl labelControl1;
      private System.Windows.Forms.ComboBox cboTraining;
      private DevExpress.XtraEditors.CheckedListBoxControl clbShifts;
      private DevExpress.XtraEditors.LabelControl labelControl2;
      private System.Windows.Forms.Label label37;
      private System.Windows.Forms.ComboBox cboLength;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.DateTimePicker dtpEndDate;
      private System.Windows.Forms.DateTimePicker dtpStartDate;
      private System.Windows.Forms.NumericUpDown numPrice;
      private System.Windows.Forms.Label label35;
      private System.Windows.Forms.Label label38;
      private System.Windows.Forms.ErrorProvider errorProvider;
      private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel;
      private DevExpress.XtraEditors.SimpleButton btnOK;
      private DevExpress.XtraEditors.SimpleButton btnCancel;
      private DevExpress.XtraEditors.LabelControl labelControl3;
      private System.Windows.Forms.TextBox txtId;
      private DevExpress.XtraEditors.LabelControl lbStatus;
   }
}