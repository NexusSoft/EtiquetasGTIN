using CapaDeDatos;
using DevExpress.XtraEditors;
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
    public partial class Frm_EstibasDisponibles : DevExpress.XtraEditors.XtraForm
    {
        public string c_codigo_sel { get; set; }
        public Frm_EstibasDisponibles()
        {
            InitializeComponent();
        }

        private void Frm_EstibasDisponibles_Load(object sender, EventArgs e)
        {
            CLS_Rendimiento sel = new CLS_Rendimiento();
            sel.MtdSeleccionarEstibasDisponibles();
            if(sel.Exito)
            {
                dtgEstibas.DataSource = sel.Datos;
            }
        }

        private void dtgEstibas_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                foreach (int i in this.dtgValEstibas.GetSelectedRows())
                {
                    DataRow row = this.dtgValEstibas.GetDataRow(i);
                    c_codigo_sel = row["c_codigo_sel"].ToString();
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