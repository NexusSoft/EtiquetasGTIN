namespace Etiquetas_AGV
{
    partial class Frm_FechaPalet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_FechaPalet));
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txt_Palet = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.dt_FechaEtiqueta = new DevExpress.XtraEditors.DateEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.btn_Guardar = new DevExpress.XtraEditors.SimpleButton();
            this.txt_Temporada = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Palet.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_FechaEtiqueta.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_FechaEtiqueta.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Temporada.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(25, 16);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(54, 13);
            this.labelControl3.TabIndex = 7;
            this.labelControl3.Text = "Temporada";
            // 
            // txt_Palet
            // 
            this.txt_Palet.Enabled = false;
            this.txt_Palet.Location = new System.Drawing.Point(110, 38);
            this.txt_Palet.Name = "txt_Palet";
            this.txt_Palet.Size = new System.Drawing.Size(108, 20);
            this.txt_Palet.TabIndex = 8;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(25, 42);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(24, 13);
            this.labelControl1.TabIndex = 9;
            this.labelControl1.Text = "Palet";
            // 
            // dt_FechaEtiqueta
            // 
            this.dt_FechaEtiqueta.EditValue = null;
            this.dt_FechaEtiqueta.Location = new System.Drawing.Point(110, 65);
            this.dt_FechaEtiqueta.Name = "dt_FechaEtiqueta";
            this.dt_FechaEtiqueta.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dt_FechaEtiqueta.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dt_FechaEtiqueta.Size = new System.Drawing.Size(108, 20);
            this.dt_FechaEtiqueta.TabIndex = 10;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(25, 68);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(72, 13);
            this.labelControl2.TabIndex = 11;
            this.labelControl2.Text = "Fecha Etiqueta";
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSICFI.ImageOptions.Image")));
            this.btn_Guardar.Location = new System.Drawing.Point(110, 93);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(107, 42);
            this.btn_Guardar.TabIndex = 15;
            this.btn_Guardar.Text = "Guardar";
            this.btn_Guardar.Click += new System.EventHandler(this.btn_Guardar_Click);
            // 
            // txt_Temporada
            // 
            this.txt_Temporada.Enabled = false;
            this.txt_Temporada.Location = new System.Drawing.Point(110, 12);
            this.txt_Temporada.Name = "txt_Temporada";
            this.txt_Temporada.Size = new System.Drawing.Size(108, 20);
            this.txt_Temporada.TabIndex = 16;
            // 
            // Frm_FechaPalet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 176);
            this.Controls.Add(this.txt_Temporada);
            this.Controls.Add(this.btn_Guardar);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.dt_FechaEtiqueta);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txt_Palet);
            this.Controls.Add(this.labelControl3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_FechaPalet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cambio Fecha Etiqueta";
            this.Shown += new System.EventHandler(this.Frm_FechaPalet_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.txt_Palet.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_FechaEtiqueta.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_FechaEtiqueta.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Temporada.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txt_Palet;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.DateEdit dt_FechaEtiqueta;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton btn_Guardar;
        private DevExpress.XtraEditors.TextEdit txt_Temporada;
    }
}