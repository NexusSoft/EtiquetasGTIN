namespace Etiquetas_AGV.Formularios.Rendimiento
{
    partial class Frm_Rendimiento_General
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Rendimiento_General));
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btn_Actualizar = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.txt_KilosBono = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.dt_FechaFin = new DevExpress.XtraEditors.DateEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.dt_FechaInicio = new DevExpress.XtraEditors.DateEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.lbl_estibakilos = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.lbl_estiba = new DevExpress.XtraEditors.LabelControl();
            this.lbl_kilosmeta = new DevExpress.XtraEditors.LabelControl();
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            this.lbl_kilosProcesados = new DevExpress.XtraEditors.LabelControl();
            this.bar_avance = new DevExpress.XtraEditors.ProgressBarControl();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.dtgKilosAcumulados = new DevExpress.XtraGrid.GridControl();
            this.dtgValKilosAcumulados = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_KilosBono.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_FechaFin.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_FechaFin.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_FechaInicio.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_FechaInicio.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bar_avance.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgKilosAcumulados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgValKilosAcumulados)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btn_Actualizar);
            this.panelControl1.Controls.Add(this.labelControl9);
            this.panelControl1.Controls.Add(this.txt_KilosBono);
            this.panelControl1.Controls.Add(this.labelControl6);
            this.panelControl1.Controls.Add(this.dt_FechaFin);
            this.panelControl1.Controls.Add(this.labelControl5);
            this.panelControl1.Controls.Add(this.dt_FechaInicio);
            this.panelControl1.Controls.Add(this.labelControl3);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1286, 104);
            this.panelControl1.TabIndex = 26;
            // 
            // btn_Actualizar
            // 
            this.btn_Actualizar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Actualizar.ImageOptions.Image")));
            this.btn_Actualizar.Location = new System.Drawing.Point(829, 9);
            this.btn_Actualizar.Name = "btn_Actualizar";
            this.btn_Actualizar.Size = new System.Drawing.Size(113, 40);
            this.btn_Actualizar.TabIndex = 45;
            this.btn_Actualizar.Text = "Actualizar";
            this.btn_Actualizar.Click += new System.EventHandler(this.btn_Actualizar_Click);
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(18, 57);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(223, 25);
            this.labelControl9.TabIndex = 44;
            this.labelControl9.Text = "Ultima Actualizacion:";
            // 
            // txt_KilosBono
            // 
            this.txt_KilosBono.Location = new System.Drawing.Point(672, 16);
            this.txt_KilosBono.Name = "txt_KilosBono";
            this.txt_KilosBono.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_KilosBono.Properties.Appearance.ForeColor = System.Drawing.Color.OliveDrab;
            this.txt_KilosBono.Properties.Appearance.Options.UseFont = true;
            this.txt_KilosBono.Properties.Appearance.Options.UseForeColor = true;
            this.txt_KilosBono.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.txt_KilosBono.Properties.MaskSettings.Set("mask", "n");
            this.txt_KilosBono.Size = new System.Drawing.Size(137, 26);
            this.txt_KilosBono.TabIndex = 43;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(467, 17);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(187, 25);
            this.labelControl6.TabIndex = 42;
            this.labelControl6.Text = "Kilos Diario Bono:";
            // 
            // dt_FechaFin
            // 
            this.dt_FechaFin.EditValue = null;
            this.dt_FechaFin.Location = new System.Drawing.Point(314, 18);
            this.dt_FechaFin.Name = "dt_FechaFin";
            this.dt_FechaFin.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_FechaFin.Properties.Appearance.Options.UseFont = true;
            this.dt_FechaFin.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dt_FechaFin.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dt_FechaFin.Size = new System.Drawing.Size(108, 22);
            this.dt_FechaFin.TabIndex = 41;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(261, 17);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(28, 25);
            this.labelControl5.TabIndex = 40;
            this.labelControl5.Text = "Al:";
            // 
            // dt_FechaInicio
            // 
            this.dt_FechaInicio.EditValue = null;
            this.dt_FechaInicio.Location = new System.Drawing.Point(124, 18);
            this.dt_FechaInicio.Name = "dt_FechaInicio";
            this.dt_FechaInicio.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_FechaInicio.Properties.Appearance.Options.UseFont = true;
            this.dt_FechaInicio.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dt_FechaInicio.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dt_FechaInicio.Size = new System.Drawing.Size(108, 22);
            this.dt_FechaInicio.TabIndex = 39;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(18, 17);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(88, 25);
            this.labelControl3.TabIndex = 38;
            this.labelControl3.Text = "Periodo:";
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.lbl_estibakilos);
            this.panelControl2.Controls.Add(this.labelControl8);
            this.panelControl2.Controls.Add(this.labelControl4);
            this.panelControl2.Controls.Add(this.lbl_estiba);
            this.panelControl2.Controls.Add(this.lbl_kilosmeta);
            this.panelControl2.Controls.Add(this.labelControl13);
            this.panelControl2.Controls.Add(this.lbl_kilosProcesados);
            this.panelControl2.Controls.Add(this.bar_avance);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelControl2.Location = new System.Drawing.Point(0, 104);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(766, 437);
            this.panelControl2.TabIndex = 27;
            // 
            // lbl_estibakilos
            // 
            this.lbl_estibakilos.Appearance.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_estibakilos.Appearance.ForeColor = System.Drawing.Color.SteelBlue;
            this.lbl_estibakilos.Appearance.Options.UseFont = true;
            this.lbl_estibakilos.Appearance.Options.UseForeColor = true;
            this.lbl_estibakilos.Location = new System.Drawing.Point(285, 245);
            this.lbl_estibakilos.Name = "lbl_estibakilos";
            this.lbl_estibakilos.Size = new System.Drawing.Size(78, 39);
            this.lbl_estibakilos.TabIndex = 35;
            this.lbl_estibakilos.Text = "75%";
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(59, 245);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(197, 39);
            this.labelControl8.TabIndex = 34;
            this.labelControl8.Text = "Estiba Kilos:";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(168, 18);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(449, 45);
            this.labelControl4.TabIndex = 33;
            this.labelControl4.Text = "Kilos empacados del Dia";
            // 
            // lbl_estiba
            // 
            this.lbl_estiba.Appearance.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_estiba.Appearance.ForeColor = System.Drawing.Color.SteelBlue;
            this.lbl_estiba.Appearance.Options.UseFont = true;
            this.lbl_estiba.Appearance.Options.UseForeColor = true;
            this.lbl_estiba.Location = new System.Drawing.Point(285, 198);
            this.lbl_estiba.Name = "lbl_estiba";
            this.lbl_estiba.Size = new System.Drawing.Size(78, 39);
            this.lbl_estiba.TabIndex = 32;
            this.lbl_estiba.Text = "75%";
            // 
            // lbl_kilosmeta
            // 
            this.lbl_kilosmeta.Appearance.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_kilosmeta.Appearance.ForeColor = System.Drawing.Color.SteelBlue;
            this.lbl_kilosmeta.Appearance.Options.UseFont = true;
            this.lbl_kilosmeta.Appearance.Options.UseForeColor = true;
            this.lbl_kilosmeta.Location = new System.Drawing.Point(600, 134);
            this.lbl_kilosmeta.Name = "lbl_kilosmeta";
            this.lbl_kilosmeta.Size = new System.Drawing.Size(78, 39);
            this.lbl_kilosmeta.TabIndex = 31;
            this.lbl_kilosmeta.Text = "75%";
            // 
            // labelControl13
            // 
            this.labelControl13.Appearance.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl13.Appearance.Options.UseFont = true;
            this.labelControl13.Location = new System.Drawing.Point(59, 198);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(220, 39);
            this.labelControl13.TabIndex = 30;
            this.labelControl13.Text = "Estiba Actual:";
            // 
            // lbl_kilosProcesados
            // 
            this.lbl_kilosProcesados.Appearance.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_kilosProcesados.Appearance.Options.UseFont = true;
            this.lbl_kilosProcesados.Location = new System.Drawing.Point(59, 96);
            this.lbl_kilosProcesados.Name = "lbl_kilosProcesados";
            this.lbl_kilosProcesados.Size = new System.Drawing.Size(239, 33);
            this.lbl_kilosProcesados.TabIndex = 29;
            this.lbl_kilosProcesados.Text = "Kilos Procesados:";
            // 
            // bar_avance
            // 
            this.bar_avance.EditValue = 75;
            this.bar_avance.Location = new System.Drawing.Point(59, 135);
            this.bar_avance.Name = "bar_avance";
            this.bar_avance.Properties.Appearance.ForeColor = System.Drawing.Color.Gray;
            this.bar_avance.Properties.ShowTitle = true;
            this.bar_avance.Size = new System.Drawing.Size(518, 37);
            this.bar_avance.TabIndex = 0;
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.labelControl2);
            this.panelControl3.Controls.Add(this.dtgKilosAcumulados);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelControl3.Location = new System.Drawing.Point(766, 104);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Padding = new System.Windows.Forms.Padding(10, 30, 10, 10);
            this.panelControl3.Size = new System.Drawing.Size(561, 437);
            this.panelControl3.TabIndex = 28;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(243, 4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(184, 25);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Kilos Acumulados";
            // 
            // dtgKilosAcumulados
            // 
            this.dtgKilosAcumulados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgKilosAcumulados.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgKilosAcumulados.Location = new System.Drawing.Point(12, 32);
            this.dtgKilosAcumulados.MainView = this.dtgValKilosAcumulados;
            this.dtgKilosAcumulados.Name = "dtgKilosAcumulados";
            this.dtgKilosAcumulados.Size = new System.Drawing.Size(537, 393);
            this.dtgKilosAcumulados.TabIndex = 1;
            this.dtgKilosAcumulados.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dtgValKilosAcumulados});
            // 
            // dtgValKilosAcumulados
            // 
            this.dtgValKilosAcumulados.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgValKilosAcumulados.Appearance.HeaderPanel.Options.UseFont = true;
            this.dtgValKilosAcumulados.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgValKilosAcumulados.Appearance.Row.Options.UseFont = true;
            this.dtgValKilosAcumulados.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6});
            this.dtgValKilosAcumulados.GridControl = this.dtgKilosAcumulados;
            this.dtgValKilosAcumulados.Name = "dtgValKilosAcumulados";
            this.dtgValKilosAcumulados.OptionsView.ShowGroupPanel = false;
            this.dtgValKilosAcumulados.RowStyle += new DevExpress.XtraGrid.Views.Grid.RowStyleEventHandler(this.dtgValKilosAcumulados_RowStyle);
            // 
            // gridColumn4
            // 
            this.gridColumn4.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumn4.AppearanceCell.Options.UseFont = true;
            this.gridColumn4.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumn4.AppearanceHeader.Options.UseFont = true;
            this.gridColumn4.Caption = "Fecha";
            this.gridColumn4.FieldName = "Fecha";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.OptionsColumn.AllowEdit = false;
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 1;
            this.gridColumn4.Width = 187;
            // 
            // gridColumn5
            // 
            this.gridColumn5.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumn5.AppearanceCell.Options.UseFont = true;
            this.gridColumn5.Caption = "Dia Semana";
            this.gridColumn5.FieldName = "Dia";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.OptionsColumn.AllowEdit = false;
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 0;
            this.gridColumn5.Width = 153;
            // 
            // gridColumn6
            // 
            this.gridColumn6.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridColumn6.AppearanceCell.Options.UseFont = true;
            this.gridColumn6.Caption = "Kilos";
            this.gridColumn6.FieldName = "kilos";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.OptionsColumn.AllowEdit = false;
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 2;
            this.gridColumn6.Width = 176;
            // 
            // timer1
            // 
            this.timer1.Interval = 300000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Frm_Rendimiento_General
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1286, 541);
            this.Controls.Add(this.panelControl3);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Name = "Frm_Rendimiento_General";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Shown += new System.EventHandler(this.Frm_Rendimiento_General_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_KilosBono.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_FechaFin.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_FechaFin.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_FechaInicio.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_FechaInicio.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bar_avance.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            this.panelControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgKilosAcumulados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgValKilosAcumulados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.ProgressBarControl bar_avance;
        private DevExpress.XtraEditors.LabelControl labelControl13;
        private DevExpress.XtraEditors.LabelControl lbl_kilosProcesados;
        private DevExpress.XtraEditors.LabelControl lbl_estiba;
        private DevExpress.XtraEditors.LabelControl lbl_kilosmeta;
        private DevExpress.XtraEditors.DateEdit dt_FechaFin;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.DateEdit dt_FechaInicio;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txt_KilosBono;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraGrid.GridControl dtgKilosAcumulados;
        private DevExpress.XtraGrid.Views.Grid.GridView dtgValKilosAcumulados;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl lbl_estibakilos;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.SimpleButton btn_Actualizar;
        private System.Windows.Forms.Timer timer1;
    }
}