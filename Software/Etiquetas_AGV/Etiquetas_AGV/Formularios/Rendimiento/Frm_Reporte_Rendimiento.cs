using CapaDeDatos;
using DevExpress.Xpo;
using DevExpress.XtraEditors;
using DevExpress.XtraExport.Helpers;
using DevExpress.XtraGrid.Views.Grid;
using Etiquetas_AGV.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Etiquetas_AGV.Formularios.Rendimiento
{
    public partial class Frm_Reporte_Rendimiento : DevExpress.XtraEditors.XtraForm
    {
        private ImagenTimer imageTimer;
        private static Frm_Reporte_Rendimiento m_FormDefInstance;
        public static Frm_Reporte_Rendimiento DefInstance
        {
            get
            {
                if (m_FormDefInstance == null || m_FormDefInstance.IsDisposed)
                    m_FormDefInstance = new Frm_Reporte_Rendimiento();
                return m_FormDefInstance;
            }
            set
            {
                m_FormDefInstance = value;
            }
        }
        public string c_codigo_usu { get; set; }
        public Frm_Reporte_Rendimiento()
        {
            InitializeComponent();
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ConsultaRendimiento();
            
        }

        private void ConsultaRendimiento()
        {
            CLS_Reportes selG = new CLS_Reportes();
            selG.MtdSeleccionarReporteUA();
            if (selG.Exito)
            {
                labelControl4.Text = "Ultima Actualizacion: " + selG.Datos.Rows[0]["Actualizacion"].ToString();
            }

            CLS_Reportes selAcum = new CLS_Reportes();
            selAcum.FechaInicio = dt_FechaInicio.DateTime.Year.ToString() + "-" + DosCero(dt_FechaInicio.DateTime.Month.ToString()) + "-" + DosCero(dt_FechaInicio.DateTime.Day.ToString()) + " 00:00:00";
            selAcum.FechaFin = dt_FechaFin.DateTime.Year.ToString() + "-" + DosCero(dt_FechaFin.DateTime.Month.ToString()) + "-" + DosCero(dt_FechaFin.DateTime.Day.ToString()) + " 23:59:59";
            selAcum.MtdSeleccionarReporteAcumulado();
            if (selAcum.Exito)
            {
                dtgKilosAcumulados.DataSource = selAcum.Datos;
            }

            DateTime Fecha = DateTime.Now;
            CLS_Reportes selDia = new CLS_Reportes();
            selDia.FechaInicio = Fecha.Year.ToString() + "-" + DosCero(Fecha.Month.ToString()) + "-" + DosCero(Fecha.Day.ToString()) + " 00:00:00";
            selDia.FechaFin = Fecha.Year.ToString() + "-" + DosCero(Fecha.Month.ToString()) + "-" + DosCero(Fecha.Day.ToString()) + " 23:59:59";
            selDia.MtdSeleccionarReporteDia();
            if (selDia.Exito)
            {
                dtgKilosDia.DataSource = selDia.Datos;
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
        private void grdViewReportPreview_RowStyle(object sender, RowStyleEventArgs e)
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
        private void Frm_Reporte_Rendimiento_Shown(object sender, EventArgs e)
        {
            dtgValKilosDia.OptionsView.RowAutoHeight = true;
            dtgValKilosDia.RowHeight = 35;
            dtgValKilosAcumulados.OptionsView.RowAutoHeight = true;
            dtgValKilosAcumulados.RowHeight = 35;
            txt_KilosBono.Text = "12000";
            txt_KilosBono.Properties.Mask.UseMaskAsDisplayFormat = true;
            gridColumn3.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            gridColumn3.DisplayFormat.FormatString = "n2";
            gridColumn6.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            gridColumn6.DisplayFormat.FormatString = "n2";
            dtgValKilosDia.OptionsSelection.EnableAppearanceFocusedCell = false;
            dtgValKilosDia.OptionsSelection.EnableAppearanceHideSelection = false;
            dtgValKilosDia.OptionsSelection.EnableAppearanceFocusedRow = false;
            dtgValKilosAcumulados.OptionsSelection.EnableAppearanceFocusedCell = false;
            dtgValKilosAcumulados.OptionsSelection.EnableAppearanceHideSelection = false;
            dtgValKilosAcumulados.OptionsSelection.EnableAppearanceFocusedRow = false;
            DateTime today ;
            DateTime answer ;
            DateTime dateValue = DateTime.Now;
            int dia=(int)dateValue.DayOfWeek;
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
            timer1.Enabled = true;
            timer1.Start();
            ConsultaRendimiento();
           
        }

        private void btn_Actualizar_Click(object sender, EventArgs e)
        {
            ConsultaRendimiento();
        }
        private void dtgValKilosDia_RowStyle(object sender, RowStyleEventArgs e)
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

 

    }


}