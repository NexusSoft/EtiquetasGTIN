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
using CapaDeDatos;

namespace Etiquetas_AGV
{
    public partial class Frm_FechaPalet : DevExpress.XtraEditors.XtraForm
    {
        public string vTemporada { get; set; }
        public string vPalet { get; set; }
        public Frm_FechaPalet()
        {
            InitializeComponent();
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
        private void Frm_FechaPalet_Shown(object sender, EventArgs e)
        {
            dt_FechaEtiqueta.DateTime= DateTime.Now;
            txt_Temporada.Text= vTemporada;
            txt_Palet.Text= vPalet;
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            CLS_Etiquetas udp = new CLS_Etiquetas();
            udp.c_codigo_tem = txt_Temporada.Text;
            udp.c_codigo_pal = txt_Palet.Text;
            udp.d_empaque_eti = dt_FechaEtiqueta.DateTime.Year + DosCero(dt_FechaEtiqueta.DateTime.Month.ToString()) + DosCero(dt_FechaEtiqueta.DateTime.Day.ToString());
            udp.MtdUpdateFechaPalet();
            if(udp.Exito)
            {
                XtraMessageBox.Show("Se ha cambiado la fecha con exito");
            }
            else
            {
                XtraMessageBox.Show(udp.Mensaje);
            }
        }
    }
}