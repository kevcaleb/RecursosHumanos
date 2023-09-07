namespace RecursosHumanos.Empleados
{
    partial class EdicionUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EdicionUsuario));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.bbiGuardarUsuario = new DevExpress.XtraBars.BarButtonItem();
            this.bbiCancelar = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.xtraScrollableControl1 = new DevExpress.XtraEditors.XtraScrollableControl();
            this.txtConfirmarContra = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtUsuario = new DevExpress.XtraEditors.TextEdit();
            this.txtContrasena = new DevExpress.XtraEditors.TextEdit();
            this.txtNombreUsuario = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.lkeRoles = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl19 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.xtraScrollableControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtConfirmarContra.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsuario.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtContrasena.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombreUsuario.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkeRoles.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.bbiGuardarUsuario,
            this.bbiCancelar});
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
            this.ribbon.Size = new System.Drawing.Size(1330, 175);
            this.ribbon.Toolbar.ShowCustomizeItem = false;
            // 
            // bbiGuardarUsuario
            // 
            this.bbiGuardarUsuario.Caption = "Crear";
            this.bbiGuardarUsuario.Id = 1;
            this.bbiGuardarUsuario.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("bbiGuardarUsuario.ImageOptions.SvgImage")));
            this.bbiGuardarUsuario.Name = "bbiGuardarUsuario";
            this.bbiGuardarUsuario.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiGuardarUsuario_ItemClick);
            // 
            // bbiCancelar
            // 
            this.bbiCancelar.Caption = "Cancelar";
            this.bbiCancelar.Id = 2;
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
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiGuardarUsuario);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiCancelar);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Acciones";
            // 
            // groupControl1
            // 
            this.groupControl1.AllowTouchScroll = true;
            this.groupControl1.Controls.Add(this.xtraScrollableControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 175);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1330, 665);
            this.groupControl1.TabIndex = 3;
            this.groupControl1.Text = "Informarción Personal";
            // 
            // xtraScrollableControl1
            // 
            this.xtraScrollableControl1.Controls.Add(this.txtConfirmarContra);
            this.xtraScrollableControl1.Controls.Add(this.labelControl2);
            this.xtraScrollableControl1.Controls.Add(this.txtUsuario);
            this.xtraScrollableControl1.Controls.Add(this.txtContrasena);
            this.xtraScrollableControl1.Controls.Add(this.txtNombreUsuario);
            this.xtraScrollableControl1.Controls.Add(this.labelControl1);
            this.xtraScrollableControl1.Controls.Add(this.lkeRoles);
            this.xtraScrollableControl1.Controls.Add(this.labelControl19);
            this.xtraScrollableControl1.Controls.Add(this.labelControl3);
            this.xtraScrollableControl1.Controls.Add(this.labelControl9);
            this.xtraScrollableControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraScrollableControl1.Location = new System.Drawing.Point(2, 29);
            this.xtraScrollableControl1.Name = "xtraScrollableControl1";
            this.xtraScrollableControl1.Size = new System.Drawing.Size(1326, 634);
            this.xtraScrollableControl1.TabIndex = 25;
            // 
            // txtConfirmarContra
            // 
            this.txtConfirmarContra.Location = new System.Drawing.Point(207, 134);
            this.txtConfirmarContra.MenuManager = this.ribbon;
            this.txtConfirmarContra.Name = "txtConfirmarContra";
            this.txtConfirmarContra.Properties.Mask.EditMask = "*";
            this.txtConfirmarContra.Properties.PasswordChar = '*';
            this.txtConfirmarContra.Properties.UseSystemPasswordChar = true;
            this.txtConfirmarContra.Size = new System.Drawing.Size(292, 28);
            this.txtConfirmarContra.TabIndex = 4;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(36, 139);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(155, 19);
            this.labelControl2.TabIndex = 89;
            this.labelControl2.Text = "Confirmar Contraseña";
            this.labelControl2.ToolTipIconType = DevExpress.Utils.ToolTipIconType.WindLogo;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(207, 34);
            this.txtUsuario.MenuManager = this.ribbon;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Properties.Mask.EditMask = "\\p{Lu}+";
            this.txtUsuario.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtUsuario.Size = new System.Drawing.Size(292, 28);
            this.txtUsuario.TabIndex = 1;
            // 
            // txtContrasena
            // 
            this.txtContrasena.Location = new System.Drawing.Point(207, 101);
            this.txtContrasena.MenuManager = this.ribbon;
            this.txtContrasena.Name = "txtContrasena";
            this.txtContrasena.Properties.Mask.EditMask = "*";
            this.txtContrasena.Properties.PasswordChar = '*';
            this.txtContrasena.Properties.UseSystemPasswordChar = true;
            this.txtContrasena.Size = new System.Drawing.Size(292, 28);
            this.txtContrasena.TabIndex = 3;
            // 
            // txtNombreUsuario
            // 
            this.txtNombreUsuario.Location = new System.Drawing.Point(207, 67);
            this.txtNombreUsuario.MenuManager = this.ribbon;
            this.txtNombreUsuario.Name = "txtNombreUsuario";
            this.txtNombreUsuario.Properties.Mask.EditMask = "\\p{L}+ \\p{L}+";
            this.txtNombreUsuario.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtNombreUsuario.Size = new System.Drawing.Size(292, 28);
            this.txtNombreUsuario.TabIndex = 2;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(36, 72);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(158, 19);
            this.labelControl1.TabIndex = 84;
            this.labelControl1.Text = "Nombre del Empleado";
            this.labelControl1.ToolTipIconType = DevExpress.Utils.ToolTipIconType.WindLogo;
            // 
            // lkeRoles
            // 
            this.lkeRoles.Location = new System.Drawing.Point(207, 170);
            this.lkeRoles.MenuManager = this.ribbon;
            this.lkeRoles.Name = "lkeRoles";
            this.lkeRoles.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkeRoles.Size = new System.Drawing.Size(292, 28);
            this.lkeRoles.TabIndex = 5;
            // 
            // labelControl19
            // 
            this.labelControl19.Location = new System.Drawing.Point(36, 172);
            this.labelControl19.Name = "labelControl19";
            this.labelControl19.Size = new System.Drawing.Size(104, 19);
            this.labelControl19.TabIndex = 31;
            this.labelControl19.Text = "Rol de Usuario";
            this.labelControl19.ToolTipIconType = DevExpress.Utils.ToolTipIconType.WindLogo;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(36, 37);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(54, 19);
            this.labelControl3.TabIndex = 3;
            this.labelControl3.Text = "Usuario";
            this.labelControl3.ToolTipIconType = DevExpress.Utils.ToolTipIconType.WindLogo;
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(36, 105);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(79, 19);
            this.labelControl9.TabIndex = 15;
            this.labelControl9.Text = "Contraseña";
            this.labelControl9.ToolTipIconType = DevExpress.Utils.ToolTipIconType.WindLogo;
            // 
            // EdicionUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1330, 840);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.ribbon);
            this.Name = "EdicionUsuario";
            this.Ribbon = this.ribbon;
            this.Text = "EdicionUsuario";
            this.Load += new System.EventHandler(this.EdicionUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.xtraScrollableControl1.ResumeLayout(false);
            this.xtraScrollableControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtConfirmarContra.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUsuario.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtContrasena.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombreUsuario.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkeRoles.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraBars.BarButtonItem bbiGuardarUsuario;
        private DevExpress.XtraEditors.XtraScrollableControl xtraScrollableControl1;
        private DevExpress.XtraEditors.LabelControl labelControl19;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LookUpEdit lkeRoles;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtUsuario;
        private DevExpress.XtraEditors.TextEdit txtContrasena;
        private DevExpress.XtraEditors.TextEdit txtNombreUsuario;
        private DevExpress.XtraEditors.TextEdit txtConfirmarContra;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraBars.BarButtonItem bbiCancelar;
    }
}