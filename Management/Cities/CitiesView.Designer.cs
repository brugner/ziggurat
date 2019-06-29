namespace Management.Cities
{
   partial class CitiesView
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
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CitiesView));
         this.defaultLookAndFeel = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
         this.gridControlCities = new DevExpress.XtraGrid.GridControl();
         this.gridViewCities = new DevExpress.XtraGrid.Views.Grid.GridView();
         this.gridColumnId = new DevExpress.XtraGrid.Columns.GridColumn();
         this.gridColumnName = new DevExpress.XtraGrid.Columns.GridColumn();
         this.gridColumnZipCode = new DevExpress.XtraGrid.Columns.GridColumn();
         this.gridColumnCityStateName = new DevExpress.XtraGrid.Columns.GridColumn();
         this.toolTipController = new DevExpress.Utils.ToolTipController(this.components);
         ((System.ComponentModel.ISupportInitialize)(this.gridControlCities)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.gridViewCities)).BeginInit();
         this.SuspendLayout();
         // 
         // defaultLookAndFeel
         // 
         this.defaultLookAndFeel.LookAndFeel.SkinName = "Office 2016 Colorful";
         // 
         // gridControlCities
         // 
         this.gridControlCities.Dock = System.Windows.Forms.DockStyle.Fill;
         this.gridControlCities.Location = new System.Drawing.Point(0, 0);
         this.gridControlCities.MainView = this.gridViewCities;
         this.gridControlCities.Name = "gridControlCities";
         this.gridControlCities.Size = new System.Drawing.Size(590, 320);
         this.gridControlCities.TabIndex = 1;
         this.gridControlCities.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewCities});
         // 
         // gridViewCities
         // 
         this.gridViewCities.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumnId,
            this.gridColumnName,
            this.gridColumnZipCode,
            this.gridColumnCityStateName});
         this.gridViewCities.GridControl = this.gridControlCities;
         this.gridViewCities.Name = "gridViewCities";
         this.gridViewCities.OptionsFind.AlwaysVisible = true;
         this.gridViewCities.OptionsFind.FindNullPrompt = "Escribe para buscar..";
         this.gridViewCities.OptionsFind.ShowClearButton = false;
         this.gridViewCities.OptionsFind.ShowCloseButton = false;
         this.gridViewCities.OptionsFind.ShowFindButton = false;
         this.gridViewCities.OptionsView.ShowGroupPanel = false;
         this.gridViewCities.DoubleClick += new System.EventHandler(this.gridViewCities_DoubleClick);
         // 
         // gridColumnId
         // 
         this.gridColumnId.Caption = "Id";
         this.gridColumnId.FieldName = "Id";
         this.gridColumnId.Name = "gridColumnId";
         this.gridColumnId.OptionsColumn.AllowEdit = false;
         this.gridColumnId.OptionsColumn.AllowFocus = false;
         this.gridColumnId.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
         this.gridColumnId.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
         this.gridColumnId.OptionsColumn.AllowMove = false;
         this.gridColumnId.OptionsColumn.AllowShowHide = false;
         this.gridColumnId.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
         this.gridColumnId.OptionsColumn.ReadOnly = true;
         // 
         // gridColumnName
         // 
         this.gridColumnName.Caption = "Localidad";
         this.gridColumnName.FieldName = "Name";
         this.gridColumnName.Name = "gridColumnName";
         this.gridColumnName.OptionsColumn.AllowEdit = false;
         this.gridColumnName.OptionsColumn.AllowFocus = false;
         this.gridColumnName.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
         this.gridColumnName.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
         this.gridColumnName.OptionsColumn.AllowMove = false;
         this.gridColumnName.OptionsColumn.AllowShowHide = false;
         this.gridColumnName.OptionsColumn.ReadOnly = true;
         this.gridColumnName.Visible = true;
         this.gridColumnName.VisibleIndex = 0;
         // 
         // gridColumnZipCode
         // 
         this.gridColumnZipCode.Caption = "Cód. Postal";
         this.gridColumnZipCode.FieldName = "ZipCode";
         this.gridColumnZipCode.Name = "gridColumnZipCode";
         this.gridColumnZipCode.OptionsColumn.AllowEdit = false;
         this.gridColumnZipCode.OptionsColumn.AllowFocus = false;
         this.gridColumnZipCode.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
         this.gridColumnZipCode.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
         this.gridColumnZipCode.OptionsColumn.AllowMove = false;
         this.gridColumnZipCode.OptionsColumn.AllowShowHide = false;
         this.gridColumnZipCode.OptionsColumn.ReadOnly = true;
         this.gridColumnZipCode.Visible = true;
         this.gridColumnZipCode.VisibleIndex = 1;
         // 
         // gridColumnCityStateName
         // 
         this.gridColumnCityStateName.Caption = "Provincia";
         this.gridColumnCityStateName.FieldName = "CityStateName";
         this.gridColumnCityStateName.Name = "gridColumnCityStateName";
         this.gridColumnCityStateName.OptionsColumn.AllowEdit = false;
         this.gridColumnCityStateName.OptionsColumn.AllowFocus = false;
         this.gridColumnCityStateName.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
         this.gridColumnCityStateName.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
         this.gridColumnCityStateName.OptionsColumn.AllowMove = false;
         this.gridColumnCityStateName.OptionsColumn.AllowShowHide = false;
         this.gridColumnCityStateName.OptionsColumn.ReadOnly = true;
         this.gridColumnCityStateName.Visible = true;
         this.gridColumnCityStateName.VisibleIndex = 2;
         // 
         // CitiesView
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(590, 320);
         this.Controls.Add(this.gridControlCities);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
         this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
         this.MaximizeBox = false;
         this.MinimizeBox = false;
         this.Name = "CitiesView";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
         this.Text = "Seleccionar localidad";
         this.Load += new System.EventHandler(this.CitiesView_Load);
         ((System.ComponentModel.ISupportInitialize)(this.gridControlCities)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.gridViewCities)).EndInit();
         this.ResumeLayout(false);

      }

      #endregion

      private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel;
      private DevExpress.XtraGrid.GridControl gridControlCities;
      private DevExpress.XtraGrid.Views.Grid.GridView gridViewCities;
      private DevExpress.XtraGrid.Columns.GridColumn gridColumnId;
      private DevExpress.XtraGrid.Columns.GridColumn gridColumnName;
      private DevExpress.XtraGrid.Columns.GridColumn gridColumnZipCode;
      private DevExpress.XtraGrid.Columns.GridColumn gridColumnCityStateName;
      private DevExpress.Utils.ToolTipController toolTipController;
   }
}