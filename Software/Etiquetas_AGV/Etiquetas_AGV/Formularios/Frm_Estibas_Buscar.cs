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
using CapaDeDatos;

namespace Etiquetas_AGV
{
    public partial class Frm_Estibas_Buscar : DevExpress.XtraEditors.XtraForm
    {
        public Frm_Etiquetas FrmEtiquetas;
        public string vc_codigo_sel { get;  set; }
        public string vc_codigo_tem { get; set; }
        public Frm_Estibas_Buscar()
        {
            InitializeComponent();
        }

        private void Frm_Estibas_Buscar_Shown(object sender, EventArgs e)
        {
            dtgValEstibas.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            dtgValEstibas.OptionsSelection.EnableAppearanceFocusedCell = false;
            lblProveedor.Caption = "Folio:";
            CargarEstibas();
        }

        private void CargarEstibas()
        {
            CLS_Estiba sel = new CLS_Estiba();
            sel.c_codigo_tem = vc_codigo_tem;
            sel.MtdSeleccionarEstiba();
            if (sel.Exito)
            {
                if (sel.Datos.Rows.Count > 0)
                {
                    dtgEstibas.DataSource = sel.Datos;
                }
            }
        }

        private void btnSeleccionar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (vc_codigo_sel != string.Empty)
            {
                
                this.Close();
            }
            else
            {
                XtraMessageBox.Show("No se ha seleccionado Pedido");
            }
        }
        private void dtgPrePedidos_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (int i in this.dtgValEstibas.GetSelectedRows())
                {
                    DataRow row = this.dtgValEstibas.GetDataRow(i);
                    vc_codigo_sel = row["c_codigo_sel"].ToString();
                    lblProveedor.Caption = string.Format("Estiba: {0}", vc_codigo_sel);
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }
        private void dtgPrePedidos_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                foreach (int i in this.dtgValEstibas.GetSelectedRows())
                {
                    DataRow row = this.dtgValEstibas.GetDataRow(i);
                    vc_codigo_sel = row["c_codigo_sel"].ToString();
                    lblProveedor.Caption = string.Format("Estiba: {0}", vc_codigo_sel);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }
    }
}