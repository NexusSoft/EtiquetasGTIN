using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace Etiquetas_AGV
{
    public partial class rpt_Etiqueta_Maquila_USDA : DevExpress.XtraReports.UI.XtraReport
    {
        public string c_codigo_dis { get; set; } 
        
        public rpt_Etiqueta_Maquila_USDA()
        {
            //c_codigo_jul = string.Empty;
            InitializeComponent();
            CargarParametros();
        }

        public void CargarParametros()
        {
            DevExpress.DataAccess.Sql.QueryParameter queryParameter1 = new DevExpress.DataAccess.Sql.QueryParameter();
            queryParameter1.Name = "@c_codigo_dis";
            queryParameter1.Type = typeof(string);
            queryParameter1.ValueInfo = c_codigo_dis;
            
            sqlDataSource1.Queries[0].Parameters.Clear();
            sqlDataSource1.Queries[0].Parameters.Add(queryParameter1);
        }
    }
}
