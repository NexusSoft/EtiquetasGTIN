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


    }
}