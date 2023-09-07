namespace RecursosHumanos.Empleados
{
    partial class SuspensionSolicitudVacaciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SuspensionSolicitudVacaciones));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.bbiSuspender = new DevExpress.XtraBars.BarButtonItem();
            this.bbitCancelar = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.txtJustificacionSuspension = new DevExpress.XtraEditors.MemoEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.dtpFechaInicioVacaciones = new DevExpress.XtraEditors.DateEdit();
            this.dtpFechaFinalVacaciones = new DevExpress.XtraEditors.DateEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.dtpFechaInicioSuspensionVacaciones = new DevExpress.XtraEditors.DateEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtDiasSuspender = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtJustificacionSuspension.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpFechaInicioVacaciones.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpFechaInicioVacaciones.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpFechaFinalVacaciones.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpFechaFinalVacaciones.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpFechaInicioSuspensionVacaciones.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpFechaInicioSuspensionVacaciones.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiasSuspender.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.bbiSuspender,
            this.bbitCancelar});
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
            this.ribbon.Size = new System.Drawing.Size(698, 175);
            this.ribbon.Toolbar.ShowCustomizeItem = false;
            // 
            // bbiSuspender
            // 
            this.bbiSuspender.Caption = "Suspender";
            this.bbiSuspender.Id = 1;
            this.bbiSuspender.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("bbiSuspender.ImageOptions.SvgImage")));
            this.bbiSuspender.Name = "bbiSuspender";
            this.bbiSuspender.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiSuspender_ItemClick);
            // 
            // bbitCancelar
            // 
            this.bbitCancelar.Caption = "Cancelar";
            this.bbitCancelar.Id = 2;
            this.bbitCancelar.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("bbitCancelar.ImageOptions.SvgImage")));
            this.bbitCancelar.Name = "bbitCancelar";
            this.bbitCancelar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbitCancelar_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Acciones";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("ribbonPageGroup1.ImageOptions.SvgImage")));
            this.ribbonPageGroup1.ItemLinks.Add(this.bbiSuspender);
            this.ribbonPageGroup1.ItemLinks.Add(this.bbitCancelar);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Acciones";
            // 
            // txtJustificacionSuspension
            // 
            this.txtJustificacionSuspension.Location = new System.Drawing.Point(301, 347);
            this.txtJustificacionSuspension.Name = "txtJustificacionSuspension";
            this.txtJustificacionSuspension.Properties.MaxLength = 500;
            this.txtJustificacionSuspension.Size = new System.Drawing.Size(296, 150);
            this.txtJustificacionSuspension.TabIndex = 74;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(58, 363);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(220, 19);
            this.labelControl1.TabIndex = 75;
            this.labelControl1.Text = "Justificacion de la Suspension: ";
            this.labelControl1.ToolTipIconType = DevExpress.Utils.ToolTipIconType.WindLogo;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(58, 288);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(197, 19);
            this.labelControl2.TabIndex = 78;
            this.labelControl2.Text = "Fecha Inicio de Suspensión:";
            this.labelControl2.ToolTipIconType = DevExpress.Utils.ToolTipIconType.WindLogo;
            // 
            // dtpFechaInicioVacaciones
            // 
            this.dtpFechaInicioVacaciones.EditValue = null;
            this.dtpFechaInicioVacaciones.Location = new System.Drawing.Point(301, 210);
            this.dtpFechaInicioVacaciones.MenuManager = this.ribbon;
            this.dtpFechaInicioVacaciones.Name = "dtpFechaInicioVacaciones";
            this.dtpFechaInicioVacaciones.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpFechaInicioVacaciones.Properties.CalendarTimeEditing = DevExpress.Utils.DefaultBoolean.False;
            this.dtpFechaInicioVacaciones.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpFechaInicioVacaciones.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.dtpFechaInicioVacaciones.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtpFechaInicioVacaciones.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.dtpFechaInicioVacaciones.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtpFechaInicioVacaciones.Properties.FirstDayOfWeek = System.DayOfWeek.Monday;
            this.dtpFechaInicioVacaciones.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.dtpFechaInicioVacaciones.Properties.ReadOnly = true;
            this.dtpFechaInicioVacaciones.Properties.ShowMonthNavigationButtons = DevExpress.Utils.DefaultBoolean.True;
            this.dtpFechaInicioVacaciones.Size = new System.Drawing.Size(296, 28);
            this.dtpFechaInicioVacaciones.TabIndex = 109;
            // 
            // dtpFechaFinalVacaciones
            // 
            this.dtpFechaFinalVacaciones.EditValue = null;
            this.dtpFechaFinalVacaciones.Location = new System.Drawing.Point(301, 245);
            this.dtpFechaFinalVacaciones.MenuManager = this.ribbon;
            this.dtpFechaFinalVacaciones.Name = "dtpFechaFinalVacaciones";
            this.dtpFechaFinalVacaciones.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpFechaFinalVacaciones.Properties.CalendarTimeEditing = DevExpress.Utils.DefaultBoolean.False;
            this.dtpFechaFinalVacaciones.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpFechaFinalVacaciones.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.dtpFechaFinalVacaciones.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtpFechaFinalVacaciones.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.dtpFechaFinalVacaciones.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtpFechaFinalVacaciones.Properties.FirstDayOfWeek = System.DayOfWeek.Monday;
            this.dtpFechaFinalVacaciones.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.dtpFechaFinalVacaciones.Properties.ReadOnly = true;
            this.dtpFechaFinalVacaciones.Properties.ShowMonthNavigationButtons = DevExpress.Utils.DefaultBoolean.True;
            this.dtpFechaFinalVacaciones.Size = new System.Drawing.Size(296, 28);
            this.dtpFechaFinalVacaciones.TabIndex = 108;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(58, 217);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(236, 21);
            this.labelControl6.TabIndex = 107;
            this.labelControl6.Text = "Fecha de Inicio Vacaciones:";
            this.labelControl6.ToolTipIconType = DevExpress.Utils.ToolTipIconType.WindLogo;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(58, 252);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(228, 21);
            this.labelControl5.TabIndex = 106;
            this.labelControl5.Text = "Fecha Final de Vacaciones:";
            this.labelControl5.ToolTipIconType = DevExpress.Utils.ToolTipIconType.WindLogo;
            // 
            // dtpFechaInicioSuspensionVacaciones
            // 
            this.dtpFechaInicioSuspensionVacaciones.EditValue = null;
            this.dtpFechaInicioSuspensionVacaciones.Location = new System.Drawing.Point(301, 279);
            this.dtpFechaInicioSuspensionVacaciones.MenuManager = this.ribbon;
            this.dtpFechaInicioSuspensionVacaciones.Name = "dtpFechaInicioSuspensionVacaciones";
            this.dtpFechaInicioSuspensionVacaciones.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpFechaInicioSuspensionVacaciones.Properties.CalendarTimeEditing = DevExpress.Utils.DefaultBoolean.False;
            this.dtpFechaInicioSuspensionVacaciones.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpFechaInicioSuspensionVacaciones.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.dtpFechaInicioSuspensionVacaciones.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtpFechaInicioSuspensionVacaciones.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.dtpFechaInicioSuspensionVacaciones.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtpFechaInicioSuspensionVacaciones.Properties.FirstDayOfWeek = System.DayOfWeek.Monday;
            this.dtpFechaInicioSuspensionVacaciones.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.dtpFechaInicioSuspensionVacaciones.Properties.ShowMonthNavigationButtons = DevExpress.Utils.DefaultBoolean.True;
            this.dtpFechaInicioSuspensionVacaciones.Size = new System.Drawing.Size(296, 28);
            this.dtpFechaInicioSuspensionVacaciones.TabIndex = 110;
            this.dtpFechaInicioSuspensionVacaciones.DisableCalendarDate += new DevExpress.XtraEditors.Calendar.DisableCalendarDateEventHandler(this.dtpFechaInicioSuspensionVacaciones_DisableCalendarDate);
            this.dtpFechaInicioSuspensionVacaciones.EditValueChanged += new System.EventHandler(this.dtpFechaInicioSuspensionVacaciones_EditValueChanged);
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(58, 323);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(128, 19);
            this.labelControl3.TabIndex = 111;
            this.labelControl3.Text = "Dias a Suspender:";
            this.labelControl3.ToolTipIconType = DevExpress.Utils.ToolTipIconType.WindLogo;
            // 
            // txtDiasSuspender
            // 
            this.txtDiasSuspender.EditValue = "0";
            this.txtDiasSuspender.Location = new System.Drawing.Point(301, 313);
            this.txtDiasSuspender.MenuManager = this.ribbon;
            this.txtDiasSuspender.Name = "txtDiasSuspender";
            this.txtDiasSuspender.Properties.ReadOnly = true;
            this.txtDiasSuspender.Size = new System.Drawing.Size(296, 28);
            this.txtDiasSuspender.TabIndex = 112;
            // 
            // SuspensionSolicitudVacaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 531);
            this.Controls.Add(this.txtDiasSuspender);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.dtpFechaInicioSuspensionVacaciones);
            this.Controls.Add(this.dtpFechaInicioVacaciones);
            this.Controls.Add(this.dtpFechaFinalVacaciones);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtJustificacionSuspension);
            this.Controls.Add(this.ribbon);
            this.Name = "SuspensionSolicitudVacaciones";
            this.Ribbon = this.ribbon;
            this.Text = "Suspension de Solicitud Vacaciones";
            this.Load += new System.EventHandler(this.SuspensionSolicitudVacaciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtJustificacionSuspension.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpFechaInicioVacaciones.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpFechaInicioVacaciones.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpFechaFinalVacaciones.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpFechaFinalVacaciones.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpFechaInicioSuspensionVacaciones.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpFechaInicioSuspensionVacaciones.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiasSuspender.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem bbiSuspender;
        private DevExpress.XtraBars.BarButtonItem bbitCancelar;
        private DevExpress.XtraEditors.MemoEdit txtJustificacionSuspension;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.DateEdit dtpFechaInicioVacaciones;
        private DevExpress.XtraEditors.DateEdit dtpFechaFinalVacaciones;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.DateEdit dtpFechaInicioSuspensionVacaciones;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtDiasSuspender;
    }
}