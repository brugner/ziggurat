namespace Management.Members.DeletedMembers
{
   partial class DeletedMembersView
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeletedMembersView));
			this.defaultLookAndFeel = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
			this.gridControlRecords = new DevExpress.XtraGrid.GridControl();
			this.gridViewRecords = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.gridColumnId = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridColumnFullName = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridColumnDNI = new DevExpress.XtraGrid.Columns.GridColumn();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
			this.gridColumnAge = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridColumnAddress = new DevExpress.XtraGrid.Columns.GridColumn();
			((System.ComponentModel.ISupportInitialize)(this.gridControlRecords)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridViewRecords)).BeginInit();
			this.statusStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// defaultLookAndFeel
			// 
			this.defaultLookAndFeel.LookAndFeel.SkinName = "Office 2016 Colorful";
			// 
			// gridControlRecords
			// 
			this.gridControlRecords.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gridControlRecords.Location = new System.Drawing.Point(0, 0);
			this.gridControlRecords.MainView = this.gridViewRecords;
			this.gridControlRecords.Name = "gridControlRecords";
			this.gridControlRecords.Size = new System.Drawing.Size(677, 449);
			this.gridControlRecords.TabIndex = 1;
			this.gridControlRecords.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewRecords});
			// 
			// gridViewRecords
			// 
			this.gridViewRecords.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumnId,
            this.gridColumnFullName,
            this.gridColumnDNI,
            this.gridColumnAge,
            this.gridColumnAddress});
			this.gridViewRecords.GridControl = this.gridControlRecords;
			this.gridViewRecords.Name = "gridViewRecords";
			this.gridViewRecords.OptionsFind.AlwaysVisible = true;
			this.gridViewRecords.OptionsFind.FindDelay = 500;
			this.gridViewRecords.OptionsFind.FindNullPrompt = "Empieza a escribi para buscar..";
			this.gridViewRecords.OptionsFind.ShowClearButton = false;
			this.gridViewRecords.OptionsFind.ShowCloseButton = false;
			this.gridViewRecords.OptionsFind.ShowFindButton = false;
			this.gridViewRecords.OptionsView.ShowGroupPanel = false;
			this.gridViewRecords.OptionsView.ShowIndicator = false;
			this.gridViewRecords.DoubleClick += new System.EventHandler(this.gridViewMembers_DoubleClick);
			// 
			// gridColumnId
			// 
			this.gridColumnId.Caption = "Id";
			this.gridColumnId.FieldName = "Id";
			this.gridColumnId.Name = "gridColumnId";
			this.gridColumnId.OptionsColumn.AllowEdit = false;
			this.gridColumnId.OptionsColumn.AllowFocus = false;
			this.gridColumnId.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
			this.gridColumnId.OptionsColumn.AllowShowHide = false;
			this.gridColumnId.OptionsColumn.ReadOnly = true;
			this.gridColumnId.Visible = true;
			this.gridColumnId.VisibleIndex = 0;
			this.gridColumnId.Width = 52;
			// 
			// gridColumnFullName
			// 
			this.gridColumnFullName.Caption = "Nombre";
			this.gridColumnFullName.FieldName = "FullName";
			this.gridColumnFullName.Name = "gridColumnFullName";
			this.gridColumnFullName.OptionsColumn.AllowEdit = false;
			this.gridColumnFullName.OptionsColumn.AllowFocus = false;
			this.gridColumnFullName.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
			this.gridColumnFullName.OptionsColumn.AllowShowHide = false;
			this.gridColumnFullName.OptionsColumn.ReadOnly = true;
			this.gridColumnFullName.Visible = true;
			this.gridColumnFullName.VisibleIndex = 1;
			this.gridColumnFullName.Width = 220;
			// 
			// gridColumnDNI
			// 
			this.gridColumnDNI.Caption = "DNI";
			this.gridColumnDNI.FieldName = "DNI";
			this.gridColumnDNI.Name = "gridColumnDNI";
			this.gridColumnDNI.OptionsColumn.AllowEdit = false;
			this.gridColumnDNI.OptionsColumn.AllowFocus = false;
			this.gridColumnDNI.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
			this.gridColumnDNI.OptionsColumn.AllowShowHide = false;
			this.gridColumnDNI.OptionsColumn.ReadOnly = true;
			this.gridColumnDNI.Visible = true;
			this.gridColumnDNI.VisibleIndex = 2;
			this.gridColumnDNI.Width = 92;
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
			this.statusStrip1.Location = new System.Drawing.Point(0, 427);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(677, 22);
			this.statusStrip1.TabIndex = 2;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// toolStripStatusLabel1
			// 
			this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
			this.toolStripStatusLabel1.Size = new System.Drawing.Size(235, 17);
			this.toolStripStatusLabel1.Text = "Doble click en un miembro para restaurarlo";
			// 
			// gridColumnAge
			// 
			this.gridColumnAge.Caption = "Edad";
			this.gridColumnAge.FieldName = "Age";
			this.gridColumnAge.Name = "gridColumnAge";
			this.gridColumnAge.OptionsColumn.AllowEdit = false;
			this.gridColumnAge.OptionsColumn.AllowFocus = false;
			this.gridColumnAge.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
			this.gridColumnAge.OptionsColumn.AllowShowHide = false;
			this.gridColumnAge.OptionsColumn.ReadOnly = true;
			this.gridColumnAge.Visible = true;
			this.gridColumnAge.VisibleIndex = 3;
			this.gridColumnAge.Width = 35;
			// 
			// gridColumnAddress
			// 
			this.gridColumnAddress.Caption = "Domicilio";
			this.gridColumnAddress.FieldName = "Address";
			this.gridColumnAddress.Name = "gridColumnAddress";
			this.gridColumnAddress.OptionsColumn.AllowEdit = false;
			this.gridColumnAddress.OptionsColumn.AllowFocus = false;
			this.gridColumnAddress.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
			this.gridColumnAddress.OptionsColumn.AllowShowHide = false;
			this.gridColumnAddress.OptionsColumn.ReadOnly = true;
			this.gridColumnAddress.Visible = true;
			this.gridColumnAddress.VisibleIndex = 4;
			this.gridColumnAddress.Width = 309;
			// 
			// DeletedMembersView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(677, 449);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.gridControlRecords);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "DeletedMembersView";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Miembros dados de baja";
			this.Load += new System.EventHandler(this.DeletedMembersView_Load);
			((System.ComponentModel.ISupportInitialize)(this.gridControlRecords)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridViewRecords)).EndInit();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

      }

      #endregion

      private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel;
      private DevExpress.XtraGrid.GridControl gridControlRecords;
      private DevExpress.XtraGrid.Views.Grid.GridView gridViewRecords;
      private DevExpress.XtraGrid.Columns.GridColumn gridColumnId;
      private DevExpress.XtraGrid.Columns.GridColumn gridColumnDNI;
      private DevExpress.XtraGrid.Columns.GridColumn gridColumnFullName;
      private System.Windows.Forms.StatusStrip statusStrip1;
      private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumnAge;
		private DevExpress.XtraGrid.Columns.GridColumn gridColumnAddress;
	}
}