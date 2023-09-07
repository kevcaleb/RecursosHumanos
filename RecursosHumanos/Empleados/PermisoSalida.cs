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
    public partial class PermisoSalida : DevExpress.XtraBars.Ribbon.RibbonForm
    {

        Datos datos = new Datos();
        frmPrincipal frmprincipal = new frmPrincipal();
        EdicionEmpleado edicionEmpleado = new EdicionEmpleado();
        string identidad;



        public PermisoSalida()
        {
            InitializeComponent();
        }

        private void PermisoSalida_Load(object sender, EventArgs e)
        {
            
            CargarDatosControlesPermiso();
            CargarDatosUsuario();
            dtpFechaSalida.EditValue = DateTime.Today;
            if (Global.NumeroIdentidad != "")
            {
                lkeEmpleado.EditValue = Global.NumeroIdentidad;
            }
        }

        private void CargarEmpleados()
        {
            try
            {
                lkeEmpleado.Properties.DataSource = datos.ConsultaTabla("[dbo].[p_ConsultarEmpleadosActivos]");
                lkeEmpleado.Properties.DisplayMember = "Nombre del Empleado";
                lkeEmpleado.Properties.ValueMember = "Numero de Identidad";
            }
            catch (Exception ex)
            {
                frmprincipal.MostrarError(ex.Message);
            }
        }

        private void CargarDatosControlesPermiso()
        {
            CargarEmpleados();
            CargarTipoSalida();
            CargarMotivoPermiso();
            CargarUnidad();
            CargarTipoPermiso();
        }



        private void CargarTipoSalida()
        {
            try
            {
                lkeTipoSalida.Properties.DataSource = datos.ConsultaTabla("[dbo].[p_ConsultarTipoSalida]");
                lkeTipoSalida.Properties.DisplayMember = "Tipo de Salida";
                lkeTipoSalida.Properties.ValueMember = "ID";
            }
            catch (Exception ex)
            {
                frmprincipal.MostrarError(ex.Message);                
            }

        }

        private void CargarMotivoPermiso()
        {
            try
            {
                lkeMotivoPermiso.Properties.DataSource = datos.ConsultaTabla("[dbo].[p_ConsultarMotivoPermiso]");
                lkeMotivoPermiso.Properties.DisplayMember = "Motivo de Permiso";
                lkeMotivoPermiso.Properties.ValueMember = "ID";
            }
            catch (Exception ex)
            {
                frmprincipal.MostrarError(ex.Message);

            }

        }

        private void CargarUnidad()
        {
            try
            {
                lkeUnidad.Properties.DataSource = datos.ConsultaTabla("[dbo].[p_ConsultarUnidad]");
                lkeUnidad.Properties.DisplayMember = "Nombre de la Unidad";
                lkeUnidad.Properties.ValueMember = "ID";
            }
            catch (Exception ex)
            {
                frmprincipal.MostrarError(ex.Message);
            }

        }

        private void CargarTipoPermiso()
        {
            try
            {
                lkeTipoPermiso.Properties.DataSource = datos.ConsultaTabla("[dbo].[p_ConsultarTipoPermiso]");
                lkeTipoPermiso.Properties.DisplayMember = "Tipo de Permiso";
                lkeTipoPermiso.Properties.ValueMember = "ID";
            }
            catch (Exception ex)
            {
                frmprincipal.MostrarError(ex.Message);

            }

        }

        private void CargarDatosUsuario()
        {
            try
            {
                DataTable dataTable = new DataTable();
                dataTable = datos.ConsultaTabla("[dbo].[p_ConsultarEmpleadoPorIdUsuario]", "@Id_Usuario", Global.IDUsuario);

                if (dataTable.Rows.Count > 0)
                {
                    txteRelojMarcador.Text = dataTable.Rows[0].ItemArray[dataTable.Columns["No. Reloj Marcador"].Ordinal].ToString();
                    lkeUnidad.EditValue = dataTable.Rows[0].ItemArray[dataTable.Columns["Codigo_Unidad"].Ordinal];
                }

                }
            catch (Exception ex)
            {
                frmprincipal.MostrarError(ex.Message);
            }
        }

        private void lkeTipoPermiso_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (lkeTipoPermiso.EditValue != null)
                {
                    if (Convert.ToInt32(lkeTipoPermiso.EditValue) == 1)  //1 es entrada y 2 es salida
                    {
                        lkeTipoSalida.Enabled = false;
                        lkeTipoSalida.EditValue = null;
                    }
                    else
                    {
                        lkeTipoSalida.Enabled = true;
                    }
                }
            }
            catch (Exception ex)
            {
                frmprincipal.MostrarError(ex.Message);
            }
        }

        private bool ValidarRequerimientos()
        {
            bool resultado = true;
            try
            {
                if (txtAsunto.Text == "")
                {
                    resultado = false;
                }
                if (lkeTipoPermiso.EditValue == null)
                {
                    resultado = false;
                }
                if (lkeMotivoPermiso.EditValue == null)
                {
                    resultado = false;
                }
                if (lkeTipoSalida.EditValue == "")
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

        private void GuardarNuevo()
        {
            if(lkeTipoSalida.EditValue == null)
            {
                lkeTipoSalida.EditValue = 3;
            }
            
            try
            {
                datos.Procedimiento("[dbo].[p_InsertarPermiso]"
                    , "@Numero_Identidad", lkeEmpleado.EditValue
                    , "@Codigo_Tipo_Permiso", lkeTipoPermiso.EditValue
                    , "@Codigo_Motivo_Permiso", lkeMotivoPermiso.EditValue
                    , "@Codigo_Tipo_Salida", lkeTipoSalida.EditValue
                    , "@Hora_Permiso", tmeSalida.EditValue
                    , "@Fecha_Permiso", dtpFechaSalida.EditValue
                    , "@Asunto", txtAsunto.Text
                    , "@Id_Usuario_Creacion", Global.IDUsuario
                    );
              
            }
            catch (Exception ex)
            {
                frmprincipal.MostrarError(ex.Message);
            }
        }
        
        


        private void bbiGuardar_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (ValidarRequerimientos() == true)
            {
                
                try
                {
                            GuardarNuevo();
                            this.Close();
                }
                catch (Exception ex)
                {

                    frmprincipal.MostrarError(ex.Message);
                }
            }
        }

  
    }
}




    

        

