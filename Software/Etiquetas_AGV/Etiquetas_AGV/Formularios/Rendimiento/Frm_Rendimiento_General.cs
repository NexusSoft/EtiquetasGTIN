using CapaDeDatos;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Drawing;

namespace Etiquetas_AGV.Formularios.Rendimiento
{
    public partial class Frm_Rendimiento_General : DevExpress.XtraEditors.XtraForm
    {
        private static Frm_Rendimiento_General m_FormDefInstance;
        public string c_codigo_usu { get; set; }
        public static Frm_Rendimiento_General DefInstance
        {
            get
            {
                if (m_FormDefInstance == null || m_FormDefInstance.IsDisposed)
                    m_FormDefInstance = new Frm_Rendimiento_General();
                return m_FormDefInstance;
            }
            set
            {
                m_FormDefInstance = value;
            }

        }
        public string TemActiva { get; set; }

        public Frm_Rendimiento_General()
        {
            InitializeComponent();
        }
        private void dtgValKilosAcumulados_RowStyle(object sender, RowStyleEventArgs e)
        {
            if (sender is GridView)
            {
                GridView gView = (GridView)sender;
                if (!gView.IsValidRowHandle(e.RowHandle)) return;
                int parent = gView.GetParentRowHandle(e.RowHandle);
                if (gView.IsGroupRow(parent))
                {
                    for (int i = 0; i < gView.GetChildRowCount(parent); i++)
                    {
                        if (gView.GetChildRowHandle(parent, i) == e.RowHandle)
                        {
                            e.Appearance.BackColor = i % 2 == 0 ? Color.AliceBlue : Color.White;
                        }
                    }
                }
                else
                {
                    e.Appearance.BackColor = e.RowHandle % 2 == 0 ? Color.AliceBlue : Color.White;
                }
            }
        }
        string Consultaparametro()
        {
            string Valor = "0";
            CLS_Rendimiento sel = new CLS_Rendimiento();
            sel.MtdSeleccionarkilosparametro();
            if (sel.Exito)
            {
                Valor = sel.Datos.Rows[0]["n_kilos_diarios"].ToString();
                lbl_kilosmeta.Text = decimal.Round(Convert.ToDecimal(Valor), 0).ToString();
                int nval = Convert.ToInt32(decimal.Round(Convert.ToDecimal(Valor), 0));
                bar_avance.Properties.Maximum = nval;
            }
            return Valor;
        }
        void ConsultaAcumulado()
        {
            CLS_Rendimiento sel = new CLS_Rendimiento();
            DateTime Fecha = DateTime.Now;

            sel.FechaConsulta = Fecha.Year.ToString() + "-" + DosCero(Fecha.Month.ToString()) + "-" + DosCero(Fecha.Day.ToString()) + " 00:00:00";
            sel.FechaConsulta2 = Fecha.Year.ToString() + "-" + DosCero(Fecha.Month.ToString()) + "-" + DosCero(Fecha.Day.ToString()) + " 23:59:59";
            sel.MtdSeleccionarKilosAcumulado();
            if (sel.Exito)
            {
                if (sel.Datos.Rows.Count > 0)
                {
                    if (sel.Datos.Rows[0]["kilos"].ToString() != string.Empty)
                    {
                        lbl_kilosProcesados.Text = "Kilos Procesados: " + decimal.Round(Convert.ToDecimal(sel.Datos.Rows[0]["kilos"].ToString())).ToString();
                        bar_avance.Position = Convert.ToInt32(decimal.Round(Convert.ToDecimal(sel.Datos.Rows[0]["kilos"].ToString())));
                    }
                    else
                    {
                        lbl_kilosProcesados.Text = "Kilos Procesados: 0.00";
                        bar_avance.Position = 0;
                    }
                }
            }
        }
        private static string DosCero(string sVal)
        {
            string str = "";
            if (sVal.Length == 1)
            {
                return (str = "0" + sVal);
            }
            return sVal;
        }
        void ConsultaHistorico()
        {
            CLS_Rendimiento selAcum = new CLS_Rendimiento();
            selAcum.FechaInicio = dt_FechaInicio.DateTime.Year.ToString() + "-" + DosCero(dt_FechaInicio.DateTime.Month.ToString()) + "-" + DosCero(dt_FechaInicio.DateTime.Day.ToString()) + " 00:00:00";
            selAcum.FechaFin = dt_FechaFin.DateTime.Year.ToString() + "-" + DosCero(dt_FechaFin.DateTime.Month.ToString()) + "-" + DosCero(dt_FechaFin.DateTime.Day.ToString()) + " 23:59:59";
            selAcum.MtdSeleccionarKilosHistoricos();
            if (selAcum.Exito)
            {
                dtgKilosAcumulados.DataSource = selAcum.Datos;
            }
        }
        private void CargarTemporadaActiva()
        {
            CLS_Temporada obtener = new CLS_Temporada();
            obtener.MtdSeleccionarEtiquetaTemporadaActiva();
            if (obtener.Exito)
            {
                if (obtener.Datos.Rows.Count > 0)
                {
                    TemActiva = obtener.Datos.Rows[0][0].ToString();
                }
            }
        }
        void ConsultaEstibaActual()
        {
            CLS_Rendimiento sel = new CLS_Rendimiento();
            sel.MtdSeleccionarEstibaActiva();
            if (sel.Exito)
            {
                if (sel.Datos.Rows.Count > 0)
                {
                    lbl_estiba.Text = sel.Datos.Rows[0]["c_codigo_sel"].ToString();
                    lbl_estibakilos.Text = sel.Datos.Rows[0]["n_kilos_proc"].ToString();
                }
                else
                {
                    lbl_estiba.Text = string.Empty;
                    lbl_estibakilos.Text = "0";
                }
            }
        }
        private void Frm_Rendimiento_General_Shown(object sender, EventArgs e)
        {
            dtgValKilosAcumulados.OptionsView.RowAutoHeight = true;
            dtgValKilosAcumulados.RowHeight = 35;
            txt_KilosBono.Text = Consultaparametro();
            txt_KilosBono.Properties.Mask.UseMaskAsDisplayFormat = true;
            gridColumn6.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            gridColumn6.DisplayFormat.FormatString = "n2";
            dtgValKilosAcumulados.OptionsSelection.EnableAppearanceFocusedCell = false;
            dtgValKilosAcumulados.OptionsSelection.EnableAppearanceHideSelection = false;
            dtgValKilosAcumulados.OptionsSelection.EnableAppearanceFocusedRow = false;
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
            ConsultaRendimiento();
            timer1.Start();
        }

        private void btn_Actualizar_Click(object sender, EventArgs e)
        {
            ConsultaRendimiento();
        }

        private void ConsultaRendimiento()
        {
            CLS_Reportes selG = new CLS_Reportes();
            selG.MtdSeleccionarReporteUA();
            if (selG.Exito)
            {
                labelControl9.Text = "Ultima Actualizacion: " + selG.Datos.Rows[0]["Actualizacion"].ToString();
            }
            ConsultaAcumulado();
            ConsultaHistorico();
            ConsultaEstibaActual();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ConsultaRendimiento();
        }
    }
}