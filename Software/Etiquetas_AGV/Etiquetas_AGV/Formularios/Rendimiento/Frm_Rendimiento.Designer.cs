namespace Etiquetas_AGV
{
    partial class Frm_Rendimiento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Rendimiento));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnEmpleados = new DevExpress.XtraBars.BarButtonItem();
            this.btnPuestos = new DevExpress.XtraBars.BarButtonItem();
            this.btnEtiquetas = new DevExpress.XtraBars.BarButtonItem();
            this.btnRendimientoDia = new DevExpress.XtraBars.BarButtonItem();
            this.btnEmpleadoBono = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.SkinForm = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.applicationMenu1 = new DevExpress.XtraBars.Ribbon.ApplicationMenu(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.applicationMenu1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.EmptyAreaImageOptions.ImagePadding = new System.Windows.Forms.Padding(26, 24, 26, 24);
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.btnEmpleados,
            this.btnPuestos,
            this.btnEtiquetas,
            this.btnRendimientoDia,
            this.btnEmpleadoBono});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ribbon.MaxItemId = 6;
            this.ribbon.Name = "ribbon";
            this.ribbon.OptionsMenuMinWidth = 283;
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbon.Size = new System.Drawing.Size(972, 147);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // btnEmpleados
            // 
            this.btnEmpleados.Caption = "Empleados";
            this.btnEmpleados.Id = 1;
            this.btnEmpleados.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnEmpleados.ImageOptions.Image")));
            this.btnEmpleados.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnEmpleados.ImageOptions.LargeImage")));
            this.btnEmpleados.Name = "btnEmpleados";
            this.btnEmpleados.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnEmpleados_ItemClick);
            // 
            // btnPuestos
            // 
            this.btnPuestos.Caption = "Puestos";
            this.btnPuestos.Id = 2;
            this.btnPuestos.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPuestos.ImageOptions.Image")));
            this.btnPuestos.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnPuestos.ImageOptions.LargeImage")));
            this.btnPuestos.Name = "btnPuestos";
            this.btnPuestos.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPuestos_ItemClick);
            // 
            // btnEtiquetas
            // 
            this.btnEtiquetas.Caption = "Etiquetas";
            this.btnEtiquetas.Id = 3;
            this.btnEtiquetas.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnEtiquetas.ImageOptions.Image")));
            this.btnEtiquetas.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnEtiquetas.ImageOptions.LargeImage")));
            this.btnEtiquetas.Name = "btnEtiquetas";
            this.btnEtiquetas.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnEtiquetas_ItemClick);
            // 
            // btnRendimientoDia
            // 
            this.btnRendimientoDia.Caption = "Rendimiento del dia";
            this.btnRendimientoDia.Id = 4;
            this.btnRendimientoDia.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnRendimientoDia.ImageOptions.Image")));
            this.btnRendimientoDia.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnRendimientoDia.ImageOptions.LargeImage")));
            this.btnRendimientoDia.Name = "btnRendimientoDia";
            this.btnRendimientoDia.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnRendimientoDia_ItemClick);
            // 
            // btnEmpleadoBono
            // 
            this.btnEmpleadoBono.Caption = "Personal Bono";
            this.btnEmpleadoBono.Id = 5;
            this.btnEmpleadoBono.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image")));
            this.btnEmpleadoBono.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.LargeImage")));
            this.btnEmpleadoBono.Name = "btnEmpleadoBono";
            this.btnEmpleadoBono.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnEmpleadoBono_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Rendimiento";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnEmpleados);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnPuestos);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnEtiquetas);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Catalogos";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btnRendimientoDia);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnEmpleadoBono);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Monitor";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 453);
            this.ribbonStatusBar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(972, 23);
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.ClosePageButtonShowMode = DevExpress.XtraTab.ClosePageButtonShowMode.InAllTabPageHeaders;
            this.xtraTabbedMdiManager1.MdiParent = null;
            // 
            // SkinForm
            // 
            this.SkinForm.EnableBonusSkins = true;
            this.SkinForm.LookAndFeel.SkinName = "Office 2013 Light Gray";
            // 
            // applicationMenu1
            // 
            this.applicationMenu1.Name = "applicationMenu1";
            this.applicationMenu1.Ribbon = this.ribbon;
            // 
            // Frm_Rendimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 476);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Frm_Rendimiento";
            this.Ribbon = this.ribbon;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Rendimiento";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Frm_Rendimiento_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.applicationMenu1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem btnEmpleados;
        private DevExpress.XtraBars.BarButtonItem btnPuestos;
        private DevExpress.XtraBars.BarButtonItem btnEtiquetas;
        private DevExpress.XtraBars.BarButtonItem btnRendimientoDia;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private DevExpress.LookAndFeel.DefaultLookAndFeel SkinForm;
        private DevExpress.XtraBars.Ribbon.ApplicationMenu applicationMenu1;
        private DevExpress.XtraBars.BarButtonItem btnEmpleadoBono;
    }
}