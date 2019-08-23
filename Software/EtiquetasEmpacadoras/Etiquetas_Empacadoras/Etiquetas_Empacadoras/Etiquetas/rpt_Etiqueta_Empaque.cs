using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace Etiquetas_Empacadoras
{
    public partial class rpt_Etiqueta_Empaque : DevExpress.XtraReports.UI.XtraReport
    {
        public rpt_Etiqueta_Empaque(string c_codigo_emp)
        {
            InitializeComponent();
            this.c_codigo_emp.Value = c_codigo_emp;
        }
    }
}
