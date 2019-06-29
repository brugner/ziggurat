namespace Management.Products
{
   partial class ProductView
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductView));
			this.defaultLookAndFeel = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
			this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
			this.txtId = new System.Windows.Forms.TextBox();
			this.labelControl20 = new DevExpress.XtraEditors.LabelControl();
			this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
			this.txtName = new System.Windows.Forms.TextBox();
			this.numPrice = new System.Windows.Forms.NumericUpDown();
			this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
			this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
			this.numCost = new System.Windows.Forms.NumericUpDown();
			this.cboProductType = new System.Windows.Forms.ComboBox();
			this.labelControl21 = new DevExpress.XtraEditors.LabelControl();
			this.txtCreatedAt = new System.Windows.Forms.TextBox();
			this.txtUpdatedAt = new System.Windows.Forms.TextBox();
			this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
			this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
			this.btnOK = new DevExpress.XtraEditors.SimpleButton();
			this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
			this.chkIsActive = new System.Windows.Forms.CheckBox();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numPrice)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numCost)).BeginInit();
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
			// txtId
			// 
			this.txtId.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtId.Location = new System.Drawing.Point(74, 12);
			this.txtId.Name = "txtId";
			this.txtId.ReadOnly = true;
			this.txtId.Size = new System.Drawing.Size(60, 14);
			this.txtId.TabIndex = 32;
			this.txtId.TabStop = false;
			// 
			// labelControl20
			// 
			this.labelControl20.Location = new System.Drawing.Point(11, 12);
			this.labelControl20.Name = "labelControl20";
			this.labelControl20.Size = new System.Drawing.Size(14, 13);
			this.labelControl20.TabIndex = 31;
			this.labelControl20.Text = "Id:";
			// 
			// labelControl1
			// 
			this.labelControl1.Location = new System.Drawing.Point(10, 36);
			this.labelControl1.Name = "labelControl1";
			this.labelControl1.Size = new System.Drawing.Size(41, 13);
			this.labelControl1.TabIndex = 30;
			this.labelControl1.Text = "Nombre:";
			// 
			// txtName
			// 
			this.txtName.Location = new System.Drawing.Point(74, 32);
			this.txtName.MaxLength = 50;
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(291, 21);
			this.txtName.TabIndex = 0;
			this.txtName.Validating += new System.ComponentModel.CancelEventHandler(this.txtName_Validating);
			// 
			// numPrice
			// 
			this.numPrice.DecimalPlaces = 2;
			this.numPrice.Location = new System.Drawing.Point(74, 59);
			this.numPrice.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
			this.numPrice.Name = "numPrice";
			this.numPrice.Size = new System.Drawing.Size(82, 21);
			this.numPrice.TabIndex = 1;
			this.numPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.numPrice.ThousandsSeparator = true;
			// 
			// labelControl2
			// 
			this.labelControl2.Location = new System.Drawing.Point(12, 61);
			this.labelControl2.Name = "labelControl2";
			this.labelControl2.Size = new System.Drawing.Size(33, 13);
			this.labelControl2.TabIndex = 34;
			this.labelControl2.Text = "Precio:";
			// 
			// labelControl3
			// 
			this.labelControl3.Location = new System.Drawing.Point(12, 88);
			this.labelControl3.Name = "labelControl3";
			this.labelControl3.Size = new System.Drawing.Size(32, 13);
			this.labelControl3.TabIndex = 36;
			this.labelControl3.Text = "Costo:";
			// 
			// numCost
			// 
			this.numCost.DecimalPlaces = 2;
			this.numCost.Location = new System.Drawing.Point(74, 86);
			this.numCost.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
			this.numCost.Name = "numCost";
			this.numCost.Size = new System.Drawing.Size(82, 21);
			this.numCost.TabIndex = 2;
			this.numCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.numCost.ThousandsSeparator = true;
			// 
			// cboProductType
			// 
			this.cboProductType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboProductType.FormattingEnabled = true;
			this.cboProductType.Location = new System.Drawing.Point(74, 113);
			this.cboProductType.Name = "cboProductType";
			this.cboProductType.Size = new System.Drawing.Size(291, 21);
			this.cboProductType.TabIndex = 3;
			this.cboProductType.Validating += new System.ComponentModel.CancelEventHandler(this.cboProductType_Validating);
			// 
			// labelControl21
			// 
			this.labelControl21.Location = new System.Drawing.Point(12, 116);
			this.labelControl21.Name = "labelControl21";
			this.labelControl21.Size = new System.Drawing.Size(24, 13);
			this.labelControl21.TabIndex = 39;
			this.labelControl21.Text = "Tipo:";
			// 
			// txtCreatedAt
			// 
			this.txtCreatedAt.Location = new System.Drawing.Point(10, 178);
			this.txtCreatedAt.Name = "txtCreatedAt";
			this.txtCreatedAt.ReadOnly = true;
			this.txtCreatedAt.Size = new System.Drawing.Size(355, 21);
			this.txtCreatedAt.TabIndex = 24;
			this.txtCreatedAt.TabStop = false;
			// 
			// txtUpdatedAt
			// 
			this.txtUpdatedAt.Location = new System.Drawing.Point(10, 227);
			this.txtUpdatedAt.Name = "txtUpdatedAt";
			this.txtUpdatedAt.ReadOnly = true;
			this.txtUpdatedAt.Size = new System.Drawing.Size(355, 21);
			this.txtUpdatedAt.TabIndex = 25;
			this.txtUpdatedAt.TabStop = false;
			// 
			// labelControl10
			// 
			this.labelControl10.Location = new System.Drawing.Point(10, 162);
			this.labelControl10.Name = "labelControl10";
			this.labelControl10.Size = new System.Drawing.Size(35, 13);
			this.labelControl10.TabIndex = 22;
			this.labelControl10.Text = "Creado";
			// 
			// labelControl11
			// 
			this.labelControl11.Location = new System.Drawing.Point(10, 209);
			this.labelControl11.Name = "labelControl11";
			this.labelControl11.Size = new System.Drawing.Size(93, 13);
			this.labelControl11.TabIndex = 23;
			this.labelControl11.Text = "Última actualización";
			// 
			// btnOK
			// 
			this.btnOK.Location = new System.Drawing.Point(209, 263);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(75, 23);
			this.btnOK.TabIndex = 40;
			this.btnOK.Text = "Aceptar";
			this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.CausesValidation = false;
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Location = new System.Drawing.Point(290, 263);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 41;
			this.btnCancel.Text = "Cancelar";
			// 
			// chkIsActive
			// 
			this.chkIsActive.AutoSize = true;
			this.chkIsActive.Checked = true;
			this.chkIsActive.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkIsActive.Location = new System.Drawing.Point(309, 11);
			this.chkIsActive.Name = "chkIsActive";
			this.chkIsActive.Size = new System.Drawing.Size(56, 17);
			this.chkIsActive.TabIndex = 42;
			this.chkIsActive.TabStop = false;
			this.chkIsActive.Text = "Activo";
			this.chkIsActive.UseVisualStyleBackColor = true;
			// 
			// ProductView
			// 
			this.AcceptButton = this.btnOK;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnCancel;
			this.ClientSize = new System.Drawing.Size(386, 306);
			this.Controls.Add(this.txtCreatedAt);
			this.Controls.Add(this.chkIsActive);
			this.Controls.Add(this.txtUpdatedAt);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.labelControl10);
			this.Controls.Add(this.labelControl11);
			this.Controls.Add(this.btnOK);
			this.Controls.Add(this.cboProductType);
			this.Controls.Add(this.labelControl21);
			this.Controls.Add(this.labelControl3);
			this.Controls.Add(this.numCost);
			this.Controls.Add(this.labelControl2);
			this.Controls.Add(this.numPrice);
			this.Controls.Add(this.txtId);
			this.Controls.Add(this.labelControl20);
			this.Controls.Add(this.labelControl1);
			this.Controls.Add(this.txtName);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "ProductView";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "ProductView";
			this.Load += new System.EventHandler(this.ProductView_Load);
			((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numPrice)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numCost)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

      }

      #endregion

      private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel;
      private System.Windows.Forms.ErrorProvider errorProvider;
      private System.Windows.Forms.TextBox txtId;
      private DevExpress.XtraEditors.LabelControl labelControl20;
      private DevExpress.XtraEditors.LabelControl labelControl1;
      private System.Windows.Forms.TextBox txtName;
      private DevExpress.XtraEditors.LabelControl labelControl3;
      private System.Windows.Forms.NumericUpDown numCost;
      private DevExpress.XtraEditors.LabelControl labelControl2;
      private System.Windows.Forms.NumericUpDown numPrice;
      private System.Windows.Forms.ComboBox cboProductType;
      private DevExpress.XtraEditors.LabelControl labelControl21;
      private System.Windows.Forms.TextBox txtCreatedAt;
      private System.Windows.Forms.TextBox txtUpdatedAt;
      private DevExpress.XtraEditors.LabelControl labelControl10;
      private DevExpress.XtraEditors.LabelControl labelControl11;
      private DevExpress.XtraEditors.SimpleButton btnOK;
      private DevExpress.XtraEditors.SimpleButton btnCancel;
      private System.Windows.Forms.CheckBox chkIsActive;
   }
}