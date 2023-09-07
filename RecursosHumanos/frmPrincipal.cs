using RecursosHumanos.Empleados;
using System;
using System.Windows.Forms;
using System.Diagnostics;
using System.Net;
using System.Drawing;
using DevExpress.XtraLayout;
using RecursosHumanos.Empleados.Consultas;


namespace RecursosHumanos
{
    public partial class frmPrincipal : DevExpress.XtraEditors.XtraForm
    {
        private Image backgroundImage;
        private LayoutControl layoutControl1;

        public frmPrincipal()
        {
            InitializeComponent();
        }

        public void MostrarError(string error)
        {
            alertControl1.Show(this, "ERROR! ", error);
        }

        public void MostrarErrorPrivilegios()
        {
            alertControl1.Show(this, "","No cuenta con los privilegios para realizar esta accion.");
        }

        public void MostrarExito()
        {
            alertControl1.Show(this, "Exito ", "Operación Exitosa.");
        }

        public void MostrarExito(string Mensaje)
        {
            alertControl1.Show(this, "Exito ", Mensaje);
        }

        private void frmPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            CargarCaption();           
        }

        public void CargarCaption()
        {
            tncUsuario.Caption = Global.IDUsuario.Trim() + Environment.NewLine + Global.Puesto.Trim();
        }

        private void tniControlPermisos_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            if (Global.ComprobarPrivilegio(7) == true)
            {
                ControlPermisos controlPermisos = new ControlPermisos();
                controlPermisos.MdiParent = this;
                controlPermisos.Show();
            }
            else
            {
                MostrarErrorPrivilegios();
            }
        }

        private void tniControlEmpleados_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            if (Global.ComprobarPrivilegio(1) == true)
            {
                ControlEmpleados empleados = new ControlEmpleados();
                empleados.MdiParent = this;
                empleados.Show();
            }
            else
            {
                MostrarErrorPrivilegios();
            }
        }

        private void tniUsuarios_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            if (Global.ComprobarPrivilegio(17) == true)
            {
                ControlUsuarios controlUsuarios = new ControlUsuarios();
                controlUsuarios.MdiParent = this;
                controlUsuarios.Show();
            }
            else
            {
                MostrarErrorPrivilegios();
            }
        }

        private void tniControlVacaciones_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            if (Global.ComprobarPrivilegio(27) == true)
            {
                ControlVacaciones controlVacaciones = new ControlVacaciones();
                controlVacaciones.MdiParent = this;
                controlVacaciones.Show();
            }
            else
            {
                MostrarErrorPrivilegios();
            }
        }

        private void tniCerrarSession_ElementClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            Application.Restart();
        }

        private void alertControl1_ButtonClick(object sender, DevExpress.XtraBars.Alerter.AlertButtonClickEventArgs e)
        {
            try
            {
                if (e.ButtonName == "Copiar")
                {
                    Clipboard.SetText(e.AlertForm.AlertInfo.Text);
                } else if (e.ButtonName == "Correo") {
                    var to = "kcastillo@inhgeomin.gob.hn";
                    var subject = "Error en RRHH";
                    var body = e.AlertForm.AlertInfo.Text;

                    // You need to URL encode the subject and body
                    subject = WebUtility.UrlEncode(subject);
                    body = WebUtility.UrlEncode(body);

                    var mailtoLink = $"mailto:{to}?subject={subject}&body={body}";

                    Process.Start(new ProcessStartInfo(mailtoLink) { UseShellExecute = true });
                }

            }
            catch (Exception ex)
            {

                MostrarError(ex.Message);
            }
        }

        private void frmPrincipal_VisibleChanged(object sender, EventArgs e)
        {
            CargarCaption();
        }



        /*private void tniControlVacaciones_TileClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            ControlVacaciones controlPermisos = new ControlVacaciones();
            ControlVacaciones.MdiParent = this;
            ControlVacaciones.Show();
        }*/

    }
}
