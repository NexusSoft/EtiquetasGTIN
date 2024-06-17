using DevExpress.XtraBars;
using Etiquetas_AGV.Formularios.Rendimiento;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Etiquetas_AGV
{
    public partial class Frm_Rendimiento : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public string UsuariosLogin { get; set; }
        internal string c_codigo_usu;
        public Frm_Rendimiento()
        {
            InitializeComponent();
        }

        private void btnEmpleados_ItemClick(object sender, ItemClickEventArgs e)
        {
            Frm_Empleados Ventana = new Frm_Empleados();
            Frm_Empleados.DefInstance.MdiParent = this;
            Frm_Empleados.DefInstance.c_codigo_usu = c_codigo_usu;
            Frm_Empleados.DefInstance.Show();
        }

        private void btnPuestos_ItemClick(object sender, ItemClickEventArgs e)
        {
            Frm_Puestos Ventana = new Frm_Puestos();
            Frm_Puestos.DefInstance.MdiParent = this;
            Frm_Puestos.DefInstance.c_codigo_usu = c_codigo_usu;
            Frm_Puestos.DefInstance.Show();
        }

        private void btnEtiquetas_ItemClick(object sender, ItemClickEventArgs e)
        {
            Frm_Eti_Empleados Ventana = new Frm_Eti_Empleados();
            Frm_Eti_Empleados.DefInstance.MdiParent = this;
            Frm_Eti_Empleados.DefInstance.c_codigo_usu = c_codigo_usu;
            Frm_Eti_Empleados.DefInstance.Show();
        }

        private void Frm_Rendimiento_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void btnRendimientoDia_ItemClick(object sender, ItemClickEventArgs e)
        {
            Frm_Reporte_Rendimiento Ventana = new Frm_Reporte_Rendimiento();
            Frm_Reporte_Rendimiento.DefInstance.MdiParent = this;
            Frm_Reporte_Rendimiento.DefInstance.c_codigo_usu = c_codigo_usu;
            Frm_Reporte_Rendimiento.DefInstance.Show();
        }

        private void btnEmpleadoBono_ItemClick(object sender, ItemClickEventArgs e)
        {
            Frm_EmpleadosBono Ventana = new Frm_EmpleadosBono();
            Frm_EmpleadosBono.DefInstance.MdiParent = this;
            Frm_EmpleadosBono.DefInstance.c_codigo_usu = c_codigo_usu;
            Frm_EmpleadosBono.DefInstance.Show();
        }

        private void btn_Avisos_Configuraciones_ItemClick(object sender, ItemClickEventArgs e)
        {
            Frm_Avisos Ventana = new Frm_Avisos();
            Frm_Avisos.DefInstance.MdiParent = this;
            Frm_Avisos.DefInstance.c_codigo_usu = c_codigo_usu;
            Frm_Avisos.DefInstance.Show();
        }
    }
}