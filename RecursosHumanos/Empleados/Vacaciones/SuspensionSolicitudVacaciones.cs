using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;

namespace RecursosHumanos.Empleados
{
    public partial class SuspensionSolicitudVacaciones : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        Datos datos = new Datos();
        frmPrincipal frmprincipal = new frmPrincipal();
        public ControlVacaciones controlVacaciones;
        public string idSolicitud { get; set; }

        public SuspensionSolicitudVacaciones(string numeroSolicitud)
        {
            InitializeComponent();
            idSolicitud = numeroSolicitud;
            this.Text = this.Text + " - " + idSolicitud;
        }

        private void bbiSuspender_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                if (txtJustificacionSuspension.Text != "" && txtJustificacionSuspension.Text.Length >= 15)
                {
                    if (MessageBox.Show("Desea proceder con la suspensi[on?", "Confirmar Suspensión", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        datos.Procedimiento("[dbo].[p_SuspenderVacaciones]", "@Id_Solicitud_Vacaciones", idSolicitud,
                            "@Id_Usuario_Verificador", Global.IDUsuario,
                            "@Comentario_Rechazo", txtJustificacionSuspension.Text,
                            "@Dias", txtDiasSuspender.Text);
                        this.Close();
                        controlVacaciones.Refrescar();
                    }
                }
                else
                {
                    frmprincipal.MostrarError("La justificacion de suspension no puede estar vacia y debe tener al menos 15 letras.");
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        
        private void SuspensionSolicitudVacaciones_Load(object sender, EventArgs e)
        {
            try
            {
                //Cargar datos de las vacaciones
                DataTable tabla = datos.ConsultaTabla("[dbo].[p_ConsultarSolicitudVacacionesporEmpleadoReporte]", "@Id_Solicitud_Vacaciones", idSolicitud);
                if (tabla.Rows.Count > 0)
                {
                    dtpFechaInicioVacaciones.EditValue = tabla.Rows[0].ItemArray[tabla.Columns["Fecha_Inicial"].Ordinal];
                    dtpFechaFinalVacaciones.EditValue = tabla.Rows[0].ItemArray[tabla.Columns["Fecha_Final"].Ordinal];
                    dtpFechaInicioSuspensionVacaciones.EditValue = tabla.Rows[0].ItemArray[tabla.Columns["Fecha_Inicial"].Ordinal];
                    dtpFechaInicioSuspensionVacaciones.Properties.MinValue = Convert.ToDateTime(dtpFechaInicioVacaciones.EditValue);
                    dtpFechaInicioSuspensionVacaciones.Properties.MaxValue = Convert.ToDateTime(dtpFechaFinalVacaciones.EditValue);
                }
            }
            catch (Exception ex)
            {
                frmprincipal.MostrarError(ex.Message);
            }
        }

        private void bbitCancelar_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Close();
        }

        private void dtpFechaInicioSuspensionVacaciones_DisableCalendarDate(object sender, DevExpress.XtraEditors.Calendar.DisableCalendarDateEventArgs e)
        {
            if (e.Date.DayOfWeek == DayOfWeek.Saturday || e.Date.DayOfWeek == DayOfWeek.Sunday)
            {
                e.IsDisabled = true;
            } 
        }

        private void dtpFechaInicioSuspensionVacaciones_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                DateTime fechaInicial = Convert.ToDateTime(dtpFechaInicioSuspensionVacaciones.EditValue);
                DateTime fechaFinal = Convert.ToDateTime(dtpFechaFinalVacaciones.EditValue);
                TimeSpan timeSpan = fechaFinal - fechaInicial;
                int diasFinSemana = 0;

                while (fechaInicial.Date <= fechaFinal.Date)
                {
                    if (fechaInicial.DayOfWeek == DayOfWeek.Saturday || fechaInicial.DayOfWeek == DayOfWeek.Sunday)
                    {
                        diasFinSemana += 1;
                    }
                    fechaInicial = fechaInicial.AddDays(1);
                }

                txtDiasSuspender.EditValue = timeSpan.Days + 1 - diasFinSemana;
            }
            catch (Exception ex)
            {

                frmprincipal.MostrarError(ex.Message);
            }

        }
    }
}