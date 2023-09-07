namespace RecursosHumanos.Empleados
{
    partial class ControlPermisos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ControlPermisos));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.bbiNuevoPermiso = new DevExpress.XtraBars.BarButtonItem();
            this.bbiRefrescar = new DevExpress.XtraBars.BarButtonItem();
            this.bbiAutorizar = new DevExpress.XtraBars.BarButtonItem();
            this.bbiRechazar = new DevExpress.XtraBars.BarButtonItem();
            this.bbiExportar = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.tncPermisos = new DevExpress.XtraBars.Navigation.TabPane();
            this.tnpPendientes = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.gdcPendientes = new DevExpress.XtraGrid.GridControl();
            this.gdvPendientes = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.tnpAutorizados = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.gdcAutorizados = new DevExpress.XtraGrid.GridControl();
            this.gdvAutorizados = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.tnpRechazados = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.gdcRechazados = new DevExpress.XtraGrid.GridControl();
            this.gdvRechazados = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.bbiImprimir = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tncPermisos)).BeginInit();
            this.tncPermisos.SuspendLayout();
            this.tnpPendientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdcPendientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvPendientes)).BeginInit();
            this.tnpAutorizados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdcAutorizados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvAutorizados)).BeginInit();
            this.tnpRechazados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdcRechazados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvRechazados)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.bbiNuevoPermiso,
            this.bbiRefrescar,
            this.bbiAutorizar,
            this.bbiRechazar,
            this.bbiExportar,
            this.bbiImprimir});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 8;
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
            this.ribbon.Size = new System.Drawing.Size(1268, 175);
            this.ribbon.Toolbar.ShowCustomizeItem = false;
            // 
            // bbiNuevoPermiso
            // 
            this.bbiNuevoPermiso.Caption = "Nuevo Permiso";
            this.bbiNuevoPermiso.Id = 2;
            this.bbiNuevoPermiso.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("bbiNuevoPermiso.ImageOptions.SvgImage")));
            this.bbiNuevoPermiso.Name = "bbiNuevoPermiso";
            this.bbiNuevoPermiso.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiNuevoPermiso_ItemClick);
            // 
            // bbiRefrescar
            // 
            this.bbiRefrescar.Caption = "Refrescar";
            this.bbiRefrescar.Id = 3;
            this.bbiRefrescar.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("bbiRefrescar.ImageOptions.SvgImage")));
            this.bbiRefrescar.Name = "bbiRefrescar";
            // 
            // bbiAutorizar
            // 
            this.bbiAutorizar.Caption = "Autorizar";
            this.bbiAutorizar.Id = 4;
            this.bbiAutorizar.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("bbiAutorizar.ImageOptions.SvgImage")));
            this.bbiAutorizar.Name = "bbiAutorizar";
            this.bbiAutorizar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiAprobar_ItemClick);
            // 
            // bbiRechazar
            // 
            this.bbiRechazar.Caption = "Rechazar";
            this.bbiRechazar.Id = 5;
            this.bbiRechazar.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("bbiRechazar.ImageOptions.SvgImage")));
            this.bbiRechazar.Name = "bbiRechazar";
            this.bbiRechazar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiRechazar_ItemClick);
            // 
            // bbiExportar
            // 
            this.bbiExportar.Caption = "Exportar";
            this.bbiExportar.Id = 6;
            this.bbiExportar.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("bbiExportar.ImageOptions.SvgImage")));
            this.bbiExportar.Name = "bbiExportar";
            this.bbiExportar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiExportar_ItemClick);
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
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiNuevoPermiso);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiRefrescar);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiImprimir);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiAutorizar);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiRechazar);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiExportar);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Acciones";
            // 
            // tncPermisos
            // 
            this.tncPermisos.Controls.Add(this.tnpPendientes);
            this.tncPermisos.Controls.Add(this.tnpAutorizados);
            this.tncPermisos.Controls.Add(this.tnpRechazados);
            this.tncPermisos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tncPermisos.Location = new System.Drawing.Point(0, 175);
            this.tncPermisos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tncPermisos.Name = "tncPermisos";
            this.tncPermisos.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.tnpPendientes,
            this.tnpAutorizados,
            this.tnpRechazados});
            this.tncPermisos.RegularSize = new System.Drawing.Size(1268, 546);
            this.tncPermisos.SelectedPage = this.tnpPendientes;
            this.tncPermisos.Size = new System.Drawing.Size(1268, 546);
            this.tncPermisos.TabIndex = 5;
            this.tncPermisos.Text = "tabPane1";
            // 
            // tnpPendientes
            // 
            this.tnpPendientes.Caption = "Permisos Pendientes";
            this.tnpPendientes.Controls.Add(this.gdcPendientes);
            this.tnpPendientes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tnpPendientes.Name = "tnpPendientes";
            this.tnpPendientes.Size = new System.Drawing.Size(1268, 507);
            // 
            // gdcPendientes
            // 
            this.gdcPendientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gdcPendientes.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gdcPendientes.Location = new System.Drawing.Point(0, 0);
            this.gdcPendientes.MainView = this.gdvPendientes;
            this.gdcPendientes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gdcPendientes.MenuManager = this.ribbon;
            this.gdcPendientes.Name = "gdcPendientes";
            this.gdcPendientes.Size = new System.Drawing.Size(1268, 507);
            this.gdcPendientes.TabIndex = 0;
            this.gdcPendientes.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gdvPendientes});
            // 
            // gdvPendientes
            // 
            this.gdvPendientes.DetailHeight = 349;
            this.gdvPendientes.FixedLineWidth = 1;
            this.gdvPendientes.GridControl = this.gdcPendientes;
            this.gdvPendientes.Name = "gdvPendientes";
            this.gdvPendientes.OptionsBehavior.Editable = false;
            this.gdvPendientes.OptionsMenu.ShowGroupSummaryEditorItem = true;
            this.gdvPendientes.OptionsView.ColumnAutoWidth = false;
            this.gdvPendientes.OptionsView.ShowFooter = true;
            // 
            // tnpAutorizados
            // 
            this.tnpAutorizados.Caption = "Permisos Autorizados";
            this.tnpAutorizados.Controls.Add(this.gdcAutorizados);
            this.tnpAutorizados.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tnpAutorizados.Name = "tnpAutorizados";
            this.tnpAutorizados.Size = new System.Drawing.Size(1268, 507);
            // 
            // gdcAutorizados
            // 
            this.gdcAutorizados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gdcAutorizados.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gdcAutorizados.Location = new System.Drawing.Point(0, 0);
            this.gdcAutorizados.MainView = this.gdvAutorizados;
            this.gdcAutorizados.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gdcAutorizados.MenuManager = this.ribbon;
            this.gdcAutorizados.Name = "gdcAutorizados";
            this.gdcAutorizados.Size = new System.Drawing.Size(1268, 507);
            this.gdcAutorizados.TabIndex = 1;
            this.gdcAutorizados.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gdvAutorizados});
            // 
            // gdvAutorizados
            // 
            this.gdvAutorizados.DetailHeight = 349;
            this.gdvAutorizados.FixedLineWidth = 1;
            this.gdvAutorizados.GridControl = this.gdcAutorizados;
            this.gdvAutorizados.Name = "gdvAutorizados";
            this.gdvAutorizados.OptionsBehavior.Editable = false;
            this.gdvAutorizados.OptionsMenu.ShowGroupSummaryEditorItem = true;
            this.gdvAutorizados.OptionsView.ShowFooter = true;
            // 
            // tnpRechazados
            // 
            this.tnpRechazados.Caption = "Permisos Rechazados";
            this.tnpRechazados.Controls.Add(this.gdcRechazados);
            this.tnpRechazados.Name = "tnpRechazados";
            this.tnpRechazados.Size = new System.Drawing.Size(1268, 507);
            // 
            // gdcRechazados
            // 
            this.gdcRechazados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gdcRechazados.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gdcRechazados.Location = new System.Drawing.Point(0, 0);
            this.gdcRechazados.MainView = this.gdvRechazados;
            this.gdcRechazados.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gdcRechazados.MenuManager = this.ribbon;
            this.gdcRechazados.Name = "gdcRechazados";
            this.gdcRechazados.Size = new System.Drawing.Size(1268, 507);
            this.gdcRechazados.TabIndex = 2;
            this.gdcRechazados.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gdvRechazados});
            // 
            // gdvRechazados
            // 
            this.gdvRechazados.DetailHeight = 349;
            this.gdvRechazados.FixedLineWidth = 1;
            this.gdvRechazados.GridControl = this.gdcRechazados;
            this.gdvRechazados.Name = "gdvRechazados";
            this.gdvRechazados.OptionsBehavior.Editable = false;
            this.gdvRechazados.OptionsMenu.ShowGroupSummaryEditorItem = true;
            this.gdvRechazados.OptionsView.ShowFooter = true;
            // 
            // bbiImprimir
            // 
            this.bbiImprimir.Caption = "Imprimir";
            this.bbiImprimir.Id = 7;
            this.bbiImprimir.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("bbiImprimir.ImageOptions.SvgImage")));
            this.bbiImprimir.Name = "bbiImprimir";
            this.bbiImprimir.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiImprimir_ItemClick);
            // 
            // ControlPermisos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1268, 721);
            this.Controls.Add(this.tncPermisos);
            this.Controls.Add(this.ribbon);
            this.Name = "ControlPermisos";
            this.Ribbon = this.ribbon;
            this.Text = "ControlPermisos";
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tncPermisos)).EndInit();
            this.tncPermisos.ResumeLayout(false);
            this.tnpPendientes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gdcPendientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvPendientes)).EndInit();
            this.tnpAutorizados.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gdcAutorizados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvAutorizados)).EndInit();
            this.tnpRechazados.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gdcRechazados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvRechazados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Navigation.TabPane tncPermisos;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tnpPendientes;
        private DevExpress.XtraGrid.GridControl gdcPendientes;
        private DevExpress.XtraGrid.Views.Grid.GridView gdvPendientes;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tnpAutorizados;
        private DevExpress.XtraGrid.GridControl gdcAutorizados;
        private DevExpress.XtraGrid.Views.Grid.GridView gdvAutorizados;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tnpRechazados;
        private DevExpress.XtraGrid.GridControl gdcRechazados;
        private DevExpress.XtraGrid.Views.Grid.GridView gdvRechazados;
        private DevExpress.XtraBars.BarButtonItem bbiNuevoPermiso;
        private DevExpress.XtraBars.BarButtonItem bbiRefrescar;
        private DevExpress.XtraBars.BarButtonItem bbiAutorizar;
        private DevExpress.XtraBars.BarButtonItem bbiRechazar;
        private DevExpress.XtraBars.BarButtonItem bbiExportar;
        private DevExpress.XtraBars.BarButtonItem bbiImprimir;
    }
}