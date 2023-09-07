namespace RecursosHumanos.Empleados
{
    partial class ControlEmpleados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ControlEmpleados));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.bbiNuevoEmpleado = new DevExpress.XtraBars.BarButtonItem();
            this.bbiEditarEmpleado = new DevExpress.XtraBars.BarButtonItem();
            this.bbiEliminarEmpleado = new DevExpress.XtraBars.BarButtonItem();
            this.bbiRefrescar = new DevExpress.XtraBars.BarButtonItem();
            this.bbiInactivarEmpleado = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.tncEmpelados = new DevExpress.XtraBars.Navigation.TabPane();
            this.tnpEmpleadosActivos = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.gdcEmpleadosActivos = new DevExpress.XtraGrid.GridControl();
            this.gdvEmpleadosActivos = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.tnpEmpleadosInactivos = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.gdcEmpleadosInactivos = new DevExpress.XtraGrid.GridControl();
            this.gdvEmpleadosInactivos = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tncEmpelados)).BeginInit();
            this.tncEmpelados.SuspendLayout();
            this.tnpEmpleadosActivos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdcEmpleadosActivos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvEmpleadosActivos)).BeginInit();
            this.tnpEmpleadosInactivos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdcEmpleadosInactivos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvEmpleadosInactivos)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.bbiNuevoEmpleado,
            this.bbiEditarEmpleado,
            this.bbiEliminarEmpleado,
            this.bbiRefrescar,
            this.bbiInactivarEmpleado});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ribbon.MaxItemId = 6;
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
            this.ribbon.Size = new System.Drawing.Size(1226, 175);
            this.ribbon.Toolbar.ShowCustomizeItem = false;
            this.ribbon.Click += new System.EventHandler(this.ribbon_Click);
            // 
            // bbiNuevoEmpleado
            // 
            this.bbiNuevoEmpleado.Caption = "Nuevo Empleado";
            this.bbiNuevoEmpleado.Id = 1;
            this.bbiNuevoEmpleado.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("bbiNuevoEmpleado.ImageOptions.SvgImage")));
            this.bbiNuevoEmpleado.Name = "bbiNuevoEmpleado";
            this.bbiNuevoEmpleado.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiNuevoEmpleado_ItemClick);
            // 
            // bbiEditarEmpleado
            // 
            this.bbiEditarEmpleado.Caption = "Editar Empleado";
            this.bbiEditarEmpleado.Id = 2;
            this.bbiEditarEmpleado.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("bbiEditarEmpleado.ImageOptions.SvgImage")));
            this.bbiEditarEmpleado.Name = "bbiEditarEmpleado";
            this.bbiEditarEmpleado.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiEditarEmpleado_ItemClick);
            // 
            // bbiEliminarEmpleado
            // 
            this.bbiEliminarEmpleado.Caption = "Eliminar Empleado";
            this.bbiEliminarEmpleado.Id = 3;
            this.bbiEliminarEmpleado.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("bbiEliminarEmpleado.ImageOptions.SvgImage")));
            this.bbiEliminarEmpleado.Name = "bbiEliminarEmpleado";
            this.bbiEliminarEmpleado.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiEliminarEmpleado_ItemClick);
            // 
            // bbiRefrescar
            // 
            this.bbiRefrescar.Caption = "Refrescar";
            this.bbiRefrescar.Id = 4;
            this.bbiRefrescar.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("bbiRefrescar.ImageOptions.SvgImage")));
            this.bbiRefrescar.Name = "bbiRefrescar";
            this.bbiRefrescar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiRefrescar_ItemClick);
            // 
            // bbiInactivarEmpleado
            // 
            this.bbiInactivarEmpleado.Caption = "Inactivar Empleado";
            this.bbiInactivarEmpleado.Id = 5;
            this.bbiInactivarEmpleado.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("bbiInactivarEmpleado.ImageOptions.SvgImage")));
            this.bbiInactivarEmpleado.Name = "bbiInactivarEmpleado";
            this.bbiInactivarEmpleado.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiInactivarEmpleado_ItemClick);
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
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiNuevoEmpleado);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiEditarEmpleado);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiEliminarEmpleado);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiRefrescar);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiInactivarEmpleado);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Acciones";
            // 
            // tncEmpelados
            // 
            this.tncEmpelados.Controls.Add(this.tnpEmpleadosActivos);
            this.tncEmpelados.Controls.Add(this.tnpEmpleadosInactivos);
            this.tncEmpelados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tncEmpelados.Location = new System.Drawing.Point(0, 175);
            this.tncEmpelados.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tncEmpelados.Name = "tncEmpelados";
            this.tncEmpelados.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.tnpEmpleadosActivos,
            this.tnpEmpleadosInactivos});
            this.tncEmpelados.RegularSize = new System.Drawing.Size(1226, 395);
            this.tncEmpelados.SelectedPage = this.tnpEmpleadosActivos;
            this.tncEmpelados.Size = new System.Drawing.Size(1226, 395);
            this.tncEmpelados.TabIndex = 2;
            this.tncEmpelados.Text = "tabPane1";
            // 
            // tnpEmpleadosActivos
            // 
            this.tnpEmpleadosActivos.Caption = "Empleados Activos";
            this.tnpEmpleadosActivos.Controls.Add(this.gdcEmpleadosActivos);
            this.tnpEmpleadosActivos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tnpEmpleadosActivos.Name = "tnpEmpleadosActivos";
            this.tnpEmpleadosActivos.Size = new System.Drawing.Size(1226, 356);
            // 
            // gdcEmpleadosActivos
            // 
            this.gdcEmpleadosActivos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gdcEmpleadosActivos.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gdcEmpleadosActivos.Location = new System.Drawing.Point(0, 0);
            this.gdcEmpleadosActivos.MainView = this.gdvEmpleadosActivos;
            this.gdcEmpleadosActivos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gdcEmpleadosActivos.MenuManager = this.ribbon;
            this.gdcEmpleadosActivos.Name = "gdcEmpleadosActivos";
            this.gdcEmpleadosActivos.Size = new System.Drawing.Size(1226, 356);
            this.gdcEmpleadosActivos.TabIndex = 0;
            this.gdcEmpleadosActivos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gdvEmpleadosActivos});
            // 
            // gdvEmpleadosActivos
            // 
            this.gdvEmpleadosActivos.DetailHeight = 349;
            this.gdvEmpleadosActivos.FixedLineWidth = 1;
            this.gdvEmpleadosActivos.GridControl = this.gdcEmpleadosActivos;
            this.gdvEmpleadosActivos.Name = "gdvEmpleadosActivos";
            this.gdvEmpleadosActivos.OptionsBehavior.Editable = false;
            this.gdvEmpleadosActivos.OptionsMenu.ShowGroupSummaryEditorItem = true;
            this.gdvEmpleadosActivos.OptionsView.ColumnAutoWidth = false;
            this.gdvEmpleadosActivos.OptionsView.ShowFooter = true;
            // 
            // tnpEmpleadosInactivos
            // 
            this.tnpEmpleadosInactivos.Caption = "Empleados Inactivos";
            this.tnpEmpleadosInactivos.Controls.Add(this.gdcEmpleadosInactivos);
            this.tnpEmpleadosInactivos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tnpEmpleadosInactivos.Name = "tnpEmpleadosInactivos";
            this.tnpEmpleadosInactivos.Size = new System.Drawing.Size(1226, 356);
            // 
            // gdcEmpleadosInactivos
            // 
            this.gdcEmpleadosInactivos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gdcEmpleadosInactivos.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gdcEmpleadosInactivos.Location = new System.Drawing.Point(0, 0);
            this.gdcEmpleadosInactivos.MainView = this.gdvEmpleadosInactivos;
            this.gdcEmpleadosInactivos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gdcEmpleadosInactivos.MenuManager = this.ribbon;
            this.gdcEmpleadosInactivos.Name = "gdcEmpleadosInactivos";
            this.gdcEmpleadosInactivos.Size = new System.Drawing.Size(1226, 356);
            this.gdcEmpleadosInactivos.TabIndex = 1;
            this.gdcEmpleadosInactivos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gdvEmpleadosInactivos});
            // 
            // gdvEmpleadosInactivos
            // 
            this.gdvEmpleadosInactivos.DetailHeight = 349;
            this.gdvEmpleadosInactivos.FixedLineWidth = 1;
            this.gdvEmpleadosInactivos.GridControl = this.gdcEmpleadosInactivos;
            this.gdvEmpleadosInactivos.Name = "gdvEmpleadosInactivos";
            this.gdvEmpleadosInactivos.OptionsBehavior.Editable = false;
            this.gdvEmpleadosInactivos.OptionsMenu.ShowGroupSummaryEditorItem = true;
            this.gdvEmpleadosInactivos.OptionsView.ShowFooter = true;
            // 
            // ControlEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1226, 570);
            this.Controls.Add(this.tncEmpelados);
            this.Controls.Add(this.ribbon);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ControlEmpleados";
            this.Ribbon = this.ribbon;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Control de Empleados";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ControlEmpleados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tncEmpelados)).EndInit();
            this.tncEmpelados.ResumeLayout(false);
            this.tnpEmpleadosActivos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gdcEmpleadosActivos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvEmpleadosActivos)).EndInit();
            this.tnpEmpleadosInactivos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gdcEmpleadosInactivos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvEmpleadosInactivos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem bbiNuevoEmpleado;
        private DevExpress.XtraBars.BarButtonItem bbiEditarEmpleado;
        private DevExpress.XtraBars.BarButtonItem bbiEliminarEmpleado;
        private DevExpress.XtraBars.Navigation.TabPane tncEmpelados;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tnpEmpleadosActivos;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tnpEmpleadosInactivos;
        private DevExpress.XtraGrid.GridControl gdcEmpleadosActivos;
        private DevExpress.XtraGrid.Views.Grid.GridView gdvEmpleadosActivos;
        private DevExpress.XtraGrid.GridControl gdcEmpleadosInactivos;
        private DevExpress.XtraGrid.Views.Grid.GridView gdvEmpleadosInactivos;
        private DevExpress.XtraBars.BarButtonItem bbiRefrescar;
        private DevExpress.XtraBars.BarButtonItem bbiInactivarEmpleado;
    }
}