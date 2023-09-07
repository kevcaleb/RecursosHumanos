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
    public partial class EdicionEmpleado : DevExpress.XtraBars.Ribbon.RibbonForm//Hereda de la clase ribbonForm y poder acceder a los controles, la cual  es la clase dvexpress
    {
        frmPrincipal principal = new frmPrincipal();
        bool EsNuevo = false;
        Datos datos = new Datos();

       
        /// <summary>
        /// Creacion de nuevos empleados
        /// </summary>
        public EdicionEmpleado()//Metodo de inicializacion de nueva instancia que tiene sobrecarga de metodos y se usa tanto apra evaluar si el usuario presiono e boton guardar o modificar por su contenido interno
        {
            InitializeComponent();
            EsNuevo = true;
            this.Text = "Creción de Empleado";
            CargarDatosControles();
        }

        public ControlEmpleados controlEmpleados;


        /// <summary>
        /// Forma para modificar empleado existente
        /// </summary>
        /// <param name="id">Numero de identidad del empleado a modificar</param>
        public EdicionEmpleado(string id)//Sobrecarga de metodos, se deferencia del otro porque recibe una variable 
        {
            InitializeComponent();
            EsNuevo = false;
            CargarDatosControles();
            CargarDatosEmpleado(id);
            this.Text = "Edición de Empleado - " + txteNombreEmpleado.Text;
            txteNumeroIdentidad.ReadOnly = true;
        }

       

        private void CargarDatosControles()
        {
            CargarGeneros();
            CargarTipoSangre();
            CargarNivelUniversitario();
            CargarEstadoCivil();
            CargarMunicipios();
            CargarPuestos();
            CargarCarreraProfesional();
            CargarFondos();
            CargarUnidad();
        }


        private void CargarDatosEmpleado(string id)//Mostrar todos los campos del empleado que puede modificar en pantalla
        {
            try
            {
                DataTable dataTable = new DataTable();
                dataTable = datos.ConsultaTabla("[dbo].[p_ConsultarEmpleadoPorId]", "@Numero_Identidad", id);

                if (dataTable.Rows.Count > 0)
                {
                    txteNumeroIdentidad.Text = dataTable.Rows[0].ItemArray[dataTable.Columns["Numero de Identidad"].Ordinal].ToString();
                    txteOtrosConocimientos.Text = dataTable.Rows[0].ItemArray[dataTable.Columns["Otros Conocimientos"].Ordinal].ToString();
                    txtCorreoOficial.Text = dataTable.Rows[0].ItemArray[dataTable.Columns["Correo Oficial"].Ordinal].ToString();
                    txteRelojMarcador.Text = dataTable.Rows[0].ItemArray[dataTable.Columns["No. Reloj Marcador"].Ordinal].ToString();
                    txteNombreEmpleado.Text = dataTable.Rows[0].ItemArray[dataTable.Columns["Nombre del Empleado"].Ordinal].ToString();
                    txteNumeroPersonasCasa.Text = dataTable.Rows[0].ItemArray[dataTable.Columns["Numero de Personas en Casa"].Ordinal].ToString();
                    txteNumeroPersonasTercera.Text = dataTable.Rows[0].ItemArray[dataTable.Columns["Cantidad de Tercera Edad"].Ordinal].ToString();
                    txteTelefonoCelular.Text = dataTable.Rows[0].ItemArray[dataTable.Columns["Telefono Celular"].Ordinal].ToString();
                    txteTelefonoFijo.Text = dataTable.Rows[0].ItemArray[dataTable.Columns["Telefono fijo"].Ordinal].ToString();
                    txteDiplomas.Text = dataTable.Rows[0].ItemArray[dataTable.Columns["Diplomados Cursados"].Ordinal].ToString();
                    txteDescripcionDiplomas.Text = dataTable.Rows[0].ItemArray[dataTable.Columns["Descripcion de Diplomados"].Ordinal].ToString();
                    txteDescripcionNivelMedio.Text = dataTable.Rows[0].ItemArray[dataTable.Columns["Descripcion de Nivel Medio"].Ordinal].ToString();
                    dteFechaIngreso.EditValue = dataTable.Rows[0].ItemArray[dataTable.Columns["Fecha de Ingreso"].Ordinal];
                    dteFechaNacimiento.EditValue = dataTable.Rows[0].ItemArray[dataTable.Columns["Fecha de Nacimiento"].Ordinal];
                    txtNivelMedio.Text = dataTable.Rows[0].ItemArray[dataTable.Columns["Nivel Medio"].Ordinal].ToString();
                    txteNombreConyugue.Text = dataTable.Rows[0].ItemArray[dataTable.Columns["Nombre de Conyugue"].Ordinal].ToString();
                    txteTelefonoConyugue.Text = dataTable.Rows[0].ItemArray[dataTable.Columns["Telefono de Conyugue"].Ordinal].ToString();
                    lkeCarreraProfesional.EditValue = dataTable.Rows[0].ItemArray[dataTable.Columns["Codigo_Carrera_Profesional"].Ordinal];
                    lkeEstadoCivil.EditValue = dataTable.Rows[0].ItemArray[dataTable.Columns["Codigo_Estado_Civil"].Ordinal];
                    lkeFondos.EditValue = dataTable.Rows[0].ItemArray[dataTable.Columns["Codigo_Fondos"].Ordinal];
                    lkeMunicipios.EditValue = dataTable.Rows[0].ItemArray[dataTable.Columns["Codigo_Municipio_Nacimiento"].Ordinal];
                    lkeNivelUniversitario.EditValue = dataTable.Rows[0].ItemArray[dataTable.Columns["Codigo_Universitario"].Ordinal];
                    lkePuestos.EditValue = dataTable.Rows[0].ItemArray[dataTable.Columns["Codigo_Puesto"].Ordinal];
                    lkeTipoSangre.EditValue = dataTable.Rows[0].ItemArray[dataTable.Columns["Codigo_Tipo_Sangre"].Ordinal];
                    lkeGenero.EditValue = dataTable.Rows[0].ItemArray[dataTable.Columns["Codigo_Genero"].Ordinal];
                    txteCertificacionesCursadas.Text = dataTable.Rows[0].ItemArray[dataTable.Columns["Certificaciones Cursadas"].Ordinal].ToString();
                    txteDescripcionCertificaciones.Text = dataTable.Rows[0].ItemArray[dataTable.Columns["Descripcion de Certificaciones"].Ordinal].ToString();
                    txteCantidadHijosCasa.Text = dataTable.Rows[0].ItemArray[dataTable.Columns["Hijos en Casa"].Ordinal].ToString();
                    txteNivelPrimario.Text = dataTable.Rows[0].ItemArray[dataTable.Columns["Nivel Primario"].Ordinal].ToString();
                    txteDireccionDomiciliaria.Text = dataTable.Rows[0].ItemArray[dataTable.Columns["Direccion Domiciliaria"].Ordinal].ToString();
                    txteCorreoPersonal.Text = dataTable.Rows[0].ItemArray[dataTable.Columns["Correo Personal"].Ordinal].ToString();
                }
                else
                {
                    principal.MostrarError("No se pudo obtener los datos del empleado, intentelo nuevamente.");
                    controlEmpleados.Refrescar();
                    this.Close();
                }


            }
            catch (Exception ex)
            {

                principal.MostrarError(ex.Message);
            }
        }

        private void CargarTipoSangre()
        {
            try
            {
                lkeTipoSangre.Properties.DataSource = datos.ConsultaTabla("[dbo].[p_ConsultarTipoSangre]");
                lkeTipoSangre.Properties.DisplayMember = "Tipo";
                lkeTipoSangre.Properties.ValueMember = "ID";
            }
            catch (Exception)
            {

                throw;
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
            catch (Exception)
            {

                throw;
            }
        }

        private void CargarGeneros()
        {
            try
            {
                lkeGenero.Properties.DataSource = datos.ConsultaTabla("[dbo].[p_ConsultarGenero]");
                lkeGenero.Properties.DisplayMember = "Genero";
                lkeGenero.Properties.ValueMember = "ID";
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void CargarNivelUniversitario()
        {
            try
            {
                lkeNivelUniversitario.Properties.DataSource = datos.ConsultaTabla("[dbo].[p_ConsultarNivelUniversitario]");
                lkeNivelUniversitario.Properties.DisplayMember = "Descripcion Nivel Universitario";
                lkeNivelUniversitario.Properties.ValueMember = "ID";
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void CargarEstadoCivil()
        {
            try
            {
                lkeEstadoCivil.Properties.DataSource = datos.ConsultaTabla("[dbo].[p_ConsultarEstadoCivil]");
                lkeEstadoCivil.Properties.DisplayMember = "Estado Civil";
                lkeEstadoCivil.Properties.ValueMember = "ID";
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void CargarMunicipios()
        {
            try
            {
                lkeMunicipios.Properties.DataSource = datos.ConsultaTabla("[dbo].[p_ConsultarMunicipios]");
                lkeMunicipios.Properties.DisplayMember = "Municipios";
                lkeMunicipios.Properties.ValueMember = "ID";
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void CargarPuestos()
        {
            try
            {
                lkePuestos.Properties.DataSource = datos.ConsultaTabla("[dbo].[p_ConsultarPuestos]");
                lkePuestos.Properties.DisplayMember = "Puestos";
                lkePuestos.Properties.ValueMember = "ID";
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void CargarCarreraProfesional()
        {
            try
            {
                lkeCarreraProfesional.Properties.DataSource = datos.ConsultaTabla("[dbo].[p_ConsultarCarreraProfesional]");
                lkeCarreraProfesional.Properties.DisplayMember = "Carrera";
                lkeCarreraProfesional.Properties.ValueMember = "ID";
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void CargarFondos()
        {
            try
            {
                lkeFondos.Properties.DataSource = datos.ConsultaTabla("[dbo].[p_ConsultarFondos]");
                lkeFondos.Properties.DisplayMember = "Fondo";
                lkeFondos.Properties.ValueMember = "ID";
            }
            catch (Exception)
            {

                throw;
            }
        }

        private bool ValidarRequerimientos()
        {
            bool resultado = true;
            try
            {
                if (txteNumeroIdentidad.Text == "")
                {
                    resultado = false;
                }
                if (txteRelojMarcador.Text == "")
                {
                    resultado = false;
                }
                if (txteNombreEmpleado.Text == "")
                {
                    resultado = false;
                }
                if (txteTelefonoCelular.Text == "")
                {
                    resultado = false;
                }
                if (dteFechaNacimiento.EditValue == null)
                {
                    resultado = false;
                }
                if (dteFechaIngreso.EditValue == null)
                {
                    resultado = false;
                }
                if (txteDireccionDomiciliaria.Text == "")
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
            try
            {
                datos.Procedimiento("[dbo].[p_InsertarEmpleado]",
                    "@Numero_Identidad", txteNumeroIdentidad.Text,
                    "@Numero_de_reloj_Marcador", txteRelojMarcador.Text,
                    "@Nombre_Empleado", txteNombreEmpleado.Text,
                    "@Telefono_Celular", txteTelefonoCelular.Text,
                    "@Telefono_fijo", txteTelefonoFijo.Text,
                    "Correo_Oficial", txtCorreoOficial.Text,
                    "@Correo_Personal", txteCorreoPersonal.Text,
                    "@Total_Personas_Casa", txteNumeroPersonasCasa.Text,
                    "@Total_Personas_Tercera", txteNumeroPersonasTercera.Text,
                    "@Certificaciones_Cursadas", txteCertificacionesCursadas.Text,
                    "@Descripcion_Certificaciones", txteDescripcionCertificaciones.Text,
                    "@Diplomados_Cursados", txteDescripcionDiplomas.Text,
                    "@Descripcion_Diplomados", txteDescripcionDiplomas.Text,
                    "@Otros_Conocimientos", txteOtrosConocimientos.Text,
                    "@Fecha_Nacimiento", dteFechaNacimiento.EditValue,
                    "@Fecha_Ingreso", dteFechaIngreso.EditValue,
                    "@Direccion_Domiciliaria", txteDireccionDomiciliaria.Text,
                    "@Nombre_Conyugue", txteNombreConyugue.Text,
                    "@Telefono_Conyugue", txteCantidadHijosCasa.Text,
                    "@Cantidad_Hijos_Casa", txteCantidadHijosCasa.Text,
                    "@Nivel_Medio", txtNivelMedio.Text,
                    "@Descripcion_Nivel_Medio", txteDescripcionNivelMedio.Text,
                    "@Nivel_Primario", txteNivelPrimario.Text,
                    "@Codigo_Carrera_Profesional", lkeCarreraProfesional.EditValue,
                    "@Codigo_Estado_Civil", lkeEstadoCivil.EditValue,
                    "@Codigo_Genero", lkeGenero.EditValue,
                    "@Codigo_Tipo_Sangre", lkeTipoSangre.EditValue,
                    "@Codigo_Universitario", lkeNivelUniversitario.EditValue,
                    "@Codigo_Municipio_Nacimiento", lkeMunicipios.EditValue,
                    "@Codigo_Puesto", lkePuestos.EditValue,
                    "@Codigo_Fondos", lkeFondos.EditValue,
                    "@Codigo_Unidad", lkeUnidad.EditValue
                    );
            }
            catch (Exception ex)
            {
                principal.MostrarError(ex.Message);
            }
        }

        private void ActualizarExistente()
        {
            try
            {
                if (MessageBox.Show("¿Esta seguro que desea modificar con estos datos?", "Confirmar Actualización", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    
                    datos.Procedimiento("[dbo].[p_ModificarEmpleado]",
                        "@Numero_Identidad", txteNumeroIdentidad.Text,
                        "@Numero_de_reloj_Marcador", txteRelojMarcador.Text,
                        "@Nombre_Empleado", txteNombreEmpleado.Text,
                        "@Telefono_Celular", txteTelefonoCelular.Text,
                        "@Telefono_fijo", txteTelefonoFijo.Text,
                        "Correo_Oficial", txtCorreoOficial.Text,
                        "@Correo_Personal", txteCorreoPersonal.Text,
                        "@Total_Personas_Casa", txteNumeroPersonasCasa.Text,
                        "@Total_Personas_Tercera", txteNumeroPersonasTercera.Text,
                        "@Certificaciones_Cursadas", txteCertificacionesCursadas.Text,
                        "@Descripcion_Certificaciones", txteDescripcionCertificaciones.Text,
                        "@Diplomados_Cursados", txteDescripcionDiplomas.Text,
                        "@Descripcion_Diplomados", txteDescripcionDiplomas.Text,
                        "@Otros_Conocimientos", txteOtrosConocimientos.Text,
                        "@Fecha_Nacimiento", dteFechaNacimiento.EditValue,
                        "@Fecha_Ingreso", dteFechaIngreso.EditValue,
                        "@Direccion_Domiciliaria", txteDireccionDomiciliaria.Text,
                        "@Nombre_Conyugue", txteNombreConyugue.Text,
                        "@Telefono_Conyugue", txteCantidadHijosCasa.Text,
                        "@Cantidad_Hijos_Casa", txteCantidadHijosCasa.Text,
                        "@Nivel_Medio", txtNivelMedio.Text,
                        "@Descripcion_Nivel_Medio", txteDescripcionNivelMedio.Text,
                        "@Nivel_Primario", txteNivelPrimario.Text,
                        "@Codigo_Carrera_Profesional", lkeCarreraProfesional.EditValue,
                        "@Codigo_Estado_Civil", lkeEstadoCivil.EditValue,
                        "@Codigo_Genero", lkeGenero.EditValue,
                        "@Codigo_Tipo_Sangre", lkeTipoSangre.EditValue,
                        "@Codigo_Universitario", lkeNivelUniversitario.EditValue,
                        "@Codigo_Municipio_Nacimiento", lkeMunicipios.EditValue,
                        "@Codigo_Puesto", lkePuestos.EditValue,
                        "@Codigo_Fondos", lkeFondos.EditValue,
                        "@Codigo_Unidad", lkeUnidad.EditValue
                        );


                    principal.MostrarExito();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                principal.MostrarError(ex.Message);
            }
        }

        private void bbiGuardar_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {


                if (ValidarRequerimientos() == true)
                {
                    if (EsNuevo == true)//se evalua para 
                    {
                        GuardarNuevo();
                        EdicionEmpleado edicionEmpleado = new EdicionEmpleado();
                        edicionEmpleado.MdiParent = this.MdiParent;
                        edicionEmpleado.Show();
                        this.Close();
                    }
                    else
                    {
                        ActualizarExistente();
                    }
                    controlEmpleados.Refrescar();
                }
                else
                {
                    principal.MostrarError("Introduzca todos los campos obligatorios.");
                }

            }
            catch (Exception ex)
            {
                principal.MostrarError(ex.Message);
                
            }
        }


    }
}