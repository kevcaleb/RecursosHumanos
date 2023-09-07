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
    public partial class EdicionUsuario : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        frmPrincipal frmprincipal = new frmPrincipal();
        Datos datos = new Datos();
        public ControlUsuarios controlUsuarios;
        bool EsNuevo = false;



        private void EdicionUsuario_Load(object sender, EventArgs e)
        {
            CargarRol();

            BeginInvoke(new Action(() =>
            {

                this.txtUsuario.Focus();
            }));

        }


        private void CargarDatosUsuario(string id)//Mostrar todos los campos del empleado que puede modificar en pantalla
        {
            try
            {
                DataTable dataTable = new DataTable();
                dataTable = datos.ConsultaTabla("[dbo].[p_ConsultarUsuarioPorId]", "@Id_Usuario", id);

                if (dataTable.Rows.Count > 0)
                {
                    txtUsuario.Text = dataTable.Rows[0].ItemArray[dataTable.Columns["ID de Usuario"].Ordinal].ToString();
                    txtNombreUsuario.Text = dataTable.Rows[0].ItemArray[dataTable.Columns["Nombre de Usuario"].Ordinal].ToString();
                    txtContrasena.Text = dataTable.Rows[0].ItemArray[dataTable.Columns["Contrasena de Usuario"].Ordinal].ToString();
                    txtConfirmarContra.Text = dataTable.Rows[0].ItemArray[dataTable.Columns["Contrasena de Usuario"].Ordinal].ToString();
                    lkeRoles.EditValue = dataTable.Rows[0].ItemArray[dataTable.Columns["Rol de Usuario"].Ordinal];

                }
                else
                {
                    frmprincipal.MostrarError("No se pudo obtener los datos del Usuario, intentelo nuevamente.");
                    controlUsuarios.Refrescar();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                frmprincipal.MostrarError(ex.Message);

            }
        }


        public EdicionUsuario()//Metodo de inicializacion de nueva instancia que tiene sobrecarga de metodos y se usa tanto apra evaluar si el usuario presiono e boton guardar o modificar por su contenido interno
        {
            InitializeComponent();
            EsNuevo = true;
            this.Text = "Creción de Usuario";

        }

        public EdicionUsuario(string id)//Sobrecarga de metodos, se deferencia del otro porque recibe una variable 
        {
            InitializeComponent();
            EsNuevo = false;
            CargarDatosUsuario(id);
            this.Text = "Edición de Usuario - " + txtNombreUsuario.Text;
            bbiGuardarUsuario.Caption = "Modificar";
            txtUsuario.ReadOnly = true;
        }

        private void CargarRol()
        {
            try
            {
                lkeRoles.Properties.DataSource = datos.ConsultaTabla("[dbo].[p_ConsultarRoles]");
                lkeRoles.Properties.DisplayMember = "Roles";
                lkeRoles.Properties.ValueMember = "ID";
            }
            catch (Exception ex)
            {
                frmprincipal.MostrarError(ex.Message);
            }

        }

        private void ActualizarExistente()
        {
            try
            {
                if (MessageBox.Show("¿Esta seguro que desea modificar con estos datos?", "Confirmar Actualización", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {

                    datos.Procedimiento("[dbo].[p_ModificarUsuario]",
                        "@Id_Usuario", txtUsuario.Text,
                        "@Nombre_Usuario", txtNombreUsuario.Text,
                        "@Contrasena_Usuario", txtContrasena.Text,
                        "@Codigo_Rol", lkeRoles.EditValue
                        );


                    frmprincipal.MostrarExito();
                    this.Close();
                    controlUsuarios.Refrescar();                }
            }
            catch (Exception ex)
            {
                frmprincipal.MostrarError(ex.Message);
            }
        }

        private void bbiGuardarUsuario_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Global.ComprobarPrivilegio(26) == true)
            {
                try
                {
                if (ValidarRequerimientos() == true)
                {
                    if (EsNuevo == true)//se evalua para saber que sobrecarga de metodo se usara
                    {
                        GuardarNuevoUsuario();
                    }
                    else
                    {
                        ActualizarExistente();
                    }
                    controlUsuarios.Refrescar();
                }
                else
                {
                    frmprincipal.MostrarError("Introduzca todos los campos obligatorios.");
                }

                }
                catch (Exception ex)
                {
                    frmprincipal.MostrarError(ex.Message);

                }

            }
            else
            {
                frmprincipal.MostrarError("El Usuario no cuenta con los privilegios.");
            }
        }


        private bool ValidarRequerimientos()
        {
            bool resultado = true;
            try
            {
                if (txtNombreUsuario.Text == "")
                {
                    resultado = false;
                }
                if (txtUsuario.Text == "")
                {
                    resultado = false;
                }
                if (txtContrasena.Text == "")
                {
                    resultado = false;
                }
                if (Convert.ToString(lkeRoles.EditValue) == "")
                {
                    resultado = false;
                }
                if (txtConfirmarContra.Text == "")
                {
                    resultado = false;
                }

            }
            catch (Exception)
            {

                throw;
            }
            return resultado;
        }

        private void GuardarNuevoUsuario()
        {
            if (ValidarRequerimientos() == true)
            {

                if (txtConfirmarContra.Text == txtContrasena.Text)
                {

                    try
                    {
                        datos.Procedimiento("[dbo].[p_InsertarUsuario]"
                            , "@Id_Usuario", txtUsuario.Text
                       , "@Nombre_Usuario", txtNombreUsuario.Text
                       , "@Contrasena_Usuario", txtContrasena.Text
                       , "@Codigo_Rol", lkeRoles.EditValue
                       , "@Id_Usuario_Creador", Global.IDUsuario
                       );

                        this.Close();
                        controlUsuarios.Refrescar();

                    }
                    catch (Exception ex)
                    {
                        frmprincipal.MostrarError(ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Las contrasenas que ingreso no coinciden.");
                }

            }
            else
            {
                MessageBox.Show("Ingrese todos los datos del usuario.");
            }

        }

        private void bbiCancelar_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Close();
        }
    }

}

