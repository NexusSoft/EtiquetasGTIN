using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using GridControlEditCBMultipleSelection;
using CapaDeDatos;
using DevExpress.XtraGrid;

namespace Etiquetas_Empacadoras
{
    public partial class Frm_Empleados_Listar : DevExpress.XtraEditors.XtraForm
    {
        GridControlCheckMarksSelection gridCheckMarksPalets;
        public string CadenaCodigos { get; set; }
        StringBuilder sb = new StringBuilder();
        public Frm_Empleados_Listar()
        {
            InitializeComponent();
        }
        private void GridMultiplePalets()
        {
            gridCheckMarksPalets = new GridControlCheckMarksSelection(dtgValEmpleados);
            gridCheckMarksPalets.SelectionChanged += gridCheckMarksAcuerdos_SelectionChanged;
        }
        void gridCheckMarksAcuerdos_SelectionChanged(object sender, EventArgs e)
        {
            CadenaCodigos = string.Empty;
            if (ActiveControl is GridControl)
            {

                foreach (DataRowView rv in (sender as GridControlCheckMarksSelection).selection)
                {
                    if (sb.ToString().Length > 0) { sb.Append(", "); }
                    sb.AppendFormat("{0}", rv["c_codigo_emp"]);

                    if (CadenaCodigos != string.Empty)
                    {
                        CadenaCodigos = string.Format("{0},{1}", CadenaCodigos, rv["c_codigo_emp"]);
                    }
                    else
                    {
                        CadenaCodigos = rv["c_codigo_emp"].ToString();
                    }
                }
            }
            if (CadenaCodigos == string.Empty)
            {
                btnAgregar.Enabled = false;
            }
            else
            {
                btnAgregar.Enabled = true;
            }
        }
        private void btnCancelar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            dtgValEmpleados.ApplyFindFilter("");
            gridCheckMarksPalets.ClearSelection();
        }

        private void btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void Frm_Empleados_Listar_Shown(object sender, EventArgs e)
        {
            GridMultiplePalets();
            CLS_Empleado sel = new CLS_Empleado();
            sel.MtdSeleccionar();
            if (sel.Exito)
            {
                dtgEmpleados.DataSource = sel.Datos;
            }
        }

        private void btnAgregar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(CadenaCodigos!=string.Empty)
            {
                this.Close();
            }
            else
            {
                XtraMessageBox.Show("No se ha seleccionado empleados"); 
            }
        }

        private void btnSincronizar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            CLS_Empleado ins = new CLS_Empleado();
            ins.MtdInsertSincronizarEmpleados();
            if (ins.Exito)
            {
                XtraMessageBox.Show("Se ha actualizado los empleados con exito");
            }
            else
            {
                XtraMessageBox.Show(ins.Mensaje);
            }
        }
    }
}