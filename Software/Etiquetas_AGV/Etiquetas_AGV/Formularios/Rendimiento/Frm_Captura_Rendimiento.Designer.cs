namespace Etiquetas_AGV.Formularios.Rendimiento
{
    partial class Frm_Captura_Rendimiento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Captura_Rendimiento));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txt_kilosPalet = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.cmb_temporada = new DevExpress.XtraEditors.LookUpEdit();
            this.separatorControl1 = new DevExpress.XtraEditors.SeparatorControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txt_kilos_estiba = new DevExpress.XtraEditors.TextEdit();
            this.btn_agregar_palet = new DevExpress.XtraEditors.SimpleButton();
            this.txt_palet = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.dt_FechaFin = new DevExpress.XtraEditors.DateEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.dt_FechaInicio = new DevExpress.XtraEditors.DateEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.btn_cierra_corrida = new DevExpress.XtraEditors.SimpleButton();
            this.btn_BuscarEstiba = new DevExpress.XtraEditors.SimpleButton();
            this.txt_estiba = new DevExpress.XtraEditors.TextEdit();
            this.btn_Inicia_corrida = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_kilosPalet.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_temporada.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_kilos_estiba.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_palet.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_FechaFin.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_FechaFin.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_FechaInicio.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_FechaInicio.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_estiba.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.labelControl7);
            this.panelControl1.Controls.Add(this.txt_kilosPalet);
            this.panelControl1.Controls.Add(this.labelControl6);
            this.panelControl1.Controls.Add(this.cmb_temporada);
            this.panelControl1.Controls.Add(this.separatorControl1);
            this.panelControl1.Controls.Add(this.labelControl5);
            this.panelControl1.Controls.Add(this.txt_kilos_estiba);
            this.panelControl1.Controls.Add(this.btn_agregar_palet);
            this.panelControl1.Controls.Add(this.txt_palet);
            this.panelControl1.Controls.Add(this.labelControl4);
            this.panelControl1.Controls.Add(this.dt_FechaFin);
            this.panelControl1.Controls.Add(this.labelControl3);
            this.panelControl1.Controls.Add(this.dt_FechaInicio);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.btn_cierra_corrida);
            this.panelControl1.Controls.Add(this.btn_BuscarEstiba);
            this.panelControl1.Controls.Add(this.txt_estiba);
            this.panelControl1.Controls.Add(this.btn_Inicia_corrida);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(472, 247);
            this.panelControl1.TabIndex = 0;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(31, 212);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(70, 13);
            this.labelControl7.TabIndex = 52;
            this.labelControl7.Text = "kgs a agregar:";
            // 
            // txt_kilosPalet
            // 
            this.txt_kilosPalet.EditValue = "0";
            this.txt_kilosPalet.Enabled = false;
            this.txt_kilosPalet.Location = new System.Drawing.Point(119, 208);
            this.txt_kilosPalet.Name = "txt_kilosPalet";
            this.txt_kilosPalet.Properties.BeepOnError = true;
            this.txt_kilosPalet.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.txt_kilosPalet.Properties.MaskSettings.Set("MaskManagerSignature", "allowNull=False");
            this.txt_kilosPalet.Properties.MaskSettings.Set("mask", "n");
            this.txt_kilosPalet.Properties.MaskSettings.Set("culture", "es-MX");
            this.txt_kilosPalet.Properties.MaskSettings.Set("valueType", typeof(decimal));
            this.txt_kilosPalet.Properties.UseMaskAsDisplayFormat = true;
            this.txt_kilosPalet.Size = new System.Drawing.Size(126, 20);
            this.txt_kilosPalet.TabIndex = 51;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(31, 9);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(54, 13);
            this.labelControl6.TabIndex = 50;
            this.labelControl6.Text = "Temporada";
            // 
            // cmb_temporada
            // 
            this.cmb_temporada.Enabled = false;
            this.cmb_temporada.Location = new System.Drawing.Point(119, 5);
            this.cmb_temporada.Name = "cmb_temporada";
            this.cmb_temporada.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_temporada.Size = new System.Drawing.Size(111, 20);
            this.cmb_temporada.TabIndex = 49;
            // 
            // separatorControl1
            // 
            this.separatorControl1.BackColor = System.Drawing.Color.Transparent;
            this.separatorControl1.LineColor = System.Drawing.Color.Black;
            this.separatorControl1.Location = new System.Drawing.Point(0, 148);
            this.separatorControl1.Name = "separatorControl1";
            this.separatorControl1.Size = new System.Drawing.Size(484, 23);
            this.separatorControl1.TabIndex = 48;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(31, 62);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(74, 13);
            this.labelControl5.TabIndex = 47;
            this.labelControl5.Text = "kgs a Procesar:";
            // 
            // txt_kilos_estiba
            // 
            this.txt_kilos_estiba.EditValue = "0";
            this.txt_kilos_estiba.Enabled = false;
            this.txt_kilos_estiba.Location = new System.Drawing.Point(119, 58);
            this.txt_kilos_estiba.Name = "txt_kilos_estiba";
            this.txt_kilos_estiba.Properties.BeepOnError = true;
            this.txt_kilos_estiba.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.txt_kilos_estiba.Properties.MaskSettings.Set("MaskManagerSignature", "allowNull=False");
            this.txt_kilos_estiba.Properties.MaskSettings.Set("mask", "n");
            this.txt_kilos_estiba.Properties.MaskSettings.Set("culture", "es-MX");
            this.txt_kilos_estiba.Properties.MaskSettings.Set("valueType", typeof(decimal));
            this.txt_kilos_estiba.Properties.UseMaskAsDisplayFormat = true;
            this.txt_kilos_estiba.Size = new System.Drawing.Size(111, 20);
            this.txt_kilos_estiba.TabIndex = 46;
            // 
            // btn_agregar_palet
            // 
            this.btn_agregar_palet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_agregar_palet.ImageOptions.Image")));
            this.btn_agregar_palet.Location = new System.Drawing.Point(281, 174);
            this.btn_agregar_palet.Name = "btn_agregar_palet";
            this.btn_agregar_palet.Size = new System.Drawing.Size(102, 23);
            this.btn_agregar_palet.TabIndex = 45;
            this.btn_agregar_palet.Text = "Agregar";
            this.btn_agregar_palet.Click += new System.EventHandler(this.btn_agregar_palet_Click);
            // 
            // txt_palet
            // 
            this.txt_palet.Location = new System.Drawing.Point(119, 176);
            this.txt_palet.Name = "txt_palet";
            this.txt_palet.Size = new System.Drawing.Size(126, 20);
            this.txt_palet.TabIndex = 44;
            this.txt_palet.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_palet_KeyDown);
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(31, 180);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(63, 26);
            this.labelControl4.TabIndex = 43;
            this.labelControl4.Text = "Palet / Estiba\r\nReempaque:";
            // 
            // dt_FechaFin
            // 
            this.dt_FechaFin.EditValue = new System.DateTime(2024, 8, 9, 9, 55, 18, 0);
            this.dt_FechaFin.Enabled = false;
            this.dt_FechaFin.Location = new System.Drawing.Point(119, 120);
            this.dt_FechaFin.Name = "dt_FechaFin";
            this.dt_FechaFin.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_FechaFin.Properties.Appearance.Options.UseFont = true;
            this.dt_FechaFin.Properties.BeepOnError = true;
            this.dt_FechaFin.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dt_FechaFin.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dt_FechaFin.Properties.MaskSettings.Set("mask", "f");
            this.dt_FechaFin.Properties.MaskSettings.Set("culture", "es-MX");
            this.dt_FechaFin.Properties.UseMaskAsDisplayFormat = true;
            this.dt_FechaFin.Size = new System.Drawing.Size(301, 22);
            this.dt_FechaFin.TabIndex = 42;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(31, 118);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(63, 26);
            this.labelControl3.TabIndex = 41;
            this.labelControl3.Text = "Fecha y hora \r\nActual:";
            // 
            // dt_FechaInicio
            // 
            this.dt_FechaInicio.EditValue = new System.DateTime(2024, 8, 9, 9, 55, 18, 0);
            this.dt_FechaInicio.Enabled = false;
            this.dt_FechaInicio.Location = new System.Drawing.Point(119, 90);
            this.dt_FechaInicio.Name = "dt_FechaInicio";
            this.dt_FechaInicio.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_FechaInicio.Properties.Appearance.Options.UseFont = true;
            this.dt_FechaInicio.Properties.BeepOnError = true;
            this.dt_FechaInicio.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dt_FechaInicio.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dt_FechaInicio.Properties.MaskSettings.Set("mask", "f");
            this.dt_FechaInicio.Properties.MaskSettings.Set("culture", "es-MX");
            this.dt_FechaInicio.Properties.UseMaskAsDisplayFormat = true;
            this.dt_FechaInicio.Size = new System.Drawing.Size(301, 22);
            this.dt_FechaInicio.TabIndex = 40;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(31, 86);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(63, 26);
            this.labelControl2.TabIndex = 35;
            this.labelControl2.Text = "Fecha y hora \r\nde Inicio:";
            // 
            // btn_cierra_corrida
            // 
            this.btn_cierra_corrida.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_cierra_corrida.ImageOptions.Image")));
            this.btn_cierra_corrida.Location = new System.Drawing.Point(281, 57);
            this.btn_cierra_corrida.Name = "btn_cierra_corrida";
            this.btn_cierra_corrida.Size = new System.Drawing.Size(102, 23);
            this.btn_cierra_corrida.TabIndex = 34;
            this.btn_cierra_corrida.Text = "Cerrar Corrida";
            this.btn_cierra_corrida.Click += new System.EventHandler(this.btn_cierra_corrida_Click);
            // 
            // btn_BuscarEstiba
            // 
            this.btn_BuscarEstiba.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_BuscarEstiba.ImageOptions.Image")));
            this.btn_BuscarEstiba.Location = new System.Drawing.Point(236, 30);
            this.btn_BuscarEstiba.Name = "btn_BuscarEstiba";
            this.btn_BuscarEstiba.Size = new System.Drawing.Size(24, 23);
            this.btn_BuscarEstiba.TabIndex = 33;
            this.btn_BuscarEstiba.Click += new System.EventHandler(this.btn_BuscarEstiba_Click);
            // 
            // txt_estiba
            // 
            this.txt_estiba.EditValue = "";
            this.txt_estiba.Enabled = false;
            this.txt_estiba.Location = new System.Drawing.Point(119, 31);
            this.txt_estiba.Name = "txt_estiba";
            this.txt_estiba.Size = new System.Drawing.Size(111, 20);
            this.txt_estiba.TabIndex = 2;
            this.txt_estiba.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_estiba_KeyDown);
            // 
            // btn_Inicia_corrida
            // 
            this.btn_Inicia_corrida.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Inicia_corrida.ImageOptions.Image")));
            this.btn_Inicia_corrida.Location = new System.Drawing.Point(281, 30);
            this.btn_Inicia_corrida.Name = "btn_Inicia_corrida";
            this.btn_Inicia_corrida.Size = new System.Drawing.Size(102, 23);
            this.btn_Inicia_corrida.TabIndex = 1;
            this.btn_Inicia_corrida.Text = "Iniciar Corrida";
            this.btn_Inicia_corrida.Click += new System.EventHandler(this.btn_Inicia_corrida_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(31, 35);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(79, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Estiba seleccion:";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Frm_Captura_Rendimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 247);
            this.Controls.Add(this.panelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Captura_Rendimiento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Captura Rendimiento";
            this.Load += new System.EventHandler(this.Frm_Captura_Rendimiento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_kilosPalet.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_temporada.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_kilos_estiba.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_palet.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_FechaFin.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_FechaFin.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_FechaInicio.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_FechaInicio.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_estiba.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.TextEdit txt_estiba;
        private DevExpress.XtraEditors.SimpleButton btn_Inicia_corrida;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btn_cierra_corrida;
        private DevExpress.XtraEditors.SimpleButton btn_BuscarEstiba;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.DateEdit dt_FechaInicio;
        private DevExpress.XtraEditors.SimpleButton btn_agregar_palet;
        private DevExpress.XtraEditors.TextEdit txt_palet;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.DateEdit dt_FechaFin;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txt_kilos_estiba;
        private DevExpress.XtraEditors.SeparatorControl separatorControl1;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LookUpEdit cmb_temporada;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit txt_kilosPalet;
        private System.Windows.Forms.Timer timer1;
    }
}