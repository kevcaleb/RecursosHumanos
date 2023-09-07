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
using DevExpress.LookAndFeel;


namespace RecursosHumanos.Configuracion.Usuarios
{
    public partial class frmInicioSesion : DevExpress.XtraEditors.XtraForm
    {
        public frmInicioSesion()
        {
            InitializeComponent();
        }

        private void frmInicioSesion_Load(object sender, EventArgs e)
        {
            BeginInvoke(new Action(() => {

                this.txtUsuario.Focus();
            }));
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            IniciarSesion();
        }


        private void IniciarSesion()
        {
            try
            {
                if (txtUsuario.Text != "")
                {
                    if (txtContrasena.Text != "")
                    {
                        Datos datos = new Datos();

                        int resultado = Convert.ToInt32(datos.ProcedimientoRetorno("[dbo].[p_VerificarUsuario]", "@Id_Usuario", txtUsuario.Text, "@Contrasena_Usuario", txtContrasena.Text, "@Resultado"));
                        if (resultado == -1)//-1--Este Resultado determina que la contrasena es incorrecta
                        {
                            txtContrasena.Text = "";
                            txtContrasena.Focus();
                            MessageBox.Show("Contrasena Incorrecta");
                        }
                        else if (resultado == 0)//Usuario no existe
                        {
                            txtUsuario.Text = "";
                            txtUsuario.Focus();
                            MessageBox.Show("Usuario Incorrecto");
                        }
                        else if (resultado == 1)//Este Resultado determina que el usuario y contrasena coinciden
                        {                                                    
                            Global.IDUsuario = txtUsuario.Text.Trim();
                            DataTable datosUsuario = datos.ConsultaTabla("[dbo].[p_ConsultarUsuarioPorIdTodo]", "@Id_Usuario", Global.IDUsuario);
                            if (datosUsuario.Rows.Count >0)
                            {
                                Global.NumeroIdentidad = datosUsuario.Rows[0].ItemArray[datosUsuario.Columns["Numero de Identidad"].Ordinal].ToString();
                                Global.Puesto = datosUsuario.Rows[0].ItemArray[datosUsuario.Columns["Puesto"].Ordinal].ToString();
                            }
                            Global.ComprobarCarpetaTemporal();
                            frmPrincipal principal = new frmPrincipal();
                            principal.Show();
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Error desconocido, reportar a informatica");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Escriba la contraseña", "Contraseña");
                    }
                }
                else
                {
                    MessageBox.Show("Escriba el nombre de usuario", "Usuario");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtContrasena_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarEnter(e);
        }
        


        public void ValidarEnter(KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                IniciarSesion();
            }
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarEnter(e);
        }

        private void frmInicioSesion_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarEnter(e);
        }
    }
}