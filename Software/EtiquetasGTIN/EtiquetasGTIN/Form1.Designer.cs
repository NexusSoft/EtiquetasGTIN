namespace EtiquetasGTIN
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtGTIN = new DevExpress.XtraEditors.TextEdit();
            this.txtLote = new DevExpress.XtraEditors.TextEdit();
            this.dtFecha = new DevExpress.XtraEditors.DateEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.btnGenera = new DevExpress.XtraEditors.SimpleButton();
            this.lblPick2 = new DevExpress.XtraEditors.LabelControl();
            this.lblPick1 = new DevExpress.XtraEditors.LabelControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLimpiar = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtGTIN.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLote.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFecha.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFecha.Properties)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtGTIN
            // 
            this.txtGTIN.Location = new System.Drawing.Point(72, 19);
            this.txtGTIN.Name = "txtGTIN";
            this.txtGTIN.Size = new System.Drawing.Size(191, 20);
            this.txtGTIN.TabIndex = 1;
            // 
            // txtLote
            // 
            this.txtLote.Location = new System.Drawing.Point(72, 45);
            this.txtLote.Name = "txtLote";
            this.txtLote.Size = new System.Drawing.Size(191, 20);
            this.txtLote.TabIndex = 2;
            // 
            // dtFecha
            // 
            this.dtFecha.EditValue = null;
            this.dtFecha.Location = new System.Drawing.Point(72, 72);
            this.dtFecha.Name = "dtFecha";
            this.dtFecha.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtFecha.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtFecha.Size = new System.Drawing.Size(100, 20);
            this.dtFecha.TabIndex = 3;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(31, 23);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(24, 13);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "GTIN";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(34, 49);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(21, 13);
            this.labelControl2.TabIndex = 5;
            this.labelControl2.Text = "Lote";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(26, 76);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(29, 13);
            this.labelControl3.TabIndex = 6;
            this.labelControl3.Text = "Fecha";
            // 
            // btnGenera
            // 
            this.btnGenera.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.btnGenera.Location = new System.Drawing.Point(72, 112);
            this.btnGenera.Name = "btnGenera";
            this.btnGenera.Size = new System.Drawing.Size(100, 37);
            this.btnGenera.TabIndex = 7;
            this.btnGenera.Text = "Generar \r\nVoice Pick";
            this.btnGenera.Click += new System.EventHandler(this.btnGenera_Click);
            // 
            // lblPick2
            // 
            this.lblPick2.Appearance.Font = new System.Drawing.Font("Tahoma", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPick2.Appearance.ForeColor = System.Drawing.Color.White;
            this.lblPick2.Appearance.Options.UseFont = true;
            this.lblPick2.Appearance.Options.UseForeColor = true;
            this.lblPick2.Location = new System.Drawing.Point(56, 15);
            this.lblPick2.Name = "lblPick2";
            this.lblPick2.Size = new System.Drawing.Size(62, 58);
            this.lblPick2.TabIndex = 9;
            this.lblPick2.Text = "99";
            // 
            // lblPick1
            // 
            this.lblPick1.Appearance.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPick1.Appearance.ForeColor = System.Drawing.Color.White;
            this.lblPick1.Appearance.Options.UseFont = true;
            this.lblPick1.Appearance.Options.UseForeColor = true;
            this.lblPick1.Location = new System.Drawing.Point(14, 33);
            this.lblPick1.Name = "lblPick1";
            this.lblPick1.Size = new System.Drawing.Size(30, 29);
            this.lblPick1.TabIndex = 8;
            this.lblPick1.Text = "25";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.lblPick1);
            this.panel1.Controls.Add(this.lblPick2);
            this.panel1.Location = new System.Drawing.Point(301, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(127, 86);
            this.panel1.TabIndex = 10;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.btnLimpiar.Location = new System.Drawing.Point(178, 112);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(100, 37);
            this.btnLimpiar.TabIndex = 11;
            this.btnLimpiar.Text = "Limpiar \r\nCampos";
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 184);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnGenera);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.dtFecha);
            this.Controls.Add(this.txtLote);
            this.Controls.Add(this.txtGTIN);
            this.Name = "Form1";
            this.Text = "Voice Pick";
            this.Shown += new System.EventHandler(this.Form1_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.txtGTIN.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLote.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFecha.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFecha.Properties)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.TextEdit txtGTIN;
        private DevExpress.XtraEditors.TextEdit txtLote;
        private DevExpress.XtraEditors.DateEdit dtFecha;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SimpleButton btnGenera;
        private DevExpress.XtraEditors.LabelControl lblPick2;
        private DevExpress.XtraEditors.LabelControl lblPick1;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton btnLimpiar;
    }
}

