namespace RecursosHumanos.Empleados
{
    partial class ControlPlanillas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ControlPlanillas));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.tnpPlanillas = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.gdcPlanillas = new DevExpress.XtraGrid.GridControl();
            this.gdvPlanillas = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.tncPlanillas = new DevExpress.XtraBars.Navigation.TabPane();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.tnpPlanillas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdcPlanillas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvPlanillas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tncPlanillas)).BeginInit();
            this.tncPlanillas.SuspendLayout();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.barButtonItem1});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ribbon.MaxItemId = 2;
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
            this.ribbon.Size = new System.Drawing.Size(742, 122);
            this.ribbon.Toolbar.ShowCustomizeItem = false;
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Agregar Nueva Planilla";
            this.barButtonItem1.Id = 1;
            this.barButtonItem1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem1.ImageOptions.SvgImage")));
            this.barButtonItem1.Name = "barButtonItem1";
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
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem1);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Acciones";
            // 
            // gridView1
            // 
            this.gridView1.Name = "gridView1";
            // 
            // tnpPlanillas
            // 
            this.tnpPlanillas.Caption = "Planillas";
            this.tnpPlanillas.Controls.Add(this.gdcPlanillas);
            this.tnpPlanillas.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tnpPlanillas.Name = "tnpPlanillas";
            this.tnpPlanillas.Size = new System.Drawing.Size(742, 324);
            // 
            // gdcPlanillas
            // 
            this.gdcPlanillas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gdcPlanillas.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gdcPlanillas.Location = new System.Drawing.Point(0, 0);
            this.gdcPlanillas.MainView = this.gdvPlanillas;
            this.gdcPlanillas.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gdcPlanillas.MenuManager = this.ribbon;
            this.gdcPlanillas.Name = "gdcPlanillas";
            this.gdcPlanillas.Size = new System.Drawing.Size(742, 324);
            this.gdcPlanillas.TabIndex = 0;
            this.gdcPlanillas.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gdvPlanillas,
            this.gridView2});
            // 
            // gdvPlanillas
            // 
            this.gdvPlanillas.DetailHeight = 239;
            this.gdvPlanillas.FixedLineWidth = 1;
            this.gdvPlanillas.GridControl = this.gdcPlanillas;
            this.gdvPlanillas.Name = "gdvPlanillas";
            this.gdvPlanillas.OptionsBehavior.Editable = false;
            this.gdvPlanillas.OptionsMenu.ShowGroupSummaryEditorItem = true;
            this.gdvPlanillas.OptionsView.ColumnAutoWidth = false;
            this.gdvPlanillas.OptionsView.ShowFooter = true;
            // 
            // gridView2
            // 
            this.gridView2.DetailHeight = 239;
            this.gridView2.FixedLineWidth = 1;
            this.gridView2.GridControl = this.gdcPlanillas;
            this.gridView2.Name = "gridView2";
            // 
            // tncPlanillas
            // 
            this.tncPlanillas.Controls.Add(this.tnpPlanillas);
            this.tncPlanillas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tncPlanillas.Location = new System.Drawing.Point(0, 122);
            this.tncPlanillas.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tncPlanillas.Name = "tncPlanillas";
            this.tncPlanillas.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.tnpPlanillas});
            this.tncPlanillas.RegularSize = new System.Drawing.Size(742, 351);
            this.tncPlanillas.SelectedPage = this.tnpPlanillas;
            this.tncPlanillas.Size = new System.Drawing.Size(742, 351);
            this.tncPlanillas.TabIndex = 6;
            this.tncPlanillas.Text = "tabPane1";
            // 
            // ControlPlanillas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 473);
            this.Controls.Add(this.tncPlanillas);
            this.Controls.Add(this.ribbon);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ControlPlanillas";
            this.Ribbon = this.ribbon;
            this.Text = "Control Planillas";
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.tnpPlanillas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gdcPlanillas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvPlanillas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tncPlanillas)).EndInit();
            this.tncPlanillas.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tnpPlanillas;
        private DevExpress.XtraGrid.GridControl gdcPlanillas;
        private DevExpress.XtraGrid.Views.Grid.GridView gdvPlanillas;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraBars.Navigation.TabPane tncPlanillas;
    }
}