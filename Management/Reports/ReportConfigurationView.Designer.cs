namespace Management.Reports
{
   partial class ReportConfigurationView
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportConfigurationView));
			this.btnOK = new DevExpress.XtraEditors.SimpleButton();
			this.defaultLookAndFeel = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
			this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
			this.gbCheckins = new System.Windows.Forms.GroupBox();
			this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
			this.clbTrainings = new DevExpress.XtraEditors.CheckedListBoxControl();
			this.dtpTo = new System.Windows.Forms.DateTimePicker();
			this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
			this.dtpFrom = new System.Windows.Forms.DateTimePicker();
			this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
			this.gbMembers = new System.Windows.Forms.GroupBox();
			this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
			this.lbReports = new System.Windows.Forms.ListBox();
			this.gbSales = new System.Windows.Forms.GroupBox();
			this.dtpSalesTo = new System.Windows.Forms.DateTimePicker();
			this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
			this.dtpSalesFrom = new System.Windows.Forms.DateTimePicker();
			this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
			this.gbProducts = new System.Windows.Forms.GroupBox();
			this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
			this.gbRedOnes = new System.Windows.Forms.GroupBox();
			this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
			this.gbCheckins.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.clbTrainings)).BeginInit();
			this.gbMembers.SuspendLayout();
			this.gbSales.SuspendLayout();
			this.gbProducts.SuspendLayout();
			this.gbRedOnes.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnOK
			// 
			this.btnOK.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnOK.Appearance.Options.UseFont = true;
			this.btnOK.Location = new System.Drawing.Point(548, 359);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(102, 25);
			this.btnOK.TabIndex = 0;
			this.btnOK.Text = "Generar reporte";
			this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
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
			// gbCheckins
			// 
			this.gbCheckins.Controls.Add(this.labelControl3);
			this.gbCheckins.Controls.Add(this.clbTrainings);
			this.gbCheckins.Controls.Add(this.dtpTo);
			this.gbCheckins.Controls.Add(this.labelControl2);
			this.gbCheckins.Controls.Add(this.dtpFrom);
			this.gbCheckins.Controls.Add(this.labelControl1);
			this.gbCheckins.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gbCheckins.Location = new System.Drawing.Point(245, 12);
			this.gbCheckins.Name = "gbCheckins";
			this.gbCheckins.Size = new System.Drawing.Size(405, 341);
			this.gbCheckins.TabIndex = 2;
			this.gbCheckins.TabStop = false;
			this.gbCheckins.Tag = "Asistencias";
			this.gbCheckins.Text = "Configuración";
			// 
			// labelControl3
			// 
			this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelControl3.Appearance.Options.UseFont = true;
			this.labelControl3.Location = new System.Drawing.Point(11, 90);
			this.labelControl3.Name = "labelControl3";
			this.labelControl3.Size = new System.Drawing.Size(64, 16);
			this.labelControl3.TabIndex = 5;
			this.labelControl3.Text = "Actividades";
			// 
			// clbTrainings
			// 
			this.clbTrainings.Cursor = System.Windows.Forms.Cursors.Default;
			this.clbTrainings.Location = new System.Drawing.Point(11, 112);
			this.clbTrainings.Name = "clbTrainings";
			this.clbTrainings.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
			this.clbTrainings.Size = new System.Drawing.Size(363, 95);
			this.clbTrainings.TabIndex = 4;
			this.clbTrainings.Validating += new System.ComponentModel.CancelEventHandler(this.clbTrainings_Validating);
			// 
			// dtpTo
			// 
			this.dtpTo.Location = new System.Drawing.Point(63, 51);
			this.dtpTo.Name = "dtpTo";
			this.dtpTo.Size = new System.Drawing.Size(311, 23);
			this.dtpTo.TabIndex = 3;
			// 
			// labelControl2
			// 
			this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelControl2.Appearance.Options.UseFont = true;
			this.labelControl2.Location = new System.Drawing.Point(11, 56);
			this.labelControl2.Name = "labelControl2";
			this.labelControl2.Size = new System.Drawing.Size(37, 16);
			this.labelControl2.TabIndex = 2;
			this.labelControl2.Text = "Hasta:";
			// 
			// dtpFrom
			// 
			this.dtpFrom.Location = new System.Drawing.Point(63, 22);
			this.dtpFrom.Name = "dtpFrom";
			this.dtpFrom.Size = new System.Drawing.Size(311, 23);
			this.dtpFrom.TabIndex = 1;
			// 
			// labelControl1
			// 
			this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelControl1.Appearance.Options.UseFont = true;
			this.labelControl1.Location = new System.Drawing.Point(11, 27);
			this.labelControl1.Name = "labelControl1";
			this.labelControl1.Size = new System.Drawing.Size(40, 16);
			this.labelControl1.TabIndex = 0;
			this.labelControl1.Text = "Desde:";
			// 
			// gbMembers
			// 
			this.gbMembers.Controls.Add(this.labelControl4);
			this.gbMembers.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gbMembers.Location = new System.Drawing.Point(245, 12);
			this.gbMembers.Name = "gbMembers";
			this.gbMembers.Size = new System.Drawing.Size(405, 341);
			this.gbMembers.TabIndex = 3;
			this.gbMembers.TabStop = false;
			this.gbMembers.Tag = "Miembros";
			this.gbMembers.Text = "Configuración";
			// 
			// labelControl4
			// 
			this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelControl4.Appearance.Options.UseFont = true;
			this.labelControl4.Location = new System.Drawing.Point(11, 27);
			this.labelControl4.Name = "labelControl4";
			this.labelControl4.Size = new System.Drawing.Size(212, 16);
			this.labelControl4.TabIndex = 0;
			this.labelControl4.Text = "No hay configuraciones para realizar";
			// 
			// lbReports
			// 
			this.lbReports.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbReports.FormattingEnabled = true;
			this.lbReports.ItemHeight = 16;
			this.lbReports.Items.AddRange(new object[] {
            "Miembros",
            "Asistencias",
            "Ventas",
            "Productos",
            "Deudores"});
			this.lbReports.Location = new System.Drawing.Point(12, 12);
			this.lbReports.Name = "lbReports";
			this.lbReports.Size = new System.Drawing.Size(227, 340);
			this.lbReports.TabIndex = 4;
			this.lbReports.SelectedIndexChanged += new System.EventHandler(this.lbReports_SelectedIndexChanged);
			// 
			// gbSales
			// 
			this.gbSales.Controls.Add(this.dtpSalesTo);
			this.gbSales.Controls.Add(this.labelControl6);
			this.gbSales.Controls.Add(this.dtpSalesFrom);
			this.gbSales.Controls.Add(this.labelControl7);
			this.gbSales.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gbSales.Location = new System.Drawing.Point(245, 12);
			this.gbSales.Name = "gbSales";
			this.gbSales.Size = new System.Drawing.Size(405, 341);
			this.gbSales.TabIndex = 5;
			this.gbSales.TabStop = false;
			this.gbSales.Tag = "Ventas";
			this.gbSales.Text = "Configuración";
			// 
			// dtpSalesTo
			// 
			this.dtpSalesTo.Location = new System.Drawing.Point(63, 51);
			this.dtpSalesTo.Name = "dtpSalesTo";
			this.dtpSalesTo.Size = new System.Drawing.Size(311, 23);
			this.dtpSalesTo.TabIndex = 3;
			// 
			// labelControl6
			// 
			this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelControl6.Appearance.Options.UseFont = true;
			this.labelControl6.Location = new System.Drawing.Point(11, 56);
			this.labelControl6.Name = "labelControl6";
			this.labelControl6.Size = new System.Drawing.Size(37, 16);
			this.labelControl6.TabIndex = 2;
			this.labelControl6.Text = "Hasta:";
			// 
			// dtpSalesFrom
			// 
			this.dtpSalesFrom.Location = new System.Drawing.Point(63, 22);
			this.dtpSalesFrom.Name = "dtpSalesFrom";
			this.dtpSalesFrom.Size = new System.Drawing.Size(311, 23);
			this.dtpSalesFrom.TabIndex = 1;
			// 
			// labelControl7
			// 
			this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelControl7.Appearance.Options.UseFont = true;
			this.labelControl7.Location = new System.Drawing.Point(11, 27);
			this.labelControl7.Name = "labelControl7";
			this.labelControl7.Size = new System.Drawing.Size(40, 16);
			this.labelControl7.TabIndex = 0;
			this.labelControl7.Text = "Desde:";
			// 
			// gbProducts
			// 
			this.gbProducts.Controls.Add(this.labelControl5);
			this.gbProducts.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gbProducts.Location = new System.Drawing.Point(245, 12);
			this.gbProducts.Name = "gbProducts";
			this.gbProducts.Size = new System.Drawing.Size(405, 341);
			this.gbProducts.TabIndex = 6;
			this.gbProducts.TabStop = false;
			this.gbProducts.Tag = "Productos";
			this.gbProducts.Text = "Configuración";
			// 
			// labelControl5
			// 
			this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelControl5.Appearance.Options.UseFont = true;
			this.labelControl5.Location = new System.Drawing.Point(11, 27);
			this.labelControl5.Name = "labelControl5";
			this.labelControl5.Size = new System.Drawing.Size(212, 16);
			this.labelControl5.TabIndex = 0;
			this.labelControl5.Text = "No hay configuraciones para realizar";
			// 
			// gbRedOnes
			// 
			this.gbRedOnes.Controls.Add(this.labelControl8);
			this.gbRedOnes.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gbRedOnes.Location = new System.Drawing.Point(245, 12);
			this.gbRedOnes.Name = "gbRedOnes";
			this.gbRedOnes.Size = new System.Drawing.Size(405, 341);
			this.gbRedOnes.TabIndex = 7;
			this.gbRedOnes.TabStop = false;
			this.gbRedOnes.Tag = "Deudores";
			this.gbRedOnes.Text = "Configuración";
			// 
			// labelControl8
			// 
			this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelControl8.Appearance.Options.UseFont = true;
			this.labelControl8.Location = new System.Drawing.Point(11, 27);
			this.labelControl8.Name = "labelControl8";
			this.labelControl8.Size = new System.Drawing.Size(212, 16);
			this.labelControl8.TabIndex = 0;
			this.labelControl8.Text = "No hay configuraciones para realizar";
			// 
			// ReportConfigurationView
			// 
			this.AcceptButton = this.btnOK;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(662, 393);
			this.Controls.Add(this.gbRedOnes);
			this.Controls.Add(this.lbReports);
			this.Controls.Add(this.btnOK);
			this.Controls.Add(this.gbMembers);
			this.Controls.Add(this.gbSales);
			this.Controls.Add(this.gbCheckins);
			this.Controls.Add(this.gbProducts);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "ReportConfigurationView";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Configuración de Reportes";
			this.Load += new System.EventHandler(this.ReportConfigurationView_Load);
			((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
			this.gbCheckins.ResumeLayout(false);
			this.gbCheckins.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.clbTrainings)).EndInit();
			this.gbMembers.ResumeLayout(false);
			this.gbMembers.PerformLayout();
			this.gbSales.ResumeLayout(false);
			this.gbSales.PerformLayout();
			this.gbProducts.ResumeLayout(false);
			this.gbProducts.PerformLayout();
			this.gbRedOnes.ResumeLayout(false);
			this.gbRedOnes.PerformLayout();
			this.ResumeLayout(false);

      }

      #endregion

      private DevExpress.XtraEditors.SimpleButton btnOK;
      private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel;
      private System.Windows.Forms.ErrorProvider errorProvider;
      private System.Windows.Forms.GroupBox gbCheckins;
      private System.Windows.Forms.DateTimePicker dtpTo;
      private DevExpress.XtraEditors.LabelControl labelControl2;
      private System.Windows.Forms.DateTimePicker dtpFrom;
      private DevExpress.XtraEditors.LabelControl labelControl1;
      private System.Windows.Forms.GroupBox gbMembers;
      private DevExpress.XtraEditors.LabelControl labelControl4;
      private System.Windows.Forms.ListBox lbReports;
      private DevExpress.XtraEditors.LabelControl labelControl3;
      private DevExpress.XtraEditors.CheckedListBoxControl clbTrainings;
      private System.Windows.Forms.GroupBox gbSales;
      private System.Windows.Forms.DateTimePicker dtpSalesTo;
      private DevExpress.XtraEditors.LabelControl labelControl6;
      private System.Windows.Forms.DateTimePicker dtpSalesFrom;
      private DevExpress.XtraEditors.LabelControl labelControl7;
      private System.Windows.Forms.GroupBox gbProducts;
      private DevExpress.XtraEditors.LabelControl labelControl5;
      private System.Windows.Forms.GroupBox gbRedOnes;
      private DevExpress.XtraEditors.LabelControl labelControl8;
   }
}