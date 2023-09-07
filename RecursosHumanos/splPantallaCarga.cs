using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraSplashScreen;
using RecursosHumanos.Configuracion.Usuarios;

namespace RecursosHumanos
{
    public partial class splPantallaCarga : SplashScreen
    {
        public splPantallaCarga()
        {
            InitializeComponent();
            this.labelControl1.Text = "Copyright © 1998-" + DateTime.Now.Year.ToString();
        }
        
        #region Overrides

        public override void ProcessCommand(Enum cmd, object arg)
        {
            base.ProcessCommand(cmd, arg);
        }

        #endregion

        public enum SplashScreenCommand
        {
        }

        private void splPantallaCarga_Load(object sender, EventArgs e)
        {
            tmrTimer.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tmrTimer.Stop();
            this.Hide();
            frmInicioSesion inicioSesion = new frmInicioSesion();
            inicioSesion.Show();

        }

        private void pictureEdit2_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}