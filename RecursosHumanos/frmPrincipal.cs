using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using RecursosHumanos.Configuracion.Usuarios;
using RecursosHumanos.Empleados;


namespace RecursosHumanos
{
    public partial class frmPrincipal : DevExpress.XtraEditors.XtraForm
    {
        
        
        public frmPrincipal()
        {
            InitializeComponent();
        }

        public void MostrarError(string error)
        {
            alertControl1.Show(this, "ERROR! ", error);
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

        private void tniControlEmpleados_TileClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            ControlEmpleados empleados = new ControlEmpleados();
            empleados.MdiParent = this;
            empleados.Show();
            
        }


        private void tniControlPermisos_TileClick(object sender, DevExpress.XtraBars.Navigation.NavElementEventArgs e)
        {
            ControlPermisos controlPermisos = new ControlPermisos();
            controlPermisos.MdiParent = this;
            controlPermisos.Show();
        }
    }
}
