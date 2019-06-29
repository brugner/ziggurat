namespace Management.Sales
{
   partial class NewSaleView
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewSaleView));
			DevExpress.Utils.ToolTipItem toolTipItem1 = new DevExpress.Utils.ToolTipItem();
			this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
			this.defaultLookAndFeel = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
			this.gridControlProducts = new DevExpress.XtraGrid.GridControl();
			this.gridViewProducts = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.gridColumnProductId = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridColumnProductName = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridColumnProductPrice = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridColumnProductType = new DevExpress.XtraGrid.Columns.GridColumn();
			this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
			this.linkMemberSearch = new DevExpress.XtraEditors.HyperlinkLabelControl();
			this.txtMemberFullName = new System.Windows.Forms.TextBox();
			this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
			this.dtpDate = new System.Windows.Forms.DateTimePicker();
			this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
			this.txtComment = new System.Windows.Forms.TextBox();
			this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
			this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
			this.btnOK = new DevExpress.XtraEditors.SimpleButton();
			this.gridControlSaleItems = new DevExpress.XtraGrid.GridControl();
			this.gridViewSaleItems = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridColumnSaleItemsProductName = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridColumnSaleItemsPrice = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridColumnSaleItemsQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridColumnSaleItemsSubtotal = new DevExpress.XtraGrid.Columns.GridColumn();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridControlProducts)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridViewProducts)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
			this.splitContainerControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridControlSaleItems)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridViewSaleItems)).BeginInit();
			this.SuspendLayout();
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
			// gridControlProducts
			// 
			this.gridControlProducts.Location = new System.Drawing.Point(3, 78);
			this.gridControlProducts.MainView = this.gridViewProducts;
			this.gridControlProducts.Name = "gridControlProducts";
			this.gridControlProducts.Size = new System.Drawing.Size(451, 555);
			this.gridControlProducts.TabIndex = 1;
			this.gridControlProducts.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewProducts});
			// 
			// gridViewProducts
			// 
			this.gridViewProducts.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumnProductId,
            this.gridColumnProductName,
            this.gridColumnProductPrice,
            this.gridColumnProductType});
			this.gridViewProducts.GridControl = this.gridControlProducts;
			this.gridViewProducts.Name = "gridViewProducts";
			this.gridViewProducts.OptionsFind.AlwaysVisible = true;
			this.gridViewProducts.OptionsFind.FindDelay = 500;
			this.gridViewProducts.OptionsFind.FindNullPrompt = "Empieza a escribir para buscar..";
			this.gridViewProducts.OptionsFind.ShowClearButton = false;
			this.gridViewProducts.OptionsFind.ShowCloseButton = false;
			this.gridViewProducts.OptionsFind.ShowFindButton = false;
			this.gridViewProducts.OptionsView.ShowGroupPanel = false;
			this.gridViewProducts.OptionsView.ShowIndicator = false;
			this.gridViewProducts.OptionsView.ShowViewCaption = true;
			this.gridViewProducts.ViewCaption = "Productos";
			this.gridViewProducts.DoubleClick += new System.EventHandler(this.gridViewProducts_DoubleClick);
			// 
			// gridColumnProductId
			// 
			this.gridColumnProductId.Caption = "Id";
			this.gridColumnProductId.FieldName = "Id";
			this.gridColumnProductId.Name = "gridColumnProductId";
			// 
			// gridColumnProductName
			// 
			this.gridColumnProductName.Caption = "Nombre";
			this.gridColumnProductName.FieldName = "Name";
			this.gridColumnProductName.Name = "gridColumnProductName";
			this.gridColumnProductName.OptionsColumn.AllowEdit = false;
			this.gridColumnProductName.OptionsColumn.AllowFocus = false;
			this.gridColumnProductName.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
			this.gridColumnProductName.OptionsColumn.AllowShowHide = false;
			this.gridColumnProductName.OptionsColumn.ReadOnly = true;
			this.gridColumnProductName.Visible = true;
			this.gridColumnProductName.VisibleIndex = 0;
			this.gridColumnProductName.Width = 331;
			// 
			// gridColumnProductPrice
			// 
			this.gridColumnProductPrice.Caption = "Precio";
			this.gridColumnProductPrice.DisplayFormat.FormatString = "n2";
			this.gridColumnProductPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.gridColumnProductPrice.FieldName = "Price";
			this.gridColumnProductPrice.Name = "gridColumnProductPrice";
			this.gridColumnProductPrice.OptionsColumn.AllowEdit = false;
			this.gridColumnProductPrice.OptionsColumn.AllowFocus = false;
			this.gridColumnProductPrice.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
			this.gridColumnProductPrice.OptionsColumn.AllowShowHide = false;
			this.gridColumnProductPrice.OptionsColumn.ReadOnly = true;
			this.gridColumnProductPrice.Visible = true;
			this.gridColumnProductPrice.VisibleIndex = 2;
			this.gridColumnProductPrice.Width = 174;
			// 
			// gridColumnProductType
			// 
			this.gridColumnProductType.Caption = "Tipo";
			this.gridColumnProductType.FieldName = "ProductType";
			this.gridColumnProductType.Name = "gridColumnProductType";
			this.gridColumnProductType.OptionsColumn.AllowEdit = false;
			this.gridColumnProductType.OptionsColumn.AllowFocus = false;
			this.gridColumnProductType.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
			this.gridColumnProductType.OptionsColumn.AllowShowHide = false;
			this.gridColumnProductType.OptionsColumn.ReadOnly = true;
			this.gridColumnProductType.Visible = true;
			this.gridColumnProductType.VisibleIndex = 1;
			this.gridColumnProductType.Width = 203;
			// 
			// splitContainerControl1
			// 
			this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
			this.splitContainerControl1.Name = "splitContainerControl1";
			this.splitContainerControl1.Panel1.Controls.Add(this.linkMemberSearch);
			this.splitContainerControl1.Panel1.Controls.Add(this.gridControlProducts);
			this.splitContainerControl1.Panel1.Controls.Add(this.txtMemberFullName);
			this.splitContainerControl1.Panel1.Controls.Add(this.labelControl1);
			this.splitContainerControl1.Panel1.Text = "Panel1";
			this.splitContainerControl1.Panel2.Controls.Add(this.dtpDate);
			this.splitContainerControl1.Panel2.Controls.Add(this.labelControl3);
			this.splitContainerControl1.Panel2.Controls.Add(this.txtComment);
			this.splitContainerControl1.Panel2.Controls.Add(this.labelControl2);
			this.splitContainerControl1.Panel2.Controls.Add(this.btnCancel);
			this.splitContainerControl1.Panel2.Controls.Add(this.btnOK);
			this.splitContainerControl1.Panel2.Controls.Add(this.gridControlSaleItems);
			this.splitContainerControl1.Panel2.Text = "Panel2";
			this.splitContainerControl1.Size = new System.Drawing.Size(1085, 645);
			this.splitContainerControl1.SplitterPosition = 459;
			this.splitContainerControl1.TabIndex = 2;
			this.splitContainerControl1.Text = "splitContainerControl1";
			// 
			// linkMemberSearch
			// 
			this.linkMemberSearch.Cursor = System.Windows.Forms.Cursors.Hand;
			this.linkMemberSearch.Location = new System.Drawing.Point(59, 43);
			this.linkMemberSearch.Name = "linkMemberSearch";
			this.linkMemberSearch.Size = new System.Drawing.Size(83, 13);
			toolTipTitleItem1.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
			toolTipTitleItem1.Appearance.Options.UseImage = true;
			toolTipTitleItem1.Image = ((System.Drawing.Image)(resources.GetObject("toolTipTitleItem1.Image")));
			toolTipTitleItem1.Text = "Buscar miembro";
			toolTipItem1.LeftIndent = 6;
			toolTipItem1.Text = "Selecciona el miembro cliente de esta venta.";
			superToolTip1.Items.Add(toolTipTitleItem1);
			superToolTip1.Items.Add(toolTipItem1);
			this.linkMemberSearch.SuperTip = superToolTip1;
			this.linkMemberSearch.TabIndex = 4;
			this.linkMemberSearch.Text = "Buscar miembro..";
			this.linkMemberSearch.Click += new System.EventHandler(this.linkMemberSearch_Click);
			// 
			// txtMemberFullName
			// 
			this.txtMemberFullName.Location = new System.Drawing.Point(59, 16);
			this.txtMemberFullName.Name = "txtMemberFullName";
			this.txtMemberFullName.ReadOnly = true;
			this.txtMemberFullName.Size = new System.Drawing.Size(362, 21);
			this.txtMemberFullName.TabIndex = 6;
			this.txtMemberFullName.TabStop = false;
			this.txtMemberFullName.Validating += new System.ComponentModel.CancelEventHandler(this.txtMemberFullName_Validating);
			// 
			// labelControl1
			// 
			this.labelControl1.Location = new System.Drawing.Point(9, 19);
			this.labelControl1.Name = "labelControl1";
			this.labelControl1.Size = new System.Drawing.Size(44, 13);
			this.labelControl1.TabIndex = 5;
			this.labelControl1.Text = "Miembro:";
			// 
			// dtpDate
			// 
			this.dtpDate.CustomFormat = "dddd d \'de\' MMMM \'de\' yyyy \'a las\' hh:mm";
			this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpDate.Location = new System.Drawing.Point(3, 513);
			this.dtpDate.Name = "dtpDate";
			this.dtpDate.Size = new System.Drawing.Size(598, 21);
			this.dtpDate.TabIndex = 11;
			// 
			// labelControl3
			// 
			this.labelControl3.Location = new System.Drawing.Point(3, 494);
			this.labelControl3.Name = "labelControl3";
			this.labelControl3.Size = new System.Drawing.Size(29, 13);
			this.labelControl3.TabIndex = 10;
			this.labelControl3.Text = "Fecha";
			// 
			// txtComment
			// 
			this.txtComment.Location = new System.Drawing.Point(3, 572);
			this.txtComment.MaxLength = 100;
			this.txtComment.Name = "txtComment";
			this.txtComment.Size = new System.Drawing.Size(598, 21);
			this.txtComment.TabIndex = 9;
			// 
			// labelControl2
			// 
			this.labelControl2.Location = new System.Drawing.Point(3, 553);
			this.labelControl2.Name = "labelControl2";
			this.labelControl2.Size = new System.Drawing.Size(55, 13);
			this.labelControl2.TabIndex = 8;
			this.labelControl2.Text = "Comentario";
			// 
			// btnCancel
			// 
			this.btnCancel.CausesValidation = false;
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Location = new System.Drawing.Point(526, 610);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 7;
			this.btnCancel.Text = "Cancelar";
			// 
			// btnOK
			// 
			this.btnOK.Enabled = false;
			this.btnOK.Location = new System.Drawing.Point(445, 610);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(75, 23);
			this.btnOK.TabIndex = 6;
			this.btnOK.Text = "Aceptar";
			this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
			// 
			// gridControlSaleItems
			// 
			this.gridControlSaleItems.Location = new System.Drawing.Point(3, 78);
			this.gridControlSaleItems.MainView = this.gridViewSaleItems;
			this.gridControlSaleItems.Name = "gridControlSaleItems";
			this.gridControlSaleItems.Size = new System.Drawing.Size(598, 393);
			this.gridControlSaleItems.TabIndex = 2;
			this.gridControlSaleItems.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewSaleItems});
			// 
			// gridViewSaleItems
			// 
			this.gridViewSaleItems.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumnSaleItemsProductName,
            this.gridColumnSaleItemsPrice,
            this.gridColumnSaleItemsQuantity,
            this.gridColumnSaleItemsSubtotal});
			this.gridViewSaleItems.GridControl = this.gridControlSaleItems;
			this.gridViewSaleItems.Name = "gridViewSaleItems";
			this.gridViewSaleItems.OptionsBehavior.AlignGroupSummaryInGroupRow = DevExpress.Utils.DefaultBoolean.True;
			this.gridViewSaleItems.OptionsFind.FindDelay = 500;
			this.gridViewSaleItems.OptionsFind.FindNullPrompt = "Empieza a escribir para buscar..";
			this.gridViewSaleItems.OptionsFind.ShowClearButton = false;
			this.gridViewSaleItems.OptionsFind.ShowCloseButton = false;
			this.gridViewSaleItems.OptionsFind.ShowFindButton = false;
			this.gridViewSaleItems.OptionsView.ShowFooter = true;
			this.gridViewSaleItems.OptionsView.ShowGroupPanel = false;
			this.gridViewSaleItems.OptionsView.ShowIndicator = false;
			this.gridViewSaleItems.OptionsView.ShowViewCaption = true;
			this.gridViewSaleItems.ViewCaption = "Carrito de compras";
			this.gridViewSaleItems.DoubleClick += new System.EventHandler(this.gridViewSaleItems_DoubleClick);
			// 
			// gridColumn1
			// 
			this.gridColumn1.Caption = "Id";
			this.gridColumn1.FieldName = "Id";
			this.gridColumn1.Name = "gridColumn1";
			// 
			// gridColumnSaleItemsProductName
			// 
			this.gridColumnSaleItemsProductName.Caption = "Producto";
			this.gridColumnSaleItemsProductName.FieldName = "ProductName";
			this.gridColumnSaleItemsProductName.Name = "gridColumnSaleItemsProductName";
			this.gridColumnSaleItemsProductName.OptionsColumn.AllowEdit = false;
			this.gridColumnSaleItemsProductName.OptionsColumn.AllowFocus = false;
			this.gridColumnSaleItemsProductName.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
			this.gridColumnSaleItemsProductName.OptionsColumn.AllowShowHide = false;
			this.gridColumnSaleItemsProductName.OptionsColumn.ReadOnly = true;
			this.gridColumnSaleItemsProductName.Visible = true;
			this.gridColumnSaleItemsProductName.VisibleIndex = 0;
			this.gridColumnSaleItemsProductName.Width = 299;
			// 
			// gridColumnSaleItemsPrice
			// 
			this.gridColumnSaleItemsPrice.Caption = "Precio";
			this.gridColumnSaleItemsPrice.DisplayFormat.FormatString = "n2";
			this.gridColumnSaleItemsPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.gridColumnSaleItemsPrice.FieldName = "Price";
			this.gridColumnSaleItemsPrice.Name = "gridColumnSaleItemsPrice";
			this.gridColumnSaleItemsPrice.OptionsColumn.AllowEdit = false;
			this.gridColumnSaleItemsPrice.OptionsColumn.AllowFocus = false;
			this.gridColumnSaleItemsPrice.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
			this.gridColumnSaleItemsPrice.OptionsColumn.AllowShowHide = false;
			this.gridColumnSaleItemsPrice.OptionsColumn.ReadOnly = true;
			this.gridColumnSaleItemsPrice.Visible = true;
			this.gridColumnSaleItemsPrice.VisibleIndex = 1;
			this.gridColumnSaleItemsPrice.Width = 144;
			// 
			// gridColumnSaleItemsQuantity
			// 
			this.gridColumnSaleItemsQuantity.Caption = "Cant.";
			this.gridColumnSaleItemsQuantity.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.gridColumnSaleItemsQuantity.FieldName = "Quantity";
			this.gridColumnSaleItemsQuantity.Name = "gridColumnSaleItemsQuantity";
			this.gridColumnSaleItemsQuantity.OptionsColumn.AllowEdit = false;
			this.gridColumnSaleItemsQuantity.OptionsColumn.AllowFocus = false;
			this.gridColumnSaleItemsQuantity.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
			this.gridColumnSaleItemsQuantity.OptionsColumn.AllowShowHide = false;
			this.gridColumnSaleItemsQuantity.OptionsColumn.ReadOnly = true;
			this.gridColumnSaleItemsQuantity.Visible = true;
			this.gridColumnSaleItemsQuantity.VisibleIndex = 2;
			this.gridColumnSaleItemsQuantity.Width = 82;
			// 
			// gridColumnSaleItemsSubtotal
			// 
			this.gridColumnSaleItemsSubtotal.Caption = "Subtotal";
			this.gridColumnSaleItemsSubtotal.DisplayFormat.FormatString = "n2";
			this.gridColumnSaleItemsSubtotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
			this.gridColumnSaleItemsSubtotal.FieldName = "Subtotal";
			this.gridColumnSaleItemsSubtotal.Name = "gridColumnSaleItemsSubtotal";
			this.gridColumnSaleItemsSubtotal.OptionsColumn.AllowEdit = false;
			this.gridColumnSaleItemsSubtotal.OptionsColumn.AllowFocus = false;
			this.gridColumnSaleItemsSubtotal.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
			this.gridColumnSaleItemsSubtotal.OptionsColumn.AllowShowHide = false;
			this.gridColumnSaleItemsSubtotal.OptionsColumn.ReadOnly = true;
			this.gridColumnSaleItemsSubtotal.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Subtotal", "Total: {0:c2}")});
			this.gridColumnSaleItemsSubtotal.Visible = true;
			this.gridColumnSaleItemsSubtotal.VisibleIndex = 3;
			this.gridColumnSaleItemsSubtotal.Width = 183;
			// 
			// NewSaleView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1085, 645);
			this.Controls.Add(this.splitContainerControl1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "NewSaleView";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Nueva venta";
			this.Load += new System.EventHandler(this.NewSaleView_Load);
			((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridControlProducts)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridViewProducts)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
			this.splitContainerControl1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gridControlSaleItems)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridViewSaleItems)).EndInit();
			this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.ErrorProvider errorProvider;
      private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel;
      private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
      private DevExpress.XtraGrid.GridControl gridControlProducts;
      private DevExpress.XtraGrid.Views.Grid.GridView gridViewProducts;
      private DevExpress.XtraGrid.Columns.GridColumn gridColumnProductId;
      private DevExpress.XtraGrid.Columns.GridColumn gridColumnProductName;
      private DevExpress.XtraGrid.Columns.GridColumn gridColumnProductPrice;
      private DevExpress.XtraGrid.Columns.GridColumn gridColumnProductType;
      private DevExpress.XtraGrid.GridControl gridControlSaleItems;
      private DevExpress.XtraGrid.Views.Grid.GridView gridViewSaleItems;
      private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
      private DevExpress.XtraGrid.Columns.GridColumn gridColumnSaleItemsProductName;
      private DevExpress.XtraGrid.Columns.GridColumn gridColumnSaleItemsPrice;
      private DevExpress.XtraGrid.Columns.GridColumn gridColumnSaleItemsQuantity;
      private DevExpress.XtraGrid.Columns.GridColumn gridColumnSaleItemsSubtotal;
      private DevExpress.XtraEditors.HyperlinkLabelControl linkMemberSearch;
      private System.Windows.Forms.TextBox txtMemberFullName;
      private DevExpress.XtraEditors.LabelControl labelControl1;
      private DevExpress.XtraEditors.SimpleButton btnCancel;
      private DevExpress.XtraEditors.SimpleButton btnOK;
      private System.Windows.Forms.TextBox txtComment;
      private DevExpress.XtraEditors.LabelControl labelControl2;
      private DevExpress.XtraEditors.LabelControl labelControl3;
      private System.Windows.Forms.DateTimePicker dtpDate;
   }
}