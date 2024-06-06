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
    public partial class Frm_EmpleadosBono : DevExpress.XtraEditors.XtraForm
    {
        private static Frm_EmpleadosBono m_FormDefInstance;
        public static Frm_EmpleadosBono DefInstance
        {
            get
            {
                if (m_FormDefInstance == null || m_FormDefInstance.IsDisposed)
                    m_FormDefInstance = new Frm_EmpleadosBono();
                return m_FormDefInstance;
            }
            set
            {
                m_FormDefInstance = value;
            }
        }
        public string c_codigo_usu { get; set; }
        public string c_codigo_einc { get; set; }
        public Frm_EmpleadosBono()
        {
            InitializeComponent();
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            Frm_Empleados Emp = new Frm_Empleados();
            Emp.c_codigo_usu = c_codigo_usu.Trim();
            Emp.PaSel = true;
            Emp.ShowDialog();

            textId.Text = Emp.c_codigo_emp;
            textNombre.Text = Emp.v_nombre_emp;
        }
        private void CargarInsidencias(int? Valor)
        {
            CLS_Incidencias obtener = new CLS_Incidencias();
            obtener.MtdSeleccionarInsidencias();
            if (obtener.Exito)
            {
                CargarComboIncidencias(obtener.Datos, Valor);
            }
        }
        private void CargarComboIncidencias(DataTable Datos, int? Valor)
        {
            cboInsidencias.Properties.DisplayMember = "NombreIncidencia";
            cboInsidencias.Properties.ValueMember = "IdIncidencia";
            cboInsidencias.EditValue = Valor;
            cboInsidencias.Properties.DataSource = Datos;
        }
        private void Frm_EmpleadosBono_Load(object sender, EventArgs e)
        {
            dtFecha.DateTime = DateTime.Now;
            CargarInsidencias(null);
            DateTime today;
            DateTime answer;
            DateTime dateValue = DateTime.Now;
            int dia = (int)dateValue.DayOfWeek;
            switch (dia)
            {
                case 0:
                    today = DateTime.Now;
                    answer = today.AddDays(-4);
                    dt_FechaInicio.DateTime = answer;
                    answer = today.AddDays(2);
                    dt_FechaFin.DateTime = answer;
                    break;
                case 1:
                    today = DateTime.Now;
                    answer = today.AddDays(-5);
                    dt_FechaInicio.DateTime = answer;
                    answer = today.AddDays(1);
                    dt_FechaFin.DateTime = answer;
                    break;
                case 2:
                    today = DateTime.Now;
                    answer = today.AddDays(-6);
                    dt_FechaInicio.DateTime = answer;
                    answer = today.AddDays(0);
                    dt_FechaFin.DateTime = answer;
                    break;
                case 3:
                    today = DateTime.Now;
                    answer = today.AddDays(0);
                    dt_FechaInicio.DateTime = answer;
                    answer = today.AddDays(6);
                    dt_FechaFin.DateTime = answer;
                    break;
                case 4:
                    today = DateTime.Now;
                    answer = today.AddDays(-1);
                    dt_FechaInicio.DateTime = answer;
                    answer = today.AddDays(5);
                    dt_FechaFin.DateTime = answer;
                    break;
                case 5:
                    today = DateTime.Now;
                    answer = today.AddDays(-2);
                    dt_FechaInicio.DateTime = answer;
                    answer = today.AddDays(4);
                    dt_FechaFin.DateTime = answer;
                    break;
                case 6:
                    today = DateTime.Now;
                    answer = today.AddDays(-3);
                    dt_FechaInicio.DateTime = answer;
                    answer = today.AddDays(3);
                    dt_FechaFin.DateTime = answer;
                    break;
                default:
                    break;
            }
            CargarEmpleadoBono();
            dtgValEmpleadosBono.OptionsSelection.EnableAppearanceFocusedCell = false;
            dtgValEmpleadosBono.OptionsSelection.EnableAppearanceHideSelection = false;
            dtgValEmpleadosBono.OptionsSelection.EnableAppearanceFocusedRow = false;
            c_codigo_einc = string.Empty;
        }
        public string DosCeros(string sVal)
        {
            string str = "";
            if (sVal.Length == 1)
            {
                return (str = "0" + sVal);
            }
            return sVal;
        }
        private void LimpiarCampos()
        {
            textId.Text = string.Empty;
            textNombre.Text = string.Empty;
            dtFecha.DateTime = DateTime.Now;
            c_codigo_einc=string.Empty;
            CargarInsidencias(null);
        }
        private void InsertarEmpleadoBono()
        {
            CLS_Incidencias Clase = new CLS_Incidencias();
            DateTime FIncidencia = Convert.ToDateTime(dtFecha.EditValue.ToString());

            Clase.Fecha = string.Format("{0}{1}{2} 00:00:00", FIncidencia.Year, DosCeros(FIncidencia.Month.ToString()), DosCeros(FIncidencia.Day.ToString()));
            Clase.c_codigo_einc = c_codigo_einc;
            Clase.c_codigo_emp = textId.Text.Trim();
            Clase.IdIncidencia =Convert.ToInt32(cboInsidencias.EditValue.ToString());
            Clase.MtdInsertEmpleadoIncidencias();

            if (Clase.Exito)
            {
                CargarEmpleadoBono();
                XtraMessageBox.Show("Se ha Insertado el registro con exito");
                LimpiarCampos();
            }
            else
            {
                XtraMessageBox.Show(Clase.Mensaje);
            }
        }
        private void CargarEmpleadoBono()
        {
            dtgEmpleadosBono.DataSource = null;
            CLS_Incidencias Clase = new CLS_Incidencias();
            DateTime FInicio= Convert.ToDateTime(dt_FechaInicio.EditValue.ToString());
            Clase.FechaInicio = string.Format("{0}-{1}-{2} 00:00:00", FInicio.Year, DosCeros(FInicio.Month.ToString()), DosCeros(FInicio.Day.ToString()));
            DateTime FFin = Convert.ToDateTime(dt_FechaFin.EditValue.ToString());
            Clase.FechaFin = string.Format("{0}-{1}-{2} 00:00:00", FFin.Year, DosCeros(FFin.Month.ToString()), DosCeros(FFin.Day.ToString()));
            Clase.MtdSeleccionarEmpleadoInsidencias();
            if (Clase.Exito)
            {
                dtgEmpleadosBono.DataSource = Clase.Datos;
            }
        }
        private void btnGuardar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (textNombre.Text.ToString().Trim().Length > 0 && textId.Text.ToString().Trim().Length > 0 && cboInsidencias.EditValue!=null)
            {
                InsertarEmpleadoBono();
            }
            else
            {
                XtraMessageBox.Show("Es necesario completar todos los campos.");
            }
        }

        private void dtgEmpleadosBono_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (int i in this.dtgValEmpleadosBono.GetSelectedRows())
                {
                    DataRow row = this.dtgValEmpleadosBono.GetDataRow(i);
                    c_codigo_einc = row["c_codigo_einc"].ToString();
                    textId.Text = row["c_codigo_emp"].ToString();
                    textNombre.Text = row["v_nombre_emp"].ToString();
                    CargarInsidencias(Convert.ToInt32(row["IdIncidencia"].ToString()));
                    dtFecha.DateTime = Convert.ToDateTime(row["Fecha"].ToString());
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }

        private void btnEliminar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (c_codigo_einc != string.Empty)
            {
                DialogResult = XtraMessageBox.Show("¿Desea eliminar el dato seleccionado?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                if (DialogResult == DialogResult.Yes)
                {
                    CLS_Incidencias Clase = new CLS_Incidencias();
                    Clase.c_codigo_einc = c_codigo_einc;
                    Clase.MtdEliminarEmpleadoIncidencias();

                    if (Clase.Exito)
                    {
                        CargarEmpleadoBono();
                        XtraMessageBox.Show("Se ha Eliminado el registro con exito");
                        LimpiarCampos();
                    }
                    else
                    {
                        XtraMessageBox.Show(Clase.Mensaje);
                    }
                }
            }
            else
            {
                XtraMessageBox.Show("No Se ha Seleccionado un registro a eliminar");
            }
        }
    }
}