namespace Management.ProductTypes
{
   partial class ProductTypesView
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
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductTypesView));
         this.defaultLookAndFeel = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
         this.gridControlProductTypes = new DevExpress.XtraGrid.GridControl();
         this.gridViewProductTypes = new DevExpress.XtraGrid.Views.Grid.GridView();
         this.gridColumnId = new DevExpress.XtraGrid.Columns.GridColumn();
         this.gridColumnName = new DevExpress.XtraGrid.Columns.GridColumn();
         this.gbProductTypeData = new System.Windows.Forms.GroupBox();
         this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
         this.btnOK = new DevExpress.XtraEditors.SimpleButton();
         this.txtName = new System.Windows.Forms.TextBox();
         this.label1 = new System.Windows.Forms.Label();
         this.linkNew = new DevExpress.XtraEditors.HyperlinkLabelControl();
         this.linkEdit = new DevExpress.XtraEditors.HyperlinkLabelControl();
         this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
         ((System.ComponentModel.ISupportInitialize)(this.gridControlProductTypes)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.gridViewProductTypes)).BeginInit();
         this.gbProductTypeData.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
         this.SuspendLayout();
         // 
         // defaultLookAndFeel
         // 
         this.defaultLookAndFeel.LookAndFeel.SkinName = "Office 2016 Colorful";
         // 
         // gridControlProductTypes
         // 
         this.gridControlProductTypes.EmbeddedNavigator.TextStringFormat = "{0} de {1}";
         this.gridControlProductTypes.Location = new System.Drawing.Point(0, 0);
         this.gridControlProductTypes.MainView = this.gridViewProductTypes;
         this.gridControlProductTypes.Name = "gridControlProductTypes";
         this.gridControlProductTypes.Size = new System.Drawing.Size(501, 153);
         this.gridControlProductTypes.TabIndex = 0;
         this.gridControlProductTypes.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewProductTypes});
         // 
         // gridViewProductTypes
         // 
         this.gridViewProductTypes.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumnId,
            this.gridColumnName});
         this.gridViewProductTypes.GridControl = this.gridControlProductTypes;
         this.gridViewProductTypes.Name = "gridViewProductTypes";
         this.gridViewProductTypes.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
         this.gridViewProductTypes.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
         this.gridViewProductTypes.OptionsView.ShowGroupPanel = false;
         this.gridViewProductTypes.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridViewProductTypes_FocusedRowChanged);
         // 
         // gridColumnId
         // 
         this.gridColumnId.Caption = "Id";
         this.gridColumnId.FieldName = "Id";
         this.gridColumnId.Name = "gridColumnId";
         this.gridColumnId.OptionsColumn.AllowEdit = false;
         this.gridColumnId.OptionsColumn.AllowFocus = false;
         this.gridColumnId.OptionsColumn.AllowIncrementalSearch = false;
         this.gridColumnId.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
         this.gridColumnId.OptionsColumn.AllowMove = false;
         this.gridColumnId.OptionsColumn.ReadOnly = true;
         this.gridColumnId.Visible = true;
         this.gridColumnId.VisibleIndex = 0;
         this.gridColumnId.Width = 73;
         // 
         // gridColumnName
         // 
         this.gridColumnName.Caption = "Nombre";
         this.gridColumnName.FieldName = "Name";
         this.gridColumnName.Name = "gridColumnName";
         this.gridColumnName.OptionsColumn.AllowEdit = false;
         this.gridColumnName.OptionsColumn.AllowFocus = false;
         this.gridColumnName.OptionsColumn.AllowIncrementalSearch = false;
         this.gridColumnName.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
         this.gridColumnName.OptionsColumn.AllowMove = false;
         this.gridColumnName.OptionsColumn.ReadOnly = true;
         this.gridColumnName.Visible = true;
         this.gridColumnName.VisibleIndex = 1;
         this.gridColumnName.Width = 616;
         // 
         // gbProductTypeData
         // 
         this.gbProductTypeData.Controls.Add(this.btnCancel);
         this.gbProductTypeData.Controls.Add(this.btnOK);
         this.gbProductTypeData.Controls.Add(this.txtName);
         this.gbProductTypeData.Controls.Add(this.label1);
         this.gbProductTypeData.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.gbProductTypeData.Location = new System.Drawing.Point(12, 213);
         this.gbProductTypeData.Name = "gbProductTypeData";
         this.gbProductTypeData.Size = new System.Drawing.Size(477, 82);
         this.gbProductTypeData.TabIndex = 1;
         this.gbProductTypeData.TabStop = false;
         // 
         // btnCancel
         // 
         this.btnCancel.CausesValidation = false;
         this.btnCancel.Enabled = false;
         this.btnCancel.Location = new System.Drawing.Point(396, 51);
         this.btnCancel.Name = "btnCancel";
         this.btnCancel.Size = new System.Drawing.Size(75, 23);
         this.btnCancel.TabIndex = 3;
         this.btnCancel.Text = "Cancelar";
         this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
         // 
         // btnOK
         // 
         this.btnOK.Enabled = false;
         this.btnOK.Location = new System.Drawing.Point(315, 51);
         this.btnOK.Name = "btnOK";
         this.btnOK.Size = new System.Drawing.Size(75, 23);
         this.btnOK.TabIndex = 2;
         this.btnOK.Text = "Aceptar";
         this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
         // 
         // txtName
         // 
         this.txtName.Location = new System.Drawing.Point(77, 22);
         this.txtName.MaxLength = 50;
         this.txtName.Name = "txtName";
         this.txtName.ReadOnly = true;
         this.txtName.Size = new System.Drawing.Size(394, 23);
         this.txtName.TabIndex = 1;
         this.txtName.Validating += new System.ComponentModel.CancelEventHandler(this.txtName_Validating);
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(13, 25);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(58, 16);
         this.label1.TabIndex = 0;
         this.label1.Text = "Nombre:";
         // 
         // linkNew
         // 
         this.linkNew.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.linkNew.Appearance.Options.UseFont = true;
         this.linkNew.Cursor = System.Windows.Forms.Cursors.Hand;
         this.linkNew.Location = new System.Drawing.Point(12, 191);
         this.linkNew.Name = "linkNew";
         this.linkNew.Size = new System.Drawing.Size(46, 16);
         this.linkNew.TabIndex = 3;
         this.linkNew.Text = "Agregar";
         this.linkNew.Click += new System.EventHandler(this.linkNew_Click);
         // 
         // linkEdit
         // 
         this.linkEdit.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.linkEdit.Appearance.Options.UseFont = true;
         this.linkEdit.Cursor = System.Windows.Forms.Cursors.Hand;
         this.linkEdit.Location = new System.Drawing.Point(64, 191);
         this.linkEdit.Name = "linkEdit";
         this.linkEdit.Size = new System.Drawing.Size(33, 16);
         this.linkEdit.TabIndex = 4;
         this.linkEdit.Text = "Editar";
         this.linkEdit.Click += new System.EventHandler(this.linkEdit_Click);
         // 
         // errorProvider
         // 
         this.errorProvider.ContainerControl = this;
         this.errorProvider.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider.Icon")));
         // 
         // ProductTypesView
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(501, 309);
         this.Controls.Add(this.linkNew);
         this.Controls.Add(this.linkEdit);
         this.Controls.Add(this.gbProductTypeData);
         this.Controls.Add(this.gridControlProductTypes);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
         this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
         this.MaximizeBox = false;
         this.Name = "ProductTypesView";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
         this.Text = "Tipos de productos";
         this.Load += new System.EventHandler(this.ProductTypesView_Load);
         ((System.ComponentModel.ISupportInitialize)(this.gridControlProductTypes)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.gridViewProductTypes)).EndInit();
         this.gbProductTypeData.ResumeLayout(false);
         this.gbProductTypeData.PerformLayout();
         ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel;
      private DevExpress.XtraGrid.GridControl gridControlProductTypes;
      private DevExpress.XtraGrid.Views.Grid.GridView gridViewProductTypes;
      private DevExpress.XtraGrid.Columns.GridColumn gridColumnId;
      private DevExpress.XtraGrid.Columns.GridColumn gridColumnName;
      private System.Windows.Forms.GroupBox gbProductTypeData;
      private DevExpress.XtraEditors.SimpleButton btnOK;
      private System.Windows.Forms.TextBox txtName;
      private System.Windows.Forms.Label label1;
      private DevExpress.XtraEditors.HyperlinkLabelControl linkEdit;
      private DevExpress.XtraEditors.HyperlinkLabelControl linkNew;
      private DevExpress.XtraEditors.SimpleButton btnCancel;
      private System.Windows.Forms.ErrorProvider errorProvider;
   }
}