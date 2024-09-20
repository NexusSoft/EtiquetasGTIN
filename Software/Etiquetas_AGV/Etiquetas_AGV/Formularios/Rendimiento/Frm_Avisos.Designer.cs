namespace Etiquetas_AGV.Formularios.Rendimiento
{
    partial class Frm_Avisos
    {
        private System.ComponentModel.IContainer components = null;
        private DevExpress.XtraEditors.SimpleButton btn_Guadar_Imagen;
        private DevExpress.XtraEditors.SimpleButton btn_Eliminar_Imagen;
        private System.Windows.Forms.ImageList imageList1;
        private DevExpress.XtraEditors.ImageListBoxControl Lista_imagenes;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton btn_Guadar_Carrusel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Avisos));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.Lista_imagenes = new DevExpress.XtraEditors.ImageListBoxControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.btn_Guadar_Carrusel = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Eliminar_Imagen = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Guadar_Imagen = new DevExpress.XtraEditors.SimpleButton();
            this.text_Aparecer = new DevExpress.XtraEditors.TextEdit();
            this.text_Desaparecer = new DevExpress.XtraEditors.TextEdit();
            this.Lista_imagenes.DoubleClick += new System.EventHandler(this.Lista_imagenes_DoubleClick);
            ((System.ComponentModel.ISupportInitialize)(this.Lista_imagenes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.text_Aparecer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.text_Desaparecer.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(64, 64);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // Lista_imagenes
            // 
            this.Lista_imagenes.DisplayMember = "Description";
            this.Lista_imagenes.ImageList = this.imageList1;
            this.Lista_imagenes.Location = new System.Drawing.Point(12, 12);
            this.Lista_imagenes.MultiColumn = true;
            this.Lista_imagenes.Name = "Lista_imagenes";
            this.Lista_imagenes.Size = new System.Drawing.Size(1058, 352);
            this.Lista_imagenes.TabIndex = 13;
            this.Lista_imagenes.ValueMember = "Value";
            
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(462, 403);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(110, 13);
            this.labelControl1.TabIndex = 10;
            this.labelControl1.Text = "Retardo Aparecer(min)";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(584, 403);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(128, 13);
            this.labelControl2.TabIndex = 11;
            this.labelControl2.Text = "Retardo Desaparecer(seg)";
            // 
            // btn_Guadar_Carrusel
            // 
            this.btn_Guadar_Carrusel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Guadar_Carrusel.ImageOptions.Image")));
            this.btn_Guadar_Carrusel.Location = new System.Drawing.Point(782, 401);
            this.btn_Guadar_Carrusel.Name = "btn_Guadar_Carrusel";
            this.btn_Guadar_Carrusel.Size = new System.Drawing.Size(166, 41);
            this.btn_Guadar_Carrusel.TabIndex = 12;
            this.btn_Guadar_Carrusel.Text = "Guardar";
            this.btn_Guadar_Carrusel.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // btn_Eliminar_Imagen
            // 
            this.btn_Eliminar_Imagen.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Eliminar_Imagen.ImageOptions.Image")));
            this.btn_Eliminar_Imagen.Location = new System.Drawing.Point(200, 405);
            this.btn_Eliminar_Imagen.Name = "btn_Eliminar_Imagen";
            this.btn_Eliminar_Imagen.Size = new System.Drawing.Size(128, 37);
            this.btn_Eliminar_Imagen.TabIndex = 6;
            this.btn_Eliminar_Imagen.Text = "Eliminar imagen";
            this.btn_Eliminar_Imagen.Click += new System.EventHandler(this.btn_Eliminar_Imagen_Click);
            // 
            // btn_Guadar_Imagen
            // 
            this.btn_Guadar_Imagen.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Guadar_Imagen.ImageOptions.Image")));
            this.btn_Guadar_Imagen.Location = new System.Drawing.Point(45, 405);
            this.btn_Guadar_Imagen.Name = "btn_Guadar_Imagen";
            this.btn_Guadar_Imagen.Size = new System.Drawing.Size(119, 37);
            this.btn_Guadar_Imagen.TabIndex = 4;
            this.btn_Guadar_Imagen.Text = "Guardar imagen";
            this.btn_Guadar_Imagen.Click += new System.EventHandler(this.btn_Guadar_Imagen_Click);
            // 
            // text_Aparecer
            // 
            this.text_Aparecer.EditValue = "5";
            this.text_Aparecer.Location = new System.Drawing.Point(468, 422);
            this.text_Aparecer.Name = "text_Aparecer";
            this.text_Aparecer.Size = new System.Drawing.Size(98, 20);
            this.text_Aparecer.TabIndex = 14;
            this.text_Aparecer.Tag = "";
            // 
            // text_Desaparecer
            // 
            this.text_Desaparecer.EditValue = "10";
            this.text_Desaparecer.Location = new System.Drawing.Point(600, 422);
            this.text_Desaparecer.Name = "text_Desaparecer";
            this.text_Desaparecer.Size = new System.Drawing.Size(96, 20);
            this.text_Desaparecer.TabIndex = 15;
            // 
            // Frm_Avisos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1082, 488);
            this.Controls.Add(this.text_Desaparecer);
            this.Controls.Add(this.text_Aparecer);
            this.Controls.Add(this.btn_Guadar_Carrusel);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.Lista_imagenes);
            this.Controls.Add(this.btn_Eliminar_Imagen);
            this.Controls.Add(this.btn_Guadar_Imagen);
            this.Name = "Frm_Avisos";
            this.Text = "Frm_Avisos";
            ((System.ComponentModel.ISupportInitialize)(this.Lista_imagenes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.text_Aparecer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.text_Desaparecer.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private DevExpress.XtraEditors.TextEdit text_Aparecer;
        private DevExpress.XtraEditors.TextEdit text_Desaparecer;
    }
}