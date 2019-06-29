namespace Management.DatabaseBackupRecords
{
   partial class DatabaseBackupRecordsView
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DatabaseBackupRecordsView));
			DevExpress.Utils.ToolTipItem toolTipItem1 = new DevExpress.Utils.ToolTipItem();
			DevExpress.Utils.SuperToolTip superToolTip2 = new DevExpress.Utils.SuperToolTip();
			DevExpress.Utils.ToolTipTitleItem toolTipTitleItem2 = new DevExpress.Utils.ToolTipTitleItem();
			DevExpress.Utils.ToolTipItem toolTipItem2 = new DevExpress.Utils.ToolTipItem();
			this.defaultLookAndFeel = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
			this.gridControlRecords = new DevExpress.XtraGrid.GridControl();
			this.gridViewRecords = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.gridColumnId = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridColumnDate = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridColumnPath = new DevExpress.XtraGrid.Columns.GridColumn();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
			this.btnOpenBackupFolder = new DevExpress.XtraEditors.SimpleButton();
			this.btnBackup = new DevExpress.XtraEditors.SimpleButton();
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
			this.gridControlRecords.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.gridControlRecords.Location = new System.Drawing.Point(0, 41);
			this.gridControlRecords.MainView = this.gridViewRecords;
			this.gridControlRecords.Name = "gridControlRecords";
			this.gridControlRecords.Size = new System.Drawing.Size(677, 383);
			this.gridControlRecords.TabIndex = 1;
			this.gridControlRecords.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewRecords});
			// 
			// gridViewRecords
			// 
			this.gridViewRecords.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumnId,
            this.gridColumnDate,
            this.gridColumnPath});
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
			this.gridColumnId.Width = 39;
			// 
			// gridColumnDate
			// 
			this.gridColumnDate.Caption = "Fecha";
			this.gridColumnDate.DisplayFormat.FormatString = "dd/MM/yyyy hh:mm:ss";
			this.gridColumnDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
			this.gridColumnDate.FieldName = "Date";
			this.gridColumnDate.Name = "gridColumnDate";
			this.gridColumnDate.OptionsColumn.AllowEdit = false;
			this.gridColumnDate.OptionsColumn.AllowFocus = false;
			this.gridColumnDate.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
			this.gridColumnDate.OptionsColumn.AllowShowHide = false;
			this.gridColumnDate.OptionsColumn.ReadOnly = true;
			this.gridColumnDate.Visible = true;
			this.gridColumnDate.VisibleIndex = 0;
			this.gridColumnDate.Width = 128;
			// 
			// gridColumnPath
			// 
			this.gridColumnPath.Caption = "Ruta";
			this.gridColumnPath.FieldName = "Path";
			this.gridColumnPath.Name = "gridColumnPath";
			this.gridColumnPath.OptionsColumn.AllowEdit = false;
			this.gridColumnPath.OptionsColumn.AllowFocus = false;
			this.gridColumnPath.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
			this.gridColumnPath.OptionsColumn.AllowShowHide = false;
			this.gridColumnPath.OptionsColumn.ReadOnly = true;
			this.gridColumnPath.Visible = true;
			this.gridColumnPath.VisibleIndex = 1;
			this.gridColumnPath.Width = 580;
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
			this.toolStripStatusLabel1.Size = new System.Drawing.Size(324, 17);
			this.toolStripStatusLabel1.Text = "Los backups son generados automáticamente todos los días";
			// 
			// btnOpenBackupFolder
			// 
			this.btnOpenBackupFolder.Location = new System.Drawing.Point(119, 12);
			this.btnOpenBackupFolder.Name = "btnOpenBackupFolder";
			this.btnOpenBackupFolder.Size = new System.Drawing.Size(147, 23);
			toolTipTitleItem1.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
			toolTipTitleItem1.Appearance.Options.UseImage = true;
			toolTipTitleItem1.Image = ((System.Drawing.Image)(resources.GetObject("toolTipTitleItem1.Image")));
			toolTipTitleItem1.Text = "Abrir carpeta de backups";
			toolTipItem1.LeftIndent = 6;
			toolTipItem1.Text = "Abre el directorio en donde se encuentran los archivos de la copia de seguridad d" +
    "e la base de datos. Es importante que los copies y guardes en algún lugar seguro" +
    ".";
			superToolTip1.Items.Add(toolTipTitleItem1);
			superToolTip1.Items.Add(toolTipItem1);
			this.btnOpenBackupFolder.SuperTip = superToolTip1;
			this.btnOpenBackupFolder.TabIndex = 13;
			this.btnOpenBackupFolder.Text = "Abrir carpeta de backups";
			this.btnOpenBackupFolder.Click += new System.EventHandler(this.btnOpenBackupFolder_Click);
			// 
			// btnBackup
			// 
			this.btnBackup.Location = new System.Drawing.Point(12, 12);
			this.btnBackup.Name = "btnBackup";
			this.btnBackup.Size = new System.Drawing.Size(101, 23);
			toolTipTitleItem2.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
			toolTipTitleItem2.Appearance.Options.UseImage = true;
			toolTipTitleItem2.Image = ((System.Drawing.Image)(resources.GetObject("toolTipTitleItem2.Image")));
			toolTipTitleItem2.Text = "Generar backup";
			toolTipItem2.LeftIndent = 6;
			toolTipItem2.Text = "Realiza la copia de seguridad de la base de datos.";
			superToolTip2.Items.Add(toolTipTitleItem2);
			superToolTip2.Items.Add(toolTipItem2);
			this.btnBackup.SuperTip = superToolTip2;
			this.btnBackup.TabIndex = 14;
			this.btnBackup.Text = "Generar backup";
			this.btnBackup.Click += new System.EventHandler(this.btnBackup_Click);
			// 
			// DatabaseBackupRecordsView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(677, 449);
			this.Controls.Add(this.btnBackup);
			this.Controls.Add(this.btnOpenBackupFolder);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.gridControlRecords);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "DatabaseBackupRecordsView";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Backups de la base de datos";
			this.Load += new System.EventHandler(this.DatabaseBackupRecordsView_Load);
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
      private DevExpress.XtraGrid.Columns.GridColumn gridColumnPath;
      private DevExpress.XtraGrid.Columns.GridColumn gridColumnDate;
      private System.Windows.Forms.StatusStrip statusStrip1;
      private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
      private DevExpress.XtraEditors.SimpleButton btnOpenBackupFolder;
      private DevExpress.XtraEditors.SimpleButton btnBackup;
   }
}