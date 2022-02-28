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
using System.IO;
using System.Diagnostics;

namespace Etiquetas_AGV
{
    public partial class Frm_Archivo_SICFI : DevExpress.XtraEditors.XtraForm
    {
        public string TemActiva { get; private set; }
        public string fecha { get; private set; }

        public Frm_Archivo_SICFI()
        {
            InitializeComponent();
        }

        private void Frm_Archivo_SICFI_Shown(object sender, EventArgs e)
        {
            CargarTemporadaActiva();
            CargarTemporada(TemActiva);
            dtgValManifiesto.OptionsSelection.EnableAppearanceFocusedCell = false;
            dtgValManifiesto.OptionsSelection.EnableAppearanceHideSelection = false;
            dtgValManifiesto.OptionsSelection.MultiSelect = true;
            dtgValManifiesto.OptionsView.ShowGroupPanel = false;
            dtgValManifiesto.OptionsBehavior.AutoPopulateColumns = true;
            dtgValManifiesto.OptionsView.ColumnAutoWidth = true;
            dtgValManifiesto.BestFitColumns();
            
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

        private void btn_EstibaBuscar_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(cmb_temporada.EditValue.ToString())&& txtManifiesto.Text!=string.Empty)
            {
                CLS_Estiba sel = new CLS_Estiba();
                sel.c_codigo_tem= cmb_temporada.EditValue.ToString();
                sel.c_codigo_man = txtManifiesto.Text;
                sel.MtdSeleccionarSICFIManifiesto();
                if(sel.Exito)
                {
                    if(sel.Datos.Rows.Count>0)
                    {
                        dtgManifiesto.DataSource = sel.Datos;
                        dtgValManifiesto.BestFitColumns();
                    }
                    else
                    {
                        XtraMessageBox.Show("No se encontraron datos de este manifiesto");
                    }
                }
                else
                {
                    XtraMessageBox.Show(sel.Mensaje);
                }
            }
        }

        private void txtManifiesto_EditValueChanged(object sender, EventArgs e)
        {
            dtgManifiesto.DataSource = null;

        }

        private void btn_Generar_Click(object sender, EventArgs e)
        {
            DialogResult result = DialogoFolder.ShowDialog();
            if (result == DialogResult.OK)
            {
                if (dtgValManifiesto.RowCount > 0 && txtManifiesto.Text != string.Empty)
                {
                    string NombreArchivo = cmb_temporada.EditValue + "-" + txtManifiesto.Text;
                    string Ruta = DialogoFolder.SelectedPath.ToString() + "\\" + NombreArchivo + ".txt";
                    StreamWriter sw = new StreamWriter(Ruta);
                    if (!string.IsNullOrEmpty(cmb_temporada.EditValue.ToString()) && txtManifiesto.Text != string.Empty)
                    {
                        CLS_Estiba sel = new CLS_Estiba();
                        sel.c_codigo_tem = cmb_temporada.EditValue.ToString();
                        sel.c_codigo_man = txtManifiesto.Text;
                        sel.MtdSeleccionarSICFIManifiesto();
                        if (sel.Exito)
                        {
                            if (sel.Datos.Rows.Count > 0)
                            {
                                fecha=CalcularFecha();
                                sw.WriteLine(fecha);
                                string vPaletTemp = string.Empty;
                                string vPalet = string.Empty;
                                for (int i = 0; i < sel.Datos.Rows.Count; i++)
                                {
                                    if (vPaletTemp == sel.Datos.Rows[i]["Palet"].ToString())
                                    {
                                        vPalet += Espacios(sel.Datos.Rows[i]["n_bulxpa_pal"].ToString(), 10);
                                        vPalet += Espacios(sel.Datos.Rows[i]["id_product"].ToString(), 5);
                                        vPalet += Espacios(sel.Datos.Rows[i]["id_size"].ToString(), 3);
                                        vPalet += Espacios(sel.Datos.Rows[i]["v_registro_hue"].ToString(), 14);
                                        vPalet += Espacios(sel.Datos.Rows[i]["c_codigo_lot"].ToString(), 10);
                                    }
                                    else
                                    {
                                        if (i!=0)
                                        {
                                            sw.WriteLine(vPalet);
                                        }
                                        vPalet = sel.Datos.Rows[i]["Palet"].ToString();
                                        vPaletTemp = vPalet;
                                        vPalet += sel.Datos.Rows[i]["id_commodity"].ToString();
                                        vPalet += sel.Datos.Rows[i]["c_codigo_tra"].ToString();
                                        vPalet += sel.Datos.Rows[i]["v_codext_tif"].ToString();

                                        vPalet +=Espacios(sel.Datos.Rows[i]["n_bulxpa_pal"].ToString(), 10);
                                        vPalet += Espacios(sel.Datos.Rows[i]["id_product"].ToString(), 5);
                                        vPalet += Espacios(sel.Datos.Rows[i]["id_size"].ToString(), 3);
                                        vPalet += Espacios(sel.Datos.Rows[i]["v_registro_hue"].ToString(),14);
                                        vPalet += Espacios(sel.Datos.Rows[i]["c_codigo_lot"].ToString(),10);
                                    }

                                }
                                sw.WriteLine(vPalet);
                                sw.Close();
                                XtraMessageBox.Show("Se ha generado el archivo con exito");
                                StartProcess(DialogoFolder.SelectedPath.ToString());

                            }
                        }
                    }
                }
            }
        }
        private void StartProcess(string path)
        {
            ProcessStartInfo StartInformation = new ProcessStartInfo();
            StartInformation.FileName = path;
            Process process = Process.Start(StartInformation);
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
        private static string Espacios(string sVal,int cantidad)
        {
            int length = sVal.Length;
            int espacios = cantidad - length;
            switch (espacios)
            {
                case 1:
                    sVal = sVal + " ";
                    break;
                case 2:
                    sVal = sVal + "  ";
                    break;
                case 3:
                    sVal = sVal + "   ";
                    break;
                case 4:
                    sVal = sVal + "    ";
                    break;
                case 5:
                    sVal = sVal + "     ";
                    break;
                case 6:
                    sVal = sVal + "      ";
                    break;
                case 7:
                    sVal = sVal + "       ";
                    break;
                case 8:
                    sVal = sVal + "        ";
                    break;
                case 9:
                    sVal = sVal + "         ";
                    break;
                default:
                    break;
            }
            return sVal;
        }
        private string CalcularFecha()
        {
            string vfecha = string.Empty;
            CLS_Estiba sel = new CLS_Estiba();
            sel.c_codigo_tem = cmb_temporada.EditValue.ToString();
            sel.c_codigo_man = txtManifiesto.Text;
            sel.MtdSeleccionarSICFIManifiestoFecha();
            if (sel.Exito)
            {
                if (sel.Datos.Rows.Count > 0)
                {
                    DateTime Fecha1 = Convert.ToDateTime(sel.Datos.Rows[0]["fechaini"].ToString());
                    DateTime Fecha2 = Convert.ToDateTime(sel.Datos.Rows[0]["fechafin"].ToString());
                    string Cadena = DosCero(Fecha1.Day.ToString()) + DosCero(Fecha1.Month.ToString()) + Fecha1.Year.ToString() + DosCero(Fecha2.Day.ToString()) + DosCero(Fecha2.Month.ToString()) + Fecha2.Year.ToString();
                    vfecha = Cadena;
                }
            }
            return vfecha;
        }
    }
}