namespace Management.Payments
{
   partial class NewPaymentView
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewPaymentView));
			this.gridControlDebts = new DevExpress.XtraGrid.GridControl();
			this.gridViewDebts = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.gridColumnIsSelected = new DevExpress.XtraGrid.Columns.GridColumn();
			this.repositoryItemCheckEditIsSelected = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
			this.gridColumnMembershipId = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridColumnSaleId = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridColumnDate = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridColumnOrigin = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridColumnDescription = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridColumnAmount = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridColumnDebtAmount = new DevExpress.XtraGrid.Columns.GridColumn();
			this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
			this.numAmount = new System.Windows.Forms.NumericUpDown();
			this.cboPaymentMethod = new System.Windows.Forms.ComboBox();
			this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
			this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
			this.btnOK = new DevExpress.XtraEditors.SimpleButton();
			this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
			this.dtpDate = new System.Windows.Forms.DateTimePicker();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.txtComment = new System.Windows.Forms.TextBox();
			this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
			this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
			this.defaultLookAndFeel = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
			this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
			((System.ComponentModel.ISupportInitialize)(this.gridControlDebts)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridViewDebts)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEditIsSelected)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numAmount)).BeginInit();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
			this.SuspendLayout();
			// 
			// gridControlDebts
			// 
			this.gridControlDebts.Location = new System.Drawing.Point(12, 32);
			this.gridControlDebts.MainView = this.gridViewDebts;
			this.gridControlDebts.Name = "gridControlDebts";
			this.gridControlDebts.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEditIsSelected});
			this.gridControlDebts.Size = new System.Drawing.Size(727, 289);
			this.gridControlDebts.TabIndex = 1;
			this.gridControlDebts.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewDebts});
			// 
			// gridViewDebts
			// 
			this.gridViewDebts.Appearance.FocusedRow.Options.UseBackColor = true;
			this.gridViewDebts.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumnIsSelected,
            this.gridColumnMembershipId,
            this.gridColumnSaleId,
            this.gridColumnDate,
            this.gridColumnOrigin,
            this.gridColumnDescription,
            this.gridColumnAmount,
            this.gridColumnDebtAmount});
			this.gridViewDebts.GridControl = this.gridControlDebts;
			this.gridViewDebts.Name = "gridViewDebts";
			this.gridViewDebts.OptionsFind.AllowFindPanel = false;
			this.gridViewDebts.OptionsFind.FindNullPrompt = "";
			this.gridViewDebts.OptionsView.ShowGroupPanel = false;
			this.gridViewDebts.OptionsView.ShowIndicator = false;
			// 
			// gridColumnIsSelected
			// 
			this.gridColumnIsSelected.Caption = " ";
			this.gridColumnIsSelected.ColumnEdit = this.repositoryItemCheckEditIsSelected;
			this.gridColumnIsSelected.FieldName = "IsSelected";
			this.gridColumnIsSelected.Name = "gridColumnIsSelected";
			this.gridColumnIsSelected.OptionsColumn.AllowMove = false;
			this.gridColumnIsSelected.OptionsColumn.AllowSize = false;
			this.gridColumnIsSelected.Visible = true;
			this.gridColumnIsSelected.VisibleIndex = 0;
			this.gridColumnIsSelected.Width = 47;
			// 
			// repositoryItemCheckEditIsSelected
			// 
			this.repositoryItemCheckEditIsSelected.AllowFocused = false;
			this.repositoryItemCheckEditIsSelected.AutoHeight = false;
			this.repositoryItemCheckEditIsSelected.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Radio;
			this.repositoryItemCheckEditIsSelected.HotTrackWhenReadOnly = false;
			this.repositoryItemCheckEditIsSelected.Name = "repositoryItemCheckEditIsSelected";
			this.repositoryItemCheckEditIsSelected.CheckedChanged += new System.EventHandler(this.repositoryItemCheckEditSelected_CheckedChanged);
			// 
			// gridColumnMembershipId
			// 
			this.gridColumnMembershipId.Caption = "MembershipId";
			this.gridColumnMembershipId.FieldName = "MembershipId";
			this.gridColumnMembershipId.Name = "gridColumnMembershipId";
			// 
			// gridColumnSaleId
			// 
			this.gridColumnSaleId.Caption = "SaleId";
			this.gridColumnSaleId.FieldName = "SaleId";
			this.gridColumnSaleId.Name = "gridColumnSaleId";
			// 
			// gridColumnDate
			// 
			this.gridColumnDate.Caption = "Fecha";
			this.gridColumnDate.DisplayFormat.FormatString = "dd/MM/yyyy";
			this.gridColumnDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
			this.gridColumnDate.FieldName = "Date";
			this.gridColumnDate.Name = "gridColumnDate";
			this.gridColumnDate.OptionsColumn.AllowEdit = false;
			this.gridColumnDate.OptionsColumn.AllowFocus = false;
			this.gridColumnDate.Visible = true;
			this.gridColumnDate.VisibleIndex = 1;
			this.gridColumnDate.Width = 80;
			// 
			// gridColumnOrigin
			// 
			this.gridColumnOrigin.Caption = "Origen";
			this.gridColumnOrigin.FieldName = "Origin";
			this.gridColumnOrigin.Name = "gridColumnOrigin";
			this.gridColumnOrigin.OptionsColumn.AllowEdit = false;
			this.gridColumnOrigin.OptionsColumn.AllowFocus = false;
			this.gridColumnOrigin.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
			this.gridColumnOrigin.OptionsColumn.ReadOnly = true;
			this.gridColumnOrigin.Visible = true;
			this.gridColumnOrigin.VisibleIndex = 2;
			this.gridColumnOrigin.Width = 76;
			// 
			// gridColumnDescription
			// 
			this.gridColumnDescription.Caption = "Descripción";
			this.gridColumnDescription.FieldName = "Description";
			this.gridColumnDescription.Name = "gridColumnDescription";
			this.gridColumnDescription.OptionsColumn.AllowEdit = false;
			this.gridColumnDescription.OptionsColumn.AllowFocus = false;
			this.gridColumnDescription.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
			this.gridColumnDescription.OptionsColumn.ReadOnly = true;
			this.gridColumnDescription.Visible = true;
			this.gridColumnDescription.VisibleIndex = 3;
			this.gridColumnDescription.Width = 304;
			// 
			// gridColumnAmount
			// 
			this.gridColumnAmount.Caption = "Importe";
			this.gridColumnAmount.FieldName = "Amount";
			this.gridColumnAmount.Name = "gridColumnAmount";
			this.gridColumnAmount.OptionsColumn.AllowEdit = false;
			this.gridColumnAmount.OptionsColumn.AllowFocus = false;
			this.gridColumnAmount.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
			this.gridColumnAmount.OptionsColumn.ReadOnly = true;
			this.gridColumnAmount.Visible = true;
			this.gridColumnAmount.VisibleIndex = 4;
			this.gridColumnAmount.Width = 94;
			// 
			// gridColumnDebtAmount
			// 
			this.gridColumnDebtAmount.Caption = "Importe adeudado";
			this.gridColumnDebtAmount.FieldName = "DebtAmount";
			this.gridColumnDebtAmount.Name = "gridColumnDebtAmount";
			this.gridColumnDebtAmount.OptionsColumn.AllowEdit = false;
			this.gridColumnDebtAmount.OptionsColumn.AllowFocus = false;
			this.gridColumnDebtAmount.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.True;
			this.gridColumnDebtAmount.OptionsColumn.ReadOnly = true;
			this.gridColumnDebtAmount.Visible = true;
			this.gridColumnDebtAmount.VisibleIndex = 5;
			this.gridColumnDebtAmount.Width = 107;
			// 
			// labelControl1
			// 
			this.labelControl1.Location = new System.Drawing.Point(11, 25);
			this.labelControl1.Name = "labelControl1";
			this.labelControl1.Size = new System.Drawing.Size(42, 13);
			this.labelControl1.TabIndex = 2;
			this.labelControl1.Text = "Importe:";
			// 
			// numAmount
			// 
			this.numAmount.DecimalPlaces = 2;
			this.numAmount.Font = new System.Drawing.Font("Tahoma", 8.25F);
			this.numAmount.Location = new System.Drawing.Point(99, 23);
			this.numAmount.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
			this.numAmount.Name = "numAmount";
			this.numAmount.Size = new System.Drawing.Size(159, 21);
			this.numAmount.TabIndex = 1;
			this.numAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.numAmount.ThousandsSeparator = true;
			this.numAmount.Validating += new System.ComponentModel.CancelEventHandler(this.numAmount_Validating);
			// 
			// cboPaymentMethod
			// 
			this.cboPaymentMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboPaymentMethod.Font = new System.Drawing.Font("Tahoma", 8.25F);
			this.cboPaymentMethod.FormattingEnabled = true;
			this.cboPaymentMethod.Items.AddRange(new object[] {
            "Efectivo"});
			this.cboPaymentMethod.Location = new System.Drawing.Point(99, 50);
			this.cboPaymentMethod.Name = "cboPaymentMethod";
			this.cboPaymentMethod.Size = new System.Drawing.Size(159, 21);
			this.cboPaymentMethod.TabIndex = 2;
			// 
			// labelControl2
			// 
			this.labelControl2.Location = new System.Drawing.Point(11, 53);
			this.labelControl2.Name = "labelControl2";
			this.labelControl2.Size = new System.Drawing.Size(76, 13);
			this.labelControl2.TabIndex = 5;
			this.labelControl2.Text = "Forma de pago:";
			// 
			// btnCancel
			// 
			this.btnCancel.CausesValidation = false;
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Location = new System.Drawing.Point(664, 425);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 3;
			this.btnCancel.Text = "Cancelar";
			// 
			// btnOK
			// 
			this.btnOK.Location = new System.Drawing.Point(583, 425);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(75, 23);
			this.btnOK.TabIndex = 2;
			this.btnOK.Text = "Aceptar";
			this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
			// 
			// labelControl3
			// 
			this.labelControl3.Location = new System.Drawing.Point(390, 25);
			this.labelControl3.Name = "labelControl3";
			this.labelControl3.Size = new System.Drawing.Size(33, 13);
			this.labelControl3.TabIndex = 9;
			this.labelControl3.Text = "Fecha:";
			// 
			// dtpDate
			// 
			this.dtpDate.CustomFormat = "dd/MM/yyyy hh:mm";
			this.dtpDate.Font = new System.Drawing.Font("Tahoma", 8.25F);
			this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpDate.Location = new System.Drawing.Point(459, 22);
			this.dtpDate.Name = "dtpDate";
			this.dtpDate.Size = new System.Drawing.Size(187, 21);
			this.dtpDate.TabIndex = 3;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.txtComment);
			this.groupBox1.Controls.Add(this.labelControl4);
			this.groupBox1.Controls.Add(this.labelControl1);
			this.groupBox1.Controls.Add(this.dtpDate);
			this.groupBox1.Controls.Add(this.labelControl3);
			this.groupBox1.Controls.Add(this.numAmount);
			this.groupBox1.Controls.Add(this.cboPaymentMethod);
			this.groupBox1.Controls.Add(this.labelControl2);
			this.groupBox1.Font = new System.Drawing.Font("Tahoma", 8.25F);
			this.groupBox1.Location = new System.Drawing.Point(12, 327);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(727, 92);
			this.groupBox1.TabIndex = 2;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Datos del pago";
			// 
			// txtComment
			// 
			this.txtComment.Location = new System.Drawing.Point(459, 49);
			this.txtComment.MaxLength = 50;
			this.txtComment.Name = "txtComment";
			this.txtComment.Size = new System.Drawing.Size(252, 21);
			this.txtComment.TabIndex = 4;
			// 
			// labelControl4
			// 
			this.labelControl4.Location = new System.Drawing.Point(390, 53);
			this.labelControl4.Name = "labelControl4";
			this.labelControl4.Size = new System.Drawing.Size(59, 13);
			this.labelControl4.TabIndex = 10;
			this.labelControl4.Text = "Comentario:";
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
			// labelControl5
			// 
			this.labelControl5.Location = new System.Drawing.Point(12, 13);
			this.labelControl5.Name = "labelControl5";
			this.labelControl5.Size = new System.Drawing.Size(144, 13);
			this.labelControl5.TabIndex = 4;
			this.labelControl5.Text = "Selecciona un item para pagar";
			// 
			// NewPaymentView
			// 
			this.AcceptButton = this.btnOK;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnCancel;
			this.ClientSize = new System.Drawing.Size(751, 462);
			this.Controls.Add(this.labelControl5);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnOK);
			this.Controls.Add(this.gridControlDebts);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "NewPaymentView";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "NewPaymentView";
			this.Load += new System.EventHandler(this.NewPaymentView_Load);
			((System.ComponentModel.ISupportInitialize)(this.gridControlDebts)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridViewDebts)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEditIsSelected)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numAmount)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

      }

      #endregion

      private DevExpress.XtraGrid.GridControl gridControlDebts;
      private DevExpress.XtraGrid.Views.Grid.GridView gridViewDebts;
      private DevExpress.XtraGrid.Columns.GridColumn gridColumnOrigin;
      private DevExpress.XtraGrid.Columns.GridColumn gridColumnDescription;
      private DevExpress.XtraGrid.Columns.GridColumn gridColumnAmount;
      private DevExpress.XtraGrid.Columns.GridColumn gridColumnMembershipId;
      private DevExpress.XtraGrid.Columns.GridColumn gridColumnSaleId;
      private DevExpress.XtraEditors.LabelControl labelControl1;
      private DevExpress.XtraGrid.Columns.GridColumn gridColumnDate;
      private System.Windows.Forms.NumericUpDown numAmount;
      private System.Windows.Forms.ComboBox cboPaymentMethod;
      private DevExpress.XtraEditors.LabelControl labelControl2;
      private DevExpress.XtraEditors.SimpleButton btnCancel;
      private DevExpress.XtraEditors.SimpleButton btnOK;
      private DevExpress.XtraEditors.LabelControl labelControl3;
      private System.Windows.Forms.DateTimePicker dtpDate;
      private System.Windows.Forms.GroupBox groupBox1;
      private System.Windows.Forms.TextBox txtComment;
      private DevExpress.XtraEditors.LabelControl labelControl4;
      private System.Windows.Forms.ErrorProvider errorProvider;
      private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel;
      private DevExpress.XtraGrid.Columns.GridColumn gridColumnIsSelected;
      private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEditIsSelected;
      private DevExpress.XtraEditors.LabelControl labelControl5;
      private DevExpress.XtraGrid.Columns.GridColumn gridColumnDebtAmount;
   }
}