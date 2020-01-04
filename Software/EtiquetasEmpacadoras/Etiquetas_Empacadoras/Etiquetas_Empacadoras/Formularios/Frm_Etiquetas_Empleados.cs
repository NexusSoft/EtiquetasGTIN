using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CapaDeDatos;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraReports.UI;

namespace Etiquetas_Empacadoras
{
    public partial class Frm_Etiquetas_Empleados : DevExpress.XtraEditors.XtraForm
    {
        public string c_codigo_usu { get; internal set; }
        public string c_codigo_emp { get; private set; }
        public string v_nombre_emp { get; private set; }
        public string n_cantidad { get; private set; }
        public string vPrinterName { get; private set; }
        public bool PrimeraEdicion { get; private set; }

        public Frm_Etiquetas_Empleados()
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
            column.ColumnName = "c_codigo_emp";
            column.AutoIncrement = false;
            column.Caption = "Tem";
            column.ReadOnly = false;
            column.Unique = false;

            table.Columns.Add(column);

            column = new DataColumn();
            column.DataType = typeof(string);
            column.ColumnName = "v_nombre_emp";
            column.AutoIncrement = false;
            column.Caption = "Sel";
            column.ReadOnly = false;
            column.Unique = false;

            table.Columns.Add(column);

            column = new DataColumn();
            column.DataType = typeof(int);
            column.ColumnName = "n_cantidad";
            column.AutoIncrement = false;
            column.Caption = "Palet";
            column.ReadOnly = false;
            column.Unique = false;

            table.Columns.Add(column);
            dtgEmpleados.DataSource = table;
        }
        private void CreatNewRowArticulo(string c_codigo_emp, string v_nombre_emp, string n_cantidad)
        {
            dtgValEmpleados.AddNewRow();

            int rowHandle = dtgValEmpleados.GetRowHandle(dtgValEmpleados.DataRowCount);
            if (dtgValEmpleados.IsNewItemRow(rowHandle))
            {
                dtgValEmpleados.SetRowCellValue(rowHandle, dtgValEmpleados.Columns["c_codigo_emp"], c_codigo_emp);
                dtgValEmpleados.SetRowCellValue(rowHandle, dtgValEmpleados.Columns["v_nombre_emp"], v_nombre_emp);
                dtgValEmpleados.SetRowCellValue(rowHandle, dtgValEmpleados.Columns["n_cantidad"], n_cantidad);
            }
        }

        
        private void btnLimpiar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            MakeTablaPedidosInsidencias();
            txtCantidad.Text = "0";
            PrimeraEdicion = false;
        }
        private void btnAgregar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Convert.ToInt32(txtCantidad.Text)>0)
            {
                Frm_Empleados_Listar sel = new Frm_Empleados_Listar();
                sel.ShowDialog();
                if (sel.CadenaCodigos != null)
                {
                    string[] Empleados = sel.CadenaCodigos.Split(',');
                    foreach (string vEmpleado in Empleados)
                    {
                        CLS_Empleado selemp = new CLS_Empleado();
                        selemp.c_codigo_emp = vEmpleado;
                        selemp.v_nombre_emp = "";
                        selemp.MtdSeleccionarCodigoNombre();
                        if (selemp.Exito)
                        {
                            if (selemp.Datos.Rows.Count > 0)
                            {
                                c_codigo_emp = vEmpleado;
                                v_nombre_emp = selemp.Datos.Rows[0]["v_nombre_emp"].ToString();
                                n_cantidad = txtCantidad.Text;
                                CreatNewRowArticulo(c_codigo_emp, v_nombre_emp, n_cantidad);
                            }
                        }
                    }
                }
            }
            else
            {
                XtraMessageBox.Show("Debe definir una cantidad de Etiquetas");
                txtCantidad.Focus();
            }
        }

        private void btnImprimir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (dtgValEmpleados.RowCount > 0)
            {
                int t = 0;
                for (int i = 0; i < dtgValEmpleados.RowCount; i++)
                {
                    int xRow = dtgValEmpleados.GetVisibleRowHandle(i);
                    if (dtgValEmpleados.GetRowCellValue(xRow, "c_codigo_emp").ToString() != string.Empty)
                    {
                        int n_eti = Convert.ToInt32(dtgValEmpleados.GetRowCellValue(xRow, "n_cantidad").ToString()) / 2;
                        for (int s = 0; s < n_eti; s++)
                        {
                            string c_codigo_emp = dtgValEmpleados.GetRowCellValue(xRow, "c_codigo_emp").ToString();
                            rpt_Etiqueta_Empaque rpt = new rpt_Etiqueta_Empaque(c_codigo_emp);
                            ReportPrintTool printTool = new ReportPrintTool(rpt);
                            GeneraCodeBar(c_codigo_emp);
                            if (rdgTipoImpresion.SelectedIndex == 1)
                            {
                                rpt.ShowPreviewDialog();
                                break;
                            }
                            else
                            {
                                if (t == 0)
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
                        }
                    }
                }
            }
        }
        private void GeneraCodeBar(string c_codido_emp)
        {
            string path = @"c:\Etiquetas";
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            ptb1.Image = Codigos.CodigosBarra(c_codido_emp, 0);
            ptb1.Image.Save("C:\\Etiquetas\\CodeBarEmp.bmp");

        }
        private void btnSalir_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void Frm_Etiquetas_Empleados_Shown(object sender, EventArgs e)
        {
            MakeTablaPedidosInsidencias();
            txtCantidad.Text = "2";
            PrimeraEdicion = false;
        }

        private void txtCantidad_EditValueChanged(object sender, EventArgs e)
        {
            if(Convert.ToInt32(txtCantidad.Text)%2 !=0)
            {
                txtCantidad.Text =Convert.ToString(Convert.ToInt32(txtCantidad.Text) + 1);
            }
        }

        private void dtgValEmpleados_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            GridView gv = sender as GridView;
            if (gv.GetRowCellValue(e.RowHandle, gv.Columns["n_cantidad"]).ToString() != string.Empty)
            {
                if (!PrimeraEdicion)
                {
                    PrimeraEdicion = true;

                    int TEtiquetas = 0;
                    TEtiquetas += Convert.ToInt32(gv.GetRowCellValue(e.RowHandle, gv.Columns["n_cantidad"]).ToString());
                    if (TEtiquetas % 2 != 0)
                    {
                        TEtiquetas++;
                        gv.SetRowCellValue(e.RowHandle, gv.Columns["n_cantidad"], TEtiquetas);
                    }
                    PrimeraEdicion = false;
                }
            }
        }

        private void txtNoEmpleado_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyValue==13)
            {
                if (txtNoEmpleado.Text != string.Empty && Convert.ToInt32(txtCantidad.Text)>0)
                {
                    txtNoEmpleado.Text = CerosEmpleado(txtNoEmpleado.Text);
                    CLS_Empleado selemp = new CLS_Empleado();
                    selemp.c_codigo_emp = CerosEmpleado(txtNoEmpleado.Text);
                    selemp.v_nombre_emp = "";
                    selemp.MtdSeleccionarCodigoNombre();
                    if (selemp.Exito)
                    {
                        if (selemp.Datos.Rows.Count > 0)
                        {
                            c_codigo_emp = txtNoEmpleado.Text;
                            v_nombre_emp = selemp.Datos.Rows[0]["v_nombre_emp"].ToString();
                            n_cantidad = txtCantidad.Text;
                            CreatNewRowArticulo(CerosEmpleado(c_codigo_emp), v_nombre_emp, n_cantidad);
                            dtgValEmpleados.ClearSelection();
                            txtNoEmpleado.Text = string.Empty;
                            txtNoEmpleado.Focus();
                        }
                        else
                        {
                            XtraMessageBox.Show("No se ha encontrado este empleado");
                        }
                    }
                }
                else
                {
                    XtraMessageBox.Show("El empleado no existe o la cantidad de etiquetas no es mayor a 0");
                }
            }
        }
        private string CerosEmpleado(string sVal)
        {
            string str = "";
            for (int i = sVal.Length; i < 6; i++)
            {
                sVal = "0" + sVal;
            }

            return sVal;
        }
    }
}
