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
using System.IO.Ports;
using DevExpress.Utils.Extensions;

namespace Etiquetas_AGV.Formularios
{
    public partial class Frm_Bascula : DevExpress.XtraEditors.XtraForm
    {
        private delegate void DelegadoAcceso(string accion);
        private string strBufferIn;
        private string strBufferOut;
        public Frm_Bascula()
        {
            InitializeComponent();
        }

        private void AccesoForm(string accion)
        {
            strBufferIn = accion;
            txt_Peso.Text = strBufferIn;
        }
        private void AccesoInterrupcion(string accion)
        {
            DelegadoAcceso Var_DelegadoAcceso;
            Var_DelegadoAcceso = new DelegadoAcceso(AccesoForm);
            object[] arg = { accion };
            base.Invoke(Var_DelegadoAcceso, arg);
        }
        private void Frm_Bascula_Load(object sender, EventArgs e)
        {
            Inicializa_Variables();
        }

        private void Inicializa_Variables()
        {
            strBufferIn = string.Empty;
            strBufferOut = string.Empty;
            btnConectar.Enabled = false;
        }

        private void btnBuscarPuertos_Click(object sender, EventArgs e)
        {
            string[] PuertosDisponibles = SerialPort.GetPortNames();
            cmb_Puertos.Properties.Items.Clear();
            foreach (string puerto_simple in PuertosDisponibles)
            {
                cmb_Puertos.Properties.Items.Add(puerto_simple);
            }
            if(cmb_Puertos.Properties.Items.Count > 0)
            {
                cmb_Puertos.SelectedIndex = 0;
                btnConectar.Enabled = true;
            }
            else
            {
                cmb_Puertos.Properties.Items.Clear();
                Inicializa_Variables();
                XtraMessageBox.Show("No se encontraron puertos disponibles");
            }
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnConectar.Text== "Conectar Puerto")
                {
                    SpPuertos.BaudRate=Int32.Parse(cmb_Baud_Rate.Text);
                    SpPuertos.DataBits = 8;
                    SpPuertos.Parity = Parity.None;
                    SpPuertos.StopBits = StopBits.One;
                    SpPuertos.Handshake = Handshake.None;
                    SpPuertos.PortName = cmb_Puertos.Text;
                    try
                    {
                        SpPuertos.Open();
                        btnConectar.Text = "Desconectar Puerto";

                    }
                    catch (Exception exc)
                    {
                        XtraMessageBox.Show(exc.Message);
                    }
                }
                else if (btnConectar.Text == "Desonectar Puerto")
                {
                    SpPuertos.Close();
                    btnConectar.Text = "Conectar Puerto";
                }
            }
            catch (Exception exc)
            {
                XtraMessageBox.Show(exc.Message);
            }
        }

        private void BtnLeerPuertos_Click(object sender, EventArgs e)
        {

        }

        private void DatoRecibido(object sender, SerialDataReceivedEventArgs e)
        {
            string data_in = SpPuertos.ReadExisting();

        }
    }
}