namespace RecursosHumanos
{
    partial class frmPrincipal
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
            DevExpress.XtraEditors.TileItemElement tileItemElement2 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement1 = new DevExpress.XtraEditors.TileItemElement();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            DevExpress.XtraEditors.TileItemElement tileItemElement5 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement3 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement4 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement6 = new DevExpress.XtraEditors.TileItemElement();
            this.toastNotificationsManager1 = new DevExpress.XtraBars.ToastNotifications.ToastNotificationsManager(this.components);
            this.alertControl1 = new DevExpress.XtraBars.Alerter.AlertControl(this.components);
            this.tileNavPane1 = new DevExpress.XtraBars.Navigation.TileNavPane();
            this.navButton2 = new DevExpress.XtraBars.Navigation.NavButton();
            this.tncConfiguracion = new DevExpress.XtraBars.Navigation.TileNavCategory();
            this.tniUsuarios = new DevExpress.XtraBars.Navigation.TileNavItem();
            this.tncEmpleados = new DevExpress.XtraBars.Navigation.TileNavCategory();
            this.tniControlEmpleados = new DevExpress.XtraBars.Navigation.TileNavItem();
            this.tniControlPermisos = new DevExpress.XtraBars.Navigation.TileNavItem();
            this.tncPlanilla = new DevExpress.XtraBars.Navigation.TileNavCategory();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.toastNotificationsManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileNavPane1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // toastNotificationsManager1
            // 
            this.toastNotificationsManager1.ApplicationId = "42677224-1750-4090-b67b-2a19ae2616b1";
            // 
            // alertControl1
            // 
            this.alertControl1.AutoFormDelay = 5000;
            // 
            // tileNavPane1
            // 
            this.tileNavPane1.BackColor = System.Drawing.Color.SteelBlue;
            this.tileNavPane1.Buttons.Add(this.navButton2);
            this.tileNavPane1.Categories.AddRange(new DevExpress.XtraBars.Navigation.TileNavCategory[] {
            this.tncConfiguracion,
            this.tncEmpleados,
            this.tncPlanilla});
            this.tileNavPane1.ContinuousNavigation = true;
            // 
            // tileNavCategory1
            // 
            this.tileNavPane1.DefaultCategory.Name = "tileNavCategory1";
            // 
            // 
            // 
            this.tileNavPane1.DefaultCategory.Tile.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            this.tileNavPane1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tileNavPane1.Location = new System.Drawing.Point(0, 0);
            this.tileNavPane1.Name = "tileNavPane1";
            this.tileNavPane1.Size = new System.Drawing.Size(1718, 40);
            this.tileNavPane1.TabIndex = 1;
            this.tileNavPane1.Text = "tnpMenu";
            // 
            // navButton2
            // 
            this.navButton2.Caption = "Recursos Humanos ";
            this.navButton2.IsMain = true;
            this.navButton2.Name = "navButton2";
            // 
            // tncConfiguracion
            // 
            this.tncConfiguracion.Caption = "Configuracion";
            this.tncConfiguracion.Items.AddRange(new DevExpress.XtraBars.Navigation.TileNavItem[] {
            this.tniUsuarios});
            this.tncConfiguracion.Name = "tncConfiguracion";
            // 
            // 
            // 
            this.tncConfiguracion.Tile.AppearanceItem.Normal.BackColor = System.Drawing.Color.DarkGreen;
            this.tncConfiguracion.Tile.AppearanceItem.Normal.ForeColor = System.Drawing.Color.White;
            this.tncConfiguracion.Tile.AppearanceItem.Normal.Options.UseBackColor = true;
            this.tncConfiguracion.Tile.AppearanceItem.Normal.Options.UseForeColor = true;
            this.tncConfiguracion.Tile.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            tileItemElement2.Text = "Configuracion";
            tileItemElement2.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.BottomRight;
            this.tncConfiguracion.Tile.Elements.Add(tileItemElement2);
            this.tncConfiguracion.Tile.Name = "tileBarItem2";
            // 
            // tniUsuarios
            // 
            this.tniUsuarios.Caption = "Usuarios";
            this.tniUsuarios.Name = "tniUsuarios";
            // 
            // 
            // 
            this.tniUsuarios.Tile.AppearanceItem.Normal.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.tniUsuarios.Tile.AppearanceItem.Normal.ForeColor = System.Drawing.Color.White;
            this.tniUsuarios.Tile.AppearanceItem.Normal.Options.UseBackColor = true;
            this.tniUsuarios.Tile.AppearanceItem.Normal.Options.UseForeColor = true;
            this.tniUsuarios.Tile.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            tileItemElement1.Text = "Usuarios";
            this.tniUsuarios.Tile.Elements.Add(tileItemElement1);
            this.tniUsuarios.Tile.Name = "tileBarItem1";
            // 
            // tncEmpleados
            // 
            this.tncEmpleados.Caption = "Empleados";
            this.tncEmpleados.Items.AddRange(new DevExpress.XtraBars.Navigation.TileNavItem[] {
            this.tniControlEmpleados,
            this.tniControlPermisos});
            this.tncEmpleados.Name = "tncEmpleados";
            // 
            // 
            // 
            this.tncEmpleados.Tile.AppearanceItem.Normal.BackColor = System.Drawing.Color.SaddleBrown;
            this.tncEmpleados.Tile.AppearanceItem.Normal.ForeColor = System.Drawing.Color.White;
            this.tncEmpleados.Tile.AppearanceItem.Normal.Options.UseBackColor = true;
            this.tncEmpleados.Tile.AppearanceItem.Normal.Options.UseForeColor = true;
            this.tncEmpleados.Tile.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement5.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image2")));
            tileItemElement5.Text = "Empleados";
            tileItemElement5.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.BottomRight;
            this.tncEmpleados.Tile.Elements.Add(tileItemElement5);
            this.tncEmpleados.Tile.Name = "tileBarItem3";
            // 
            // tniControlEmpleados
            // 
            this.tniControlEmpleados.Caption = "Control de Empleados";
            this.tniControlEmpleados.Name = "tniControlEmpleados";
            // 
            // 
            // 
            this.tniControlEmpleados.Tile.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement3.Text = "Control de Empleados";
            this.tniControlEmpleados.Tile.Elements.Add(tileItemElement3);
            this.tniControlEmpleados.Tile.Name = "tileBarItem1";
            this.tniControlEmpleados.TileClick += new DevExpress.XtraBars.Navigation.NavElementClickEventHandler(this.tniControlEmpleados_TileClick);
            // 
            // tniControlPermisos
            // 
            this.tniControlPermisos.Caption = "Control Permisos";
            this.tniControlPermisos.Name = "tniControlPermisos";
            // 
            // 
            // 
            this.tniControlPermisos.Tile.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement4.Text = "Control de Permisos";
            this.tniControlPermisos.Tile.Elements.Add(tileItemElement4);
            this.tniControlPermisos.Tile.Name = "tileBarItem2";
            this.tniControlPermisos.TileClick += new DevExpress.XtraBars.Navigation.NavElementClickEventHandler(this.tniControlPermisos_TileClick);
            // 
            // tncPlanilla
            // 
            this.tncPlanilla.Caption = "Planillas";
            this.tncPlanilla.Name = "tncPlanilla";
            // 
            // 
            // 
            this.tncPlanilla.Tile.AppearanceItem.Normal.BackColor = System.Drawing.Color.Maroon;
            this.tncPlanilla.Tile.AppearanceItem.Normal.Options.UseBackColor = true;
            this.tncPlanilla.Tile.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement6.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image3")));
            tileItemElement6.Text = "              Planillas";
            this.tncPlanilla.Tile.Elements.Add(tileItemElement6);
            this.tncPlanilla.Tile.Name = "tileBarItem4";
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.ClosePageButtonShowMode = DevExpress.XtraTab.ClosePageButtonShowMode.InAllTabPageHeaders;
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // frmPrincipal
            // 
            this.AllowMdiBar = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1718, 956);
            this.Controls.Add(this.tileNavPane1);
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmPrincipal";
            this.ShowIcon = false;
            this.ShowMdiChildCaptionInParentTitle = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmPrincipal_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.toastNotificationsManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileNavPane1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.ToastNotifications.ToastNotificationsManager toastNotificationsManager1;
        public DevExpress.XtraBars.Alerter.AlertControl alertControl1;
        private DevExpress.XtraBars.Navigation.TileNavPane tileNavPane1;
        private DevExpress.XtraBars.Navigation.NavButton navButton2;
        private DevExpress.XtraBars.Navigation.TileNavCategory tncConfiguracion;
        private DevExpress.XtraBars.Navigation.TileNavCategory tncEmpleados;
        private DevExpress.XtraBars.Navigation.TileNavCategory tncPlanilla;
        private DevExpress.XtraBars.Navigation.TileNavItem tniUsuarios;
        private DevExpress.XtraBars.Navigation.TileNavItem tniControlEmpleados;
        private DevExpress.XtraBars.Navigation.TileNavItem tniControlPermisos;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
    }
}

