namespace RecursosHumanos.Empleados
{
    partial class ExcepcionVacaciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExcepcionVacaciones));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.bbiGuardar = new DevExpress.XtraBars.BarButtonItem();
            this.bbiCancelar = new DevExpress.XtraBars.BarButtonItem();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.gdcDatos = new DevExpress.XtraGrid.GridControl();
            this.gdvDatos = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.txteDias = new DevExpress.XtraEditors.TextEdit();
            this.txteComentarios = new DevExpress.XtraEditors.MemoEdit();
            this.lkeTipoExcepcion = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdcDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txteDias.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txteComentarios.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkeTipoExcepcion.Properties)).BeginInit();
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
            this.ribbon.Size = new System.Drawing.Size(726, 122);
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
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiGuardar);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiCancelar);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Acciones";
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
            this.bbiCancelar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiCancelar_ItemClick);
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.lkeTipoExcepcion);
            this.groupControl1.Controls.Add(this.txteComentarios);
            this.groupControl1.Controls.Add(this.txteDias);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(12, 128);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(702, 100);
            this.groupControl1.TabIndex = 2;
            this.groupControl1.Text = "Datos de Excepcion";
            // 
            // groupControl2
            // 
            this.groupControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl2.Controls.Add(this.gdcDatos);
            this.groupControl2.Location = new System.Drawing.Point(12, 234);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(702, 291);
            this.groupControl2.TabIndex = 3;
            this.groupControl2.Text = "Empleados";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(24, 33);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(47, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "No. Dias:";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(260, 33);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(75, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Comentarios:";
            // 
            // gdcDatos
            // 
            this.gdcDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gdcDatos.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gdcDatos.Location = new System.Drawing.Point(2, 20);
            this.gdcDatos.MainView = this.gdvDatos;
            this.gdcDatos.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gdcDatos.MenuManager = this.ribbon;
            this.gdcDatos.Name = "gdcDatos";
            this.gdcDatos.Size = new System.Drawing.Size(698, 269);
            this.gdcDatos.TabIndex = 7;
            this.gdcDatos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gdvDatos});
            // 
            // gdvDatos
            // 
            this.gdvDatos.DetailHeight = 239;
            this.gdvDatos.FixedLineWidth = 1;
            this.gdvDatos.GridControl = this.gdcDatos;
            this.gdvDatos.Name = "gdvDatos";
            this.gdvDatos.OptionsBehavior.Editable = false;
            this.gdvDatos.OptionsFind.AlwaysVisible = true;
            this.gdvDatos.OptionsFind.FindNullPrompt = "Ingrese el empleado a buscar...";
            this.gdvDatos.OptionsFind.SearchInPreview = true;
            this.gdvDatos.OptionsMenu.ShowGroupSummaryEditorItem = true;
            this.gdvDatos.OptionsSelection.MultiSelect = true;
            this.gdvDatos.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gdvDatos.OptionsView.ColumnAutoWidth = false;
            this.gdvDatos.OptionsView.ShowAutoFilterRow = true;
            this.gdvDatos.OptionsView.ShowFooter = true;
            this.gdvDatos.OptionsView.ShowGroupPanel = false;
            // 
            // txteDias
            // 
            this.txteDias.Location = new System.Drawing.Point(133, 30);
            this.txteDias.MenuManager = this.ribbon;
            this.txteDias.Name = "txteDias";
            this.txteDias.Properties.Mask.EditMask = "n0";
            this.txteDias.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txteDias.Size = new System.Drawing.Size(111, 20);
            this.txteDias.TabIndex = 2;
            // 
            // txteComentarios
            // 
            this.txteComentarios.Location = new System.Drawing.Point(341, 31);
            this.txteComentarios.MenuManager = this.ribbon;
            this.txteComentarios.Name = "txteComentarios";
            this.txteComentarios.Size = new System.Drawing.Size(266, 57);
            this.txteComentarios.TabIndex = 3;
            // 
            // lkeTipoExcepcion
            // 
            this.lkeTipoExcepcion.Location = new System.Drawing.Point(133, 57);
            this.lkeTipoExcepcion.MenuManager = this.ribbon;
            this.lkeTipoExcepcion.Name = "lkeTipoExcepcion";
            this.lkeTipoExcepcion.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkeTipoExcepcion.Size = new System.Drawing.Size(111, 20);
            this.lkeTipoExcepcion.TabIndex = 4;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(24, 60);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(103, 13);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "Tipo de Excepcion:";
            // 
            // ExcepcionVacaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 537);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.ribbon);
            this.Name = "ExcepcionVacaciones";
            this.Ribbon = this.ribbon;
            this.Text = "Excepcion de Vacaciones";
            this.Load += new System.EventHandler(this.ExcepcionVacaciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gdcDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txteDias.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txteComentarios.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkeTipoExcepcion.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem bbiGuardar;
        private DevExpress.XtraBars.BarButtonItem bbiCancelar;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.GridControl gdcDatos;
        private DevExpress.XtraGrid.Views.Grid.GridView gdvDatos;
        private DevExpress.XtraEditors.MemoEdit txteComentarios;
        private DevExpress.XtraEditors.TextEdit txteDias;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LookUpEdit lkeTipoExcepcion;
    }
}