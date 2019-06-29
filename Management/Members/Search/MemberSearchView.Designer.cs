namespace Management.Members.Search
{
   partial class MemberSearchView
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
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MemberSearchView));
         this.gridControlMembers = new DevExpress.XtraGrid.GridControl();
         this.gridViewMembers = new DevExpress.XtraGrid.Views.Grid.GridView();
         this.gridColumnId = new DevExpress.XtraGrid.Columns.GridColumn();
         this.gridColumnFullName = new DevExpress.XtraGrid.Columns.GridColumn();
         this.gridColumnDNI = new DevExpress.XtraGrid.Columns.GridColumn();
         this.gridColumnAddress = new DevExpress.XtraGrid.Columns.GridColumn();
         this.gridColumnCityName = new DevExpress.XtraGrid.Columns.GridColumn();
         ((System.ComponentModel.ISupportInitialize)(this.gridControlMembers)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.gridViewMembers)).BeginInit();
         this.SuspendLayout();
         // 
         // gridControlMembers
         // 
         this.gridControlMembers.Dock = System.Windows.Forms.DockStyle.Fill;
         this.gridControlMembers.Location = new System.Drawing.Point(0, 0);
         this.gridControlMembers.MainView = this.gridViewMembers;
         this.gridControlMembers.Name = "gridControlMembers";
         this.gridControlMembers.Size = new System.Drawing.Size(671, 421);
         this.gridControlMembers.TabIndex = 1;
         this.gridControlMembers.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewMembers});
         // 
         // gridViewMembers
         // 
         this.gridViewMembers.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumnId,
            this.gridColumnFullName,
            this.gridColumnDNI,
            this.gridColumnAddress,
            this.gridColumnCityName});
         this.gridViewMembers.GridControl = this.gridControlMembers;
         this.gridViewMembers.Name = "gridViewMembers";
         this.gridViewMembers.OptionsFind.AlwaysVisible = true;
         this.gridViewMembers.OptionsFind.FindDelay = 500;
         this.gridViewMembers.OptionsFind.FindNullPrompt = "Empieza a escribir para buscar..";
         this.gridViewMembers.OptionsFind.ShowClearButton = false;
         this.gridViewMembers.OptionsFind.ShowCloseButton = false;
         this.gridViewMembers.OptionsFind.ShowFindButton = false;
         this.gridViewMembers.OptionsView.ShowGroupPanel = false;
         this.gridViewMembers.OptionsView.ShowIndicator = false;
         this.gridViewMembers.DoubleClick += new System.EventHandler(this.gridViewMembers_DoubleClick);
         // 
         // gridColumnId
         // 
         this.gridColumnId.Caption = "Id";
         this.gridColumnId.FieldName = "Id";
         this.gridColumnId.Name = "gridColumnId";
         this.gridColumnId.OptionsColumn.AllowEdit = false;
         this.gridColumnId.OptionsColumn.AllowFocus = false;
         this.gridColumnId.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
         this.gridColumnId.OptionsColumn.ReadOnly = true;
         this.gridColumnId.Visible = true;
         this.gridColumnId.VisibleIndex = 0;
         // 
         // gridColumnFullName
         // 
         this.gridColumnFullName.Caption = "Nombre";
         this.gridColumnFullName.FieldName = "FullName";
         this.gridColumnFullName.Name = "gridColumnFullName";
         this.gridColumnFullName.OptionsColumn.AllowEdit = false;
         this.gridColumnFullName.OptionsColumn.AllowFocus = false;
         this.gridColumnFullName.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
         this.gridColumnFullName.OptionsColumn.ReadOnly = true;
         this.gridColumnFullName.Visible = true;
         this.gridColumnFullName.VisibleIndex = 1;
         // 
         // gridColumnDNI
         // 
         this.gridColumnDNI.Caption = "DNI";
         this.gridColumnDNI.FieldName = "DNI";
         this.gridColumnDNI.Name = "gridColumnDNI";
         this.gridColumnDNI.OptionsColumn.AllowEdit = false;
         this.gridColumnDNI.OptionsColumn.AllowFocus = false;
         this.gridColumnDNI.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
         this.gridColumnDNI.OptionsColumn.ReadOnly = true;
         this.gridColumnDNI.Visible = true;
         this.gridColumnDNI.VisibleIndex = 2;
         // 
         // gridColumnAddress
         // 
         this.gridColumnAddress.Caption = "Domicilio";
         this.gridColumnAddress.FieldName = "Address";
         this.gridColumnAddress.Name = "gridColumnAddress";
         this.gridColumnAddress.OptionsColumn.AllowEdit = false;
         this.gridColumnAddress.OptionsColumn.AllowFocus = false;
         this.gridColumnAddress.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
         this.gridColumnAddress.OptionsColumn.ReadOnly = true;
         this.gridColumnAddress.Visible = true;
         this.gridColumnAddress.VisibleIndex = 3;
         // 
         // gridColumnCityName
         // 
         this.gridColumnCityName.Caption = "Localidad";
         this.gridColumnCityName.FieldName = "CityName";
         this.gridColumnCityName.Name = "gridColumnCityName";
         this.gridColumnCityName.OptionsColumn.AllowEdit = false;
         this.gridColumnCityName.OptionsColumn.AllowFocus = false;
         this.gridColumnCityName.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
         this.gridColumnCityName.OptionsColumn.ReadOnly = true;
         this.gridColumnCityName.Visible = true;
         this.gridColumnCityName.VisibleIndex = 4;
         // 
         // MemberSearchView
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(671, 421);
         this.Controls.Add(this.gridControlMembers);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
         this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
         this.MaximizeBox = false;
         this.MinimizeBox = false;
         this.Name = "MemberSearchView";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Text = "Seleccionar miembro";
         ((System.ComponentModel.ISupportInitialize)(this.gridControlMembers)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.gridViewMembers)).EndInit();
         this.ResumeLayout(false);

      }

      #endregion

      private DevExpress.XtraGrid.GridControl gridControlMembers;
      private DevExpress.XtraGrid.Views.Grid.GridView gridViewMembers;
      private DevExpress.XtraGrid.Columns.GridColumn gridColumnId;
      private DevExpress.XtraGrid.Columns.GridColumn gridColumnFullName;
      private DevExpress.XtraGrid.Columns.GridColumn gridColumnDNI;
      private DevExpress.XtraGrid.Columns.GridColumn gridColumnAddress;
      private DevExpress.XtraGrid.Columns.GridColumn gridColumnCityName;
   }
}