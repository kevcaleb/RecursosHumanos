using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace RecursosHumanos.Empleados
{
    public partial class RechazoSolicitudVacaciones : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        Datos datos = new Datos();
        frmPrincipal frmprincipal = new frmPrincipal();
        public ControlVacaciones controlVacaciones;
        public string idSolicitud { get; set; }

        /// <summary>
        /// Ventana para confirmar el rechazo de la solicitud de vacaciones
        /// </summary>
        /// <param name="numeroSolicitud">Numero de Solicitud a Rechazar Como String</param>
        public RechazoSolicitudVacaciones(string numeroSolicitud)
        {
            InitializeComponent();
            idSolicitud = numeroSolicitud;
           
        }
        
        private void bbiCancelar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void bbiRechazar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (txtJustificacionRechazo.Text != "" && txtJustificacionRechazo.Text.Length>=15)
                {
                    if(MessageBox.Show("Desea proceder con el rechazo?", "Confirmar Rechazo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        datos.Procedimiento("[dbo].[p_RechazarVacaciones]", "@Id_Solicitud_Vacaciones", idSolicitud,
                            "@Id_Usuario_Verificador", Global.IDUsuario,
                            "@Comentario_Rechazo", txtJustificacionRechazo.Text);
                        this.Close();
                        controlVacaciones.Refrescar();
                    }
                    
                }
                else
                {
                    frmprincipal.MostrarError("La justificacion de rechazo no puede estar vacia y debe tener al menos 15 letras.");
                }
            }
            catch (Exception ex)
            {

                frmprincipal.MostrarError(ex.Message);
            }
        }
    }
}