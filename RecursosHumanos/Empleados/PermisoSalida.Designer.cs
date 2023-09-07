namespace RecursosHumanos.Empleados
{
    partial class PermisoSalida
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PermisoSalida));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.bbiGuardar = new DevExpress.XtraBars.BarButtonItem();
            this.bbiCancelar = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPageCategory1 = new DevExpress.XtraBars.Ribbon.RibbonPageCategory();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.txteRelojMarcador = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.lkeTipoSalida = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.lkeMotivoPermiso = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.dtpFechaSalida = new DevExpress.XtraEditors.DateEdit();
            this.txtAsunto = new DevExpress.XtraEditors.MemoEdit();
            this.tmeSalida = new DevExpress.XtraEditors.TimeEdit();
            this.lkeUnidad = new DevExpress.XtraEditors.LookUpEdit();
            this.lkeTipoPermiso = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.lkeEmpleado = new DevExpress.XtraEditors.LookUpEdit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txteRelojMarcador.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkeTipoSalida.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkeMotivoPermiso.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpFechaSalida.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpFechaSalida.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAsunto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tmeSalida.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkeUnidad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkeTipoPermiso.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkeEmpleado.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.bbiGuardar,
            this.bbiCancelar});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 3;
            this.ribbon.Name = "ribbon";
            this.ribbon.PageCategories.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageCategory[] {
            this.ribbonPageCategory1});
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
            this.ribbon.Size = new System.Drawing.Size(984, 175);
            this.ribbon.Toolbar.ShowCustomizeItem = false;
            // 
            // bbiGuardar
            // 
            this.bbiGuardar.Caption = "Guardar";
            this.bbiGuardar.Id = 1;
            this.bbiGuardar.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("bbiGuardar.ImageOptions.SvgImage")));
            this.bbiGuardar.Name = "bbiGuardar";
            this.bbiGuardar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiGuardar_ItemClick);
            // 
            // bbiCancelar
            // 
            this.bbiCancelar.Caption = "Cancelar";
            this.bbiCancelar.Id = 2;
            this.bbiCancelar.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("bbiCancelar.ImageOptions.SvgImage")));
            this.bbiCancelar.Name = "bbiCancelar";
            // 
            // ribbonPageCategory1
            // 
            this.ribbonPageCategory1.Name = "ribbonPageCategory1";
            this.ribbonPageCategory1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage2});
            this.ribbonPageCategory1.Text = "ribbonPageCategory1";
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2});
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "ribbonPage2";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "ribbonPageGroup2";
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
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiGuardar);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiCancelar);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Acciones";
            // 
            // txteRelojMarcador
            // 
            this.txteRelojMarcador.Location = new System.Drawing.Point(242, 273);
            this.txteRelojMarcador.MenuManager = this.ribbon;
            this.txteRelojMarcador.Name = "txteRelojMarcador";
            this.txteRelojMarcador.Properties.ReadOnly = true;
            this.txteRelojMarcador.Size = new System.Drawing.Size(193, 28);
            this.txteRelojMarcador.TabIndex = 3;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(64, 243);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(164, 19);
            this.labelControl3.TabIndex = 6;
            this.labelControl3.Text = "Nombre del Empleado:";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(64, 277);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(126, 19);
            this.labelControl1.TabIndex = 7;
            this.labelControl1.Text = "Numero de Reloj:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(476, 342);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(56, 19);
            this.labelControl2.TabIndex = 8;
            this.labelControl2.Text = "Asunto:";
            // 
            // lkeTipoSalida
            // 
            this.lkeTipoSalida.Location = new System.Drawing.Point(242, 409);
            this.lkeTipoSalida.MenuManager = this.ribbon;
            this.lkeTipoSalida.Name = "lkeTipoSalida";
            this.lkeTipoSalida.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkeTipoSalida.Size = new System.Drawing.Size(193, 28);
            this.lkeTipoSalida.TabIndex = 26;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(65, 311);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(56, 19);
            this.labelControl4.TabIndex = 27;
            this.labelControl4.Text = "Unidad:";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(64, 379);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(137, 19);
            this.labelControl5.TabIndex = 28;
            this.labelControl5.Text = "Motivo de Permiso:";
            // 
            // lkeMotivoPermiso
            // 
            this.lkeMotivoPermiso.Location = new System.Drawing.Point(242, 375);
            this.lkeMotivoPermiso.MenuManager = this.ribbon;
            this.lkeMotivoPermiso.Name = "lkeMotivoPermiso";
            this.lkeMotivoPermiso.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkeMotivoPermiso.Size = new System.Drawing.Size(193, 28);
            this.lkeMotivoPermiso.TabIndex = 29;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(476, 277);
            this.labelControl6.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(124, 19);
            this.labelControl6.TabIndex = 31;
            this.labelControl6.Text = "Hora de Permiso:";
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(65, 413);
            this.labelControl7.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(107, 19);
            this.labelControl7.TabIndex = 32;
            this.labelControl7.Text = "Tipo de Salida:";
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(476, 311);
            this.labelControl8.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(130, 19);
            this.labelControl8.TabIndex = 34;
            this.labelControl8.Text = "Fecha de Permiso:";
            // 
            // dtpFechaSalida
            // 
            this.dtpFechaSalida.EditValue = null;
            this.dtpFechaSalida.Location = new System.Drawing.Point(654, 307);
            this.dtpFechaSalida.MenuManager = this.ribbon;
            this.dtpFechaSalida.Name = "dtpFechaSalida";
            this.dtpFechaSalida.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpFechaSalida.Properties.CalendarTimeEditing = DevExpress.Utils.DefaultBoolean.False;
            this.dtpFechaSalida.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpFechaSalida.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.dtpFechaSalida.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtpFechaSalida.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.dtpFechaSalida.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtpFechaSalida.Properties.FirstDayOfWeek = System.DayOfWeek.Monday;
            this.dtpFechaSalida.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.dtpFechaSalida.Properties.ShowMonthNavigationButtons = DevExpress.Utils.DefaultBoolean.True;
            this.dtpFechaSalida.Size = new System.Drawing.Size(239, 28);
            this.dtpFechaSalida.TabIndex = 62;
            // 
            // txtAsunto
            // 
            this.txtAsunto.Location = new System.Drawing.Point(654, 341);
            this.txtAsunto.MenuManager = this.ribbon;
            this.txtAsunto.Name = "txtAsunto";
            this.txtAsunto.Properties.MaxLength = 250;
            this.txtAsunto.Size = new System.Drawing.Size(239, 96);
            this.txtAsunto.TabIndex = 72;
            // 
            // tmeSalida
            // 
            this.tmeSalida.EditValue = new System.DateTime(2022, 9, 20, 0, 0, 0, 0);
            this.tmeSalida.Location = new System.Drawing.Point(654, 273);
            this.tmeSalida.MenuManager = this.ribbon;
            this.tmeSalida.Name = "tmeSalida";
            this.tmeSalida.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.tmeSalida.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tmeSalida.Properties.DisplayFormat.FormatString = "hh:MM tt";
            this.tmeSalida.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.tmeSalida.Properties.EditFormat.FormatString = "hh:MM";
            this.tmeSalida.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.tmeSalida.Properties.Mask.EditMask = "hh:mm tt";
            this.tmeSalida.Properties.NullText = "vacio";
            this.tmeSalida.Properties.NullValuePromptShowForEmptyValue = true;
            this.tmeSalida.Properties.TimeEditStyle = DevExpress.XtraEditors.Repository.TimeEditStyle.TouchUI;
            this.tmeSalida.Properties.TouchUIMaxValue = new System.DateTime(9999, 12, 31, 16, 0, 0, 0);
            this.tmeSalida.Properties.TouchUIMinValue = new System.DateTime(1800, 12, 31, 7, 0, 0, 0);
            this.tmeSalida.Size = new System.Drawing.Size(239, 28);
            this.tmeSalida.TabIndex = 74;
            // 
            // lkeUnidad
            // 
            this.lkeUnidad.Location = new System.Drawing.Point(242, 307);
            this.lkeUnidad.MenuManager = this.ribbon;
            this.lkeUnidad.Name = "lkeUnidad";
            this.lkeUnidad.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkeUnidad.Properties.ReadOnly = true;
            this.lkeUnidad.Size = new System.Drawing.Size(193, 28);
            this.lkeUnidad.TabIndex = 76;
            // 
            // lkeTipoPermiso
            // 
            this.lkeTipoPermiso.Location = new System.Drawing.Point(242, 341);
            this.lkeTipoPermiso.MenuManager = this.ribbon;
            this.lkeTipoPermiso.Name = "lkeTipoPermiso";
            this.lkeTipoPermiso.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkeTipoPermiso.Size = new System.Drawing.Size(193, 28);
            this.lkeTipoPermiso.TabIndex = 78;
            this.lkeTipoPermiso.EditValueChanged += new System.EventHandler(this.lkeTipoPermiso_EditValueChanged);
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(64, 345);
            this.labelControl9.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(122, 19);
            this.labelControl9.TabIndex = 77;
            this.labelControl9.Text = "Tipo de Permiso:";
            // 
            // lkeEmpleado
            // 
            this.lkeEmpleado.Location = new System.Drawing.Point(242, 239);
            this.lkeEmpleado.MenuManager = this.ribbon;
            this.lkeEmpleado.Name = "lkeEmpleado";
            this.lkeEmpleado.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkeEmpleado.Size = new System.Drawing.Size(193, 28);
            this.lkeEmpleado.TabIndex = 80;
            // 
            // PermisoSalida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 495);
            this.Controls.Add(this.lkeEmpleado);
            this.Controls.Add(this.lkeTipoPermiso);
            this.Controls.Add(this.labelControl9);
            this.Controls.Add(this.lkeUnidad);
            this.Controls.Add(this.tmeSalida);
            this.Controls.Add(this.txtAsunto);
            this.Controls.Add(this.dtpFechaSalida);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.lkeMotivoPermiso);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.lkeTipoSalida);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.txteRelojMarcador);
            this.Controls.Add(this.ribbon);
            this.Name = "PermisoSalida";
            this.Ribbon = this.ribbon;
            this.Text = "PermisoSalida";
            this.Load += new System.EventHandler(this.PermisoSalida_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txteRelojMarcador.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkeTipoSalida.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkeMotivoPermiso.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpFechaSalida.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpFechaSalida.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAsunto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tmeSalida.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkeUnidad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkeTipoPermiso.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkeEmpleado.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraEditors.TextEdit txteRelojMarcador;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LookUpEdit lkeTipoSalida;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LookUpEdit lkeMotivoPermiso;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.DateEdit dtpFechaSalida;
        private DevExpress.XtraBars.Ribbon.RibbonPageCategory ribbonPageCategory1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem bbiGuardar;
        private DevExpress.XtraBars.BarButtonItem bbiCancelar;
        private DevExpress.XtraEditors.MemoEdit txtAsunto;
        private DevExpress.XtraEditors.TimeEdit tmeSalida;
        private DevExpress.XtraEditors.LookUpEdit lkeUnidad;
        private DevExpress.XtraEditors.LookUpEdit lkeTipoPermiso;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LookUpEdit lkeEmpleado;
    }
}