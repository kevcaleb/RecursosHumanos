namespace RecursosHumanos.Empleados.Consultas
{
    partial class ConsultaVacacionesEmpleado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultaVacacionesEmpleado));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.bbiCerrar = new DevExpress.XtraBars.BarButtonItem();
            this.bbiActualizar = new DevExpress.XtraBars.BarButtonItem();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.xtraScrollableControl1 = new DevExpress.XtraEditors.XtraScrollableControl();
            this.gdcDatos = new DevExpress.XtraGrid.GridControl();
            this.gdvDatos = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.txtUnidad = new DevExpress.XtraEditors.TextEdit();
            this.txtPuestos = new DevExpress.XtraEditors.TextEdit();
            this.txtDiasDisponibles = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtRelojMarcador = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.txteEmpleado = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.xtraScrollableControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdcDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUnidad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPuestos.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiasDisponibles.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRelojMarcador.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txteEmpleado.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.bbiCerrar,
            this.bbiActualizar});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 3;
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
            this.ribbon.Size = new System.Drawing.Size(1067, 175);
            this.ribbon.Toolbar.ShowCustomizeItem = false;
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
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiCerrar);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiActualizar);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Acciones";
            // 
            // bbiCerrar
            // 
            this.bbiCerrar.Caption = "Cerrar";
            this.bbiCerrar.Id = 1;
            this.bbiCerrar.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("bbiCerrar.ImageOptions.SvgImage")));
            this.bbiCerrar.Name = "bbiCerrar";
            this.bbiCerrar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiCerrar_ItemClick);
            // 
            // bbiActualizar
            // 
            this.bbiActualizar.Caption = "Actualizar";
            this.bbiActualizar.Id = 2;
            this.bbiActualizar.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("bbiActualizar.ImageOptions.SvgImage")));
            this.bbiActualizar.Name = "bbiActualizar";
            this.bbiActualizar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiActualizar_ItemClick);
            // 
            // groupControl1
            // 
            this.groupControl1.AllowTouchScroll = true;
            this.groupControl1.Controls.Add(this.xtraScrollableControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 175);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1067, 541);
            this.groupControl1.TabIndex = 5;
            this.groupControl1.Text = "Informarción";
            // 
            // xtraScrollableControl1
            // 
            this.xtraScrollableControl1.Controls.Add(this.txteEmpleado);
            this.xtraScrollableControl1.Controls.Add(this.gdcDatos);
            this.xtraScrollableControl1.Controls.Add(this.labelControl10);
            this.xtraScrollableControl1.Controls.Add(this.txtUnidad);
            this.xtraScrollableControl1.Controls.Add(this.txtPuestos);
            this.xtraScrollableControl1.Controls.Add(this.txtDiasDisponibles);
            this.xtraScrollableControl1.Controls.Add(this.labelControl7);
            this.xtraScrollableControl1.Controls.Add(this.labelControl2);
            this.xtraScrollableControl1.Controls.Add(this.txtRelojMarcador);
            this.xtraScrollableControl1.Controls.Add(this.labelControl1);
            this.xtraScrollableControl1.Controls.Add(this.labelControl3);
            this.xtraScrollableControl1.Controls.Add(this.labelControl9);
            this.xtraScrollableControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraScrollableControl1.Location = new System.Drawing.Point(2, 29);
            this.xtraScrollableControl1.Name = "xtraScrollableControl1";
            this.xtraScrollableControl1.Size = new System.Drawing.Size(1063, 510);
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
            this.txtUnidad.Location = new System.Drawing.Point(180, 129);
            this.txtUnidad.MenuManager = this.ribbon;
            this.txtUnidad.Name = "txtUnidad";
            this.txtUnidad.Properties.Mask.EditMask = "*";
            this.txtUnidad.Properties.ReadOnly = true;
            this.txtUnidad.Size = new System.Drawing.Size(290, 28);
            this.txtUnidad.TabIndex = 109;
            // 
            // txtPuestos
            // 
            this.txtPuestos.Location = new System.Drawing.Point(180, 96);
            this.txtPuestos.MenuManager = this.ribbon;
            this.txtPuestos.Name = "txtPuestos";
            this.txtPuestos.Properties.Mask.EditMask = "*";
            this.txtPuestos.Properties.ReadOnly = true;
            this.txtPuestos.Size = new System.Drawing.Size(290, 28);
            this.txtPuestos.TabIndex = 108;
            // 
            // txtDiasDisponibles
            // 
            this.txtDiasDisponibles.Location = new System.Drawing.Point(180, 165);
            this.txtDiasDisponibles.MenuManager = this.ribbon;
            this.txtDiasDisponibles.Name = "txtDiasDisponibles";
            this.txtDiasDisponibles.Properties.Mask.EditMask = "*";
            this.txtDiasDisponibles.Properties.ReadOnly = true;
            this.txtDiasDisponibles.Size = new System.Drawing.Size(290, 28);
            this.txtDiasDisponibles.TabIndex = 99;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(36, 170);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(116, 19);
            this.labelControl7.TabIndex = 98;
            this.labelControl7.Text = "Dias Disponibles";
            this.labelControl7.ToolTipIconType = DevExpress.Utils.ToolTipIconType.WindLogo;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(36, 134);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(50, 19);
            this.labelControl2.TabIndex = 89;
            this.labelControl2.Text = "Unidad";
            this.labelControl2.ToolTipIconType = DevExpress.Utils.ToolTipIconType.WindLogo;
            // 
            // txtRelojMarcador
            // 
            this.txtRelojMarcador.Location = new System.Drawing.Point(180, 62);
            this.txtRelojMarcador.MenuManager = this.ribbon;
            this.txtRelojMarcador.Name = "txtRelojMarcador";
            this.txtRelojMarcador.Properties.ReadOnly = true;
            this.txtRelojMarcador.Size = new System.Drawing.Size(290, 28);
            this.txtRelojMarcador.TabIndex = 2;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(36, 67);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(136, 19);
            this.labelControl1.TabIndex = 84;
            this.labelControl1.Text = "No. Reloj Marcador";
            this.labelControl1.ToolTipIconType = DevExpress.Utils.ToolTipIconType.WindLogo;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(36, 32);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(70, 19);
            this.labelControl3.TabIndex = 3;
            this.labelControl3.Text = "Empleado";
            this.labelControl3.ToolTipIconType = DevExpress.Utils.ToolTipIconType.WindLogo;
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(36, 100);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(47, 19);
            this.labelControl9.TabIndex = 15;
            this.labelControl9.Text = "Puesto";
            this.labelControl9.ToolTipIconType = DevExpress.Utils.ToolTipIconType.WindLogo;
            // 
            // txteEmpleado
            // 
            this.txteEmpleado.Location = new System.Drawing.Point(180, 28);
            this.txteEmpleado.MenuManager = this.ribbon;
            this.txteEmpleado.Name = "txteEmpleado";
            this.txteEmpleado.Properties.ReadOnly = true;
            this.txteEmpleado.Size = new System.Drawing.Size(290, 28);
            this.txteEmpleado.TabIndex = 112;
            // 
            // ConsultaVacacionesEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 716);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.ribbon);
            this.Name = "ConsultaVacacionesEmpleado";
            this.Ribbon = this.ribbon;
            this.Text = "Consulta de Vacaciones de Empleado";
            this.Load += new System.EventHandler(this.ConsultaVacacionesEmpleado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.xtraScrollableControl1.ResumeLayout(false);
            this.xtraScrollableControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdcDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUnidad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPuestos.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiasDisponibles.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRelojMarcador.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txteEmpleado.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem bbiCerrar;
        private DevExpress.XtraBars.BarButtonItem bbiActualizar;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.XtraScrollableControl xtraScrollableControl1;
        private DevExpress.XtraEditors.TextEdit txteEmpleado;
        private DevExpress.XtraGrid.GridControl gdcDatos;
        private DevExpress.XtraGrid.Views.Grid.GridView gdvDatos;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.TextEdit txtUnidad;
        private DevExpress.XtraEditors.TextEdit txtPuestos;
        private DevExpress.XtraEditors.TextEdit txtDiasDisponibles;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtRelojMarcador;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl9;
    }
}