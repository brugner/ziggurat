namespace Corlib.Views.Reports
{
   partial class MemberFinancialMovementsReport
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
         DevExpress.DataAccess.Sql.SelectQuery selectQuery1 = new DevExpress.DataAccess.Sql.SelectQuery();
         DevExpress.DataAccess.Sql.Column column1 = new DevExpress.DataAccess.Sql.Column();
         DevExpress.DataAccess.Sql.ColumnExpression columnExpression1 = new DevExpress.DataAccess.Sql.ColumnExpression();
         DevExpress.DataAccess.Sql.Table table1 = new DevExpress.DataAccess.Sql.Table();
         DevExpress.DataAccess.Sql.CustomSqlQuery customSqlQuery1 = new DevExpress.DataAccess.Sql.CustomSqlQuery();
         DevExpress.DataAccess.Sql.QueryParameter queryParameter1 = new DevExpress.DataAccess.Sql.QueryParameter();
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MemberFinancialMovementsReport));
         DevExpress.DataAccess.Sql.CustomSqlQuery customSqlQuery2 = new DevExpress.DataAccess.Sql.CustomSqlQuery();
         DevExpress.DataAccess.Sql.QueryParameter queryParameter2 = new DevExpress.DataAccess.Sql.QueryParameter();
         DevExpress.DataAccess.Sql.CustomSqlQuery customSqlQuery3 = new DevExpress.DataAccess.Sql.CustomSqlQuery();
         DevExpress.DataAccess.Sql.QueryParameter queryParameter3 = new DevExpress.DataAccess.Sql.QueryParameter();
         DevExpress.XtraReports.UI.XRSummary xrSummary1 = new DevExpress.XtraReports.UI.XRSummary();
         DevExpress.XtraReports.UI.XRSummary xrSummary2 = new DevExpress.XtraReports.UI.XRSummary();
         this.Detail = new DevExpress.XtraReports.UI.DetailBand();
         this.xrLabel23 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel24 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel25 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel26 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel27 = new DevExpress.XtraReports.UI.XRLabel();
         this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
         this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
         this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
         this.xrPageInfo1 = new DevExpress.XtraReports.UI.XRPageInfo();
         this.xrPageInfo2 = new DevExpress.XtraReports.UI.XRPageInfo();
         this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
         this.reportHeaderBand1 = new DevExpress.XtraReports.UI.ReportHeaderBand();
         this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrTableRow1 = new DevExpress.XtraReports.UI.XRTableRow();
         this.xrTableCell1 = new DevExpress.XtraReports.UI.XRTableCell();
         this.xrTableCell2 = new DevExpress.XtraReports.UI.XRTableCell();
         this.xrTableCell3 = new DevExpress.XtraReports.UI.XRTableCell();
         this.Title = new DevExpress.XtraReports.UI.XRControlStyle();
         this.DetailData3_Odd = new DevExpress.XtraReports.UI.XRControlStyle();
         this.PageInfo = new DevExpress.XtraReports.UI.XRControlStyle();
         this.Id = new DevExpress.XtraReports.Parameters.Parameter();
         this.xrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel4 = new DevExpress.XtraReports.UI.XRLabel();
         this.PageHeader = new DevExpress.XtraReports.UI.PageHeaderBand();
         this.xrLabel8 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel7 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel6 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel5 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrPanel1 = new DevExpress.XtraReports.UI.XRPanel();
         this.xrLabel15 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel14 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel13 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel11 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel9 = new DevExpress.XtraReports.UI.XRLabel();
         this.ReportFooter = new DevExpress.XtraReports.UI.ReportFooterBand();
         this.xrPanel2 = new DevExpress.XtraReports.UI.XRPanel();
         this.xrLabel19 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel20 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel21 = new DevExpress.XtraReports.UI.XRLabel();
         this.formattingRule1 = new DevExpress.XtraReports.UI.FormattingRule();
         this.cfFinalBalance = new DevExpress.XtraReports.UI.CalculatedField();
         ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
         // 
         // Detail
         // 
         this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel23,
            this.xrLabel24,
            this.xrLabel25,
            this.xrLabel26,
            this.xrLabel27});
         this.Detail.HeightF = 23F;
         this.Detail.Name = "Detail";
         this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
         this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
         // 
         // xrLabel23
         // 
         this.xrLabel23.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.Date", "{0:dd/MM/yyyy}")});
         this.xrLabel23.Font = new System.Drawing.Font("Tahoma", 10F);
         this.xrLabel23.LocationFloat = new DevExpress.Utils.PointFloat(10.00001F, 0F);
         this.xrLabel23.Name = "xrLabel23";
         this.xrLabel23.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel23.SizeF = new System.Drawing.SizeF(76F, 23F);
         this.xrLabel23.StylePriority.UseFont = false;
         this.xrLabel23.Text = "xrLabel10";
         // 
         // xrLabel24
         // 
         this.xrLabel24.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.Concept")});
         this.xrLabel24.Font = new System.Drawing.Font("Tahoma", 10F);
         this.xrLabel24.LocationFloat = new DevExpress.Utils.PointFloat(92.04165F, 0F);
         this.xrLabel24.Name = "xrLabel24";
         this.xrLabel24.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel24.SizeF = new System.Drawing.SizeF(267.0415F, 23F);
         this.xrLabel24.StylePriority.UseFont = false;
         this.xrLabel24.Text = "xrLabel12";
         // 
         // xrLabel25
         // 
         this.xrLabel25.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.Debit")});
         this.xrLabel25.Font = new System.Drawing.Font("Tahoma", 10F);
         this.xrLabel25.LocationFloat = new DevExpress.Utils.PointFloat(364.2083F, 0F);
         this.xrLabel25.Name = "xrLabel25";
         this.xrLabel25.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel25.SizeF = new System.Drawing.SizeF(89.99991F, 23F);
         this.xrLabel25.StylePriority.UseFont = false;
         this.xrLabel25.StylePriority.UseTextAlignment = false;
         this.xrLabel25.Text = "xrLabel16";
         this.xrLabel25.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
         // 
         // xrLabel26
         // 
         this.xrLabel26.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.Credit")});
         this.xrLabel26.Font = new System.Drawing.Font("Tahoma", 10F);
         this.xrLabel26.LocationFloat = new DevExpress.Utils.PointFloat(454.2083F, 0F);
         this.xrLabel26.Name = "xrLabel26";
         this.xrLabel26.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel26.SizeF = new System.Drawing.SizeF(90F, 23F);
         this.xrLabel26.StylePriority.UseFont = false;
         this.xrLabel26.StylePriority.UseTextAlignment = false;
         this.xrLabel26.Text = "xrLabel17";
         this.xrLabel26.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
         // 
         // xrLabel27
         // 
         this.xrLabel27.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.Balance")});
         this.xrLabel27.Font = new System.Drawing.Font("Tahoma", 10F);
         this.xrLabel27.LocationFloat = new DevExpress.Utils.PointFloat(544.2083F, 0F);
         this.xrLabel27.Name = "xrLabel27";
         this.xrLabel27.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel27.SizeF = new System.Drawing.SizeF(101.604F, 23F);
         this.xrLabel27.StylePriority.UseFont = false;
         this.xrLabel27.StylePriority.UseTextAlignment = false;
         this.xrLabel27.Text = "xrLabel18";
         this.xrLabel27.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
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
         this.xrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(10.00001F, 10.00001F);
         this.xrLabel2.Name = "xrLabel2";
         this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel2.SizeF = new System.Drawing.SizeF(630F, 28F);
         this.xrLabel2.StylePriority.UseFont = false;
         this.xrLabel2.StylePriority.UseTextAlignment = false;
         this.xrLabel2.Text = "xrLabel2";
         this.xrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
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
         columnExpression1.ColumnName = "GymName";
         table1.Name = "Parameters";
         columnExpression1.Table = table1;
         column1.Expression = columnExpression1;
         selectQuery1.Columns.Add(column1);
         selectQuery1.Name = "Parameters";
         selectQuery1.Tables.Add(table1);
         customSqlQuery1.Name = "Query";
         queryParameter1.Name = "MemberId";
         queryParameter1.Type = typeof(DevExpress.DataAccess.Expression);
         queryParameter1.Value = new DevExpress.DataAccess.Expression("[Parameters.Id]", typeof(int));
         customSqlQuery1.Parameters.Add(queryParameter1);
         customSqlQuery1.Sql = resources.GetString("customSqlQuery1.Sql");
         customSqlQuery2.Name = "Members";
         queryParameter2.Name = "MemberId";
         queryParameter2.Type = typeof(DevExpress.DataAccess.Expression);
         queryParameter2.Value = new DevExpress.DataAccess.Expression("[Parameters.Id]", typeof(int));
         customSqlQuery2.Parameters.Add(queryParameter2);
         customSqlQuery2.Sql = "SELECT Members.FirstName + \' \' + Members.LastName AS \'FullName\'\r\nFROM Members\r\nWH" +
    "ERE Members.Id = @MemberId";
         customSqlQuery3.Name = "Dates";
         queryParameter3.Name = "MemberId";
         queryParameter3.Type = typeof(DevExpress.DataAccess.Expression);
         queryParameter3.Value = new DevExpress.DataAccess.Expression("[Parameters.Id]", typeof(int));
         customSqlQuery3.Parameters.Add(queryParameter3);
         customSqlQuery3.Sql = "SELECT MIN(MemberFinancialMovements.Date) AS \'InitialDate\', MAX(MemberFinancialMo" +
    "vements.Date) AS \'FinalDate\'\r\nFROM MemberFinancialMovements\r\nWHERE MemberFinanci" +
    "alMovements.MemberId = @MemberId";
         this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            selectQuery1,
            customSqlQuery1,
            customSqlQuery2,
            customSqlQuery3});
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
         this.xrLabel1.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
         this.xrLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
         this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(10.00001F, 6.00001F);
         this.xrLabel1.Name = "xrLabel1";
         this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel1.SizeF = new System.Drawing.SizeF(629.9999F, 26F);
         this.xrLabel1.StyleName = "Title";
         this.xrLabel1.StylePriority.UseFont = false;
         this.xrLabel1.StylePriority.UseForeColor = false;
         this.xrLabel1.StylePriority.UseTextAlignment = false;
         this.xrLabel1.Text = "Movimientos financieros";
         this.xrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
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
         // PageInfo
         // 
         this.PageInfo.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
         this.PageInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
         this.PageInfo.Name = "PageInfo";
         this.PageInfo.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         // 
         // Id
         // 
         this.Id.Description = "Id of the member";
         this.Id.Name = "Id";
         this.Id.Type = typeof(int);
         this.Id.ValueInfo = "0";
         this.Id.Visible = false;
         // 
         // xrLabel3
         // 
         this.xrLabel3.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Members.FullName")});
         this.xrLabel3.Font = new System.Drawing.Font("Tahoma", 10F);
         this.xrLabel3.LocationFloat = new DevExpress.Utils.PointFloat(86.04164F, 0F);
         this.xrLabel3.Name = "xrLabel3";
         this.xrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel3.SizeF = new System.Drawing.SizeF(208.1249F, 23F);
         this.xrLabel3.StylePriority.UseFont = false;
         this.xrLabel3.StylePriority.UseTextAlignment = false;
         this.xrLabel3.Text = "xrLabel3";
         this.xrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
         // 
         // xrLabel4
         // 
         this.xrLabel4.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
         this.xrLabel4.LocationFloat = new DevExpress.Utils.PointFloat(10.00001F, 0F);
         this.xrLabel4.Name = "xrLabel4";
         this.xrLabel4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel4.SizeF = new System.Drawing.SizeF(76.04163F, 23F);
         this.xrLabel4.StylePriority.UseFont = false;
         this.xrLabel4.StylePriority.UseTextAlignment = false;
         this.xrLabel4.Text = "Miembro:";
         this.xrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
         // 
         // PageHeader
         // 
         this.PageHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel8,
            this.xrLabel7,
            this.xrLabel6,
            this.xrLabel5,
            this.xrLabel3,
            this.xrLabel4,
            this.xrPanel1});
         this.PageHeader.HeightF = 45.29167F;
         this.PageHeader.Name = "PageHeader";
         // 
         // xrLabel8
         // 
         this.xrLabel8.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Dates.FinalDate", "{0:dd/MM/yyyy}")});
         this.xrLabel8.Font = new System.Drawing.Font("Tahoma", 10F);
         this.xrLabel8.LocationFloat = new DevExpress.Utils.PointFloat(569.8123F, 0F);
         this.xrLabel8.Name = "xrLabel8";
         this.xrLabel8.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel8.SizeF = new System.Drawing.SizeF(76F, 23F);
         this.xrLabel8.StylePriority.UseFont = false;
         this.xrLabel8.StylePriority.UseTextAlignment = false;
         this.xrLabel8.Text = "xrLabel8";
         this.xrLabel8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
         // 
         // xrLabel7
         // 
         this.xrLabel7.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Dates.InitialDate", "{0:dd/MM/yyyy}")});
         this.xrLabel7.Font = new System.Drawing.Font("Tahoma", 10F);
         this.xrLabel7.LocationFloat = new DevExpress.Utils.PointFloat(401.7915F, 0F);
         this.xrLabel7.Name = "xrLabel7";
         this.xrLabel7.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel7.SizeF = new System.Drawing.SizeF(76F, 23F);
         this.xrLabel7.StylePriority.UseFont = false;
         this.xrLabel7.StylePriority.UseTextAlignment = false;
         this.xrLabel7.Text = "xrLabel7";
         this.xrLabel7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
         // 
         // xrLabel6
         // 
         this.xrLabel6.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
         this.xrLabel6.LocationFloat = new DevExpress.Utils.PointFloat(305.7082F, 0F);
         this.xrLabel6.Name = "xrLabel6";
         this.xrLabel6.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel6.SizeF = new System.Drawing.SizeF(96.08328F, 23F);
         this.xrLabel6.StylePriority.UseFont = false;
         this.xrLabel6.StylePriority.UseTextAlignment = false;
         this.xrLabel6.Text = "Fecha inicial:";
         this.xrLabel6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
         // 
         // xrLabel5
         // 
         this.xrLabel5.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
         this.xrLabel5.LocationFloat = new DevExpress.Utils.PointFloat(483.7915F, 0F);
         this.xrLabel5.Name = "xrLabel5";
         this.xrLabel5.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel5.SizeF = new System.Drawing.SizeF(86.02081F, 23F);
         this.xrLabel5.StylePriority.UseFont = false;
         this.xrLabel5.StylePriority.UseTextAlignment = false;
         this.xrLabel5.Text = "Fecha final:";
         this.xrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
         // 
         // xrPanel1
         // 
         this.xrPanel1.BackColor = System.Drawing.Color.Silver;
         this.xrPanel1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel15,
            this.xrLabel14,
            this.xrLabel13,
            this.xrLabel11,
            this.xrLabel9});
         this.xrPanel1.LocationFloat = new DevExpress.Utils.PointFloat(10.00001F, 23.41668F);
         this.xrPanel1.Name = "xrPanel1";
         this.xrPanel1.SizeF = new System.Drawing.SizeF(635.8123F, 21.875F);
         this.xrPanel1.StylePriority.UseBackColor = false;
         // 
         // xrLabel15
         // 
         this.xrLabel15.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
         this.xrLabel15.LocationFloat = new DevExpress.Utils.PointFloat(534.2082F, 0F);
         this.xrLabel15.Name = "xrLabel15";
         this.xrLabel15.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel15.SizeF = new System.Drawing.SizeF(101.6041F, 23F);
         this.xrLabel15.StylePriority.UseFont = false;
         this.xrLabel15.StylePriority.UseTextAlignment = false;
         this.xrLabel15.Text = "Balance";
         this.xrLabel15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
         // 
         // xrLabel14
         // 
         this.xrLabel14.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
         this.xrLabel14.LocationFloat = new DevExpress.Utils.PointFloat(444.2083F, 0F);
         this.xrLabel14.Name = "xrLabel14";
         this.xrLabel14.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel14.SizeF = new System.Drawing.SizeF(90F, 23F);
         this.xrLabel14.StylePriority.UseFont = false;
         this.xrLabel14.StylePriority.UseTextAlignment = false;
         this.xrLabel14.Text = "Crédito";
         this.xrLabel14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
         // 
         // xrLabel13
         // 
         this.xrLabel13.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
         this.xrLabel13.LocationFloat = new DevExpress.Utils.PointFloat(354.2083F, 0F);
         this.xrLabel13.Name = "xrLabel13";
         this.xrLabel13.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel13.SizeF = new System.Drawing.SizeF(90F, 23F);
         this.xrLabel13.StylePriority.UseFont = false;
         this.xrLabel13.StylePriority.UseTextAlignment = false;
         this.xrLabel13.Text = "Débito";
         this.xrLabel13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
         // 
         // xrLabel11
         // 
         this.xrLabel11.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
         this.xrLabel11.LocationFloat = new DevExpress.Utils.PointFloat(82.04164F, 0F);
         this.xrLabel11.Name = "xrLabel11";
         this.xrLabel11.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel11.SizeF = new System.Drawing.SizeF(76.04163F, 23F);
         this.xrLabel11.StylePriority.UseFont = false;
         this.xrLabel11.StylePriority.UseTextAlignment = false;
         this.xrLabel11.Text = "Concepto";
         this.xrLabel11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
         // 
         // xrLabel9
         // 
         this.xrLabel9.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
         this.xrLabel9.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
         this.xrLabel9.Name = "xrLabel9";
         this.xrLabel9.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel9.SizeF = new System.Drawing.SizeF(76.04163F, 23F);
         this.xrLabel9.StylePriority.UseFont = false;
         this.xrLabel9.StylePriority.UseTextAlignment = false;
         this.xrLabel9.Text = "Fecha";
         this.xrLabel9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
         // 
         // ReportFooter
         // 
         this.ReportFooter.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrPanel2});
         this.ReportFooter.HeightF = 44.79167F;
         this.ReportFooter.Name = "ReportFooter";
         // 
         // xrPanel2
         // 
         this.xrPanel2.Borders = DevExpress.XtraPrinting.BorderSide.Top;
         this.xrPanel2.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel19,
            this.xrLabel20,
            this.xrLabel21});
         this.xrPanel2.LocationFloat = new DevExpress.Utils.PointFloat(10.00001F, 0F);
         this.xrPanel2.Name = "xrPanel2";
         this.xrPanel2.SizeF = new System.Drawing.SizeF(635.8123F, 34.79166F);
         this.xrPanel2.StylePriority.UseBorders = false;
         // 
         // xrLabel19
         // 
         this.xrLabel19.Borders = DevExpress.XtraPrinting.BorderSide.None;
         this.xrLabel19.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.Debit")});
         this.xrLabel19.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
         this.xrLabel19.LocationFloat = new DevExpress.Utils.PointFloat(354.2082F, 1.791668F);
         this.xrLabel19.Name = "xrLabel19";
         this.xrLabel19.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel19.SizeF = new System.Drawing.SizeF(90F, 23F);
         this.xrLabel19.StylePriority.UseBorders = false;
         this.xrLabel19.StylePriority.UseFont = false;
         this.xrLabel19.StylePriority.UseTextAlignment = false;
         xrSummary1.FormatString = "${0}";
         xrSummary1.IgnoreNullValues = true;
         xrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
         this.xrLabel19.Summary = xrSummary1;
         this.xrLabel19.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
         // 
         // xrLabel20
         // 
         this.xrLabel20.Borders = DevExpress.XtraPrinting.BorderSide.None;
         this.xrLabel20.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.Credit")});
         this.xrLabel20.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
         this.xrLabel20.LocationFloat = new DevExpress.Utils.PointFloat(444.2082F, 1.791668F);
         this.xrLabel20.Name = "xrLabel20";
         this.xrLabel20.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel20.SizeF = new System.Drawing.SizeF(90F, 23F);
         this.xrLabel20.StylePriority.UseBorders = false;
         this.xrLabel20.StylePriority.UseFont = false;
         this.xrLabel20.StylePriority.UseTextAlignment = false;
         xrSummary2.FormatString = "${0}";
         xrSummary2.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
         this.xrLabel20.Summary = xrSummary2;
         this.xrLabel20.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
         // 
         // xrLabel21
         // 
         this.xrLabel21.Borders = DevExpress.XtraPrinting.BorderSide.None;
         this.xrLabel21.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.cfFinalBalance", "${0}")});
         this.xrLabel21.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
         this.xrLabel21.ForeColor = System.Drawing.Color.Green;
         this.xrLabel21.FormattingRules.Add(this.formattingRule1);
         this.xrLabel21.LocationFloat = new DevExpress.Utils.PointFloat(534.2083F, 1.791668F);
         this.xrLabel21.Name = "xrLabel21";
         this.xrLabel21.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel21.SizeF = new System.Drawing.SizeF(101.6039F, 23F);
         this.xrLabel21.StylePriority.UseBorders = false;
         this.xrLabel21.StylePriority.UseFont = false;
         this.xrLabel21.StylePriority.UseForeColor = false;
         this.xrLabel21.StylePriority.UseTextAlignment = false;
         this.xrLabel21.Text = "xrLabel21";
         this.xrLabel21.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
         // 
         // formattingRule1
         // 
         this.formattingRule1.Condition = "[Query.cfFinalBalance] > 0";
         this.formattingRule1.Formatting.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
         this.formattingRule1.Name = "formattingRule1";
         // 
         // cfFinalBalance
         // 
         this.cfFinalBalance.DataMember = "Query";
         this.cfFinalBalance.Expression = "Sum([Debit]) - Sum([Credit])";
         this.cfFinalBalance.Name = "cfFinalBalance";
         // 
         // MemberFinancialMovementsReport
         // 
         this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.reportHeaderBand1,
            this.PageHeader,
            this.ReportFooter});
         this.CalculatedFields.AddRange(new DevExpress.XtraReports.UI.CalculatedField[] {
            this.cfFinalBalance});
         this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.sqlDataSource1});
         this.DataSource = this.sqlDataSource1;
         this.FormattingRuleSheet.AddRange(new DevExpress.XtraReports.UI.FormattingRule[] {
            this.formattingRule1});
         this.Margins = new System.Drawing.Printing.Margins(100, 100, 60, 100);
         this.Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {
            this.Id});
         this.StyleSheet.AddRange(new DevExpress.XtraReports.UI.XRControlStyle[] {
            this.Title,
            this.DetailData3_Odd,
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
      private DevExpress.XtraReports.UI.XRControlStyle Title;
      private DevExpress.XtraReports.UI.XRControlStyle DetailData3_Odd;
      private DevExpress.XtraReports.UI.XRControlStyle PageInfo;
      private DevExpress.XtraReports.UI.XRLabel xrLabel2;
      private DevExpress.XtraReports.Parameters.Parameter Id;
      private DevExpress.XtraReports.UI.XRLabel xrLabel3;
      private DevExpress.XtraReports.UI.XRLabel xrLabel4;
      private DevExpress.XtraReports.UI.PageHeaderBand PageHeader;
      private DevExpress.XtraReports.UI.XRLabel xrLabel8;
      private DevExpress.XtraReports.UI.XRLabel xrLabel7;
      private DevExpress.XtraReports.UI.XRLabel xrLabel6;
      private DevExpress.XtraReports.UI.XRLabel xrLabel5;
      private DevExpress.XtraReports.UI.XRLabel xrLabel15;
      private DevExpress.XtraReports.UI.XRLabel xrLabel14;
      private DevExpress.XtraReports.UI.XRLabel xrLabel13;
      private DevExpress.XtraReports.UI.XRLabel xrLabel11;
      private DevExpress.XtraReports.UI.XRLabel xrLabel9;
      private DevExpress.XtraReports.UI.XRPanel xrPanel1;
      private DevExpress.XtraReports.UI.ReportFooterBand ReportFooter;
      private DevExpress.XtraReports.UI.XRLabel xrLabel21;
      private DevExpress.XtraReports.UI.FormattingRule formattingRule1;
      private DevExpress.XtraReports.UI.XRLabel xrLabel20;
      private DevExpress.XtraReports.UI.XRLabel xrLabel19;
      private DevExpress.XtraReports.UI.CalculatedField cfFinalBalance;
      private DevExpress.XtraReports.UI.XRPanel xrPanel2;
      private DevExpress.XtraReports.UI.XRLabel xrLabel23;
      private DevExpress.XtraReports.UI.XRLabel xrLabel24;
      private DevExpress.XtraReports.UI.XRLabel xrLabel25;
      private DevExpress.XtraReports.UI.XRLabel xrLabel26;
      private DevExpress.XtraReports.UI.XRLabel xrLabel27;
   }
}
