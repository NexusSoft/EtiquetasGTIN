using CapaDeDatos;
using DevExpress.XtraEditors;
using System;
using System.Data;
using System.Windows.Forms;

namespace Etiquetas_AGV
{
    public partial class Frm_Empleados : DevExpress.XtraEditors.XtraForm
    {

        public Boolean PaSel { get; set; }

        private static Frm_Empleados m_FormDefInstance;
        public static Frm_Empleados DefInstance
        {
            get
            {
                if (m_FormDefInstance == null || m_FormDefInstance.IsDisposed)
                    m_FormDefInstance = new Frm_Empleados();
                return m_FormDefInstance;
            }
            set
            {
                m_FormDefInstance = value;
            }
        }
        public Frm_Empleados()
        {
            InitializeComponent();
        }


        public string c_codigo_emp { get; set; }
        public string v_nombre_emp { get; set; }
        public string c_codigo_pue { get; set; }
        public string v_nombre_pue { get; set; }

        public string c_codigo_usu { get; set; }

        private void CargarCiudad()
        {
            dtgEmpleados.DataSource = null;
            CLS_Empleados Clase = new CLS_Empleados();

            Clase.MtdSeleccionarEmpleado();
            if (Clase.Exito)
            {
                dtgEmpleados.DataSource = Clase.Datos;
            }
        }

        private void InsertarCiudad()
        {
            CLS_Empleados Clase = new CLS_Empleados();

            Clase.c_codigo_emp = textId.Text.Trim();
            Clase.v_nombre_emp = textNombre.Text.ToUpper().Trim();
            Clase.c_codigo_pue = textPuesto.Tag.ToString();
            Clase.Usuario = c_codigo_usu.Trim();
            Clase.MtdInsertarEmpleado();

            if (Clase.Exito)
            {
                CargarCiudad();
                XtraMessageBox.Show("Se ha Insertado el registro con exito");
                LimpiarCampos();
            }
            else
            {
                XtraMessageBox.Show(Clase.Mensaje);
            }
        }

        private void EliminarCiudad()
        {
            CLS_Empleados Clase = new CLS_Empleados();
            Clase.c_codigo_emp = textId.Text.Trim();
            Clase.MtdEliminarEmpleado();
            if (Clase.Exito)
            {
                CargarCiudad();
                XtraMessageBox.Show("Se ha Eliminado el registro con exito");
                LimpiarCampos();
            }
            else
            {
                XtraMessageBox.Show(Clase.Mensaje);
            }
        }

        private void iniciarTags()
        {
            textPuesto.Tag = "";
        }

        private void LimpiarCampos()
        {
            textId.Text = "";
            textNombre.Text = "";
            textPuesto.Text = "";
            textPuesto.Tag = "";
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (int i in this.dtgValEmpleados.GetSelectedRows())
                {
                    DataRow row = this.dtgValEmpleados.GetDataRow(i);
                    textId.Text = row["c_codigo_emp"].ToString();
                    textNombre.Text = row["v_nombre_emp"].ToString();
                    textPuesto.Tag = row["c_codigo_pue"].ToString();
                    textPuesto.Text = row["v_nombre_pue"].ToString();
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }

        private void Frm_Ciudad_Load(object sender, EventArgs e)
        {
            if (PaSel == true)
            {
                btnSeleccionar.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
            }
            else
            {
                btnSeleccionar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            }
            CargarCiudad();
            iniciarTags();
        }

        private void btnGuardar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (textNombre.Text.ToString().Trim().Length > 0 && textId.Text.ToString().Trim().Length>0 && textPuesto.Tag.ToString().Trim().Length > 0)
            {
                InsertarCiudad();
            }
            else
            {
                XtraMessageBox.Show("Es necesario completar todos los campos.");
            }
        }

        private void btnEliminar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (textId.Text.Trim().Length > 0)
            {
                DialogResult = XtraMessageBox.Show("¿Desea eliminar el dato seleccionado?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                if (DialogResult == DialogResult.Yes)
                {
                    EliminarCiudad();
                }
            }
            else
            {
                XtraMessageBox.Show("Es necesario seleccionar un empleado.");
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
            c_codigo_emp = textId.Text.Trim();
            v_nombre_emp = textNombre.Text.Trim();
            c_codigo_pue = textPuesto.Tag.ToString();
            v_nombre_pue = textPuesto.Text.Trim();
            this.Close();
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            Frm_Puestos Estado = new Frm_Puestos();
            Estado.c_codigo_usu = c_codigo_usu.Trim();
            Estado.PaSel = true;
            Estado.ShowDialog();

            textPuesto.Tag = Estado.c_codigo_pue;
            textPuesto.Text = Estado.v_nombre_pue;
        }

        private void textPuesto_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}