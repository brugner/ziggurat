namespace Corlib.Views.Reports
{
   partial class CheckinsReport
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

      #region Designer generated code

      /// <summary>
      /// Required method for Designer support - do not modify
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
         this.components = new System.ComponentModel.Container();
         DevExpress.DataAccess.Sql.CustomSqlQuery customSqlQuery1 = new DevExpress.DataAccess.Sql.CustomSqlQuery();
         DevExpress.DataAccess.Sql.QueryParameter queryParameter1 = new DevExpress.DataAccess.Sql.QueryParameter();
         DevExpress.DataAccess.Sql.QueryParameter queryParameter2 = new DevExpress.DataAccess.Sql.QueryParameter();
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CheckinsReport));
         DevExpress.DataAccess.Sql.CustomSqlQuery customSqlQuery2 = new DevExpress.DataAccess.Sql.CustomSqlQuery();
         this.Detail = new DevExpress.XtraReports.UI.DetailBand();
         this.xrTable2 = new DevExpress.XtraReports.UI.XRTable();
         this.xrTableRow4 = new DevExpress.XtraReports.UI.XRTableRow();
         this.xrTableCell10 = new DevExpress.XtraReports.UI.XRTableCell();
         this.xrTableCell11 = new DevExpress.XtraReports.UI.XRTableCell();
         this.xrTableCell12 = new DevExpress.XtraReports.UI.XRTableCell();
         this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
         this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
         this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
         this.xrPageInfo1 = new DevExpress.XtraReports.UI.XRPageInfo();
         this.xrPageInfo2 = new DevExpress.XtraReports.UI.XRPageInfo();
         this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
         this.reportHeaderBand1 = new DevExpress.XtraReports.UI.ReportHeaderBand();
         this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
         this.ReportTitle = new DevExpress.XtraReports.Parameters.Parameter();
         this.groupHeaderBand1 = new DevExpress.XtraReports.UI.GroupHeaderBand();
         this.xrTable1 = new DevExpress.XtraReports.UI.XRTable();
         this.xrTableRow2 = new DevExpress.XtraReports.UI.XRTableRow();
         this.xrTableCell4 = new DevExpress.XtraReports.UI.XRTableCell();
         this.xrTableCell5 = new DevExpress.XtraReports.UI.XRTableCell();
         this.xrTableCell6 = new DevExpress.XtraReports.UI.XRTableCell();
         this.xrTableRow1 = new DevExpress.XtraReports.UI.XRTableRow();
         this.xrTableCell1 = new DevExpress.XtraReports.UI.XRTableCell();
         this.xrTableCell2 = new DevExpress.XtraReports.UI.XRTableCell();
         this.xrTableCell3 = new DevExpress.XtraReports.UI.XRTableCell();
         this.xrTableRow3 = new DevExpress.XtraReports.UI.XRTableRow();
         this.xrTableCell7 = new DevExpress.XtraReports.UI.XRTableCell();
         this.xrTableCell8 = new DevExpress.XtraReports.UI.XRTableCell();
         this.xrTableCell9 = new DevExpress.XtraReports.UI.XRTableCell();
         this.Title = new DevExpress.XtraReports.UI.XRControlStyle();
         this.DetailCaption3 = new DevExpress.XtraReports.UI.XRControlStyle();
         this.DetailData3 = new DevExpress.XtraReports.UI.XRControlStyle();
         this.DetailData3_Odd = new DevExpress.XtraReports.UI.XRControlStyle();
         this.DetailCaptionBackground3 = new DevExpress.XtraReports.UI.XRControlStyle();
         this.PageInfo = new DevExpress.XtraReports.UI.XRControlStyle();
         this.From = new DevExpress.XtraReports.Parameters.Parameter();
         this.To = new DevExpress.XtraReports.Parameters.Parameter();
         this.TrainingsIds = new DevExpress.XtraReports.Parameters.Parameter();
         ((System.ComponentModel.ISupportInitialize)(this.xrTable2)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).BeginInit();
         ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
         // 
         // Detail
         // 
         this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable2});
         this.Detail.HeightF = 25F;
         this.Detail.Name = "Detail";
         this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
         this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
         // 
         // xrTable2
         // 
         this.xrTable2.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
         this.xrTable2.Name = "xrTable2";
         this.xrTable2.OddStyleName = "DetailData3_Odd";
         this.xrTable2.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow4});
         this.xrTable2.SizeF = new System.Drawing.SizeF(650F, 25F);
         // 
         // xrTableRow4
         // 
         this.xrTableRow4.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell10,
            this.xrTableCell11,
            this.xrTableCell12});
         this.xrTableRow4.Name = "xrTableRow4";
         this.xrTableRow4.Weight = 11.5D;
         // 
         // xrTableCell10
         // 
         this.xrTableCell10.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "MainData.Member")});
         this.xrTableCell10.Font = new System.Drawing.Font("Tahoma", 10F);
         this.xrTableCell10.Name = "xrTableCell10";
         this.xrTableCell10.StyleName = "DetailData3";
         this.xrTableCell10.StylePriority.UseFont = false;
         this.xrTableCell10.Weight = 0.2857142857142857D;
         // 
         // xrTableCell11
         // 
         this.xrTableCell11.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "MainData.Training")});
         this.xrTableCell11.Font = new System.Drawing.Font("Tahoma", 10F);
         this.xrTableCell11.Name = "xrTableCell11";
         this.xrTableCell11.StyleName = "DetailData3";
         this.xrTableCell11.StylePriority.UseFont = false;
         this.xrTableCell11.Weight = 0.2857142857142857D;
         // 
         // xrTableCell12
         // 
         this.xrTableCell12.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "MainData.Date")});
         this.xrTableCell12.Font = new System.Drawing.Font("Tahoma", 10F);
         this.xrTableCell12.Name = "xrTableCell12";
         this.xrTableCell12.StyleName = "DetailData3";
         this.xrTableCell12.StylePriority.UseFont = false;
         this.xrTableCell12.Weight = 0.2857142857142857D;
         // 
         // TopMargin
         // 
         this.TopMargin.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel2});
         this.TopMargin.HeightF = 60F;
         this.TopMargin.Name = "TopMargin";
         this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
         this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
         // 
         // xrLabel2
         // 
         this.xrLabel2.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Parameters.GymName")});
         this.xrLabel2.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
         this.xrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(10F, 10F);
         this.xrLabel2.Name = "xrLabel2";
         this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel2.SizeF = new System.Drawing.SizeF(633.9999F, 35.20832F);
         this.xrLabel2.StylePriority.UseFont = false;
         this.xrLabel2.StylePriority.UseTextAlignment = false;
         this.xrLabel2.Text = "xrLabel2";
         this.xrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
         // 
         // BottomMargin
         // 
         this.BottomMargin.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrPageInfo1,
            this.xrPageInfo2});
         this.BottomMargin.HeightF = 100F;
         this.BottomMargin.Name = "BottomMargin";
         this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
         this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
         // 
         // xrPageInfo1
         // 
         this.xrPageInfo1.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
         this.xrPageInfo1.LocationFloat = new DevExpress.Utils.PointFloat(6F, 6F);
         this.xrPageInfo1.Name = "xrPageInfo1";
         this.xrPageInfo1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrPageInfo1.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime;
         this.xrPageInfo1.SizeF = new System.Drawing.SizeF(313F, 23F);
         this.xrPageInfo1.StyleName = "PageInfo";
         this.xrPageInfo1.StylePriority.UseFont = false;
         // 
         // xrPageInfo2
         // 
         this.xrPageInfo2.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
         this.xrPageInfo2.Format = "{0}/{1}";
         this.xrPageInfo2.LocationFloat = new DevExpress.Utils.PointFloat(331F, 6F);
         this.xrPageInfo2.Name = "xrPageInfo2";
         this.xrPageInfo2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrPageInfo2.SizeF = new System.Drawing.SizeF(313F, 23F);
         this.xrPageInfo2.StyleName = "PageInfo";
         this.xrPageInfo2.StylePriority.UseFont = false;
         this.xrPageInfo2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
         // 
         // sqlDataSource1
         // 
         this.sqlDataSource1.ConnectionName = "Ziggurat";
         this.sqlDataSource1.Name = "sqlDataSource1";
         customSqlQuery1.Name = "MainData";
         queryParameter1.Name = "From";
         queryParameter1.Type = typeof(DevExpress.DataAccess.Expression);
         queryParameter1.Value = new DevExpress.DataAccess.Expression("[Parameters.From]", typeof(System.DateTime));
         queryParameter2.Name = "To";
         queryParameter2.Type = typeof(DevExpress.DataAccess.Expression);
         queryParameter2.Value = new DevExpress.DataAccess.Expression("[Parameters.To]", typeof(System.DateTime));
         customSqlQuery1.Parameters.Add(queryParameter1);
         customSqlQuery1.Parameters.Add(queryParameter2);
         customSqlQuery1.Sql = resources.GetString("customSqlQuery1.Sql");
         customSqlQuery2.Name = "Parameters";
         customSqlQuery2.Sql = "SELECT TOP 1 * FROM Parameters";
         this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            customSqlQuery1,
            customSqlQuery2});
         this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
         // 
         // reportHeaderBand1
         // 
         this.reportHeaderBand1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel1});
         this.reportHeaderBand1.HeightF = 60F;
         this.reportHeaderBand1.Name = "reportHeaderBand1";
         // 
         // xrLabel1
         // 
         this.xrLabel1.BackColor = System.Drawing.Color.Transparent;
         this.xrLabel1.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding(this.ReportTitle, "Text", "")});
         this.xrLabel1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
         this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(6F, 6F);
         this.xrLabel1.Name = "xrLabel1";
         this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel1.SizeF = new System.Drawing.SizeF(638F, 26F);
         this.xrLabel1.StyleName = "Title";
         this.xrLabel1.StylePriority.UseBackColor = false;
         this.xrLabel1.StylePriority.UseFont = false;
         this.xrLabel1.StylePriority.UseTextAlignment = false;
         this.xrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
         // 
         // ReportTitle
         // 
         this.ReportTitle.Description = "The title of the report";
         this.ReportTitle.Name = "ReportTitle";
         this.ReportTitle.ValueInfo = "Asistencias";
         this.ReportTitle.Visible = false;
         // 
         // groupHeaderBand1
         // 
         this.groupHeaderBand1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable1});
         this.groupHeaderBand1.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail;
         this.groupHeaderBand1.HeightF = 28F;
         this.groupHeaderBand1.Name = "groupHeaderBand1";
         // 
         // xrTable1
         // 
         this.xrTable1.BackColor = System.Drawing.Color.Silver;
         this.xrTable1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
         this.xrTable1.Name = "xrTable1";
         this.xrTable1.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow2});
         this.xrTable1.SizeF = new System.Drawing.SizeF(650F, 28F);
         // 
         // xrTableRow2
         // 
         this.xrTableRow2.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell4,
            this.xrTableCell5,
            this.xrTableCell6});
         this.xrTableRow2.Name = "xrTableRow2";
         this.xrTableRow2.Weight = 4.6D;
         // 
         // xrTableCell4
         // 
         this.xrTableCell4.BackColor = System.Drawing.Color.Silver;
         this.xrTableCell4.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
         this.xrTableCell4.Name = "xrTableCell4";
         this.xrTableCell4.StyleName = "DetailCaption3";
         this.xrTableCell4.StylePriority.UseBackColor = false;
         this.xrTableCell4.StylePriority.UseFont = false;
         this.xrTableCell4.Text = "Miembro";
         this.xrTableCell4.Weight = 0.2857142857142857D;
         // 
         // xrTableCell5
         // 
         this.xrTableCell5.BackColor = System.Drawing.Color.Silver;
         this.xrTableCell5.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
         this.xrTableCell5.Name = "xrTableCell5";
         this.xrTableCell5.StyleName = "DetailCaption3";
         this.xrTableCell5.StylePriority.UseBackColor = false;
         this.xrTableCell5.StylePriority.UseFont = false;
         this.xrTableCell5.Text = "Actividad";
         this.xrTableCell5.Weight = 0.2857142857142857D;
         // 
         // xrTableCell6
         // 
         this.xrTableCell6.BackColor = System.Drawing.Color.Silver;
         this.xrTableCell6.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
         this.xrTableCell6.Name = "xrTableCell6";
         this.xrTableCell6.StyleName = "DetailCaption3";
         this.xrTableCell6.StylePriority.UseBackColor = false;
         this.xrTableCell6.StylePriority.UseFont = false;
         this.xrTableCell6.Text = "Fecha";
         this.xrTableCell6.Weight = 0.2857142857142857D;
         // 
         // xrTableRow1
         // 
         this.xrTableRow1.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell1,
            this.xrTableCell2,
            this.xrTableCell3});
         this.xrTableRow1.Name = "xrTableRow1";
         this.xrTableRow1.Weight = 1D;
         // 
         // xrTableCell1
         // 
         this.xrTableCell1.Name = "xrTableCell1";
         this.xrTableCell1.Text = "xrTableCell1";
         this.xrTableCell1.Weight = 1D;
         // 
         // xrTableCell2
         // 
         this.xrTableCell2.Name = "xrTableCell2";
         this.xrTableCell2.Text = "xrTableCell2";
         this.xrTableCell2.Weight = 1D;
         // 
         // xrTableCell3
         // 
         this.xrTableCell3.Name = "xrTableCell3";
         this.xrTableCell3.Text = "xrTableCell3";
         this.xrTableCell3.Weight = 1D;
         // 
         // xrTableRow3
         // 
         this.xrTableRow3.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell7,
            this.xrTableCell8,
            this.xrTableCell9});
         this.xrTableRow3.Name = "xrTableRow3";
         this.xrTableRow3.Weight = 1D;
         // 
         // xrTableCell7
         // 
         this.xrTableCell7.Name = "xrTableCell7";
         this.xrTableCell7.Text = "xrTableCell7";
         this.xrTableCell7.Weight = 1D;
         // 
         // xrTableCell8
         // 
         this.xrTableCell8.Name = "xrTableCell8";
         this.xrTableCell8.Text = "xrTableCell8";
         this.xrTableCell8.Weight = 1D;
         // 
         // xrTableCell9
         // 
         this.xrTableCell9.Name = "xrTableCell9";
         this.xrTableCell9.Text = "xrTableCell9";
         this.xrTableCell9.Weight = 1D;
         // 
         // Title
         // 
         this.Title.BackColor = System.Drawing.Color.Transparent;
         this.Title.BorderColor = System.Drawing.Color.Black;
         this.Title.Borders = DevExpress.XtraPrinting.BorderSide.None;
         this.Title.BorderWidth = 1F;
         this.Title.Font = new System.Drawing.Font("Tahoma", 14F);
         this.Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
         this.Title.Name = "Title";
         // 
         // DetailCaption3
         // 
         this.DetailCaption3.BackColor = System.Drawing.Color.Transparent;
         this.DetailCaption3.BorderColor = System.Drawing.Color.Transparent;
         this.DetailCaption3.Borders = DevExpress.XtraPrinting.BorderSide.None;
         this.DetailCaption3.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
         this.DetailCaption3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
         this.DetailCaption3.Name = "DetailCaption3";
         this.DetailCaption3.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100F);
         this.DetailCaption3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
         // 
         // DetailData3
         // 
         this.DetailData3.Font = new System.Drawing.Font("Tahoma", 8F);
         this.DetailData3.ForeColor = System.Drawing.Color.Black;
         this.DetailData3.Name = "DetailData3";
         this.DetailData3.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100F);
         this.DetailData3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
         // 
         // DetailData3_Odd
         // 
         this.DetailData3_Odd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(231)))), ((int)(((byte)(231)))));
         this.DetailData3_Odd.BorderColor = System.Drawing.Color.Transparent;
         this.DetailData3_Odd.Borders = DevExpress.XtraPrinting.BorderSide.None;
         this.DetailData3_Odd.BorderWidth = 1F;
         this.DetailData3_Odd.Font = new System.Drawing.Font("Tahoma", 8F);
         this.DetailData3_Odd.ForeColor = System.Drawing.Color.Black;
         this.DetailData3_Odd.Name = "DetailData3_Odd";
         this.DetailData3_Odd.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100F);
         this.DetailData3_Odd.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
         // 
         // DetailCaptionBackground3
         // 
         this.DetailCaptionBackground3.BackColor = System.Drawing.Color.Transparent;
         this.DetailCaptionBackground3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(206)))), ((int)(((byte)(206)))));
         this.DetailCaptionBackground3.Borders = DevExpress.XtraPrinting.BorderSide.Top;
         this.DetailCaptionBackground3.BorderWidth = 2F;
         this.DetailCaptionBackground3.Name = "DetailCaptionBackground3";
         // 
         // PageInfo
         // 
         this.PageInfo.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
         this.PageInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
         this.PageInfo.Name = "PageInfo";
         this.PageInfo.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         // 
         // From
         // 
         this.From.Description = "Desde";
         this.From.Name = "From";
         this.From.Type = typeof(System.DateTime);
         this.From.ValueInfo = "2001-01-01";
         this.From.Visible = false;
         // 
         // To
         // 
         this.To.Description = "To this date";
         this.To.Name = "To";
         this.To.Type = typeof(System.DateTime);
         this.To.ValueInfo = "2000-01-01";
         this.To.Visible = false;
         // 
         // TrainingsIds
         // 
         this.TrainingsIds.Description = "Trainings included in the query";
         this.TrainingsIds.MultiValue = true;
         this.TrainingsIds.Name = "TrainingsIds";
         this.TrainingsIds.Type = typeof(int);
         this.TrainingsIds.ValueInfo = "0";
         this.TrainingsIds.Visible = false;
         // 
         // CheckinsReport
         // 
         this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.reportHeaderBand1,
            this.groupHeaderBand1});
         this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.sqlDataSource1});
         this.DataMember = "MainData";
         this.DataSource = this.sqlDataSource1;
         this.Margins = new System.Drawing.Printing.Margins(100, 100, 60, 100);
         this.Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {
            this.From,
            this.ReportTitle,
            this.To,
            this.TrainingsIds});
         this.StyleSheet.AddRange(new DevExpress.XtraReports.UI.XRControlStyle[] {
            this.Title,
            this.DetailCaption3,
            this.DetailData3,
            this.DetailData3_Odd,
            this.DetailCaptionBackground3,
            this.PageInfo});
         this.Version = "17.1";
         this.DataSourceDemanded += new System.EventHandler<System.EventArgs>(this.CheckinsReport_DataSourceDemanded);
         ((System.ComponentModel.ISupportInitialize)(this.xrTable2)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).EndInit();
         ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

      }

      #endregion

      private DevExpress.XtraReports.UI.DetailBand Detail;
      private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
      private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
      private DevExpress.XtraReports.UI.XRTable xrTable2;
      private DevExpress.XtraReports.UI.XRTableRow xrTableRow4;
      private DevExpress.XtraReports.UI.XRTableCell xrTableCell10;
      private DevExpress.XtraReports.UI.XRTableCell xrTableCell11;
      private DevExpress.XtraReports.UI.XRTableCell xrTableCell12;
      private DevExpress.XtraReports.UI.XRPageInfo xrPageInfo1;
      private DevExpress.XtraReports.UI.XRPageInfo xrPageInfo2;
      private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
      private DevExpress.XtraReports.UI.ReportHeaderBand reportHeaderBand1;
      private DevExpress.XtraReports.UI.XRLabel xrLabel1;
      private DevExpress.XtraReports.UI.GroupHeaderBand groupHeaderBand1;
      private DevExpress.XtraReports.UI.XRTable xrTable1;
      private DevExpress.XtraReports.UI.XRTableRow xrTableRow2;
      private DevExpress.XtraReports.UI.XRTableCell xrTableCell4;
      private DevExpress.XtraReports.UI.XRTableCell xrTableCell5;
      private DevExpress.XtraReports.UI.XRTableCell xrTableCell6;
      private DevExpress.XtraReports.UI.XRTableRow xrTableRow1;
      private DevExpress.XtraReports.UI.XRTableCell xrTableCell1;
      private DevExpress.XtraReports.UI.XRTableCell xrTableCell2;
      private DevExpress.XtraReports.UI.XRTableCell xrTableCell3;
      private DevExpress.XtraReports.UI.XRTableRow xrTableRow3;
      private DevExpress.XtraReports.UI.XRTableCell xrTableCell7;
      private DevExpress.XtraReports.UI.XRTableCell xrTableCell8;
      private DevExpress.XtraReports.UI.XRTableCell xrTableCell9;
      private DevExpress.XtraReports.UI.XRControlStyle Title;
      private DevExpress.XtraReports.UI.XRControlStyle DetailCaption3;
      private DevExpress.XtraReports.UI.XRControlStyle DetailData3;
      private DevExpress.XtraReports.UI.XRControlStyle DetailData3_Odd;
      private DevExpress.XtraReports.UI.XRControlStyle DetailCaptionBackground3;
      private DevExpress.XtraReports.UI.XRControlStyle PageInfo;
      private DevExpress.XtraReports.Parameters.Parameter From;
      private DevExpress.XtraReports.UI.XRLabel xrLabel2;
      private DevExpress.XtraReports.Parameters.Parameter ReportTitle;
      private DevExpress.XtraReports.Parameters.Parameter To;
      private DevExpress.XtraReports.Parameters.Parameter TrainingsIds;
   }
}
