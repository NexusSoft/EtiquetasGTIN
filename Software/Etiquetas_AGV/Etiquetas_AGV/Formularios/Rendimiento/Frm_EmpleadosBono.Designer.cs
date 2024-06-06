namespace Etiquetas_AGV
{
    partial class Frm_EmpleadosBono
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_EmpleadosBono));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bIconos = new DevExpress.XtraBars.Bar();
            this.btnLimpiar = new DevExpress.XtraBars.BarLargeButtonItem();
            this.btnGuardar = new DevExpress.XtraBars.BarLargeButtonItem();
            this.btnEliminar = new DevExpress.XtraBars.BarLargeButtonItem();
            this.btnSalir = new DevExpress.XtraBars.BarLargeButtonItem();
            this.btnSeleccionar = new DevExpress.XtraBars.BarLargeButtonItem();
            this.bEstado = new DevExpress.XtraBars.Bar();
            this.lblProveedor = new DevExpress.XtraBars.BarStaticItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.cboInsidencias = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.dtFecha = new DevExpress.XtraEditors.DateEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.btnbuscar = new DevExpress.XtraEditors.SimpleButton();
            this.textNombre = new DevExpress.XtraEditors.TextEdit();
            this.textId = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.dt_FechaFin = new DevExpress.XtraEditors.DateEdit();
            this.dt_FechaInicio = new DevExpress.XtraEditors.DateEdit();
            this.dtgEmpleadosBono = new DevExpress.XtraGrid.GridControl();
            this.dtgValEmpleadosBono = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboInsidencias.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFecha.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFecha.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textNombre.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dt_FechaFin.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_FechaFin.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_FechaInicio.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_FechaInicio.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgEmpleadosBono)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgValEmpleadosBono)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bIconos,
            this.bEstado});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.lblProveedor,
            this.btnLimpiar,
            this.btnGuardar,
            this.btnEliminar,
            this.btnSalir,
            this.btnSeleccionar});
            this.barManager1.MainMenu = this.bIconos;
            this.barManager1.MaxItemId = 68;
            this.barManager1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEdit1});
            this.barManager1.StatusBar = this.bEstado;
            // 
            // bIconos
            // 
            this.bIconos.BarName = "Menú principal";
            this.bIconos.DockCol = 0;
            this.bIconos.DockRow = 0;
            this.bIconos.DockStyle = DevExpress.XtraBars.BarDockStyle.Left;
            this.bIconos.FloatLocation = new System.Drawing.Point(42, 184);
            this.bIconos.FloatSize = new System.Drawing.Size(1106, 535);
            this.bIconos.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnLimpiar),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnGuardar),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnEliminar),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnSalir)});
            this.bIconos.OptionsBar.AllowCollapse = true;
            this.bIconos.OptionsBar.AllowQuickCustomization = false;
            this.bIconos.OptionsBar.AutoPopupMode = DevExpress.XtraBars.BarAutoPopupMode.None;
            this.bIconos.OptionsBar.DisableClose = true;
            this.bIconos.OptionsBar.DisableCustomization = true;
            this.bIconos.OptionsBar.DrawBorder = false;
            this.bIconos.OptionsBar.DrawDragBorder = false;
            this.bIconos.OptionsBar.RotateWhenVertical = false;
            this.bIconos.OptionsBar.UseWholeRow = true;
            this.bIconos.Text = "Menú principal";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Caption = "Limpiar";
            this.btnLimpiar.Id = 50;
            this.btnLimpiar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpiar.ImageOptions.Image")));
            this.btnLimpiar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnLimpiar.ImageOptions.LargeImage")));
            this.btnLimpiar.Name = "btnLimpiar";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Caption = "Guardar";
            this.btnGuardar.Id = 53;
            this.btnGuardar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.ImageOptions.Image")));
            this.btnGuardar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnGuardar.ImageOptions.LargeImage")));
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnGuardar_ItemClick);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Caption = "Eliminar";
            this.btnEliminar.Id = 57;
            this.btnEliminar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.ImageOptions.Image")));
            this.btnEliminar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnEliminar.ImageOptions.LargeImage")));
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnEliminar_ItemClick);
            // 
            // btnSalir
            // 
            this.btnSalir.Caption = "Salir";
            this.btnSalir.Id = 63;
            this.btnSalir.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.ImageOptions.Image")));
            this.btnSalir.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnSalir.ImageOptions.LargeImage")));
            this.btnSalir.Name = "btnSalir";
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.Caption = "Seleccionar";
            this.btnSeleccionar.Id = 66;
            this.btnSeleccionar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSeleccionar.ImageOptions.Image")));
            this.btnSeleccionar.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnSeleccionar.ImageOptions.LargeImage")));
            this.btnSeleccionar.Name = "btnSeleccionar";
            // 
            // bEstado
            // 
            this.bEstado.BarName = "Barra de estado";
            this.bEstado.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bEstado.DockCol = 0;
            this.bEstado.DockRow = 0;
            this.bEstado.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bEstado.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.lblProveedor)});
            this.bEstado.OptionsBar.AllowQuickCustomization = false;
            this.bEstado.OptionsBar.DrawDragBorder = false;
            this.bEstado.OptionsBar.UseWholeRow = true;
            this.bEstado.Text = "Barra de estado";
            // 
            // lblProveedor
            // 
            this.lblProveedor.Caption = "Empleado:";
            this.lblProveedor.Id = 48;
            this.lblProveedor.Name = "lblProveedor";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(848, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 569);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(848, 22);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(56, 569);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(848, 0);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 569);
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.cboInsidencias);
            this.panelControl1.Controls.Add(this.labelControl7);
            this.panelControl1.Controls.Add(this.dtFecha);
            this.panelControl1.Controls.Add(this.labelControl3);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.btnbuscar);
            this.panelControl1.Controls.Add(this.textNombre);
            this.panelControl1.Controls.Add(this.textId);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(56, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(792, 130);
            this.panelControl1.TabIndex = 4;
            // 
            // cboInsidencias
            // 
            this.cboInsidencias.Location = new System.Drawing.Point(119, 91);
            this.cboInsidencias.Name = "cboInsidencias";
            this.cboInsidencias.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboInsidencias.Properties.NullText = "- Seleccione Incidencia -";
            this.cboInsidencias.Size = new System.Drawing.Size(198, 20);
            this.cboInsidencias.TabIndex = 29;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(50, 94);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(52, 13);
            this.labelControl7.TabIndex = 28;
            this.labelControl7.Text = "Incidencia:";
            // 
            // dtFecha
            // 
            this.dtFecha.EditValue = null;
            this.dtFecha.Location = new System.Drawing.Point(119, 65);
            this.dtFecha.MenuManager = this.barManager1;
            this.dtFecha.Name = "dtFecha";
            this.dtFecha.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtFecha.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtFecha.Size = new System.Drawing.Size(130, 20);
            this.dtFecha.TabIndex = 25;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(17, 69);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(84, 13);
            this.labelControl3.TabIndex = 24;
            this.labelControl3.Text = "Fecha Incidencia:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(60, 43);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(41, 13);
            this.labelControl2.TabIndex = 22;
            this.labelControl2.Text = "Nombre:";
            // 
            // btnbuscar
            // 
            this.btnbuscar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnbuscar.ImageOptions.Image")));
            this.btnbuscar.Location = new System.Drawing.Point(225, 12);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(24, 23);
            this.btnbuscar.TabIndex = 21;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // textNombre
            // 
            this.textNombre.Enabled = false;
            this.textNombre.Location = new System.Drawing.Point(119, 39);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(245, 20);
            this.textNombre.TabIndex = 20;
            // 
            // textId
            // 
            this.textId.Enabled = false;
            this.textId.Location = new System.Drawing.Point(119, 13);
            this.textId.Name = "textId";
            this.textId.Size = new System.Drawing.Size(100, 20);
            this.textId.TabIndex = 19;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(51, 17);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(50, 13);
            this.labelControl1.TabIndex = 18;
            this.labelControl1.Text = "Empleado:";
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.labelControl6);
            this.panelControl2.Controls.Add(this.labelControl5);
            this.panelControl2.Controls.Add(this.dt_FechaFin);
            this.panelControl2.Controls.Add(this.dt_FechaInicio);
            this.panelControl2.Controls.Add(this.dtgEmpleadosBono);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(56, 130);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Padding = new System.Windows.Forms.Padding(10, 40, 10, 10);
            this.panelControl2.Size = new System.Drawing.Size(792, 439);
            this.panelControl2.TabIndex = 5;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(232, 14);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(50, 13);
            this.labelControl6.TabIndex = 28;
            this.labelControl6.Text = "Fecha Fin:";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(27, 14);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(61, 13);
            this.labelControl5.TabIndex = 27;
            this.labelControl5.Text = "Fecha Inicio:";
            // 
            // dt_FechaFin
            // 
            this.dt_FechaFin.EditValue = null;
            this.dt_FechaFin.Location = new System.Drawing.Point(291, 9);
            this.dt_FechaFin.Name = "dt_FechaFin";
            this.dt_FechaFin.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_FechaFin.Properties.Appearance.Options.UseFont = true;
            this.dt_FechaFin.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dt_FechaFin.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dt_FechaFin.Size = new System.Drawing.Size(108, 22);
            this.dt_FechaFin.TabIndex = 15;
            // 
            // dt_FechaInicio
            // 
            this.dt_FechaInicio.EditValue = null;
            this.dt_FechaInicio.Location = new System.Drawing.Point(95, 9);
            this.dt_FechaInicio.Name = "dt_FechaInicio";
            this.dt_FechaInicio.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_FechaInicio.Properties.Appearance.Options.UseFont = true;
            this.dt_FechaInicio.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dt_FechaInicio.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dt_FechaInicio.Size = new System.Drawing.Size(108, 22);
            this.dt_FechaInicio.TabIndex = 14;
            // 
            // dtgEmpleadosBono
            // 
            this.dtgEmpleadosBono.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgEmpleadosBono.Location = new System.Drawing.Point(12, 42);
            this.dtgEmpleadosBono.MainView = this.dtgValEmpleadosBono;
            this.dtgEmpleadosBono.MenuManager = this.barManager1;
            this.dtgEmpleadosBono.Name = "dtgEmpleadosBono";
            this.dtgEmpleadosBono.Size = new System.Drawing.Size(768, 385);
            this.dtgEmpleadosBono.TabIndex = 0;
            this.dtgEmpleadosBono.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dtgValEmpleadosBono});
            this.dtgEmpleadosBono.Click += new System.EventHandler(this.dtgEmpleadosBono_Click);
            // 
            // dtgValEmpleadosBono
            // 
            this.dtgValEmpleadosBono.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6});
            this.dtgValEmpleadosBono.GridControl = this.dtgEmpleadosBono;
            this.dtgValEmpleadosBono.Name = "dtgValEmpleadosBono";
            this.dtgValEmpleadosBono.OptionsFind.AllowFindPanel = false;
            this.dtgValEmpleadosBono.OptionsFind.AlwaysVisible = true;
            this.dtgValEmpleadosBono.OptionsView.ShowFooter = true;
            this.dtgValEmpleadosBono.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Codigo";
            this.gridColumn1.FieldName = "c_codigo_emp";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Nombre";
            this.gridColumn2.FieldName = "v_nombre_emp";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Fecha";
            this.gridColumn3.FieldName = "Fecha";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.AllowEdit = false;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Incidencia";
            this.gridColumn4.FieldName = "NombreIncidencia";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.OptionsColumn.AllowEdit = false;
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "c_codigo_einc";
            this.gridColumn5.FieldName = "c_codigo_einc";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.OptionsColumn.AllowEdit = false;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "IdIncidencia";
            this.gridColumn6.FieldName = "IdIncidencia";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.OptionsColumn.AllowEdit = false;
            // 
            // Frm_EmpleadosBono
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 591);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_EmpleadosBono";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Empleados Bono";
            this.Load += new System.EventHandler(this.Frm_EmpleadosBono_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboInsidencias.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFecha.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFecha.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textNombre.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dt_FechaFin.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_FechaFin.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_FechaInicio.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_FechaInicio.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgEmpleadosBono)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgValEmpleadosBono)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public DevExpress.XtraBars.BarManager barManager1;
        public DevExpress.XtraBars.Bar bIconos;
        private DevExpress.XtraBars.BarLargeButtonItem btnLimpiar;
        private DevExpress.XtraBars.BarLargeButtonItem btnGuardar;
        private DevExpress.XtraBars.BarLargeButtonItem btnEliminar;
        private DevExpress.XtraBars.BarLargeButtonItem btnSalir;
        private DevExpress.XtraBars.BarLargeButtonItem btnSeleccionar;
        private DevExpress.XtraBars.Bar bEstado;
        private DevExpress.XtraBars.BarStaticItem lblProveedor;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.DateEdit dtFecha;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton btnbuscar;
        private DevExpress.XtraEditors.TextEdit textNombre;
        private DevExpress.XtraEditors.TextEdit textId;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraGrid.GridControl dtgEmpleadosBono;
        private DevExpress.XtraGrid.Views.Grid.GridView dtgValEmpleadosBono;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.DateEdit dt_FechaFin;
        private DevExpress.XtraEditors.DateEdit dt_FechaInicio;
        private DevExpress.XtraEditors.LookUpEdit cboInsidencias;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
    }
}