namespace Etiquetas_AGV.Formularios
{
    partial class Frm_Bascula
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Bascula));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.SpPuertos = new System.IO.Ports.SerialPort(this.components);
            this.btnBuscarPuertos = new DevExpress.XtraEditors.SimpleButton();
            this.cmb_Puertos = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.cmb_Baud_Rate = new DevExpress.XtraEditors.ComboBoxEdit();
            this.btnConectar = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txt_palet = new DevExpress.XtraEditors.TextEdit();
            this.btn_EmpresaBascula = new DevExpress.XtraEditors.SimpleButton();
            this.txt_Peso = new DevExpress.XtraEditors.TextEdit();
            this.txt_Tara = new DevExpress.XtraEditors.TextEdit();
            this.txt_Neto = new DevExpress.XtraEditors.TextEdit();
            this.BtnLeerPuertos = new DevExpress.XtraEditors.SimpleButton();
            this.btnGuardarPeso = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Puertos.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Baud_Rate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_palet.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Peso.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Tara.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Neto.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.groupControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelControl1.Location = new System.Drawing.Point(10, 10);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Padding = new System.Windows.Forms.Padding(10);
            this.panelControl1.Size = new System.Drawing.Size(263, 286);
            this.panelControl1.TabIndex = 0;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.groupControl2);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(273, 10);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Padding = new System.Windows.Forms.Padding(10);
            this.panelControl2.Size = new System.Drawing.Size(256, 286);
            this.panelControl2.TabIndex = 1;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.btnConectar);
            this.groupControl1.Controls.Add(this.cmb_Baud_Rate);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.cmb_Puertos);
            this.groupControl1.Controls.Add(this.btnBuscarPuertos);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(12, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(239, 262);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Configuracion Puerto";
            // 
            // SpPuertos
            // 
            this.SpPuertos.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.DatoRecibido);
            // 
            // btnBuscarPuertos
            // 
            this.btnBuscarPuertos.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.btnBuscarPuertos.Location = new System.Drawing.Point(53, 157);
            this.btnBuscarPuertos.Name = "btnBuscarPuertos";
            this.btnBuscarPuertos.Size = new System.Drawing.Size(131, 44);
            this.btnBuscarPuertos.TabIndex = 0;
            this.btnBuscarPuertos.Text = "BuscarPuertos";
            this.btnBuscarPuertos.Click += new System.EventHandler(this.btnBuscarPuertos_Click);
            // 
            // cmb_Puertos
            // 
            this.cmb_Puertos.Location = new System.Drawing.Point(83, 43);
            this.cmb_Puertos.Name = "cmb_Puertos";
            this.cmb_Puertos.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_Puertos.Size = new System.Drawing.Size(100, 20);
            this.cmb_Puertos.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(20, 73);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(54, 13);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Baud Rate:";
            // 
            // cmb_Baud_Rate
            // 
            this.cmb_Baud_Rate.EditValue = "9600";
            this.cmb_Baud_Rate.Location = new System.Drawing.Point(83, 69);
            this.cmb_Baud_Rate.Name = "cmb_Baud_Rate";
            this.cmb_Baud_Rate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_Baud_Rate.Properties.Items.AddRange(new object[] {
            "1200",
            "2400",
            "4800",
            "9600",
            "14400",
            "19200",
            "28800",
            "38400",
            "56000",
            "115200"});
            this.cmb_Baud_Rate.Size = new System.Drawing.Size(100, 20);
            this.cmb_Baud_Rate.TabIndex = 3;
            // 
            // btnConectar
            // 
            this.btnConectar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.btnConectar.Location = new System.Drawing.Point(53, 112);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(131, 39);
            this.btnConectar.TabIndex = 4;
            this.btnConectar.Text = "Conectar Puerto";
            this.btnConectar.Click += new System.EventHandler(this.btnConectar_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(29, 47);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(41, 13);
            this.labelControl2.TabIndex = 5;
            this.labelControl2.Text = "Puertos:";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.btnGuardarPeso);
            this.groupControl2.Controls.Add(this.BtnLeerPuertos);
            this.groupControl2.Controls.Add(this.txt_Neto);
            this.groupControl2.Controls.Add(this.txt_Tara);
            this.groupControl2.Controls.Add(this.txt_Peso);
            this.groupControl2.Controls.Add(this.btn_EmpresaBascula);
            this.groupControl2.Controls.Add(this.txt_palet);
            this.groupControl2.Controls.Add(this.labelControl6);
            this.groupControl2.Controls.Add(this.labelControl5);
            this.groupControl2.Controls.Add(this.labelControl3);
            this.groupControl2.Controls.Add(this.labelControl4);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(12, 12);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(232, 262);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "Palet / Palet Estibado";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(29, 47);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(28, 13);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "Palet:";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(29, 77);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(27, 13);
            this.labelControl4.TabIndex = 2;
            this.labelControl4.Text = "Peso:";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(29, 103);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(26, 13);
            this.labelControl5.TabIndex = 6;
            this.labelControl5.Text = "Tara:";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(28, 129);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(27, 13);
            this.labelControl6.TabIndex = 7;
            this.labelControl6.Text = "Neto:";
            // 
            // txt_palet
            // 
            this.txt_palet.Location = new System.Drawing.Point(73, 43);
            this.txt_palet.Name = "txt_palet";
            this.txt_palet.Size = new System.Drawing.Size(100, 20);
            this.txt_palet.TabIndex = 8;
            // 
            // btn_EmpresaBascula
            // 
            this.btn_EmpresaBascula.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_EmpresaBascula.ImageOptions.Image")));
            this.btn_EmpresaBascula.Location = new System.Drawing.Point(179, 42);
            this.btn_EmpresaBascula.Name = "btn_EmpresaBascula";
            this.btn_EmpresaBascula.Size = new System.Drawing.Size(24, 23);
            this.btn_EmpresaBascula.TabIndex = 32;
            // 
            // txt_Peso
            // 
            this.txt_Peso.Location = new System.Drawing.Point(73, 73);
            this.txt_Peso.Name = "txt_Peso";
            this.txt_Peso.Size = new System.Drawing.Size(100, 20);
            this.txt_Peso.TabIndex = 33;
            // 
            // txt_Tara
            // 
            this.txt_Tara.Enabled = false;
            this.txt_Tara.Location = new System.Drawing.Point(73, 99);
            this.txt_Tara.Name = "txt_Tara";
            this.txt_Tara.Size = new System.Drawing.Size(100, 20);
            this.txt_Tara.TabIndex = 34;
            // 
            // txt_Neto
            // 
            this.txt_Neto.Enabled = false;
            this.txt_Neto.Location = new System.Drawing.Point(73, 125);
            this.txt_Neto.Name = "txt_Neto";
            this.txt_Neto.Size = new System.Drawing.Size(100, 20);
            this.txt_Neto.TabIndex = 35;
            // 
            // BtnLeerPuertos
            // 
            this.BtnLeerPuertos.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton3.ImageOptions.Image")));
            this.BtnLeerPuertos.Location = new System.Drawing.Point(53, 158);
            this.BtnLeerPuertos.Name = "BtnLeerPuertos";
            this.BtnLeerPuertos.Size = new System.Drawing.Size(131, 39);
            this.BtnLeerPuertos.TabIndex = 36;
            this.BtnLeerPuertos.Text = "Leer Peso";
            this.BtnLeerPuertos.Click += new System.EventHandler(this.BtnLeerPuertos_Click);
            // 
            // btnGuardarPeso
            // 
            this.btnGuardarPeso.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton4.ImageOptions.Image")));
            this.btnGuardarPeso.Location = new System.Drawing.Point(53, 203);
            this.btnGuardarPeso.Name = "btnGuardarPeso";
            this.btnGuardarPeso.Size = new System.Drawing.Size(131, 39);
            this.btnGuardarPeso.TabIndex = 37;
            this.btnGuardarPeso.Text = "Guardar";
            // 
            // Frm_Bascula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 306);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Name = "Frm_Bascula";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "Bascula";
            this.Load += new System.EventHandler(this.Frm_Bascula_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Puertos.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Baud_Rate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_palet.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Peso.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Tara.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Neto.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private System.IO.Ports.SerialPort SpPuertos;
        private DevExpress.XtraEditors.SimpleButton btnConectar;
        private DevExpress.XtraEditors.ComboBoxEdit cmb_Baud_Rate;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.ComboBoxEdit cmb_Puertos;
        private DevExpress.XtraEditors.SimpleButton btnBuscarPuertos;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.TextEdit txt_palet;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.SimpleButton btnGuardarPeso;
        private DevExpress.XtraEditors.SimpleButton BtnLeerPuertos;
        private DevExpress.XtraEditors.TextEdit txt_Neto;
        private DevExpress.XtraEditors.TextEdit txt_Tara;
        private DevExpress.XtraEditors.TextEdit txt_Peso;
        private DevExpress.XtraEditors.SimpleButton btn_EmpresaBascula;
    }
}