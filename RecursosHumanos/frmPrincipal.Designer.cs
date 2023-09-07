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
            DevExpress.XtraBars.Alerter.AlertButton alertButton11 = new DevExpress.XtraBars.Alerter.AlertButton();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            DevExpress.XtraBars.Alerter.AlertButton alertButton12 = new DevExpress.XtraBars.Alerter.AlertButton();
            DevExpress.XtraEditors.TileItemElement tileItemElement41 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement43 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement42 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement47 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement44 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement45 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement46 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement48 = new DevExpress.XtraEditors.TileItemElement();
            this.alertControl1 = new DevExpress.XtraBars.Alerter.AlertControl(this.components);
            this.tileNavPane1 = new DevExpress.XtraBars.Navigation.TileNavPane();
            this.navButton2 = new DevExpress.XtraBars.Navigation.NavButton();
            this.tncUsuario = new DevExpress.XtraBars.Navigation.TileNavCategory();
            this.tniCerrarSession = new DevExpress.XtraBars.Navigation.TileNavItem();
            this.tncConfiguracion = new DevExpress.XtraBars.Navigation.TileNavCategory();
            this.tniUsuarios = new DevExpress.XtraBars.Navigation.TileNavItem();
            this.tncEmpleados = new DevExpress.XtraBars.Navigation.TileNavCategory();
            this.tniControlEmpleados = new DevExpress.XtraBars.Navigation.TileNavItem();
            this.tniControlPermisos = new DevExpress.XtraBars.Navigation.TileNavItem();
            this.tniControlVacaciones = new DevExpress.XtraBars.Navigation.TileNavItem();
            this.tncPlanilla = new DevExpress.XtraBars.Navigation.TileNavCategory();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.tileNavPane1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // alertControl1
            // 
            this.alertControl1.AutoFormDelay = 5000;
            alertButton11.Hint = "Copiar";
            alertButton11.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            alertButton11.Name = "Copiar";
            alertButton12.Hint = "Correo";
            alertButton12.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            alertButton12.Name = "Correo";
            this.alertControl1.Buttons.Add(alertButton11);
            this.alertControl1.Buttons.Add(alertButton12);
            this.alertControl1.ButtonClick += new DevExpress.XtraBars.Alerter.AlertButtonClickEventHandler(this.alertControl1_ButtonClick);
            // 
            // tileNavPane1
            // 
            this.tileNavPane1.Appearance.BackColor2 = System.Drawing.Color.Gainsboro;
            this.tileNavPane1.Appearance.BorderColor = System.Drawing.Color.White;
            this.tileNavPane1.Appearance.Options.UseBorderColor = true;
            this.tileNavPane1.BackColor = System.Drawing.Color.SteelBlue;
            this.tileNavPane1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tileNavPane1.Buttons.Add(this.navButton2);
            this.tileNavPane1.Buttons.Add(this.tncUsuario);
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
            this.tileNavPane1.OptionsPrimaryDropDown.ShowItemShadow = DevExpress.Utils.DefaultBoolean.True;
            this.tileNavPane1.OptionsSecondaryDropDown.ShowItemShadow = DevExpress.Utils.DefaultBoolean.True;
            this.tileNavPane1.Size = new System.Drawing.Size(1718, 66);
            this.tileNavPane1.TabIndex = 1;
            this.tileNavPane1.Text = "tnpMenu";
            // 
            // navButton2
            // 
            this.navButton2.Caption = "Recursos Humanos ";
            this.navButton2.IsMain = true;
            this.navButton2.Name = "navButton2";
            // 
            // tncUsuario
            // 
            this.tncUsuario.Alignment = DevExpress.XtraBars.Navigation.NavButtonAlignment.Right;
            this.tncUsuario.Caption = "Usuario";
            this.tncUsuario.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("tncUsuario.ImageOptions.SvgImage")));
            this.tncUsuario.Items.AddRange(new DevExpress.XtraBars.Navigation.TileNavItem[] {
            this.tniCerrarSession});
            this.tncUsuario.Name = "tncUsuario";
            // 
            // 
            // 
            this.tncUsuario.Tile.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            // 
            // tniCerrarSession
            // 
            this.tniCerrarSession.Caption = "Cerrar Sesión";
            this.tniCerrarSession.Name = "tniCerrarSession";
            // 
            // 
            // 
            this.tniCerrarSession.Tile.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement41.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image2")));
            tileItemElement41.Text = "Cerrar Sesión";
            this.tniCerrarSession.Tile.Elements.Add(tileItemElement41);
            this.tniCerrarSession.Tile.Name = "tileBarItem1";
            this.tniCerrarSession.ElementClick += new DevExpress.XtraBars.Navigation.NavElementClickEventHandler(this.tniCerrarSession_ElementClick);
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
            this.tncConfiguracion.Tile.AppearanceItem.Normal.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.tncConfiguracion.Tile.AppearanceItem.Normal.ForeColor = System.Drawing.Color.White;
            this.tncConfiguracion.Tile.AppearanceItem.Normal.Options.UseBackColor = true;
            this.tncConfiguracion.Tile.AppearanceItem.Normal.Options.UseForeColor = true;
            this.tncConfiguracion.Tile.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement43.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image4")));
            tileItemElement43.Text = "Configuracion";
            tileItemElement43.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.BottomRight;
            this.tncConfiguracion.Tile.Elements.Add(tileItemElement43);
            this.tncConfiguracion.Tile.Name = "tileBarItem2";
            // 
            // tniUsuarios
            // 
            this.tniUsuarios.Caption = "Usuarios";
            this.tniUsuarios.Name = "tniUsuarios";
            // 
            // 
            // 
            this.tniUsuarios.Tile.AppearanceItem.Normal.BackColor = System.Drawing.Color.DarkGreen;
            this.tniUsuarios.Tile.AppearanceItem.Normal.ForeColor = System.Drawing.Color.White;
            this.tniUsuarios.Tile.AppearanceItem.Normal.Options.UseBackColor = true;
            this.tniUsuarios.Tile.AppearanceItem.Normal.Options.UseForeColor = true;
            this.tniUsuarios.Tile.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement42.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image3")));
            tileItemElement42.Text = "Usuarios";
            this.tniUsuarios.Tile.Elements.Add(tileItemElement42);
            this.tniUsuarios.Tile.Name = "tileBarItem1";
            this.tniUsuarios.ElementClick += new DevExpress.XtraBars.Navigation.NavElementClickEventHandler(this.tniUsuarios_ElementClick);
            // 
            // tncEmpleados
            // 
            this.tncEmpleados.Caption = "Empleados";
            this.tncEmpleados.Items.AddRange(new DevExpress.XtraBars.Navigation.TileNavItem[] {
            this.tniControlEmpleados,
            this.tniControlPermisos,
            this.tniControlVacaciones});
            this.tncEmpleados.Name = "tncEmpleados";
            // 
            // 
            // 
            this.tncEmpleados.Tile.AppearanceItem.Normal.BackColor = System.Drawing.Color.SaddleBrown;
            this.tncEmpleados.Tile.AppearanceItem.Normal.ForeColor = System.Drawing.Color.White;
            this.tncEmpleados.Tile.AppearanceItem.Normal.Options.UseBackColor = true;
            this.tncEmpleados.Tile.AppearanceItem.Normal.Options.UseForeColor = true;
            this.tncEmpleados.Tile.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement47.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image8")));
            tileItemElement47.Text = "Empleados";
            tileItemElement47.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.BottomRight;
            this.tncEmpleados.Tile.Elements.Add(tileItemElement47);
            this.tncEmpleados.Tile.Name = "tileBarItem3";
            // 
            // tniControlEmpleados
            // 
            this.tniControlEmpleados.Caption = "Control de Empleados";
            this.tniControlEmpleados.Name = "tniControlEmpleados";
            // 
            // 
            // 
            this.tniControlEmpleados.Tile.AppearanceItem.Normal.BackColor = System.Drawing.Color.DarkGreen;
            this.tniControlEmpleados.Tile.AppearanceItem.Normal.ForeColor = System.Drawing.Color.White;
            this.tniControlEmpleados.Tile.AppearanceItem.Normal.Options.UseBackColor = true;
            this.tniControlEmpleados.Tile.AppearanceItem.Normal.Options.UseForeColor = true;
            this.tniControlEmpleados.Tile.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement44.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image5")));
            tileItemElement44.Text = "Control de Empleados";
            this.tniControlEmpleados.Tile.Elements.Add(tileItemElement44);
            this.tniControlEmpleados.Tile.Name = "tileBarItem1";
            this.tniControlEmpleados.ElementClick += new DevExpress.XtraBars.Navigation.NavElementClickEventHandler(this.tniControlEmpleados_ElementClick);
            // 
            // tniControlPermisos
            // 
            this.tniControlPermisos.Caption = "Control Permisos";
            this.tniControlPermisos.Name = "tniControlPermisos";
            // 
            // 
            // 
            this.tniControlPermisos.Tile.AppearanceItem.Normal.BackColor = System.Drawing.Color.DarkGreen;
            this.tniControlPermisos.Tile.AppearanceItem.Normal.ForeColor = System.Drawing.Color.White;
            this.tniControlPermisos.Tile.AppearanceItem.Normal.Options.UseBackColor = true;
            this.tniControlPermisos.Tile.AppearanceItem.Normal.Options.UseForeColor = true;
            this.tniControlPermisos.Tile.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement45.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image6")));
            tileItemElement45.Text = "Control de Permisos";
            this.tniControlPermisos.Tile.Elements.Add(tileItemElement45);
            this.tniControlPermisos.Tile.Name = "tileBarItem2";
            this.tniControlPermisos.ElementClick += new DevExpress.XtraBars.Navigation.NavElementClickEventHandler(this.tniControlPermisos_ElementClick);
            // 
            // tniControlVacaciones
            // 
            this.tniControlVacaciones.Caption = "Control de Vacaciones";
            this.tniControlVacaciones.Name = "tniControlVacaciones";
            // 
            // 
            // 
            this.tniControlVacaciones.Tile.AppearanceItem.Normal.BackColor = System.Drawing.Color.DarkGreen;
            this.tniControlVacaciones.Tile.AppearanceItem.Normal.ForeColor = System.Drawing.Color.White;
            this.tniControlVacaciones.Tile.AppearanceItem.Normal.Options.UseBackColor = true;
            this.tniControlVacaciones.Tile.AppearanceItem.Normal.Options.UseForeColor = true;
            this.tniControlVacaciones.Tile.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement46.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image7")));
            tileItemElement46.Text = "Control de Vacaciones";
            this.tniControlVacaciones.Tile.Elements.Add(tileItemElement46);
            this.tniControlVacaciones.Tile.Name = "tileBarItem1";
            this.tniControlVacaciones.ElementClick += new DevExpress.XtraBars.Navigation.NavElementClickEventHandler(this.tniControlVacaciones_ElementClick);
            // 
            // tncPlanilla
            // 
            this.tncPlanilla.Caption = "Planillas";
            this.tncPlanilla.Name = "tncPlanilla";
            // 
            // 
            // 
            this.tncPlanilla.Tile.AppearanceItem.Normal.BackColor = System.Drawing.Color.Maroon;
            this.tncPlanilla.Tile.AppearanceItem.Normal.ForeColor = System.Drawing.Color.White;
            this.tncPlanilla.Tile.AppearanceItem.Normal.Options.UseBackColor = true;
            this.tncPlanilla.Tile.AppearanceItem.Normal.Options.UseForeColor = true;
            this.tncPlanilla.Tile.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement48.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image9")));
            tileItemElement48.Text = "              Planillas";
            this.tncPlanilla.Tile.Elements.Add(tileItemElement48);
            this.tncPlanilla.Tile.Name = "tileBarItem4";
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.Appearance.BackColor = System.Drawing.Color.White;
            this.xtraTabbedMdiManager1.Appearance.Options.UseBackColor = true;
            this.xtraTabbedMdiManager1.ClosePageButtonShowMode = DevExpress.XtraTab.ClosePageButtonShowMode.InAllTabPageHeaders;
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // frmPrincipal
            // 
            this.AllowMdiBar = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1718, 1006);
            this.Controls.Add(this.tileNavPane1);
            this.DoubleBuffered = true;
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmPrincipal";
            this.ShowIcon = false;
            this.ShowMdiChildCaptionInParentTitle = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmPrincipal_FormClosed);
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.VisibleChanged += new System.EventHandler(this.frmPrincipal_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.tileNavPane1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
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
        private DevExpress.XtraBars.Navigation.TileNavItem tniControlVacaciones;
        private DevExpress.XtraBars.Navigation.TileNavCategory tncUsuario;
        private DevExpress.XtraBars.Navigation.TileNavItem tniCerrarSession;
    }
}

