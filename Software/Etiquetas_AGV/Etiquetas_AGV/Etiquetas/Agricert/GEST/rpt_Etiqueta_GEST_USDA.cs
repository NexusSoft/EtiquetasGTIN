using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace Etiquetas_AGV
{
    public partial class rpt_Etiqueta_GEST_USDA : DevExpress.XtraReports.UI.XtraReport
    {

        public string c_codigo_tem { get; set; }
        public string c_codigo_pal { get; set; }
        public string c_codsec_pal { get; set; }
        public string c_codigo_dis { get; set; }
        public string c_codigo_sec { get; set; }
        public string voice1 { get; set; }
        public string voice2 { get; set; }
        public string c_codigo_jul { get; set; }
        public Boolean plu { get; set; }
        public rpt_Etiqueta_GEST_USDA()
        {
            //c_codigo_jul = string.Empty;
            InitializeComponent();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter1 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter2 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter3 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter4 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter5 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter6 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter7 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter8 = new DevExpress.DataAccess.Sql.QueryParameter();
            queryParameter1.Name = "@c_codigo_tem";
            queryParameter1.Type = typeof(string);
            queryParameter1.ValueInfo = c_codigo_tem;
            queryParameter2.Name = "@c_codigo_pal";
            queryParameter2.Type = typeof(string);
            queryParameter2.ValueInfo = c_codigo_pal;
            queryParameter3.Name = "@c_codsec_pal";
            queryParameter3.Type = typeof(string);
            queryParameter3.ValueInfo = c_codsec_pal;
            queryParameter4.Name = "@c_codigo_dis";
            queryParameter4.Type = typeof(string);
            queryParameter4.ValueInfo = c_codigo_dis;
            queryParameter5.Name = "@c_codigo_sec";
            queryParameter5.Type = typeof(string);
            queryParameter5.ValueInfo = c_codigo_sec;
            queryParameter6.Name = "@voice1";
            queryParameter6.Type = typeof(string);
            queryParameter6.ValueInfo = voice1;
            queryParameter7.Name = "@voice2";
            queryParameter7.Type = typeof(string);
            queryParameter7.ValueInfo = voice2;
            queryParameter8.Name = "@c_codigo_jul";
            queryParameter8.Type = typeof(string);
            queryParameter8.ValueInfo = c_codigo_jul;
            sqlDataSource1.Queries[0].Parameters.Clear();
            sqlDataSource1.Queries[0].Parameters.Add(queryParameter1);
            sqlDataSource1.Queries[0].Parameters.Add(queryParameter2);
            sqlDataSource1.Queries[0].Parameters.Add(queryParameter3);
            sqlDataSource1.Queries[0].Parameters.Add(queryParameter4);
            sqlDataSource1.Queries[0].Parameters.Add(queryParameter5);
            sqlDataSource1.Queries[0].Parameters.Add(queryParameter6);
            sqlDataSource1.Queries[0].Parameters.Add(queryParameter7);
            sqlDataSource1.Queries[0].Parameters.Add(queryParameter8);
            xrPictureBox1.ImageUrl = "C:\\Etiquetas\\CodeBar128Juliana.bmp";
        }
        private void rpt_Etiqueta_UPC_DesignerLoaded(object sender, DevExpress.XtraReports.UserDesigner.DesignerLoadedEventArgs e)
        {
            xrPictureBox1.ImageUrl = "C:\\Etiquetas\\CodeBar128Juliana.bmp";
        }
    }
}
