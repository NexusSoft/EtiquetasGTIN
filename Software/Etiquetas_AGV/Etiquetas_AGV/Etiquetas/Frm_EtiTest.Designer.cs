namespace Etiquetas_AGV.Etiquetas
{
    partial class Frm_EtiTest
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
            this.barcodeControl1 = new TECIT.TBarCode.Windows.BarcodeControl();
            this.SuspendLayout();
            // 
            // barcodeControl1
            // 
            this.barcodeControl1.Barcode.BarcodeType = TECIT.TBarCode.BarcodeType.UpcA;
            this.barcodeControl1.Barcode.CharacterSpacing = 1D;
            this.barcodeControl1.Barcode.CheckdigitMethod = TECIT.TBarCode.CheckdigitMethod.UpcA;
            this.barcodeControl1.Barcode.Data = "07989312156";
            this.barcodeControl1.Barcode.Dpi = -1D;
            this.barcodeControl1.Barcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barcodeControl1.Barcode.FontHeight = 9;
            this.barcodeControl1.Barcode.FontName = "Microsoft Sans Serif";
            this.barcodeControl1.Barcode.LicenseCount = 1;
            this.barcodeControl1.Barcode.LicensedProduct = TECIT.TBarCode.TBarCodeProduct.Barcode2D;
            this.barcodeControl1.Barcode.Licensee = "Mem: San Tadeo y Socios S.A. de R.L, MX-60090";
            this.barcodeControl1.Barcode.LicenseType = TECIT.TBarCode.LicenseType.DeveloperOrWeb;
            this.barcodeControl1.Barcode.ModuleWidth = -1D;
            this.barcodeControl1.Barcode.QuietZones.Bottom.Size = 0D;
            this.barcodeControl1.Barcode.QuietZones.Left.Size = 0D;
            this.barcodeControl1.Barcode.QuietZones.Right.Size = 0D;
            this.barcodeControl1.Barcode.QuietZones.Top.Size = 0D;
            this.barcodeControl1.Barcode.TextClipping = false;
            this.barcodeControl1.Barcode.TextDistance = 1F;
            this.barcodeControl1.Barcode.WordWrapping = false;
            this.barcodeControl1.Location = new System.Drawing.Point(45, 38);
            this.barcodeControl1.Name = "barcodeControl1";
            this.barcodeControl1.Size = new System.Drawing.Size(144, 61);
            this.barcodeControl1.TabIndex = 0;
            // 
            // Frm_EtiTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 268);
            this.Controls.Add(this.barcodeControl1);
            this.Name = "Frm_EtiTest";
            this.Text = "Frm_EtiTest";
            this.ResumeLayout(false);

        }

        #endregion

        private TECIT.TBarCode.Windows.BarcodeControl barcodeControl1;
    }
}