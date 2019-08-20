using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using esp_VPCode;
using DevExpress.XtraEditors;

namespace EtiquetasGTIN
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            btnLimpiar.PerformClick();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtGTIN.Text = string.Empty;
            txtLote.Text = string.Empty;
            dtFecha.EditValue = DateTime.Now;
            lblPick1.Text = string.Empty;
            lblPick2.Text = string.Empty;
        }

        private void btnGenera_Click(object sender, EventArgs e)
        {
            if (txtGTIN.Text != string.Empty && txtLote.Text != string.Empty)
            {
                string Cadena = cls_VoiceCode.fn_CalculaVPC(txtGTIN.Text, txtLote.Text, Convert.ToDateTime(dtFecha.EditValue));
                lblPick1.Text = Cadena.Substring(0, 2);
                lblPick2.Text = Cadena.Substring(2, 2);
            }
            else
            {
                XtraMessageBox.Show("Faltan datos por llenar");
            }
        }
    }
}
