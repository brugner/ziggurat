namespace Corlib.Views.Reports
{
   partial class ReceiptReport
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
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReceiptReport));
         this.Detail = new DevExpress.XtraReports.UI.DetailBand();
         this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
         this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
         this.xrPageInfo1 = new DevExpress.XtraReports.UI.XRPageInfo();
         this.xrPageInfo2 = new DevExpress.XtraReports.UI.XRPageInfo();
         this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
         this.reportHeaderBand1 = new DevExpress.XtraReports.UI.ReportHeaderBand();
         this.xrLabel13 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel14 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel15 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel16 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel17 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel18 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel19 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel20 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel21 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel22 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLine3 = new DevExpress.XtraReports.UI.XRLine();
         this.xrLabel23 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel24 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel12 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel11 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLine2 = new DevExpress.XtraReports.UI.XRLine();
         this.xrLine1 = new DevExpress.XtraReports.UI.XRLine();
         this.xrLabel10 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel9 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel8 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel7 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel6 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel5 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel4 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrTableRow1 = new DevExpress.XtraReports.UI.XRTableRow();
         this.xrTableCell1 = new DevExpress.XtraReports.UI.XRTableCell();
         this.xrTableCell2 = new DevExpress.XtraReports.UI.XRTableCell();
         this.xrTableCell3 = new DevExpress.XtraReports.UI.XRTableCell();
         this.Title = new DevExpress.XtraReports.UI.XRControlStyle();
         this.DetailData3_Odd = new DevExpress.XtraReports.UI.XRControlStyle();
         this.PageInfo = new DevExpress.XtraReports.UI.XRControlStyle();
         this.Id = new DevExpress.XtraReports.Parameters.Parameter();
         this.cfToday = new DevExpress.XtraReports.UI.CalculatedField();
         this.cfTitle = new DevExpress.XtraReports.UI.CalculatedField();
         ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
         // 
         // Detail
         // 
         this.Detail.HeightF = 2F;
         this.Detail.Name = "Detail";
         this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
         this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
         // 
         // TopMargin
         // 
         this.TopMargin.HeightF = 100F;
         this.TopMargin.Name = "TopMargin";
         this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
         this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
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
         queryParameter1.Name = "Id";
         queryParameter1.Type = typeof(DevExpress.DataAccess.Expression);
         queryParameter1.Value = new DevExpress.DataAccess.Expression("[Parameters.Id]", typeof(int));
         customSqlQuery1.Parameters.Add(queryParameter1);
         customSqlQuery1.Sql = resources.GetString("customSqlQuery1.Sql");
         this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            selectQuery1,
            customSqlQuery1});
         this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
         // 
         // reportHeaderBand1
         // 
         this.reportHeaderBand1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel13,
            this.xrLabel14,
            this.xrLabel15,
            this.xrLabel16,
            this.xrLabel17,
            this.xrLabel18,
            this.xrLabel19,
            this.xrLabel20,
            this.xrLabel21,
            this.xrLabel22,
            this.xrLine3,
            this.xrLabel23,
            this.xrLabel24,
            this.xrLabel12,
            this.xrLabel11,
            this.xrLine2,
            this.xrLine1,
            this.xrLabel10,
            this.xrLabel9,
            this.xrLabel8,
            this.xrLabel7,
            this.xrLabel6,
            this.xrLabel5,
            this.xrLabel4,
            this.xrLabel2,
            this.xrLabel1,
            this.xrLabel3});
         this.reportHeaderBand1.HeightF = 444.375F;
         this.reportHeaderBand1.Name = "reportHeaderBand1";
         // 
         // xrLabel13
         // 
         this.xrLabel13.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
         this.xrLabel13.LocationFloat = new DevExpress.Utils.PointFloat(6.00001F, 258.2187F);
         this.xrLabel13.Name = "xrLabel13";
         this.xrLabel13.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel13.SizeF = new System.Drawing.SizeF(72.16667F, 23F);
         this.xrLabel13.StylePriority.UseFont = false;
         this.xrLabel13.StylePriority.UseTextAlignment = false;
         this.xrLabel13.Text = "Miembro:";
         this.xrLabel13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
         // 
         // xrLabel14
         // 
         this.xrLabel14.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.cfTitle")});
         this.xrLabel14.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
         this.xrLabel14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
         this.xrLabel14.LocationFloat = new DevExpress.Utils.PointFloat(6.00001F, 226.5521F);
         this.xrLabel14.Name = "xrLabel14";
         this.xrLabel14.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel14.SizeF = new System.Drawing.SizeF(313F, 26F);
         this.xrLabel14.StyleName = "Title";
         this.xrLabel14.StylePriority.UseFont = false;
         this.xrLabel14.StylePriority.UseForeColor = false;
         this.xrLabel14.StylePriority.UseTextAlignment = false;
         this.xrLabel14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
         // 
         // xrLabel15
         // 
         this.xrLabel15.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Parameters.GymName")});
         this.xrLabel15.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
         this.xrLabel15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
         this.xrLabel15.LocationFloat = new DevExpress.Utils.PointFloat(327.0001F, 226.5521F);
         this.xrLabel15.Name = "xrLabel15";
         this.xrLabel15.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel15.SizeF = new System.Drawing.SizeF(313F, 26F);
         this.xrLabel15.StyleName = "Title";
         this.xrLabel15.StylePriority.UseFont = false;
         this.xrLabel15.StylePriority.UseForeColor = false;
         this.xrLabel15.StylePriority.UseTextAlignment = false;
         this.xrLabel15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
         // 
         // xrLabel16
         // 
         this.xrLabel16.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.Member")});
         this.xrLabel16.Font = new System.Drawing.Font("Tahoma", 10F);
         this.xrLabel16.LocationFloat = new DevExpress.Utils.PointFloat(78.16671F, 258.2187F);
         this.xrLabel16.Name = "xrLabel16";
         this.xrLabel16.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel16.SizeF = new System.Drawing.SizeF(331.0416F, 23F);
         this.xrLabel16.StylePriority.UseFont = false;
         this.xrLabel16.StylePriority.UseTextAlignment = false;
         this.xrLabel16.Text = "xrLabel4";
         this.xrLabel16.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
         // 
         // xrLabel17
         // 
         this.xrLabel17.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.Date", "{0:dd/MM/yyyy}")});
         this.xrLabel17.Font = new System.Drawing.Font("Tahoma", 10F);
         this.xrLabel17.LocationFloat = new DevExpress.Utils.PointFloat(562F, 258.2187F);
         this.xrLabel17.Name = "xrLabel17";
         this.xrLabel17.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel17.SizeF = new System.Drawing.SizeF(78F, 23F);
         this.xrLabel17.StylePriority.UseFont = false;
         this.xrLabel17.StylePriority.UseTextAlignment = false;
         this.xrLabel17.Text = "xrLabel5";
         this.xrLabel17.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
         // 
         // xrLabel18
         // 
         this.xrLabel18.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.Concept")});
         this.xrLabel18.Font = new System.Drawing.Font("Tahoma", 10F);
         this.xrLabel18.LocationFloat = new DevExpress.Utils.PointFloat(6.000137F, 304.2188F);
         this.xrLabel18.Name = "xrLabel18";
         this.xrLabel18.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel18.SizeF = new System.Drawing.SizeF(633.9999F, 23F);
         this.xrLabel18.StylePriority.UseFont = false;
         this.xrLabel18.StylePriority.UseTextAlignment = false;
         this.xrLabel18.Text = "xrLabel6";
         this.xrLabel18.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
         // 
         // xrLabel19
         // 
         this.xrLabel19.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
         this.xrLabel19.LocationFloat = new DevExpress.Utils.PointFloat(6.00001F, 281.2187F);
         this.xrLabel19.Name = "xrLabel19";
         this.xrLabel19.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel19.SizeF = new System.Drawing.SizeF(72.1667F, 23F);
         this.xrLabel19.StylePriority.UseFont = false;
         this.xrLabel19.StylePriority.UseTextAlignment = false;
         this.xrLabel19.Text = "Concepto";
         this.xrLabel19.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomLeft;
         // 
         // xrLabel20
         // 
         this.xrLabel20.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
         this.xrLabel20.LocationFloat = new DevExpress.Utils.PointFloat(509.125F, 258.2187F);
         this.xrLabel20.Name = "xrLabel20";
         this.xrLabel20.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel20.SizeF = new System.Drawing.SizeF(52.87497F, 23F);
         this.xrLabel20.StylePriority.UseFont = false;
         this.xrLabel20.StylePriority.UseTextAlignment = false;
         this.xrLabel20.Text = "Fecha:";
         this.xrLabel20.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
         // 
         // xrLabel21
         // 
         this.xrLabel21.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
         this.xrLabel21.LocationFloat = new DevExpress.Utils.PointFloat(489.8333F, 281.2187F);
         this.xrLabel21.Name = "xrLabel21";
         this.xrLabel21.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel21.SizeF = new System.Drawing.SizeF(72.16667F, 23F);
         this.xrLabel21.StylePriority.UseFont = false;
         this.xrLabel21.StylePriority.UseTextAlignment = false;
         this.xrLabel21.Text = "Importe:";
         this.xrLabel21.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
         // 
         // xrLabel22
         // 
         this.xrLabel22.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.Amount", "{0:$0.00}")});
         this.xrLabel22.Font = new System.Drawing.Font("Tahoma", 10F);
         this.xrLabel22.LocationFloat = new DevExpress.Utils.PointFloat(562F, 281.2187F);
         this.xrLabel22.Name = "xrLabel22";
         this.xrLabel22.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel22.SizeF = new System.Drawing.SizeF(78.00006F, 23F);
         this.xrLabel22.StylePriority.UseFont = false;
         this.xrLabel22.StylePriority.UseTextAlignment = false;
         this.xrLabel22.Text = "xrLabel10";
         this.xrLabel22.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
         // 
         // xrLine3
         // 
         this.xrLine3.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash;
         this.xrLine3.LocationFloat = new DevExpress.Utils.PointFloat(420.5835F, 366.9062F);
         this.xrLine3.Name = "xrLine3";
         this.xrLine3.SizeF = new System.Drawing.SizeF(217.3333F, 5F);
         // 
         // xrLabel23
         // 
         this.xrLabel23.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Italic);
         this.xrLabel23.LocationFloat = new DevExpress.Utils.PointFloat(420.5835F, 371.9062F);
         this.xrLabel23.Name = "xrLabel23";
         this.xrLabel23.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel23.SizeF = new System.Drawing.SizeF(217.3333F, 23F);
         this.xrLabel23.StylePriority.UseFont = false;
         this.xrLabel23.StylePriority.UseTextAlignment = false;
         this.xrLabel23.Text = "Firma del gimnasio";
         this.xrLabel23.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
         // 
         // xrLabel24
         // 
         this.xrLabel24.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.cfToday", "{0:dd/MM/yyyy \'a las\' hh:mm}")});
         this.xrLabel24.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Italic);
         this.xrLabel24.LocationFloat = new DevExpress.Utils.PointFloat(6.00001F, 371.9062F);
         this.xrLabel24.Name = "xrLabel24";
         this.xrLabel24.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel24.SizeF = new System.Drawing.SizeF(217.3333F, 23F);
         this.xrLabel24.StylePriority.UseFont = false;
         this.xrLabel24.StylePriority.UseTextAlignment = false;
         this.xrLabel24.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
         // 
         // xrLabel12
         // 
         this.xrLabel12.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.cfToday", "{0:dd/MM/yyyy \'a las\' hh:mm}")});
         this.xrLabel12.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Italic);
         this.xrLabel12.LocationFloat = new DevExpress.Utils.PointFloat(6.00001F, 151.3542F);
         this.xrLabel12.Name = "xrLabel12";
         this.xrLabel12.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel12.SizeF = new System.Drawing.SizeF(217.3333F, 23F);
         this.xrLabel12.StylePriority.UseFont = false;
         this.xrLabel12.StylePriority.UseTextAlignment = false;
         this.xrLabel12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
         // 
         // xrLabel11
         // 
         this.xrLabel11.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Italic);
         this.xrLabel11.LocationFloat = new DevExpress.Utils.PointFloat(420.5835F, 151.3542F);
         this.xrLabel11.Name = "xrLabel11";
         this.xrLabel11.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel11.SizeF = new System.Drawing.SizeF(217.3333F, 23F);
         this.xrLabel11.StylePriority.UseFont = false;
         this.xrLabel11.StylePriority.UseTextAlignment = false;
         this.xrLabel11.Text = "Firma del miembro";
         this.xrLabel11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
         // 
         // xrLine2
         // 
         this.xrLine2.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash;
         this.xrLine2.LocationFloat = new DevExpress.Utils.PointFloat(420.5835F, 146.3542F);
         this.xrLine2.Name = "xrLine2";
         this.xrLine2.SizeF = new System.Drawing.SizeF(217.3333F, 5F);
         // 
         // xrLine1
         // 
         this.xrLine1.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash;
         this.xrLine1.LocationFloat = new DevExpress.Utils.PointFloat(6.00001F, 193.9167F);
         this.xrLine1.Name = "xrLine1";
         this.xrLine1.SizeF = new System.Drawing.SizeF(634F, 16.66667F);
         // 
         // xrLabel10
         // 
         this.xrLabel10.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.Amount", "{0:$0.00}")});
         this.xrLabel10.Font = new System.Drawing.Font("Tahoma", 10F);
         this.xrLabel10.LocationFloat = new DevExpress.Utils.PointFloat(561.9999F, 60.66666F);
         this.xrLabel10.Name = "xrLabel10";
         this.xrLabel10.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel10.SizeF = new System.Drawing.SizeF(78.00006F, 23F);
         this.xrLabel10.StylePriority.UseFont = false;
         this.xrLabel10.StylePriority.UseTextAlignment = false;
         this.xrLabel10.Text = "xrLabel10";
         this.xrLabel10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
         // 
         // xrLabel9
         // 
         this.xrLabel9.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
         this.xrLabel9.LocationFloat = new DevExpress.Utils.PointFloat(489.8333F, 60.66663F);
         this.xrLabel9.Name = "xrLabel9";
         this.xrLabel9.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel9.SizeF = new System.Drawing.SizeF(72.16667F, 23F);
         this.xrLabel9.StylePriority.UseFont = false;
         this.xrLabel9.StylePriority.UseTextAlignment = false;
         this.xrLabel9.Text = "Importe:";
         this.xrLabel9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
         // 
         // xrLabel8
         // 
         this.xrLabel8.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
         this.xrLabel8.LocationFloat = new DevExpress.Utils.PointFloat(509.125F, 37.66664F);
         this.xrLabel8.Name = "xrLabel8";
         this.xrLabel8.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel8.SizeF = new System.Drawing.SizeF(52.87497F, 23F);
         this.xrLabel8.StylePriority.UseFont = false;
         this.xrLabel8.StylePriority.UseTextAlignment = false;
         this.xrLabel8.Text = "Fecha:";
         this.xrLabel8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
         // 
         // xrLabel7
         // 
         this.xrLabel7.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
         this.xrLabel7.LocationFloat = new DevExpress.Utils.PointFloat(6.00001F, 60.66666F);
         this.xrLabel7.Name = "xrLabel7";
         this.xrLabel7.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel7.SizeF = new System.Drawing.SizeF(72.1667F, 23F);
         this.xrLabel7.StylePriority.UseFont = false;
         this.xrLabel7.StylePriority.UseTextAlignment = false;
         this.xrLabel7.Text = "Concepto";
         this.xrLabel7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomLeft;
         // 
         // xrLabel6
         // 
         this.xrLabel6.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.Concept")});
         this.xrLabel6.Font = new System.Drawing.Font("Tahoma", 10F);
         this.xrLabel6.LocationFloat = new DevExpress.Utils.PointFloat(6.000137F, 83.66667F);
         this.xrLabel6.Name = "xrLabel6";
         this.xrLabel6.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel6.SizeF = new System.Drawing.SizeF(633.9999F, 23F);
         this.xrLabel6.StylePriority.UseFont = false;
         this.xrLabel6.StylePriority.UseTextAlignment = false;
         this.xrLabel6.Text = "xrLabel6";
         this.xrLabel6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
         // 
         // xrLabel5
         // 
         this.xrLabel5.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.Date", "{0:dd/MM/yyyy}")});
         this.xrLabel5.Font = new System.Drawing.Font("Tahoma", 10F);
         this.xrLabel5.LocationFloat = new DevExpress.Utils.PointFloat(562F, 37.66664F);
         this.xrLabel5.Name = "xrLabel5";
         this.xrLabel5.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel5.SizeF = new System.Drawing.SizeF(78F, 23F);
         this.xrLabel5.StylePriority.UseFont = false;
         this.xrLabel5.StylePriority.UseTextAlignment = false;
         this.xrLabel5.Text = "xrLabel5";
         this.xrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
         // 
         // xrLabel4
         // 
         this.xrLabel4.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.Member")});
         this.xrLabel4.Font = new System.Drawing.Font("Tahoma", 10F);
         this.xrLabel4.LocationFloat = new DevExpress.Utils.PointFloat(78.16671F, 37.66666F);
         this.xrLabel4.Name = "xrLabel4";
         this.xrLabel4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel4.SizeF = new System.Drawing.SizeF(331.0416F, 23F);
         this.xrLabel4.StylePriority.UseFont = false;
         this.xrLabel4.StylePriority.UseTextAlignment = false;
         this.xrLabel4.Text = "xrLabel4";
         this.xrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
         // 
         // xrLabel2
         // 
         this.xrLabel2.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Parameters.GymName")});
         this.xrLabel2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
         this.xrLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
         this.xrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(327F, 6.00001F);
         this.xrLabel2.Name = "xrLabel2";
         this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel2.SizeF = new System.Drawing.SizeF(313F, 26F);
         this.xrLabel2.StyleName = "Title";
         this.xrLabel2.StylePriority.UseFont = false;
         this.xrLabel2.StylePriority.UseForeColor = false;
         this.xrLabel2.StylePriority.UseTextAlignment = false;
         this.xrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
         // 
         // xrLabel1
         // 
         this.xrLabel1.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.cfTitle")});
         this.xrLabel1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
         this.xrLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
         this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(6.00001F, 6.00001F);
         this.xrLabel1.Name = "xrLabel1";
         this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel1.SizeF = new System.Drawing.SizeF(313F, 26F);
         this.xrLabel1.StyleName = "Title";
         this.xrLabel1.StylePriority.UseFont = false;
         this.xrLabel1.StylePriority.UseForeColor = false;
         this.xrLabel1.StylePriority.UseTextAlignment = false;
         this.xrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
         // 
         // xrLabel3
         // 
         this.xrLabel3.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
         this.xrLabel3.LocationFloat = new DevExpress.Utils.PointFloat(6.00001F, 37.66666F);
         this.xrLabel3.Name = "xrLabel3";
         this.xrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel3.SizeF = new System.Drawing.SizeF(72.16667F, 23F);
         this.xrLabel3.StylePriority.UseFont = false;
         this.xrLabel3.StylePriority.UseTextAlignment = false;
         this.xrLabel3.Text = "Miembro:";
         this.xrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
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
         this.Id.Description = "Id of the payment";
         this.Id.Name = "Id";
         this.Id.Type = typeof(int);
         this.Id.ValueInfo = "0";
         this.Id.Visible = false;
         // 
         // cfToday
         // 
         this.cfToday.DataMember = "Query";
         this.cfToday.Expression = "Today()";
         this.cfToday.Name = "cfToday";
         // 
         // cfTitle
         // 
         this.cfTitle.DataMember = "Query";
         this.cfTitle.Expression = "\'Recibo #\' + [Id]";
         this.cfTitle.Name = "cfTitle";
         // 
         // ReceiptReport
         // 
         this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.reportHeaderBand1});
         this.CalculatedFields.AddRange(new DevExpress.XtraReports.UI.CalculatedField[] {
            this.cfToday,
            this.cfTitle});
         this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.sqlDataSource1});
         this.DataSource = this.sqlDataSource1;
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
      private DevExpress.XtraReports.UI.XRLabel xrLabel10;
      private DevExpress.XtraReports.UI.XRLabel xrLabel9;
      private DevExpress.XtraReports.UI.XRLabel xrLabel8;
      private DevExpress.XtraReports.UI.XRLabel xrLabel7;
      private DevExpress.XtraReports.UI.XRLabel xrLabel6;
      private DevExpress.XtraReports.UI.XRLabel xrLabel5;
      private DevExpress.XtraReports.UI.XRLabel xrLabel4;
      private DevExpress.XtraReports.UI.XRLabel xrLabel2;
      private DevExpress.XtraReports.UI.XRLabel xrLabel3;
      private DevExpress.XtraReports.Parameters.Parameter Id;
      private DevExpress.XtraReports.UI.XRLabel xrLabel13;
      private DevExpress.XtraReports.UI.XRLabel xrLabel14;
      private DevExpress.XtraReports.UI.XRLabel xrLabel15;
      private DevExpress.XtraReports.UI.XRLabel xrLabel16;
      private DevExpress.XtraReports.UI.XRLabel xrLabel17;
      private DevExpress.XtraReports.UI.XRLabel xrLabel18;
      private DevExpress.XtraReports.UI.XRLabel xrLabel19;
      private DevExpress.XtraReports.UI.XRLabel xrLabel20;
      private DevExpress.XtraReports.UI.XRLabel xrLabel21;
      private DevExpress.XtraReports.UI.XRLabel xrLabel22;
      private DevExpress.XtraReports.UI.XRLine xrLine3;
      private DevExpress.XtraReports.UI.XRLabel xrLabel23;
      private DevExpress.XtraReports.UI.XRLabel xrLabel24;
      private DevExpress.XtraReports.UI.XRLabel xrLabel12;
      private DevExpress.XtraReports.UI.XRLabel xrLabel11;
      private DevExpress.XtraReports.UI.XRLine xrLine2;
      private DevExpress.XtraReports.UI.XRLine xrLine1;
      private DevExpress.XtraReports.UI.CalculatedField cfToday;
      private DevExpress.XtraReports.UI.CalculatedField cfTitle;
   }
}
