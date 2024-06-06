namespace Etiquetas_AGV
{
    partial class Frm_Eti_Empleados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Eti_Empleados));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.textId = new DevExpress.XtraEditors.TextEdit();
            this.btnbuscar = new DevExpress.XtraEditors.SimpleButton();
            this.textNombre = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.spinEdit1 = new DevExpress.XtraEditors.SpinEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.btnImprimir = new DevExpress.XtraEditors.SimpleButton();
            this.rdgTipoImpresion = new DevExpress.XtraEditors.RadioGroup();
            ((System.ComponentModel.ISupportInitialize)(this.textId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textNombre.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdgTipoImpresion.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(20, 16);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(50, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Empleado:";
            // 
            // textId
            // 
            this.textId.Enabled = false;
            this.textId.Location = new System.Drawing.Point(79, 12);
            this.textId.Name = "textId";
            this.textId.Size = new System.Drawing.Size(100, 20);
            this.textId.TabIndex = 1;
            // 
            // btnbuscar
            // 
            this.btnbuscar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnbuscar.ImageOptions.Image")));
            this.btnbuscar.Location = new System.Drawing.Point(185, 11);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(24, 23);
            this.btnbuscar.TabIndex = 10;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // textNombre
            // 
            this.textNombre.Enabled = false;
            this.textNombre.Location = new System.Drawing.Point(79, 38);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(245, 20);
            this.textNombre.TabIndex = 9;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(20, 42);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(41, 13);
            this.labelControl2.TabIndex = 11;
            this.labelControl2.Text = "Nombre:";
            // 
            // spinEdit1
            // 
            this.spinEdit1.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spinEdit1.Location = new System.Drawing.Point(79, 64);
            this.spinEdit1.Name = "spinEdit1";
            this.spinEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinEdit1.Properties.MaxValue = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.spinEdit1.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spinEdit1.Size = new System.Drawing.Size(72, 20);
            this.spinEdit1.TabIndex = 12;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(20, 68);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(47, 13);
            this.labelControl3.TabIndex = 13;
            this.labelControl3.Text = "Cantidad:";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Appearance.Options.UseForeColor = true;
            this.labelControl4.Location = new System.Drawing.Point(162, 68);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(218, 14);
            this.labelControl4.TabIndex = 14;
            this.labelControl4.Text = "Las etiquetas se imprimira 3 al paso";
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(411, 35);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(93, 45);
            this.btnImprimir.TabIndex = 16;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // rdgTipoImpresion
            // 
            this.rdgTipoImpresion.Location = new System.Drawing.Point(20, 90);
            this.rdgTipoImpresion.Name = "rdgTipoImpresion";
            this.rdgTipoImpresion.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.rdgTipoImpresion.Properties.Appearance.Options.UseBackColor = true;
            this.rdgTipoImpresion.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.rdgTipoImpresion.Properties.Columns = 2;
            this.rdgTipoImpresion.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Impresion Directa"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Vista Previa")});
            this.rdgTipoImpresion.Size = new System.Drawing.Size(238, 35);
            this.rdgTipoImpresion.TabIndex = 17;
            // 
            // Frm_Eti_Empleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 127);
            this.Controls.Add(this.rdgTipoImpresion);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.spinEdit1);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.textNombre);
            this.Controls.Add(this.textId);
            this.Controls.Add(this.labelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Eti_Empleados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Etiquetas Empleados";
            this.Load += new System.EventHandler(this.Frm_Eti_Empleados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.textId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textNombre.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdgTipoImpresion.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit textId;
        private DevExpress.XtraEditors.SimpleButton btnbuscar;
        private DevExpress.XtraEditors.TextEdit textNombre;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SpinEdit spinEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.SimpleButton btnImprimir;
        private DevExpress.XtraEditors.RadioGroup rdgTipoImpresion;
    }
}