using DevExpress.XtraPrinting.BarCode;

namespace Etiquetas_AGV
{
    partial class rpt_Etiqueta_Dubai
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rpt_Etiqueta_Dubai));
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.sqlDataSource1 = new DevExpress.DataAccess.Sql.SqlDataSource(this.components);
            this.xrControlStyle1 = new DevExpress.XtraReports.UI.XRControlStyle();
            this.calculatedField1 = new DevExpress.XtraReports.UI.CalculatedField();
            this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
            this.calculatedField2 = new DevExpress.XtraReports.UI.CalculatedField();
            this.COC = new DevExpress.XtraReports.Parameters.Parameter();
            this.COCGest = new DevExpress.XtraReports.Parameters.Parameter();
            this.xrLabel6 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel4 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel5 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel7 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel8 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel9 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel10 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel11 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel12 = new DevExpress.XtraReports.UI.XRLabel();
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
            this.xrLabel23 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel24 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel25 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel26 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel27 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel28 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel29 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel30 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel31 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel32 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel33 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel34 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel35 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel36 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel37 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel38 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel39 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel40 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel42 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel43 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel44 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel45 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel46 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel47 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel48 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel49 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel50 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel41 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel51 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel52 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel53 = new DevExpress.XtraReports.UI.XRLabel();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Expanded = false;
            this.Detail.HeightF = 0F;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.Detail.Visible = false;
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
            this.BottomMargin.HeightF = 1F;
            this.BottomMargin.Name = "BottomMargin";
            this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // sqlDataSource1
            // 
            this.sqlDataSource1.ConnectionName = "Etiquetas_AGV_Connection2";
            this.sqlDataSource1.Name = "sqlDataSource1";
            storedProcQuery1.MetaSerializable = "<Meta X=\"20\" Y=\"20\" Width=\"100\" Height=\"615\" />";
            storedProcQuery1.Name = "SP_Eti_EtiquetaHEB_Select";
            queryParameter1.Name = "@c_codigo_tem";
            queryParameter1.Type = typeof(string);
            queryParameter1.ValueInfo = "09";
            queryParameter2.Name = "@c_codigo_pal";
            queryParameter2.Type = typeof(string);
            queryParameter2.ValueInfo = "035853";
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
            queryParameter6.ValueInfo = "20";
            queryParameter7.Name = "@voice2";
            queryParameter7.Type = typeof(string);
            queryParameter7.ValueInfo = "66";
            queryParameter8.Name = "@c_codigo_jul";
            queryParameter8.Type = typeof(string);
            storedProcQuery1.Parameters.AddRange(new DevExpress.DataAccess.Sql.QueryParameter[] {
            queryParameter1,
            queryParameter2,
            queryParameter3,
            queryParameter4,
            queryParameter5,
            queryParameter6,
            queryParameter7,
            queryParameter8});
            storedProcQuery1.StoredProcName = "SP_Eti_EtiquetaHEB_Select";
            this.sqlDataSource1.Queries.AddRange(new DevExpress.DataAccess.Sql.SqlQuery[] {
            storedProcQuery1});
            this.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable");
            // 
            // xrControlStyle1
            // 
            this.xrControlStyle1.Name = "xrControlStyle1";
            this.xrControlStyle1.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            // 
            // calculatedField1
            // 
            this.calculatedField1.DataMember = "SP_Eti_EtiquetaHEB_Select";
            this.calculatedField1.Expression = "[mes]+\' \'+[dia]+\', \'+[c_anio]";
            this.calculatedField1.Name = "calculatedField1";
            // 
            // ReportHeader
            // 
            this.ReportHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel53,
            this.xrLabel52,
            this.xrLabel51,
            this.xrLabel41,
            this.xrLabel50,
            this.xrLabel49,
            this.xrLabel47,
            this.xrLabel48,
            this.xrLabel45,
            this.xrLabel46,
            this.xrLabel43,
            this.xrLabel44,
            this.xrLabel42,
            this.xrLabel39,
            this.xrLabel40,
            this.xrLabel37,
            this.xrLabel38,
            this.xrLabel35,
            this.xrLabel36,
            this.xrLabel33,
            this.xrLabel34,
            this.xrLabel31,
            this.xrLabel32,
            this.xrLabel29,
            this.xrLabel30,
            this.xrLabel28,
            this.xrLabel27,
            this.xrLabel26,
            this.xrLabel25,
            this.xrLabel24,
            this.xrLabel23,
            this.xrLabel22,
            this.xrLabel21,
            this.xrLabel20,
            this.xrLabel19,
            this.xrLabel18,
            this.xrLabel17,
            this.xrLabel16,
            this.xrLabel15,
            this.xrLabel14,
            this.xrLabel13,
            this.xrLabel12,
            this.xrLabel11,
            this.xrLabel10,
            this.xrLabel9,
            this.xrLabel8,
            this.xrLabel7,
            this.xrLabel5,
            this.xrLabel4,
            this.xrLabel3,
            this.xrLabel2,
            this.xrLabel1,
            this.xrLabel6});
            this.ReportHeader.HeightF = 221.1916F;
            this.ReportHeader.KeepTogether = true;
            this.ReportHeader.Name = "ReportHeader";
            // 
            // calculatedField2
            // 
            this.calculatedField2.DataMember = "SP_Eti_EtiquetaHEB_Select";
            this.calculatedField2.Expression = "\'(01)\'+[gtin]+\'(10)\'+[c_codigo_sel]+\'(13)\'+[fecha]";
            this.calculatedField2.Name = "calculatedField2";
            // 
            // COC
            // 
            this.COC.Description = "Cadena de Custodia";
            this.COC.Name = "COC";
            this.COC.ValueInfo = "CoC: 4052852027427";
            // 
            // COCGest
            // 
            this.COCGest.Description = "Cadena de Custodia";
            this.COCGest.Name = "COCGest";
            this.COCGest.ValueInfo = "CoC: 4063651273854";
            // 
            // xrLabel6
            // 
            this.xrLabel6.Font = new DevExpress.Drawing.DXFont("Times New Roman", 8F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrLabel6.LocationFloat = new DevExpress.Utils.PointFloat(9.999999F, 0F);
            this.xrLabel6.Name = "xrLabel6";
            this.xrLabel6.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel6.SizeF = new System.Drawing.SizeF(380F, 14F);
            this.xrLabel6.StylePriority.UseFont = false;
            this.xrLabel6.StylePriority.UseTextAlignment = false;
            this.xrLabel6.Text = "EMPAQUE DE MANGOS DEL PACIFICO";
            this.xrLabel6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel1
            // 
            this.xrLabel1.Font = new DevExpress.Drawing.DXFont("Times New Roman", 8F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(9.999999F, 14.00002F);
            this.xrLabel1.Name = "xrLabel1";
            this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel1.SizeF = new System.Drawing.SizeF(74.16666F, 14F);
            this.xrLabel1.StylePriority.UseFont = false;
            this.xrLabel1.StylePriority.UseTextAlignment = false;
            this.xrLabel1.Text = "Produced By :";
            this.xrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel2
            // 
            this.xrLabel2.Font = new DevExpress.Drawing.DXFont("Times New Roman", 8F);
            this.xrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(86.66665F, 14.00002F);
            this.xrLabel2.Name = "xrLabel2";
            this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel2.SizeF = new System.Drawing.SizeF(203.3333F, 14F);
            this.xrLabel2.StylePriority.UseFont = false;
            this.xrLabel2.StylePriority.UseTextAlignment = false;
            this.xrLabel2.Text = "EMPAQUE DE MANGOS DEL PACIFICO";
            this.xrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel3
            // 
            this.xrLabel3.Font = new DevExpress.Drawing.DXFont("Times New Roman", 8F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrLabel3.LocationFloat = new DevExpress.Utils.PointFloat(330F, 14.00001F);
            this.xrLabel3.Name = "xrLabel3";
            this.xrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel3.SizeF = new System.Drawing.SizeF(60.00003F, 14F);
            this.xrLabel3.StylePriority.UseFont = false;
            this.xrLabel3.StylePriority.UseTextAlignment = false;
            this.xrLabel3.Text = "انتاج شركة";
            this.xrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // xrLabel4
            // 
            this.xrLabel4.Font = new DevExpress.Drawing.DXFont("Times New Roman", 8F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrLabel4.LocationFloat = new DevExpress.Utils.PointFloat(9.999999F, 28.00001F);
            this.xrLabel4.Name = "xrLabel4";
            this.xrLabel4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel4.SizeF = new System.Drawing.SizeF(74.16666F, 14F);
            this.xrLabel4.StylePriority.UseFont = false;
            this.xrLabel4.StylePriority.UseTextAlignment = false;
            this.xrLabel4.Text = "Product :";
            this.xrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel5
            // 
            this.xrLabel5.Font = new DevExpress.Drawing.DXFont("Times New Roman", 8F);
            this.xrLabel5.LocationFloat = new DevExpress.Utils.PointFloat(86.66665F, 28.00001F);
            this.xrLabel5.Name = "xrLabel5";
            this.xrLabel5.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel5.SizeF = new System.Drawing.SizeF(106.6666F, 14F);
            this.xrLabel5.StylePriority.UseFont = false;
            this.xrLabel5.StylePriority.UseTextAlignment = false;
            this.xrLabel5.Text = "AVOCADOS FRESH";
            this.xrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel7
            // 
            this.xrLabel7.Font = new DevExpress.Drawing.DXFont("Times New Roman", 8F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrLabel7.LocationFloat = new DevExpress.Utils.PointFloat(223.3333F, 28.00001F);
            this.xrLabel7.Name = "xrLabel7";
            this.xrLabel7.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel7.SizeF = new System.Drawing.SizeF(54.16666F, 14F);
            this.xrLabel7.StylePriority.UseFont = false;
            this.xrLabel7.StylePriority.UseTextAlignment = false;
            this.xrLabel7.Text = "افوكادو طازج";
            this.xrLabel7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // xrLabel8
            // 
            this.xrLabel8.Font = new DevExpress.Drawing.DXFont("Times New Roman", 8F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrLabel8.LocationFloat = new DevExpress.Utils.PointFloat(330F, 28.00001F);
            this.xrLabel8.Name = "xrLabel8";
            this.xrLabel8.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel8.SizeF = new System.Drawing.SizeF(60F, 14F);
            this.xrLabel8.StylePriority.UseFont = false;
            this.xrLabel8.StylePriority.UseTextAlignment = false;
            this.xrLabel8.Text = "المنتج";
            this.xrLabel8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // xrLabel9
            // 
            this.xrLabel9.Font = new DevExpress.Drawing.DXFont("Times New Roman", 7F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrLabel9.LocationFloat = new DevExpress.Utils.PointFloat(9.999999F, 42F);
            this.xrLabel9.Name = "xrLabel9";
            this.xrLabel9.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel9.SizeF = new System.Drawing.SizeF(74.16666F, 14F);
            this.xrLabel9.StylePriority.UseFont = false;
            this.xrLabel9.StylePriority.UseTextAlignment = false;
            this.xrLabel9.Text = "Quality Grade :";
            this.xrLabel9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel10
            // 
            this.xrLabel10.Font = new DevExpress.Drawing.DXFont("Times New Roman", 8F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrLabel10.LocationFloat = new DevExpress.Utils.PointFloat(9.999999F, 56F);
            this.xrLabel10.Name = "xrLabel10";
            this.xrLabel10.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel10.SizeF = new System.Drawing.SizeF(60.83333F, 14F);
            this.xrLabel10.StylePriority.UseFont = false;
            this.xrLabel10.StylePriority.UseTextAlignment = false;
            this.xrLabel10.Text = "Exporter :";
            this.xrLabel10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel11
            // 
            this.xrLabel11.Font = new DevExpress.Drawing.DXFont("Times New Roman", 8F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrLabel11.LocationFloat = new DevExpress.Utils.PointFloat(10.00001F, 70.00001F);
            this.xrLabel11.Name = "xrLabel11";
            this.xrLabel11.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel11.SizeF = new System.Drawing.SizeF(87.49996F, 14.00001F);
            this.xrLabel11.StylePriority.UseFont = false;
            this.xrLabel11.StylePriority.UseTextAlignment = false;
            this.xrLabel11.Text = "Gross Weight :";
            this.xrLabel11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel12
            // 
            this.xrLabel12.Font = new DevExpress.Drawing.DXFont("Times New Roman", 8F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrLabel12.LocationFloat = new DevExpress.Utils.PointFloat(9.999999F, 84.00002F);
            this.xrLabel12.Name = "xrLabel12";
            this.xrLabel12.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel12.SizeF = new System.Drawing.SizeF(74.16666F, 14F);
            this.xrLabel12.StylePriority.UseFont = false;
            this.xrLabel12.StylePriority.UseTextAlignment = false;
            this.xrLabel12.Text = "Net Weight  :";
            this.xrLabel12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel13
            // 
            this.xrLabel13.Font = new DevExpress.Drawing.DXFont("Times New Roman", 8F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrLabel13.LocationFloat = new DevExpress.Utils.PointFloat(10.00001F, 98.00001F);
            this.xrLabel13.Name = "xrLabel13";
            this.xrLabel13.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel13.SizeF = new System.Drawing.SizeF(74.16666F, 14F);
            this.xrLabel13.StylePriority.UseFont = false;
            this.xrLabel13.StylePriority.UseTextAlignment = false;
            this.xrLabel13.Text = "Count :";
            this.xrLabel13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel14
            // 
            this.xrLabel14.Font = new DevExpress.Drawing.DXFont("Times New Roman", 8F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrLabel14.LocationFloat = new DevExpress.Utils.PointFloat(9.999999F, 112F);
            this.xrLabel14.Name = "xrLabel14";
            this.xrLabel14.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel14.SizeF = new System.Drawing.SizeF(100F, 14.00001F);
            this.xrLabel14.StylePriority.UseFont = false;
            this.xrLabel14.StylePriority.UseTextAlignment = false;
            this.xrLabel14.Text = "Country of Origin :";
            this.xrLabel14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel15
            // 
            this.xrLabel15.Font = new DevExpress.Drawing.DXFont("Times New Roman", 6F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrLabel15.LocationFloat = new DevExpress.Utils.PointFloat(9.999999F, 126F);
            this.xrLabel15.Name = "xrLabel15";
            this.xrLabel15.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel15.SizeF = new System.Drawing.SizeF(76.66666F, 14F);
            this.xrLabel15.StylePriority.UseFont = false;
            this.xrLabel15.StylePriority.UseTextAlignment = false;
            this.xrLabel15.Text = "Storage Instruction:";
            this.xrLabel15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel16
            // 
            this.xrLabel16.Font = new DevExpress.Drawing.DXFont("Times New Roman", 8F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrLabel16.LocationFloat = new DevExpress.Utils.PointFloat(10.00001F, 155.1916F);
            this.xrLabel16.Name = "xrLabel16";
            this.xrLabel16.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel16.SizeF = new System.Drawing.SizeF(68.33316F, 14F);
            this.xrLabel16.StylePriority.UseFont = false;
            this.xrLabel16.StylePriority.UseTextAlignment = false;
            this.xrLabel16.Text = "Importer:";
            this.xrLabel16.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel17
            // 
            this.xrLabel17.Font = new DevExpress.Drawing.DXFont("Times New Roman", 8F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrLabel17.LocationFloat = new DevExpress.Utils.PointFloat(9.999999F, 169.1916F);
            this.xrLabel17.Name = "xrLabel17";
            this.xrLabel17.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel17.SizeF = new System.Drawing.SizeF(86.66666F, 14F);
            this.xrLabel17.StylePriority.UseFont = false;
            this.xrLabel17.StylePriority.UseTextAlignment = false;
            this.xrLabel17.Text = "Date of Packing:";
            this.xrLabel17.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel18
            // 
            this.xrLabel18.Font = new DevExpress.Drawing.DXFont("Times New Roman", 8F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrLabel18.LocationFloat = new DevExpress.Utils.PointFloat(9.166809F, 183.1916F);
            this.xrLabel18.Name = "xrLabel18";
            this.xrLabel18.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel18.SizeF = new System.Drawing.SizeF(74.16666F, 14F);
            this.xrLabel18.StylePriority.UseFont = false;
            this.xrLabel18.StylePriority.UseTextAlignment = false;
            this.xrLabel18.Text = "Expiry Date:";
            this.xrLabel18.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel19
            // 
            this.xrLabel19.Font = new DevExpress.Drawing.DXFont("Times New Roman", 8F);
            this.xrLabel19.LocationFloat = new DevExpress.Utils.PointFloat(86.66665F, 42F);
            this.xrLabel19.Name = "xrLabel19";
            this.xrLabel19.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel19.SizeF = new System.Drawing.SizeF(106.6666F, 14F);
            this.xrLabel19.StylePriority.UseFont = false;
            this.xrLabel19.StylePriority.UseTextAlignment = false;
            this.xrLabel19.Text = "CAT 1";
            this.xrLabel19.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel20
            // 
            this.xrLabel20.Font = new DevExpress.Drawing.DXFont("Times New Roman", 6F);
            this.xrLabel20.LocationFloat = new DevExpress.Utils.PointFloat(74.16666F, 56.00004F);
            this.xrLabel20.Name = "xrLabel20";
            this.xrLabel20.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel20.SizeF = new System.Drawing.SizeF(156.9442F, 14F);
            this.xrLabel20.StylePriority.UseFont = false;
            this.xrLabel20.StylePriority.UseTextAlignment = false;
            this.xrLabel20.Text = "EMPAQUE DE MANGOS DEL PACIFICO";
            this.xrLabel20.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel21
            // 
            this.xrLabel21.Font = new DevExpress.Drawing.DXFont("Times New Roman", 8F);
            this.xrLabel21.LocationFloat = new DevExpress.Utils.PointFloat(99.99995F, 70.00003F);
            this.xrLabel21.Name = "xrLabel21";
            this.xrLabel21.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel21.SizeF = new System.Drawing.SizeF(106.6666F, 14F);
            this.xrLabel21.StylePriority.UseFont = false;
            this.xrLabel21.StylePriority.UseTextAlignment = false;
            this.xrLabel21.Text = "11.3 KG";
            this.xrLabel21.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel22
            // 
            this.xrLabel22.Font = new DevExpress.Drawing.DXFont("Times New Roman", 8F);
            this.xrLabel22.LocationFloat = new DevExpress.Utils.PointFloat(100F, 84.00002F);
            this.xrLabel22.Name = "xrLabel22";
            this.xrLabel22.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel22.SizeF = new System.Drawing.SizeF(106.6666F, 14F);
            this.xrLabel22.StylePriority.UseFont = false;
            this.xrLabel22.StylePriority.UseTextAlignment = false;
            this.xrLabel22.Text = "10 KG";
            this.xrLabel22.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel23
            // 
            this.xrLabel23.Font = new DevExpress.Drawing.DXFont("Times New Roman", 8F);
            this.xrLabel23.LocationFloat = new DevExpress.Utils.PointFloat(84.16666F, 98.00001F);
            this.xrLabel23.Name = "xrLabel23";
            this.xrLabel23.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel23.SizeF = new System.Drawing.SizeF(106.6666F, 14F);
            this.xrLabel23.StylePriority.UseFont = false;
            this.xrLabel23.StylePriority.UseTextAlignment = false;
            this.xrLabel23.Text = "48-60";
            this.xrLabel23.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel24
            // 
            this.xrLabel24.Font = new DevExpress.Drawing.DXFont("Times New Roman", 8F);
            this.xrLabel24.LocationFloat = new DevExpress.Utils.PointFloat(116.6667F, 112F);
            this.xrLabel24.Name = "xrLabel24";
            this.xrLabel24.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel24.SizeF = new System.Drawing.SizeF(106.6666F, 14F);
            this.xrLabel24.StylePriority.UseFont = false;
            this.xrLabel24.StylePriority.UseTextAlignment = false;
            this.xrLabel24.Text = "MEXICO";
            this.xrLabel24.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel25
            // 
            this.xrLabel25.Font = new DevExpress.Drawing.DXFont("Times New Roman", 6F);
            this.xrLabel25.LocationFloat = new DevExpress.Utils.PointFloat(86.66665F, 126F);
            this.xrLabel25.Name = "xrLabel25";
            this.xrLabel25.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel25.SizeF = new System.Drawing.SizeF(136.6666F, 14F);
            this.xrLabel25.StylePriority.UseFont = false;
            this.xrLabel25.StylePriority.UseTextAlignment = false;
            this.xrLabel25.Text = "STORE IN COLD PLACE 4 to 10 °C";
            this.xrLabel25.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel26
            // 
            this.xrLabel26.Font = new DevExpress.Drawing.DXFont("Times New Roman", 8F);
            this.xrLabel26.LocationFloat = new DevExpress.Utils.PointFloat(78.33317F, 155.1916F);
            this.xrLabel26.Name = "xrLabel26";
            this.xrLabel26.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel26.SizeF = new System.Drawing.SizeF(119.1666F, 14F);
            this.xrLabel26.StylePriority.UseFont = false;
            this.xrLabel26.StylePriority.UseTextAlignment = false;
            this.xrLabel26.Text = "Salah A AL Amoudi Est";
            this.xrLabel26.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel27
            // 
            this.xrLabel27.Font = new DevExpress.Drawing.DXFont("Times New Roman", 8F);
            this.xrLabel27.LocationFloat = new DevExpress.Utils.PointFloat(96.66666F, 169.1916F);
            this.xrLabel27.Name = "xrLabel27";
            this.xrLabel27.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel27.SizeF = new System.Drawing.SizeF(45.55555F, 14.00002F);
            this.xrLabel27.StylePriority.UseFont = false;
            this.xrLabel27.StylePriority.UseTextAlignment = false;
            this.xrLabel27.Text = "04-Nov";
            this.xrLabel27.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel28
            // 
            this.xrLabel28.Font = new DevExpress.Drawing.DXFont("Times New Roman", 6F);
            this.xrLabel28.LocationFloat = new DevExpress.Utils.PointFloat(83.33346F, 183.1916F);
            this.xrLabel28.Name = "xrLabel28";
            this.xrLabel28.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel28.SizeF = new System.Drawing.SizeF(123.3331F, 14F);
            this.xrLabel28.StylePriority.UseFont = false;
            this.xrLabel28.StylePriority.UseTextAlignment = false;
            this.xrLabel28.Text = "60 days from the date of packing";
            this.xrLabel28.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel29
            // 
            this.xrLabel29.Font = new DevExpress.Drawing.DXFont("Times New Roman", 8F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrLabel29.LocationFloat = new DevExpress.Utils.PointFloat(223.3333F, 42F);
            this.xrLabel29.Name = "xrLabel29";
            this.xrLabel29.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel29.SizeF = new System.Drawing.SizeF(54.16666F, 14F);
            this.xrLabel29.StylePriority.UseFont = false;
            this.xrLabel29.StylePriority.UseTextAlignment = false;
            this.xrLabel29.Text = "اولى";
            this.xrLabel29.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // xrLabel30
            // 
            this.xrLabel30.Font = new DevExpress.Drawing.DXFont("Times New Roman", 8F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrLabel30.LocationFloat = new DevExpress.Utils.PointFloat(330F, 42F);
            this.xrLabel30.Name = "xrLabel30";
            this.xrLabel30.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel30.SizeF = new System.Drawing.SizeF(60.00003F, 14F);
            this.xrLabel30.StylePriority.UseFont = false;
            this.xrLabel30.StylePriority.UseTextAlignment = false;
            this.xrLabel30.Text = "درجة الجودة";
            this.xrLabel30.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // xrLabel31
            // 
            this.xrLabel31.Font = new DevExpress.Drawing.DXFont("Times New Roman", 8F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrLabel31.LocationFloat = new DevExpress.Utils.PointFloat(231.6667F, 55.99997F);
            this.xrLabel31.Name = "xrLabel31";
            this.xrLabel31.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel31.SizeF = new System.Drawing.SizeF(104.1667F, 14F);
            this.xrLabel31.StylePriority.UseFont = false;
            this.xrLabel31.StylePriority.UseTextAlignment = false;
            this.xrLabel31.Text = "إمباك بيريبان إس دي آر إل";
            this.xrLabel31.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // xrLabel32
            // 
            this.xrLabel32.Font = new DevExpress.Drawing.DXFont("Times New Roman", 8F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrLabel32.LocationFloat = new DevExpress.Utils.PointFloat(335.8333F, 55.99997F);
            this.xrLabel32.Name = "xrLabel32";
            this.xrLabel32.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel32.SizeF = new System.Drawing.SizeF(54.16666F, 14F);
            this.xrLabel32.StylePriority.UseFont = false;
            this.xrLabel32.StylePriority.UseTextAlignment = false;
            this.xrLabel32.Text = "المصدر";
            this.xrLabel32.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // xrLabel33
            // 
            this.xrLabel33.Font = new DevExpress.Drawing.DXFont("Times New Roman", 8F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrLabel33.LocationFloat = new DevExpress.Utils.PointFloat(223.3333F, 69.99998F);
            this.xrLabel33.Name = "xrLabel33";
            this.xrLabel33.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel33.SizeF = new System.Drawing.SizeF(54.16669F, 14F);
            this.xrLabel33.StylePriority.UseFont = false;
            this.xrLabel33.StylePriority.UseTextAlignment = false;
            this.xrLabel33.Text = "     كيلوغرام";
            this.xrLabel33.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // xrLabel34
            // 
            this.xrLabel34.Font = new DevExpress.Drawing.DXFont("Times New Roman", 8F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrLabel34.LocationFloat = new DevExpress.Utils.PointFloat(330F, 69.99998F);
            this.xrLabel34.Name = "xrLabel34";
            this.xrLabel34.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel34.SizeF = new System.Drawing.SizeF(60F, 14F);
            this.xrLabel34.StylePriority.UseFont = false;
            this.xrLabel34.StylePriority.UseTextAlignment = false;
            this.xrLabel34.Text = "الوزن الإجمالي";
            this.xrLabel34.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // xrLabel35
            // 
            this.xrLabel35.Font = new DevExpress.Drawing.DXFont("Times New Roman", 8F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrLabel35.LocationFloat = new DevExpress.Utils.PointFloat(223.3333F, 83.99996F);
            this.xrLabel35.Name = "xrLabel35";
            this.xrLabel35.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel35.SizeF = new System.Drawing.SizeF(54.16666F, 14F);
            this.xrLabel35.StylePriority.UseFont = false;
            this.xrLabel35.StylePriority.UseTextAlignment = false;
            this.xrLabel35.Text = " كيلوغرام";
            this.xrLabel35.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // xrLabel36
            // 
            this.xrLabel36.Font = new DevExpress.Drawing.DXFont("Times New Roman", 8F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrLabel36.LocationFloat = new DevExpress.Utils.PointFloat(330F, 83.99997F);
            this.xrLabel36.Name = "xrLabel36";
            this.xrLabel36.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel36.SizeF = new System.Drawing.SizeF(60.00003F, 13.99999F);
            this.xrLabel36.StylePriority.UseFont = false;
            this.xrLabel36.StylePriority.UseTextAlignment = false;
            this.xrLabel36.Text = "الوزن الصافي";
            this.xrLabel36.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // xrLabel37
            // 
            this.xrLabel37.Font = new DevExpress.Drawing.DXFont("Times New Roman", 8F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrLabel37.LocationFloat = new DevExpress.Utils.PointFloat(223.3333F, 97.99995F);
            this.xrLabel37.Name = "xrLabel37";
            this.xrLabel37.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel37.SizeF = new System.Drawing.SizeF(54.16666F, 14F);
            this.xrLabel37.StylePriority.UseFont = false;
            this.xrLabel37.StylePriority.UseTextAlignment = false;
            this.xrLabel37.Text = "48-60 قطعة";
            this.xrLabel37.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // xrLabel38
            // 
            this.xrLabel38.Font = new DevExpress.Drawing.DXFont("Times New Roman", 8F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrLabel38.LocationFloat = new DevExpress.Utils.PointFloat(335.8333F, 97.99995F);
            this.xrLabel38.Name = "xrLabel38";
            this.xrLabel38.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel38.SizeF = new System.Drawing.SizeF(54.16666F, 14F);
            this.xrLabel38.StylePriority.UseFont = false;
            this.xrLabel38.StylePriority.UseTextAlignment = false;
            this.xrLabel38.Text = "العدد";
            this.xrLabel38.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // xrLabel39
            // 
            this.xrLabel39.Font = new DevExpress.Drawing.DXFont("Times New Roman", 8F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrLabel39.LocationFloat = new DevExpress.Utils.PointFloat(223.3333F, 112F);
            this.xrLabel39.Name = "xrLabel39";
            this.xrLabel39.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel39.SizeF = new System.Drawing.SizeF(54.16666F, 14F);
            this.xrLabel39.StylePriority.UseFont = false;
            this.xrLabel39.StylePriority.UseTextAlignment = false;
            this.xrLabel39.Text = "المكسيك";
            this.xrLabel39.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // xrLabel40
            // 
            this.xrLabel40.Font = new DevExpress.Drawing.DXFont("Times New Roman", 8F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrLabel40.LocationFloat = new DevExpress.Utils.PointFloat(335.8333F, 112F);
            this.xrLabel40.Name = "xrLabel40";
            this.xrLabel40.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel40.SizeF = new System.Drawing.SizeF(54.16666F, 14F);
            this.xrLabel40.StylePriority.UseFont = false;
            this.xrLabel40.StylePriority.UseTextAlignment = false;
            this.xrLabel40.Text = "بلد المنشأ";
            this.xrLabel40.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // xrLabel42
            // 
            this.xrLabel42.Font = new DevExpress.Drawing.DXFont("Times New Roman", 7F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrLabel42.LocationFloat = new DevExpress.Utils.PointFloat(330F, 141.1916F);
            this.xrLabel42.Name = "xrLabel42";
            this.xrLabel42.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel42.SizeF = new System.Drawing.SizeF(60F, 14.00002F);
            this.xrLabel42.StylePriority.UseFont = false;
            this.xrLabel42.StylePriority.UseTextAlignment = false;
            this.xrLabel42.Text = "تعليمات التخزين";
            this.xrLabel42.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // xrLabel43
            // 
            this.xrLabel43.Font = new DevExpress.Drawing.DXFont("Times New Roman", 7F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrLabel43.LocationFloat = new DevExpress.Utils.PointFloat(197.4998F, 155.1916F);
            this.xrLabel43.Name = "xrLabel43";
            this.xrLabel43.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel43.SizeF = new System.Drawing.SizeF(146.6667F, 14.00002F);
            this.xrLabel43.StylePriority.UseFont = false;
            this.xrLabel43.StylePriority.UseTextAlignment = false;
            this.xrLabel43.Text = "مؤسسة صلاح عبدالرحمن العمودي للتجاره";
            this.xrLabel43.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // xrLabel44
            // 
            this.xrLabel44.Font = new DevExpress.Drawing.DXFont("Times New Roman", 8F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrLabel44.LocationFloat = new DevExpress.Utils.PointFloat(345.8334F, 155.1916F);
            this.xrLabel44.Name = "xrLabel44";
            this.xrLabel44.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel44.SizeF = new System.Drawing.SizeF(44.16663F, 14.00003F);
            this.xrLabel44.StylePriority.UseFont = false;
            this.xrLabel44.StylePriority.UseTextAlignment = false;
            this.xrLabel44.Text = "المستورد:";
            this.xrLabel44.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // xrLabel45
            // 
            this.xrLabel45.Font = new DevExpress.Drawing.DXFont("Times New Roman", 8F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrLabel45.LocationFloat = new DevExpress.Utils.PointFloat(193.3333F, 169.1916F);
            this.xrLabel45.Name = "xrLabel45";
            this.xrLabel45.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel45.SizeF = new System.Drawing.SizeF(47.77768F, 14F);
            this.xrLabel45.StylePriority.UseFont = false;
            this.xrLabel45.StylePriority.UseTextAlignment = false;
            this.xrLabel45.Text = "04-Nov";
            this.xrLabel45.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // xrLabel46
            // 
            this.xrLabel46.Font = new DevExpress.Drawing.DXFont("Times New Roman", 8F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrLabel46.LocationFloat = new DevExpress.Utils.PointFloat(317.4999F, 169.1916F);
            this.xrLabel46.Name = "xrLabel46";
            this.xrLabel46.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel46.SizeF = new System.Drawing.SizeF(72.50009F, 14F);
            this.xrLabel46.StylePriority.UseFont = false;
            this.xrLabel46.StylePriority.UseTextAlignment = false;
            this.xrLabel46.Text = "تاريخ التعبئة:";
            this.xrLabel46.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // xrLabel47
            // 
            this.xrLabel47.Font = new DevExpress.Drawing.DXFont("Times New Roman", 8F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrLabel47.LocationFloat = new DevExpress.Utils.PointFloat(224.4444F, 183.1916F);
            this.xrLabel47.Name = "xrLabel47";
            this.xrLabel47.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel47.SizeF = new System.Drawing.SizeF(79.16663F, 14F);
            this.xrLabel47.StylePriority.UseFont = false;
            this.xrLabel47.StylePriority.UseTextAlignment = false;
            this.xrLabel47.Text = "يوم من تاريخ التعبئه";
            this.xrLabel47.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // xrLabel48
            // 
            this.xrLabel48.Font = new DevExpress.Drawing.DXFont("Times New Roman", 8F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrLabel48.LocationFloat = new DevExpress.Utils.PointFloat(303.611F, 183.1916F);
            this.xrLabel48.Name = "xrLabel48";
            this.xrLabel48.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel48.SizeF = new System.Drawing.SizeF(86.38898F, 14F);
            this.xrLabel48.StylePriority.UseFont = false;
            this.xrLabel48.StylePriority.UseTextAlignment = false;
            this.xrLabel48.Text = "تاريخ انتهاء الصلاحية:";
            this.xrLabel48.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // xrLabel49
            // 
            this.xrLabel49.Font = new DevExpress.Drawing.DXFont("Times New Roman", 8F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrLabel49.LocationFloat = new DevExpress.Utils.PointFloat(277.4999F, 84.00002F);
            this.xrLabel49.Name = "xrLabel49";
            this.xrLabel49.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel49.SizeF = new System.Drawing.SizeF(42.77777F, 14F);
            this.xrLabel49.StylePriority.UseFont = false;
            this.xrLabel49.StylePriority.UseTextAlignment = false;
            this.xrLabel49.Text = "10";
            this.xrLabel49.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel50
            // 
            this.xrLabel50.Font = new DevExpress.Drawing.DXFont("Times New Roman", 8F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrLabel50.LocationFloat = new DevExpress.Utils.PointFloat(277.5F, 69.99998F);
            this.xrLabel50.Name = "xrLabel50";
            this.xrLabel50.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel50.SizeF = new System.Drawing.SizeF(49.99997F, 14F);
            this.xrLabel50.StylePriority.UseFont = false;
            this.xrLabel50.StylePriority.UseTextAlignment = false;
            this.xrLabel50.Text = "11.30";
            this.xrLabel50.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel41
            // 
            this.xrLabel41.Font = new DevExpress.Drawing.DXFont("Times New Roman", 7F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrLabel41.LocationFloat = new DevExpress.Utils.PointFloat(187.4997F, 141.1916F);
            this.xrLabel41.Name = "xrLabel41";
            this.xrLabel41.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel41.SizeF = new System.Drawing.SizeF(43.61115F, 14F);
            this.xrLabel41.StylePriority.UseFont = false;
            this.xrLabel41.StylePriority.UseTextAlignment = false;
            this.xrLabel41.Text = "درجة مئوية";
            this.xrLabel41.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // xrLabel51
            // 
            this.xrLabel51.Font = new DevExpress.Drawing.DXFont("Times New Roman", 6F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrLabel51.LocationFloat = new DevExpress.Utils.PointFloat(231.1109F, 141.1916F);
            this.xrLabel51.Name = "xrLabel51";
            this.xrLabel51.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel51.SizeF = new System.Drawing.SizeF(13.33337F, 14F);
            this.xrLabel51.StylePriority.UseFont = false;
            this.xrLabel51.StylePriority.UseTextAlignment = false;
            this.xrLabel51.Text = "10";
            this.xrLabel51.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // xrLabel52
            // 
            this.xrLabel52.Font = new DevExpress.Drawing.DXFont("Times New Roman", 7F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrLabel52.LocationFloat = new DevExpress.Utils.PointFloat(244.4443F, 141.1916F);
            this.xrLabel52.Name = "xrLabel52";
            this.xrLabel52.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel52.SizeF = new System.Drawing.SizeF(85.55569F, 14F);
            this.xrLabel52.StylePriority.UseFont = false;
            this.xrLabel52.StylePriority.UseTextAlignment = false;
            this.xrLabel52.Text = "يحفظ في درجة حرارة اقل من";
            this.xrLabel52.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // xrLabel53
            // 
            this.xrLabel53.Font = new DevExpress.Drawing.DXFont("Times New Roman", 8F, DevExpress.Drawing.DXFontStyle.Bold);
            this.xrLabel53.LocationFloat = new DevExpress.Utils.PointFloat(206.6667F, 183.1916F);
            this.xrLabel53.Name = "xrLabel53";
            this.xrLabel53.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel53.SizeF = new System.Drawing.SizeF(17.77777F, 14F);
            this.xrLabel53.StylePriority.UseFont = false;
            this.xrLabel53.StylePriority.UseTextAlignment = false;
            this.xrLabel53.Text = "60";
            this.xrLabel53.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // rpt_Etiqueta_Dubai
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
            this.DataMember = "SP_Eti_EtiquetaHEB_Select";
            this.DataSource = this.sqlDataSource1;
            this.Font = new DevExpress.Drawing.DXFont("Times New Roman", 9F);
            this.Margins = new DevExpress.Drawing.DXMargins(6F, 7F, 2F, 1F);
            this.PageHeight = 250;
            this.PageWidth = 413;
            this.PaperKind = DevExpress.Drawing.Printing.DXPaperKind.Custom;
            this.PaperName = "A6";
            this.ParameterPanelLayoutItems.AddRange(new DevExpress.XtraReports.Parameters.ParameterPanelLayoutItem[] {
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.COC, DevExpress.XtraReports.Parameters.Orientation.Horizontal),
            new DevExpress.XtraReports.Parameters.ParameterLayoutItem(this.COCGest, DevExpress.XtraReports.Parameters.Orientation.Horizontal)});
            this.Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {
            this.COC,
            this.COCGest});
            this.StyleSheet.AddRange(new DevExpress.XtraReports.UI.XRControlStyle[] {
            this.xrControlStyle1});
            this.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.Version = "23.1";
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.DataAccess.Sql.SqlDataSource sqlDataSource1;
        private DevExpress.XtraReports.UI.XRControlStyle xrControlStyle1;
        private DevExpress.XtraReports.UI.CalculatedField calculatedField1;
        private DevExpress.XtraReports.UI.ReportHeaderBand ReportHeader;
        private DevExpress.XtraReports.UI.CalculatedField calculatedField2;
        private DevExpress.XtraReports.Parameters.Parameter COC;
        private DevExpress.XtraReports.Parameters.Parameter COCGest;
        private DevExpress.XtraReports.UI.XRLabel xrLabel6;
        private DevExpress.XtraReports.UI.XRLabel xrLabel1;
        private DevExpress.XtraReports.UI.XRLabel xrLabel4;
        private DevExpress.XtraReports.UI.XRLabel xrLabel3;
        private DevExpress.XtraReports.UI.XRLabel xrLabel2;
        private DevExpress.XtraReports.UI.XRLabel xrLabel47;
        private DevExpress.XtraReports.UI.XRLabel xrLabel48;
        private DevExpress.XtraReports.UI.XRLabel xrLabel45;
        private DevExpress.XtraReports.UI.XRLabel xrLabel46;
        private DevExpress.XtraReports.UI.XRLabel xrLabel43;
        private DevExpress.XtraReports.UI.XRLabel xrLabel44;
        private DevExpress.XtraReports.UI.XRLabel xrLabel42;
        private DevExpress.XtraReports.UI.XRLabel xrLabel39;
        private DevExpress.XtraReports.UI.XRLabel xrLabel40;
        private DevExpress.XtraReports.UI.XRLabel xrLabel37;
        private DevExpress.XtraReports.UI.XRLabel xrLabel38;
        private DevExpress.XtraReports.UI.XRLabel xrLabel35;
        private DevExpress.XtraReports.UI.XRLabel xrLabel36;
        private DevExpress.XtraReports.UI.XRLabel xrLabel33;
        private DevExpress.XtraReports.UI.XRLabel xrLabel34;
        private DevExpress.XtraReports.UI.XRLabel xrLabel31;
        private DevExpress.XtraReports.UI.XRLabel xrLabel32;
        private DevExpress.XtraReports.UI.XRLabel xrLabel29;
        private DevExpress.XtraReports.UI.XRLabel xrLabel30;
        private DevExpress.XtraReports.UI.XRLabel xrLabel28;
        private DevExpress.XtraReports.UI.XRLabel xrLabel27;
        private DevExpress.XtraReports.UI.XRLabel xrLabel26;
        private DevExpress.XtraReports.UI.XRLabel xrLabel25;
        private DevExpress.XtraReports.UI.XRLabel xrLabel24;
        private DevExpress.XtraReports.UI.XRLabel xrLabel23;
        private DevExpress.XtraReports.UI.XRLabel xrLabel22;
        private DevExpress.XtraReports.UI.XRLabel xrLabel21;
        private DevExpress.XtraReports.UI.XRLabel xrLabel20;
        private DevExpress.XtraReports.UI.XRLabel xrLabel19;
        private DevExpress.XtraReports.UI.XRLabel xrLabel18;
        private DevExpress.XtraReports.UI.XRLabel xrLabel17;
        private DevExpress.XtraReports.UI.XRLabel xrLabel16;
        private DevExpress.XtraReports.UI.XRLabel xrLabel15;
        private DevExpress.XtraReports.UI.XRLabel xrLabel14;
        private DevExpress.XtraReports.UI.XRLabel xrLabel13;
        private DevExpress.XtraReports.UI.XRLabel xrLabel12;
        private DevExpress.XtraReports.UI.XRLabel xrLabel11;
        private DevExpress.XtraReports.UI.XRLabel xrLabel10;
        private DevExpress.XtraReports.UI.XRLabel xrLabel9;
        private DevExpress.XtraReports.UI.XRLabel xrLabel8;
        private DevExpress.XtraReports.UI.XRLabel xrLabel7;
        private DevExpress.XtraReports.UI.XRLabel xrLabel5;
        private DevExpress.XtraReports.UI.XRLabel xrLabel49;
        private DevExpress.XtraReports.UI.XRLabel xrLabel53;
        private DevExpress.XtraReports.UI.XRLabel xrLabel52;
        private DevExpress.XtraReports.UI.XRLabel xrLabel51;
        private DevExpress.XtraReports.UI.XRLabel xrLabel41;
        private DevExpress.XtraReports.UI.XRLabel xrLabel50;
    }
}
