using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace Etiquetas_AGV
{
    public partial class rpt_Etiqueta_EuropaFRHOMIMEX : DevExpress.XtraReports.UI.XtraReport
    {
        public string c_codigo_imp { get; set; }
        public rpt_Etiqueta_EuropaFRHOMIMEX()
        {
            InitializeComponent();
            DevExpress.DataAccess.Sql.QueryParameter queryParameter1 = new DevExpress.DataAccess.Sql.QueryParameter();
            queryParameter1.Name = "@c_codigo_imp";
            queryParameter1.Type = typeof(string);
            queryParameter1.ValueInfo = c_codigo_imp;
            sqlDataSource1.Queries[0].Parameters.Clear();
            sqlDataSource1.Queries[0].Parameters.Add(queryParameter1);
        }
    }
}
