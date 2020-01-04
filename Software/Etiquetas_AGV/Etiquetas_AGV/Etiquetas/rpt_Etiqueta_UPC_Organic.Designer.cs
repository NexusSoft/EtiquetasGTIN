namespace Etiquetas_AGV
{
    partial class rpt_Etiqueta_UPC_Organic
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
            DevExpress.DataAccess.Sql.StoredProcQuery storedProcQuery1 = new DevExpress.DataAccess.Sql.StoredProcQuery();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter1 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter2 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter3 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter4 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter5 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter6 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter7 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter8 = new DevExpress.DataAccess.Sql.QueryParameter();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rpt_Etiqueta_UPC_Organic));
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.xrControlStyle1 = new DevExpress.XtraReports.UI.XRControlStyle();
            this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
            this.xrLabel19 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrPictureBox3 = new DevExpress.XtraReports.UI.XRPictureBox();
            this.xrLabel10 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel17 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel15 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel18 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel14 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel13 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel12 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel11 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel9 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel8 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel5 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel6 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel16 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrPictureBox2 = new DevExpress.XtraReports.UI.XRPictureBox();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel4 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrPictureBox1 = new DevExpress.XtraReports.UI.XRPictureBox();
            this.xrLabel7 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
            this.calculatedField1 = new DevExpress.XtraReports.UI.CalculatedField();
            this.calculatedField2 = new DevExpress.XtraReports.UI.CalculatedField();
            this.COC = new DevExpress.XtraReports.Parameters.Parameter();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.HeightF = 0F;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // TopMargin
            // 
            this.TopMargin.HeightF = 2F;
            this.TopMargin.Name = "TopMargin";
            this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // BottomMargin
            // 
            this.BottomMargin.HeightF = 3.000005F;
            this.BottomMargin.Name = "BottomMargin";
            this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "Etiquetas_AGV_Connection2";
            this.sqlDataSource1.Name = "sqlDataSource1";
            storedProcQuery1.Name = "SP_Eti_EtiquetaUPC_Select";
            queryParameter1.Name = "@c_codigo_tem";
            queryParameter1.Type = typeof(string);
            queryParameter1.ValueInfo = "09";
            queryParameter2.Name = "@c_codigo_pal";
            queryParameter2.Type = typeof(string);
            queryParameter2.ValueInfo = "059746";
            queryParameter3.Name = "@c_codsec_pal";
            queryParameter3.Type = typeof(string);
            queryParameter3.ValueInfo = "01";
            queryParameter4.Name = "@c_codigo_dis";
            queryParameter4.Type = typeof(string);
            queryParameter4.ValueInfo = "000240";
            queryParameter5.Name = "@c_codigo_sec";
            queryParameter5.Type = typeof(string);
            queryParameter5.ValueInfo = "001";
            queryParameter6.Name = "@voice1";
            queryParameter6.Type = typeof(string);
            queryParameter6.ValueInfo = "74";
            queryParameter7.Name = "@voice2";
            queryParameter7.Type = typeof(string);
            queryParameter7.ValueInfo = "24";
            queryParameter8.Name = "@c_codigo_jul";
            queryParameter8.Type = typeof(string);
            queryParameter8.ValueInfo = "12345678";
            storedProcQuery1.Parameters.Add(queryParameter1);
            storedProcQuery1.Parameters.Add(queryParameter2);
            storedProcQuery1.Parameters.Add(queryParameter3);
            storedProcQuery1.Parameters.Add(queryParameter4);
            storedProcQuery1.Parameters.Add(queryParameter5);
            storedProcQuery1.Parameters.Add(queryParameter6);
            storedProcQuery1.Parameters.Add(queryParameter7);
            storedProcQuery1.Parameters.Add(queryParameter8);
            storedProcQuery1.StoredProcName = "SP_Eti_EtiquetaUPC_Select";
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            storedProcQuery1});
            this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
            // 
            // xrControlStyle1
            // 
            this.xrControlStyle1.Name = "xrControlStyle1";
            // 
            // ReportHeader
            // 
            this.ReportHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel19,
            this.xrPictureBox3,
            this.xrLabel10,
            this.xrLabel17,
            this.xrLabel15,
            this.xrLabel18,
            this.xrLabel14,
            this.xrLabel13,
            this.xrLabel12,
            this.xrLabel11,
            this.xrLabel9,
            this.xrLabel8,
            this.xrLabel5,
            this.xrLabel3,
            this.xrLabel6,
            this.xrLabel16,
            this.xrPictureBox2,
            this.xrLabel1,
            this.xrLabel4,
            this.xrPictureBox1,
            this.xrLabel7,
            this.xrLabel2});
            this.ReportHeader.HeightF = 224.125F;
            this.ReportHeader.Name = "ReportHeader";
            this.ReportHeader.StylePriority.UseFont = false;
            this.ReportHeader.StylePriority.UseTextAlignment = false;
            this.ReportHeader.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel19
            // 
            this.xrLabel19.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[Parameters].[COC]")});
            this.xrLabel19.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.xrLabel19.LocationFloat = new DevExpress.Utils.PointFloat(10.0001F, 202.3717F);
            this.xrLabel19.Name = "xrLabel19";
            this.xrLabel19.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel19.SizeF = new System.Drawing.SizeF(202.08F, 18F);
            this.xrLabel19.StylePriority.UseFont = false;
            this.xrLabel19.Text = "xrLabel19";
            // 
            // xrPictureBox3
            // 
            this.xrPictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("xrPictureBox3.Image")));
            this.xrPictureBox3.LocationFloat = new DevExpress.Utils.PointFloat(269.7899F, 72.50013F);
            this.xrPictureBox3.Name = "xrPictureBox3";
            this.xrPictureBox3.SizeF = new System.Drawing.SizeF(52.04F, 55F);
            this.xrPictureBox3.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage;
            // 
            // xrLabel10
            // 
            this.xrLabel10.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[SP_Eti_EtiquetaUPC_Select].[LOT]")});
            this.xrLabel10.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold);
            this.xrLabel10.LocationFloat = new DevExpress.Utils.PointFloat(10.00001F, 92.1669F);
            this.xrLabel10.Name = "xrLabel10";
            this.xrLabel10.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel10.SizeF = new System.Drawing.SizeF(129.2499F, 14F);
            this.xrLabel10.StylePriority.UseFont = false;
            this.xrLabel10.Text = "xrLabel10";
            // 
            // xrLabel17
            // 
            this.xrLabel17.CanGrow = false;
            this.xrLabel17.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[SP_Eti_EtiquetaUPC_Select].[c_codigo_upc]")});
            this.xrLabel17.LocationFloat = new DevExpress.Utils.PointFloat(139.2499F, 100.9967F);
            this.xrLabel17.Name = "xrLabel17";
            this.xrLabel17.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel17.SizeF = new System.Drawing.SizeF(120.5383F, 12F);
            this.xrLabel17.StylePriority.UseTextAlignment = false;
            this.xrLabel17.Text = "xrLabel17";
            this.xrLabel17.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrLabel17.WordWrap = false;
            // 
            // xrLabel15
            // 
            this.xrLabel15.CanGrow = false;
            this.xrLabel15.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[SP_Eti_EtiquetaUPC_Select].[v_nomext_cul]")});
            this.xrLabel15.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.xrLabel15.LocationFloat = new DevExpress.Utils.PointFloat(9.99999F, 112.9967F);
            this.xrLabel15.Name = "xrLabel15";
            this.xrLabel15.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel15.SizeF = new System.Drawing.SizeF(233.33F, 16F);
            this.xrLabel15.StylePriority.UseFont = false;
            this.xrLabel15.Text = "xrLabel15";
            this.xrLabel15.WordWrap = false;
            // 
            // xrLabel18
            // 
            this.xrLabel18.LocationFloat = new DevExpress.Utils.PointFloat(321.8301F, 114.9967F);
            this.xrLabel18.Name = "xrLabel18";
            this.xrLabel18.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel18.SizeF = new System.Drawing.SizeF(76.16992F, 16.75005F);
            this.xrLabel18.StylePriority.UseTextAlignment = false;
            this.xrLabel18.Text = "Pack Date";
            this.xrLabel18.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel14
            // 
            this.xrLabel14.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[SP_Eti_EtiquetaUPC_Select].[calculatedField2]")});
            this.xrLabel14.LocationFloat = new DevExpress.Utils.PointFloat(321.83F, 131.7467F);
            this.xrLabel14.Name = "xrLabel14";
            this.xrLabel14.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel14.SizeF = new System.Drawing.SizeF(76.17F, 15F);
            this.xrLabel14.StylePriority.UseTextAlignment = false;
            this.xrLabel14.Text = "xrLabel14";
            this.xrLabel14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel13
            // 
            this.xrLabel13.CanGrow = false;
            this.xrLabel13.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[SP_Eti_EtiquetaUPC_Select].[v_codext_pro]")});
            this.xrLabel13.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.xrLabel13.LocationFloat = new DevExpress.Utils.PointFloat(9.999847F, 128.9967F);
            this.xrLabel13.Name = "xrLabel13";
            this.xrLabel13.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel13.SizeF = new System.Drawing.SizeF(311.8301F, 15F);
            this.xrLabel13.StylePriority.UseFont = false;
            this.xrLabel13.StylePriority.UseTextAlignment = false;
            this.xrLabel13.Text = "xrLabel13";
            this.xrLabel13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrLabel13.WordWrap = false;
            // 
            // xrLabel12
            // 
            this.xrLabel12.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel12.LocationFloat = new DevExpress.Utils.PointFloat(9.999847F, 143.9967F);
            this.xrLabel12.Name = "xrLabel12";
            this.xrLabel12.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel12.SizeF = new System.Drawing.SizeF(311.83F, 16F);
            this.xrLabel12.StylePriority.UseFont = false;
            this.xrLabel12.StylePriority.UseTextAlignment = false;
            this.xrLabel12.Text = "PRODUCT OF MEXICO";
            this.xrLabel12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrLabel11
            // 
            this.xrLabel11.CanGrow = false;
            this.xrLabel11.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[SP_Eti_EtiquetaUPC_Select].[v_nombre_dis]")});
            this.xrLabel11.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold);
            this.xrLabel11.LocationFloat = new DevExpress.Utils.PointFloat(105.8317F, 162.7467F);
            this.xrLabel11.Name = "xrLabel11";
            this.xrLabel11.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel11.SizeF = new System.Drawing.SizeF(215.9983F, 11.99998F);
            this.xrLabel11.StylePriority.UseFont = false;
            this.xrLabel11.StylePriority.UseTextAlignment = false;
            this.xrLabel11.Text = "xrLabel11";
            this.xrLabel11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrLabel11.WordWrap = false;
            // 
            // xrLabel9
            // 
            this.xrLabel9.CanGrow = false;
            this.xrLabel9.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrLabel9.LocationFloat = new DevExpress.Utils.PointFloat(9.99999F, 160.7467F);
            this.xrLabel9.Name = "xrLabel9";
            this.xrLabel9.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel9.SizeF = new System.Drawing.SizeF(95.83168F, 12F);
            this.xrLabel9.StylePriority.UseFont = false;
            this.xrLabel9.StylePriority.UseTextAlignment = false;
            this.xrLabel9.Text = "Distributed by:";
            this.xrLabel9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrLabel9.WordWrap = false;
            // 
            // xrLabel8
            // 
            this.xrLabel8.BackColor = System.Drawing.Color.Black;
            this.xrLabel8.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[SP_Eti_EtiquetaUPC_Select].[Voice2]")});
            this.xrLabel8.Font = new System.Drawing.Font("Times New Roman", 18F);
            this.xrLabel8.ForeColor = System.Drawing.Color.White;
            this.xrLabel8.LocationFloat = new DevExpress.Utils.PointFloat(351.8301F, 146.7467F);
            this.xrLabel8.Name = "xrLabel8";
            this.xrLabel8.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel8.SizeF = new System.Drawing.SizeF(45.17F, 35F);
            this.xrLabel8.StylePriority.UseBackColor = false;
            this.xrLabel8.StylePriority.UseFont = false;
            this.xrLabel8.StylePriority.UseForeColor = false;
            this.xrLabel8.StylePriority.UseTextAlignment = false;
            this.xrLabel8.Text = "xrLabel8";
            this.xrLabel8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrLabel8.WordWrap = false;
            // 
            // xrLabel5
            // 
            this.xrLabel5.BackColor = System.Drawing.Color.Black;
            this.xrLabel5.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[SP_Eti_EtiquetaUPC_Select].[Voice1]")});
            this.xrLabel5.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.xrLabel5.ForeColor = System.Drawing.Color.White;
            this.xrLabel5.LocationFloat = new DevExpress.Utils.PointFloat(321.8301F, 146.7467F);
            this.xrLabel5.Name = "xrLabel5";
            this.xrLabel5.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel5.SizeF = new System.Drawing.SizeF(30F, 35F);
            this.xrLabel5.StylePriority.UseBackColor = false;
            this.xrLabel5.StylePriority.UseFont = false;
            this.xrLabel5.StylePriority.UseForeColor = false;
            this.xrLabel5.StylePriority.UseTextAlignment = false;
            this.xrLabel5.Text = "xrLabel5";
            this.xrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.xrLabel5.WordWrap = false;
            // 
            // xrLabel3
            // 
            this.xrLabel3.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[SP_Eti_EtiquetaUPC_Select].[v_nombre_pem]")});
            this.xrLabel3.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold);
            this.xrLabel3.LocationFloat = new DevExpress.Utils.PointFloat(74.6666F, 175.4967F);
            this.xrLabel3.Name = "xrLabel3";
            this.xrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel3.SizeF = new System.Drawing.SizeF(234.7933F, 10.50002F);
            this.xrLabel3.StylePriority.UseFont = false;
            this.xrLabel3.Text = "xrLabel3";
            // 
            // xrLabel6
            // 
            this.xrLabel6.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.xrLabel6.LocationFloat = new DevExpress.Utils.PointFloat(9.99999F, 175.4967F);
            this.xrLabel6.Name = "xrLabel6";
            this.xrLabel6.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel6.SizeF = new System.Drawing.SizeF(64F, 10.5F);
            this.xrLabel6.StylePriority.UseFont = false;
            this.xrLabel6.StylePriority.UseTextAlignment = false;
            this.xrLabel6.Text = "Packed by:";
            this.xrLabel6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrLabel6.WordWrap = false;
            // 
            // xrLabel16
            // 
            this.xrLabel16.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel16.LocationFloat = new DevExpress.Utils.PointFloat(10.00001F, 78.1669F);
            this.xrLabel16.Name = "xrLabel16";
            this.xrLabel16.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel16.SizeF = new System.Drawing.SizeF(76.49997F, 14F);
            this.xrLabel16.StylePriority.UseFont = false;
            this.xrLabel16.StylePriority.UseTextAlignment = false;
            this.xrLabel16.Text = "Trace Code:";
            this.xrLabel16.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrPictureBox2
            // 
            this.xrPictureBox2.ImageUrl = "C:\\Etiquetas\\CodeBarUPC.bmp";
            this.xrPictureBox2.LocationFloat = new DevExpress.Utils.PointFloat(139.2499F, 62.50013F);
            this.xrPictureBox2.Name = "xrPictureBox2";
            this.xrPictureBox2.SizeF = new System.Drawing.SizeF(120.54F, 38F);
            this.xrPictureBox2.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage;
            // 
            // xrLabel1
            // 
            this.xrLabel1.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[SP_Eti_EtiquetaUPC_Select].[calculatedField1]")});
            this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(10.00001F, 43.66681F);
            this.xrLabel1.Name = "xrLabel1";
            this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel1.SizeF = new System.Drawing.SizeF(381.0001F, 18.83332F);
            this.xrLabel1.StylePriority.UseTextAlignment = false;
            this.xrLabel1.Text = "xrLabel1";
            this.xrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel4
            // 
            this.xrLabel4.CanGrow = false;
            this.xrLabel4.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold);
            this.xrLabel4.LocationFloat = new DevExpress.Utils.PointFloat(9.999847F, 186.3717F);
            this.xrLabel4.Multiline = true;
            this.xrLabel4.Name = "xrLabel4";
            this.xrLabel4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel4.SizeF = new System.Drawing.SizeF(299.46F, 16F);
            this.xrLabel4.StylePriority.UseFont = false;
            this.xrLabel4.StylePriority.UseTextAlignment = false;
            this.xrLabel4.Text = "Calle Delicias  No 100. col. Jicalan , Uruapan Michoacan";
            this.xrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrPictureBox1
            // 
            this.xrPictureBox1.ImageUrl = "C:\\Etiquetas\\CodeBar128.bmp";
            this.xrPictureBox1.LocationFloat = new DevExpress.Utils.PointFloat(10.00001F, 0F);
            this.xrPictureBox1.Name = "xrPictureBox1";
            this.xrPictureBox1.SizeF = new System.Drawing.SizeF(383.0017F, 43.66681F);
            this.xrPictureBox1.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage;
            // 
            // xrLabel7
            // 
            this.xrLabel7.CanGrow = false;
            this.xrLabel7.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel7.LocationFloat = new DevExpress.Utils.PointFloat(309.4599F, 182.2467F);
            this.xrLabel7.Name = "xrLabel7";
            this.xrLabel7.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel7.SizeF = new System.Drawing.SizeF(88.54013F, 18.83333F);
            this.xrLabel7.StylePriority.UseFont = false;
            this.xrLabel7.StylePriority.UseTextAlignment = false;
            this.xrLabel7.Text = "EMP.089";
            this.xrLabel7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.xrLabel7.WordWrap = false;
            // 
            // xrLabel2
            // 
            this.xrLabel2.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[SP_Eti_EtiquetaUPC_Select].[v_registro_hue]")});
            this.xrLabel2.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold);
            this.xrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(212.0832F, 203.205F);
            this.xrLabel2.Name = "xrLabel2";
            this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel2.SizeF = new System.Drawing.SizeF(185.9166F, 20.91997F);
            this.xrLabel2.StylePriority.UseFont = false;
            this.xrLabel2.StylePriority.UseTextAlignment = false;
            this.xrLabel2.Text = "xrLabel2";
            this.xrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // calculatedField1
            // 
            this.calculatedField1.DataMember = "SP_Eti_EtiquetaUPC_Select";
            this.calculatedField1.Expression = "\'(01)\'+[gtin]+\'(10)\'+[c_codigo_sel]+\'(13)\'+[fecha]";
            this.calculatedField1.Name = "calculatedField1";
            // 
            // calculatedField2
            // 
            this.calculatedField2.DataMember = "SP_Eti_EtiquetaUPC_Select";
            this.calculatedField2.Expression = "[mes]+\' \'+[dia]+\', \'+[c_anio]";
            this.calculatedField2.Name = "calculatedField2";
            // 
            // COC
            // 
            this.COC.Description = "Cadena de Custodia";
            this.COC.Name = "COC";
            this.COC.ValueInfo = "COC: 4052852027427";
            // 
            // rpt_Etiqueta_UPC_Organic
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.ReportHeader});
            this.CalculatedFields.AddRange(new DevExpress.XtraReports.UI.CalculatedField[] {
            this.calculatedField1,
            this.calculatedField2});
            this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.sqlDataSource1});
            this.DataSource = this.sqlDataSource1;
            this.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.Margins = new System.Drawing.Printing.Margins(10, 5, 2, 3);
            this.PageHeight = 250;
            this.PageWidth = 414;
            this.PaperKind = System.Drawing.Printing.PaperKind.Custom;
            this.PaperName = "A6";
            this.Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {
            this.COC});
            this.StyleSheet.AddRange(new DevExpress.XtraReports.UI.XRControlStyle[] {
            this.xrControlStyle1});
            this.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.Version = "17.2";
            this.DesignerLoaded += new DevExpress.XtraReports.UserDesigner.DesignerLoadedEventHandler(this.rpt_Etiqueta_UPC_Organic_DesignerLoaded);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private DevExpress.XtraReports.UI.XRControlStyle xrControlStyle1;
        private DevExpress.XtraReports.UI.ReportHeaderBand ReportHeader;
        private DevExpress.XtraReports.UI.XRLabel xrLabel2;
        private DevExpress.XtraReports.UI.XRLabel xrLabel7;
        private DevExpress.XtraReports.UI.XRPictureBox xrPictureBox1;
        private DevExpress.XtraReports.UI.XRLabel xrLabel4;
        private DevExpress.XtraReports.UI.XRLabel xrLabel1;
        private DevExpress.XtraReports.UI.CalculatedField calculatedField1;
        private DevExpress.XtraReports.UI.XRPictureBox xrPictureBox2;
        private DevExpress.XtraReports.UI.XRLabel xrLabel16;
        private DevExpress.XtraReports.UI.XRLabel xrLabel6;
        private DevExpress.XtraReports.UI.XRLabel xrLabel8;
        private DevExpress.XtraReports.UI.XRLabel xrLabel5;
        private DevExpress.XtraReports.UI.XRLabel xrLabel3;
        private DevExpress.XtraReports.UI.XRLabel xrLabel9;
        private DevExpress.XtraReports.UI.XRLabel xrLabel11;
        private DevExpress.XtraReports.UI.XRLabel xrLabel12;
        private DevExpress.XtraReports.UI.XRLabel xrLabel13;
        private DevExpress.XtraReports.UI.XRLabel xrLabel14;
        private DevExpress.XtraReports.UI.CalculatedField calculatedField2;
        private DevExpress.XtraReports.UI.XRLabel xrLabel18;
        private DevExpress.XtraReports.UI.XRLabel xrLabel17;
        private DevExpress.XtraReports.UI.XRLabel xrLabel15;
        private DevExpress.XtraReports.UI.XRLabel xrLabel10;
        private DevExpress.XtraReports.UI.XRPictureBox xrPictureBox3;
        private DevExpress.XtraReports.UI.XRLabel xrLabel19;
        private DevExpress.XtraReports.Parameters.Parameter COC;
    }
}
