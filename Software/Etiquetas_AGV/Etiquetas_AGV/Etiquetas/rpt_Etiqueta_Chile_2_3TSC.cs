using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace Etiquetas_AGV
{
    public partial class rpt_Etiqueta_Chile_2_3TSC : DevExpress.XtraReports.UI.XtraReport
    {
        public rpt_Etiqueta_Chile_2_3TSC(
             string c_codigo_tem, string c_codigo_pal)
        {
            InitializeComponent();
            CargarParametros(c_codigo_tem, c_codigo_pal);
        }

        private void CargarParametros(string c_codigo_tem, string c_codigo_pal)
        {
            DevExpress.DataAccess.Sql.QueryParameter queryParameter1 = new DevExpress.DataAccess.Sql.QueryParameter();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter2 = new DevExpress.DataAccess.Sql.QueryParameter();
            queryParameter1.Name = "@c_codigo_tem";
            queryParameter1.Type = typeof(string);
            queryParameter1.ValueInfo = c_codigo_tem;
            queryParameter2.Name = "@c_codigo_pal";
            queryParameter2.Type = typeof(string);
            queryParameter2.ValueInfo = c_codigo_pal;
            sqlDataSource1.Queries[0].Parameters.Clear();
            sqlDataSource1.Queries[0].Parameters.Add(queryParameter1);
            sqlDataSource1.Queries[0].Parameters.Add(queryParameter2);
        }
    }
}
