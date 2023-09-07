namespace RecursosHumanos.Empleados
{
    partial class ControlUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ControlUsuarios));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.bbiAgregarUsuario = new DevExpress.XtraBars.BarButtonItem();
            this.bbiEditarUsuario = new DevExpress.XtraBars.BarButtonItem();
            this.bbiEliminarUsuario = new DevExpress.XtraBars.BarButtonItem();
            this.bbiRefrescar = new DevExpress.XtraBars.BarButtonItem();
            this.bbitModificarPermisos = new DevExpress.XtraBars.BarButtonItem();
            this.bbiInactivarUsuario = new DevExpress.XtraBars.BarButtonItem();
            this.bbitActivar_Usuario = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.tncUsuarios = new DevExpress.XtraBars.Navigation.TabPane();
            this.tnpUsuariosActivos = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.gdcUsuariosActivos = new DevExpress.XtraGrid.GridControl();
            this.gdvUsuariosActivos = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.tnpUsuariosInactivos = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.gdcUsuariosInactivos = new DevExpress.XtraGrid.GridControl();
            this.gdvUsuariosInactivos = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tncUsuarios)).BeginInit();
            this.tncUsuarios.SuspendLayout();
            this.tnpUsuariosActivos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdcUsuariosActivos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvUsuariosActivos)).BeginInit();
            this.tnpUsuariosInactivos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdcUsuariosInactivos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvUsuariosInactivos)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.bbiAgregarUsuario,
            this.bbiEditarUsuario,
            this.bbiEliminarUsuario,
            this.bbiRefrescar,
            this.bbitModificarPermisos,
            this.bbiInactivarUsuario,
            this.bbitActivar_Usuario});
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
            this.ribbon.Size = new System.Drawing.Size(1186, 175);
            this.ribbon.Toolbar.ShowCustomizeItem = false;
            // 
            // bbiAgregarUsuario
            // 
            this.bbiAgregarUsuario.Caption = "Agregar Usuario";
            this.bbiAgregarUsuario.Id = 1;
            this.bbiAgregarUsuario.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("bbiAgregarUsuario.ImageOptions.SvgImage")));
            this.bbiAgregarUsuario.Name = "bbiAgregarUsuario";
            this.bbiAgregarUsuario.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiAgregarUsuario_ItemClick);
            // 
            // bbiEditarUsuario
            // 
            this.bbiEditarUsuario.Caption = "Editar Usuario";
            this.bbiEditarUsuario.Id = 2;
            this.bbiEditarUsuario.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("bbiEditarUsuario.ImageOptions.SvgImage")));
            this.bbiEditarUsuario.Name = "bbiEditarUsuario";
            this.bbiEditarUsuario.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiEditarUsuario_ItemClick);
            // 
            // bbiEliminarUsuario
            // 
            this.bbiEliminarUsuario.Caption = "Eliminar Usuario";
            this.bbiEliminarUsuario.Id = 3;
            this.bbiEliminarUsuario.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("bbiEliminarUsuario.ImageOptions.SvgImage")));
            this.bbiEliminarUsuario.Name = "bbiEliminarUsuario";
            this.bbiEliminarUsuario.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiEliminarUsuario_ItemClick);
            // 
            // bbiRefrescar
            // 
            this.bbiRefrescar.Caption = "Refrescar";
            this.bbiRefrescar.Id = 4;
            this.bbiRefrescar.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("bbiRefrescar.ImageOptions.SvgImage")));
            this.bbiRefrescar.Name = "bbiRefrescar";
            this.bbiRefrescar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiRefrescar_ItemClick);
            // 
            // bbitModificarPermisos
            // 
            this.bbitModificarPermisos.Caption = "Editar Permisos";
            this.bbitModificarPermisos.Id = 5;
            this.bbitModificarPermisos.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("bbitModificarPermisos.ImageOptions.SvgImage")));
            this.bbitModificarPermisos.Name = "bbitModificarPermisos";
            this.bbitModificarPermisos.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbitModificarPermisos_ItemClick);
            // 
            // bbiInactivarUsuario
            // 
            this.bbiInactivarUsuario.Caption = "Inactivar Usuario";
            this.bbiInactivarUsuario.Id = 6;
            this.bbiInactivarUsuario.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("bbiInactivarUsuario.ImageOptions.SvgImage")));
            this.bbiInactivarUsuario.Name = "bbiInactivarUsuario";
            this.bbiInactivarUsuario.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiInactivarUsuario_ItemClick);
            // 
            // bbitActivar_Usuario
            // 
            this.bbitActivar_Usuario.Caption = "Activar Usuario";
            this.bbitActivar_Usuario.Id = 7;
            this.bbitActivar_Usuario.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("bbitActivar_Usuario.ImageOptions.SvgImage")));
            this.bbitActivar_Usuario.Name = "bbitActivar_Usuario";
            this.bbitActivar_Usuario.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbitActivar_Usuario_ItemClick);
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
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiAgregarUsuario);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiEditarUsuario);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiEliminarUsuario);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiRefrescar);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbitModificarPermisos);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiInactivarUsuario);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbitActivar_Usuario);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Acciones";
            // 
            // tncUsuarios
            // 
            this.tncUsuarios.Controls.Add(this.tnpUsuariosActivos);
            this.tncUsuarios.Controls.Add(this.tnpUsuariosInactivos);
            this.tncUsuarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tncUsuarios.Location = new System.Drawing.Point(0, 175);
            this.tncUsuarios.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tncUsuarios.Name = "tncUsuarios";
            this.tncUsuarios.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.tnpUsuariosActivos,
            this.tnpUsuariosInactivos});
            this.tncUsuarios.RegularSize = new System.Drawing.Size(1186, 401);
            this.tncUsuarios.SelectedPage = this.tnpUsuariosActivos;
            this.tncUsuarios.Size = new System.Drawing.Size(1186, 401);
            this.tncUsuarios.TabIndex = 5;
            this.tncUsuarios.Text = "tabPane1";
            // 
            // tnpUsuariosActivos
            // 
            this.tnpUsuariosActivos.Caption = "Usuarios Activos";
            this.tnpUsuariosActivos.Controls.Add(this.gdcUsuariosActivos);
            this.tnpUsuariosActivos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tnpUsuariosActivos.Name = "tnpUsuariosActivos";
            this.tnpUsuariosActivos.Size = new System.Drawing.Size(1186, 362);
            // 
            // gdcUsuariosActivos
            // 
            this.gdcUsuariosActivos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gdcUsuariosActivos.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gdcUsuariosActivos.Location = new System.Drawing.Point(0, 0);
            this.gdcUsuariosActivos.MainView = this.gdvUsuariosActivos;
            this.gdcUsuariosActivos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gdcUsuariosActivos.MenuManager = this.ribbon;
            this.gdcUsuariosActivos.Name = "gdcUsuariosActivos";
            this.gdcUsuariosActivos.Size = new System.Drawing.Size(1186, 362);
            this.gdcUsuariosActivos.TabIndex = 0;
            this.gdcUsuariosActivos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gdvUsuariosActivos});
            // 
            // gdvUsuariosActivos
            // 
            this.gdvUsuariosActivos.DetailHeight = 349;
            this.gdvUsuariosActivos.FixedLineWidth = 1;
            this.gdvUsuariosActivos.GridControl = this.gdcUsuariosActivos;
            this.gdvUsuariosActivos.Name = "gdvUsuariosActivos";
            this.gdvUsuariosActivos.OptionsBehavior.Editable = false;
            this.gdvUsuariosActivos.OptionsMenu.ShowGroupSummaryEditorItem = true;
            this.gdvUsuariosActivos.OptionsView.ColumnAutoWidth = false;
            this.gdvUsuariosActivos.OptionsView.ShowFooter = true;
            // 
            // tnpUsuariosInactivos
            // 
            this.tnpUsuariosInactivos.Caption = "Usuarios Inactivos";
            this.tnpUsuariosInactivos.Controls.Add(this.gdcUsuariosInactivos);
            this.tnpUsuariosInactivos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tnpUsuariosInactivos.Name = "tnpUsuariosInactivos";
            this.tnpUsuariosInactivos.Size = new System.Drawing.Size(1186, 362);
            // 
            // gdcUsuariosInactivos
            // 
            this.gdcUsuariosInactivos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gdcUsuariosInactivos.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gdcUsuariosInactivos.Location = new System.Drawing.Point(0, 0);
            this.gdcUsuariosInactivos.MainView = this.gdvUsuariosInactivos;
            this.gdcUsuariosInactivos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gdcUsuariosInactivos.MenuManager = this.ribbon;
            this.gdcUsuariosInactivos.Name = "gdcUsuariosInactivos";
            this.gdcUsuariosInactivos.Size = new System.Drawing.Size(1186, 362);
            this.gdcUsuariosInactivos.TabIndex = 1;
            this.gdcUsuariosInactivos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gdvUsuariosInactivos});
            // 
            // gdvUsuariosInactivos
            // 
            this.gdvUsuariosInactivos.DetailHeight = 349;
            this.gdvUsuariosInactivos.FixedLineWidth = 1;
            this.gdvUsuariosInactivos.GridControl = this.gdcUsuariosInactivos;
            this.gdvUsuariosInactivos.Name = "gdvUsuariosInactivos";
            this.gdvUsuariosInactivos.OptionsBehavior.Editable = false;
            this.gdvUsuariosInactivos.OptionsMenu.ShowGroupSummaryEditorItem = true;
            this.gdvUsuariosInactivos.OptionsView.ColumnAutoWidth = false;
            this.gdvUsuariosInactivos.OptionsView.ShowFooter = true;
            // 
            // ControlUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1186, 576);
            this.Controls.Add(this.tncUsuarios);
            this.Controls.Add(this.ribbon);
            this.Name = "ControlUsuarios";
            this.Ribbon = this.ribbon;
            this.Text = "ControlUsuarios";
            this.Load += new System.EventHandler(this.ControlUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tncUsuarios)).EndInit();
            this.tncUsuarios.ResumeLayout(false);
            this.tnpUsuariosActivos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gdcUsuariosActivos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvUsuariosActivos)).EndInit();
            this.tnpUsuariosInactivos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gdcUsuariosInactivos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvUsuariosInactivos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem bbiAgregarUsuario;
        private DevExpress.XtraBars.BarButtonItem bbiEditarUsuario;
        private DevExpress.XtraBars.BarButtonItem bbiEliminarUsuario;
        private DevExpress.XtraBars.BarButtonItem bbiRefrescar;
        private DevExpress.XtraBars.BarButtonItem bbitModificarPermisos;
        private DevExpress.XtraBars.Navigation.TabPane tncUsuarios;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tnpUsuariosActivos;
        private DevExpress.XtraGrid.GridControl gdcUsuariosActivos;
        private DevExpress.XtraGrid.Views.Grid.GridView gdvUsuariosActivos;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tnpUsuariosInactivos;
        private DevExpress.XtraGrid.GridControl gdcUsuariosInactivos;
        private DevExpress.XtraGrid.Views.Grid.GridView gdvUsuariosInactivos;
        private DevExpress.XtraBars.BarButtonItem bbiInactivarUsuario;
        private DevExpress.XtraBars.BarButtonItem bbitActivar_Usuario;
    }
}