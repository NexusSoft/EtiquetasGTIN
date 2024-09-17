using CapaDeDatos;
using DevExpress.XtraCharts.Native;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Etiquetas_AGV.Formularios.Rendimiento
{
    public partial class Frm_Captura_Rendimiento : DevExpress.XtraEditors.XtraForm
    {
        NumberStyles style = NumberStyles.Number | NumberStyles.AllowCurrencySymbol;
        CultureInfo provider = new CultureInfo("es-MX");
        public string TemActiva { get; set; }
        public string c_codigo_usu { get; set; }
        private static Frm_Captura_Rendimiento m_FormDefInstance;
        public static Frm_Captura_Rendimiento DefInstance
        {
            get
            {
                if (m_FormDefInstance == null || m_FormDefInstance.IsDisposed)
                    m_FormDefInstance = new Frm_Captura_Rendimiento();
                return m_FormDefInstance;
            }
            set
            {
                m_FormDefInstance = value;
            }
        }
        public Frm_Captura_Rendimiento()
        {
            InitializeComponent();
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
        private void CargarTemporada(string Valor)
        {
            CLS_Temporada obtener = new CLS_Temporada();
            obtener.MtdSeleccionarEtiquetaTemporada();
            if (obtener.Exito)
            {
                if (obtener.Datos.Rows.Count > 0)
                {
                    CargarComboTemporada(obtener.Datos, Valor);
                }
            }
        }
        private void CargarComboTemporada(DataTable Datos, string Valor)
        {
            cmb_temporada.Properties.DisplayMember = "v_nombre_tem";
            cmb_temporada.Properties.ValueMember = "c_codigo_tem";
            cmb_temporada.EditValue = Valor;
            cmb_temporada.Properties.DataSource = Datos;
        }
        private void CargarEstibaActiva()
        {
            CLS_Rendimiento sel = new CLS_Rendimiento();
            sel.MtdSeleccionarEstibaActiva();
            if (sel.Exito)
            {
                if (sel.Datos.Rows.Count > 0)
                {
                    txt_estiba.Text = sel.Datos.Rows[0]["c_codigo_sel"].ToString();
                    dt_FechaInicio.DateTime = Convert.ToDateTime(sel.Datos.Rows[0]["d_fecha_inicio"].ToString());
                    dt_FechaFin.DateTime = DateTime.Now;
                    txt_kilos_estiba.Text = sel.Datos.Rows[0]["n_kilos_proc"].ToString();
                    btn_BuscarEstiba.Enabled = false;
                    btn_Inicia_corrida.Enabled = false;
                    btn_cierra_corrida.Enabled = true;
                }
                else
                {
                    txt_estiba.Text = string.Empty;
                    dt_FechaInicio.DateTime = DateTime.Now;
                    dt_FechaFin.DateTime = DateTime.Now;
                    txt_kilos_estiba.Text = "0";
                    btn_BuscarEstiba.Enabled = true;
                    btn_Inicia_corrida.Enabled = true;
                    btn_cierra_corrida.Enabled = false;
                }
            }
        }
        private void Frm_Captura_Rendimiento_Load(object sender, EventArgs e)
        {
            CargarTemporadaActiva();
            CargarTemporada(TemActiva);
            CargarEstibaActiva();
            timer1.Start();
        }
        void RellenarCeros(string text)
        {
            string Cadena = text;
            for (int i = text.Length; i < 10; i++)
            {
                Cadena = "0" + Cadena;
            }
            txt_estiba.Text = Cadena;
        }
        void BuscarEstiba()
        {

            CLS_Rendimiento sel2 = new CLS_Rendimiento();
            sel2.c_codigo_tem = cmb_temporada.EditValue.ToString();
            sel2.c_codigo_sel = txt_estiba.Text;
            sel2.MtdSeleccionarEstibakilos();
            if (sel2.Exito)
            {
                if (Convert.ToInt32(sel2.Datos.Rows[0]["Dias"].ToString()) <= 3)
                {
                    txt_kilos_estiba.Text = sel2.Datos.Rows[0]["Kilos"].ToString();
                }
                else
                {
                    txt_kilos_estiba.Text = "0";
                    XtraMessageBox.Show("Esta estiba tiene mas de 2 dias de su recepcion y no se podra ingresar");
                }
            }
        }
        private void txt_estiba_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txt_estiba.Text != string.Empty)
            {
                RellenarCeros(txt_estiba.Text);
                BuscarEstiba();
            }
        }

        private void btn_Inicia_corrida_Click(object sender, EventArgs e)
        {
            if (txt_estiba.Text != string.Empty && Convert.ToDecimal(txt_kilos_estiba.Text) > 0)
            {
                CLS_Rendimiento ins = new CLS_Rendimiento();
                ins.c_codigo_tem = cmb_temporada.EditValue.ToString();
                ins.c_codigo_sel = txt_estiba.Text;
                ins.n_kilos_proc = Decimal.Parse(txt_kilos_estiba.Text, style, provider);
                ins.MtdInsertarEstiba();
                if (ins.Exito)
                {
                    XtraMessageBox.Show("Se ha iniciado la corrida de la estiba" + txt_estiba.Text);
                    btn_BuscarEstiba.Enabled = false;
                    btn_Inicia_corrida.Enabled = false;
                    btn_cierra_corrida.Enabled = true;
                }
            }
        }

        private void btn_BuscarEstiba_Click(object sender, EventArgs e)
        {
            Frm_EstibasDisponibles frm = new Frm_EstibasDisponibles();
            frm.c_codigo_sel = string.Empty;
            frm.ShowDialog();
            txt_estiba.Text = frm.c_codigo_sel;
            if (txt_estiba.Text != string.Empty)
            {
                RellenarCeros(txt_estiba.Text);
                BuscarEstiba();
            }
        }

        private void btn_cierra_corrida_Click(object sender, EventArgs e)
        {
            DialogResult = XtraMessageBox.Show("¿Desea finalizar la corrida actual no se podra ingresar de nuevo?", "Finalizar Corrida", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            if (DialogResult == DialogResult.Yes)
            {
                DateTime FechaActual = ObtenerHoraActual();
                DateTime FechaInicio = dt_FechaInicio.DateTime;
                DateTime FechaLimite = Convert.ToDateTime(FechaActual.Year+"-"+FechaActual.Month+"-"+FechaActual.Day+" 17:00:00");
                TimeSpan diferencia = FechaLimite - FechaActual;
                var diferenciaenminutos = diferencia.TotalMinutes;
                if(diferenciaenminutos>0)
                {
                    CLS_Rendimiento udp = new CLS_Rendimiento();
                    udp.c_codigo_tem = cmb_temporada.EditValue.ToString();
                    udp.c_codigo_sel = txt_estiba.Text;
                    udp.n_kilos_rend= Decimal.Parse(txt_kilos_estiba.Text, style, provider);
                    udp.MtdActualizarEstiba();
                    if(udp.Exito)
                    {
                        XtraMessageBox.Show("Se ha finalizado la corrida de la estiba " + txt_estiba.Text);
                        btn_BuscarEstiba.Enabled = true;
                        btn_Inicia_corrida.Enabled = true;
                        btn_cierra_corrida.Enabled = false;
                        txt_estiba.Text = string.Empty;
                        txt_kilos_estiba.Text = "0";
                        dt_FechaInicio.DateTime = DateTime.Now;
                        dt_FechaFin.DateTime = DateTime.Now;
                    }
                }
                else
                {
                    diferencia = FechaLimite - FechaInicio;
                    var minutosconsiderados = diferencia.TotalMinutes;
                    TimeSpan duracioncorrida = FechaActual - FechaInicio;
                    var minutoscorrida= duracioncorrida.TotalMinutes;
                    decimal kilosconsiderados = (Convert.ToDecimal(minutosconsiderados) * Decimal.Parse(txt_kilos_estiba.Text, style, provider) / Convert.ToDecimal(minutoscorrida));
                    CLS_Rendimiento udp = new CLS_Rendimiento();
                    udp.c_codigo_tem = cmb_temporada.EditValue.ToString();
                    udp.c_codigo_sel = txt_estiba.Text;
                    if (kilosconsiderados > 0)
                    {
                        udp.n_kilos_rend = kilosconsiderados;
                    }
                    else
                    {
                        udp.n_kilos_rend = 0;
                    }
                    udp.MtdActualizarEstiba();
                    if (udp.Exito)
                    {
                        XtraMessageBox.Show("Se ha finalizado la corrida de la estiba " + txt_estiba.Text);
                        btn_BuscarEstiba.Enabled = true;
                        btn_Inicia_corrida.Enabled = true;
                        btn_cierra_corrida.Enabled = false;
                        txt_estiba.Text = string.Empty;
                        txt_kilos_estiba.Text = "0";
                        dt_FechaInicio.DateTime = DateTime.Now;
                        dt_FechaFin.DateTime = DateTime.Now;
                    }
                }
            }
        }

        private DateTime ObtenerHoraActual()
        {
            DateTime HoraActual=DateTime.Now;
           CLS_Rendimiento sel = new CLS_Rendimiento();
            sel.MtdSeleccionarEstibaHoraActual();
            if(sel.Exito)
            {
                HoraActual =Convert.ToDateTime(sel.Datos.Rows[0]["HoraActual"].ToString());
            }
            return HoraActual;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            dt_FechaFin.DateTime = DateTime.Now;
        }

        private void txt_palet_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter && txt_palet.Text!=string.Empty)
            {
                CLS_Rendimiento sel=new CLS_Rendimiento();
                sel.c_codigo_pal=txt_palet.Text;
                sel.MtdSeleccionarPaletExistente();
                if(sel.Exito)
                {
                    if(sel.Datos.Rows.Count==0)
                    {
                        CLS_Rendimiento sel2 = new CLS_Rendimiento();
                        sel2.c_codigo_pal = txt_palet.Text;
                        sel2.MtdSeleccionarPaletPeso();
                        if(sel2.Exito)
                        {
                            if(sel2.Datos.Rows.Count>0)
                            {
                                if (!string.IsNullOrEmpty(sel2.Datos.Rows[0]["Peso"].ToString()))
                                {
                                    txt_kilosPalet.Text = sel2.Datos.Rows[0]["Peso"].ToString();
                                }
                                else 
                                {
                                    XtraMessageBox.Show("Este palet es una parte de un palet estibado, colocar el codigo del palet estibado");
                                }
                            }
                            else
                            {
                                XtraMessageBox.Show("No existe el numero de palet " + txt_palet.Text + " en el sistema");
                                txt_kilosPalet.Text = "0";
                            }
                        }
                    }
                    else
                    {
                        XtraMessageBox.Show("Ya existe este palet capturado");
                        txt_kilosPalet.Text = "0";
                    }
                }
            }
        }

        private void btn_agregar_palet_Click(object sender, EventArgs e)
        {
            if(txt_palet.Text != string.Empty && Decimal.Parse(txt_kilosPalet.Text, style, provider)>0)
            {
                CLS_Rendimiento ins=new CLS_Rendimiento();
                ins.c_codigo_tem=cmb_temporada.EditValue.ToString();
                ins.c_codigo_pal = txt_palet.Text;
                ins.n_kilos_proc = Decimal.Parse(txt_kilosPalet.Text, style, provider);
                ins.n_kilos_rend = Decimal.Parse(txt_kilosPalet.Text, style, provider);
                ins.MtdInsertPalet();
                if(ins.Exito)
                {
                    XtraMessageBox.Show("Se ha agregado el palet con exito");
                }
                else
                {
                    XtraMessageBox.Show(ins.Mensaje);
                }
            }
            else
            {
                XtraMessageBox.Show("El peso del palet debe ser mayor a 0");
            }
        }
    }
}