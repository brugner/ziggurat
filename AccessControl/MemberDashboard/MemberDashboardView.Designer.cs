namespace AccessControl.MemberDashboard
{
   partial class MemberDashboardView
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
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MemberDashboardView));
         DevExpress.XtraCharts.XYDiagram xyDiagram1 = new DevExpress.XtraCharts.XYDiagram();
         DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
         DevExpress.XtraCharts.LineSeriesView lineSeriesView1 = new DevExpress.XtraCharts.LineSeriesView();
         this.panel1 = new System.Windows.Forms.Panel();
         this.lbNeedHelp = new DevExpress.XtraEditors.LabelControl();
         this.lbTitle = new DevExpress.XtraEditors.LabelControl();
         this.panel4 = new System.Windows.Forms.Panel();
         this.pbProfilePicture = new System.Windows.Forms.PictureBox();
         this.txtMembershipNumber = new System.Windows.Forms.TextBox();
         this.lbQuestion = new DevExpress.XtraEditors.LabelControl();
         this.lbTrainingNumber = new DevExpress.XtraEditors.LabelControl();
         this.lbMemberName = new DevExpress.XtraEditors.LabelControl();
         this.gridControlMemberships = new DevExpress.XtraGrid.GridControl();
         this.gridViewMemberships = new DevExpress.XtraGrid.Views.Grid.GridView();
         this.gridColumnMembershipId = new DevExpress.XtraGrid.Columns.GridColumn();
         this.gridColumnMembershipLineNumber = new DevExpress.XtraGrid.Columns.GridColumn();
         this.gridColumnMembershipTrainingName = new DevExpress.XtraGrid.Columns.GridColumn();
         this.gridColumnMembershipStartDate = new DevExpress.XtraGrid.Columns.GridColumn();
         this.gridColumnMembershipEndDate = new DevExpress.XtraGrid.Columns.GridColumn();
         this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
         this.panel2 = new System.Windows.Forms.Panel();
         this.txtAdText = new System.Windows.Forms.RichTextBox();
         this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
         this.pbAdImage = new System.Windows.Forms.PictureBox();
         this.panel3 = new System.Windows.Forms.Panel();
         this.lbFavoriteProduct2 = new DevExpress.XtraEditors.LabelControl();
         this.lbFavoriteTraining2 = new DevExpress.XtraEditors.LabelControl();
         this.lbLastCheckin2 = new DevExpress.XtraEditors.LabelControl();
         this.lbTotalCheckinsCount2 = new DevExpress.XtraEditors.LabelControl();
         this.lbJoiningDate2 = new DevExpress.XtraEditors.LabelControl();
         this.lbBirthdayDaysCount = new DevExpress.XtraEditors.LabelControl();
         this.lbFavoriteProduct1 = new DevExpress.XtraEditors.LabelControl();
         this.lbFavoriteTraining1 = new DevExpress.XtraEditors.LabelControl();
         this.lbCheckins = new DevExpress.XtraEditors.LabelControl();
         this.lbLastCheckin1 = new DevExpress.XtraEditors.LabelControl();
         this.lbTotalCheckinsCount1 = new DevExpress.XtraEditors.LabelControl();
         this.lbJoiningDate1 = new DevExpress.XtraEditors.LabelControl();
         this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
         this.chartControlCheckins = new DevExpress.XtraCharts.ChartControl();
         this.lbClock = new DevExpress.XtraEditors.LabelControl();
         this.timerClock = new System.Windows.Forms.Timer();
         this.timerAd = new System.Windows.Forms.Timer();
         this.defaultLookAndFeel = new DevExpress.LookAndFeel.DefaultLookAndFeel();
         this.timerBirthday = new System.Windows.Forms.Timer();
         this.panel1.SuspendLayout();
         this.panel4.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.pbProfilePicture)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.gridControlMemberships)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.gridViewMemberships)).BeginInit();
         this.tableLayoutPanel1.SuspendLayout();
         this.panel2.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.pbAdImage)).BeginInit();
         this.panel3.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.chartControlCheckins)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(lineSeriesView1)).BeginInit();
         this.SuspendLayout();
         // 
         // panel1
         // 
         this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.panel1.BackColor = System.Drawing.Color.Gainsboro;
         this.panel1.Controls.Add(this.lbNeedHelp);
         this.panel1.Controls.Add(this.lbTitle);
         this.panel1.Controls.Add(this.panel4);
         this.panel1.Location = new System.Drawing.Point(415, 3);
         this.panel1.Name = "panel1";
         this.panel1.Size = new System.Drawing.Size(642, 842);
         this.panel1.TabIndex = 0;
         // 
         // lbNeedHelp
         // 
         this.lbNeedHelp.Appearance.BackColor = System.Drawing.Color.Transparent;
         this.lbNeedHelp.Appearance.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lbNeedHelp.Appearance.Options.UseBackColor = true;
         this.lbNeedHelp.Appearance.Options.UseFont = true;
         this.lbNeedHelp.Appearance.Options.UseTextOptions = true;
         this.lbNeedHelp.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
         this.lbNeedHelp.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
         this.lbNeedHelp.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
         this.lbNeedHelp.Dock = System.Windows.Forms.DockStyle.Bottom;
         this.lbNeedHelp.Location = new System.Drawing.Point(0, 811);
         this.lbNeedHelp.Name = "lbNeedHelp";
         this.lbNeedHelp.Size = new System.Drawing.Size(642, 31);
         this.lbNeedHelp.TabIndex = 7;
         this.lbNeedHelp.Text = "¿Necesitas ayuda? Presiona *";
         // 
         // lbTitle
         // 
         this.lbTitle.Appearance.BackColor = System.Drawing.Color.Transparent;
         this.lbTitle.Appearance.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lbTitle.Appearance.ForeColor = System.Drawing.Color.Black;
         this.lbTitle.Appearance.Options.UseBackColor = true;
         this.lbTitle.Appearance.Options.UseFont = true;
         this.lbTitle.Appearance.Options.UseForeColor = true;
         this.lbTitle.Appearance.Options.UseTextOptions = true;
         this.lbTitle.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
         this.lbTitle.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
         this.lbTitle.Dock = System.Windows.Forms.DockStyle.Top;
         this.lbTitle.Location = new System.Drawing.Point(0, 0);
         this.lbTitle.Name = "lbTitle";
         this.lbTitle.Size = new System.Drawing.Size(642, 88);
         this.lbTitle.TabIndex = 0;
         this.lbTitle.Text = "Bienvenid@ a Club Gym";
         // 
         // panel4
         // 
         this.panel4.Anchor = System.Windows.Forms.AnchorStyles.Top;
         this.panel4.BackColor = System.Drawing.Color.Transparent;
         this.panel4.Controls.Add(this.pbProfilePicture);
         this.panel4.Controls.Add(this.txtMembershipNumber);
         this.panel4.Controls.Add(this.lbQuestion);
         this.panel4.Controls.Add(this.lbTrainingNumber);
         this.panel4.Controls.Add(this.lbMemberName);
         this.panel4.Controls.Add(this.gridControlMemberships);
         this.panel4.Location = new System.Drawing.Point(3, 91);
         this.panel4.Name = "panel4";
         this.panel4.Size = new System.Drawing.Size(636, 629);
         this.panel4.TabIndex = 8;
         // 
         // pbProfilePicture
         // 
         this.pbProfilePicture.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
         this.pbProfilePicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.pbProfilePicture.Cursor = System.Windows.Forms.Cursors.Default;
         this.pbProfilePicture.Image = ((System.Drawing.Image)(resources.GetObject("pbProfilePicture.Image")));
         this.pbProfilePicture.Location = new System.Drawing.Point(214, 18);
         this.pbProfilePicture.Name = "pbProfilePicture";
         this.pbProfilePicture.Size = new System.Drawing.Size(211, 234);
         this.pbProfilePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
         this.pbProfilePicture.TabIndex = 2;
         this.pbProfilePicture.TabStop = false;
         // 
         // txtMembershipNumber
         // 
         this.txtMembershipNumber.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
         this.txtMembershipNumber.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.txtMembershipNumber.Location = new System.Drawing.Point(268, 520);
         this.txtMembershipNumber.MaxLength = 2;
         this.txtMembershipNumber.Name = "txtMembershipNumber";
         this.txtMembershipNumber.Size = new System.Drawing.Size(100, 40);
         this.txtMembershipNumber.TabIndex = 0;
         this.txtMembershipNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
         this.txtMembershipNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMembershipNumber_KeyPress);
         // 
         // lbQuestion
         // 
         this.lbQuestion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.lbQuestion.Appearance.BackColor = System.Drawing.Color.Transparent;
         this.lbQuestion.Appearance.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lbQuestion.Appearance.Options.UseBackColor = true;
         this.lbQuestion.Appearance.Options.UseFont = true;
         this.lbQuestion.Appearance.Options.UseTextOptions = true;
         this.lbQuestion.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
         this.lbQuestion.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
         this.lbQuestion.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
         this.lbQuestion.Location = new System.Drawing.Point(0, 317);
         this.lbQuestion.Name = "lbQuestion";
         this.lbQuestion.Size = new System.Drawing.Size(636, 31);
         this.lbQuestion.TabIndex = 4;
         this.lbQuestion.Text = "¿Qué actividad vas a realizar hoy?";
         // 
         // lbTrainingNumber
         // 
         this.lbTrainingNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.lbTrainingNumber.Appearance.BackColor = System.Drawing.Color.Transparent;
         this.lbTrainingNumber.Appearance.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lbTrainingNumber.Appearance.Options.UseBackColor = true;
         this.lbTrainingNumber.Appearance.Options.UseFont = true;
         this.lbTrainingNumber.Appearance.Options.UseTextOptions = true;
         this.lbTrainingNumber.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
         this.lbTrainingNumber.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
         this.lbTrainingNumber.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
         this.lbTrainingNumber.Location = new System.Drawing.Point(0, 484);
         this.lbTrainingNumber.Name = "lbTrainingNumber";
         this.lbTrainingNumber.Size = new System.Drawing.Size(636, 31);
         this.lbTrainingNumber.TabIndex = 6;
         this.lbTrainingNumber.Text = "Ingresa el número de actividad";
         // 
         // lbMemberName
         // 
         this.lbMemberName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.lbMemberName.Appearance.BackColor = System.Drawing.Color.Transparent;
         this.lbMemberName.Appearance.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lbMemberName.Appearance.Options.UseBackColor = true;
         this.lbMemberName.Appearance.Options.UseFont = true;
         this.lbMemberName.Appearance.Options.UseTextOptions = true;
         this.lbMemberName.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
         this.lbMemberName.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
         this.lbMemberName.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
         this.lbMemberName.Location = new System.Drawing.Point(0, 258);
         this.lbMemberName.Name = "lbMemberName";
         this.lbMemberName.Size = new System.Drawing.Size(636, 43);
         this.lbMemberName.TabIndex = 3;
         this.lbMemberName.Text = "Nery Brugnoni";
         // 
         // gridControlMemberships
         // 
         this.gridControlMemberships.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.gridControlMemberships.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.gridControlMemberships.Location = new System.Drawing.Point(22, 354);
         this.gridControlMemberships.MainView = this.gridViewMemberships;
         this.gridControlMemberships.Name = "gridControlMemberships";
         this.gridControlMemberships.Size = new System.Drawing.Size(588, 125);
         this.gridControlMemberships.TabIndex = 5;
         this.gridControlMemberships.TabStop = false;
         this.gridControlMemberships.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewMemberships});
         this.gridControlMemberships.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.gridControlMemberships_KeyPress);
         // 
         // gridViewMemberships
         // 
         this.gridViewMemberships.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.gridViewMemberships.Appearance.HeaderPanel.Options.UseFont = true;
         this.gridViewMemberships.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.gridViewMemberships.Appearance.Row.Options.UseFont = true;
         this.gridViewMemberships.Appearance.ViewCaption.ForeColor = System.Drawing.Color.Black;
         this.gridViewMemberships.Appearance.ViewCaption.Options.UseForeColor = true;
         this.gridViewMemberships.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumnMembershipId,
            this.gridColumnMembershipLineNumber,
            this.gridColumnMembershipTrainingName,
            this.gridColumnMembershipStartDate,
            this.gridColumnMembershipEndDate});
         this.gridViewMemberships.GridControl = this.gridControlMemberships;
         this.gridViewMemberships.Name = "gridViewMemberships";
         this.gridViewMemberships.OptionsView.ShowGroupPanel = false;
         this.gridViewMemberships.OptionsView.ShowIndicator = false;
         // 
         // gridColumnMembershipId
         // 
         this.gridColumnMembershipId.Caption = "Id";
         this.gridColumnMembershipId.FieldName = "Id";
         this.gridColumnMembershipId.Name = "gridColumnMembershipId";
         // 
         // gridColumnMembershipLineNumber
         // 
         this.gridColumnMembershipLineNumber.AppearanceCell.Options.UseTextOptions = true;
         this.gridColumnMembershipLineNumber.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
         this.gridColumnMembershipLineNumber.AppearanceHeader.Options.UseTextOptions = true;
         this.gridColumnMembershipLineNumber.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
         this.gridColumnMembershipLineNumber.Caption = "#";
         this.gridColumnMembershipLineNumber.FieldName = "LineNumber";
         this.gridColumnMembershipLineNumber.Name = "gridColumnMembershipLineNumber";
         this.gridColumnMembershipLineNumber.OptionsColumn.AllowEdit = false;
         this.gridColumnMembershipLineNumber.OptionsColumn.AllowFocus = false;
         this.gridColumnMembershipLineNumber.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
         this.gridColumnMembershipLineNumber.OptionsColumn.AllowIncrementalSearch = false;
         this.gridColumnMembershipLineNumber.OptionsColumn.AllowShowHide = false;
         this.gridColumnMembershipLineNumber.OptionsColumn.AllowSize = false;
         this.gridColumnMembershipLineNumber.OptionsColumn.ReadOnly = true;
         this.gridColumnMembershipLineNumber.Visible = true;
         this.gridColumnMembershipLineNumber.VisibleIndex = 0;
         this.gridColumnMembershipLineNumber.Width = 26;
         // 
         // gridColumnMembershipTrainingName
         // 
         this.gridColumnMembershipTrainingName.Caption = "Actividad";
         this.gridColumnMembershipTrainingName.FieldName = "TrainingName";
         this.gridColumnMembershipTrainingName.Name = "gridColumnMembershipTrainingName";
         this.gridColumnMembershipTrainingName.OptionsColumn.AllowEdit = false;
         this.gridColumnMembershipTrainingName.OptionsColumn.AllowFocus = false;
         this.gridColumnMembershipTrainingName.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
         this.gridColumnMembershipTrainingName.OptionsColumn.AllowIncrementalSearch = false;
         this.gridColumnMembershipTrainingName.OptionsColumn.AllowShowHide = false;
         this.gridColumnMembershipTrainingName.OptionsColumn.AllowSize = false;
         this.gridColumnMembershipTrainingName.OptionsColumn.ReadOnly = true;
         this.gridColumnMembershipTrainingName.Visible = true;
         this.gridColumnMembershipTrainingName.VisibleIndex = 1;
         this.gridColumnMembershipTrainingName.Width = 200;
         // 
         // gridColumnMembershipStartDate
         // 
         this.gridColumnMembershipStartDate.Caption = "Inicio";
         this.gridColumnMembershipStartDate.DisplayFormat.FormatString = "dd/MM/yyyy";
         this.gridColumnMembershipStartDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
         this.gridColumnMembershipStartDate.FieldName = "StartDate";
         this.gridColumnMembershipStartDate.Name = "gridColumnMembershipStartDate";
         this.gridColumnMembershipStartDate.OptionsColumn.AllowEdit = false;
         this.gridColumnMembershipStartDate.OptionsColumn.AllowFocus = false;
         this.gridColumnMembershipStartDate.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
         this.gridColumnMembershipStartDate.OptionsColumn.AllowIncrementalSearch = false;
         this.gridColumnMembershipStartDate.OptionsColumn.AllowShowHide = false;
         this.gridColumnMembershipStartDate.OptionsColumn.AllowSize = false;
         this.gridColumnMembershipStartDate.OptionsColumn.ReadOnly = true;
         this.gridColumnMembershipStartDate.Visible = true;
         this.gridColumnMembershipStartDate.VisibleIndex = 2;
         this.gridColumnMembershipStartDate.Width = 100;
         // 
         // gridColumnMembershipEndDate
         // 
         this.gridColumnMembershipEndDate.Caption = "Vencimiento";
         this.gridColumnMembershipEndDate.DisplayFormat.FormatString = "dd/MM/yyyy";
         this.gridColumnMembershipEndDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
         this.gridColumnMembershipEndDate.FieldName = "EndDate";
         this.gridColumnMembershipEndDate.Name = "gridColumnMembershipEndDate";
         this.gridColumnMembershipEndDate.OptionsColumn.AllowEdit = false;
         this.gridColumnMembershipEndDate.OptionsColumn.AllowFocus = false;
         this.gridColumnMembershipEndDate.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
         this.gridColumnMembershipEndDate.OptionsColumn.AllowIncrementalSearch = false;
         this.gridColumnMembershipEndDate.OptionsColumn.AllowShowHide = false;
         this.gridColumnMembershipEndDate.OptionsColumn.AllowSize = false;
         this.gridColumnMembershipEndDate.OptionsColumn.ReadOnly = true;
         this.gridColumnMembershipEndDate.Visible = true;
         this.gridColumnMembershipEndDate.VisibleIndex = 3;
         this.gridColumnMembershipEndDate.Width = 100;
         // 
         // tableLayoutPanel1
         // 
         this.tableLayoutPanel1.ColumnCount = 3;
         this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.00261F));
         this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.99826F));
         this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.99913F));
         this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 0);
         this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 0);
         this.tableLayoutPanel1.Controls.Add(this.panel3, 2, 0);
         this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
         this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
         this.tableLayoutPanel1.Name = "tableLayoutPanel1";
         this.tableLayoutPanel1.RowCount = 1;
         this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
         this.tableLayoutPanel1.Size = new System.Drawing.Size(1473, 848);
         this.tableLayoutPanel1.TabIndex = 2;
         // 
         // panel2
         // 
         this.panel2.Controls.Add(this.txtAdText);
         this.panel2.Controls.Add(this.labelControl4);
         this.panel2.Controls.Add(this.pbAdImage);
         this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
         this.panel2.Location = new System.Drawing.Point(3, 3);
         this.panel2.Name = "panel2";
         this.panel2.Size = new System.Drawing.Size(406, 842);
         this.panel2.TabIndex = 2;
         // 
         // txtAdText
         // 
         this.txtAdText.Anchor = System.Windows.Forms.AnchorStyles.Top;
         this.txtAdText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.txtAdText.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.txtAdText.Location = new System.Drawing.Point(12, 390);
         this.txtAdText.MaxLength = 100;
         this.txtAdText.Name = "txtAdText";
         this.txtAdText.ReadOnly = true;
         this.txtAdText.Size = new System.Drawing.Size(384, 287);
         this.txtAdText.TabIndex = 7;
         this.txtAdText.TabStop = false;
         this.txtAdText.Text = "";
         // 
         // labelControl4
         // 
         this.labelControl4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.labelControl4.Appearance.BackColor = System.Drawing.Color.Transparent;
         this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.labelControl4.Appearance.ForeColor = System.Drawing.Color.DimGray;
         this.labelControl4.Appearance.Options.UseBackColor = true;
         this.labelControl4.Appearance.Options.UseFont = true;
         this.labelControl4.Appearance.Options.UseForeColor = true;
         this.labelControl4.Appearance.Options.UseTextOptions = true;
         this.labelControl4.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
         this.labelControl4.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
         this.labelControl4.Location = new System.Drawing.Point(12, 43);
         this.labelControl4.Name = "labelControl4";
         this.labelControl4.Size = new System.Drawing.Size(384, 45);
         this.labelControl4.TabIndex = 2;
         this.labelControl4.Text = "Anuncios";
         // 
         // pbAdImage
         // 
         this.pbAdImage.Anchor = System.Windows.Forms.AnchorStyles.Top;
         this.pbAdImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
         this.pbAdImage.Cursor = System.Windows.Forms.Cursors.Default;
         this.pbAdImage.Location = new System.Drawing.Point(12, 91);
         this.pbAdImage.Name = "pbAdImage";
         this.pbAdImage.Size = new System.Drawing.Size(384, 293);
         this.pbAdImage.TabIndex = 1;
         this.pbAdImage.TabStop = false;
         // 
         // panel3
         // 
         this.panel3.Controls.Add(this.lbFavoriteProduct2);
         this.panel3.Controls.Add(this.lbFavoriteTraining2);
         this.panel3.Controls.Add(this.lbLastCheckin2);
         this.panel3.Controls.Add(this.lbTotalCheckinsCount2);
         this.panel3.Controls.Add(this.lbJoiningDate2);
         this.panel3.Controls.Add(this.lbBirthdayDaysCount);
         this.panel3.Controls.Add(this.lbFavoriteProduct1);
         this.panel3.Controls.Add(this.lbFavoriteTraining1);
         this.panel3.Controls.Add(this.lbCheckins);
         this.panel3.Controls.Add(this.lbLastCheckin1);
         this.panel3.Controls.Add(this.lbTotalCheckinsCount1);
         this.panel3.Controls.Add(this.lbJoiningDate1);
         this.panel3.Controls.Add(this.labelControl5);
         this.panel3.Controls.Add(this.chartControlCheckins);
         this.panel3.Controls.Add(this.lbClock);
         this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
         this.panel3.Location = new System.Drawing.Point(1063, 3);
         this.panel3.Name = "panel3";
         this.panel3.Size = new System.Drawing.Size(407, 842);
         this.panel3.TabIndex = 3;
         // 
         // lbFavoriteProduct2
         // 
         this.lbFavoriteProduct2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lbFavoriteProduct2.Appearance.ForeColor = System.Drawing.Color.DimGray;
         this.lbFavoriteProduct2.Appearance.Options.UseFont = true;
         this.lbFavoriteProduct2.Appearance.Options.UseForeColor = true;
         this.lbFavoriteProduct2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
         this.lbFavoriteProduct2.Location = new System.Drawing.Point(13, 644);
         this.lbFavoriteProduct2.Name = "lbFavoriteProduct2";
         this.lbFavoriteProduct2.Size = new System.Drawing.Size(70, 19);
         this.lbFavoriteProduct2.TabIndex = 24;
         this.lbFavoriteProduct2.Text = "\'Gatorade\'";
         // 
         // lbFavoriteTraining2
         // 
         this.lbFavoriteTraining2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lbFavoriteTraining2.Appearance.ForeColor = System.Drawing.Color.DimGray;
         this.lbFavoriteTraining2.Appearance.Options.UseFont = true;
         this.lbFavoriteTraining2.Appearance.Options.UseForeColor = true;
         this.lbFavoriteTraining2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
         this.lbFavoriteTraining2.Location = new System.Drawing.Point(13, 596);
         this.lbFavoriteTraining2.Name = "lbFavoriteTraining2";
         this.lbFavoriteTraining2.Size = new System.Drawing.Size(69, 19);
         this.lbFavoriteTraining2.TabIndex = 23;
         this.lbFavoriteTraining2.Text = "\'Aparatos\'";
         // 
         // lbLastCheckin2
         // 
         this.lbLastCheckin2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.lbLastCheckin2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lbLastCheckin2.Appearance.ForeColor = System.Drawing.Color.DimGray;
         this.lbLastCheckin2.Appearance.Options.UseFont = true;
         this.lbLastCheckin2.Appearance.Options.UseForeColor = true;
         this.lbLastCheckin2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical;
         this.lbLastCheckin2.Location = new System.Drawing.Point(13, 529);
         this.lbLastCheckin2.Name = "lbLastCheckin2";
         this.lbLastCheckin2.Size = new System.Drawing.Size(384, 38);
         this.lbLastCheckin2.TabIndex = 22;
         this.lbLastCheckin2.Text = "\'Aparatos\' el sábado 24 de septiembre de 2018 a las 14:03";
         // 
         // lbTotalCheckinsCount2
         // 
         this.lbTotalCheckinsCount2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lbTotalCheckinsCount2.Appearance.ForeColor = System.Drawing.Color.DimGray;
         this.lbTotalCheckinsCount2.Appearance.Options.UseFont = true;
         this.lbTotalCheckinsCount2.Appearance.Options.UseForeColor = true;
         this.lbTotalCheckinsCount2.Location = new System.Drawing.Point(13, 482);
         this.lbTotalCheckinsCount2.Name = "lbTotalCheckinsCount2";
         this.lbTotalCheckinsCount2.Size = new System.Drawing.Size(27, 19);
         this.lbTotalCheckinsCount2.TabIndex = 21;
         this.lbTotalCheckinsCount2.Text = "240";
         // 
         // lbJoiningDate2
         // 
         this.lbJoiningDate2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.lbJoiningDate2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lbJoiningDate2.Appearance.ForeColor = System.Drawing.Color.DimGray;
         this.lbJoiningDate2.Appearance.Options.UseFont = true;
         this.lbJoiningDate2.Appearance.Options.UseForeColor = true;
         this.lbJoiningDate2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical;
         this.lbJoiningDate2.Location = new System.Drawing.Point(13, 435);
         this.lbJoiningDate2.Name = "lbJoiningDate2";
         this.lbJoiningDate2.Size = new System.Drawing.Size(384, 19);
         this.lbJoiningDate2.TabIndex = 20;
         this.lbJoiningDate2.Text = "sábado 24 de septiembre de 2018 a las 14:03";
         // 
         // lbBirthdayDaysCount
         // 
         this.lbBirthdayDaysCount.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lbBirthdayDaysCount.Appearance.ForeColor = System.Drawing.Color.DimGray;
         this.lbBirthdayDaysCount.Appearance.Options.UseFont = true;
         this.lbBirthdayDaysCount.Appearance.Options.UseForeColor = true;
         this.lbBirthdayDaysCount.Location = new System.Drawing.Point(13, 675);
         this.lbBirthdayDaysCount.Name = "lbBirthdayDaysCount";
         this.lbBirthdayDaysCount.Size = new System.Drawing.Size(232, 19);
         this.lbBirthdayDaysCount.TabIndex = 19;
         this.lbBirthdayDaysCount.Text = "Faltan x días para tu cumpleaños";
         // 
         // lbFavoriteProduct1
         // 
         this.lbFavoriteProduct1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lbFavoriteProduct1.Appearance.ForeColor = System.Drawing.Color.DimGray;
         this.lbFavoriteProduct1.Appearance.Options.UseFont = true;
         this.lbFavoriteProduct1.Appearance.Options.UseForeColor = true;
         this.lbFavoriteProduct1.Location = new System.Drawing.Point(13, 624);
         this.lbFavoriteProduct1.Name = "lbFavoriteProduct1";
         this.lbFavoriteProduct1.Size = new System.Drawing.Size(142, 19);
         this.lbFavoriteProduct1.TabIndex = 18;
         this.lbFavoriteProduct1.Text = "Producto favorito";
         // 
         // lbFavoriteTraining1
         // 
         this.lbFavoriteTraining1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lbFavoriteTraining1.Appearance.ForeColor = System.Drawing.Color.DimGray;
         this.lbFavoriteTraining1.Appearance.Options.UseFont = true;
         this.lbFavoriteTraining1.Appearance.Options.UseForeColor = true;
         this.lbFavoriteTraining1.Location = new System.Drawing.Point(13, 576);
         this.lbFavoriteTraining1.Name = "lbFavoriteTraining1";
         this.lbFavoriteTraining1.Size = new System.Drawing.Size(145, 19);
         this.lbFavoriteTraining1.TabIndex = 17;
         this.lbFavoriteTraining1.Text = "Actividad favorita";
         // 
         // lbCheckins
         // 
         this.lbCheckins.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.lbCheckins.Appearance.BackColor = System.Drawing.Color.Transparent;
         this.lbCheckins.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lbCheckins.Appearance.ForeColor = System.Drawing.Color.DimGray;
         this.lbCheckins.Appearance.Options.UseBackColor = true;
         this.lbCheckins.Appearance.Options.UseFont = true;
         this.lbCheckins.Appearance.Options.UseForeColor = true;
         this.lbCheckins.Appearance.Options.UseTextOptions = true;
         this.lbCheckins.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
         this.lbCheckins.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
         this.lbCheckins.Location = new System.Drawing.Point(13, 387);
         this.lbCheckins.Name = "lbCheckins";
         this.lbCheckins.Size = new System.Drawing.Size(384, 19);
         this.lbCheckins.TabIndex = 16;
         this.lbCheckins.Text = "Asistencias de los últimos 30 días";
         // 
         // lbLastCheckin1
         // 
         this.lbLastCheckin1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lbLastCheckin1.Appearance.ForeColor = System.Drawing.Color.DimGray;
         this.lbLastCheckin1.Appearance.Options.UseFont = true;
         this.lbLastCheckin1.Appearance.Options.UseForeColor = true;
         this.lbLastCheckin1.Location = new System.Drawing.Point(13, 510);
         this.lbLastCheckin1.Name = "lbLastCheckin1";
         this.lbLastCheckin1.Size = new System.Drawing.Size(140, 19);
         this.lbLastCheckin1.TabIndex = 15;
         this.lbLastCheckin1.Text = "Última asistencia";
         // 
         // lbTotalCheckinsCount1
         // 
         this.lbTotalCheckinsCount1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lbTotalCheckinsCount1.Appearance.ForeColor = System.Drawing.Color.DimGray;
         this.lbTotalCheckinsCount1.Appearance.Options.UseFont = true;
         this.lbTotalCheckinsCount1.Appearance.Options.UseForeColor = true;
         this.lbTotalCheckinsCount1.Location = new System.Drawing.Point(13, 463);
         this.lbTotalCheckinsCount1.Name = "lbTotalCheckinsCount1";
         this.lbTotalCheckinsCount1.Size = new System.Drawing.Size(162, 19);
         this.lbTotalCheckinsCount1.TabIndex = 14;
         this.lbTotalCheckinsCount1.Text = "Total de asistencias";
         // 
         // lbJoiningDate1
         // 
         this.lbJoiningDate1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lbJoiningDate1.Appearance.ForeColor = System.Drawing.Color.DimGray;
         this.lbJoiningDate1.Appearance.Options.UseFont = true;
         this.lbJoiningDate1.Appearance.Options.UseForeColor = true;
         this.lbJoiningDate1.Location = new System.Drawing.Point(13, 416);
         this.lbJoiningDate1.Name = "lbJoiningDate1";
         this.lbJoiningDate1.Size = new System.Drawing.Size(109, 19);
         this.lbJoiningDate1.TabIndex = 13;
         this.lbJoiningDate1.Text = "Fecha de alta";
         // 
         // labelControl5
         // 
         this.labelControl5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.labelControl5.Appearance.BackColor = System.Drawing.Color.Transparent;
         this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.labelControl5.Appearance.ForeColor = System.Drawing.Color.DimGray;
         this.labelControl5.Appearance.Options.UseBackColor = true;
         this.labelControl5.Appearance.Options.UseFont = true;
         this.labelControl5.Appearance.Options.UseForeColor = true;
         this.labelControl5.Appearance.Options.UseTextOptions = true;
         this.labelControl5.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
         this.labelControl5.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
         this.labelControl5.Location = new System.Drawing.Point(12, 43);
         this.labelControl5.Name = "labelControl5";
         this.labelControl5.Size = new System.Drawing.Size(385, 45);
         this.labelControl5.TabIndex = 11;
         this.labelControl5.Text = "Tus estadísticas";
         // 
         // chartControlCheckins
         // 
         this.chartControlCheckins.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.chartControlCheckins.DataBindings = null;
         xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
         xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
         this.chartControlCheckins.Diagram = xyDiagram1;
         this.chartControlCheckins.Legend.Name = "Default Legend";
         this.chartControlCheckins.Legend.Visibility = DevExpress.Utils.DefaultBoolean.False;
         this.chartControlCheckins.Location = new System.Drawing.Point(13, 91);
         this.chartControlCheckins.Name = "chartControlCheckins";
         series1.Name = "Series 1";
         series1.View = lineSeriesView1;
         this.chartControlCheckins.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1};
         this.chartControlCheckins.Size = new System.Drawing.Size(385, 293);
         this.chartControlCheckins.TabIndex = 9;
         // 
         // lbClock
         // 
         this.lbClock.Appearance.BackColor = System.Drawing.Color.Transparent;
         this.lbClock.Appearance.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.lbClock.Appearance.ForeColor = System.Drawing.Color.Black;
         this.lbClock.Appearance.Options.UseBackColor = true;
         this.lbClock.Appearance.Options.UseFont = true;
         this.lbClock.Appearance.Options.UseForeColor = true;
         this.lbClock.Appearance.Options.UseTextOptions = true;
         this.lbClock.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
         this.lbClock.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
         this.lbClock.Dock = System.Windows.Forms.DockStyle.Bottom;
         this.lbClock.Location = new System.Drawing.Point(0, 813);
         this.lbClock.Name = "lbClock";
         this.lbClock.Size = new System.Drawing.Size(407, 29);
         this.lbClock.TabIndex = 8;
         this.lbClock.Text = "HH:MM:SS";
         // 
         // timerClock
         // 
         this.timerClock.Enabled = true;
         this.timerClock.Interval = 500;
         this.timerClock.Tick += new System.EventHandler(this.timerClock_Tick);
         // 
         // timerAd
         // 
         this.timerAd.Enabled = true;
         this.timerAd.Interval = 5000;
         this.timerAd.Tick += new System.EventHandler(this.timerAd_Tick);
         // 
         // defaultLookAndFeel
         // 
         this.defaultLookAndFeel.LookAndFeel.SkinName = "Office 2016 Colorful";
         // 
         // timerBirthday
         // 
         this.timerBirthday.Tick += new System.EventHandler(this.timerBirthday_Tick);
         // 
         // MemberDashboardView
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(1473, 848);
         this.Controls.Add(this.tableLayoutPanel1);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
         this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
         this.Name = "MemberDashboardView";
         this.Text = "Ziggurat Access Control";
         this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
         this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MemberDashboardView_FormClosed);
         this.Load += new System.EventHandler(this.MemberDashboardView_Load);
         this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MemberDashboardView_KeyPress);
         this.Resize += new System.EventHandler(this.MemberDashboardView_Resize);
         this.panel1.ResumeLayout(false);
         this.panel4.ResumeLayout(false);
         this.panel4.PerformLayout();
         ((System.ComponentModel.ISupportInitialize)(this.pbProfilePicture)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.gridControlMemberships)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.gridViewMemberships)).EndInit();
         this.tableLayoutPanel1.ResumeLayout(false);
         this.panel2.ResumeLayout(false);
         ((System.ComponentModel.ISupportInitialize)(this.pbAdImage)).EndInit();
         this.panel3.ResumeLayout(false);
         this.panel3.PerformLayout();
         ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(lineSeriesView1)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.chartControlCheckins)).EndInit();
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.Panel panel1;
      private DevExpress.XtraEditors.LabelControl lbTitle;
      private System.Windows.Forms.PictureBox pbProfilePicture;
      private DevExpress.XtraEditors.LabelControl lbMemberName;
      private DevExpress.XtraEditors.LabelControl lbQuestion;
      private DevExpress.XtraGrid.GridControl gridControlMemberships;
      private DevExpress.XtraGrid.Views.Grid.GridView gridViewMemberships;
      private DevExpress.XtraGrid.Columns.GridColumn gridColumnMembershipId;
      private DevExpress.XtraGrid.Columns.GridColumn gridColumnMembershipLineNumber;
      private DevExpress.XtraGrid.Columns.GridColumn gridColumnMembershipTrainingName;
      private DevExpress.XtraGrid.Columns.GridColumn gridColumnMembershipStartDate;
      private DevExpress.XtraGrid.Columns.GridColumn gridColumnMembershipEndDate;
      private System.Windows.Forms.TextBox txtMembershipNumber;
      private DevExpress.XtraEditors.LabelControl lbTrainingNumber;
      private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
      private DevExpress.XtraEditors.LabelControl lbNeedHelp;
      private System.Windows.Forms.Panel panel2;
      private System.Windows.Forms.PictureBox pbAdImage;
      private DevExpress.XtraEditors.LabelControl labelControl4;
      private System.Windows.Forms.RichTextBox txtAdText;
      private DevExpress.XtraEditors.LabelControl lbClock;
      private System.Windows.Forms.Timer timerClock;
      private System.Windows.Forms.Panel panel3;
      private System.Windows.Forms.Timer timerAd;
      private DevExpress.XtraCharts.ChartControl chartControlCheckins;
      private DevExpress.XtraEditors.LabelControl labelControl5;
      private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel;
      private System.Windows.Forms.Panel panel4;
      private DevExpress.XtraEditors.LabelControl lbCheckins;
      private DevExpress.XtraEditors.LabelControl lbBirthdayDaysCount;
      private DevExpress.XtraEditors.LabelControl lbFavoriteProduct1;
      private DevExpress.XtraEditors.LabelControl lbFavoriteTraining1;
      private DevExpress.XtraEditors.LabelControl lbLastCheckin1;
      private DevExpress.XtraEditors.LabelControl lbTotalCheckinsCount1;
      private DevExpress.XtraEditors.LabelControl lbJoiningDate1;
      private DevExpress.XtraEditors.LabelControl lbFavoriteProduct2;
      private DevExpress.XtraEditors.LabelControl lbFavoriteTraining2;
      private DevExpress.XtraEditors.LabelControl lbLastCheckin2;
      private DevExpress.XtraEditors.LabelControl lbTotalCheckinsCount2;
      private DevExpress.XtraEditors.LabelControl lbJoiningDate2;
      private System.Windows.Forms.Timer timerBirthday;
   }
}