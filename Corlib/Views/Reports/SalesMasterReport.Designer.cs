namespace Corlib.Views.Reports
{
   partial class SalesMasterReport
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
			DevExpress.DataAccess.Sql.CustomSqlQuery customSqlQuery1 = new DevExpress.DataAccess.Sql.CustomSqlQuery();
			DevExpress.DataAccess.Sql.QueryParameter queryParameter1 = new DevExpress.DataAccess.Sql.QueryParameter();
			DevExpress.DataAccess.Sql.QueryParameter queryParameter2 = new DevExpress.DataAccess.Sql.QueryParameter();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalesMasterReport));
			DevExpress.DataAccess.Sql.SelectQuery selectQuery1 = new DevExpress.DataAccess.Sql.SelectQuery();
			DevExpress.DataAccess.Sql.Column column1 = new DevExpress.DataAccess.Sql.Column();
			DevExpress.DataAccess.Sql.ColumnExpression columnExpression1 = new DevExpress.DataAccess.Sql.ColumnExpression();
			DevExpress.DataAccess.Sql.Table table1 = new DevExpress.DataAccess.Sql.Table();
			this.Detail = new DevExpress.XtraReports.UI.DetailBand();
			this.xrLabel9 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel8 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel7 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel6 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel5 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel4 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrSubreport1 = new DevExpress.XtraReports.UI.XRSubreport();
			this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
			this.xrLabel10 = new DevExpress.XtraReports.UI.XRLabel();
			this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
			this.xrPageInfo1 = new DevExpress.XtraReports.UI.XRPageInfo();
			this.xrPageInfo2 = new DevExpress.XtraReports.UI.XRPageInfo();
			this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource();
			this.reportHeaderBand1 = new DevExpress.XtraReports.UI.ReportHeaderBand();
			this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
			this.ReportTitle = new DevExpress.XtraReports.Parameters.Parameter();
			this.xrTableRow1 = new DevExpress.XtraReports.UI.XRTableRow();
			this.xrTableCell1 = new DevExpress.XtraReports.UI.XRTableCell();
			this.xrTableCell2 = new DevExpress.XtraReports.UI.XRTableCell();
			this.xrTableCell3 = new DevExpress.XtraReports.UI.XRTableCell();
			this.xrTableRow3 = new DevExpress.XtraReports.UI.XRTableRow();
			this.xrTableCell8 = new DevExpress.XtraReports.UI.XRTableCell();
			this.xrTableCell9 = new DevExpress.XtraReports.UI.XRTableCell();
			this.xrTableCell10 = new DevExpress.XtraReports.UI.XRTableCell();
			this.Title = new DevExpress.XtraReports.UI.XRControlStyle();
			this.DetailCaption3 = new DevExpress.XtraReports.UI.XRControlStyle();
			this.DetailData3 = new DevExpress.XtraReports.UI.XRControlStyle();
			this.DetailData3_Odd = new DevExpress.XtraReports.UI.XRControlStyle();
			this.DetailCaptionBackground3 = new DevExpress.XtraReports.UI.XRControlStyle();
			this.PageInfo = new DevExpress.XtraReports.UI.XRControlStyle();
			this.cfIsFullyPaid = new DevExpress.XtraReports.UI.CalculatedField();
			this.From = new DevExpress.XtraReports.Parameters.Parameter();
			this.To = new DevExpress.XtraReports.Parameters.Parameter();
			((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
			// 
			// Detail
			// 
			this.Detail.Borders = DevExpress.XtraPrinting.BorderSide.None;
			this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel9,
            this.xrLabel8,
            this.xrLabel7,
            this.xrLabel3,
            this.xrLabel6,
            this.xrLabel5,
            this.xrLabel4,
            this.xrLabel2,
            this.xrSubreport1});
			this.Detail.HeightF = 136.25F;
			this.Detail.KeepTogether = true;
			this.Detail.Name = "Detail";
			this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
			this.Detail.StylePriority.UseBorders = false;
			this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			// 
			// xrLabel9
			// 
			this.xrLabel9.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Sales.cfIsFullyPaid")});
			this.xrLabel9.Font = new System.Drawing.Font("Tahoma", 10F);
			this.xrLabel9.LocationFloat = new DevExpress.Utils.PointFloat(484.7917F, 28.99999F);
			this.xrLabel9.Name = "xrLabel9";
			this.xrLabel9.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel9.SizeF = new System.Drawing.SizeF(100F, 23F);
			this.xrLabel9.StylePriority.UseFont = false;
			this.xrLabel9.StylePriority.UseTextAlignment = false;
			this.xrLabel9.Text = "xrLabel9";
			this.xrLabel9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			// 
			// xrLabel8
			// 
			this.xrLabel8.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Sales.Date", "{0:dd/MM/yyyy \'a las\' hh:mm}")});
			this.xrLabel8.Font = new System.Drawing.Font("Tahoma", 10F);
			this.xrLabel8.LocationFloat = new DevExpress.Utils.PointFloat(484.7917F, 6.000008F);
			this.xrLabel8.Name = "xrLabel8";
			this.xrLabel8.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel8.SizeF = new System.Drawing.SizeF(155F, 23F);
			this.xrLabel8.StylePriority.UseFont = false;
			this.xrLabel8.StylePriority.UseTextAlignment = false;
			this.xrLabel8.Text = "xrLabel8";
			this.xrLabel8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			// 
			// xrLabel7
			// 
			this.xrLabel7.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Sales.Member")});
			this.xrLabel7.Font = new System.Drawing.Font("Tahoma", 10F);
			this.xrLabel7.LocationFloat = new DevExpress.Utils.PointFloat(78.91668F, 28.99999F);
			this.xrLabel7.Name = "xrLabel7";
			this.xrLabel7.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel7.SizeF = new System.Drawing.SizeF(213F, 23F);
			this.xrLabel7.StylePriority.UseFont = false;
			this.xrLabel7.StylePriority.UseTextAlignment = false;
			this.xrLabel7.Text = "xrLabel7";
			this.xrLabel7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			// 
			// xrLabel3
			// 
			this.xrLabel3.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Sales.Number")});
			this.xrLabel3.Font = new System.Drawing.Font("Tahoma", 10F);
			this.xrLabel3.LocationFloat = new DevExpress.Utils.PointFloat(78.91668F, 6.000008F);
			this.xrLabel3.Name = "xrLabel3";
			this.xrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel3.SizeF = new System.Drawing.SizeF(100F, 23F);
			this.xrLabel3.StylePriority.UseFont = false;
			this.xrLabel3.StylePriority.UseTextAlignment = false;
			this.xrLabel3.Text = "xrLabel3";
			this.xrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			// 
			// xrLabel6
			// 
			this.xrLabel6.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
			this.xrLabel6.LocationFloat = new DevExpress.Utils.PointFloat(429.5834F, 28.99999F);
			this.xrLabel6.Name = "xrLabel6";
			this.xrLabel6.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel6.SizeF = new System.Drawing.SizeF(55.20831F, 23F);
			this.xrLabel6.StylePriority.UseFont = false;
			this.xrLabel6.StylePriority.UseTextAlignment = false;
			this.xrLabel6.Text = "Paga:";
			this.xrLabel6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			// 
			// xrLabel5
			// 
			this.xrLabel5.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
			this.xrLabel5.LocationFloat = new DevExpress.Utils.PointFloat(429.5834F, 6.000008F);
			this.xrLabel5.Name = "xrLabel5";
			this.xrLabel5.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel5.SizeF = new System.Drawing.SizeF(55.20831F, 23F);
			this.xrLabel5.StylePriority.UseFont = false;
			this.xrLabel5.StylePriority.UseTextAlignment = false;
			this.xrLabel5.Text = "Fecha:";
			this.xrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			// 
			// xrLabel4
			// 
			this.xrLabel4.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
			this.xrLabel4.LocationFloat = new DevExpress.Utils.PointFloat(6.00001F, 28.99999F);
			this.xrLabel4.Name = "xrLabel4";
			this.xrLabel4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel4.SizeF = new System.Drawing.SizeF(72.91667F, 23F);
			this.xrLabel4.StylePriority.UseFont = false;
			this.xrLabel4.StylePriority.UseTextAlignment = false;
			this.xrLabel4.Text = "Miembro:";
			this.xrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			// 
			// xrLabel2
			// 
			this.xrLabel2.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
			this.xrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(6.00001F, 6.000008F);
			this.xrLabel2.Name = "xrLabel2";
			this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel2.SizeF = new System.Drawing.SizeF(72.91667F, 23F);
			this.xrLabel2.StylePriority.UseFont = false;
			this.xrLabel2.StylePriority.UseTextAlignment = false;
			this.xrLabel2.Text = "Número:";
			this.xrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
			// 
			// xrSubreport1
			// 
			this.xrSubreport1.LocationFloat = new DevExpress.Utils.PointFloat(6.00001F, 57F);
			this.xrSubreport1.Name = "xrSubreport1";
			this.xrSubreport1.ParameterBindings.Add(new DevExpress.XtraReports.UI.ParameterBinding("SaleId", null, "Sales.Id"));
			this.xrSubreport1.ReportSource = new Corlib.Views.Reports.SalesDetailReport();
			this.xrSubreport1.SizeF = new System.Drawing.SizeF(633.9999F, 53.37506F);
			// 
			// TopMargin
			// 
			this.TopMargin.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel10});
			this.TopMargin.HeightF = 60F;
			this.TopMargin.Name = "TopMargin";
			this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
			this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
			// 
			// xrLabel10
			// 
			this.xrLabel10.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Parameters.GymName")});
			this.xrLabel10.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
			this.xrLabel10.LocationFloat = new DevExpress.Utils.PointFloat(10.00001F, 10.00001F);
			this.xrLabel10.Name = "xrLabel10";
			this.xrLabel10.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel10.SizeF = new System.Drawing.SizeF(629.9999F, 23F);
			this.xrLabel10.StylePriority.UseFont = false;
			this.xrLabel10.StylePriority.UseTextAlignment = false;
			this.xrLabel10.Text = "xrLabel10";
			this.xrLabel10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
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
			this.xrPageInfo1.LocationFloat = new DevExpress.Utils.PointFloat(6F, 6F);
			this.xrPageInfo1.Name = "xrPageInfo1";
			this.xrPageInfo1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrPageInfo1.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime;
			this.xrPageInfo1.SizeF = new System.Drawing.SizeF(313F, 23F);
			this.xrPageInfo1.StyleName = "PageInfo";
			// 
			// xrPageInfo2
			// 
			this.xrPageInfo2.Format = "{0}/{1}";
			this.xrPageInfo2.LocationFloat = new DevExpress.Utils.PointFloat(331F, 6F);
			this.xrPageInfo2.Name = "xrPageInfo2";
			this.xrPageInfo2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrPageInfo2.SizeF = new System.Drawing.SizeF(313F, 23F);
			this.xrPageInfo2.StyleName = "PageInfo";
			this.xrPageInfo2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
			// 
			// sqlDataSource1
			// 
			this.sqlDataSource1.ConnectionName = "Ziggurat";
			this.sqlDataSource1.Name = "sqlDataSource1";
			customSqlQuery1.Name = "Sales";
			queryParameter1.Name = "From";
			queryParameter1.Type = typeof(DevExpress.DataAccess.Expression);
			queryParameter1.Value = new DevExpress.DataAccess.Expression("[Parameters.From]", typeof(System.DateTime));
			queryParameter2.Name = "To";
			queryParameter2.Type = typeof(DevExpress.DataAccess.Expression);
			queryParameter2.Value = new DevExpress.DataAccess.Expression("[Parameters.To]", typeof(System.DateTime));
			customSqlQuery1.Parameters.Add(queryParameter1);
			customSqlQuery1.Parameters.Add(queryParameter2);
			customSqlQuery1.Sql = resources.GetString("customSqlQuery1.Sql");
			columnExpression1.ColumnName = "GymName";
			table1.Name = "Parameters";
			columnExpression1.Table = table1;
			column1.Expression = columnExpression1;
			selectQuery1.Columns.Add(column1);
			selectQuery1.Name = "Parameters";
			selectQuery1.Tables.Add(table1);
			this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            customSqlQuery1,
            selectQuery1});
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
			this.xrLabel1.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding(this.ReportTitle, "Text", "")});
			this.xrLabel1.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
			this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(6F, 6F);
			this.xrLabel1.Name = "xrLabel1";
			this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel1.SizeF = new System.Drawing.SizeF(638F, 26F);
			this.xrLabel1.StyleName = "Title";
			this.xrLabel1.StylePriority.UseFont = false;
			this.xrLabel1.StylePriority.UseTextAlignment = false;
			this.xrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
			// 
			// ReportTitle
			// 
			this.ReportTitle.Description = "The title of the report";
			this.ReportTitle.Name = "ReportTitle";
			this.ReportTitle.Visible = false;
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
            this.xrTableCell8,
            this.xrTableCell9,
            this.xrTableCell10});
			this.xrTableRow3.Name = "xrTableRow3";
			this.xrTableRow3.Weight = 1D;
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
			// xrTableCell10
			// 
			this.xrTableCell10.Name = "xrTableCell10";
			this.xrTableCell10.Text = "xrTableCell10";
			this.xrTableCell10.Weight = 1D;
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
			// cfIsFullyPaid
			// 
			this.cfIsFullyPaid.DataMember = "Sales";
			this.cfIsFullyPaid.Expression = "Iif([IsFullyPaid],  \'Sí\', \'No\')";
			this.cfIsFullyPaid.Name = "cfIsFullyPaid";
			// 
			// From
			// 
			this.From.Description = "From date";
			this.From.Name = "From";
			this.From.Type = typeof(System.DateTime);
			this.From.ValueInfo = "2000-01-01";
			this.From.Visible = false;
			// 
			// To
			// 
			this.To.Description = "To date";
			this.To.Name = "To";
			this.To.Type = typeof(System.DateTime);
			this.To.ValueInfo = "2020-01-01";
			this.To.Visible = false;
			// 
			// SalesMasterReport
			// 
			this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.reportHeaderBand1});
			this.CalculatedFields.AddRange(new DevExpress.XtraReports.UI.CalculatedField[] {
            this.cfIsFullyPaid});
			this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.sqlDataSource1});
			this.DataMember = "Sales";
			this.DataSource = this.sqlDataSource1;
			this.Margins = new System.Drawing.Printing.Margins(100, 100, 60, 100);
			this.Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {
            this.ReportTitle,
            this.From,
            this.To});
			this.StyleSheet.AddRange(new DevExpress.XtraReports.UI.XRControlStyle[] {
            this.Title,
            this.DetailCaption3,
            this.DetailData3,
            this.DetailData3_Odd,
            this.DetailCaptionBackground3,
            this.PageInfo});
			this.Version = "17.1";
			((System.ComponentModel.ISupportInitialize)(this)).EndInit();

      }

      #endregion

      private DevExpress.XtraReports.UI.DetailBand Detail;
      private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
      private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
      private DevExpress.XtraReports.UI.XRPageInfo xrPageInfo1;
      private DevExpress.XtraReports.UI.XRPageInfo xrPageInfo2;
      private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
      private DevExpress.XtraReports.UI.ReportHeaderBand reportHeaderBand1;
      private DevExpress.XtraReports.UI.XRLabel xrLabel1;
      private DevExpress.XtraReports.UI.XRTableRow xrTableRow1;
      private DevExpress.XtraReports.UI.XRTableCell xrTableCell1;
      private DevExpress.XtraReports.UI.XRTableCell xrTableCell2;
      private DevExpress.XtraReports.UI.XRTableCell xrTableCell3;
      private DevExpress.XtraReports.UI.XRTableRow xrTableRow3;
      private DevExpress.XtraReports.UI.XRTableCell xrTableCell8;
      private DevExpress.XtraReports.UI.XRTableCell xrTableCell9;
      private DevExpress.XtraReports.UI.XRTableCell xrTableCell10;
      private DevExpress.XtraReports.UI.XRControlStyle Title;
      private DevExpress.XtraReports.UI.XRControlStyle DetailCaption3;
      private DevExpress.XtraReports.UI.XRControlStyle DetailData3;
      private DevExpress.XtraReports.UI.XRControlStyle DetailData3_Odd;
      private DevExpress.XtraReports.UI.XRControlStyle DetailCaptionBackground3;
      private DevExpress.XtraReports.UI.XRControlStyle PageInfo;
      private DevExpress.XtraReports.UI.XRLabel xrLabel9;
      private DevExpress.XtraReports.UI.XRLabel xrLabel8;
      private DevExpress.XtraReports.UI.XRLabel xrLabel7;
      private DevExpress.XtraReports.UI.XRLabel xrLabel3;
      private DevExpress.XtraReports.UI.XRLabel xrLabel6;
      private DevExpress.XtraReports.UI.XRLabel xrLabel5;
      private DevExpress.XtraReports.UI.XRLabel xrLabel4;
      private DevExpress.XtraReports.UI.XRLabel xrLabel2;
      private DevExpress.XtraReports.UI.CalculatedField cfIsFullyPaid;
      private DevExpress.XtraReports.UI.XRSubreport xrSubreport1;
      private DevExpress.XtraReports.UI.XRLabel xrLabel10;
      private DevExpress.XtraReports.Parameters.Parameter ReportTitle;
      private DevExpress.XtraReports.Parameters.Parameter From;
      private DevExpress.XtraReports.Parameters.Parameter To;
   }
}
