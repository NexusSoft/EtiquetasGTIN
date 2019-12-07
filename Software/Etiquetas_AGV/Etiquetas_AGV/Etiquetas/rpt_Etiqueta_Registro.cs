using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace Etiquetas_AGV
{
    public partial class rpt_Etiqueta_Registro : DevExpress.XtraReports.UI.XtraReport
    {
        public rpt_Etiqueta_Registro(string c_codigo_hue)
        {
            InitializeComponent();
            this.c_codigo_hue.ValueInfo = c_codigo_hue;
        }

    }
}
