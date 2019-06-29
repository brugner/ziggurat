namespace Management.ShiftsAndQuotas
{
   partial class ShiftsAndQuotasView
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShiftsAndQuotasView));
			this.defaultLookAndFeel = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
			this.gridControlShifts = new DevExpress.XtraGrid.GridControl();
			this.gridViewShifts = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.gridColumnShiftId = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridColumnShiftTrainingName = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridColumnShiftNumber = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridColumnDaysNames = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridColumnShiftTime = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridColumnShiftQuota = new DevExpress.XtraGrid.Columns.GridColumn();
			this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.txtAvailableQuota = new System.Windows.Forms.TextBox();
			this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
			this.txtQuota = new System.Windows.Forms.TextBox();
			this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
			this.txtTime = new System.Windows.Forms.TextBox();
			this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
			this.txtDaysNames = new System.Windows.Forms.TextBox();
			this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
			this.txtTrainingName = new System.Windows.Forms.TextBox();
			this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
			this.gridControlMembers = new DevExpress.XtraGrid.GridControl();
			this.gridViewMembers = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.gridColumnMemberId = new DevExpress.XtraGrid.Columns.GridColumn();
			this.gridColumnMemberFullName = new DevExpress.XtraGrid.Columns.GridColumn();
			((System.ComponentModel.ISupportInitialize)(this.gridControlShifts)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridViewShifts)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
			this.splitContainerControl1.SuspendLayout();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridControlMembers)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gridViewMembers)).BeginInit();
			this.SuspendLayout();
			// 
			// defaultLookAndFeel
			// 
			this.defaultLookAndFeel.LookAndFeel.SkinName = "Office 2016 Colorful";
			// 
			// gridControlShifts
			// 
			this.gridControlShifts.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gridControlShifts.Location = new System.Drawing.Point(0, 0);
			this.gridControlShifts.MainView = this.gridViewShifts;
			this.gridControlShifts.Name = "gridControlShifts";
			this.gridControlShifts.Size = new System.Drawing.Size(561, 738);
			this.gridControlShifts.TabIndex = 0;
			this.gridControlShifts.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewShifts});
			// 
			// gridViewShifts
			// 
			this.gridViewShifts.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumnShiftId,
            this.gridColumnShiftTrainingName,
            this.gridColumnShiftNumber,
            this.gridColumnDaysNames,
            this.gridColumnShiftTime,
            this.gridColumnShiftQuota});
			this.gridViewShifts.GridControl = this.gridControlShifts;
			this.gridViewShifts.GroupCount = 1;
			this.gridViewShifts.Name = "gridViewShifts";
			this.gridViewShifts.OptionsFind.AlwaysVisible = true;
			this.gridViewShifts.OptionsFind.FindNullPrompt = "Empieza a esciribir para buscar..";
			this.gridViewShifts.OptionsFind.ShowClearButton = false;
			this.gridViewShifts.OptionsFind.ShowCloseButton = false;
			this.gridViewShifts.OptionsFind.ShowFindButton = false;
			this.gridViewShifts.OptionsView.ShowIndicator = false;
			this.gridViewShifts.OptionsView.ShowViewCaption = true;
			this.gridViewShifts.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.gridColumnShiftTrainingName, DevExpress.Data.ColumnSortOrder.Ascending)});
			this.gridViewShifts.ViewCaption = "Turnos";
			this.gridViewShifts.CustomDrawGroupRow += new DevExpress.XtraGrid.Views.Base.RowObjectCustomDrawEventHandler(this.gridViewShifts_CustomDrawGroupRow);
			this.gridViewShifts.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridViewShifts_FocusedRowChanged);
			// 
			// gridColumnShiftId
			// 
			this.gridColumnShiftId.Caption = "Id";
			this.gridColumnShiftId.FieldName = "Id";
			this.gridColumnShiftId.Name = "gridColumnShiftId";
			// 
			// gridColumnShiftTrainingName
			// 
			this.gridColumnShiftTrainingName.Caption = "Actividad";
			this.gridColumnShiftTrainingName.FieldName = "TrainingName";
			this.gridColumnShiftTrainingName.Name = "gridColumnShiftTrainingName";
			this.gridColumnShiftTrainingName.OptionsColumn.AllowEdit = false;
			this.gridColumnShiftTrainingName.OptionsColumn.AllowFocus = false;
			this.gridColumnShiftTrainingName.OptionsColumn.AllowShowHide = false;
			this.gridColumnShiftTrainingName.OptionsColumn.ReadOnly = true;
			this.gridColumnShiftTrainingName.Visible = true;
			this.gridColumnShiftTrainingName.VisibleIndex = 0;
			this.gridColumnShiftTrainingName.Width = 220;
			// 
			// gridColumnShiftNumber
			// 
			this.gridColumnShiftNumber.Caption = "Número";
			this.gridColumnShiftNumber.FieldName = "Number";
			this.gridColumnShiftNumber.Name = "gridColumnShiftNumber";
			this.gridColumnShiftNumber.OptionsColumn.AllowEdit = false;
			this.gridColumnShiftNumber.OptionsColumn.AllowFocus = false;
			this.gridColumnShiftNumber.OptionsColumn.AllowShowHide = false;
			this.gridColumnShiftNumber.OptionsColumn.ReadOnly = true;
			this.gridColumnShiftNumber.Visible = true;
			this.gridColumnShiftNumber.VisibleIndex = 0;
			this.gridColumnShiftNumber.Width = 65;
			// 
			// gridColumnDaysNames
			// 
			this.gridColumnDaysNames.Caption = "Días";
			this.gridColumnDaysNames.FieldName = "DaysNames";
			this.gridColumnDaysNames.Name = "gridColumnDaysNames";
			this.gridColumnDaysNames.OptionsColumn.AllowEdit = false;
			this.gridColumnDaysNames.OptionsColumn.AllowFocus = false;
			this.gridColumnDaysNames.OptionsColumn.AllowShowHide = false;
			this.gridColumnDaysNames.OptionsColumn.ReadOnly = true;
			this.gridColumnDaysNames.Visible = true;
			this.gridColumnDaysNames.VisibleIndex = 1;
			this.gridColumnDaysNames.Width = 262;
			// 
			// gridColumnShiftTime
			// 
			this.gridColumnShiftTime.Caption = "Hora";
			this.gridColumnShiftTime.DisplayFormat.FormatString = "hh:mm";
			this.gridColumnShiftTime.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
			this.gridColumnShiftTime.FieldName = "Time";
			this.gridColumnShiftTime.Name = "gridColumnShiftTime";
			this.gridColumnShiftTime.OptionsColumn.AllowEdit = false;
			this.gridColumnShiftTime.OptionsColumn.AllowFocus = false;
			this.gridColumnShiftTime.OptionsColumn.AllowShowHide = false;
			this.gridColumnShiftTime.OptionsColumn.ReadOnly = true;
			this.gridColumnShiftTime.Visible = true;
			this.gridColumnShiftTime.VisibleIndex = 2;
			this.gridColumnShiftTime.Width = 93;
			// 
			// gridColumnShiftQuota
			// 
			this.gridColumnShiftQuota.Caption = "Cupo";
			this.gridColumnShiftQuota.FieldName = "Quota";
			this.gridColumnShiftQuota.Name = "gridColumnShiftQuota";
			this.gridColumnShiftQuota.OptionsColumn.AllowEdit = false;
			this.gridColumnShiftQuota.OptionsColumn.AllowFocus = false;
			this.gridColumnShiftQuota.OptionsColumn.AllowShowHide = false;
			this.gridColumnShiftQuota.OptionsColumn.ReadOnly = true;
			this.gridColumnShiftQuota.Visible = true;
			this.gridColumnShiftQuota.VisibleIndex = 3;
			this.gridColumnShiftQuota.Width = 49;
			// 
			// splitContainerControl1
			// 
			this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
			this.splitContainerControl1.Name = "splitContainerControl1";
			this.splitContainerControl1.Panel1.Controls.Add(this.gridControlShifts);
			this.splitContainerControl1.Panel1.Text = "Panel1";
			this.splitContainerControl1.Panel2.Controls.Add(this.groupBox1);
			this.splitContainerControl1.Panel2.Controls.Add(this.gridControlMembers);
			this.splitContainerControl1.Panel2.Text = "Panel2";
			this.splitContainerControl1.Size = new System.Drawing.Size(1168, 738);
			this.splitContainerControl1.SplitterPosition = 561;
			this.splitContainerControl1.TabIndex = 1;
			this.splitContainerControl1.Text = "splitContainerControl1";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.txtAvailableQuota);
			this.groupBox1.Controls.Add(this.labelControl5);
			this.groupBox1.Controls.Add(this.txtQuota);
			this.groupBox1.Controls.Add(this.labelControl4);
			this.groupBox1.Controls.Add(this.txtTime);
			this.groupBox1.Controls.Add(this.labelControl3);
			this.groupBox1.Controls.Add(this.txtDaysNames);
			this.groupBox1.Controls.Add(this.labelControl2);
			this.groupBox1.Controls.Add(this.txtTrainingName);
			this.groupBox1.Controls.Add(this.labelControl1);
			this.groupBox1.Location = new System.Drawing.Point(0, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(583, 162);
			this.groupBox1.TabIndex = 2;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Datos del turno";
			// 
			// txtAvailableQuota
			// 
			this.txtAvailableQuota.Location = new System.Drawing.Point(203, 135);
			this.txtAvailableQuota.Name = "txtAvailableQuota";
			this.txtAvailableQuota.ReadOnly = true;
			this.txtAvailableQuota.Size = new System.Drawing.Size(48, 21);
			this.txtAvailableQuota.TabIndex = 9;
			this.txtAvailableQuota.TabStop = false;
			this.txtAvailableQuota.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// labelControl5
			// 
			this.labelControl5.Location = new System.Drawing.Point(203, 116);
			this.labelControl5.Name = "labelControl5";
			this.labelControl5.Size = new System.Drawing.Size(48, 13);
			this.labelControl5.TabIndex = 8;
			this.labelControl5.Text = "Disponible";
			// 
			// txtQuota
			// 
			this.txtQuota.Location = new System.Drawing.Point(137, 135);
			this.txtQuota.Name = "txtQuota";
			this.txtQuota.ReadOnly = true;
			this.txtQuota.Size = new System.Drawing.Size(37, 21);
			this.txtQuota.TabIndex = 7;
			this.txtQuota.TabStop = false;
			this.txtQuota.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// labelControl4
			// 
			this.labelControl4.Location = new System.Drawing.Point(142, 116);
			this.labelControl4.Name = "labelControl4";
			this.labelControl4.Size = new System.Drawing.Size(25, 13);
			this.labelControl4.TabIndex = 6;
			this.labelControl4.Text = "Cupo";
			// 
			// txtTime
			// 
			this.txtTime.Location = new System.Drawing.Point(6, 135);
			this.txtTime.Name = "txtTime";
			this.txtTime.ReadOnly = true;
			this.txtTime.Size = new System.Drawing.Size(99, 21);
			this.txtTime.TabIndex = 5;
			this.txtTime.TabStop = false;
			// 
			// labelControl3
			// 
			this.labelControl3.Location = new System.Drawing.Point(6, 116);
			this.labelControl3.Name = "labelControl3";
			this.labelControl3.Size = new System.Drawing.Size(35, 13);
			this.labelControl3.TabIndex = 4;
			this.labelControl3.Text = "Horario";
			// 
			// txtDaysNames
			// 
			this.txtDaysNames.Location = new System.Drawing.Point(6, 89);
			this.txtDaysNames.Name = "txtDaysNames";
			this.txtDaysNames.ReadOnly = true;
			this.txtDaysNames.Size = new System.Drawing.Size(571, 21);
			this.txtDaysNames.TabIndex = 3;
			this.txtDaysNames.TabStop = false;
			// 
			// labelControl2
			// 
			this.labelControl2.Location = new System.Drawing.Point(6, 70);
			this.labelControl2.Name = "labelControl2";
			this.labelControl2.Size = new System.Drawing.Size(20, 13);
			this.labelControl2.TabIndex = 2;
			this.labelControl2.Text = "Días";
			// 
			// txtTrainingName
			// 
			this.txtTrainingName.Location = new System.Drawing.Point(6, 42);
			this.txtTrainingName.Name = "txtTrainingName";
			this.txtTrainingName.ReadOnly = true;
			this.txtTrainingName.Size = new System.Drawing.Size(571, 21);
			this.txtTrainingName.TabIndex = 1;
			this.txtTrainingName.TabStop = false;
			// 
			// labelControl1
			// 
			this.labelControl1.Location = new System.Drawing.Point(6, 23);
			this.labelControl1.Name = "labelControl1";
			this.labelControl1.Size = new System.Drawing.Size(44, 13);
			this.labelControl1.TabIndex = 0;
			this.labelControl1.Text = "Actividad";
			// 
			// gridControlMembers
			// 
			this.gridControlMembers.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.gridControlMembers.Location = new System.Drawing.Point(0, 180);
			this.gridControlMembers.MainView = this.gridViewMembers;
			this.gridControlMembers.Name = "gridControlMembers";
			this.gridControlMembers.Size = new System.Drawing.Size(595, 558);
			this.gridControlMembers.TabIndex = 1;
			this.gridControlMembers.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewMembers});
			// 
			// gridViewMembers
			// 
			this.gridViewMembers.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumnMemberId,
            this.gridColumnMemberFullName});
			this.gridViewMembers.GridControl = this.gridControlMembers;
			this.gridViewMembers.Name = "gridViewMembers";
			this.gridViewMembers.OptionsFind.AlwaysVisible = true;
			this.gridViewMembers.OptionsFind.FindNullPrompt = "Empieza a esciribir para buscar..";
			this.gridViewMembers.OptionsFind.ShowClearButton = false;
			this.gridViewMembers.OptionsFind.ShowCloseButton = false;
			this.gridViewMembers.OptionsFind.ShowFindButton = false;
			this.gridViewMembers.OptionsView.ShowGroupPanel = false;
			this.gridViewMembers.OptionsView.ShowIndicator = false;
			this.gridViewMembers.OptionsView.ShowViewCaption = true;
			this.gridViewMembers.ViewCaption = "Miembros";
			// 
			// gridColumnMemberId
			// 
			this.gridColumnMemberId.Caption = "Id";
			this.gridColumnMemberId.FieldName = "Id";
			this.gridColumnMemberId.Name = "gridColumnMemberId";
			// 
			// gridColumnMemberFullName
			// 
			this.gridColumnMemberFullName.Caption = "Nombre";
			this.gridColumnMemberFullName.FieldName = "FullName";
			this.gridColumnMemberFullName.Name = "gridColumnMemberFullName";
			this.gridColumnMemberFullName.OptionsColumn.AllowEdit = false;
			this.gridColumnMemberFullName.OptionsColumn.AllowFocus = false;
			this.gridColumnMemberFullName.OptionsColumn.AllowShowHide = false;
			this.gridColumnMemberFullName.OptionsColumn.ReadOnly = true;
			this.gridColumnMemberFullName.Visible = true;
			this.gridColumnMemberFullName.VisibleIndex = 0;
			// 
			// ShiftsAndQuotasView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1168, 738);
			this.Controls.Add(this.splitContainerControl1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "ShiftsAndQuotasView";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Turnos y cupos";
			this.Load += new System.EventHandler(this.ShiftsAndQuotasView_Load);
			((System.ComponentModel.ISupportInitialize)(this.gridControlShifts)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridViewShifts)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
			this.splitContainerControl1.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridControlMembers)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gridViewMembers)).EndInit();
			this.ResumeLayout(false);

      }

      #endregion

      private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel;
      private DevExpress.XtraGrid.GridControl gridControlShifts;
      private DevExpress.XtraGrid.Views.Grid.GridView gridViewShifts;
      private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
      private DevExpress.XtraGrid.GridControl gridControlMembers;
      private DevExpress.XtraGrid.Views.Grid.GridView gridViewMembers;
      private DevExpress.XtraGrid.Columns.GridColumn gridColumnShiftId;
      private DevExpress.XtraGrid.Columns.GridColumn gridColumnShiftTrainingName;
      private DevExpress.XtraGrid.Columns.GridColumn gridColumnShiftNumber;
      private DevExpress.XtraGrid.Columns.GridColumn gridColumnDaysNames;
      private DevExpress.XtraGrid.Columns.GridColumn gridColumnShiftTime;
      private DevExpress.XtraGrid.Columns.GridColumn gridColumnShiftQuota;
      private DevExpress.XtraGrid.Columns.GridColumn gridColumnMemberId;
      private DevExpress.XtraGrid.Columns.GridColumn gridColumnMemberFullName;
      private System.Windows.Forms.GroupBox groupBox1;
      private System.Windows.Forms.TextBox txtAvailableQuota;
      private DevExpress.XtraEditors.LabelControl labelControl5;
      private System.Windows.Forms.TextBox txtQuota;
      private DevExpress.XtraEditors.LabelControl labelControl4;
      private System.Windows.Forms.TextBox txtTime;
      private DevExpress.XtraEditors.LabelControl labelControl3;
      private System.Windows.Forms.TextBox txtDaysNames;
      private DevExpress.XtraEditors.LabelControl labelControl2;
      private System.Windows.Forms.TextBox txtTrainingName;
      private DevExpress.XtraEditors.LabelControl labelControl1;
   }
}