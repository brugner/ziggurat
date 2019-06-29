namespace Management.Checkins
{
   partial class CheckinView
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
			DevExpress.Utils.SuperToolTip superToolTip1 = new DevExpress.Utils.SuperToolTip();
			DevExpress.Utils.ToolTipTitleItem toolTipTitleItem1 = new DevExpress.Utils.ToolTipTitleItem();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CheckinView));
			DevExpress.Utils.ToolTipItem toolTipItem1 = new DevExpress.Utils.ToolTipItem();
			this.btnOK = new DevExpress.XtraEditors.SimpleButton();
			this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
			this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
			this.txtMemberFullName = new System.Windows.Forms.TextBox();
			this.linkMemberSearch = new DevExpress.XtraEditors.HyperlinkLabelControl();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.rgTrainings = new DevExpress.XtraEditors.RadioGroup();
			this.dtpDateTime = new System.Windows.Forms.DateTimePicker();
			this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
			this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
			this.defaultLookAndFeel = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.rgTrainings.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
			this.SuspendLayout();
			// 
			// btnOK
			// 
			this.btnOK.Location = new System.Drawing.Point(355, 239);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(75, 23);
			this.btnOK.TabIndex = 4;
			this.btnOK.Text = "Aceptar";
			this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.CausesValidation = false;
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Location = new System.Drawing.Point(436, 239);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 5;
			this.btnCancel.Text = "Cancelar";
			// 
			// labelControl1
			// 
			this.labelControl1.Location = new System.Drawing.Point(12, 21);
			this.labelControl1.Name = "labelControl1";
			this.labelControl1.Size = new System.Drawing.Size(44, 13);
			this.labelControl1.TabIndex = 2;
			this.labelControl1.Text = "Miembro:";
			// 
			// txtMemberFullName
			// 
			this.txtMemberFullName.Location = new System.Drawing.Point(62, 18);
			this.txtMemberFullName.Name = "txtMemberFullName";
			this.txtMemberFullName.ReadOnly = true;
			this.txtMemberFullName.Size = new System.Drawing.Size(449, 21);
			this.txtMemberFullName.TabIndex = 3;
			this.txtMemberFullName.TabStop = false;
			this.txtMemberFullName.TextChanged += new System.EventHandler(this.txtMemberFullName_TextChanged);
			this.txtMemberFullName.Validating += new System.ComponentModel.CancelEventHandler(this.txtMemberFullName_Validating);
			// 
			// linkMemberSearch
			// 
			this.linkMemberSearch.Cursor = System.Windows.Forms.Cursors.Hand;
			this.linkMemberSearch.Location = new System.Drawing.Point(62, 45);
			this.linkMemberSearch.Name = "linkMemberSearch";
			this.linkMemberSearch.Size = new System.Drawing.Size(83, 13);
			toolTipTitleItem1.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
			toolTipTitleItem1.Appearance.Options.UseImage = true;
			toolTipTitleItem1.Image = ((System.Drawing.Image)(resources.GetObject("toolTipTitleItem1.Image")));
			toolTipTitleItem1.Text = "Buscar miembro";
			toolTipItem1.LeftIndent = 6;
			toolTipItem1.Text = "Selecciona un miembro para registrarle una asistencia.";
			superToolTip1.Items.Add(toolTipTitleItem1);
			superToolTip1.Items.Add(toolTipItem1);
			this.linkMemberSearch.SuperTip = superToolTip1;
			this.linkMemberSearch.TabIndex = 1;
			this.linkMemberSearch.Text = "Buscar miembro..";
			this.linkMemberSearch.Click += new System.EventHandler(this.linkMemberSearch_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.rgTrainings);
			this.groupBox1.Location = new System.Drawing.Point(12, 77);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(499, 129);
			this.groupBox1.TabIndex = 2;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Actividades con membresías activas";
			// 
			// rgTrainings
			// 
			this.rgTrainings.Location = new System.Drawing.Point(6, 20);
			this.rgTrainings.Name = "rgTrainings";
			this.rgTrainings.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
			this.rgTrainings.Properties.Appearance.Options.UseBackColor = true;
			this.rgTrainings.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
			this.rgTrainings.Size = new System.Drawing.Size(473, 103);
			this.rgTrainings.TabIndex = 1;
			this.rgTrainings.SelectedIndexChanged += new System.EventHandler(this.rgTrainings_SelectedIndexChanged);
			// 
			// dtpDateTime
			// 
			this.dtpDateTime.CustomFormat = "dd/MM/yyyy hh:mm";
			this.dtpDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpDateTime.Location = new System.Drawing.Point(62, 212);
			this.dtpDateTime.Name = "dtpDateTime";
			this.dtpDateTime.Size = new System.Drawing.Size(449, 21);
			this.dtpDateTime.TabIndex = 3;
			// 
			// labelControl2
			// 
			this.labelControl2.Location = new System.Drawing.Point(12, 218);
			this.labelControl2.Name = "labelControl2";
			this.labelControl2.Size = new System.Drawing.Size(33, 13);
			this.labelControl2.TabIndex = 7;
			this.labelControl2.Text = "Fecha:";
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
			// CheckinView
			// 
			this.AcceptButton = this.btnOK;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnCancel;
			this.ClientSize = new System.Drawing.Size(532, 278);
			this.Controls.Add(this.labelControl2);
			this.Controls.Add(this.dtpDateTime);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.linkMemberSearch);
			this.Controls.Add(this.txtMemberFullName);
			this.Controls.Add(this.labelControl1);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnOK);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "CheckinView";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Registrar asistencia";
			this.Load += new System.EventHandler(this.CheckinView_Load);
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.rgTrainings.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

      }

      #endregion

      private DevExpress.XtraEditors.SimpleButton btnOK;
      private DevExpress.XtraEditors.SimpleButton btnCancel;
      private DevExpress.XtraEditors.LabelControl labelControl1;
      private System.Windows.Forms.TextBox txtMemberFullName;
      private DevExpress.XtraEditors.HyperlinkLabelControl linkMemberSearch;
      private System.Windows.Forms.GroupBox groupBox1;
      private DevExpress.XtraEditors.RadioGroup rgTrainings;
      private System.Windows.Forms.DateTimePicker dtpDateTime;
      private DevExpress.XtraEditors.LabelControl labelControl2;
      private System.Windows.Forms.ErrorProvider errorProvider;
      private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel;
   }
}