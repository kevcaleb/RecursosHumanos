namespace RecursosHumanos.Configuracion.Usuarios
{
    partial class ControlPrivilegios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ControlPrivilegios));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.bbiModificarPrivilegios = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.bbiCancelar = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.gdcPrivilegios = new DevExpress.XtraGrid.GridControl();
            this.gdvPrivilegios = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdcPrivilegios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvPrivilegios)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.bbiModificarPrivilegios,
            this.barButtonItem1,
            this.bbiCancelar});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
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
            this.ribbon.Size = new System.Drawing.Size(1153, 175);
            this.ribbon.Toolbar.ShowCustomizeItem = false;
            // 
            // bbiModificarPrivilegios
            // 
            this.bbiModificarPrivilegios.Caption = "Modificar Privilegios";
            this.bbiModificarPrivilegios.Id = 1;
            this.bbiModificarPrivilegios.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("bbitAgregarPermisosUsuario.ImageOptions.SvgImage")));
            this.bbiModificarPrivilegios.Name = "bbiModificarPrivilegios";
            this.bbiModificarPrivilegios.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiModificarPrivilegios_ItemClick);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "barButtonItem1";
            this.barButtonItem1.Id = 2;
            this.barButtonItem1.Name = "barButtonItem1";
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
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiModificarPrivilegios);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiCancelar);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Acciones";
            // 
            // gdcPrivilegios
            // 
            this.gdcPrivilegios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gdcPrivilegios.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gdcPrivilegios.Location = new System.Drawing.Point(0, 175);
            this.gdcPrivilegios.MainView = this.gdvPrivilegios;
            this.gdcPrivilegios.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gdcPrivilegios.MenuManager = this.ribbon;
            this.gdcPrivilegios.Name = "gdcPrivilegios";
            this.gdcPrivilegios.Size = new System.Drawing.Size(1153, 548);
            this.gdcPrivilegios.TabIndex = 6;
            this.gdcPrivilegios.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gdvPrivilegios});
            // 
            // gdvPrivilegios
            // 
            this.gdvPrivilegios.DetailHeight = 349;
            this.gdvPrivilegios.FixedLineWidth = 1;
            this.gdvPrivilegios.GridControl = this.gdcPrivilegios;
            this.gdvPrivilegios.Name = "gdvPrivilegios";
            this.gdvPrivilegios.OptionsMenu.ShowGroupSummaryEditorItem = true;
            this.gdvPrivilegios.OptionsView.ColumnAutoWidth = false;
            this.gdvPrivilegios.OptionsView.ShowFooter = true;
            // 
            // ControlPrivilegios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1153, 723);
            this.Controls.Add(this.gdcPrivilegios);
            this.Controls.Add(this.ribbon);
            this.Name = "ControlPrivilegios";
            this.Ribbon = this.ribbon;
            this.Text = "Control de Privilegios";
            this.Load += new System.EventHandler(this.ControlPrivilegios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdcPrivilegios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvPrivilegios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem bbiModificarPrivilegios;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraGrid.GridControl gdcPrivilegios;
        private DevExpress.XtraGrid.Views.Grid.GridView gdvPrivilegios;
        private DevExpress.XtraBars.BarButtonItem bbiCancelar;
    }
}