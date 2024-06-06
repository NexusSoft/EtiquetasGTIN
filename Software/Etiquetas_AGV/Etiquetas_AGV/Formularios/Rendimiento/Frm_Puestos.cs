using CapaDeDatos;
using DevExpress.XtraEditors;
using System;
using System.Data;
using System.Windows.Forms;

namespace Etiquetas_AGV
{
    public partial class Frm_Puestos : DevExpress.XtraEditors.XtraForm
    {
        public Boolean PaSel { get; set; }
        private static Frm_Puestos m_FormDefInstance;
        public static Frm_Puestos DefInstance
        {
            get
            {
                if (m_FormDefInstance == null || m_FormDefInstance.IsDisposed)
                    m_FormDefInstance = new Frm_Puestos();
                return m_FormDefInstance;
            }
            set
            {
                m_FormDefInstance = value;
            }
        }
        
        public Frm_Puestos()
        {
            InitializeComponent();
        }

        public string c_codigo_pue { get; set; }
        public string v_nombre_pue { get; set; }
        public string c_codigo_usu { get; set; }

        private void CargarPuesto(string Activo)
        {
            dtgPuesto.DataSource = null;
            CLS_Puesto Clase = new CLS_Puesto();
            Clase.MtdSeleccionarPuesto();
            if (Clase.Exito)
            {
                dtgPuesto.DataSource = Clase.Datos;
            }
        }

        private void InsertarPuesto()
        {
            CLS_Puesto Clase = new CLS_Puesto();

            Clase.c_codigo_pue = textId.Text.Trim();
            Clase.v_nombre_pue = textNombre.Text.Trim();
            Clase.Id_Usuario = c_codigo_usu;
            Clase.MtdInsertarPuesto();

            if (Clase.Exito)
            {
                CargarPuesto("1");
                XtraMessageBox.Show("Se ha Insertado el registro con exito");
                LimpiarCampos();
            }
            else
            {
                XtraMessageBox.Show(Clase.Mensaje);
            }
        }

        private void EliminarPuesto()
        {
            CLS_Puesto Clase = new CLS_Puesto();
            Clase.c_codigo_pue = textId.Text.Trim();
            Clase.Id_Usuario = c_codigo_usu;
            Clase.MtdEliminarPuesto();
            if (Clase.Exito)
            {
                XtraMessageBox.Show("Se ha Eliminado el registro con exito");
                LimpiarCampos();
            }
            else
            {
                XtraMessageBox.Show(Clase.Mensaje);
            }
        }

        private void LimpiarCampos()
        {
            textId.Text = "";
            textNombre.Text = "";
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (int i in this.dtgValPuesto.GetSelectedRows())
                {
                    DataRow row = this.dtgValPuesto.GetDataRow(i);
                    textId.Text = row["c_codigo_pue"].ToString();
                    textNombre.Text = row["v_nombre_pue"].ToString();
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }

        private void Frm_Cultivo_Load(object sender, EventArgs e)
        {
            if (PaSel == true)
            {
                btnSeleccionar.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            }
            else
            {
                btnSeleccionar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            }
            CargarPuesto("1");
            LimpiarCampos();
        }

        private void btnGuardar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (textNombre.Text.ToString().Trim().Length > 0)
            {
                InsertarPuesto();
            }
            else
            {
                XtraMessageBox.Show("Es necesario Agregar un nombre de un puesto.");
            }
        }

        private void btnEliminar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (textId.Text.Trim().Length > 0)
            {
                DialogResult = XtraMessageBox.Show("¿Desea eliminar el dato seleccionado?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                if (DialogResult == DialogResult.Yes)
                {
                    EliminarPuesto();
                }
            }
            else
            {
                XtraMessageBox.Show("Es necesario seleccionar un puesto.");
            }

        }

        private void btnLimpiar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LimpiarCampos();
        }

        private void btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnSeleccionar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            c_codigo_pue = textId.Text.Trim();
            v_nombre_pue = textNombre.Text.Trim();
            this.Close();
        }
    }
}