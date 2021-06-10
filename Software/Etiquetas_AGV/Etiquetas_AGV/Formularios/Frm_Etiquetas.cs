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
                    }
                    else
                    {
                        CadenaCodigos = rv["c_codigo_pal"].ToString();
                    }
                }
            }
            if (CadenaCodigos == string.Empty)
            {
                btn_Imprimir.Enabled = false;
            }
            else
            {
                btn_Imprimir.Enabled = true;
            }
        }
        private void Frm_Etiquetas_Shown(object sender, EventArgs e)
        {
            lblRegistro.Text = string.Empty;
            MakeTablaPedidosInsidencias();
            GridMultiplePalets();
            CargarCalibres(null);
            CargarDistribuidor(null);
            CargarEtiquetas(null);
            CargarTemporadaActiva();
            CargarTemporada(TemActiva);
            cmb_calibre.Enabled = false;
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
        }

        private void BuscarCOC()
        {
            CLS_Estiba sel = new CLS_Estiba();
            sel.MtdSeleccionarEmpaqueCOC();
            if(sel.Exito)
            {
                if(sel.Datos.Rows.Count>0)
                {
                    vCOC ="CoC: "+ sel.Datos.Rows[0]["v_codigoaux_pem"].ToString();
                }
                else
                {
                    vCOC = string.Empty;
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
                        }
                    }
                }
            }
            CLS_Estiba sel1 = new CLS_Estiba();
            sel1.c_codigo_sel = c_codigo_sel;
            sel1.c_codigo_tem = c_codigo_tem;
            sel1.MtdSeleccionarRegistroHueEstiba();
            if (sel1.Exito)
            {
                vRegistro = sel1.Datos.Rows[0]["v_registro_hue"].ToString();
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
        private int Etiqueta_Argentina_2_3(int t, string vPalet, string vCProducto)
        {
            rpt_Etiqueta_Argentina_2_3TSC rpt = new rpt_Etiqueta_Argentina_2_3TSC(vTemporada, vPalet, v_c_codsec_pal, vDistribuidor, vc_codigo_sec, vVoice1, vVoice2);
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
            rpt_Etiqueta_FamilyTree rpt = new rpt_Etiqueta_FamilyTree(vTemporada, vPalet, v_c_codsec_pal, vDistribuidor, vc_codigo_sec, vVoice1, vVoice2);
            ReportPrintTool printTool = new ReportPrintTool(rpt);
            ((SqlDataSource)rpt.DataSource).ConfigureDataConnection += Form1_ConfigureDataConnection;
            rpt.Parameters["COC"].Value = vCOC;
            rpt.Parameters["COC"].Visible = false;
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
            rpt_Etiqueta_WestFalia rpt = new rpt_Etiqueta_WestFalia(vTemporada, vPalet, v_c_codsec_pal, vDistribuidor, vc_codigo_sec, vVoice1, vVoice2);
            ReportPrintTool printTool = new ReportPrintTool(rpt);
            ((SqlDataSource)rpt.DataSource).ConfigureDataConnection += Form1_ConfigureDataConnection;
            rpt.Parameters["COC"].Value = vCOC;
            rpt.Parameters["COC"].Visible = false;
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

        private int Etiqueta_Distribuidor(int t, string vPalet)
        {
            rpt_Etiqueta_Distribuidor rpt = new rpt_Etiqueta_Distribuidor(vTemporada, vPalet, v_c_codsec_pal, vDistribuidor, vc_codigo_sec, vVoice1, vVoice2);
            ReportPrintTool printTool = new ReportPrintTool(rpt);
            ((SqlDataSource)rpt.DataSource).ConfigureDataConnection += Form1_ConfigureDataConnection;
            rpt.Parameters["COC"].Value = vCOC;
            rpt.Parameters["COC"].Visible = false;
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
            rpt_Etiqueta_PTI_Organic rpt = new rpt_Etiqueta_PTI_Organic(vTemporada, vPalet, v_c_codsec_pal, vDistribuidor, vc_codigo_sec, vVoice1, vVoice2);
            ReportPrintTool printTool = new ReportPrintTool(rpt);
            ((SqlDataSource)rpt.DataSource).ConfigureDataConnection += Form1_ConfigureDataConnection;
            rpt.Parameters["COC"].Value = vCOC;
            rpt.Parameters["COC"].Visible = false;
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
            rpt_Etiqueta_UPC_Organic rpt = new rpt_Etiqueta_UPC_Organic(vTemporada, vPalet, v_c_codsec_pal, vDistribuidor, vc_codigo_sec, vVoice1, vVoice2);
            ReportPrintTool printTool = new ReportPrintTool(rpt);
            ((SqlDataSource)rpt.DataSource).ConfigureDataConnection += Form1_ConfigureDataConnection;
            rpt.Parameters["COC"].Value = vCOC;
            rpt.Parameters["COC"].Visible = false;
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
            rpt_Etiqueta_UPC_SAMS rpt = new rpt_Etiqueta_UPC_SAMS(vTemporada, vPalet, v_c_codsec_pal, vDistribuidor, vc_codigo_sec, vVoice1, vVoice2);
            ReportPrintTool printTool = new ReportPrintTool(rpt);
            ((SqlDataSource)rpt.DataSource).ConfigureDataConnection += Form1_ConfigureDataConnection;
            ReportPrintTool print = new ReportPrintTool(rpt);
            rpt.Parameters["COC"].Value = vCOC;
            rpt.Parameters["COC"].Visible = false;
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
        private int Etiqueta_UPC_Anderson_Juliana(int t, string vPalet, string vcproducto, Boolean plu)
        {
            string val_juliano = TresCero(FechaJuliana(DateTime.Now));
            c_codigo_jul = CodigoDisExt(vDistribuidor).Trim() + val_juliano.Substring(0, 1) + txtEstiba.Text.Substring(5, 5) + val_juliano.Substring(1, 2);
            rpt_Etiqueta_UPC_AndersonJuliana rpt = new rpt_Etiqueta_UPC_AndersonJuliana(vTemporada, vPalet, v_c_codsec_pal, vDistribuidor, vc_codigo_sec, vVoice1, vVoice2,c_codigo_jul, plu);
            ReportPrintTool printTool = new ReportPrintTool(rpt);
            ((SqlDataSource)rpt.DataSource).ConfigureDataConnection += Form1_ConfigureDataConnection;
            ReportPrintTool print = new ReportPrintTool(rpt);
            rpt.Parameters["COC"].Value = vCOC;
            rpt.Parameters["COC"].Visible = false;
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
            rpt_Etiqueta_UPC_Anderson rpt = new rpt_Etiqueta_UPC_Anderson(vTemporada, vPalet, v_c_codsec_pal, vDistribuidor, vc_codigo_sec, vVoice1, vVoice2, plu);
            ReportPrintTool printTool = new ReportPrintTool(rpt);
            ((SqlDataSource)rpt.DataSource).ConfigureDataConnection += Form1_ConfigureDataConnection;
            ReportPrintTool print = new ReportPrintTool(rpt);
            rpt.Parameters["COC"].Value = vCOC;
            rpt.Parameters["COC"].Visible = false;
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
        private int Etiqueta_UPC_Anderson_Organic(int t, string vPalet, string vcproducto, Boolean plu)
        {
            rpt_Etiqueta_UPC_Anderson_Organic rpt = new rpt_Etiqueta_UPC_Anderson_Organic(vTemporada, vPalet, v_c_codsec_pal, vDistribuidor, vc_codigo_sec, vVoice1, vVoice2, plu);
            ReportPrintTool printTool = new ReportPrintTool(rpt);
            ((SqlDataSource)rpt.DataSource).ConfigureDataConnection += Form1_ConfigureDataConnection;
            ReportPrintTool print = new ReportPrintTool(rpt);
            rpt.Parameters["COC"].Value = vCOC;
            rpt.Parameters["COC"].Visible = false;
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
            rpt_Etiqueta_UPC_CROGER rpt = new rpt_Etiqueta_UPC_CROGER(vTemporada, vPalet, v_c_codsec_pal, vDistribuidor, vc_codigo_sec, vVoice1, vVoice2,plu);
            ReportPrintTool printTool = new ReportPrintTool(rpt);
            ((SqlDataSource)rpt.DataSource).ConfigureDataConnection += Form1_ConfigureDataConnection;
            ReportPrintTool print = new ReportPrintTool(rpt);
            rpt.Parameters["COC"].Value = vCOC;
            rpt.Parameters["COC"].Visible = false;
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
            rpt_Etiqueta_UPC_CROGER_Juliana rpt = new rpt_Etiqueta_UPC_CROGER_Juliana(vTemporada, vPalet, v_c_codsec_pal, vDistribuidor, vc_codigo_sec, vVoice1, vVoice2, c_codigo_jul,plu);
            ((SqlDataSource)rpt.DataSource).ConfigureDataConnection += Form1_ConfigureDataConnection;
            ReportPrintTool printTool = new ReportPrintTool(rpt);
            rpt.Parameters["COC"].Value = vCOC;
            rpt.Parameters["COC"].Visible = false;
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
            rpt_Etiqueta_UPC rpt = new rpt_Etiqueta_UPC(vTemporada, vPalet, v_c_codsec_pal, vDistribuidor, vc_codigo_sec, vVoice1, vVoice2);
            ReportPrintTool printTool = new ReportPrintTool(rpt);
            ((SqlDataSource)rpt.DataSource).ConfigureDataConnection += Form1_ConfigureDataConnection;
            rpt.Parameters["COC"].Value = vCOC;
            rpt.Parameters["COC"].Visible = false;
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
            rpt_Etiqueta_UPC_Juliana rpt = new rpt_Etiqueta_UPC_Juliana(vTemporada, vPalet, v_c_codsec_pal, vDistribuidor, vc_codigo_sec, vVoice1, vVoice2, c_codigo_jul);
            ReportPrintTool printTool = new ReportPrintTool(rpt);
            ((SqlDataSource)rpt.DataSource).ConfigureDataConnection += Form1_ConfigureDataConnection;
            rpt.Parameters["COC"].Value = vCOC;
            rpt.Parameters["COC"].Visible = false;
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
            rpt_Etiqueta_UPC_SAMS_Juliana rpt = new rpt_Etiqueta_UPC_SAMS_Juliana(vTemporada, vPalet, v_c_codsec_pal, vDistribuidor, vc_codigo_sec, vVoice1, vVoice2, c_codigo_jul);
            ReportPrintTool printTool = new ReportPrintTool(rpt);
            ((SqlDataSource)rpt.DataSource).ConfigureDataConnection += Form1_ConfigureDataConnection;
            rpt.Parameters["COC"].Value = vCOC;
            rpt.Parameters["COC"].Visible = false;
            GeneraCodeBarJulianaSAMS(vTemporada, vPalet, v_c_codsec_pal, c_codigo_jul);
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
        private int Etiqueta_HEB(int t, string vPalet)
        {
            rpt_Etiqueta_HEB rpt = new rpt_Etiqueta_HEB(vTemporada, vPalet, v_c_codsec_pal, vDistribuidor, vc_codigo_sec, vVoice1, vVoice2);
            ReportPrintTool printTool = new ReportPrintTool(rpt);
            ((SqlDataSource)rpt.DataSource).ConfigureDataConnection += Form1_ConfigureDataConnection;
            rpt.Parameters["COC"].Value = vCOC;
            rpt.Parameters["COC"].Visible = false;
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
        private int Etiqueta_Distribuidor_Juliana(int t, string vPalet)
        {
            string val_juliano =TresCero(FechaJuliana(DateTime.Now));
            c_codigo_jul =CodigoDisExt(vDistribuidor).Trim() + val_juliano.Substring(0, 1) + txtEstiba.Text.Substring(5,5) + val_juliano.Substring(1, 2);
            rpt_Etiqueta_Distribuidor_Juliana rpt = new rpt_Etiqueta_Distribuidor_Juliana(vTemporada, vPalet, v_c_codsec_pal, vDistribuidor, vc_codigo_sec, vVoice1, vVoice2,c_codigo_jul);
            ReportPrintTool printTool = new ReportPrintTool(rpt);
            ((SqlDataSource)rpt.DataSource).ConfigureDataConnection += Form1_ConfigureDataConnection;
            rpt.Parameters["COC"].Value = vCOC;
            rpt.Parameters["COC"].Visible = false;
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
        private int Etiqueta_SinDistribuidor_Juliana(int t, string vPalet)
        {
            string val_juliano = TresCero(FechaJuliana(DateTime.Now));
            c_codigo_jul = /*CodigoDisExt(vDistribuidor).Trim() + */val_juliano.Substring(0, 1) + txtEstiba.Text.Substring(5, 5) + val_juliano.Substring(1, 2);
            rpt_Etiqueta_SinDistribuidor_Juliana rpt = new rpt_Etiqueta_SinDistribuidor_Juliana(vTemporada, vPalet, v_c_codsec_pal, vDistribuidor, vc_codigo_sec, vVoice1, vVoice2, c_codigo_jul);
            ReportPrintTool printTool = new ReportPrintTool(rpt);
            ((SqlDataSource)rpt.DataSource).ConfigureDataConnection += Form1_ConfigureDataConnection;
            rpt.Parameters["COC"].Value = vCOC;
            rpt.Parameters["COC"].Visible = false;
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
            if(codext.Exito)
            {
                Valor = codext.Datos.Rows[0]["c_codextdis_dis"].ToString().TrimEnd();
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
                    ptb1.Image = Codigos.CodigosBarra(selcod.Datos.Rows[0]["c_codigo_UPC"].ToString().Trim(), 0);
                    //ptb1.Image = Codigos.Codigos128(selcod.Datos.Rows[0]["c_codigo_UPC"].ToString().Trim(),false, 0);
                    ptb1.Image.Save("C:\\Etiquetas\\CodeBarUPC.bmp");
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
                    ptb1.Image = Codigos.CodigosBarraUPCA(selcod.Datos.Rows[0]["c_codigo_UPC"].ToString().Trim(), 0);
                    //ptb1.Image = Codigos.Codigos128(selcod.Datos.Rows[0]["c_codigo_UPC"].ToString().Trim(),false, 0);
                    ptb1.Image.Save("C:\\Etiquetas\\CodeBarUPCA.bmp");
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
            string str = "";
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
    }
}
