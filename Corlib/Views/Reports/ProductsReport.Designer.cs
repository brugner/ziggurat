namespace Corlib.Views.Reports
{
   partial class ProductsReport
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
         DevExpress.DataAccess.Sql.MasterDetailInfo masterDetailInfo1 = new DevExpress.DataAccess.Sql.MasterDetailInfo();
         DevExpress.DataAccess.Sql.RelationColumnInfo relationColumnInfo1 = new DevExpress.DataAccess.Sql.RelationColumnInfo();
         System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductsReport));
         DevExpress.XtraReports.UI.XRSummary xrSummary1 = new DevExpress.XtraReports.UI.XRSummary();
         this.Detail = new DevExpress.XtraReports.UI.DetailBand();
         this.xrLabel4 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel9 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel8 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel7 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
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
         this.xrTableRow4 = new DevExpress.XtraReports.UI.XRTableRow();
         this.xrTableCell14 = new DevExpress.XtraReports.UI.XRTableCell();
         this.xrTableCell15 = new DevExpress.XtraReports.UI.XRTableCell();
         this.xrTableCell16 = new DevExpress.XtraReports.UI.XRTableCell();
         this.xrTableRow6 = new DevExpress.XtraReports.UI.XRTableRow();
         this.xrTableCell19 = new DevExpress.XtraReports.UI.XRTableCell();
         this.xrTableCell20 = new DevExpress.XtraReports.UI.XRTableCell();
         this.xrTableCell21 = new DevExpress.XtraReports.UI.XRTableCell();
         this.Title = new DevExpress.XtraReports.UI.XRControlStyle();
         this.PageInfo = new DevExpress.XtraReports.UI.XRControlStyle();
         this.GroupHeader1 = new DevExpress.XtraReports.UI.GroupHeaderBand();
         this.xrPanel1 = new DevExpress.XtraReports.UI.XRPanel();
         this.xrLabel13 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel12 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel11 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel10 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel6 = new DevExpress.XtraReports.UI.XRLabel();
         this.xrLabel5 = new DevExpress.XtraReports.UI.XRLabel();
         this.cfIsActive = new DevExpress.XtraReports.UI.CalculatedField();
         this.GroupFooter1 = new DevExpress.XtraReports.UI.GroupFooterBand();
         this.xrLabel14 = new DevExpress.XtraReports.UI.XRLabel();
         ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
         // 
         // Detail
         // 
         this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel4,
            this.xrLabel9,
            this.xrLabel8,
            this.xrLabel7,
            this.xrLabel3});
         this.Detail.HeightF = 23F;
         this.Detail.KeepTogether = true;
         this.Detail.Name = "Detail";
         this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
         this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
         // 
         // xrLabel4
         // 
         this.xrLabel4.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.cfIsActive")});
         this.xrLabel4.Font = new System.Drawing.Font("Tahoma", 10F);
         this.xrLabel4.LocationFloat = new DevExpress.Utils.PointFloat(580.625F, 0F);
         this.xrLabel4.Name = "xrLabel4";
         this.xrLabel4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel4.SizeF = new System.Drawing.SizeF(59.37494F, 23F);
         this.xrLabel4.StylePriority.UseFont = false;
         this.xrLabel4.StylePriority.UseTextAlignment = false;
         this.xrLabel4.Text = "xrLabel4";
         this.xrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
         // 
         // xrLabel9
         // 
         this.xrLabel9.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.CreatedAt", "{0:dd/MM/yyyy \'a las\' hh:mm}")});
         this.xrLabel9.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.xrLabel9.LocationFloat = new DevExpress.Utils.PointFloat(425F, 0F);
         this.xrLabel9.Name = "xrLabel9";
         this.xrLabel9.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel9.SizeF = new System.Drawing.SizeF(155F, 23F);
         this.xrLabel9.StylePriority.UseFont = false;
         this.xrLabel9.StylePriority.UseTextAlignment = false;
         this.xrLabel9.Text = "xrLabel9";
         this.xrLabel9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
         // 
         // xrLabel8
         // 
         this.xrLabel8.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.Cost")});
         this.xrLabel8.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.xrLabel8.LocationFloat = new DevExpress.Utils.PointFloat(306.4166F, 0F);
         this.xrLabel8.Name = "xrLabel8";
         this.xrLabel8.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel8.SizeF = new System.Drawing.SizeF(100F, 23F);
         this.xrLabel8.StylePriority.UseFont = false;
         this.xrLabel8.StylePriority.UseTextAlignment = false;
         this.xrLabel8.Text = "xrLabel8";
         this.xrLabel8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
         // 
         // xrLabel7
         // 
         this.xrLabel7.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.Price")});
         this.xrLabel7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.xrLabel7.LocationFloat = new DevExpress.Utils.PointFloat(199.5833F, 0F);
         this.xrLabel7.Name = "xrLabel7";
         this.xrLabel7.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel7.SizeF = new System.Drawing.SizeF(95.66669F, 23F);
         this.xrLabel7.StylePriority.UseFont = false;
         this.xrLabel7.StylePriority.UseTextAlignment = false;
         this.xrLabel7.Text = "xrLabel7";
         this.xrLabel7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
         // 
         // xrLabel3
         // 
         this.xrLabel3.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.Name")});
         this.xrLabel3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.xrLabel3.LocationFloat = new DevExpress.Utils.PointFloat(10.00001F, 0F);
         this.xrLabel3.Name = "xrLabel3";
         this.xrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel3.SizeF = new System.Drawing.SizeF(177.0833F, 23F);
         this.xrLabel3.StylePriority.UseFont = false;
         this.xrLabel3.StylePriority.UseTextAlignment = false;
         this.xrLabel3.Text = "xrLabel3";
         this.xrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
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
         this.xrLabel2.SizeF = new System.Drawing.SizeF(630F, 23F);
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
         customSqlQuery1.Sql = "SELECT Products.*, ProductTypes.Name AS \'ProductType\'\r\nFROM Products\r\nINNER JOIN " +
    "ProductTypes ON Products.ProductTypeId = ProductTypes.Id\r\nORDER BY Products.Name" +
    " ASC";
         this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            selectQuery1,
            customSqlQuery1});
         masterDetailInfo1.DetailQueryName = "ProductTypes";
         relationColumnInfo1.NestedKeyColumn = "Id";
         relationColumnInfo1.ParentKeyColumn = "ProductTypeId";
         masterDetailInfo1.KeyColumns.Add(relationColumnInfo1);
         masterDetailInfo1.MasterQueryName = "Products";
         this.sqlDataSource1.Relations.AddRange(new DevExpress.DataAccess.Sql.MasterDetailInfo[] {
            masterDetailInfo1});
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
         this.xrLabel1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
         this.xrLabel1.ForeColor = System.Drawing.Color.Black;
         this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(10.00001F, 6.00001F);
         this.xrLabel1.Name = "xrLabel1";
         this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel1.SizeF = new System.Drawing.SizeF(630F, 26F);
         this.xrLabel1.StyleName = "Title";
         this.xrLabel1.StylePriority.UseFont = false;
         this.xrLabel1.StylePriority.UseForeColor = false;
         this.xrLabel1.StylePriority.UseTextAlignment = false;
         this.xrLabel1.Text = "Productos";
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
         // xrTableRow4
         // 
         this.xrTableRow4.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell14,
            this.xrTableCell15,
            this.xrTableCell16});
         this.xrTableRow4.Name = "xrTableRow4";
         this.xrTableRow4.Weight = 1D;
         // 
         // xrTableCell14
         // 
         this.xrTableCell14.Name = "xrTableCell14";
         this.xrTableCell14.Text = "xrTableCell14";
         this.xrTableCell14.Weight = 1D;
         // 
         // xrTableCell15
         // 
         this.xrTableCell15.Name = "xrTableCell15";
         this.xrTableCell15.Text = "xrTableCell15";
         this.xrTableCell15.Weight = 1D;
         // 
         // xrTableCell16
         // 
         this.xrTableCell16.Name = "xrTableCell16";
         this.xrTableCell16.Text = "xrTableCell16";
         this.xrTableCell16.Weight = 1D;
         // 
         // xrTableRow6
         // 
         this.xrTableRow6.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell19,
            this.xrTableCell20,
            this.xrTableCell21});
         this.xrTableRow6.Name = "xrTableRow6";
         this.xrTableRow6.Weight = 1D;
         // 
         // xrTableCell19
         // 
         this.xrTableCell19.Name = "xrTableCell19";
         this.xrTableCell19.Text = "xrTableCell19";
         this.xrTableCell19.Weight = 1D;
         // 
         // xrTableCell20
         // 
         this.xrTableCell20.Name = "xrTableCell20";
         this.xrTableCell20.Text = "xrTableCell20";
         this.xrTableCell20.Weight = 1D;
         // 
         // xrTableCell21
         // 
         this.xrTableCell21.Name = "xrTableCell21";
         this.xrTableCell21.Text = "xrTableCell21";
         this.xrTableCell21.Weight = 1D;
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
         // PageInfo
         // 
         this.PageInfo.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
         this.PageInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
         this.PageInfo.Name = "PageInfo";
         this.PageInfo.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         // 
         // GroupHeader1
         // 
         this.GroupHeader1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrPanel1});
         this.GroupHeader1.GroupFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("ProductType", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)});
         this.GroupHeader1.HeightF = 47.91667F;
         this.GroupHeader1.Name = "GroupHeader1";
         this.GroupHeader1.RepeatEveryPage = true;
         // 
         // xrPanel1
         // 
         this.xrPanel1.BackColor = System.Drawing.Color.Silver;
         this.xrPanel1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel13,
            this.xrLabel12,
            this.xrLabel11,
            this.xrLabel10,
            this.xrLabel6,
            this.xrLabel5});
         this.xrPanel1.LocationFloat = new DevExpress.Utils.PointFloat(10.00001F, 0F);
         this.xrPanel1.Name = "xrPanel1";
         this.xrPanel1.SizeF = new System.Drawing.SizeF(629.9999F, 47.91667F);
         this.xrPanel1.StylePriority.UseBackColor = false;
         // 
         // xrLabel13
         // 
         this.xrLabel13.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.xrLabel13.LocationFloat = new DevExpress.Utils.PointFloat(570.6249F, 22.99995F);
         this.xrLabel13.Name = "xrLabel13";
         this.xrLabel13.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel13.SizeF = new System.Drawing.SizeF(59.37497F, 23.00001F);
         this.xrLabel13.StylePriority.UseFont = false;
         this.xrLabel13.StylePriority.UseTextAlignment = false;
         this.xrLabel13.Text = "Activo";
         this.xrLabel13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
         // 
         // xrLabel12
         // 
         this.xrLabel12.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.xrLabel12.LocationFloat = new DevExpress.Utils.PointFloat(415F, 22.99995F);
         this.xrLabel12.Name = "xrLabel12";
         this.xrLabel12.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel12.SizeF = new System.Drawing.SizeF(88.54166F, 23.00001F);
         this.xrLabel12.StylePriority.UseFont = false;
         this.xrLabel12.StylePriority.UseTextAlignment = false;
         this.xrLabel12.Text = "Fecha alta";
         this.xrLabel12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
         // 
         // xrLabel11
         // 
         this.xrLabel11.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.xrLabel11.LocationFloat = new DevExpress.Utils.PointFloat(347.2917F, 22.99995F);
         this.xrLabel11.Name = "xrLabel11";
         this.xrLabel11.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel11.SizeF = new System.Drawing.SizeF(49.125F, 23.00001F);
         this.xrLabel11.StylePriority.UseFont = false;
         this.xrLabel11.StylePriority.UseTextAlignment = false;
         this.xrLabel11.Text = "Costo";
         this.xrLabel11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
         // 
         // xrLabel10
         // 
         this.xrLabel10.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.xrLabel10.LocationFloat = new DevExpress.Utils.PointFloat(231.9168F, 22.99995F);
         this.xrLabel10.Multiline = true;
         this.xrLabel10.Name = "xrLabel10";
         this.xrLabel10.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel10.SizeF = new System.Drawing.SizeF(53.33325F, 23.00001F);
         this.xrLabel10.StylePriority.UseFont = false;
         this.xrLabel10.StylePriority.UseTextAlignment = false;
         this.xrLabel10.Text = "Precio";
         this.xrLabel10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
         // 
         // xrLabel6
         // 
         this.xrLabel6.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.xrLabel6.LocationFloat = new DevExpress.Utils.PointFloat(0F, 22.99995F);
         this.xrLabel6.Name = "xrLabel6";
         this.xrLabel6.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel6.SizeF = new System.Drawing.SizeF(177.0833F, 23F);
         this.xrLabel6.StylePriority.UseFont = false;
         this.xrLabel6.StylePriority.UseTextAlignment = false;
         this.xrLabel6.Text = "Producto";
         this.xrLabel6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
         // 
         // xrLabel5
         // 
         this.xrLabel5.BackColor = System.Drawing.Color.Transparent;
         this.xrLabel5.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.ProductType")});
         this.xrLabel5.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
         this.xrLabel5.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
         this.xrLabel5.Name = "xrLabel5";
         this.xrLabel5.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel5.SizeF = new System.Drawing.SizeF(629.9999F, 23F);
         this.xrLabel5.StylePriority.UseBackColor = false;
         this.xrLabel5.StylePriority.UseFont = false;
         this.xrLabel5.StylePriority.UseTextAlignment = false;
         this.xrLabel5.Text = "xrLabel5";
         this.xrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
         // 
         // cfIsActive
         // 
         this.cfIsActive.DataMember = "Query";
         this.cfIsActive.Expression = "Iif([IsActive],  \'Sí\', \'No\')";
         this.cfIsActive.Name = "cfIsActive";
         // 
         // GroupFooter1
         // 
         this.GroupFooter1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel14});
         this.GroupFooter1.HeightF = 55.20833F;
         this.GroupFooter1.Name = "GroupFooter1";
         // 
         // xrLabel14
         // 
         this.xrLabel14.Borders = DevExpress.XtraPrinting.BorderSide.Top;
         this.xrLabel14.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Query.Id")});
         this.xrLabel14.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
         this.xrLabel14.LocationFloat = new DevExpress.Utils.PointFloat(6.00001F, 0F);
         this.xrLabel14.Name = "xrLabel14";
         this.xrLabel14.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
         this.xrLabel14.SizeF = new System.Drawing.SizeF(619F, 23F);
         this.xrLabel14.StylePriority.UseBorders = false;
         this.xrLabel14.StylePriority.UseFont = false;
         this.xrLabel14.StylePriority.UseTextAlignment = false;
         xrSummary1.FormatString = "Total: {0}";
         xrSummary1.Func = DevExpress.XtraReports.UI.SummaryFunc.Count;
         xrSummary1.IgnoreNullValues = true;
         xrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
         this.xrLabel14.Summary = xrSummary1;
         this.xrLabel14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
         // 
         // ProductsReport
         // 
         this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.reportHeaderBand1,
            this.GroupHeader1,
            this.GroupFooter1});
         this.CalculatedFields.AddRange(new DevExpress.XtraReports.UI.CalculatedField[] {
            this.cfIsActive});
         this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.sqlDataSource1});
         this.DataMember = "Query";
         this.DataSource = this.sqlDataSource1;
         this.Margins = new System.Drawing.Printing.Margins(100, 100, 60, 100);
         this.StyleSheet.AddRange(new DevExpress.XtraReports.UI.XRControlStyle[] {
            this.Title,
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
      private DevExpress.XtraReports.UI.XRTableRow xrTableRow4;
      private DevExpress.XtraReports.UI.XRTableCell xrTableCell14;
      private DevExpress.XtraReports.UI.XRTableCell xrTableCell15;
      private DevExpress.XtraReports.UI.XRTableCell xrTableCell16;
      private DevExpress.XtraReports.UI.XRTableRow xrTableRow6;
      private DevExpress.XtraReports.UI.XRTableCell xrTableCell19;
      private DevExpress.XtraReports.UI.XRTableCell xrTableCell20;
      private DevExpress.XtraReports.UI.XRTableCell xrTableCell21;
      private DevExpress.XtraReports.UI.XRControlStyle Title;
      private DevExpress.XtraReports.UI.XRControlStyle PageInfo;
      private DevExpress.XtraReports.UI.XRLabel xrLabel2;
      private DevExpress.XtraReports.UI.XRLabel xrLabel9;
      private DevExpress.XtraReports.UI.XRLabel xrLabel8;
      private DevExpress.XtraReports.UI.XRLabel xrLabel7;
      private DevExpress.XtraReports.UI.XRLabel xrLabel3;
      private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader1;
      private DevExpress.XtraReports.UI.XRLabel xrLabel13;
      private DevExpress.XtraReports.UI.XRLabel xrLabel12;
      private DevExpress.XtraReports.UI.XRLabel xrLabel11;
      private DevExpress.XtraReports.UI.XRLabel xrLabel10;
      private DevExpress.XtraReports.UI.XRLabel xrLabel6;
      private DevExpress.XtraReports.UI.XRLabel xrLabel5;
      private DevExpress.XtraReports.UI.CalculatedField cfIsActive;
      private DevExpress.XtraReports.UI.XRLabel xrLabel4;
      private DevExpress.XtraReports.UI.GroupFooterBand GroupFooter1;
      private DevExpress.XtraReports.UI.XRLabel xrLabel14;
      private DevExpress.XtraReports.UI.XRPanel xrPanel1;
   }
}
