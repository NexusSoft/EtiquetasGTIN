using DevExpress.DataAccess.Sql;
using DevExpress.XtraReports.UI;
using System;
using System;
using System.Linq;

namespace Etiquetas_AGV
{
    public partial class Frm_Eti_Empleados : DevExpress.XtraEditors.XtraForm
    {
        public string vPrinterName { get; private set; }
        private static Frm_Eti_Empleados m_FormDefInstance;
        public static Frm_Eti_Empleados DefInstance
        {
            get
            {
                if (m_FormDefInstance == null || m_FormDefInstance.IsDisposed)
                    m_FormDefInstance = new Frm_Eti_Empleados();
                return m_FormDefInstance;
            }
            set
            {
                m_FormDefInstance = value;
            }
        }
        public Frm_Eti_Empleados()
        {
            InitializeComponent();
        }
        public string c_codigo_usu { get; set; }
        private void btnbuscar_Click(object sender, EventArgs e)
        {
            Frm_Empleados Emp = new Frm_Empleados();
            Emp.c_codigo_usu = c_codigo_usu.Trim();
            Emp.PaSel = true;
            Emp.ShowDialog();

            textId.Text = Emp.c_codigo_emp;
            textNombre.Text = Emp.v_nombre_emp;
        }

        private void Frm_Eti_Empleados_Load(object sender, EventArgs e)
        {

        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            rpt_Etiqueta_Empleado rpt = new rpt_Etiqueta_Empleado();
            ReportPrintTool printTool = new ReportPrintTool(rpt);
            Codigos_TEC_IT.CodigosBarraEmpleados(textId.Text.ToString().Trim(),false);
            if (rdgTipoImpresion.SelectedIndex == 1)
            {
                rpt.ShowPreviewDialog();
            }
            else
            {
                int t = 0;
                for (int i = 0; i < spinEdit1.Value; i++)
                {
                    t++;
                    if (t == 1)
                    {
                        t++;
                        printTool.PrintDialog();
                        vPrinterName = printTool.PrinterSettings.PrinterName;
                    }
                    else
                    {
                        printTool.Print(vPrinterName);
                    }
                }
            }
        }
    }
}