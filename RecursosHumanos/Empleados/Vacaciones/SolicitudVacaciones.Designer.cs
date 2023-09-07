namespace RecursosHumanos.Empleados
{
    partial class SolicitudVacaciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SolicitudVacaciones));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.bbiGuardarVacaciones = new DevExpress.XtraBars.BarButtonItem();
            this.bbiCancelar = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.bbitSolicitarVacaciones = new DevExpress.XtraBars.BarButtonItem();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.xtraScrollableControl1 = new DevExpress.XtraEditors.XtraScrollableControl();
            this.gdcDatos = new DevExpress.XtraGrid.GridControl();
            this.gdvDatos = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.txtUnidad = new DevExpress.XtraEditors.TextEdit();
            this.txtPuestos = new DevExpress.XtraEditors.TextEdit();
            this.dtpFechaRegreso = new DevExpress.XtraEditors.DateEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.dtpFechaInicio = new DevExpress.XtraEditors.DateEdit();
            this.dtpFechaFinal = new DevExpress.XtraEditors.DateEdit();
            this.txtDiasDisponibles = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtDiasTomar = new DevExpress.XtraEditors.TextEdit();
            this.lkeEmpleado = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtRelojMarcador = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.xtraScrollableControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdcDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUnidad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPuestos.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpFechaRegreso.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpFechaRegreso.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpFechaInicio.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpFechaInicio.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpFechaFinal.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpFechaFinal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiasDisponibles.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiasTomar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkeEmpleado.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRelojMarcador.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.bbiGuardarVacaciones,
            this.bbiCancelar});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.Margin = new System.Windows.Forms.Padding(4);
            this.ribbon.MaxItemId = 4;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbon.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbon.ShowCategoryInCaption = false;
            this.ribbon.ShowDisplayOptionsMenuButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbon.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbon.ShowMoreCommandsButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbon.ShowPageHeadersInFormCaption = DevExpress.Utils.DefaultBoolean.False;
            this.ribbon.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            this.ribbon.ShowQatLocationSelector = false;
            this.ribbon.ShowToolbarCustomizeItem = false;
            this.ribbon.Size = new System.Drawing.Size(1054, 175);
            this.ribbon.Toolbar.ShowCustomizeItem = false;
            // 
            // bbiGuardarVacaciones
            // 
            this.bbiGuardarVacaciones.Caption = "Enviar Solicitud ";
            this.bbiGuardarVacaciones.Id = 2;
            this.bbiGuardarVacaciones.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("bbiGuardarVacaciones.ImageOptions.SvgImage")));
            this.bbiGuardarVacaciones.Name = "bbiGuardarVacaciones";
            this.bbiGuardarVacaciones.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiGuardarVacaciones_ItemClick);
            // 
            // bbiCancelar
            // 
            this.bbiCancelar.Caption = "Cancelar";
            this.bbiCancelar.Id = 3;
            this.bbiCancelar.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("bbiCancelar.ImageOptions.SvgImage")));
            this.bbiCancelar.Name = "bbiCancelar";
            this.bbiCancelar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiCancelar_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "ribbonPage1";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiGuardarVacaciones);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiCancelar);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Acciones";
            // 
            // bbitSolicitarVacaciones
            // 
            this.bbitSolicitarVacaciones.Caption = "Solicitar Vacaciones ";
            this.bbitSolicitarVacaciones.Id = 1;
            this.bbitSolicitarVacaciones.Name = "bbitSolicitarVacaciones";
            // 
            // groupControl1
            // 
            this.groupControl1.AllowTouchScroll = true;
            this.groupControl1.Controls.Add(this.xtraScrollableControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 175);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1054, 581);
            this.groupControl1.TabIndex = 4;
            this.groupControl1.Text = "Informarción";
            // 
            // xtraScrollableControl1
            // 
            this.xtraScrollableControl1.Controls.Add(this.gdcDatos);
            this.xtraScrollableControl1.Controls.Add(this.labelControl10);
            this.xtraScrollableControl1.Controls.Add(this.txtUnidad);
            this.xtraScrollableControl1.Controls.Add(this.txtPuestos);
            this.xtraScrollableControl1.Controls.Add(this.dtpFechaRegreso);
            this.xtraScrollableControl1.Controls.Add(this.labelControl8);
            this.xtraScrollableControl1.Controls.Add(this.dtpFechaInicio);
            this.xtraScrollableControl1.Controls.Add(this.dtpFechaFinal);
            this.xtraScrollableControl1.Controls.Add(this.txtDiasDisponibles);
            this.xtraScrollableControl1.Controls.Add(this.labelControl7);
            this.xtraScrollableControl1.Controls.Add(this.labelControl6);
            this.xtraScrollableControl1.Controls.Add(this.labelControl5);
            this.xtraScrollableControl1.Controls.Add(this.labelControl4);
            this.xtraScrollableControl1.Controls.Add(this.txtDiasTomar);
            this.xtraScrollableControl1.Controls.Add(this.lkeEmpleado);
            this.xtraScrollableControl1.Controls.Add(this.labelControl2);
            this.xtraScrollableControl1.Controls.Add(this.txtRelojMarcador);
            this.xtraScrollableControl1.Controls.Add(this.labelControl1);
            this.xtraScrollableControl1.Controls.Add(this.labelControl3);
            this.xtraScrollableControl1.Controls.Add(this.labelControl9);
            this.xtraScrollableControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraScrollableControl1.Location = new System.Drawing.Point(2, 29);
            this.xtraScrollableControl1.Name = "xtraScrollableControl1";
            this.xtraScrollableControl1.Size = new System.Drawing.Size(1050, 550);
            this.xtraScrollableControl1.TabIndex = 25;
            // 
            // gdcDatos
            // 
            this.gdcDatos.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gdcDatos.Location = new System.Drawing.Point(36, 259);
            this.gdcDatos.MainView = this.gdvDatos;
            this.gdcDatos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gdcDatos.MenuManager = this.ribbon;
            this.gdcDatos.Name = "gdcDatos";
            this.gdcDatos.Size = new System.Drawing.Size(1004, 219);
            this.gdcDatos.TabIndex = 111;
            this.gdcDatos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gdvDatos});
            // 
            // gdvDatos
            // 
            this.gdvDatos.DetailHeight = 349;
            this.gdvDatos.FixedLineWidth = 1;
            this.gdvDatos.GridControl = this.gdcDatos;
            this.gdvDatos.Name = "gdvDatos";
            this.gdvDatos.OptionsBehavior.AllowSortAnimation = DevExpress.Utils.DefaultBoolean.False;
            this.gdvDatos.OptionsBehavior.Editable = false;
            this.gdvDatos.OptionsCustomization.AllowSort = false;
            this.gdvDatos.OptionsFind.FindNullPrompt = "Ingrese el empleado a buscar...";
            this.gdvDatos.OptionsFind.SearchInPreview = true;
            this.gdvDatos.OptionsMenu.ShowGroupSortSummaryItems = false;
            this.gdvDatos.OptionsMenu.ShowGroupSummaryEditorItem = true;
            this.gdvDatos.OptionsView.ColumnAutoWidth = false;
            this.gdvDatos.OptionsView.ShowGroupPanel = false;
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl10.Appearance.Options.UseFont = true;
            this.labelControl10.Location = new System.Drawing.Point(36, 231);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(81, 21);
            this.labelControl10.TabIndex = 110;
            this.labelControl10.Text = "Periodos:";
            this.labelControl10.ToolTipIconType = DevExpress.Utils.ToolTipIconType.WindLogo;
            // 
            // txtUnidad
            // 
            this.txtUnidad.Location = new System.Drawing.Point(180, 134);
            this.txtUnidad.MenuManager = this.ribbon;
            this.txtUnidad.Name = "txtUnidad";
            this.txtUnidad.Properties.Mask.EditMask = "*";
            this.txtUnidad.Properties.ReadOnly = true;
            this.txtUnidad.Size = new System.Drawing.Size(290, 28);
            this.txtUnidad.TabIndex = 109;
            // 
            // txtPuestos
            // 
            this.txtPuestos.Location = new System.Drawing.Point(180, 101);
            this.txtPuestos.MenuManager = this.ribbon;
            this.txtPuestos.Name = "txtPuestos";
            this.txtPuestos.Properties.Mask.EditMask = "*";
            this.txtPuestos.Properties.ReadOnly = true;
            this.txtPuestos.Size = new System.Drawing.Size(290, 28);
            this.txtPuestos.TabIndex = 108;
            // 
            // dtpFechaRegreso
            // 
            this.dtpFechaRegreso.EditValue = null;
            this.dtpFechaRegreso.Location = new System.Drawing.Point(649, 132);
            this.dtpFechaRegreso.MenuManager = this.ribbon;
            this.dtpFechaRegreso.Name = "dtpFechaRegreso";
            this.dtpFechaRegreso.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpFechaRegreso.Properties.CalendarTimeEditing = DevExpress.Utils.DefaultBoolean.False;
            this.dtpFechaRegreso.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpFechaRegreso.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.dtpFechaRegreso.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtpFechaRegreso.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.dtpFechaRegreso.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtpFechaRegreso.Properties.FirstDayOfWeek = System.DayOfWeek.Monday;
            this.dtpFechaRegreso.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.dtpFechaRegreso.Properties.ReadOnly = true;
            this.dtpFechaRegreso.Properties.ShowMonthNavigationButtons = DevExpress.Utils.DefaultBoolean.True;
            this.dtpFechaRegreso.Size = new System.Drawing.Size(313, 28);
            this.dtpFechaRegreso.TabIndex = 107;
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(505, 137);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(124, 19);
            this.labelControl8.TabIndex = 106;
            this.labelControl8.Text = "Fecha de Regreso";
            this.labelControl8.ToolTipIconType = DevExpress.Utils.ToolTipIconType.WindLogo;
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.EditValue = null;
            this.dtpFechaInicio.Location = new System.Drawing.Point(649, 29);
            this.dtpFechaInicio.MenuManager = this.ribbon;
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpFechaInicio.Properties.CalendarTimeEditing = DevExpress.Utils.DefaultBoolean.False;
            this.dtpFechaInicio.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpFechaInicio.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.dtpFechaInicio.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtpFechaInicio.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.dtpFechaInicio.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtpFechaInicio.Properties.FirstDayOfWeek = System.DayOfWeek.Monday;
            this.dtpFechaInicio.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.dtpFechaInicio.Properties.ShowMonthNavigationButtons = DevExpress.Utils.DefaultBoolean.True;
            this.dtpFechaInicio.Size = new System.Drawing.Size(313, 28);
            this.dtpFechaInicio.TabIndex = 105;
            this.dtpFechaInicio.EditValueChanged += new System.EventHandler(this.dtpFechaInicio_EditValueChanged);
            // 
            // dtpFechaFinal
            // 
            this.dtpFechaFinal.EditValue = null;
            this.dtpFechaFinal.Location = new System.Drawing.Point(649, 64);
            this.dtpFechaFinal.MenuManager = this.ribbon;
            this.dtpFechaFinal.Name = "dtpFechaFinal";
            this.dtpFechaFinal.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpFechaFinal.Properties.CalendarTimeEditing = DevExpress.Utils.DefaultBoolean.False;
            this.dtpFechaFinal.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpFechaFinal.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.dtpFechaFinal.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtpFechaFinal.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.dtpFechaFinal.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtpFechaFinal.Properties.FirstDayOfWeek = System.DayOfWeek.Monday;
            this.dtpFechaFinal.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.dtpFechaFinal.Properties.ShowMonthNavigationButtons = DevExpress.Utils.DefaultBoolean.True;
            this.dtpFechaFinal.Size = new System.Drawing.Size(313, 28);
            this.dtpFechaFinal.TabIndex = 104;
            this.dtpFechaFinal.EditValueChanged += new System.EventHandler(this.dtpFechaFinal_EditValueChanged);
            // 
            // txtDiasDisponibles
            // 
            this.txtDiasDisponibles.Location = new System.Drawing.Point(180, 170);
            this.txtDiasDisponibles.MenuManager = this.ribbon;
            this.txtDiasDisponibles.Name = "txtDiasDisponibles";
            this.txtDiasDisponibles.Properties.Mask.EditMask = "*";
            this.txtDiasDisponibles.Properties.ReadOnly = true;
            this.txtDiasDisponibles.Size = new System.Drawing.Size(290, 28);
            this.txtDiasDisponibles.TabIndex = 99;
            this.txtDiasDisponibles.Validating += new System.ComponentModel.CancelEventHandler(this.txtDiasDisponibles_Validating);
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(36, 175);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(116, 19);
            this.labelControl7.TabIndex = 98;
            this.labelControl7.Text = "Dias Disponibles";
            this.labelControl7.ToolTipIconType = DevExpress.Utils.ToolTipIconType.WindLogo;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(505, 35);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(130, 21);
            this.labelControl6.TabIndex = 95;
            this.labelControl6.Text = "Fecha de Inicio";
            this.labelControl6.ToolTipIconType = DevExpress.Utils.ToolTipIconType.WindLogo;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(505, 69);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(96, 21);
            this.labelControl5.TabIndex = 94;
            this.labelControl5.Text = "Fecha Final";
            this.labelControl5.ToolTipIconType = DevExpress.Utils.ToolTipIconType.WindLogo;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(505, 104);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(95, 19);
            this.labelControl4.TabIndex = 93;
            this.labelControl4.Text = "Dias a Tomar";
            this.labelControl4.ToolTipIconType = DevExpress.Utils.ToolTipIconType.WindLogo;
            // 
            // txtDiasTomar
            // 
            this.txtDiasTomar.Location = new System.Drawing.Point(649, 98);
            this.txtDiasTomar.MenuManager = this.ribbon;
            this.txtDiasTomar.Name = "txtDiasTomar";
            this.txtDiasTomar.Properties.Mask.EditMask = "[123456789]+";
            this.txtDiasTomar.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtDiasTomar.Properties.ReadOnly = true;
            this.txtDiasTomar.Size = new System.Drawing.Size(313, 28);
            this.txtDiasTomar.TabIndex = 92;
            this.txtDiasTomar.EditValueChanged += new System.EventHandler(this.txtDiasTomar_EditValueChanged);
            this.txtDiasTomar.Validating += new System.ComponentModel.CancelEventHandler(this.txtDiasTomar_Validating);
            // 
            // lkeEmpleado
            // 
            this.lkeEmpleado.Location = new System.Drawing.Point(180, 31);
            this.lkeEmpleado.MenuManager = this.ribbon;
            this.lkeEmpleado.Name = "lkeEmpleado";
            this.lkeEmpleado.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkeEmpleado.Properties.NullText = "";
            this.lkeEmpleado.Properties.NullValuePrompt = "Seleccione el empleado";
            this.lkeEmpleado.Size = new System.Drawing.Size(290, 28);
            this.lkeEmpleado.TabIndex = 90;
            this.lkeEmpleado.EditValueChanged += new System.EventHandler(this.lkeEmpleado_EditValueChanged);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(36, 139);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(50, 19);
            this.labelControl2.TabIndex = 89;
            this.labelControl2.Text = "Unidad";
            this.labelControl2.ToolTipIconType = DevExpress.Utils.ToolTipIconType.WindLogo;
            // 
            // txtRelojMarcador
            // 
            this.txtRelojMarcador.Location = new System.Drawing.Point(180, 67);
            this.txtRelojMarcador.MenuManager = this.ribbon;
            this.txtRelojMarcador.Name = "txtRelojMarcador";
            this.txtRelojMarcador.Properties.ReadOnly = true;
            this.txtRelojMarcador.Size = new System.Drawing.Size(290, 28);
            this.txtRelojMarcador.TabIndex = 2;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(36, 72);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(136, 19);
            this.labelControl1.TabIndex = 84;
            this.labelControl1.Text = "No. Reloj Marcador";
            this.labelControl1.ToolTipIconType = DevExpress.Utils.ToolTipIconType.WindLogo;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(36, 37);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(70, 19);
            this.labelControl3.TabIndex = 3;
            this.labelControl3.Text = "Empleado";
            this.labelControl3.ToolTipIconType = DevExpress.Utils.ToolTipIconType.WindLogo;
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(36, 105);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(47, 19);
            this.labelControl9.TabIndex = 15;
            this.labelControl9.Text = "Puesto";
            this.labelControl9.ToolTipIconType = DevExpress.Utils.ToolTipIconType.WindLogo;
            // 
            // SolicitudVacaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 756);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.ribbon);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SolicitudVacaciones";
            this.Ribbon = this.ribbon;
            this.Text = "Nueva Solicitud de Vacaciones";
            this.Load += new System.EventHandler(this.SolicitudVacaciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.xtraScrollableControl1.ResumeLayout(false);
            this.xtraScrollableControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdcDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUnidad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPuestos.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpFechaRegreso.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpFechaRegreso.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpFechaInicio.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpFechaInicio.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpFechaFinal.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpFechaFinal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiasDisponibles.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiasTomar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkeEmpleado.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRelojMarcador.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem bbitSolicitarVacaciones;
        private DevExpress.XtraBars.BarButtonItem bbiGuardarVacaciones;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.XtraScrollableControl xtraScrollableControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LookUpEdit lkeEmpleado;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtDiasTomar;
        private DevExpress.XtraEditors.TextEdit txtDiasDisponibles;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.DateEdit dtpFechaInicio;
        private DevExpress.XtraEditors.DateEdit dtpFechaFinal;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.DateEdit dtpFechaRegreso;
        private DevExpress.XtraBars.BarButtonItem bbiCancelar;
        private DevExpress.XtraEditors.TextEdit txtUnidad;
        private DevExpress.XtraEditors.TextEdit txtPuestos;
        private DevExpress.XtraEditors.TextEdit txtRelojMarcador;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraGrid.GridControl gdcDatos;
        private DevExpress.XtraGrid.Views.Grid.GridView gdvDatos;
    }
}