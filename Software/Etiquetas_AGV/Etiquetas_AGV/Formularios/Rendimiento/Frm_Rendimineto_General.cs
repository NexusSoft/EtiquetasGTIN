using System;

namespace Etiquetas_AGV.Formularios.Rendimiento
{
    public partial class Frm_Rendimineto_General : DevExpress.XtraEditors.XtraForm
    {
        private static Frm_Rendimineto_General m_FormDefInstance;
        public string c_codigo_usu { get; set; }
        public static Frm_Rendimineto_General DefInstance
        {
            get
            {
                if (m_FormDefInstance == null || m_FormDefInstance.IsDisposed)
                    m_FormDefInstance = new Frm_Rendimineto_General();
                return m_FormDefInstance;
            }
            set
            {
                m_FormDefInstance = value;
            }

        }

        public Frm_Rendimineto_General()
        {
            InitializeComponent();
        }

        private void labelControl2_Click(object sender, EventArgs e)
        {

        }

        private void labelControl4_Click(object sender, EventArgs e)
        {

        }

        private void labelControl8_Click(object sender, EventArgs e)
        {

        }

        private void progressBarControl1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void progressBarControl1_EditValueChanged_1(object sender, EventArgs e)
        {

        }

        private void labelControl12_Click(object sender, EventArgs e)
        {

        }

        private void labelControl14_Click(object sender, EventArgs e)
        {

        }

        private void labelControl20_Click(object sender, EventArgs e)
        {

        }

        private void panelControl3_Paint(object sender, System.Windows.Forms.PaintEventArgs e)
        {

        }
    }
}