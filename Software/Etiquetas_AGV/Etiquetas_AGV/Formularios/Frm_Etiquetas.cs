using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GridControlEditCBMultipleSelection;
using DevExpress.XtraGrid;
using CapaDeDatos;
using DevExpress.XtraEditors;
using esp_VPCode;
using DevExpress.XtraReports.UI;
using System.IO;
using DevExpress.DataAccess.Sql;
using DevExpress.DataAccess.ConnectionParameters;
using DevExpress.XtraCharts.GLGraphics;


namespace Etiquetas_AGV
{
    public partial class Frm_Etiquetas : DevExpress.XtraEditors.XtraForm
    {
        GridControlCheckMarksSelection gridCheckMarksPalets;
        string CadenaCodigos = null;
        StringBuilder sb = new StringBuilder();
        internal string c_codigo_usu;

        public string TemActiva { get; private set; }
        public string vTemporada { get; private set; }
        public string vDistribuidor { get; private set; }
        public string v_c_codsec_pal { get; private set; }
        public string vc_codigo_sec { get; private set; }
        public string vVoice1 { get; private set; }
        public string vVoice2 { get; private set; }
        public string vPrinterName { get; private set; }
        public string vCProducto { get; private set; }
        public string c_codigo_jul { get; private set; }
        public string vc_codigo_cra { get; set; }
        public string vv_nombre_cra { get; set; }
        public string vCOC { get; set; }
        public string vCOCGest { get; set; }
        public string v_paletmod { get; set; }

        public Frm_Etiquetas()
        {
            InitializeComponent();
        }
        private void MakeTablaPedidosInsidencias()
        {
            DataTable table = new DataTable("FirstTable");
            DataColumn column = new DataColumn();
            table.Reset();

            // DataRow row;
            column.DataType = typeof(string);
            column.ColumnName = "c_codigo_tem";
            column.AutoIncrement = false;
            column.Caption = "Tem";
            column.ReadOnly = false;
            column.Unique = false;

            table.Columns.Add(column);

            column = new DataColumn();
            column.DataType = typeof(string);
            column.ColumnName = "c_codigo_sel";
            column.AutoIncrement = false;
            column.Caption = "Sel";
            column.ReadOnly = false;
            column.Unique = false;

            table.Columns.Add(column);

            column = new DataColumn();
            column.DataType = typeof(string);
            column.ColumnName = "c_Codigo_pal";
            column.AutoIncrement = false;
            column.Caption = "Palet";
            column.ReadOnly = false;
            column.Unique = false;

            table.Columns.Add(column);

            column = new DataColumn();
            column.DataType = typeof(Int32);
            column.ColumnName = "c_codsec_pal";
            column.AutoIncrement = false;
            column.Caption = "Sec";
            column.ReadOnly = false;
            column.Unique = false;

            table.Columns.Add(column);

            column = new DataColumn();
            column.DataType = typeof(string);
            column.ColumnName = "n_bulxpa_pal";
            column.AutoIncrement = false;
            column.Caption = "Cajas";
            column.ReadOnly = false;
            column.Unique = false;

            table.Columns.Add(column);

            column = new DataColumn();
            column.DataType = typeof(string);
            column.ColumnName = "producto";
            column.AutoIncrement = false;
            column.Caption = "Producto";
            column.ReadOnly = false;
            column.Unique = false;

            table.Columns.Add(column);

            column = new DataColumn();
            column.DataType = typeof(string);
            column.ColumnName = "etiqueta";
            column.AutoIncrement = false;
            column.Caption = "Etiqueta";
            column.ReadOnly = false;
            column.Unique = false;

            table.Columns.Add(column);

            column = new DataColumn();
            column.DataType = typeof(string);
            column.ColumnName = "envase";
            column.AutoIncrement = false;
            column.Caption = "Envase";
            column.ReadOnly = false;
            column.Unique = false;

            table.Columns.Add(column);

            column = new DataColumn();
            column.DataType = typeof(string);
            column.ColumnName = "Lote";
            column.AutoIncrement = false;
            column.Caption = "Lote";
            column.ReadOnly = false;
            column.Unique = false;

            table.Columns.Add(column);

            column = new DataColumn();
            column.DataType = typeof(string);
            column.ColumnName = "Desde";
            column.AutoIncrement = false;
            column.Caption = "Desde";
            column.ReadOnly = false;
            column.Unique = false;

            table.Columns.Add(column);

            column = new DataColumn();
            column.DataType = typeof(string);
            column.ColumnName = "Hasta";
            column.AutoIncrement = false;
            column.Caption = "Hasta";
            column.ReadOnly = false;
            column.Unique = false;

            table.Columns.Add(column);

            column = new DataColumn();
            column.DataType = typeof(Boolean);
            column.ColumnName = "Recibir";
            column.AutoIncrement = false;
            column.Caption = "Recibir";
            column.ReadOnly = false;
            column.Unique = false;

            table.Columns.Add(column);

            dtgPalets.DataSource = table;
        }
        private void GridMultiplePalets()
        {
            gridCheckMarksPalets = new GridControlCheckMarksSelection(dtgValPalets);
            gridCheckMarksPalets.SelectionChanged += gridCheckMarksAcuerdos_SelectionChanged;
        }
       
        void gridCheckMarksAcuerdos_SelectionChanged(object sender, EventArgs e)
        {
            CadenaCodigos = string.Empty;
            if (ActiveControl is GridControl)
            {

                foreach (DataRowView rv in (sender as GridControlCheckMarksSelection).selection)
                {
                    if (sb.ToString().Length > 0) { sb.Append(", "); }
                    sb.AppendFormat("{0}", rv["c_codigo_pal"]);

                    if (CadenaCodigos != string.Empty)
                    {
                        CadenaCodigos = string.Format("{0},{1}", CadenaCodigos, rv["c_codigo_pal"]);
                        btn_FechaPalet.Enabled = false;
                    }
                    else
                    {
                       
                        CadenaCodigos = rv["c_codigo_pal"].ToString();
                        v_paletmod= rv["c_codigo_pal"].ToString();
                        btn_FechaPalet.Enabled = true;
                    }
                }
            }
            if (CadenaCodigos == string.Empty)
            {
                btn_FechaPalet.Enabled = false;
                btn_Imprimir.Enabled = false;
            }
            else
            {
                btn_Imprimir.Enabled = true;
            }
        }
        private void Frm_Etiquetas_Shown(object sender, EventArgs e)
        {
            btn_FechaPalet.Enabled = false;
            btn_Imprimir.Enabled = false;
            lblRegistro.Text = string.Empty;
            MakeTablaPedidosInsidencias();
            GridMultiplePalets();
            CargarCalibres(null);
            CargarDistribuidor(null);
            CargarEtiquetas(null);
            CargarTemporadaActiva();
            CargarTemporada(TemActiva);
            cmb_calibre.Enabled = false;
            cmb_Importador.Visible = false;
            cmb_Importador.Enabled = false;
            labelControl6.Visible = false;
            labelControl7.Visible = false;
            txtMateriaSeca.Visible = false;
        }
        private void CargarCalibres(string Valor)
        {
            CLS_Calibres obtener = new CLS_Calibres();
            obtener.MtdSeleccionarEtiquetaCalibres();
            if (obtener.Exito)
            {
                CargarComboCalibres(obtener.Datos, Valor);
            }
        }
        private void CargarComboCalibres(DataTable Datos, string Valor)
        {
            cmb_calibre.Properties.DisplayMember = "v_nombre_tam";
            cmb_calibre.Properties.ValueMember = "c_codigo_tam";
            cmb_calibre.EditValue = Valor;
            cmb_calibre.Properties.DataSource = Datos;
        }
        private void CargarTemporadaActiva()
        {
            CLS_Temporada obtener = new CLS_Temporada();
            obtener.MtdSeleccionarEtiquetaTemporadaActiva();
            if (obtener.Exito)
            {
                if(obtener.Datos.Rows.Count>0)
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
        private void CargarDistribuidor(string Valor)
        {
            CLS_Distribuidor obtener = new CLS_Distribuidor();
            obtener.MtdSeleccionarDistribuidor();
            if (obtener.Exito)
            {
                CargarComboDistribuidor(obtener.Datos, Valor);
            }
        }
        private void CargarComboDistribuidor(DataTable Datos, string Valor)
        {
            cmb_distribuidor.Properties.DisplayMember = "v_nombre_dis";
            cmb_distribuidor.Properties.ValueMember = "c_codigo_dis";
            cmb_distribuidor.EditValue = Valor;
            cmb_distribuidor.Properties.DataSource = Datos;
        }
        private void CargarImportador(string Valor)
        {
            CLS_Etiquetas obtener = new CLS_Etiquetas();
            obtener.c_codigo_eti = Convert.ToInt32(cmb_tipoetiqueta.EditValue.ToString());
            obtener.MtdSeleccionarExisteImportador();
            if (obtener.Exito)
            {
                if (obtener.Datos.Rows.Count > 0)
                {
                    cmb_Importador.Visible = true;
                    CargarComboimportador(obtener.Datos, Valor);
                    cmb_Importador.Enabled = true;
                    labelControl6.Visible = true;
                }
                else
                {
                    cmb_Importador.Visible = false;
                    cmb_Importador.Enabled = false;
                    labelControl6.Visible = false;
                }
            }
        }
        private void CargarComboimportador(DataTable Datos, string Valor)
        {
            cmb_Importador.Properties.DisplayMember = "v_nombre_imp";
            cmb_Importador.Properties.ValueMember = "c_codigo_imp";
            cmb_Importador.EditValue = Valor;
            cmb_Importador.Properties.DataSource = Datos;
        }
        private void CargarEtiquetas(string Valor)
        {
            CLS_Etiquetas obtener = new CLS_Etiquetas();
            obtener.MtdSeleccionarEtiquetas();
            if (obtener.Exito)
            {
                CargarComboEtiquetas(obtener.Datos, Valor);
            }
        }
        private void CargarComboEtiquetas(DataTable Datos, string Valor)
        {
            cmb_tipoetiqueta.Properties.DisplayMember = "v_nombre_eti";
            cmb_tipoetiqueta.Properties.ValueMember = "c_codigo_eti";
            cmb_tipoetiqueta.EditValue = Valor;
            cmb_tipoetiqueta.Properties.DataSource = Datos;
        }
        private void chkCalibres_CheckedChanged(object sender, EventArgs e)
        {
            if(chkCalibres.Checked==true)
            {
                cmb_calibre.Enabled = false;
                CargarCalibres(null);
            }
            else if (chkCalibres.Checked==false)
            {
                cmb_calibre.Enabled = true;
            }
        }
        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            if(cmb_temporada.EditValue!=null)
            {
                if(txtEstiba.Text!=string.Empty)
                {
                    txtEstiba.Text = CerosEstiba(txtEstiba.Text);
                    lblRegistro.Text = RegistroHuerta(cmb_temporada.EditValue.ToString(), txtEstiba.Text);
                    CLS_Estiba sel = new CLS_Estiba();
                    if(chkCalibres.Checked==true)
                    {
                        sel.c_codigo_tam = string.Empty;
                    }
                    else
                    {
                        sel.c_codigo_tam = cmb_calibre.EditValue.ToString();
                    }
                    sel.c_codigo_sel = txtEstiba.Text;
                    sel.c_codigo_tem = cmb_temporada.EditValue.ToString();
                    sel.MtdSeleccionarEstibaEtiquetas();
                    if(sel.Exito)
                    {
                        if(sel.Datos.Rows.Count>0)
                        {
                            dtgPalets.DataSource = sel.Datos;
                        }
                    }
                }
                else
                {
                    XtraMessageBox.Show("No se ha seleccionado Estiba");
                }
            }
            else
            {
                XtraMessageBox.Show("No se ha seleccionado Temporada");
            }
        }
        private void txtEstiba_KeyDown(object sender, KeyEventArgs e)
        {
            Validar_Campos tex = new Validar_Campos();
            tex.Solo_Numeros(sender, e, txtEstiba.Text);
            if(e.KeyValue==13)
            {
                btn_Buscar.PerformClick();
            }
        }
        private void btn_EstibaBuscar_Click(object sender, EventArgs e)
        {
            lblRegistro.Text = string.Empty;
            MakeTablaPedidosInsidencias();
            txtEstiba.Text = string.Empty;
            Frm_Estibas_Buscar frm = new Frm_Estibas_Buscar();
            frm.vc_codigo_tem = cmb_temporada.EditValue.ToString();
            frm.ShowDialog();
            txtEstiba.Text = frm.vc_codigo_sel;
            lblRegistro.Text = RegistroHuerta(cmb_temporada.EditValue.ToString(), txtEstiba.Text);
            if(txtEstiba.Text!=string.Empty)
            {
                btn_Buscar.PerformClick();
            }
        }

        private void BuscarCOC()
        {
            CLS_Estiba sel = new CLS_Estiba();
            sel.MtdSeleccionarEmpaqueCOC();
            if(sel.Exito)
            {
                if (sel.Datos.Rows.Count > 0)
                {
                    vCOC = "CoC: " + sel.Datos.Rows[0]["v_codigoaux_pem"].ToString();
                    vCOCGest = "CoC: " + sel.Datos.Rows[0]["v_codigo_coc"].ToString();
                }
                else
                {
                    vCOC = string.Empty;
                    vCOCGest = string.Empty;
                }
            }
        }
        private string RegistroHuerta(string c_codigo_tem, string c_codigo_sel)
        {
            string vRegistro = string.Empty;
            if (c_codigo_tem != string.Empty && c_codigo_sel != string.Empty)
            {
                CLS_Estiba sel = new CLS_Estiba();
                sel.c_codigo_sel = c_codigo_sel;
                sel.c_codigo_tem = c_codigo_tem;
                sel.MtdSeleccionarRegistroEstiba();
                if (sel.Exito)
                {
                    if (sel.Datos.Rows.Count > 0)
                    {
                        vRegistro = sel.Datos.Rows[0]["v_registro_hue"].ToString();
                        vc_codigo_cra = sel.Datos.Rows[0]["c_codigo_cra"].ToString();
                        vv_nombre_cra = sel.Datos.Rows[0]["v_nombre_cra"].ToString();
                        if (vc_codigo_cra == "0003")
                        {
                            BuscarCOC();
                        }
                        else
                        {
                            vCOC = string.Empty;
                            vCOCGest = string.Empty;
                        }
                    }
                    else
                    {
                        vCOC = string.Empty;
                        vCOCGest = string.Empty;
                    }
                }
            }
            CLS_Estiba sel1 = new CLS_Estiba();
            sel1.c_codigo_sel = c_codigo_sel;
            sel1.c_codigo_tem = c_codigo_tem;
            sel1.MtdSeleccionarRegistroHueEstiba();
            if (sel1.Exito)
            {
                if (sel1.Datos.Rows.Count > 0)
                {
                    vRegistro = sel1.Datos.Rows[0]["v_registro_hue"].ToString();
                }
            }
            return vRegistro;
        }

        private void Frm_Etiquetas_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Imprimir_Click(object sender, EventArgs e)
        {
            if (cmb_temporada.EditValue != null)
            {
                if (txtEstiba.Text != string.Empty)
                {
                    if (dtgValPalets.RowCount > 0)
                    {
                        if (cmb_tipoetiqueta.EditValue != null)
                        {
                            if (ValidaDistribuidor(cmb_tipoetiqueta.EditValue.ToString()))// la etiqueta necesita distribuidor
                            {
                                string vestiba = txtEstiba.Text;
                                vTemporada = cmb_temporada.EditValue.ToString();
                                if ( CadenaCodigos != string.Empty && CadenaCodigos!=null)
                                {
                                    string[] Palets = CadenaCodigos.Split(',');
                                    int t = 0;
                                    foreach (string vPalet in Palets)
                                    {
                                        t++;
                                        for (int i = 0; i < dtgValPalets.RowCount; i++)
                                        {
                                            int xRow = dtgValPalets.GetVisibleRowHandle(i);
                                            if (dtgValPalets.GetRowCellValue(xRow, "c_codigo_pal").ToString() == vPalet)
                                            {
                                                v_c_codsec_pal = dtgValPalets.GetRowCellValue(xRow, "c_codsec_pal").ToString();
                                                vCProducto = dtgValPalets.GetRowCellValue(xRow, "c_codigo_pro").ToString();
                                                int vhasta = Convert.ToInt32(decimal.Round(Convert.ToDecimal(dtgValPalets.GetRowCellValue(xRow, "Hasta").ToString()), 0));
                                                for (int r = 0; r < vhasta; r++)
                                                {
                                                    vc_codigo_sec = DosCero(Convert.ToString(r + 1));
                                                    string GTIN = string.Empty;
                                                    DateTime Fecha = DateTime.Now;
                                                    string Lote = txtEstiba.Text;
                                                    CLS_Estiba selG = new CLS_Estiba();
                                                    selG.c_codigo_pal = vPalet;
                                                    selG.c_codigo_tem = vTemporada;
                                                    selG.MtdSeleccionarGTIN();
                                                    if (selG.Exito)
                                                    {
                                                        GTIN = selG.Datos.Rows[0][0].ToString();
                                                    }
                                                    //GTIN = "007610100272275";
                                                    //Lote = "A003129";
                                                    string Cadena = cls_VoiceCode.fn_CalculaVPC(GTIN, Lote, Fecha);
                                                    vVoice1 = Cadena.Substring(0, 2);
                                                    vVoice2 = Cadena.Substring(2, 2);
                                                    switch (cmb_tipoetiqueta.EditValue.ToString())
                                                    {
                                                        case "1":
                                                            t=Etiqueta_HEB(t, vPalet);
                                                            break;
                                                        case "2":
                                                            t=Etiqueta_UPC(t, vPalet,vCProducto);
                                                            break;
                                                        case "3":
                                                            t = Etiqueta_UPC_Organic(t, vPalet, vCProducto);
                                                            break;
                                                        case "4":
                                                            t = Etiqueta_PTI_Organic(t, vPalet, vCProducto);
                                                            break;
                                                        case "5":
                                                            t = Etiqueta_Distribuidor(t, vPalet);
                                                            break;
                                                        case "6":
                                                            t = Etiqueta_Distribuidor_Juliana(t, vPalet);
                                                            break;
                                                        case "7":
                                                            t = Etiqueta_UPC_Distribuidor_Juliana(t, vPalet, vCProducto);
                                                            break;
                                                        case "8":
                                                            t = Etiqueta_UPC_SAMS(t, vPalet, vCProducto);
                                                            break;
                                                        case "9":
                                                            t = Etiqueta_UPC_CROGER(t, vPalet, vCProducto,false);
                                                            break;
                                                        case "10":
                                                            t = Etiqueta_UPC_CROGER(t, vPalet, vCProducto,true);
                                                            break;
                                                        case "11":
                                                            t = Etiqueta_UPC_CROGER_Juliana(t, vPalet, vCProducto,false);
                                                            break;
                                                        case "12":
                                                            t = Etiqueta_UPC_CROGER_Juliana(t, vPalet, vCProducto,true);
                                                            break;
                                                        case "13":
                                                            t = Etiqueta_UPC_SAMS_Juliana(t, vPalet, vCProducto);
                                                            break;
                                                        case "14":
                                                            t = Etiqueta_Westfalia(t, vPalet, vCProducto);
                                                            break;
                                                        case "15":
                                                            t = Etiqueta_Family(t, vPalet, vCProducto);
                                                            break;
                                                        case "16":
                                                            t = Etiqueta_Greenyard(t, vPalet, vCProducto);
                                                            break;
                                                        case "17":
                                                            t = Etiqueta_Chile(t, vPalet, vCProducto);
                                                            break;
                                                        case "18":
                                                            t = Etiqueta_Chile_2_3(t, vPalet, vCProducto);
                                                            break;
                                                        case "19":
                                                            t = Etiqueta_Argentina_2_3(t, vPalet, vCProducto);
                                                            break;
                                                        case "20":
                                                            t = Etiqueta_UPC_Anderson(t, vPalet, vCProducto, true);
                                                            break;
                                                        case "21":
                                                            t = Etiqueta_UPC_Anderson_Organic(t, vPalet, vCProducto, true);
                                                            break;
                                                        case "22":
                                                            t = Etiqueta_UPC_Anderson_Juliana(t, vPalet, vCProducto, true);
                                                            break;
                                                        case "23":
                                                            t = Etiqueta_SinDistribuidor_Juliana(t, vPalet);
                                                            break;
                                                        case "24":
                                                            t = Etiqueta_Distribuidor_PLU_AE(t, vPalet, vCProducto);
                                                            break;
                                                        case "25":
                                                            t = Etiqueta_UPC_Anderson_Juliana_Organic(t, vPalet, vCProducto, true);
                                                            break;
                                                        case "26":
                                                            t = Etiqueta_Distribuidor_JulianaOrganica(t, vPalet); 
                                                            break;
                                                        case "27":
                                                            t = Etiqueta_UPC_Index_Juliana(t, vPalet, vCProducto, true);
                                                            break;
                                                        case "28":
                                                            t = Etiqueta_Japon_Index_Juliana(t, vPalet, vCProducto, false);
                                                            break;
                                                        case "29":
                                                            t = Etiqueta_USDA_Index_Juliana(t, vPalet, vCProducto, false);
                                                            break;
                                                        case "30":
                                                            t = Etiqueta_Canada_Index_Juliana(t, vPalet, vCProducto, false);
                                                            break;
                                                        case "31":
                                                            t = Etiqueta_USDA_GEST_Juliana(t, vPalet, vCProducto, false);
                                                            break;
                                                        case "32":
                                                            t = Etiqueta_Canada_GEST_Juliana(t, vPalet, vCProducto, false);
                                                            break;
                                                        case "33":
                                                            t = Etiqueta_Distribuidor_AvocatsCanada(t, vPalet);
                                                            break;
                                                        case "34":
                                                            t = Etiqueta_Distribuidor_AvocatsCanadaSinPacked(t, vPalet);
                                                            break;
                                                        case "35":
                                                            t = Etiqueta_Distribuidor_Aqua(t, vPalet);
                                                            break;
                                                        case "36":
                                                            t = Etiqueta_SinDistribuidor_Juliana2(t, vPalet);
                                                            break;
                                                        case "37":
                                                            t = Etiqueta_EuropaGEST(t, vPalet, vCProducto);
                                                            break;
                                                        case "38":
                                                            t = Etiqueta_Europa_GEST_Estiba(t, vPalet, vCProducto, false);
                                                            break;
                                                        case "39":
                                                            t = Etiqueta_EuropaFRHOMIMEX(t);
                                                            break;
                                                        case "40":
                                                            t = Etiqueta_Europa_Maquila_Estiba(t, vPalet, vCProducto, false);
                                                            break;
                                                        case "41":
                                                            t = Etiqueta_Maquila_USDA(t);
                                                            break;
                                                        case "42":
                                                            t = Etiqueta_USDA_Maquila_Estiba(t, vPalet, vCProducto, false);
                                                            break;
                                                        case "43":
                                                            t = Etiqueta_SinUSDA_Maquila_Estiba(t, vPalet, vCProducto, false);
                                                            break;
                                                        case "44":
                                                            t = Etiqueta_Canada_GEST_Maq_Juliana(t, vPalet, vCProducto, false);
                                                            break;
                                                        case "45":
                                                            t = Etiqueta_USDA_Maquila_Estiba2(t, vPalet, vCProducto, false);
                                                            break;
                                                        case "46":
                                                            t = Etiqueta_Distribuidor_Juliana_Esp(t, vPalet);
                                                            break;
                                                        case "47":
                                                            t = Etiqueta_Dubai(t, vPalet);
                                                            break;
                                                        case "48":
                                                            t = Etiqueta_UPC_Mission(t, vPalet, vCProducto, true);
                                                            break;
                                                        case "49":
                                                            t = Etiqueta_EAN13_Mission(t, vPalet, vCProducto, true);
                                                            break;
                                                        case "50":
                                                            t = Etiqueta_UPC_LUG_Mission(t, vPalet, vCProducto, true);
                                                            break;
                                                        case "51":
                                                            t = Etiqueta_EAN13_4kg_Mission(t, vPalet, vCProducto, true);
                                                            break;
                                                        case "52":
                                                            t = Etiqueta_Lisa_Mission(t, vPalet, vCProducto, true);
                                                            break;
                                                        case "53":
                                                            t = Etiqueta_EAN13_Mission_2025(t, vPalet, vCProducto, true);
                                                            break;
                                                        case "54":
                                                            t = Etiqueta_UPC_Mission_2026(t, vPalet, vCProducto, true);
                                                            break;
                                                        case "55":
                                                            t = Etiqueta_UPC_LUG_PLU_2027(t, vPalet, vCProducto, true);
                                                            break;
                                                        case "56":
                                                            t = Etiqueta_UPC_Mission_3045(t, vPalet, vCProducto, true);
                                                            break;
                                                        case "57":
                                                            t = Etiqueta_UPC_LUG_Mission_2030(t, vPalet, vCProducto, true);
                                                            break;
                                                        case "58":
                                                            t = Etiqueta_EAN13_Mission_2028(t, vPalet, vCProducto, true);
                                                            break;
                                                        case "59":
                                                            t = Etiqueta_UPC_LUG_Mission_2033(t, vPalet, vCProducto, true);
                                                            break;
                                                        case "60":
                                                            t = Etiqueta_UPC_LUG_Mission_2030_60(t, vPalet, vCProducto, true);
                                                            break;
                                                        case "61":
                                                            t = Etiqueta_UPC_LUG_Mission_2030_70(t, vPalet, vCProducto, true);
                                                            break;
                                                        case "62":
                                                            t = Etiqueta_UPC_SAMS_LGS(t, vPalet, vCProducto, true);
                                                            break;
                                                        case "63":
                                                            t = Etiqueta_UPC_PLU_2037(t, vPalet, vCProducto, true);
                                                            break;
                                                        case "64":
                                                            t = Etiqueta_UPC_LUG_Mission_2033_Can(t, vPalet, vCProducto, true);
                                                            break;
                                                        case "65":
                                                            t = Etiqueta_Distribuidor_Canada(t, vPalet);
                                                            break;
                                                        case "66":
                                                            t = Etiqueta_EAN13_Mission_2029(t, vPalet, vCProducto, true);
                                                            break;
                                                        case "67":
                                                            t = Etiqueta_Distribuidor_DonManuel(t, vPalet);
                                                            break;
                                                        case "68":
                                                            t = Etiqueta_Distribuidor_Fecha(t, vPalet);
                                                            break;
                                                        case "69":
                                                            t = Etiqueta_SinDistribuidor(t, vPalet);
                                                            break;
                                                        case "70":
                                                            t = Etiqueta_UPC_LUG_PLU_2027EUA_31P(t, vPalet, vCProducto, true);
                                                            break;
                                                        case "71":
                                                            t = Etiqueta_UPC_LUG_PLU_2027EUA_22P(t, vPalet, vCProducto, true);
                                                            break;
                                                        case "72":
                                                            t = Etiqueta_EAN_LUG_PLU_2001(t, vPalet, vCProducto, true);
                                                            break;
                                                        case "73":
                                                            t = Etiqueta_UPC_LUG_Mission_2067(t, vPalet, vCProducto, true);
                                                            break;
                                                        case "74":
                                                            t = Etiqueta_UPC_LUG_PLU_2015(t, vPalet, vCProducto, true);
                                                            break;
                                                        case "75":
                                                            t = Etiqueta_EAN13_Mission_2006(t, vPalet, vCProducto, true);
                                                            break;
                                                        case "76":
                                                            t = Etiqueta_EAN13_Mission_2071(t, vPalet, vCProducto, true);
                                                            break;
                                                        case "77":
                                                            t = Etiqueta_UPC_Mandarin(t, vPalet, vCProducto, true);
                                                            break;
                                                        case "78":
                                                            t = Etiqueta_UPC_LUG_Mission_2004(t, vPalet, vCProducto, true);
                                                            break;
                                                        case "79":
                                                            t = Etiqueta_UPC_LUG_Mission_2043(t, vPalet, vCProducto, true);
                                                            break;
                                                        case "80":
                                                            t = Etiqueta_UPC_LUG_Mission_2041(t, vPalet, vCProducto, true);
                                                            break;
                                                    }
                                                    if(rdgTipoImpresion.SelectedIndex==1)
                                                    {
                                                        break;
                                                    }
                                                }
                                            }
                                        }
                                    }
                                    CadenaCodigos = string.Empty;
                                    gridCheckMarksPalets.ClearSelection();
                                }
                                else
                                {
                                    XtraMessageBox.Show("No se ha seleccionado palet para imprimir etiquetas");
                                }
                            }
                            else
                            {
                                XtraMessageBox.Show("No se ha seleccionado distribuidor");
                            }
                        }
                        else
                        {
                            XtraMessageBox.Show("No se ha seleccionado tipo de Etiqueta");
                        }
                    }
                    else
                    {
                        XtraMessageBox.Show("No se ha buscado Palets");
                    }
                }
                else
                {
                    XtraMessageBox.Show("No se ha seleccionado Estiba");
                }
            }
            else
            {
                XtraMessageBox.Show("No se ha seleccionado Temporada");
            }
        }
        private int Etiqueta_Distribuidor_PLU_AE(int t, string vPalet, string vcproducto)
        {
            rpt_Etiqueta_PLU_AE rpt = new rpt_Etiqueta_PLU_AE();
            rpt.c_codigo_tem = vTemporada;
            rpt.c_codigo_pal = vPalet;
            rpt.c_codsec_pal = v_c_codsec_pal;
            rpt.c_codigo_dis = vDistribuidor;
            rpt.c_codigo_sec = vc_codigo_sec;
            rpt.voice1 = vVoice1;
            rpt.voice2 = vVoice2;
            rpt.CargarParametros();
            ReportPrintTool printTool = new ReportPrintTool(rpt);
            ((SqlDataSource)rpt.DataSource).ConfigureDataConnection += Form1_ConfigureDataConnection;
            ReportPrintTool print = new ReportPrintTool(rpt);
            rpt.Parameters["COC"].Value = vCOC;
            rpt.Parameters["COC"].Visible = false;
            rpt.Parameters["COCGest"].Value = vCOCGest;
            rpt.Parameters["COCGest"].Visible = false;
            //GeneraCodeBarJuliana(vTemporada, vPalet, v_c_codsec_pal, c_codigo_jul);
            GeneraCodeBarSAMS(vTemporada, vPalet, v_c_codsec_pal);
            GeneraCodeBarPLU(vTemporada, vPalet, v_c_codsec_pal, vDistribuidor, vc_codigo_sec, vVoice1, vVoice2);
            //printTool.Print("myPrinter");
            if (rdgTipoImpresion.SelectedIndex == 1)
            {
                rpt.ShowPreviewDialog();
            }
            else
            {
                if (t == 1)
                {
                    t++;
                    printTool.PrintDialog();
                    vPrinterName = printTool.PrinterSettings.PrinterName;
                }
                else
                {
                    printTool.Print(vPrinterName);
                }
            }

            return t;
        }
        private int Etiqueta_Argentina_2_3(int t, string vPalet, string vCProducto)
        {
            rpt_Etiqueta_Argentina_2_3TSC rpt = new rpt_Etiqueta_Argentina_2_3TSC();
            rpt.c_codigo_tem = vTemporada;
            rpt.c_codigo_pal = vPalet;
            rpt.c_codsec_pal = v_c_codsec_pal;
            rpt.c_codigo_dis = vDistribuidor;
            rpt.c_codigo_sec = vc_codigo_sec;
            rpt.voice1 = vVoice1;
            rpt.voice2 = vVoice2;
            rpt.CargarParametros();
            ReportPrintTool printTool = new ReportPrintTool(rpt);
            ((SqlDataSource)rpt.DataSource).ConfigureDataConnection += Form1_ConfigureDataConnection;
            //rpt.Parameters["COC"].Value = vCOC;
            //rpt.Parameters["COC"].Visible = false;
            //GeneraCodeBarJuliana(vTemporada, vPalet, v_c_codsec_pal, c_codigo_jul);
            GeneraCodeBarMARMA(vTemporada, vPalet, v_c_codsec_pal);
            GeneraCodeBarUPC(vCProducto);
            //printTool.Print("myPrinter");
            if (rdgTipoImpresion.SelectedIndex == 1)
            {
                rpt.ShowPreviewDialog();
            }
            else
            {
                if (t == 1)
                {
                    t++;
                    printTool.PrintDialog();
                    vPrinterName = printTool.PrinterSettings.PrinterName;
                }
                else
                {
                    printTool.Print(vPrinterName);
                }
            }

            return t;
        }
        private int Etiqueta_Chile_2_3(int t, string vPalet, string vCProducto)
        {
            rpt_Etiqueta_Chile_2_3TSC rpt = new rpt_Etiqueta_Chile_2_3TSC(vTemporada, vPalet);
            ReportPrintTool printTool = new ReportPrintTool(rpt);
            ((SqlDataSource)rpt.DataSource).ConfigureDataConnection += Form1_ConfigureDataConnection;
            //rpt.Parameters["COC"].Value = vCOC;
            //rpt.Parameters["COC"].Visible = false;
            //GeneraCodeBarJuliana(vTemporada, vPalet, v_c_codsec_pal, c_codigo_jul);
            GeneraCodeBarMARMA(vTemporada, vPalet, v_c_codsec_pal);
            GeneraCodeBarUPC(vCProducto);
            //printTool.Print("myPrinter");
            if (rdgTipoImpresion.SelectedIndex == 1)
            {
                rpt.ShowPreviewDialog();
            }
            else
            {
                if (t == 1)
                {
                    t++;
                    printTool.PrintDialog();
                    vPrinterName = printTool.PrinterSettings.PrinterName;
                }
                else
                {
                    printTool.Print(vPrinterName);
                }
            }

            return t;
        }
        private int Etiqueta_Chile(int t, string vPalet, string vCProducto)
        {
            rpt_Etiqueta_Chile rpt = new rpt_Etiqueta_Chile(vTemporada, vPalet);
            ReportPrintTool printTool = new ReportPrintTool(rpt);
            ((SqlDataSource)rpt.DataSource).ConfigureDataConnection += Form1_ConfigureDataConnection;
            //rpt.Parameters["COC"].Value = vCOC;
            //rpt.Parameters["COC"].Visible = false;
            //GeneraCodeBarJuliana(vTemporada, vPalet, v_c_codsec_pal, c_codigo_jul);
            GeneraCodeBarMARMA(vTemporada, vPalet, v_c_codsec_pal);
            GeneraCodeBarUPC(vCProducto);
            //printTool.Print("myPrinter");
            if (rdgTipoImpresion.SelectedIndex == 1)
            {
                rpt.ShowPreviewDialog();
            }
            else
            {
                if (t == 1)
                {
                    t++;
                    printTool.PrintDialog();
                    vPrinterName = printTool.PrinterSettings.PrinterName;
                }
                else
                {
                    printTool.Print(vPrinterName);
                }
            }

            return t;
        }
        private int Etiqueta_Greenyard(int t, string vPalet, string vCProducto)
        {
            rpt_Etiqueta_Greenyard rpt = new rpt_Etiqueta_Greenyard(vTemporada, vPalet, v_c_codsec_pal, vDistribuidor, vc_codigo_sec, vVoice1, vVoice2);
            ReportPrintTool printTool = new ReportPrintTool(rpt);
            ((SqlDataSource)rpt.DataSource).ConfigureDataConnection += Form1_ConfigureDataConnection;
            rpt.Parameters["COC"].Value = vCOC;
            rpt.Parameters["COC"].Visible = false;
            rpt.Parameters["COCGest"].Value = vCOCGest;
            rpt.Parameters["COCGest"].Visible = false;
            //GeneraCodeBarJuliana(vTemporada, vPalet, v_c_codsec_pal, c_codigo_jul);
            GeneraCodeBarMARMA(vTemporada, vPalet, v_c_codsec_pal);
            GeneraCodeBarUPC(vCProducto);
            //printTool.Print("myPrinter");
            if (rdgTipoImpresion.SelectedIndex == 1)
            {
                rpt.ShowPreviewDialog();
            }
            else
            {
                if (t == 1)
                {
                    t++;
                    printTool.PrintDialog();
                    vPrinterName = printTool.PrinterSettings.PrinterName;
                }
                else
                {
                    printTool.Print(vPrinterName);
                }
            }

            return t;
        }
        private int Etiqueta_EuropaFRHOMIMEX(int t)
        {
            rpt_Etiqueta_EuropaFRHOMIMEX rpt = new rpt_Etiqueta_EuropaFRHOMIMEX();
            ReportPrintTool printTool = new ReportPrintTool(rpt);
            ((SqlDataSource)rpt.DataSource).ConfigureDataConnection += Form1_ConfigureDataConnection;
            //rpt.Parameters["COC"].Value = vCOC;
            //rpt.Parameters["COC"].Visible = false;
            //GeneraCodeBarJuliana(vTemporada, vPalet, v_c_codsec_pal, c_codigo_jul);
            //GeneraCodeBarMARMA(vTemporada, vPalet, v_c_codsec_pal);
            //GeneraCodeBarUPC(vCProducto);
            //printTool.Print("myPrinter");
            rpt.c_codigo_imp=cmb_Importador.EditValue.ToString();
            rpt.CargarParametros();
            if (rdgTipoImpresion.SelectedIndex == 1)
            {
                rpt.ShowPreviewDialog();
            }
            else
            {
                if (t == 1)
                {
                    t++;
                    printTool.PrintDialog();
                    vPrinterName = printTool.PrinterSettings.PrinterName;
                }
                else
                {
                    printTool.Print(vPrinterName);
                }
            }

            return t;
        }
        private int Etiqueta_EuropaGEST(int t, string vPalet, string vCProducto)
        {
            rpt_Etiqueta_EuropaGEST rpt = new rpt_Etiqueta_EuropaGEST();
            rpt.c_codigo_tem = vTemporada;
            rpt.c_codigo_pal = vPalet;
            rpt.c_codsec_pal = v_c_codsec_pal;
            rpt.c_codigo_dis = vDistribuidor;
            rpt.c_codigo_sec = vc_codigo_sec;
            rpt.voice1 = vVoice1;
            rpt.voice2 = vVoice2;
            rpt.CargarParametros();
            ReportPrintTool printTool = new ReportPrintTool(rpt);
            ((SqlDataSource)rpt.DataSource).ConfigureDataConnection += Form1_ConfigureDataConnection;
            rpt.Parameters["COC"].Value = vCOC;
            rpt.Parameters["COC"].Visible = false;
            rpt.Parameters["COCGest"].Value = vCOCGest;
            rpt.Parameters["COCGest"].Visible = false;
            //GeneraCodeBarJuliana(vTemporada, vPalet, v_c_codsec_pal, c_codigo_jul);
            GeneraCodeBarMARMA(vTemporada, vPalet, v_c_codsec_pal);
            GeneraCodeBarUPC(vCProducto);
            //printTool.Print("myPrinter");
            if (rdgTipoImpresion.SelectedIndex == 1)
            {
                rpt.ShowPreviewDialog();
            }
            else
            {
                if (t == 1)
                {
                    t++;
                    printTool.PrintDialog();
                    vPrinterName = printTool.PrinterSettings.PrinterName;
                }
                else
                {
                    printTool.Print(vPrinterName);
                }
            }

            return t;
        }
        private int Etiqueta_Family(int t, string vPalet, string vCProducto)
        {
            rpt_Etiqueta_FamilyTree rpt = new rpt_Etiqueta_FamilyTree();
            rpt.c_codigo_tem = vTemporada;
            rpt.c_codigo_pal = vPalet;
            rpt.c_codsec_pal = v_c_codsec_pal;
            rpt.c_codigo_dis = vDistribuidor;
            rpt.c_codigo_sec = vc_codigo_sec;
            rpt.voice1 = vVoice1;
            rpt.voice2 = vVoice2;
            rpt.CargarParametros();
            ReportPrintTool printTool = new ReportPrintTool(rpt);
            ((SqlDataSource)rpt.DataSource).ConfigureDataConnection += Form1_ConfigureDataConnection;
            rpt.Parameters["COC"].Value = vCOC;
            rpt.Parameters["COC"].Visible = false;
            rpt.Parameters["COCGest"].Value = vCOCGest;
            rpt.Parameters["COCGest"].Visible = false;
            //GeneraCodeBarJuliana(vTemporada, vPalet, v_c_codsec_pal, c_codigo_jul);
            GeneraCodeBarMARMA(vTemporada, vPalet, v_c_codsec_pal);
            GeneraCodeBarUPC(vCProducto);
            //printTool.Print("myPrinter");
            if (rdgTipoImpresion.SelectedIndex == 1)
            {
                rpt.ShowPreviewDialog();
            }
            else
            {
                if (t == 1)
                {
                    t++;
                    printTool.PrintDialog();
                    vPrinterName = printTool.PrinterSettings.PrinterName;
                }
                else
                {
                    printTool.Print(vPrinterName);
                }
            }

            return t;
        }
        private int Etiqueta_Westfalia(int t, string vPalet, string vCProducto)
        {
            rpt_Etiqueta_WestFalia rpt = new rpt_Etiqueta_WestFalia();
            rpt.c_codigo_tem = vTemporada;
            rpt.c_codigo_pal = vPalet;
            rpt.c_codsec_pal = v_c_codsec_pal;
            rpt.c_codigo_dis = vDistribuidor;
            rpt.c_codigo_sec = vc_codigo_sec;
            rpt.voice1 = vVoice1;
            rpt.voice2 = vVoice2;
            rpt.CargarParametros();
            ReportPrintTool printTool = new ReportPrintTool(rpt);
            ((SqlDataSource)rpt.DataSource).ConfigureDataConnection += Form1_ConfigureDataConnection;
            rpt.Parameters["COC"].Value = vCOC;
            rpt.Parameters["COC"].Visible = false;
            rpt.Parameters["COCGest"].Value = vCOCGest;
            rpt.Parameters["COCGest"].Visible = false;
            
            //GeneraCodeBarJuliana(vTemporada, vPalet, v_c_codsec_pal, c_codigo_jul);
            GeneraCodeBarMARMA(vTemporada, vPalet, v_c_codsec_pal);
            GeneraCodeBarUPC(vCProducto);
            //printTool.Print("myPrinter");
            if (rdgTipoImpresion.SelectedIndex == 1)
            {
                rpt.ShowPreviewDialog();
            }
            else
            {
                if (t == 1)
                {
                    t++;
                    printTool.PrintDialog();
                    vPrinterName = printTool.PrinterSettings.PrinterName;
                }
                else
                {
                    printTool.Print(vPrinterName);
                }
            }

            return t;
        }

        private bool ValidaDistribuidor(string TipoEtiqueta)
        {
            Boolean Valor = false;
            CLS_Etiquetas sel = new CLS_Etiquetas();
            sel.c_codigo_eti = Convert.ToInt32(TipoEtiqueta);
            sel.MtdSeleccionarEtiquetasDist();
            if(sel.Exito)
            {
                if(sel.Datos.Rows.Count>0)
                {
                    if (Convert.ToBoolean(sel.Datos.Rows[0]["b_Solicita_dis"].ToString()))
                    {
                        if(cmb_distribuidor.EditValue!=null)
                        {
                            vDistribuidor = cmb_distribuidor.EditValue.ToString();
                            Valor = true;
                        }
                        else
                        {
                            Valor = false;
                        }
                    }
                    else
                    {
                        Valor = true;
                    }
                }
            }
            return Valor;
        }
        private int Etiqueta_Distribuidor_Aqua(int t, string vPalet)
        {
            rpt_Etiqueta_Distribuidor_Aqua rpt = new rpt_Etiqueta_Distribuidor_Aqua();
            rpt.c_codigo_tem = vTemporada;
            rpt.c_codigo_pal = vPalet;
            rpt.c_codsec_pal = v_c_codsec_pal;
            rpt.c_codigo_dis = vDistribuidor;
            rpt.c_codigo_sec = vc_codigo_sec;
            rpt.voice1 = vVoice1;
            rpt.voice2 = vVoice2;
            rpt.c_codigo_jul = String.Empty;
            rpt.CargarParametros();
            ReportPrintTool printTool = new ReportPrintTool(rpt);
            ((SqlDataSource)rpt.DataSource).ConfigureDataConnection += Form1_ConfigureDataConnection;
            rpt.Parameters["COC"].Value = vCOC;
            rpt.Parameters["COC"].Visible = false;
            rpt.Parameters["COCGest"].Value = vCOCGest;
            rpt.Parameters["COCGest"].Visible = false;
            GeneraCodeBar(vTemporada, vPalet, v_c_codsec_pal);
            GeneraCodeBar(vTemporada, vPalet, v_c_codsec_pal);
            //printTool.Print("myPrinter");
            if (rdgTipoImpresion.SelectedIndex == 1)
            {
                rpt.ShowPreviewDialog();
            }
            else
            {
                if (t == 1)
                {
                    t++;
                    printTool.PrintDialog();
                    vPrinterName = printTool.PrinterSettings.PrinterName;
                }
                else
                {
                    printTool.Print(vPrinterName);
                }
            }

            return t;
        }
        private int Etiqueta_Distribuidor_AvocatsCanadaSinPacked(int t, string vPalet)
        {
            rpt_Etiqueta_Distribuidor_AvocatsSinPacked rpt = new rpt_Etiqueta_Distribuidor_AvocatsSinPacked();
            rpt.c_codigo_tem = vTemporada;
            rpt.c_codigo_pal = vPalet;
            rpt.c_codsec_pal = v_c_codsec_pal;
            rpt.c_codigo_dis = vDistribuidor;
            rpt.c_codigo_sec = vc_codigo_sec;
            rpt.voice1 = vVoice1;
            rpt.voice2 = vVoice2;
            rpt.c_codigo_jul = string.Empty;
            rpt.CargarParametros();
            ReportPrintTool printTool = new ReportPrintTool(rpt);
            ((SqlDataSource)rpt.DataSource).ConfigureDataConnection += Form1_ConfigureDataConnection;
            rpt.Parameters["COC"].Value = vCOC;
            rpt.Parameters["COC"].Visible = false;
            rpt.Parameters["COCGest"].Value = vCOCGest;
            rpt.Parameters["COCGest"].Visible = false;
            GeneraCodeBar(vTemporada, vPalet, v_c_codsec_pal);
            GeneraCodeBar(vTemporada, vPalet, v_c_codsec_pal);
            //printTool.Print("myPrinter");
            if (rdgTipoImpresion.SelectedIndex == 1)
            {
                rpt.ShowPreviewDialog();
            }
            else
            {
                if (t == 1)
                {
                    t++;
                    printTool.PrintDialog();
                    vPrinterName = printTool.PrinterSettings.PrinterName;
                }
                else
                {
                    printTool.Print(vPrinterName);
                }
            }

            return t;
        }
        private int Etiqueta_Distribuidor_AvocatsCanada(int t, string vPalet)
        {
            rpt_Etiqueta_Distribuidor_AvocatsCanada rpt = new rpt_Etiqueta_Distribuidor_AvocatsCanada();
            rpt.c_codigo_tem = vTemporada;
            rpt.c_codigo_pal = vPalet;
            rpt.c_codsec_pal = v_c_codsec_pal;
            rpt.c_codigo_dis = vDistribuidor;
            rpt.c_codigo_sec = vc_codigo_sec;
            rpt.voice1 = vVoice1;
            rpt.voice2 = vVoice2;
            rpt.CargarParametros();
            ReportPrintTool printTool = new ReportPrintTool(rpt);
            ((SqlDataSource)rpt.DataSource).ConfigureDataConnection += Form1_ConfigureDataConnection;
            rpt.Parameters["COC"].Value = vCOC;
            rpt.Parameters["COC"].Visible = false;
            rpt.Parameters["COCGest"].Value = vCOCGest;
            rpt.Parameters["COCGest"].Visible = false;
            GeneraCodeBar(vTemporada, vPalet, v_c_codsec_pal);
            GeneraCodeBar(vTemporada, vPalet, v_c_codsec_pal);
            //printTool.Print("myPrinter");
            if (rdgTipoImpresion.SelectedIndex == 1)
            {
                rpt.ShowPreviewDialog();
            }
            else
            {
                if (t == 1)
                {
                    t++;
                    printTool.PrintDialog();
                    vPrinterName = printTool.PrinterSettings.PrinterName;
                }
                else
                {
                    printTool.Print(vPrinterName);
                }
            }

            return t;
        }
        private int Etiqueta_Distribuidor_DonManuel(int t, string vPalet)
        {
            rpt_Etiqueta_Distribuidor_DonManuel rpt = new rpt_Etiqueta_Distribuidor_DonManuel();
            rpt.c_codigo_tem = vTemporada;
            rpt.c_codigo_pal = vPalet;
            rpt.c_codsec_pal = v_c_codsec_pal;
            rpt.c_codigo_dis = vDistribuidor;
            rpt.c_codigo_sec = vc_codigo_sec;
            rpt.voice1 = vVoice1;
            rpt.voice2 = vVoice2;
            rpt.CargarParametros();
            ReportPrintTool printTool = new ReportPrintTool(rpt);
            ((SqlDataSource)rpt.DataSource).ConfigureDataConnection += Form1_ConfigureDataConnection;
            rpt.Parameters["COC"].Value = vCOC;
            rpt.Parameters["COC"].Visible = false;
            rpt.Parameters["COCGest"].Value = vCOCGest;
            rpt.Parameters["COCGest"].Visible = false;
            //GeneraCodeBar(vTemporada, vPalet, v_c_codsec_pal);
            //GeneraCodeBar(vTemporada, vPalet, v_c_codsec_pal);
            //printTool.Print("myPrinter");
            if (rdgTipoImpresion.SelectedIndex == 1)
            {
                rpt.ShowPreviewDialog();
            }
            else
            {
                if (t == 1)
                {
                    t++;
                    printTool.PrintDialog();
                    vPrinterName = printTool.PrinterSettings.PrinterName;
                }
                else
                {
                    printTool.Print(vPrinterName);
                }
            }

            return t;
        }
        private int Etiqueta_Distribuidor_Canada(int t, string vPalet)
        {
            rpt_Etiqueta_Distribuidor_Canada_Nueva rpt = new rpt_Etiqueta_Distribuidor_Canada_Nueva();
            rpt.c_codigo_tem = vTemporada;
            rpt.c_codigo_pal = vPalet;
            rpt.c_codsec_pal = v_c_codsec_pal;
            rpt.c_codigo_dis = vDistribuidor;
            rpt.c_codigo_sec = vc_codigo_sec;
            rpt.voice1 = vVoice1;
            rpt.voice2 = vVoice2;
            rpt.CargarParametros();
            ReportPrintTool printTool = new ReportPrintTool(rpt);
            ((SqlDataSource)rpt.DataSource).ConfigureDataConnection += Form1_ConfigureDataConnection;
            rpt.Parameters["COC"].Value = vCOC;
            rpt.Parameters["COC"].Visible = false;
            rpt.Parameters["COCGest"].Value = vCOCGest;
            rpt.Parameters["COCGest"].Visible = false;
            GeneraCodeBar(vTemporada, vPalet, v_c_codsec_pal);
            GeneraCodeBar(vTemporada, vPalet, v_c_codsec_pal);
            //printTool.Print("myPrinter");
            if (rdgTipoImpresion.SelectedIndex == 1)
            {
                rpt.ShowPreviewDialog();
            }
            else
            {
                if (t == 1)
                {
                    t++;
                    printTool.PrintDialog();
                    vPrinterName = printTool.PrinterSettings.PrinterName;
                }
                else
                {
                    printTool.Print(vPrinterName);
                }
            }

            return t;
        }
        private int Etiqueta_Dubai(int t, string vPalet)
        {
            rpt_Etiqueta_Dubai rpt = new rpt_Etiqueta_Dubai();
            rpt.c_codigo_tem = vTemporada;
            rpt.c_codigo_pal = vPalet;
            rpt.c_codsec_pal = v_c_codsec_pal;
            rpt.c_codigo_dis = vDistribuidor;
            rpt.c_codigo_sec = vc_codigo_sec;
            rpt.voice1 = vVoice1;
            rpt.voice2 = vVoice2;
            rpt.CargarParametros();
            ReportPrintTool printTool = new ReportPrintTool(rpt);
            ((SqlDataSource)rpt.DataSource).ConfigureDataConnection += Form1_ConfigureDataConnection;
            rpt.Parameters["COC"].Value = vCOC;
            rpt.Parameters["COC"].Visible = false;
            rpt.Parameters["COCGest"].Value = vCOCGest;
            rpt.Parameters["COCGest"].Visible = false;
            GeneraCodeBar(vTemporada, vPalet, v_c_codsec_pal);
            GeneraCodeBar(vTemporada, vPalet, v_c_codsec_pal);
            //printTool.Print("myPrinter");
            if (rdgTipoImpresion.SelectedIndex == 1)
            {
                rpt.ShowPreviewDialog();
            }
            else
            {
                if (t == 1)
                {
                    t++;
                    printTool.PrintDialog();
                    vPrinterName = printTool.PrinterSettings.PrinterName;
                }
                else
                {
                    printTool.Print(vPrinterName);
                }
            }

            return t;
        }
        private int Etiqueta_SinDistribuidor(int t, string vPalet)
        {
            rpt_Etiqueta_SinDistribuidor rpt = new rpt_Etiqueta_SinDistribuidor();
            rpt.c_codigo_tem = vTemporada;
            rpt.c_codigo_pal = vPalet;
            rpt.c_codsec_pal = v_c_codsec_pal;
            rpt.c_codigo_dis = vDistribuidor;
            rpt.c_codigo_sec = vc_codigo_sec;
            rpt.voice1 = vVoice1;
            rpt.voice2 = vVoice2;
            rpt.c_codigo_jul = string.Empty;
            rpt.CargarParametros();
            ReportPrintTool printTool = new ReportPrintTool(rpt);
            ((SqlDataSource)rpt.DataSource).ConfigureDataConnection += Form1_ConfigureDataConnection;
            rpt.Parameters["COC"].Value = vCOC;
            rpt.Parameters["COC"].Visible = false;
            rpt.Parameters["COCGest"].Value = vCOCGest;
            rpt.Parameters["COCGest"].Visible = false;
            GeneraCodeBar(vTemporada, vPalet, v_c_codsec_pal);
            GeneraCodeBar(vTemporada, vPalet, v_c_codsec_pal);
            //printTool.Print("myPrinter");
            if (rdgTipoImpresion.SelectedIndex == 1)
            {
                rpt.ShowPreviewDialog();
            }
            else
            {
                if (t == 1)
                {
                    t++;
                    printTool.PrintDialog();
                    vPrinterName = printTool.PrinterSettings.PrinterName;
                }
                else
                {
                    printTool.Print(vPrinterName);
                }
            }

            return t;
        }
        private int Etiqueta_Distribuidor(int t, string vPalet)
        {
            rpt_Etiqueta_Distribuidor rpt = new rpt_Etiqueta_Distribuidor();
            rpt.c_codigo_tem = vTemporada;
            rpt.c_codigo_pal = vPalet;
            rpt.c_codsec_pal = v_c_codsec_pal;
            rpt.c_codigo_dis = vDistribuidor;
            rpt.c_codigo_sec = vc_codigo_sec;
            rpt.voice1 = vVoice1;
            rpt.voice2 = vVoice2;
            rpt.c_codigo_jul = string.Empty;
            rpt.CargarParametros();
            ReportPrintTool printTool = new ReportPrintTool(rpt);
            ((SqlDataSource)rpt.DataSource).ConfigureDataConnection += Form1_ConfigureDataConnection;
            rpt.Parameters["COC"].Value = vCOC;
            rpt.Parameters["COC"].Visible = false;
            rpt.Parameters["COCGest"].Value = vCOCGest;
            rpt.Parameters["COCGest"].Visible = false;
            GeneraCodeBar(vTemporada, vPalet, v_c_codsec_pal);
            GeneraCodeBar(vTemporada, vPalet, v_c_codsec_pal);
            //printTool.Print("myPrinter");
            if (rdgTipoImpresion.SelectedIndex == 1)
            {
                rpt.ShowPreviewDialog();
            }
            else
            {
                if (t == 1)
                {
                    t++;
                    printTool.PrintDialog();
                    vPrinterName = printTool.PrinterSettings.PrinterName;
                }
                else
                {
                    printTool.Print(vPrinterName);
                }
            }

            return t;
        }
        private int Etiqueta_PTI_Organic(int t, string vPalet, string vcproducto)
        {
            rpt_Etiqueta_PTI_Organic rpt = new rpt_Etiqueta_PTI_Organic();
            rpt.c_codigo_tem = vTemporada;
            rpt.c_codigo_pal = vPalet;
            rpt.c_codsec_pal = v_c_codsec_pal;
            rpt.c_codigo_dis = vDistribuidor;
            rpt.c_codigo_sec = vc_codigo_sec;
            rpt.voice1 = vVoice1;
            rpt.voice2 = vVoice2;
            rpt.c_codigo_jul = string.Empty;
            rpt.CargarParametros();
            ReportPrintTool printTool = new ReportPrintTool(rpt);
            ((SqlDataSource)rpt.DataSource).ConfigureDataConnection += Form1_ConfigureDataConnection;
            rpt.Parameters["COC"].Value = vCOC;
            rpt.Parameters["COC"].Visible = false;
            rpt.Parameters["COCGest"].Value = vCOCGest;
            rpt.Parameters["COCGest"].Visible = false;
            GeneraCodeBar(vTemporada, vPalet, v_c_codsec_pal);
            GeneraCodeBarUPC(vcproducto);
            //printTool.Print("myPrinter");
            if (rdgTipoImpresion.SelectedIndex == 1)
            {
                rpt.ShowPreviewDialog();
            }
            else
            {
                if (t == 1)
                {
                    t++;
                    printTool.PrintDialog();
                    vPrinterName = printTool.PrinterSettings.PrinterName;
                }
                else
                {
                    printTool.Print(vPrinterName);
                }
            }

            return t;
        }
        private int Etiqueta_UPC_Organic(int t, string vPalet, string vcproducto)
        {
            rpt_Etiqueta_UPC_Organic rpt = new rpt_Etiqueta_UPC_Organic();
            rpt.c_codigo_tem = vTemporada;
            rpt.c_codigo_pal = vPalet;
            rpt.c_codsec_pal = v_c_codsec_pal;
            rpt.c_codigo_dis = vDistribuidor;
            rpt.c_codigo_sec = vc_codigo_sec;
            rpt.voice1 = vVoice1;
            rpt.voice2 = vVoice2;
            rpt.c_codigo_jul = c_codigo_jul;
            rpt.CargarParametros();
            ReportPrintTool printTool = new ReportPrintTool(rpt);
            ((SqlDataSource)rpt.DataSource).ConfigureDataConnection += Form1_ConfigureDataConnection;
            rpt.Parameters["COC"].Value = vCOC;
            rpt.Parameters["COC"].Visible = false;
            rpt.Parameters["COCGest"].Value = vCOCGest;
            rpt.Parameters["COCGest"].Visible = false;
            GeneraCodeBar(vTemporada, vPalet, v_c_codsec_pal);
            GeneraCodeBarUPC(vcproducto);
            //printTool.Print("myPrinter");
            if (rdgTipoImpresion.SelectedIndex == 1)
            {
                rpt.ShowPreviewDialog();
            }
            else
            {
                if (t == 1)
                {
                    t++;
                    printTool.PrintDialog();
                    vPrinterName = printTool.PrinterSettings.PrinterName;
                }
                else
                {
                    printTool.Print(vPrinterName);
                }
            }

            return t;
        }
        private int Etiqueta_UPC_SAMS(int t, string vPalet, string vcproducto)
        {
            rpt_Etiqueta_UPC_SAMS rpt = new rpt_Etiqueta_UPC_SAMS();
            rpt.c_codigo_tem = vTemporada;
            rpt.c_codigo_pal = vPalet;
            rpt.c_codsec_pal = v_c_codsec_pal;
            rpt.c_codigo_dis = vDistribuidor;
            rpt.c_codigo_sec = vc_codigo_sec;
            rpt.voice1 = vVoice1;
            rpt.voice2 = vVoice2;
            rpt.c_codigo_jul = c_codigo_jul;
            rpt.CargarParametros();
            ReportPrintTool printTool = new ReportPrintTool(rpt);
            ((SqlDataSource)rpt.DataSource).ConfigureDataConnection += Form1_ConfigureDataConnection;
            ReportPrintTool print = new ReportPrintTool(rpt);
            rpt.Parameters["COC"].Value = vCOC;
            rpt.Parameters["COC"].Visible = false;
            rpt.Parameters["COCGest"].Value = vCOCGest;
            rpt.Parameters["COCGest"].Visible = false;
            //GeneraCodeBarJuliana(vTemporada, vPalet, v_c_codsec_pal, c_codigo_jul);
            GeneraCodeBarSAMS(vTemporada, vPalet, v_c_codsec_pal);
            GeneraCodeBarUPC(vcproducto);
            //printTool.Print("myPrinter");
            if (rdgTipoImpresion.SelectedIndex == 1)
            {
                rpt.ShowPreviewDialog();
            }
            else
            {
                if (t == 1)
                {
                    t++;
                    printTool.PrintDialog();
                    vPrinterName = printTool.PrinterSettings.PrinterName;
                }
                else
                {
                    printTool.Print(vPrinterName);
                }
            }

            return t;
        }
        private int Etiqueta_Canada_GEST_Juliana(int t, string vPalet, string vcproducto, Boolean plu)
        {
            string val_juliano = TresCero(FechaJuliana(DateTime.Now));
            c_codigo_jul = CodigoDisExt(vDistribuidor).Trim() + val_juliano.Substring(0, 1) + txtEstiba.Text.Substring(5, 5) + val_juliano.Substring(1, 2);
            rpt_Etiqueta_GEST_Canada rpt = new rpt_Etiqueta_GEST_Canada();
            rpt.c_codigo_tem = vTemporada;
            rpt.c_codigo_pal = vPalet; 
            rpt.c_codsec_pal = v_c_codsec_pal;
            rpt.c_codigo_dis = vDistribuidor;
            rpt.c_codigo_sec = vc_codigo_sec;
            rpt.voice1 = vVoice1;
            rpt.voice2 = vVoice2;
            rpt.c_codigo_jul = c_codigo_jul;
            rpt.plu = plu;
            rpt.CargarParametros();
            ReportPrintTool printTool = new ReportPrintTool(rpt);
            ((SqlDataSource)rpt.DataSource).ConfigureDataConnection += Form1_ConfigureDataConnection;
            ReportPrintTool print = new ReportPrintTool(rpt);
            rpt.Parameters["COC"].Value = vCOC;
            rpt.Parameters["COC"].Visible = false;
            rpt.Parameters["COCGest"].Value = vCOCGest;
            rpt.Parameters["COCGest"].Visible = false;
            GeneraCodeBarJuliana(vTemporada, vPalet, v_c_codsec_pal, c_codigo_jul);

            if (rdgTipoImpresion.SelectedIndex == 1)
            {
                rpt.ShowPreviewDialog();
            }
            else
            {
                if (t == 1)
                {
                    t++;
                    printTool.PrintDialog();
                    vPrinterName = printTool.PrinterSettings.PrinterName;
                }
                else
                {
                    printTool.Print(vPrinterName);
                }
            }

            return t;
        }
        private int Etiqueta_Canada_GEST_Maq_Juliana(int t, string vPalet, string vcproducto, Boolean plu)
        {
            string val_juliano = TresCero(FechaJuliana(DateTime.Now));
            c_codigo_jul = CodigoDisExt(vDistribuidor).Trim() + val_juliano.Substring(0, 1) + txtEstiba.Text.Substring(5, 5) + val_juliano.Substring(1, 2);
            rpt_Etiqueta_GEST_Canada_Maq rpt = new rpt_Etiqueta_GEST_Canada_Maq();
            rpt.c_codigo_tem = vTemporada;
            rpt.c_codigo_pal = vPalet;
            rpt.c_codsec_pal = v_c_codsec_pal;
            rpt.c_codigo_dis = vDistribuidor;
            rpt.c_codigo_sec = vc_codigo_sec;
            rpt.voice1 = vVoice1;
            rpt.voice2 = vVoice2;
            rpt.c_codigo_jul = c_codigo_jul;
            rpt.plu = plu;
            rpt.CargarParametros();
            ReportPrintTool printTool = new ReportPrintTool(rpt);
            ((SqlDataSource)rpt.DataSource).ConfigureDataConnection += Form1_ConfigureDataConnection;
            ReportPrintTool print = new ReportPrintTool(rpt);
            rpt.Parameters["COC"].Value = vCOC;
            rpt.Parameters["COC"].Visible = false;
            rpt.Parameters["COCGest"].Value = vCOCGest;
            rpt.Parameters["COCGest"].Visible = false;
            GeneraCodeBarJuliana(vTemporada, vPalet, v_c_codsec_pal, c_codigo_jul);

            if (rdgTipoImpresion.SelectedIndex == 1)
            {
                rpt.ShowPreviewDialog();
            }
            else
            {
                if (t == 1)
                {
                    t++;
                    printTool.PrintDialog();
                    vPrinterName = printTool.PrinterSettings.PrinterName;
                }
                else
                {
                    printTool.Print(vPrinterName);
                }
            }

            return t;
        }
        private int Etiqueta_Maquila_USDA(int t)
        {
            rpt_Etiqueta_Maquila_USDA rpt = new rpt_Etiqueta_Maquila_USDA();
            rpt.c_codigo_dis = vDistribuidor;
            rpt.CargarParametros();
            ReportPrintTool printTool = new ReportPrintTool(rpt);
            ((SqlDataSource)rpt.DataSource).ConfigureDataConnection += Form1_ConfigureDataConnection;
            ReportPrintTool print = new ReportPrintTool(rpt);
            if (rdgTipoImpresion.SelectedIndex == 1)
            {
                rpt.ShowPreviewDialog();
            }
            else
            {
                if (t == 1)
                {
                    t++;
                    printTool.PrintDialog();
                    vPrinterName = printTool.PrinterSettings.PrinterName;
                }
                else
                {
                    printTool.Print(vPrinterName);
                }
            }

            return t;
        }
        private int Etiqueta_Europa_GEST_Estiba(int t, string vPalet, string vcproducto, Boolean plu)
        {
            string val_juliano = TresCero(FechaJuliana(DateTime.Now));
            c_codigo_jul = CodigoDisExt(vDistribuidor).Trim() + val_juliano.Substring(0, 1) + txtEstiba.Text.Substring(5, 5) + val_juliano.Substring(1, 2);
            rpt_Etiqueta_GEST_Europa rpt = new rpt_Etiqueta_GEST_Europa();
            rpt.c_codigo_tem = vTemporada;
            rpt.c_codigo_pal = vPalet;
            rpt.c_codsec_pal = v_c_codsec_pal;
            rpt.c_codigo_dis = vDistribuidor;
            rpt.c_codigo_sec = vc_codigo_sec;
            rpt.voice1 = vVoice1;
            rpt.voice2 = vVoice2;
            rpt.c_codigo_jul = c_codigo_jul;
            rpt.plu = plu;
            rpt.CargarParametros();
            ReportPrintTool printTool = new ReportPrintTool(rpt);
            ((SqlDataSource)rpt.DataSource).ConfigureDataConnection += Form1_ConfigureDataConnection;
            ReportPrintTool print = new ReportPrintTool(rpt);
            rpt.Parameters["COC"].Value = vCOC;
            rpt.Parameters["COC"].Visible = false;
            rpt.Parameters["COCGest"].Value = vCOCGest;
            rpt.Parameters["COCGest"].Visible = false;
            GeneraCodeBarJuliana(vTemporada, vPalet, v_c_codsec_pal, c_codigo_jul);

            if (rdgTipoImpresion.SelectedIndex == 1)
            {
                rpt.ShowPreviewDialog();
            }
            else
            {
                if (t == 1)
                {
                    t++;
                    printTool.PrintDialog();
                    vPrinterName = printTool.PrinterSettings.PrinterName;
                }
                else
                {
                    printTool.Print(vPrinterName);
                }
            }

            return t;
        }
        private int Etiqueta_SinUSDA_Maquila_Estiba(int t, string vPalet, string vcproducto, Boolean plu)
        {
            string val_juliano = TresCero(FechaJuliana(DateTime.Now));
            c_codigo_jul = CodigoDisExt(vDistribuidor).Trim() + val_juliano.Substring(0, 1) + txtEstiba.Text.Substring(5, 5) + val_juliano.Substring(1, 2);
            rpt_Etiqueta_Maquila_SinUSDA_Org rpt = new rpt_Etiqueta_Maquila_SinUSDA_Org();
            rpt.c_codigo_tem = vTemporada;
            rpt.c_codigo_pal = vPalet;
            rpt.c_codsec_pal = v_c_codsec_pal;
            rpt.c_codigo_dis = vDistribuidor;
            rpt.c_codigo_sec = vc_codigo_sec;
            rpt.voice1 = vVoice1;
            rpt.voice2 = vVoice2;
            rpt.c_codigo_jul = c_codigo_jul;
            rpt.plu = plu;
            rpt.CargarParametros();
            ReportPrintTool printTool = new ReportPrintTool(rpt);
            ((SqlDataSource)rpt.DataSource).ConfigureDataConnection += Form1_ConfigureDataConnection;
            ReportPrintTool print = new ReportPrintTool(rpt);
            rpt.Parameters["COC"].Value = vCOC;
            rpt.Parameters["COC"].Visible = false;
            rpt.Parameters["COCGest"].Value = string.Empty;
            rpt.Parameters["COCGest"].Visible = false;
            rpt.Parameters["DryMatter"].Value = txtMateriaSeca.EditValue.ToString() + " %";
            rpt.Parameters["DryMatter"].Visible = false;
            GeneraCodeBarJuliana(vTemporada, vPalet, v_c_codsec_pal, c_codigo_jul);

            if (rdgTipoImpresion.SelectedIndex == 1)
            {
                rpt.ShowPreviewDialog();
            }
            else
            {
                if (t == 1)
                {
                    t++;
                    printTool.PrintDialog();
                    vPrinterName = printTool.PrinterSettings.PrinterName;
                }
                else
                {
                    printTool.Print(vPrinterName);
                }
            }

            return t;
        }
        private int Etiqueta_USDA_Maquila_Estiba(int t, string vPalet, string vcproducto, Boolean plu)
        {
            string val_juliano = TresCero(FechaJuliana(DateTime.Now));
            c_codigo_jul = CodigoDisExt(vDistribuidor).Trim() + val_juliano.Substring(0, 1) + txtEstiba.Text.Substring(5, 5) + val_juliano.Substring(1, 2);
            rpt_Etiqueta_Maquila_USDA_Org rpt = new rpt_Etiqueta_Maquila_USDA_Org();
            rpt.c_codigo_tem = vTemporada;
            rpt.c_codigo_pal = vPalet;
            rpt.c_codsec_pal = v_c_codsec_pal;
            rpt.c_codigo_dis = vDistribuidor;
            rpt.c_codigo_sec = vc_codigo_sec;
            rpt.voice1 = vVoice1;
            rpt.voice2 = vVoice2;
            rpt.c_codigo_jul = c_codigo_jul;
            rpt.plu = plu;
            rpt.CargarParametros();
            ReportPrintTool printTool = new ReportPrintTool(rpt);
            ((SqlDataSource)rpt.DataSource).ConfigureDataConnection += Form1_ConfigureDataConnection;
            ReportPrintTool print = new ReportPrintTool(rpt);
            rpt.Parameters["COC"].Value = vCOC;
            rpt.Parameters["COC"].Visible = false;
            rpt.Parameters["COCGest"].Value = string.Empty;
            rpt.Parameters["COCGest"].Visible = false;
            rpt.Parameters["DryMatter"].Value = txtMateriaSeca.EditValue.ToString() + " %";
            rpt.Parameters["DryMatter"].Visible = false;
            GeneraCodeBarJuliana(vTemporada, vPalet, v_c_codsec_pal, c_codigo_jul);

            if (rdgTipoImpresion.SelectedIndex == 1)
            {
                rpt.ShowPreviewDialog();
            }
            else
            {
                if (t == 1)
                {
                    t++;
                    printTool.PrintDialog();
                    vPrinterName = printTool.PrinterSettings.PrinterName;
                }
                else
                {
                    printTool.Print(vPrinterName);
                }
            }

            return t;
        }
        private int Etiqueta_USDA_Maquila_Estiba2(int t, string vPalet, string vcproducto, Boolean plu)
        {
            string val_juliano = TresCero(FechaJuliana(DateTime.Now));
            c_codigo_jul = CodigoDisExt(vDistribuidor).Trim() + val_juliano.Substring(0, 1) + txtEstiba.Text.Substring(5, 5) + val_juliano.Substring(1, 2);
            rpt_Etiqueta_Maquila_USDA_Org_Mod rpt = new rpt_Etiqueta_Maquila_USDA_Org_Mod();
            rpt.c_codigo_tem = vTemporada;
            rpt.c_codigo_pal = vPalet;
            rpt.c_codsec_pal = v_c_codsec_pal;
            rpt.c_codigo_dis = vDistribuidor;
            rpt.c_codigo_sec = vc_codigo_sec;
            rpt.voice1 = vVoice1;
            rpt.voice2 = vVoice2;
            rpt.c_codigo_jul = c_codigo_jul;
            rpt.plu = plu;
            rpt.CargarParametros();
            ReportPrintTool printTool = new ReportPrintTool(rpt);
            ((SqlDataSource)rpt.DataSource).ConfigureDataConnection += Form1_ConfigureDataConnection;
            ReportPrintTool print = new ReportPrintTool(rpt);
            rpt.Parameters["COC"].Value = vCOC;
            rpt.Parameters["COC"].Visible = false;
            rpt.Parameters["COCGest"].Value = vCOCGest;
            rpt.Parameters["COCGest"].Visible = false;
            rpt.Parameters["DryMatter"].Value = txtMateriaSeca.EditValue.ToString() + " %";
            rpt.Parameters["DryMatter"].Visible = false;
            GeneraCodeBarJuliana(vTemporada, vPalet, v_c_codsec_pal, c_codigo_jul);

            if (rdgTipoImpresion.SelectedIndex == 1)
            {
                rpt.ShowPreviewDialog();
            }
            else
            {
                if (t == 1)
                {
                    t++;
                    printTool.PrintDialog();
                    vPrinterName = printTool.PrinterSettings.PrinterName;
                }
                else
                {
                    printTool.Print(vPrinterName);
                }
            }

            return t;
        }
        private int Etiqueta_Europa_Maquila_Estiba(int t, string vPalet, string vcproducto, Boolean plu)
        {
            string val_juliano = TresCero(FechaJuliana(DateTime.Now));
            c_codigo_jul = CodigoDisExt(vDistribuidor).Trim() + val_juliano.Substring(0, 1) + txtEstiba.Text.Substring(5, 5) + val_juliano.Substring(1, 2);
            rpt_Etiqueta_Maquila_Europa rpt = new rpt_Etiqueta_Maquila_Europa();
            rpt.c_codigo_tem = vTemporada;
            rpt.c_codigo_pal = vPalet;
            rpt.c_codsec_pal = v_c_codsec_pal;
            rpt.c_codigo_dis = vDistribuidor;
            rpt.c_codigo_sec = vc_codigo_sec;
            rpt.voice1 = vVoice1;
            rpt.voice2 = vVoice2;
            rpt.c_codigo_jul = c_codigo_jul;
            rpt.plu = plu;
            rpt.CargarParametros();
            ReportPrintTool printTool = new ReportPrintTool(rpt);
            ((SqlDataSource)rpt.DataSource).ConfigureDataConnection += Form1_ConfigureDataConnection;
            ReportPrintTool print = new ReportPrintTool(rpt);
            rpt.Parameters["COC"].Value = vCOC;
            rpt.Parameters["COC"].Visible = false;
            rpt.Parameters["COCGest"].Value = string.Empty;
            rpt.Parameters["COCGest"].Visible = false;
            rpt.Parameters["DryMatter"].Value = txtMateriaSeca.EditValue.ToString()+" %";
            rpt.Parameters["DryMatter"].Visible = false;
            GeneraCodeBarJuliana(vTemporada, vPalet, v_c_codsec_pal, c_codigo_jul);

            if (rdgTipoImpresion.SelectedIndex == 1)
            {
                rpt.ShowPreviewDialog();
            }
            else
            {
                if (t == 1)
                {
                    t++;
                    printTool.PrintDialog();
                    vPrinterName = printTool.PrinterSettings.PrinterName;
                }
                else
                {
                    printTool.Print(vPrinterName);
                }
            }

            return t;
        }
        private int Etiqueta_USDA_GEST_Juliana(int t, string vPalet, string vcproducto, Boolean plu)
        {
            string val_juliano = TresCero(FechaJuliana(DateTime.Now));
            c_codigo_jul = CodigoDisExt(vDistribuidor).Trim() + val_juliano.Substring(0, 1) + txtEstiba.Text.Substring(5, 5) + val_juliano.Substring(1, 2);
            rpt_Etiqueta_GEST_USDA rpt = new rpt_Etiqueta_GEST_USDA();
            rpt.c_codigo_tem = vTemporada;
            rpt.c_codigo_pal = vPalet;
            rpt.c_codsec_pal = v_c_codsec_pal;
            rpt.c_codigo_dis = vDistribuidor;
            rpt.c_codigo_sec = vc_codigo_sec;
            rpt.voice1 = vVoice1;
            rpt.voice2 = vVoice2;
            rpt.c_codigo_jul = c_codigo_jul;
            rpt.plu = plu;
            rpt.CargarParametros();
            ReportPrintTool printTool = new ReportPrintTool(rpt);
            ((SqlDataSource)rpt.DataSource).ConfigureDataConnection += Form1_ConfigureDataConnection;
            ReportPrintTool print = new ReportPrintTool(rpt);
            rpt.Parameters["COC"].Value = vCOC;
            rpt.Parameters["COC"].Visible = false;
            rpt.Parameters["COCGest"].Value = vCOCGest;
            rpt.Parameters["COCGest"].Visible = false;
            GeneraCodeBarJuliana(vTemporada, vPalet, v_c_codsec_pal, c_codigo_jul);

            if (rdgTipoImpresion.SelectedIndex == 1)
            {
                rpt.ShowPreviewDialog();
            }
            else
            {
                if (t == 1)
                {
                    t++;
                    printTool.PrintDialog();
                    vPrinterName = printTool.PrinterSettings.PrinterName;
                }
                else
                {
                    printTool.Print(vPrinterName);
                }
            }

            return t;
        }
        private int Etiqueta_Canada_Index_Juliana(int t, string vPalet, string vcproducto, Boolean plu)
        {
            string val_juliano = TresCero(FechaJuliana(DateTime.Now));
            c_codigo_jul = CodigoDisExt(vDistribuidor).Trim() + val_juliano.Substring(0, 1) + txtEstiba.Text.Substring(5, 5) + val_juliano.Substring(1, 2);
            rpt_Etiqueta_Index_Canada rpt = new rpt_Etiqueta_Index_Canada(vTemporada, vPalet, v_c_codsec_pal, vDistribuidor, vc_codigo_sec, vVoice1, vVoice2, c_codigo_jul, plu);
            ReportPrintTool printTool = new ReportPrintTool(rpt);
            ((SqlDataSource)rpt.DataSource).ConfigureDataConnection += Form1_ConfigureDataConnection;
            ReportPrintTool print = new ReportPrintTool(rpt);
            rpt.Parameters["COC"].Value = vCOC;
            rpt.Parameters["COC"].Visible = false;
            rpt.Parameters["COCGest"].Value = vCOCGest;
            rpt.Parameters["COCGest"].Visible = false;
            GeneraCodeBarJuliana(vTemporada, vPalet, v_c_codsec_pal, c_codigo_jul);

            if (rdgTipoImpresion.SelectedIndex == 1)
            {
                rpt.ShowPreviewDialog();
            }
            else
            {
                if (t == 1)
                {
                    t++;
                    printTool.PrintDialog();
                    vPrinterName = printTool.PrinterSettings.PrinterName;
                }
                else
                {
                    printTool.Print(vPrinterName);
                }
            }

            return t;
        }
        private int Etiqueta_USDA_Index_Juliana(int t, string vPalet, string vcproducto, Boolean plu)
        {
            string val_juliano = TresCero(FechaJuliana(DateTime.Now));
            c_codigo_jul = CodigoDisExt(vDistribuidor).Trim() + val_juliano.Substring(0, 1) + txtEstiba.Text.Substring(5, 5) + val_juliano.Substring(1, 2);
            rpt_Etiqueta_Index_USDA rpt = new rpt_Etiqueta_Index_USDA(vTemporada, vPalet, v_c_codsec_pal, vDistribuidor, vc_codigo_sec, vVoice1, vVoice2, c_codigo_jul, plu);
            ReportPrintTool printTool = new ReportPrintTool(rpt);
            ((SqlDataSource)rpt.DataSource).ConfigureDataConnection += Form1_ConfigureDataConnection;
            ReportPrintTool print = new ReportPrintTool(rpt);
            rpt.Parameters["COC"].Value = vCOC;
            rpt.Parameters["COC"].Visible = false;
            rpt.Parameters["COCGest"].Value = vCOCGest;
            rpt.Parameters["COCGest"].Visible = false;
            GeneraCodeBarJuliana(vTemporada, vPalet, v_c_codsec_pal, c_codigo_jul);

            if (rdgTipoImpresion.SelectedIndex == 1)
            {
                rpt.ShowPreviewDialog();
            }
            else
            {
                if (t == 1)
                {
                    t++;
                    printTool.PrintDialog();
                    vPrinterName = printTool.PrinterSettings.PrinterName;
                }
                else
                {
                    printTool.Print(vPrinterName);
                }
            }

            return t;
        }
        private int Etiqueta_Japon_Index_Juliana(int t, string vPalet, string vcproducto, Boolean plu)
        {
            string val_juliano = TresCero(FechaJuliana(DateTime.Now));
            c_codigo_jul = CodigoDisExt(vDistribuidor).Trim() + val_juliano.Substring(0, 1) + txtEstiba.Text.Substring(5, 5) + val_juliano.Substring(1, 2);
            rpt_Etiqueta_Index_Japon rpt = new rpt_Etiqueta_Index_Japon(vTemporada, vPalet, v_c_codsec_pal, vDistribuidor, vc_codigo_sec, vVoice1, vVoice2, c_codigo_jul, plu);
            ReportPrintTool printTool = new ReportPrintTool(rpt);
            ((SqlDataSource)rpt.DataSource).ConfigureDataConnection += Form1_ConfigureDataConnection;
            ReportPrintTool print = new ReportPrintTool(rpt);
            rpt.Parameters["COC"].Value = vCOC;
            rpt.Parameters["COC"].Visible = false;
            rpt.Parameters["COCGest"].Value = vCOCGest;
            rpt.Parameters["COCGest"].Visible = false;
            GeneraCodeBarJuliana(vTemporada, vPalet, v_c_codsec_pal, c_codigo_jul);
            
            if (rdgTipoImpresion.SelectedIndex == 1)
            {
                rpt.ShowPreviewDialog();
            }
            else
            {
                if (t == 1)
                {
                    t++;
                    printTool.PrintDialog();
                    vPrinterName = printTool.PrinterSettings.PrinterName;
                }
                else
                {
                    printTool.Print(vPrinterName);
                }
            }

            return t;
        }
        private int Etiqueta_UPC_Anderson_Juliana(int t, string vPalet, string vcproducto, Boolean plu)
        {
            string val_juliano = TresCero(FechaJuliana(DateTime.Now));
            c_codigo_jul = CodigoDisExt(vDistribuidor).Trim() + val_juliano.Substring(0, 1) + txtEstiba.Text.Substring(5, 5) + val_juliano.Substring(1, 2);
            rpt_Etiqueta_UPC_AndersonJuliana rpt = new rpt_Etiqueta_UPC_AndersonJuliana();
            rpt.c_codigo_tem = vTemporada;
            rpt.c_codigo_pal = vPalet;
            rpt.c_codsec_pal = v_c_codsec_pal;
            rpt.c_codigo_dis = vDistribuidor;
            rpt.c_codigo_sec = vc_codigo_sec;
            rpt.voice1 = vVoice1;
            rpt.voice2 = vVoice2;
            rpt.c_codigo_jul = c_codigo_jul;
            rpt.plu = plu;
            rpt.CargarParametros();
            ReportPrintTool printTool = new ReportPrintTool(rpt);
            ((SqlDataSource)rpt.DataSource).ConfigureDataConnection += Form1_ConfigureDataConnection;
            ReportPrintTool print = new ReportPrintTool(rpt);
            rpt.Parameters["COC"].Value = vCOC;
            rpt.Parameters["COC"].Visible = false;
            rpt.Parameters["COCGest"].Value = vCOCGest;
            rpt.Parameters["COCGest"].Visible = false;
            GeneraCodeBarJuliana(vTemporada, vPalet, v_c_codsec_pal, c_codigo_jul);
            //GeneraCodeBarSAMS(vTemporada, vPalet, v_c_codsec_pal);
            GeneraCodeBarUPCA(vcproducto);
            //printTool.Print("myPrinter");
            if (rdgTipoImpresion.SelectedIndex == 1)
            {
                rpt.ShowPreviewDialog();
            }
            else
            {
                if (t == 1)
                {
                    t++;
                    printTool.PrintDialog();
                    vPrinterName = printTool.PrinterSettings.PrinterName;
                }
                else
                {
                    printTool.Print(vPrinterName);
                }
            }

            return t;
        }
        private int Etiqueta_UPC_Index_Juliana(int t, string vPalet, string vcproducto, Boolean plu)
        {
            string val_juliano = TresCero(FechaJuliana(DateTime.Now));
            c_codigo_jul = CodigoDisExt(vDistribuidor).Trim() + val_juliano.Substring(0, 1) + txtEstiba.Text.Substring(5, 5) + val_juliano.Substring(1, 2);
            rpt_Etiqueta_UPC_IndexJuliana rpt = new rpt_Etiqueta_UPC_IndexJuliana();
            rpt.c_codigo_tem = vTemporada;
            rpt.c_codigo_pal = vPalet;
            rpt.c_codsec_pal = v_c_codsec_pal;
            rpt.c_codigo_dis = vDistribuidor;
            rpt.c_codigo_sec = vc_codigo_sec;
            rpt.voice1 = vVoice1;
            rpt.voice2 = vVoice2;
            rpt.c_codigo_jul = c_codigo_jul;
            rpt.plu = plu;
            rpt.CargarParametros();
            ReportPrintTool printTool = new ReportPrintTool(rpt);
            ((SqlDataSource)rpt.DataSource).ConfigureDataConnection += Form1_ConfigureDataConnection;
            ReportPrintTool print = new ReportPrintTool(rpt);
            rpt.Parameters["COC"].Value = vCOC;
            rpt.Parameters["COC"].Visible = false;
            rpt.Parameters["COCGest"].Value = vCOCGest;
            rpt.Parameters["COCGest"].Visible = false;
            GeneraCodeBarJuliana(vTemporada, vPalet, v_c_codsec_pal, c_codigo_jul);
            //GeneraCodeBarSAMS(vTemporada, vPalet, v_c_codsec_pal);
            GeneraCodeBarUPCA(vcproducto);
            rpt.CargarParametros();
            //printTool.Print("myPrinter");
            if (rdgTipoImpresion.SelectedIndex == 1)
            {
                rpt.ShowPreviewDialog();
            }
            else
            {
                if (t == 1)
                {
                    t++;
                    printTool.PrintDialog();
                    vPrinterName = printTool.PrinterSettings.PrinterName;
                }
                else
                {
                    printTool.Print(vPrinterName);
                }
            }

            return t;
        }
        private int Etiqueta_UPC_Anderson_Juliana_Organic(int t, string vPalet, string vcproducto, Boolean plu)
        {
            string val_juliano = TresCero(FechaJuliana(DateTime.Now));
            c_codigo_jul = CodigoDisExt(vDistribuidor).Trim() + val_juliano.Substring(0, 1) + txtEstiba.Text.Substring(5, 5) + val_juliano.Substring(1, 2);
            rpt_Etiqueta_UPC_AndersonJuliana_Organic rpt = new rpt_Etiqueta_UPC_AndersonJuliana_Organic();
            rpt.c_codigo_tem = vTemporada;
            rpt.c_codigo_pal = vPalet;
            rpt.c_codsec_pal = v_c_codsec_pal;
            rpt.c_codigo_dis = vDistribuidor;
            rpt.c_codigo_sec = vc_codigo_sec;
            rpt.voice1 = vVoice1;
            rpt.voice2 = vVoice2;
            rpt.c_codigo_jul = c_codigo_jul;
            rpt.plu = plu;
            rpt.CargarParametros();
            ReportPrintTool printTool = new ReportPrintTool(rpt);
            ((SqlDataSource)rpt.DataSource).ConfigureDataConnection += Form1_ConfigureDataConnection;
            ReportPrintTool print = new ReportPrintTool(rpt);
            rpt.Parameters["COC"].Value = vCOC;
            rpt.Parameters["COC"].Visible = false;
            rpt.Parameters["COCGest"].Value = vCOCGest;
            rpt.Parameters["COCGest"].Visible = false;
            GeneraCodeBarJuliana(vTemporada, vPalet, v_c_codsec_pal, c_codigo_jul);
            //GeneraCodeBarSAMS(vTemporada, vPalet, v_c_codsec_pal);
            GeneraCodeBarUPCA(vcproducto);
            //printTool.Print("myPrinter");
            if (rdgTipoImpresion.SelectedIndex == 1)
            {
                rpt.ShowPreviewDialog();
            }
            else
            {
                if (t == 1)
                {
                    t++;
                    printTool.PrintDialog();
                    vPrinterName = printTool.PrinterSettings.PrinterName;
                }
                else
                {
                    printTool.Print(vPrinterName);
                }
            }

            return t;
        }
        private int Etiqueta_UPC_Anderson(int t, string vPalet, string vcproducto, Boolean plu)
        {
            rpt_Etiqueta_UPC_Anderson rpt = new rpt_Etiqueta_UPC_Anderson();
            rpt.c_codigo_tem = vTemporada;
            rpt.c_codigo_pal = vPalet;
            rpt.c_codsec_pal = v_c_codsec_pal;
            rpt.c_codigo_dis = vDistribuidor;
            rpt.c_codigo_sec = vc_codigo_sec;
            rpt.voice1 = vVoice1;
            rpt.voice2 = vVoice2;
            rpt.c_codigo_jul = c_codigo_jul;
            rpt.plu = plu;
            rpt.CargarParametros();
            ReportPrintTool printTool = new ReportPrintTool(rpt);
            ((SqlDataSource)rpt.DataSource).ConfigureDataConnection += Form1_ConfigureDataConnection;
            ReportPrintTool print = new ReportPrintTool(rpt);
            rpt.Parameters["COC"].Value = vCOC;
            rpt.Parameters["COC"].Visible = false;
            rpt.Parameters["COCGest"].Value = vCOCGest;
            rpt.Parameters["COCGest"].Visible = false;
            //GeneraCodeBarJuliana(vTemporada, vPalet, v_c_codsec_pal, c_codigo_jul);
            GeneraCodeBarSAMS(vTemporada, vPalet, v_c_codsec_pal);
            GeneraCodeBarUPC(vcproducto);
            //printTool.Print("myPrinter");
            if (rdgTipoImpresion.SelectedIndex == 1)
            {
                rpt.ShowPreviewDialog();
            }
            else
            {
                if (t == 1)
                {
                    t++;
                    printTool.PrintDialog();
                    vPrinterName = printTool.PrinterSettings.PrinterName;
                }
                else
                {
                    printTool.Print(vPrinterName);
                }
            }

            return t;
        }
        private int Etiqueta_EAN13_4kg_Mission(int t, string vPalet, string vcproducto, Boolean plu)
        {
            rpt_Etiqueta_EAN13_4kg_Mission rpt = new rpt_Etiqueta_EAN13_4kg_Mission();
            rpt.c_codigo_tem = vTemporada;
            rpt.c_codigo_pal = vPalet;
            rpt.c_codsec_pal = v_c_codsec_pal;
            rpt.c_codigo_dis = vDistribuidor;
            rpt.c_codigo_sec = vc_codigo_sec;
            rpt.voice1 = vVoice1;
            rpt.voice2 = vVoice2;
            rpt.c_codigo_jul = c_codigo_jul;
            rpt.plu = plu;
            rpt.CargarParametros();
            ReportPrintTool printTool = new ReportPrintTool(rpt);
            ((SqlDataSource)rpt.DataSource).ConfigureDataConnection += Form1_ConfigureDataConnection;
            ReportPrintTool print = new ReportPrintTool(rpt);
            rpt.Parameters["COC"].Value = vCOC;
            rpt.Parameters["COC"].Visible = false;
            rpt.Parameters["COCGest"].Value = vCOCGest;
            rpt.Parameters["COCGest"].Visible = false;
            //GeneraCodeBarJuliana(vTemporada, vPalet, v_c_codsec_pal, c_codigo_jul);
            GeneraCodeBar(vTemporada, vPalet, v_c_codsec_pal);
            GeneraCodeBarEAN13(vcproducto);
            //printTool.Print("myPrinter");
            if (rdgTipoImpresion.SelectedIndex == 1)
            {
                rpt.ShowPreviewDialog();
            }
            else
            {
                if (t == 1)
                {
                    t++;
                    printTool.PrintDialog();
                    vPrinterName = printTool.PrinterSettings.PrinterName;
                }
                else
                {
                    printTool.Print(vPrinterName);
                }
            }

            return t;
        }
        private int Etiqueta_EAN13_Mission(int t, string vPalet, string vcproducto, Boolean plu)
        {
            rpt_Etiqueta_EAN13_Mission rpt = new rpt_Etiqueta_EAN13_Mission();
            rpt.c_codigo_tem = vTemporada;
            rpt.c_codigo_pal = vPalet;
            rpt.c_codsec_pal = v_c_codsec_pal;
            rpt.c_codigo_dis = vDistribuidor;
            rpt.c_codigo_sec = vc_codigo_sec;
            rpt.voice1 = vVoice1;
            rpt.voice2 = vVoice2;
            rpt.c_codigo_jul = c_codigo_jul;
            rpt.plu = plu;
            rpt.CargarParametros();
            ReportPrintTool printTool = new ReportPrintTool(rpt);
            ((SqlDataSource)rpt.DataSource).ConfigureDataConnection += Form1_ConfigureDataConnection;
            ReportPrintTool print = new ReportPrintTool(rpt);
            rpt.Parameters["COC"].Value = vCOC;
            rpt.Parameters["COC"].Visible = false;
            rpt.Parameters["COCGest"].Value = vCOCGest;
            rpt.Parameters["COCGest"].Visible = false;
            //GeneraCodeBarJuliana(vTemporada, vPalet, v_c_codsec_pal, c_codigo_jul);
            GeneraCodeBar(vTemporada, vPalet, v_c_codsec_pal);
            GeneraCodeBarEAN13(vcproducto);
            //printTool.Print("myPrinter");
            if (rdgTipoImpresion.SelectedIndex == 1)
            {
                rpt.ShowPreviewDialog();
            }
            else
            {
                if (t == 1)
                {
                    t++;
                    printTool.PrintDialog();
                    vPrinterName = printTool.PrinterSettings.PrinterName;
                }
                else
                {
                    printTool.Print(vPrinterName);
                }
            }

            return t;
        }
        private int Etiqueta_EAN13_Mission_2071(int t, string vPalet, string vcproducto, Boolean plu)
        {
            rpt_Etiqueta_EAN13_PLU_2071 rpt = new rpt_Etiqueta_EAN13_PLU_2071();
            rpt.c_codigo_tem = vTemporada;
            rpt.c_codigo_pal = vPalet;
            rpt.c_codsec_pal = v_c_codsec_pal;
            rpt.c_codigo_dis = vDistribuidor;
            rpt.c_codigo_sec = vc_codigo_sec;
            rpt.voice1 = vVoice1;
            rpt.voice2 = vVoice2;
            rpt.c_codigo_jul = c_codigo_jul;
            rpt.plu = plu;
            rpt.CargarParametros();
            ReportPrintTool printTool = new ReportPrintTool(rpt);
            ((SqlDataSource)rpt.DataSource).ConfigureDataConnection += Form1_ConfigureDataConnection;
            ReportPrintTool print = new ReportPrintTool(rpt);
            rpt.Parameters["COC"].Value = vCOC;
            rpt.Parameters["COC"].Visible = false;
            rpt.Parameters["COCGest"].Value = vCOCGest;
            rpt.Parameters["COCGest"].Visible = false;
            //GeneraCodeBarJuliana(vTemporada, vPalet, v_c_codsec_pal, c_codigo_jul);
            GeneraCodeBar(vTemporada, vPalet, v_c_codsec_pal);
            GeneraCodeBarEAN13(vcproducto);
            //printTool.Print("myPrinter");
            if (rdgTipoImpresion.SelectedIndex == 1)
            {
                rpt.ShowPreviewDialog();
            }
            else
            {
                if (t == 1)
                {
                    t++;
                    printTool.PrintDialog();
                    vPrinterName = printTool.PrinterSettings.PrinterName;
                }
                else
                {
                    printTool.Print(vPrinterName);
                }
            }

            return t;
        }
        private int Etiqueta_EAN13_Mission_2006(int t, string vPalet, string vcproducto, Boolean plu)
        {
            rpt_Etiqueta_EAN13_PLU_2006 rpt = new rpt_Etiqueta_EAN13_PLU_2006();
            rpt.c_codigo_tem = vTemporada;
            rpt.c_codigo_pal = vPalet;
            rpt.c_codsec_pal = v_c_codsec_pal;
            rpt.c_codigo_dis = vDistribuidor;
            rpt.c_codigo_sec = vc_codigo_sec;
            rpt.voice1 = vVoice1;
            rpt.voice2 = vVoice2;
            rpt.c_codigo_jul = c_codigo_jul;
            rpt.plu = plu;
            rpt.CargarParametros();
            ReportPrintTool printTool = new ReportPrintTool(rpt);
            ((SqlDataSource)rpt.DataSource).ConfigureDataConnection += Form1_ConfigureDataConnection;
            ReportPrintTool print = new ReportPrintTool(rpt);
            rpt.Parameters["COC"].Value = vCOC;
            rpt.Parameters["COC"].Visible = false;
            rpt.Parameters["COCGest"].Value = vCOCGest;
            rpt.Parameters["COCGest"].Visible = false;
            //GeneraCodeBarJuliana(vTemporada, vPalet, v_c_codsec_pal, c_codigo_jul);
            GeneraCodeBar(vTemporada, vPalet, v_c_codsec_pal);
            GeneraCodeBarEAN13(vcproducto);
            //printTool.Print("myPrinter");
            if (rdgTipoImpresion.SelectedIndex == 1)
            {
                rpt.ShowPreviewDialog();
            }
            else
            {
                if (t == 1)
                {
                    t++;
                    printTool.PrintDialog();
                    vPrinterName = printTool.PrinterSettings.PrinterName;
                }
                else
                {
                    printTool.Print(vPrinterName);
                }
            }

            return t;
        }
        private int Etiqueta_EAN13_Mission_2028(int t, string vPalet, string vcproducto, Boolean plu)
        {
            rpt_Etiqueta_EAN13_PLU_2028 rpt = new rpt_Etiqueta_EAN13_PLU_2028();
            rpt.c_codigo_tem = vTemporada;
            rpt.c_codigo_pal = vPalet;
            rpt.c_codsec_pal = v_c_codsec_pal;
            rpt.c_codigo_dis = vDistribuidor;
            rpt.c_codigo_sec = vc_codigo_sec;
            rpt.voice1 = vVoice1;
            rpt.voice2 = vVoice2;
            rpt.c_codigo_jul = c_codigo_jul;
            rpt.plu = plu;
            rpt.CargarParametros();
            ReportPrintTool printTool = new ReportPrintTool(rpt);
            ((SqlDataSource)rpt.DataSource).ConfigureDataConnection += Form1_ConfigureDataConnection;
            ReportPrintTool print = new ReportPrintTool(rpt);
            rpt.Parameters["COC"].Value = vCOC;
            rpt.Parameters["COC"].Visible = false;
            rpt.Parameters["COCGest"].Value = vCOCGest;
            rpt.Parameters["COCGest"].Visible = false;
            //GeneraCodeBarJuliana(vTemporada, vPalet, v_c_codsec_pal, c_codigo_jul);
            GeneraCodeBar(vTemporada, vPalet, v_c_codsec_pal);
            GeneraCodeBarEAN13(vcproducto);
            //printTool.Print("myPrinter");
            if (rdgTipoImpresion.SelectedIndex == 1)
            {
                rpt.ShowPreviewDialog();
            }
            else
            {
                if (t == 1)
                {
                    t++;
                    printTool.PrintDialog();
                    vPrinterName = printTool.PrinterSettings.PrinterName;
                }
                else
                {
                    printTool.Print(vPrinterName);
                }
            }

            return t;
        }
        private int Etiqueta_EAN13_Mission_2029(int t, string vPalet, string vcproducto, Boolean plu)
        {
            rpt_Etiqueta_EAN13_Mission_2029 rpt = new rpt_Etiqueta_EAN13_Mission_2029();
            rpt.c_codigo_tem = vTemporada;
            rpt.c_codigo_pal = vPalet;
            rpt.c_codsec_pal = v_c_codsec_pal;
            rpt.c_codigo_dis = vDistribuidor;
            rpt.c_codigo_sec = vc_codigo_sec;
            rpt.voice1 = vVoice1;
            rpt.voice2 = vVoice2;
            rpt.c_codigo_jul = c_codigo_jul;
            rpt.plu = plu;
            rpt.CargarParametros();
            ReportPrintTool printTool = new ReportPrintTool(rpt);
            ((SqlDataSource)rpt.DataSource).ConfigureDataConnection += Form1_ConfigureDataConnection;
            ReportPrintTool print = new ReportPrintTool(rpt);
            rpt.Parameters["COC"].Value = vCOC;
            rpt.Parameters["COC"].Visible = false;
            rpt.Parameters["COCGest"].Value = vCOCGest;
            rpt.Parameters["COCGest"].Visible = false;
            //GeneraCodeBarJuliana(vTemporada, vPalet, v_c_codsec_pal, c_codigo_jul);
            GeneraCodeBar(vTemporada, vPalet, v_c_codsec_pal);
            GeneraCodeBarEAN13(vcproducto);
            //printTool.Print("myPrinter");
            if (rdgTipoImpresion.SelectedIndex == 1)
            {
                rpt.ShowPreviewDialog();
            }
            else
            {
                if (t == 1)
                {
                    t++;
                    printTool.PrintDialog();
                    vPrinterName = printTool.PrinterSettings.PrinterName;
                }
                else
                {
                    printTool.Print(vPrinterName);
                }
            }

            return t;
        }
        private int Etiqueta_EAN13_Mission_2025(int t, string vPalet, string vcproducto, Boolean plu)
        {
            rpt_Etiqueta_EAN13_Mission_2025 rpt = new rpt_Etiqueta_EAN13_Mission_2025();
            rpt.c_codigo_tem = vTemporada;
            rpt.c_codigo_pal = vPalet;
            rpt.c_codsec_pal = v_c_codsec_pal;
            rpt.c_codigo_dis = vDistribuidor;
            rpt.c_codigo_sec = vc_codigo_sec;
            rpt.voice1 = vVoice1;
            rpt.voice2 = vVoice2;
            rpt.c_codigo_jul = c_codigo_jul;
            rpt.plu = plu;
            rpt.CargarParametros();
            ReportPrintTool printTool = new ReportPrintTool(rpt);
            ((SqlDataSource)rpt.DataSource).ConfigureDataConnection += Form1_ConfigureDataConnection;
            ReportPrintTool print = new ReportPrintTool(rpt);
            rpt.Parameters["COC"].Value = vCOC;
            rpt.Parameters["COC"].Visible = false;
            rpt.Parameters["COCGest"].Value = vCOCGest;
            rpt.Parameters["COCGest"].Visible = false;
            //GeneraCodeBarJuliana(vTemporada, vPalet, v_c_codsec_pal, c_codigo_jul);
            GeneraCodeBar(vTemporada, vPalet, v_c_codsec_pal);
            GeneraCodeBarEAN13(vcproducto);
            //printTool.Print("myPrinter");
            if (rdgTipoImpresion.SelectedIndex == 1)
            {
                rpt.ShowPreviewDialog();
            }
            else
            {
                if (t == 1)
                {
                    t++;
                    printTool.PrintDialog();
                    vPrinterName = printTool.PrinterSettings.PrinterName;
                }
                else
                {
                    printTool.Print(vPrinterName);
                }
            }

            return t;
        }
        private int Etiqueta_UPC_LUG_Mission_2033_Can(int t, string vPalet, string vcproducto, Boolean plu)
        {
            rpt_Etiqueta_EAN13_Mission_2033_Can rpt = new rpt_Etiqueta_EAN13_Mission_2033_Can();
            rpt.c_codigo_tem = vTemporada;
            rpt.c_codigo_pal = vPalet;
            rpt.c_codsec_pal = v_c_codsec_pal;
            rpt.c_codigo_dis = vDistribuidor;
            rpt.c_codigo_sec = vc_codigo_sec;
            rpt.voice1 = vVoice1;
            rpt.voice2 = vVoice2;
            rpt.c_codigo_jul = c_codigo_jul;
            rpt.plu = plu;
            rpt.CargarParametros();
            ReportPrintTool printTool = new ReportPrintTool(rpt);
            ((SqlDataSource)rpt.DataSource).ConfigureDataConnection += Form1_ConfigureDataConnection;
            ReportPrintTool print = new ReportPrintTool(rpt);
            rpt.Parameters["COC"].Value = vCOC;
            rpt.Parameters["COC"].Visible = false;
            rpt.Parameters["COCGest"].Value = vCOCGest;
            rpt.Parameters["COCGest"].Visible = false;
            //GeneraCodeBarJuliana(vTemporada, vPalet, v_c_codsec_pal, c_codigo_jul);
            GeneraCodeBar(vTemporada, vPalet, v_c_codsec_pal);
            GeneraCodeBarEAN13(vcproducto);
            //printTool.Print("myPrinter");
            if (rdgTipoImpresion.SelectedIndex == 1)
            {
                rpt.ShowPreviewDialog();
            }
            else
            {
                if (t == 1)
                {
                    t++;
                    printTool.PrintDialog();
                    vPrinterName = printTool.PrinterSettings.PrinterName;
                }
                else
                {
                    printTool.Print(vPrinterName);
                }
            }

            return t;
        }
        private int Etiqueta_UPC_LUG_Mission_2033(int t, string vPalet, string vcproducto, Boolean plu)
        {
            rpt_Etiqueta_EAN13_Mission_2033 rpt = new rpt_Etiqueta_EAN13_Mission_2033();
            rpt.c_codigo_tem = vTemporada;
            rpt.c_codigo_pal = vPalet;
            rpt.c_codsec_pal = v_c_codsec_pal;
            rpt.c_codigo_dis = vDistribuidor;
            rpt.c_codigo_sec = vc_codigo_sec;
            rpt.voice1 = vVoice1;
            rpt.voice2 = vVoice2;
            rpt.c_codigo_jul = c_codigo_jul;
            rpt.plu = plu;
            rpt.CargarParametros();
            ReportPrintTool printTool = new ReportPrintTool(rpt);
            ((SqlDataSource)rpt.DataSource).ConfigureDataConnection += Form1_ConfigureDataConnection;
            ReportPrintTool print = new ReportPrintTool(rpt);
            rpt.Parameters["COC"].Value = vCOC;
            rpt.Parameters["COC"].Visible = false;
            rpt.Parameters["COCGest"].Value = vCOCGest;
            rpt.Parameters["COCGest"].Visible = false;
            //GeneraCodeBarJuliana(vTemporada, vPalet, v_c_codsec_pal, c_codigo_jul);
            GeneraCodeBar(vTemporada, vPalet, v_c_codsec_pal);
            GeneraCodeBarEAN13(vcproducto);
            //printTool.Print("myPrinter");
            if (rdgTipoImpresion.SelectedIndex == 1)
            {
                rpt.ShowPreviewDialog();
            }
            else
            {
                if (t == 1)
                {
                    t++;
                    printTool.PrintDialog();
                    vPrinterName = printTool.PrinterSettings.PrinterName;
                }
                else
                {
                    printTool.Print(vPrinterName);
                }
            }

            return t;
        }
        private int Etiqueta_UPC_LUG_Mission_2030_70(int t, string vPalet, string vcproducto, Boolean plu)
        {
            rpt_Etiqueta_EAN13_Mission_2030_70 rpt = new rpt_Etiqueta_EAN13_Mission_2030_70();
            rpt.c_codigo_tem = vTemporada;
            rpt.c_codigo_pal = vPalet;
            rpt.c_codsec_pal = v_c_codsec_pal;
            rpt.c_codigo_dis = vDistribuidor;
            rpt.c_codigo_sec = vc_codigo_sec;
            rpt.voice1 = vVoice1;
            rpt.voice2 = vVoice2;
            rpt.c_codigo_jul = c_codigo_jul;
            rpt.plu = plu;
            rpt.CargarParametros();
            ReportPrintTool printTool = new ReportPrintTool(rpt);
            ((SqlDataSource)rpt.DataSource).ConfigureDataConnection += Form1_ConfigureDataConnection;
            ReportPrintTool print = new ReportPrintTool(rpt);
            rpt.Parameters["COC"].Value = vCOC;
            rpt.Parameters["COC"].Visible = false;
            rpt.Parameters["COCGest"].Value = vCOCGest;
            rpt.Parameters["COCGest"].Visible = false;
            //GeneraCodeBarJuliana(vTemporada, vPalet, v_c_codsec_pal, c_codigo_jul);
            GeneraCodeBar(vTemporada, vPalet, v_c_codsec_pal);
            GeneraCodeBarEAN13(vcproducto);
            //printTool.Print("myPrinter");
            if (rdgTipoImpresion.SelectedIndex == 1)
            {
                rpt.ShowPreviewDialog();
            }
            else
            {
                if (t == 1)
                {
                    t++;
                    printTool.PrintDialog();
                    vPrinterName = printTool.PrinterSettings.PrinterName;
                }
                else
                {
                    printTool.Print(vPrinterName);
                }
            }

            return t;
        }
        private int Etiqueta_UPC_LUG_Mission_2030_60(int t, string vPalet, string vcproducto, Boolean plu)
        {
            rpt_Etiqueta_EAN13_Mission_2030_60 rpt = new rpt_Etiqueta_EAN13_Mission_2030_60();
            rpt.c_codigo_tem = vTemporada;
            rpt.c_codigo_pal = vPalet;
            rpt.c_codsec_pal = v_c_codsec_pal;
            rpt.c_codigo_dis = vDistribuidor;
            rpt.c_codigo_sec = vc_codigo_sec;
            rpt.voice1 = vVoice1;
            rpt.voice2 = vVoice2;
            rpt.c_codigo_jul = c_codigo_jul;
            rpt.plu = plu;
            rpt.CargarParametros();
            ReportPrintTool printTool = new ReportPrintTool(rpt);
            ((SqlDataSource)rpt.DataSource).ConfigureDataConnection += Form1_ConfigureDataConnection;
            ReportPrintTool print = new ReportPrintTool(rpt);
            rpt.Parameters["COC"].Value = vCOC;
            rpt.Parameters["COC"].Visible = false;
            rpt.Parameters["COCGest"].Value = vCOCGest;
            rpt.Parameters["COCGest"].Visible = false;
            //GeneraCodeBarJuliana(vTemporada, vPalet, v_c_codsec_pal, c_codigo_jul);
            GeneraCodeBar(vTemporada, vPalet, v_c_codsec_pal);
            GeneraCodeBarEAN13(vcproducto);
            //printTool.Print("myPrinter");
            if (rdgTipoImpresion.SelectedIndex == 1)
            {
                rpt.ShowPreviewDialog();
            }
            else
            {
                if (t == 1)
                {
                    t++;
                    printTool.PrintDialog();
                    vPrinterName = printTool.PrinterSettings.PrinterName;
                }
                else
                {
                    printTool.Print(vPrinterName);
                }
            }

            return t;
        }
        private int Etiqueta_UPC_LUG_Mission_2030(int t, string vPalet, string vcproducto, Boolean plu)
        {
            rpt_Etiqueta_EAN13_Mission_2030 rpt = new rpt_Etiqueta_EAN13_Mission_2030();
            rpt.c_codigo_tem = vTemporada;
            rpt.c_codigo_pal = vPalet;
            rpt.c_codsec_pal = v_c_codsec_pal;
            rpt.c_codigo_dis = vDistribuidor;
            rpt.c_codigo_sec = vc_codigo_sec;
            rpt.voice1 = vVoice1;
            rpt.voice2 = vVoice2;
            rpt.c_codigo_jul = c_codigo_jul;
            rpt.plu = plu;
            rpt.CargarParametros();
            ReportPrintTool printTool = new ReportPrintTool(rpt);
            ((SqlDataSource)rpt.DataSource).ConfigureDataConnection += Form1_ConfigureDataConnection;
            ReportPrintTool print = new ReportPrintTool(rpt);
            rpt.Parameters["COC"].Value = vCOC;
            rpt.Parameters["COC"].Visible = false;
            rpt.Parameters["COCGest"].Value = vCOCGest;
            rpt.Parameters["COCGest"].Visible = false;
            //GeneraCodeBarJuliana(vTemporada, vPalet, v_c_codsec_pal, c_codigo_jul);
            GeneraCodeBar(vTemporada, vPalet, v_c_codsec_pal);
            GeneraCodeBarEAN13(vcproducto);
            //printTool.Print("myPrinter");
            if (rdgTipoImpresion.SelectedIndex == 1)
            {
                rpt.ShowPreviewDialog();
            }
            else
            {
                if (t == 1)
                {
                    t++;
                    printTool.PrintDialog();
                    vPrinterName = printTool.PrinterSettings.PrinterName;
                }
                else
                {
                    printTool.Print(vPrinterName);
                }
            }

            return t;
        }
        private int Etiqueta_UPC_LUG_Mission_2004(int t, string vPalet, string vcproducto, Boolean plu)
        {
            rpt_Etiqueta_EAN13_Mission_2004 rpt = new rpt_Etiqueta_EAN13_Mission_2004();
            rpt.c_codigo_tem = vTemporada;
            rpt.c_codigo_pal = vPalet;
            rpt.c_codsec_pal = v_c_codsec_pal;
            rpt.c_codigo_dis = vDistribuidor;
            rpt.c_codigo_sec = vc_codigo_sec;
            rpt.voice1 = vVoice1;
            rpt.voice2 = vVoice2;
            rpt.c_codigo_jul = c_codigo_jul;
            rpt.plu = plu;
            rpt.CargarParametros();
            ReportPrintTool printTool = new ReportPrintTool(rpt);
            ((SqlDataSource)rpt.DataSource).ConfigureDataConnection += Form1_ConfigureDataConnection;
            ReportPrintTool print = new ReportPrintTool(rpt);
            rpt.Parameters["COC"].Value = vCOC;
            rpt.Parameters["COC"].Visible = false;
            rpt.Parameters["COCGest"].Value = vCOCGest;
            rpt.Parameters["COCGest"].Visible = false;
            //GeneraCodeBarJuliana(vTemporada, vPalet, v_c_codsec_pal, c_codigo_jul);
            GeneraCodeBar(vTemporada, vPalet, v_c_codsec_pal);
            GeneraCodeBarEAN13(vcproducto);
            //printTool.Print("myPrinter");
            if (rdgTipoImpresion.SelectedIndex == 1)
            {
                rpt.ShowPreviewDialog();
            }
            else
            {
                if (t == 1)
                {
                    t++;
                    printTool.PrintDialog();
                    vPrinterName = printTool.PrinterSettings.PrinterName;
                }
                else
                {
                    printTool.Print(vPrinterName);
                }
            }

            return t;
        }
        private int Etiqueta_UPC_PLU_2037(int t, string vPalet, string vcproducto, Boolean plu)
        {
            rpt_Etiqueta_UPC_LUG_PLU_2037 rpt = new rpt_Etiqueta_UPC_LUG_PLU_2037();
            rpt.c_codigo_tem = vTemporada;
            rpt.c_codigo_pal = vPalet;
            rpt.c_codsec_pal = v_c_codsec_pal;
            rpt.c_codigo_dis = vDistribuidor;
            rpt.c_codigo_sec = vc_codigo_sec;
            rpt.voice1 = vVoice1;
            rpt.voice2 = vVoice2;
            rpt.c_codigo_jul = c_codigo_jul;
            rpt.plu = plu;
            rpt.CargarParametros();
            ReportPrintTool printTool = new ReportPrintTool(rpt);
            ((SqlDataSource)rpt.DataSource).ConfigureDataConnection += Form1_ConfigureDataConnection;
            ReportPrintTool print = new ReportPrintTool(rpt);
            rpt.Parameters["COC"].Value = vCOC;
            rpt.Parameters["COC"].Visible = false;
            rpt.Parameters["COCGest"].Value = vCOCGest;
            rpt.Parameters["COCGest"].Visible = false;
            //GeneraCodeBarJuliana(vTemporada, vPalet, v_c_codsec_pal, c_codigo_jul);
            GeneraCodeBar(vTemporada, vPalet, v_c_codsec_pal);
            GeneraCodeBarUPC(vcproducto);
            //printTool.Print("myPrinter");
            if (rdgTipoImpresion.SelectedIndex == 1)
            {
                rpt.ShowPreviewDialog();
            }
            else
            {
                if (t == 1)
                {
                    t++;
                    printTool.PrintDialog();
                    vPrinterName = printTool.PrinterSettings.PrinterName;
                }
                else
                {
                    printTool.Print(vPrinterName);
                }
            }

            return t;
        }
        private int Etiqueta_UPC_LUG_Mission_2067(int t, string vPalet, string vcproducto, Boolean plu)
        {
            rpt_Etiqueta_UPC_LUG_Mission_2067 rpt = new rpt_Etiqueta_UPC_LUG_Mission_2067();
            rpt.c_codigo_tem = vTemporada;
            rpt.c_codigo_pal = vPalet;
            rpt.c_codsec_pal = v_c_codsec_pal;
            rpt.c_codigo_dis = vDistribuidor;
            rpt.c_codigo_sec = vc_codigo_sec;
            rpt.voice1 = vVoice1;
            rpt.voice2 = vVoice2;
            rpt.c_codigo_jul = c_codigo_jul;
            rpt.plu = plu;
            rpt.CargarParametros();
            ReportPrintTool printTool = new ReportPrintTool(rpt);
            ((SqlDataSource)rpt.DataSource).ConfigureDataConnection += Form1_ConfigureDataConnection;
            ReportPrintTool print = new ReportPrintTool(rpt);
            rpt.Parameters["COC"].Value = vCOC;
            rpt.Parameters["COC"].Visible = false;
            rpt.Parameters["COCGest"].Value = vCOCGest;
            rpt.Parameters["COCGest"].Visible = false;
            //GeneraCodeBarJuliana(vTemporada, vPalet, v_c_codsec_pal, c_codigo_jul);
            GeneraCodeBar(vTemporada, vPalet, v_c_codsec_pal);
            GeneraCodeBarUPC(vcproducto);
            //printTool.Print("myPrinter");
            if (rdgTipoImpresion.SelectedIndex == 1)
            {
                rpt.ShowPreviewDialog();
            }
            else
            {
                if (t == 1)
                {
                    t++;
                    printTool.PrintDialog();
                    vPrinterName = printTool.PrinterSettings.PrinterName;
                }
                else
                {
                    printTool.Print(vPrinterName);
                }
            }

            return t;
        }
        private int Etiqueta_UPC_LUG_Mission_2041(int t, string vPalet, string vcproducto, Boolean plu)
        {
            rpt_Etiqueta_UPC_LUG_Mission_2041 rpt = new rpt_Etiqueta_UPC_LUG_Mission_2041();
            rpt.c_codigo_tem = vTemporada;
            rpt.c_codigo_pal = vPalet;
            rpt.c_codsec_pal = v_c_codsec_pal;
            rpt.c_codigo_dis = vDistribuidor;
            rpt.c_codigo_sec = vc_codigo_sec;
            rpt.voice1 = vVoice1;
            rpt.voice2 = vVoice2;
            rpt.c_codigo_jul = c_codigo_jul;
            rpt.plu = plu;
            rpt.CargarParametros();
            ReportPrintTool printTool = new ReportPrintTool(rpt);
            ((SqlDataSource)rpt.DataSource).ConfigureDataConnection += Form1_ConfigureDataConnection;
            ReportPrintTool print = new ReportPrintTool(rpt);
            rpt.Parameters["COC"].Value = vCOC;
            rpt.Parameters["COC"].Visible = false;
            rpt.Parameters["COCGest"].Value = vCOCGest;
            rpt.Parameters["COCGest"].Visible = false;
            //GeneraCodeBarJuliana(vTemporada, vPalet, v_c_codsec_pal, c_codigo_jul);
            GeneraCodeBar(vTemporada, vPalet, v_c_codsec_pal);
            GeneraCodeBarUPC(vcproducto);
            //printTool.Print("myPrinter");
            if (rdgTipoImpresion.SelectedIndex == 1)
            {
                rpt.ShowPreviewDialog();
            }
            else
            {
                if (t == 1)
                {
                    t++;
                    printTool.PrintDialog();
                    vPrinterName = printTool.PrinterSettings.PrinterName;
                }
                else
                {
                    printTool.Print(vPrinterName);
                }
            }

            return t;
        }
        private int Etiqueta_UPC_LUG_Mission_2043(int t, string vPalet, string vcproducto, Boolean plu)
        {
            rpt_Etiqueta_UPC_LUG_Mission_2043 rpt = new rpt_Etiqueta_UPC_LUG_Mission_2043();
            rpt.c_codigo_tem = vTemporada;
            rpt.c_codigo_pal = vPalet;
            rpt.c_codsec_pal = v_c_codsec_pal;
            rpt.c_codigo_dis = vDistribuidor;
            rpt.c_codigo_sec = vc_codigo_sec;
            rpt.voice1 = vVoice1;
            rpt.voice2 = vVoice2;
            rpt.c_codigo_jul = c_codigo_jul;
            rpt.plu = plu;
            rpt.CargarParametros();
            ReportPrintTool printTool = new ReportPrintTool(rpt);
            ((SqlDataSource)rpt.DataSource).ConfigureDataConnection += Form1_ConfigureDataConnection;
            ReportPrintTool print = new ReportPrintTool(rpt);
            rpt.Parameters["COC"].Value = vCOC;
            rpt.Parameters["COC"].Visible = false;
            rpt.Parameters["COCGest"].Value = vCOCGest;
            rpt.Parameters["COCGest"].Visible = false;
            //GeneraCodeBarJuliana(vTemporada, vPalet, v_c_codsec_pal, c_codigo_jul);
            GeneraCodeBar(vTemporada, vPalet, v_c_codsec_pal);
            GeneraCodeBarUPC(vcproducto);
            //printTool.Print("myPrinter");
            if (rdgTipoImpresion.SelectedIndex == 1)
            {
                rpt.ShowPreviewDialog();
            }
            else
            {
                if (t == 1)
                {
                    t++;
                    printTool.PrintDialog();
                    vPrinterName = printTool.PrinterSettings.PrinterName;
                }
                else
                {
                    printTool.Print(vPrinterName);
                }
            }

            return t;
        }
        private int Etiqueta_UPC_LUG_Mission(int t, string vPalet, string vcproducto, Boolean plu)
        {
            rpt_Etiqueta_UPC_LUG_Mission rpt = new rpt_Etiqueta_UPC_LUG_Mission();
            rpt.c_codigo_tem = vTemporada;
            rpt.c_codigo_pal = vPalet;
            rpt.c_codsec_pal = v_c_codsec_pal;
            rpt.c_codigo_dis = vDistribuidor;
            rpt.c_codigo_sec = vc_codigo_sec;
            rpt.voice1 = vVoice1;
            rpt.voice2 = vVoice2;
            rpt.c_codigo_jul = c_codigo_jul;
            rpt.plu = plu;
            rpt.CargarParametros();
            ReportPrintTool printTool = new ReportPrintTool(rpt);
            ((SqlDataSource)rpt.DataSource).ConfigureDataConnection += Form1_ConfigureDataConnection;
            ReportPrintTool print = new ReportPrintTool(rpt);
            rpt.Parameters["COC"].Value = vCOC;
            rpt.Parameters["COC"].Visible = false;
            rpt.Parameters["COCGest"].Value = vCOCGest;
            rpt.Parameters["COCGest"].Visible = false;
            //GeneraCodeBarJuliana(vTemporada, vPalet, v_c_codsec_pal, c_codigo_jul);
            GeneraCodeBar(vTemporada, vPalet, v_c_codsec_pal);
            GeneraCodeBarUPC(vcproducto);
            //printTool.Print("myPrinter");
            if (rdgTipoImpresion.SelectedIndex == 1)
            {
                rpt.ShowPreviewDialog();
            }
            else
            {
                if (t == 1)
                {
                    t++;
                    printTool.PrintDialog();
                    vPrinterName = printTool.PrinterSettings.PrinterName;
                }
                else
                {
                    printTool.Print(vPrinterName);
                }
            }

            return t;
        }
        private int Etiqueta_UPC_LUG_PLU_2027EUA_22P(int t, string vPalet, string vcproducto, Boolean plu)
        {
            rpt_Etiqueta_UPC_LUG_PLU_2027_23P rpt = new rpt_Etiqueta_UPC_LUG_PLU_2027_23P();
            rpt.c_codigo_tem = vTemporada;
            rpt.c_codigo_pal = vPalet;
            rpt.c_codsec_pal = v_c_codsec_pal;
            rpt.c_codigo_dis = vDistribuidor;
            rpt.c_codigo_sec = vc_codigo_sec;
            rpt.voice1 = vVoice1;
            rpt.voice2 = vVoice2;
            rpt.c_codigo_jul = c_codigo_jul;
            rpt.plu = plu;
            rpt.CargarParametros();
            ReportPrintTool printTool = new ReportPrintTool(rpt);
            ((SqlDataSource)rpt.DataSource).ConfigureDataConnection += Form1_ConfigureDataConnection;
            ReportPrintTool print = new ReportPrintTool(rpt);
            rpt.Parameters["COC"].Value = vCOC;
            rpt.Parameters["COC"].Visible = false;
            rpt.Parameters["COCGest"].Value = vCOCGest;
            rpt.Parameters["COCGest"].Visible = false;
            //GeneraCodeBarJuliana(vTemporada, vPalet, v_c_codsec_pal, c_codigo_jul);
            GeneraCodeBar(vTemporada, vPalet, v_c_codsec_pal);
            GeneraCodeBarEAN13(vcproducto);
            //printTool.Print("myPrinter");
            if (rdgTipoImpresion.SelectedIndex == 1)
            {
                rpt.ShowPreviewDialog();
            }
            else
            {
                if (t == 1)
                {
                    t++;
                    printTool.PrintDialog();
                    vPrinterName = printTool.PrinterSettings.PrinterName;
                }
                else
                {
                    printTool.Print(vPrinterName);
                }
            }

            return t;
        }
        private int Etiqueta_UPC_LUG_PLU_2027EUA_31P(int t, string vPalet, string vcproducto, Boolean plu)
        {
            rpt_Etiqueta_UPC_LUG_PLU_2027_22P rpt = new rpt_Etiqueta_UPC_LUG_PLU_2027_22P();
            rpt.c_codigo_tem = vTemporada;
            rpt.c_codigo_pal = vPalet;
            rpt.c_codsec_pal = v_c_codsec_pal;
            rpt.c_codigo_dis = vDistribuidor;
            rpt.c_codigo_sec = vc_codigo_sec;
            rpt.voice1 = vVoice1;
            rpt.voice2 = vVoice2;
            rpt.c_codigo_jul = c_codigo_jul;
            rpt.plu = plu;
            rpt.CargarParametros();
            ReportPrintTool printTool = new ReportPrintTool(rpt);
            ((SqlDataSource)rpt.DataSource).ConfigureDataConnection += Form1_ConfigureDataConnection;
            ReportPrintTool print = new ReportPrintTool(rpt);
            rpt.Parameters["COC"].Value = vCOC;
            rpt.Parameters["COC"].Visible = false;
            rpt.Parameters["COCGest"].Value = vCOCGest;
            rpt.Parameters["COCGest"].Visible = false;
            //GeneraCodeBarJuliana(vTemporada, vPalet, v_c_codsec_pal, c_codigo_jul);
            GeneraCodeBar(vTemporada, vPalet, v_c_codsec_pal);
            GeneraCodeBarEAN13(vcproducto);
            //printTool.Print("myPrinter");
            if (rdgTipoImpresion.SelectedIndex == 1)
            {
                rpt.ShowPreviewDialog();
            }
            else
            {
                if (t == 1)
                {
                    t++;
                    printTool.PrintDialog();
                    vPrinterName = printTool.PrinterSettings.PrinterName;
                }
                else
                {
                    printTool.Print(vPrinterName);
                }
            }

            return t;
        }

        private int Etiqueta_UPC_LUG_PLU_2015(int t, string vPalet, string vcproducto, Boolean plu)
        {
            rpt_Etiqueta_UPC_LUG_PLU_2015 rpt = new rpt_Etiqueta_UPC_LUG_PLU_2015();
            rpt.c_codigo_tem = vTemporada;
            rpt.c_codigo_pal = vPalet;
            rpt.c_codsec_pal = v_c_codsec_pal;
            rpt.c_codigo_dis = vDistribuidor;
            rpt.c_codigo_sec = vc_codigo_sec;
            rpt.voice1 = vVoice1;
            rpt.voice2 = vVoice2;
            rpt.c_codigo_jul = c_codigo_jul;
            rpt.plu = plu;
            rpt.CargarParametros();
            ReportPrintTool printTool = new ReportPrintTool(rpt);
            ((SqlDataSource)rpt.DataSource).ConfigureDataConnection += Form1_ConfigureDataConnection;
            ReportPrintTool print = new ReportPrintTool(rpt);
            rpt.Parameters["COC"].Value = vCOC;
            rpt.Parameters["COC"].Visible = false;
            rpt.Parameters["COCGest"].Value = vCOCGest;
            rpt.Parameters["COCGest"].Visible = false;
            //GeneraCodeBarJuliana(vTemporada, vPalet, v_c_codsec_pal, c_codigo_jul);
            GeneraCodeBar(vTemporada, vPalet, v_c_codsec_pal);
            GeneraCodeBarUPCA(vcproducto);
            //printTool.Print("myPrinter");
            if (rdgTipoImpresion.SelectedIndex == 1)
            {
                rpt.ShowPreviewDialog();
            }
            else
            {
                if (t == 1)
                {
                    t++;
                    printTool.PrintDialog();
                    vPrinterName = printTool.PrinterSettings.PrinterName;
                }
                else
                {
                    printTool.Print(vPrinterName);
                }
            }

            return t;
        }
        private int Etiqueta_UPC_LUG_PLU_2027(int t, string vPalet, string vcproducto, Boolean plu)
        {
            rpt_Etiqueta_UPC_LUG_PLU_2027 rpt = new rpt_Etiqueta_UPC_LUG_PLU_2027();
            rpt.c_codigo_tem = vTemporada;
            rpt.c_codigo_pal = vPalet;
            rpt.c_codsec_pal = v_c_codsec_pal;
            rpt.c_codigo_dis = vDistribuidor;
            rpt.c_codigo_sec = vc_codigo_sec;
            rpt.voice1 = vVoice1;
            rpt.voice2 = vVoice2;
            rpt.c_codigo_jul = c_codigo_jul;
            rpt.plu = plu;
            rpt.CargarParametros();
            ReportPrintTool printTool = new ReportPrintTool(rpt);
            ((SqlDataSource)rpt.DataSource).ConfigureDataConnection += Form1_ConfigureDataConnection;
            ReportPrintTool print = new ReportPrintTool(rpt);
            rpt.Parameters["COC"].Value = vCOC;
            rpt.Parameters["COC"].Visible = false;
            rpt.Parameters["COCGest"].Value = vCOCGest;
            rpt.Parameters["COCGest"].Visible = false;
            //GeneraCodeBarJuliana(vTemporada, vPalet, v_c_codsec_pal, c_codigo_jul);
            GeneraCodeBar(vTemporada, vPalet, v_c_codsec_pal);
            GeneraCodeBarEAN13(vcproducto);
            //printTool.Print("myPrinter");
            if (rdgTipoImpresion.SelectedIndex == 1)
            {
                rpt.ShowPreviewDialog();
            }
            else
            {
                if (t == 1)
                {
                    t++;
                    printTool.PrintDialog();
                    vPrinterName = printTool.PrinterSettings.PrinterName;
                }
                else
                {
                    printTool.Print(vPrinterName);
                }
            }

            return t;
        }
        private int Etiqueta_EAN_LUG_PLU_2001(int t, string vPalet, string vcproducto, Boolean plu)
        {
            rpt_Etiqueta_EAN_LUG_PLU_2001 rpt = new rpt_Etiqueta_EAN_LUG_PLU_2001();
            rpt.c_codigo_tem = vTemporada;
            rpt.c_codigo_pal = vPalet;
            rpt.c_codsec_pal = v_c_codsec_pal;
            rpt.c_codigo_dis = vDistribuidor;
            rpt.c_codigo_sec = vc_codigo_sec;
            rpt.voice1 = vVoice1;
            rpt.voice2 = vVoice2;
            rpt.c_codigo_jul = c_codigo_jul;
            rpt.plu = plu;
            rpt.CargarParametros();
            ReportPrintTool printTool = new ReportPrintTool(rpt);
            ((SqlDataSource)rpt.DataSource).ConfigureDataConnection += Form1_ConfigureDataConnection;
            ReportPrintTool print = new ReportPrintTool(rpt);
            rpt.Parameters["COC"].Value = vCOC;
            rpt.Parameters["COC"].Visible = false;
            rpt.Parameters["COCGest"].Value = vCOCGest;
            rpt.Parameters["COCGest"].Visible = false;
            //GeneraCodeBarJuliana(vTemporada, vPalet, v_c_codsec_pal, c_codigo_jul);
            GeneraCodeBar(vTemporada, vPalet, v_c_codsec_pal);
            GeneraCodeBarEAN13(vcproducto);
            //printTool.Print("myPrinter");
            if (rdgTipoImpresion.SelectedIndex == 1)
            {
                rpt.ShowPreviewDialog();
            }
            else
            {
                if (t == 1)
                {
                    t++;
                    printTool.PrintDialog();
                    vPrinterName = printTool.PrinterSettings.PrinterName;
                }
                else
                {
                    printTool.Print(vPrinterName);
                }
            }

            return t;
        }
        private int Etiqueta_UPC_SAMS_LGS (int t, string vPalet, string vcproducto, Boolean plu)
        {
            rpt_Etiqueta_UPC_SAMS_LGS rpt = new rpt_Etiqueta_UPC_SAMS_LGS();
            rpt.c_codigo_tem = vTemporada;
            rpt.c_codigo_pal = vPalet;
            rpt.c_codsec_pal = v_c_codsec_pal;
            rpt.c_codigo_dis = vDistribuidor;
            rpt.c_codigo_sec = vc_codigo_sec;
            rpt.voice1 = vVoice1;
            rpt.voice2 = vVoice2;
            rpt.c_codigo_jul = c_codigo_jul;
            rpt.plu = plu;
            rpt.CargarParametros();
            ReportPrintTool printTool = new ReportPrintTool(rpt);
            ((SqlDataSource)rpt.DataSource).ConfigureDataConnection += Form1_ConfigureDataConnection;
            ReportPrintTool print = new ReportPrintTool(rpt);
            rpt.Parameters["COC"].Value = vCOC;
            rpt.Parameters["COC"].Visible = false;
            rpt.Parameters["COCGest"].Value = vCOCGest;
            rpt.Parameters["COCGest"].Visible = false;
            //GeneraCodeBarJuliana(vTemporada, vPalet, v_c_codsec_pal, c_codigo_jul);
            GeneraCodeBarSAMS_LGS(vTemporada, vPalet, v_c_codsec_pal);
            GeneraCodeBarUPC(vcproducto);
            //printTool.Print("myPrinter");
            if (rdgTipoImpresion.SelectedIndex == 1)
            {
                rpt.ShowPreviewDialog();
            }
            else
            {
                if (t == 1)
                {
                    t++;
                    printTool.PrintDialog();
                    vPrinterName = printTool.PrinterSettings.PrinterName;
                }
                else
                {
                    printTool.Print(vPrinterName);
                }
            }

            return t;
        }
        private int Etiqueta_UPC_Mandarin(int t, string vPalet, string vcproducto, Boolean plu)
        {
            rpt_Etiqueta_UPC_Mandarin rpt = new rpt_Etiqueta_UPC_Mandarin();
            rpt.c_codigo_tem = vTemporada;
            rpt.c_codigo_pal = vPalet;
            rpt.c_codsec_pal = v_c_codsec_pal;
            rpt.c_codigo_dis = vDistribuidor;
            rpt.c_codigo_sec = vc_codigo_sec;
            rpt.voice1 = vVoice1;
            rpt.voice2 = vVoice2;
            rpt.c_codigo_jul = c_codigo_jul;
            rpt.plu = plu;
            rpt.CargarParametros();
            ReportPrintTool printTool = new ReportPrintTool(rpt);
            ((SqlDataSource)rpt.DataSource).ConfigureDataConnection += Form1_ConfigureDataConnection;
            ReportPrintTool print = new ReportPrintTool(rpt);
            rpt.Parameters["COC"].Value = vCOC;
            rpt.Parameters["COC"].Visible = false;
            rpt.Parameters["COCGest"].Value = vCOCGest;
            rpt.Parameters["COCGest"].Visible = false;
            //GeneraCodeBarJuliana(vTemporada, vPalet, v_c_codsec_pal, c_codigo_jul);
            GeneraCodeBar(vTemporada, vPalet, v_c_codsec_pal);
            GeneraCodeBarUPC(vcproducto);
            //printTool.Print("myPrinter");
            if (rdgTipoImpresion.SelectedIndex == 1)
            {
                rpt.ShowPreviewDialog();
            }
            else
            {
                if (t == 1)
                {
                    t++;
                    printTool.PrintDialog();
                    vPrinterName = printTool.PrinterSettings.PrinterName;
                }
                else
                {
                    printTool.Print(vPrinterName);
                }
            }

            return t;
        }
        private int Etiqueta_UPC_Mission(int t, string vPalet, string vcproducto, Boolean plu)
        {
            rpt_Etiqueta_UPC_Mission rpt = new rpt_Etiqueta_UPC_Mission();
            rpt.c_codigo_tem = vTemporada;
            rpt.c_codigo_pal = vPalet;
            rpt.c_codsec_pal = v_c_codsec_pal;
            rpt.c_codigo_dis = vDistribuidor;
            rpt.c_codigo_sec = vc_codigo_sec;
            rpt.voice1 = vVoice1;
            rpt.voice2 = vVoice2;
            rpt.c_codigo_jul = c_codigo_jul;
            rpt.plu = plu;
            rpt.CargarParametros();
            ReportPrintTool printTool = new ReportPrintTool(rpt);
            ((SqlDataSource)rpt.DataSource).ConfigureDataConnection += Form1_ConfigureDataConnection;
            ReportPrintTool print = new ReportPrintTool(rpt);
            rpt.Parameters["COC"].Value = vCOC;
            rpt.Parameters["COC"].Visible = false;
            rpt.Parameters["COCGest"].Value = vCOCGest;
            rpt.Parameters["COCGest"].Visible = false;
            //GeneraCodeBarJuliana(vTemporada, vPalet, v_c_codsec_pal, c_codigo_jul);
            GeneraCodeBar(vTemporada, vPalet, v_c_codsec_pal);
            GeneraCodeBarUPC(vcproducto);
            //printTool.Print("myPrinter");
            if (rdgTipoImpresion.SelectedIndex == 1)
            {
                rpt.ShowPreviewDialog();
            }
            else
            {
                if (t == 1)
                {
                    t++;
                    printTool.PrintDialog();
                    vPrinterName = printTool.PrinterSettings.PrinterName;
                }
                else
                {
                    printTool.Print(vPrinterName);
                }
            }

            return t;
        }
        private int Etiqueta_UPC_Mission_3045(int t, string vPalet, string vcproducto, Boolean plu)
        {
            rpt_Etiqueta_UPC_Mission_3045 rpt = new rpt_Etiqueta_UPC_Mission_3045();
            rpt.c_codigo_tem = vTemporada;
            rpt.c_codigo_pal = vPalet;
            rpt.c_codsec_pal = v_c_codsec_pal;
            rpt.c_codigo_dis = vDistribuidor;
            rpt.c_codigo_sec = vc_codigo_sec;
            rpt.voice1 = vVoice1;
            rpt.voice2 = vVoice2;
            rpt.c_codigo_jul = c_codigo_jul;
            rpt.plu = plu;
            rpt.CargarParametros();
            ReportPrintTool printTool = new ReportPrintTool(rpt);
            ((SqlDataSource)rpt.DataSource).ConfigureDataConnection += Form1_ConfigureDataConnection;
            ReportPrintTool print = new ReportPrintTool(rpt);
            rpt.Parameters["COC"].Value = vCOC;
            rpt.Parameters["COC"].Visible = false;
            rpt.Parameters["COCGest"].Value = vCOCGest;
            rpt.Parameters["COCGest"].Visible = false;
            //GeneraCodeBarJuliana(vTemporada, vPalet, v_c_codsec_pal, c_codigo_jul);
            GeneraCodeBar(vTemporada, vPalet, v_c_codsec_pal);
            GeneraCodeBarUPC(vcproducto);
            //printTool.Print("myPrinter");
            if (rdgTipoImpresion.SelectedIndex == 1)
            {
                rpt.ShowPreviewDialog();
            }
            else
            {
                if (t == 1)
                {
                    t++;
                    printTool.PrintDialog();
                    vPrinterName = printTool.PrinterSettings.PrinterName;
                }
                else
                {
                    printTool.Print(vPrinterName);
                }
            }

            return t;
        }
        private int Etiqueta_UPC_Mission_2026(int t, string vPalet, string vcproducto, Boolean plu)
        {
            rpt_Etiqueta_UPC_Mission_2026 rpt = new rpt_Etiqueta_UPC_Mission_2026();
            rpt.c_codigo_tem = vTemporada;
            rpt.c_codigo_pal = vPalet;
            rpt.c_codsec_pal = v_c_codsec_pal;
            rpt.c_codigo_dis = vDistribuidor;
            rpt.c_codigo_sec = vc_codigo_sec;
            rpt.voice1 = vVoice1;
            rpt.voice2 = vVoice2;
            rpt.c_codigo_jul = c_codigo_jul;
            rpt.plu = plu;
            rpt.CargarParametros();
            ReportPrintTool printTool = new ReportPrintTool(rpt);
            ((SqlDataSource)rpt.DataSource).ConfigureDataConnection += Form1_ConfigureDataConnection;
            ReportPrintTool print = new ReportPrintTool(rpt);
            rpt.Parameters["COC"].Value = vCOC;
            rpt.Parameters["COC"].Visible = false;
            rpt.Parameters["COCGest"].Value = vCOCGest;
            rpt.Parameters["COCGest"].Visible = false;
            //GeneraCodeBarJuliana(vTemporada, vPalet, v_c_codsec_pal, c_codigo_jul);
            GeneraCodeBar(vTemporada, vPalet, v_c_codsec_pal);
            GeneraCodeBarUPC(vcproducto);
            //printTool.Print("myPrinter");
            if (rdgTipoImpresion.SelectedIndex == 1)
            {
                rpt.ShowPreviewDialog();
            }
            else
            {
                if (t == 1)
                {
                    t++;
                    printTool.PrintDialog();
                    vPrinterName = printTool.PrinterSettings.PrinterName;
                }
                else
                {
                    printTool.Print(vPrinterName);
                }
            }

            return t;
        }
        private int Etiqueta_Lisa_Mission(int t, string vPalet, string vcproducto, Boolean plu)
        {
            rpt_Etiqueta_Lisa_Mission rpt = new rpt_Etiqueta_Lisa_Mission();
            rpt.c_codigo_tem = vTemporada;
            rpt.c_codigo_pal = vPalet;
            rpt.c_codsec_pal = v_c_codsec_pal;
            rpt.c_codigo_dis = vDistribuidor;
            rpt.c_codigo_sec = vc_codigo_sec;
            rpt.voice1 = vVoice1;
            rpt.voice2 = vVoice2;
            rpt.c_codigo_jul = c_codigo_jul;
            rpt.plu = plu;
            rpt.CargarParametros();
            ReportPrintTool printTool = new ReportPrintTool(rpt);
            ((SqlDataSource)rpt.DataSource).ConfigureDataConnection += Form1_ConfigureDataConnection;
            ReportPrintTool print = new ReportPrintTool(rpt);
            rpt.Parameters["COC"].Value = vCOC;
            rpt.Parameters["COC"].Visible = false;
            rpt.Parameters["COCGest"].Value = vCOCGest;
            rpt.Parameters["COCGest"].Visible = false;
            //GeneraCodeBarJuliana(vTemporada, vPalet, v_c_codsec_pal, c_codigo_jul);
            GeneraCodeBar(vTemporada, vPalet, v_c_codsec_pal);
            GeneraCodeBarUPC(vcproducto);
            //printTool.Print("myPrinter");
            if (rdgTipoImpresion.SelectedIndex == 1)
            {
                rpt.ShowPreviewDialog();
            }
            else
            {
                if (t == 1)
                {
                    t++;
                    printTool.PrintDialog();
                    vPrinterName = printTool.PrinterSettings.PrinterName;
                }
                else
                {
                    printTool.Print(vPrinterName);
                }
            }

            return t;
        }
        private int Etiqueta_UPC_Anderson_Organic(int t, string vPalet, string vcproducto, Boolean plu)
        {
            rpt_Etiqueta_UPC_Anderson_Organic rpt = new rpt_Etiqueta_UPC_Anderson_Organic();
            rpt.c_codigo_tem = vTemporada;
            rpt.c_codigo_pal = vPalet;
            rpt.c_codsec_pal = v_c_codsec_pal;
            rpt.c_codigo_dis = vDistribuidor;
            rpt.c_codigo_sec = vc_codigo_sec;
            rpt.voice1 = vVoice1;
            rpt.voice2 = vVoice2;
            rpt.c_codigo_jul = c_codigo_jul;
            rpt.plu = plu;
            rpt.CargarParametros();
            ReportPrintTool printTool = new ReportPrintTool(rpt);
            ((SqlDataSource)rpt.DataSource).ConfigureDataConnection += Form1_ConfigureDataConnection;
            ReportPrintTool print = new ReportPrintTool(rpt);
            rpt.Parameters["COC"].Value = vCOC;
            rpt.Parameters["COC"].Visible = false;
            rpt.Parameters["COCGest"].Value = vCOCGest;
            rpt.Parameters["COCGest"].Visible = false;
            //GeneraCodeBarJuliana(vTemporada, vPalet, v_c_codsec_pal, c_codigo_jul);
            GeneraCodeBarSAMS(vTemporada, vPalet, v_c_codsec_pal);
            GeneraCodeBarUPC(vcproducto);
            //printTool.Print("myPrinter");
            if (rdgTipoImpresion.SelectedIndex == 1)
            {
                rpt.ShowPreviewDialog();
            }
            else
            {
                if (t == 1)
                {
                    t++;
                    printTool.PrintDialog();
                    vPrinterName = printTool.PrinterSettings.PrinterName;
                }
                else
                {
                    printTool.Print(vPrinterName);
                }
            }

            return t;
        }
        private int Etiqueta_UPC_CROGER(int t, string vPalet, string vcproducto,Boolean plu)
        {
            rpt_Etiqueta_UPC_CROGER rpt = new rpt_Etiqueta_UPC_CROGER();
            rpt.c_codigo_tem = vTemporada;
            rpt.c_codigo_pal = vPalet;
            rpt.c_codsec_pal = v_c_codsec_pal;
            rpt.c_codigo_dis = vDistribuidor;
            rpt.c_codigo_sec = vc_codigo_sec;
            rpt.voice1 = vVoice1;
            rpt.voice2 = vVoice2;
            rpt.c_codigo_jul = c_codigo_jul;
            rpt.plu = plu;
            rpt.CargarParametros();
            ReportPrintTool printTool = new ReportPrintTool(rpt);
            ((SqlDataSource)rpt.DataSource).ConfigureDataConnection += Form1_ConfigureDataConnection;
            ReportPrintTool print = new ReportPrintTool(rpt);
            rpt.Parameters["COC"].Value = vCOC;
            rpt.Parameters["COC"].Visible = false;
            rpt.Parameters["COCGest"].Value = vCOCGest;
            rpt.Parameters["COCGest"].Visible = false;
            //GeneraCodeBarJuliana(vTemporada, vPalet, v_c_codsec_pal, c_codigo_jul);
            GeneraCodeBarSAMS(vTemporada, vPalet, v_c_codsec_pal);
            GeneraCodeBarUPC(vcproducto);
            //printTool.Print("myPrinter");
            if (rdgTipoImpresion.SelectedIndex == 1)
            {
                rpt.ShowPreviewDialog();
            }
            else
            {
                if (t == 1)
                {
                    t++;
                    printTool.PrintDialog();
                    vPrinterName = printTool.PrinterSettings.PrinterName;
                }
                else
                {
                    printTool.Print(vPrinterName);
                }
            }

            return t;
        }
        private int Etiqueta_UPC_CROGER_Juliana(int t, string vPalet, string vcproducto,Boolean plu)
        {
            string val_juliano = TresCero(FechaJuliana(DateTime.Now));
            c_codigo_jul = CodigoDisExt(vDistribuidor).Trim() + val_juliano.Substring(0, 1) + txtEstiba.Text.Substring(5, 5) + val_juliano.Substring(1, 2);
            rpt_Etiqueta_UPC_CROGER_Juliana rpt = new rpt_Etiqueta_UPC_CROGER_Juliana();
            rpt.c_codigo_tem = vTemporada;
            rpt.c_codigo_pal = vPalet;
            rpt.c_codsec_pal = v_c_codsec_pal;
            rpt.c_codigo_dis = vDistribuidor;
            rpt.c_codigo_sec = vc_codigo_sec;
            rpt.voice1 = vVoice1;
            rpt.voice2 = vVoice2;
            rpt.c_codigo_jul = c_codigo_jul;
            rpt.plu = plu;
            rpt.CargarParametros();
            ((SqlDataSource)rpt.DataSource).ConfigureDataConnection += Form1_ConfigureDataConnection;
            ReportPrintTool printTool = new ReportPrintTool(rpt);
            rpt.Parameters["COC"].Value = vCOC;
            rpt.Parameters["COC"].Visible = false;
            rpt.Parameters["COCGest"].Value = vCOCGest;
            rpt.Parameters["COCGest"].Visible = false;
            GeneraCodeBarJuliana(vTemporada, vPalet, v_c_codsec_pal, c_codigo_jul);
            //GeneraCodeBar(vTemporada, vPalet, v_c_codsec_pal);
            GeneraCodeBarUPC(vcproducto);
            //printTool.Print("myPrinter");
            if (rdgTipoImpresion.SelectedIndex == 1)
            {
                rpt.ShowPreviewDialog();
            }
            else
            {
                if (t == 1)
                {
                    t++;
                    printTool.PrintDialog();
                    vPrinterName = printTool.PrinterSettings.PrinterName;
                }
                else
                {
                    printTool.Print(vPrinterName);
                }
            }

            return t;
        }
        private int Etiqueta_UPC(int t, string vPalet, string vcproducto)
        {
            rpt_Etiqueta_UPC rpt = new rpt_Etiqueta_UPC();
            rpt.c_codigo_tem = vTemporada;
            rpt.c_codigo_pal = vPalet;
            rpt.c_codsec_pal = v_c_codsec_pal;
            rpt.c_codigo_dis = vDistribuidor;
            rpt.c_codigo_sec = vc_codigo_sec;
            rpt.voice1 = vVoice1;
            rpt.voice2 = vVoice2;
            rpt.c_codigo_jul = c_codigo_jul;
            rpt.CargarParametros();
            ReportPrintTool printTool = new ReportPrintTool(rpt);
            ((SqlDataSource)rpt.DataSource).ConfigureDataConnection += Form1_ConfigureDataConnection;
            rpt.Parameters["COC"].Value = vCOC;
            rpt.Parameters["COC"].Visible = false;
            rpt.Parameters["COCGest"].Value = vCOCGest;
            rpt.Parameters["COCGest"].Visible = false;
            //GeneraCodeBarJuliana(vTemporada, vPalet, v_c_codsec_pal, c_codigo_jul);
            GeneraCodeBar(vTemporada, vPalet, v_c_codsec_pal);
            GeneraCodeBarUPC(vcproducto);
            //printTool.Print("myPrinter");
            if (rdgTipoImpresion.SelectedIndex == 1)
            {
                rpt.ShowPreviewDialog();
            }
            else
            {
                if (t == 1)
                {
                    t++;
                    printTool.PrintDialog();
                    vPrinterName = printTool.PrinterSettings.PrinterName;
                }
                else
                {
                    printTool.Print(vPrinterName);
                }
            }

            return t;
        }
        private int Etiqueta_UPC_Distribuidor_Juliana(int t, string vPalet,string vcproducto)
        {
            
            string val_juliano = TresCero(FechaJuliana(DateTime.Now));
            c_codigo_jul = CodigoDisExt(vDistribuidor).Trim() + val_juliano.Substring(0, 1) + txtEstiba.Text.Substring(5, 5) + val_juliano.Substring(1, 2);
            rpt_Etiqueta_UPC_Juliana rpt = new rpt_Etiqueta_UPC_Juliana();
            rpt.c_codigo_tem = vTemporada;
            rpt.c_codigo_pal = vPalet;
            rpt.c_codsec_pal = v_c_codsec_pal;
            rpt.c_codigo_dis = vDistribuidor;
            rpt.c_codigo_sec = vc_codigo_sec;
            rpt.voice1 = vVoice1;
            rpt.voice2 = vVoice2;
            rpt.c_codigo_jul = c_codigo_jul;
            rpt.CargarParametros();
            ReportPrintTool printTool = new ReportPrintTool(rpt);
            ((SqlDataSource)rpt.DataSource).ConfigureDataConnection += Form1_ConfigureDataConnection;
            rpt.Parameters["COC"].Value = vCOC;
            rpt.Parameters["COC"].Visible = false;
            rpt.Parameters["COCGest"].Value = vCOCGest;
            rpt.Parameters["COCGest"].Visible = false;
            GeneraCodeBarJuliana(vTemporada, vPalet, v_c_codsec_pal, c_codigo_jul);
            //GeneraCodeBar(vTemporada, vPalet, v_c_codsec_pal);
            GeneraCodeBarUPC(vcproducto);
            //printTool.Print("myPrinter");
            if (rdgTipoImpresion.SelectedIndex == 1)
            {
                rpt.ShowPreviewDialog();
            }
            else
            {
                if (t == 1)
                {
                    t++;
                    printTool.PrintDialog();
                    vPrinterName = printTool.PrinterSettings.PrinterName;
                }
                else
                {
                    printTool.Print(vPrinterName);
                }
            }

            return t;
        }
       
        private int Etiqueta_UPC_SAMS_Juliana(int t, string vPalet, string vcproducto)
        {

            string val_juliano = TresCero(FechaJuliana(DateTime.Now));
            c_codigo_jul = CodigoDisExt(vDistribuidor).Trim() + val_juliano.Substring(0, 1) + txtEstiba.Text.Substring(5, 5) + val_juliano.Substring(1, 2);
            rpt_Etiqueta_UPC_SAMS_Juliana rpt = new rpt_Etiqueta_UPC_SAMS_Juliana();
            rpt.c_codigo_tem = vTemporada;
            rpt.c_codigo_pal = vPalet;
            rpt.c_codsec_pal = v_c_codsec_pal;
            rpt.c_codigo_dis = vDistribuidor;
            rpt.c_codigo_sec = vc_codigo_sec;
            rpt.voice1 = vVoice1;
            rpt.voice2 = vVoice2;
            rpt.c_codigo_jul = c_codigo_jul;
            rpt.CargarParametros();
            ReportPrintTool printTool = new ReportPrintTool(rpt);
            ((SqlDataSource)rpt.DataSource).ConfigureDataConnection += Form1_ConfigureDataConnection;
            rpt.Parameters["COC"].Value = vCOC;
            rpt.Parameters["COC"].Visible = false;
            rpt.Parameters["COCGest"].Value = vCOCGest;
            rpt.Parameters["COCGest"].Visible = false;
            GeneraCodeBarJulianaSAMS(vTemporada, vPalet, v_c_codsec_pal, c_codigo_jul);
            //GeneraCodeBar(vTemporada, vPalet, v_c_codsec_pal);
            //GeneraCodeBarUPC(vcproducto);
            GeneraCodeBarUPCA(vcproducto);
            //printTool.Print("myPrinter");
            if (rdgTipoImpresion.SelectedIndex == 1)
            {
                rpt.ShowPreviewDialog();
            }
            else
            {
                if (t == 1)
                {
                    t++;
                    printTool.PrintDialog();
                    vPrinterName = printTool.PrinterSettings.PrinterName;
                }
                else
                {
                    printTool.Print(vPrinterName);
                }
            }

            return t;
        }
        private int Etiqueta_HEB(int t, string vPalet)
        {
            rpt_Etiqueta_HEB rpt = new rpt_Etiqueta_HEB();
            rpt.c_codigo_tem = vTemporada;
            rpt.c_codigo_pal = vPalet;
            rpt.c_codsec_pal = v_c_codsec_pal;
            rpt.c_codigo_dis = vDistribuidor;
            rpt.c_codigo_sec = vc_codigo_sec;
            rpt.voice1 = vVoice1;
            rpt.voice2 = vVoice2;
            rpt.CargarParametros();
            ReportPrintTool printTool = new ReportPrintTool(rpt);
            ((SqlDataSource)rpt.DataSource).ConfigureDataConnection += Form1_ConfigureDataConnection;
            rpt.Parameters["COC"].Value = vCOC;
            rpt.Parameters["COC"].Visible = false;
            rpt.Parameters["COCGest"].Value = vCOCGest;
            rpt.Parameters["COCGest"].Visible = false;
            GeneraCodeBar(vTemporada, vPalet, v_c_codsec_pal);
            GeneraCodeBar(vTemporada, vPalet, v_c_codsec_pal);
            //printTool.Print("myPrinter");
            if (rdgTipoImpresion.SelectedIndex == 1)
            {
                rpt.ShowPreviewDialog();
            }
            else
            {
                if (t == 1)
                {
                    t++;
                    printTool.PrintDialog();
                    vPrinterName = printTool.PrinterSettings.PrinterName;
                }
                else
                {
                    printTool.Print(vPrinterName);
                }
            }

            return t;
        }
        private int Etiqueta_Distribuidor_Juliana_Esp(int t, string vPalet)
        {
            string val_juliano = TresCero(FechaJuliana(DateTime.Now));
            c_codigo_jul = CodigoDisExt(vDistribuidor).Trim() + val_juliano.Substring(0, 1) + txtEstiba.Text.Substring(5, 5) + val_juliano.Substring(1, 2);
            rpt_Etiqueta_Distribuidor_Juliana_Esp rpt = new rpt_Etiqueta_Distribuidor_Juliana_Esp();
            rpt.c_codigo_tem = vTemporada;
            rpt.c_codigo_pal = vPalet;
            rpt.c_codsec_pal = v_c_codsec_pal;
            rpt.c_codigo_dis = vDistribuidor;
            rpt.c_codigo_sec = vc_codigo_sec;
            rpt.voice1 = vVoice1;
            rpt.voice2 = vVoice2;
            rpt.c_codigo_jul = c_codigo_jul;
            rpt.CargarParametros();
            ReportPrintTool printTool = new ReportPrintTool(rpt);
            ((SqlDataSource)rpt.DataSource).ConfigureDataConnection += Form1_ConfigureDataConnection;
            rpt.Parameters["COC"].Value = vCOC;
            rpt.Parameters["COC"].Visible = false;
            rpt.Parameters["COCGest"].Value = vCOCGest;
            rpt.Parameters["COCGest"].Visible = false;
            GeneraCodeBarJuliana(vTemporada, vPalet, v_c_codsec_pal, c_codigo_jul);
            //printTool.Print("myPrinter");
            if (rdgTipoImpresion.SelectedIndex == 1)
            {
                rpt.ShowPreviewDialog();
            }
            else
            {
                if (t == 1)
                {
                    t++;
                    printTool.PrintDialog();
                    vPrinterName = printTool.PrinterSettings.PrinterName;
                }
                else
                {
                    printTool.Print(vPrinterName);
                }
            }

            return t;
        }
        private int Etiqueta_Distribuidor_Fecha(int t, string vPalet)
        {
            string val_juliano = TresCero(FechaJuliana(DateTime.Now));
            c_codigo_jul = CodigoDisExt(vDistribuidor).Trim() + val_juliano.Substring(0, 1) + txtEstiba.Text.Substring(5, 5) + val_juliano.Substring(1, 2);
            rpt_Etiqueta_Distribuidor_Fecha rpt = new rpt_Etiqueta_Distribuidor_Fecha();
            rpt.c_codigo_tem = vTemporada;
            rpt.c_codigo_pal = vPalet;
            rpt.c_codsec_pal = v_c_codsec_pal;
            rpt.c_codigo_dis = vDistribuidor;
            rpt.c_codigo_sec = vc_codigo_sec;
            rpt.voice1 = vVoice1;
            rpt.voice2 = vVoice2;
            rpt.c_codigo_jul = c_codigo_jul;
            rpt.CargarParametros();
            ReportPrintTool printTool = new ReportPrintTool(rpt);
            ((SqlDataSource)rpt.DataSource).ConfigureDataConnection += Form1_ConfigureDataConnection;
            rpt.Parameters["COC"].Value = vCOC;
            rpt.Parameters["COC"].Visible = false;
            rpt.Parameters["COCGest"].Value = vCOCGest;
            rpt.Parameters["COCGest"].Visible = false;
            GeneraCodeBarJuliana(vTemporada, vPalet, v_c_codsec_pal, c_codigo_jul);
            //printTool.Print("myPrinter");
            if (rdgTipoImpresion.SelectedIndex == 1)
            {
                rpt.ShowPreviewDialog();
            }
            else
            {
                if (t == 1)
                {
                    t++;
                    printTool.PrintDialog();
                    vPrinterName = printTool.PrinterSettings.PrinterName;
                }
                else
                {
                    printTool.Print(vPrinterName);
                }
            }

            return t;
        }
        private int Etiqueta_Distribuidor_Juliana(int t, string vPalet)
        {
            string val_juliano =TresCero(FechaJuliana(DateTime.Now));
            c_codigo_jul =CodigoDisExt(vDistribuidor).Trim() + val_juliano.Substring(0, 1) + txtEstiba.Text.Substring(5,5) + val_juliano.Substring(1, 2);
            rpt_Etiqueta_Distribuidor_Juliana rpt = new rpt_Etiqueta_Distribuidor_Juliana();
            rpt.c_codigo_tem = vTemporada;
            rpt.c_codigo_pal = vPalet;
            rpt.c_codsec_pal = v_c_codsec_pal;
            rpt.c_codigo_dis = vDistribuidor;
            rpt.c_codigo_sec = vc_codigo_sec;
            rpt.voice1 = vVoice1;
            rpt.voice2 = vVoice2;
            rpt.c_codigo_jul = c_codigo_jul;
            rpt.CargarParametros();
            ReportPrintTool printTool = new ReportPrintTool(rpt);
            ((SqlDataSource)rpt.DataSource).ConfigureDataConnection += Form1_ConfigureDataConnection;
            rpt.Parameters["COC"].Value = vCOC;
            rpt.Parameters["COC"].Visible = false;
            rpt.Parameters["COCGest"].Value = vCOCGest;
            rpt.Parameters["COCGest"].Visible = false;
            GeneraCodeBarJuliana(vTemporada, vPalet, v_c_codsec_pal,c_codigo_jul);
            //printTool.Print("myPrinter");
            if (rdgTipoImpresion.SelectedIndex == 1)
            {
                rpt.ShowPreviewDialog();
            }
            else
            {
                if (t == 1)
                {
                    t++;
                    printTool.PrintDialog();
                    vPrinterName = printTool.PrinterSettings.PrinterName;
                }
                else
                {
                    printTool.Print(vPrinterName);
                }
            }

            return t;
        }
        private int Etiqueta_Distribuidor_JulianaOrganica(int t, string vPalet)
        {
            string val_juliano = TresCero(FechaJuliana(DateTime.Now));
            c_codigo_jul = CodigoDisExt(vDistribuidor).Trim() + val_juliano.Substring(0, 1) + txtEstiba.Text.Substring(5, 5) + val_juliano.Substring(1, 2);
            rpt_Etiqueta_Distribuidor_JulianaOrganica rpt = new rpt_Etiqueta_Distribuidor_JulianaOrganica();
            rpt.c_codigo_tem = vTemporada;
            rpt.c_codigo_pal = vPalet;
            rpt.c_codsec_pal = v_c_codsec_pal;
            rpt.c_codigo_dis = vDistribuidor;
            rpt.c_codigo_sec = vc_codigo_sec;
            rpt.voice1 = vVoice1;
            rpt.voice2 = vVoice2;
            rpt.c_codigo_jul = c_codigo_jul;
            rpt.CargarParametros();
            ReportPrintTool printTool = new ReportPrintTool(rpt);
            ((SqlDataSource)rpt.DataSource).ConfigureDataConnection += Form1_ConfigureDataConnection;
            rpt.Parameters["COC"].Value = vCOC;
            rpt.Parameters["COC"].Visible = false;
            rpt.Parameters["COCGest"].Value = vCOCGest;
            rpt.Parameters["COCGest"].Visible = false;
            GeneraCodeBarJuliana(vTemporada, vPalet, v_c_codsec_pal, c_codigo_jul);
            //printTool.Print("myPrinter");
            if (rdgTipoImpresion.SelectedIndex == 1)
            {
                rpt.ShowPreviewDialog();
            }
            else
            {
                if (t == 1)
                {
                    t++;
                    printTool.PrintDialog();
                    vPrinterName = printTool.PrinterSettings.PrinterName;
                }
                else
                {
                    printTool.Print(vPrinterName);
                }
            }

            return t;
        }
        private int Etiqueta_SinDistribuidor_Juliana(int t, string vPalet)
        {
            string val_juliano = TresCero(FechaJuliana(DateTime.Now));
            c_codigo_jul = /*CodigoDisExt(vDistribuidor).Trim() + */val_juliano.Substring(0, 1) + txtEstiba.Text.Substring(5, 5) + val_juliano.Substring(1, 2);
            rpt_Etiqueta_SinDistribuidor_Juliana rpt = new rpt_Etiqueta_SinDistribuidor_Juliana();
            rpt.c_codigo_tem = vTemporada;
            rpt.c_codigo_pal = vPalet;
            rpt.c_codsec_pal = v_c_codsec_pal;
            rpt.c_codigo_dis = vDistribuidor;
            rpt.c_codigo_sec = vc_codigo_sec;
            rpt.voice1 = vVoice1;
            rpt.voice2 = vVoice2;
            rpt.c_codigo_jul = c_codigo_jul;
            rpt.CargarParametros();
            ReportPrintTool printTool = new ReportPrintTool(rpt);
            ((SqlDataSource)rpt.DataSource).ConfigureDataConnection += Form1_ConfigureDataConnection;
            rpt.Parameters["COC"].Value = vCOC;
            rpt.Parameters["COC"].Visible = false;
            rpt.Parameters["COCGest"].Value = vCOCGest;
            rpt.Parameters["COCGest"].Visible = false;
            GeneraCodeBarJuliana(vTemporada, vPalet, v_c_codsec_pal, c_codigo_jul);
            //printTool.Print("myPrinter");
            if (rdgTipoImpresion.SelectedIndex == 1)
            {
                rpt.ShowPreviewDialog();
            }
            else
            {
                if (t == 1)
                {
                    t++;
                    printTool.PrintDialog();
                    vPrinterName = printTool.PrinterSettings.PrinterName;
                }
                else
                {
                    printTool.Print(vPrinterName);
                }
            }

            return t;
        }
        private int Etiqueta_SinDistribuidor_Juliana2(int t, string vPalet)
        {
            string val_juliano = TresCero(FechaJuliana(DateTime.Now));
            c_codigo_jul = /*CodigoDisExt(vDistribuidor).Trim() + */val_juliano.Substring(0, 1) + txtEstiba.Text.Substring(5, 5) + val_juliano.Substring(1, 2);
            rpt_Etiqueta_SinDistribuidor_Juliana2 rpt = new rpt_Etiqueta_SinDistribuidor_Juliana2();
            rpt.c_codigo_tem = vTemporada;
            rpt.c_codigo_pal = vPalet;
            rpt.c_codsec_pal = v_c_codsec_pal;
            rpt.c_codigo_dis = vDistribuidor;
            rpt.c_codigo_sec = vc_codigo_sec;
            rpt.voice1 = vVoice1;
            rpt.voice2 = vVoice2;
            rpt.c_codigo_jul = c_codigo_jul;
            rpt.CargarParametros();
            ReportPrintTool printTool = new ReportPrintTool(rpt);
            ((SqlDataSource)rpt.DataSource).ConfigureDataConnection += Form1_ConfigureDataConnection;
            rpt.Parameters["COC"].Value = vCOC;
            rpt.Parameters["COC"].Visible = false;
            rpt.Parameters["COCGest"].Value = vCOCGest;
            rpt.Parameters["COCGest"].Visible = false;
            GeneraCodeBarJuliana(vTemporada, vPalet, v_c_codsec_pal, c_codigo_jul);
            //printTool.Print("myPrinter");
            if (rdgTipoImpresion.SelectedIndex == 1)
            {
                rpt.ShowPreviewDialog();
            }
            else
            {
                if (t == 1)
                {
                    t++;
                    printTool.PrintDialog();
                    vPrinterName = printTool.PrinterSettings.PrinterName;
                }
                else
                {
                    printTool.Print(vPrinterName);
                }
            }

            return t;
        }
        private int Etiqueta_Registro(int t)
        {

            string val_juliano = TresCero(FechaJuliana(DateTime.Now));
            c_codigo_jul = CodigoDisExt(vDistribuidor).Trim() + val_juliano.Substring(0, 1) + txtEstiba.Text.Substring(5, 5) + val_juliano.Substring(1, 2);
            rpt_Etiqueta_Registro rpt = new rpt_Etiqueta_Registro(lblRegistro.Text);
            ReportPrintTool printTool = new ReportPrintTool(rpt);
            //rpt.Parameters["COC"].Value = vCOC;
            //rpt.Parameters["COC"].Visible = false;
            //GeneraCodeBarJuliana(vTemporada, vPalet, v_c_codsec_pal, c_codigo_jul);
            //printTool.Print("myPrinter");
            if (rdgTipoImpresion.SelectedIndex == 1)
            {
                rpt.ShowPreviewDialog();
            }
            else
            {
                if (t == 1)
                {
                    t++;
                    printTool.PrintDialog();
                    vPrinterName = printTool.PrinterSettings.PrinterName;
                }
                else
                {
                    printTool.Print(vPrinterName);
                }
            }

            return t;
        }
        private void Form1_ConfigureDataConnection(object sender, ConfigureDataConnectionEventArgs e)
        {
            MSRegistro RegOut = new MSRegistro();
            Crypto DesencriptarTexto = new Crypto();

            string valServer = RegOut.GetSetting("ConexionSQL", "Server");
            string valDB = RegOut.GetSetting("ConexionSQL", "DBase");
            string valLogin = RegOut.GetSetting("ConexionSQL", "User");
            string valPass = RegOut.GetSetting("ConexionSQL", "Password");

            if (valServer != string.Empty && valDB != string.Empty && valLogin != string.Empty && valPass != string.Empty)
            {
                valServer = DesencriptarTexto.Desencriptar(valServer);
                valDB = DesencriptarTexto.Desencriptar(valDB);
                valLogin = DesencriptarTexto.Desencriptar(valLogin);
                valPass = DesencriptarTexto.Desencriptar(valPass);
                e.ConnectionParameters = new MsSqlConnectionParameters(valServer, valDB, valLogin, valPass, MsSqlAuthorizationType.SqlServer);
            }
        }
        private string CodigoDisExt(string vDistribuidor)
        {
            string Valor = string.Empty;
            CLS_Juliana codext = new CLS_Juliana();
            codext.c_codigo_dis = vDistribuidor;
            codext.MtdSeleccionarJulianaDistribuidor();
            try
            {
                if (codext.Exito)
                {
                    Valor = codext.Datos.Rows[0]["c_codextdis_dis"].ToString().TrimEnd();
                }
            }
            catch (Exception)
            {

                XtraMessageBox.Show("Este distribuidor no esta activo");
            }
            return Valor;
        }

        private string FechaJuliana(DateTime now)
        {
            CLS_Juliana clsval = new CLS_Juliana();
            string fjul=clsval.Fecha_Juliana(now).ToString();
            return fjul;
        }
        private void GeneraCodeBarMARMA(string c_codigo_tem, string c_codigo_pal, string c_codsec_pal)
        {
            CLS_Etiquetas selcod = new CLS_Etiquetas();
            selcod.c_codigo_tem = c_codigo_tem;
            selcod.c_codigo_pal = c_codigo_pal;
            selcod.c_codsec_pal = c_codsec_pal;
            selcod.MtdSeleccionarPaletMarmaCodigo();
            if (selcod.Exito)
            {
                if (selcod.Datos.Rows.Count > 0)
                {
                    string path = @"c:\Etiquetas";
                    if (!Directory.Exists(path))
                    {
                        Directory.CreateDirectory(path);
                    }
                    ptb1.Image = Codigos.CodigosEAN128(selcod.Datos.Rows[0]["codigo"].ToString(), 0);
                    ptb1.Image.Save("C:\\Etiquetas\\CodeBar128.bmp");
                }
            }
        }
        private void GeneraCodeBarSAMS_LGS(string c_codigo_tem, string c_codigo_pal, string c_codsec_pal)
        {
            CLS_Etiquetas selcod = new CLS_Etiquetas();
            selcod.c_codigo_tem = c_codigo_tem;
            selcod.c_codigo_pal = c_codigo_pal;
            selcod.c_codsec_pal = c_codsec_pal;
            selcod.MtdSeleccionarPaletCodigo();
            if (selcod.Exito)
            {
                if (selcod.Datos.Rows.Count > 0)
                {
                    string path = @"c:\Etiquetas";
                    if (!Directory.Exists(path))
                    {
                        Directory.CreateDirectory(path);
                    }

                    ptb1.Image = Codigos.CodigosEAN128(selcod.Datos.Rows[0]["codigo3"].ToString(), 0);
                    ptb1.Image.Save("C:\\Etiquetas\\CodeBar128.bmp");
                }
            }
        }
        private void GeneraCodeBar(string c_codigo_tem, string c_codigo_pal, string c_codsec_pal)
        {
            CLS_Etiquetas selcod = new CLS_Etiquetas();
            selcod.c_codigo_tem = c_codigo_tem;
            selcod.c_codigo_pal = c_codigo_pal;
            selcod.c_codsec_pal = c_codsec_pal;
            selcod.MtdSeleccionarPaletCodigo();
            if (selcod.Exito)
            {
                if (selcod.Datos.Rows.Count > 0)
                {
                    string path = @"c:\Etiquetas";
                    if (!Directory.Exists(path))
                    {
                        Directory.CreateDirectory(path);
                    }

                    ptb1.Image = Codigos.CodigosEAN128(selcod.Datos.Rows[0]["codigo"].ToString(), 0);
                    ptb1.Image.Save("C:\\Etiquetas\\CodeBar128.bmp");
                }
            }
        }
        private void GeneraCodeBarSAMS(string c_codigo_tem, string c_codigo_pal, string c_codsec_pal)
        {
            CLS_Etiquetas selcod = new CLS_Etiquetas();
            selcod.c_codigo_tem = c_codigo_tem;
            selcod.c_codigo_pal = c_codigo_pal;
            selcod.c_codsec_pal = c_codsec_pal;
            selcod.MtdSeleccionarPaletCodigoSAMS();
            if (selcod.Exito)
            {
                if (selcod.Datos.Rows.Count > 0)
                {
                    string path = @"c:\Etiquetas";
                    if (!Directory.Exists(path))
                    {
                        Directory.CreateDirectory(path);
                    }
                    ptb1.Image = Codigos.CodigosEAN128(selcod.Datos.Rows[0]["codigo"].ToString(), 0);
                    ptb1.Image.Save("C:\\Etiquetas\\CodeBar128.bmp");
                }
            }
        }
        private void GeneraCodeBarPLU(string c_codigo_tem, string c_codigo_pal, string c_codsec_pal, string c_codigo_dis, string c_codigo_sec, string voice1, string voice2)
        {
            CLS_Etiqueta_PLU selcod = new CLS_Etiqueta_PLU();
            selcod.c_codigo_tem = c_codigo_tem;
            selcod.c_codigo_pal= c_codigo_pal;
            selcod.c_codsec_pal= c_codsec_pal;
            selcod.c_codigo_dis= c_codigo_dis;
            selcod.c_codigo_sec= c_codigo_sec;
            selcod.voice1= voice1;
            selcod.voice2= voice2;
            selcod.c_codigo_jul = string.Empty;
            selcod.MtdSeleccionarCodigoPLU();
            if (selcod.Exito)
            {
                if (selcod.Datos.Rows.Count > 0)
                {
                    string path = @"c:\Etiquetas";
                    if (!Directory.Exists(path))
                    {
                        Directory.CreateDirectory(path);
                    }
                    ptb1.Image = Codigos.CodigosBarraPLU(selcod.Datos.Rows[0]["c_codigo_plu"].ToString().Trim(), 0);
                    ptb1.Image.Save("C:\\Etiquetas\\CodeBarPLU.bmp");
                }
            }
        }
        private void GeneraCodeBarUPC(string c_codigo_pro)
        {
            CLS_Etiquetas selcod = new CLS_Etiquetas();
            selcod.c_codigo_pro = c_codigo_pro;
            selcod.MtdSeleccionarPaletCodigoUPC();
            if (selcod.Exito)
            {
                if (selcod.Datos.Rows.Count > 0)
                {
                    string path = @"c:\Etiquetas";
                    if (!Directory.Exists(path))
                    {
                        Directory.CreateDirectory(path);
                    }
                    Codigos_TEC_IT.CodigosBarraUPCA(selcod.Datos.Rows[0]["c_codigo_UPC"].ToString().Trim());
                    //ptb1.Image = Codigos.CodigosBarra(selcod.Datos.Rows[0]["c_codigo_UPC"].ToString().Trim(), 0);
                    //ptb1.Image.Save("C:\\Etiquetas\\CodeBarUPC.bmp");
                }
            }
        }
        private void GeneraCodeBarUPCA(string c_codigo_pro)
        {
            CLS_Etiquetas selcod = new CLS_Etiquetas();
            selcod.c_codigo_pro = c_codigo_pro;
            selcod.MtdSeleccionarPaletCodigoUPC();
            if (selcod.Exito)
            {
                if (selcod.Datos.Rows.Count > 0)
                {
                    string path = @"c:\Etiquetas";
                    if (!Directory.Exists(path))
                    {
                        Directory.CreateDirectory(path);
                    }
                    Codigos_TEC_IT.CodigosBarraUPCA(selcod.Datos.Rows[0]["c_codigo_UPC"].ToString().Trim());
                    ////ptb1.Image = Codigos.Codigos128(selcod.Datos.Rows[0]["c_codigo_UPC"].ToString().Trim(),false, 0);
                    
                }
            }
        }
        private void GeneraCodeBarEAN13(string c_codigo_pro)
        {
            CLS_Etiquetas selcod = new CLS_Etiquetas();
            selcod.c_codigo_pro = c_codigo_pro;
            selcod.MtdSeleccionarPaletCodigoEAN13();
            if (selcod.Exito)
            {
                if (selcod.Datos.Rows.Count > 0)
                {
                    string path = @"c:\Etiquetas";
                    if (!Directory.Exists(path))
                    {
                        Directory.CreateDirectory(path);
                    }
                    Codigos_TEC_IT.CodigosBarraEAN13(selcod.Datos.Rows[0]["c_codigo_EAN13"].ToString().Trim());
                    ////ptb1.Image = Codigos.Codigos128(selcod.Datos.Rows[0]["c_codigo_UPC"].ToString().Trim(),false, 0);

                }
            }
        }
        private void GeneraCodeBarJulianaSAMS(string c_codigo_tem, string c_codigo_pal, string c_codsec_pal, string c_codigo_jul)
        {
            CLS_Etiquetas selcod = new CLS_Etiquetas();
            selcod.c_codigo_tem = c_codigo_tem;
            selcod.c_codigo_pal = c_codigo_pal;
            selcod.c_codsec_pal = c_codsec_pal;
            selcod.c_codigo_jul = c_codigo_jul;
            selcod.MtdSeleccionarPaletCodigoJuliana();
            if (selcod.Exito)
            {
                if (selcod.Datos.Rows.Count > 0)
                {
                    string path = @"c:\Etiquetas";
                    if (!Directory.Exists(path))
                    {
                        Directory.CreateDirectory(path);
                    }
                    ptb1.Image = Codigos.CodigosEAN128(selcod.Datos.Rows[0]["codigo2"].ToString(), 0);
                    ptb1.Image.Save("C:\\Etiquetas\\CodeBar128Juliana.bmp");
                }
            }
        }
        private void GeneraCodeBarJuliana(string c_codigo_tem, string c_codigo_pal, string c_codsec_pal, string c_codigo_jul)
        {
            CLS_Etiquetas selcod = new CLS_Etiquetas();
            selcod.c_codigo_tem = c_codigo_tem;
            selcod.c_codigo_pal = c_codigo_pal;
            selcod.c_codsec_pal = c_codsec_pal;
            selcod.c_codigo_jul = c_codigo_jul;
            selcod.MtdSeleccionarPaletCodigoJuliana();
            if (selcod.Exito)
            {
                if (selcod.Datos.Rows.Count > 0)
                {
                    string path = @"c:\Etiquetas";
                    if (!Directory.Exists(path))
                    {
                        Directory.CreateDirectory(path);
                    }
                    ptb1.Image = Codigos.CodigosEAN128(selcod.Datos.Rows[0]["codigo"].ToString(), 0);
                    ptb1.Image.Save("C:\\Etiquetas\\CodeBar128Juliana.bmp");
                }
            }
        }
        private static string DosCero(string sVal)
        {
            string str = "";
            if (sVal.Length == 1)
            {
                return (str = "00" + sVal);
            }
            if (sVal.Length == 2)
            {
                return (str = "0" + sVal);
            }
            return sVal;
        }
        private static string TresCero(string sVal)
        {
            string str = "";
            if (sVal.Length == 1)
            {
                return (str = "00" + sVal);
            }
            if (sVal.Length == 2)
            {
                return (str = "0" + sVal);
            }
            return sVal;
        }
        private static string CerosEstiba(string sVal)
        {
            for (int i = sVal.Length; i < 10; i++)
            {
                sVal = "0" + sVal;
            }
            
            return sVal;
        }

        private void btn_ImprimirRegistro_Click(object sender, EventArgs e)
        {
            if (txtEstiba.Text != string.Empty && cmb_temporada.EditValue != null)
            {
                TextEdit textEdit = new TextEdit();
                textEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
                textEdit.Properties.Mask.EditMask = "f0";
                //textEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.
                XtraInputBoxArgs args = new XtraInputBoxArgs();
                // set required Input Box options 
                args.Caption = "Ingrese la cantidad de etiquetas";
                args.Prompt = "Nombre Archivo";
                args.DefaultButtonIndex = 0;
                //args.Showing += Args_Showing;
                // initialize a DateEdit editor with custom settings 
                TextEdit editor = new TextEdit();
                args.Editor = editor;
                // a default DateEdit value 
                args.DefaultResponse = "Nombre_Archivo_Excel";
                // display an Input Box with the custom editor
                args.Editor = textEdit;
                var result = XtraInputBox.Show(args).ToString();
                if (result != null)
                {
                    int t = 1;
                    for (int i = 0; i < Convert.ToInt32(result); i++)
                    {
                        t = Etiqueta_Registro(t);
                    }
                }
            }
            else
            {
                XtraMessageBox.Show("No se ha seleccionado una estiba");
            }
        }

        private void btnSICFI_Click(object sender, EventArgs e)
        {
            Frm_Archivo_SICFI frm = new Frm_Archivo_SICFI();
            frm.ShowDialog();
        }

        private void btn_FechaPalet_Click(object sender, EventArgs e)
        {
            Frm_FechaPalet frm = new Frm_FechaPalet();
            frm.vPalet = v_paletmod;
            frm.vTemporada = cmb_temporada.EditValue.ToString();
            frm.ShowDialog();
        }

        private void cmb_tipoetiqueta_EditValueChanged(object sender, EventArgs e)
        {
            CargarImportador("001");
            if(cmb_tipoetiqueta.EditValue.ToString()=="40")
            {
                labelControl7.Visible = true;
                txtMateriaSeca.Visible = true;
            }
            else
            {
                labelControl7.Visible = false;
                txtMateriaSeca.Visible = false;
            }
        }

        private void btnRendimineto_Click(object sender, EventArgs e)
        {
            Frm_Rendimiento frm = new Frm_Rendimiento();
            this.Hide();
            frm.Show();
        }
    }
}
