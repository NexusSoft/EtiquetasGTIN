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

namespace Etiquetas_AGV.Formularios.Rendimiento
{
    public partial class Frm_MetasRendimiento : DevExpress.XtraEditors.XtraForm
    {
        private static Frm_MetasRendimiento m_FormDefInstance;
        public static Frm_MetasRendimiento DefInstance
        {
            get
            {
                if (m_FormDefInstance == null || m_FormDefInstance.IsDisposed)
                    m_FormDefInstance = new Frm_MetasRendimiento();
                return m_FormDefInstance;
            }
            set
            {
                m_FormDefInstance = value;
            }
        }
        public string c_codigo_usu { get; set; }
        public Frm_MetasRendimiento()
        {
            InitializeComponent();
        }

        private void Frm_MetasRendimiento_Load(object sender, EventArgs e)
        {

        }
    }
}