using DevExpress.XtraBars;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Columns;

namespace RecursosHumanos.Empleados
{
    public partial class SolicitudVacaciones : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        Datos datos = new Datos();
        frmPrincipal frmprincipal = new frmPrincipal();
        Boolean CargaCompleta = false;
        //Boolean enBaseFecha = false;
        //Boolean enBaseDias = false;
        DateTime FechaInicioValidaVacaciones = new DateTime();


        public SolicitudVacaciones()
        {
            InitializeComponent();
            CargarDatos();
            txtDiasTomar.EditValue = 1;
        }

        public ControlVacaciones controlVacaciones;

        private void CargarEmpleado()
        {
            try
            {
                lkeEmpleado.Properties.DataSource = datos.ConsultaTabla("[dbo].[p_ConsultarEmpleadosParaVacacionesporUsuario]", "@Id_Usuario", Global.IDUsuario);
                lkeEmpleado.Properties.DisplayMember = "Nombre del Empleado";
                lkeEmpleado.Properties.ValueMember = "Numero de Identidad";
                lkeEmpleado.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
                lkeEmpleado.Properties.BestFit();
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

                if (lkeEmpleado.EditValue == null)
                {
                    resultado = false;
                }
                if (dtpFechaInicio.EditValue == null)
                {
                    resultado = false;
                }
                if (dtpFechaFinal.EditValue == null)
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

        private void CargarDatos()
        {
            CargarEmpleado();
        }

        private void GuardarVacacion()
        {
            try
            {
                if (ValidarRequerimientos() == true)
                {
                    if (AnioValido())
                    {
                        if (txtDiasTomar.Text != "" && txtDiasTomar.Text != "0")
                        {
                            int diasDisponibles = Convert.ToInt32(txtDiasDisponibles.Text);
                            int diasATomar = Convert.ToInt32(txtDiasTomar.Text);

                            if (diasATomar > diasDisponibles)
                            {
                                if (MessageBox.Show("Cuenta con menos dias de vacaciones de los solicitados. Desea proceder?", "Alerta!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                                {
                                    GuardarSolicitudVacaciones();
                                }
                            }
                            else
                            {
                                GuardarSolicitudVacaciones();
                            }
                        }
                        else
                        {
                            frmprincipal.MostrarError("La cantidad a dias a tomar no puede ser 0.");
                        }
                    }
                }
                else
                {
                    frmprincipal.MostrarError("Debe ingresar todos los datos para guardar.");
                }
            }
            catch (Exception ex)
            {
                frmprincipal.MostrarError(ex.Message);
            }
        }

        private void GuardarSolicitudVacaciones()
        {
            try
            {
                // asignar valor a lkeEmpleado y lkePuestos de la descripcion que tienen en el momento en que se guardan
                datos.Procedimiento("[dbo].[p_InsertarVacacion]",
                                     "@Numero_Identidad", lkeEmpleado.EditValue
                                    , "@Descripcion_Puestos", txtPuestos.Text//Buscar insertar los datos de la consulta y no los id number
                                    , "@Descripcion_Unidad", txtUnidad.Text
                                    , "@Dias_Solicitados", txtDiasTomar.Text
                                    , "@Id_Usuario_Creacion", Global.IDUsuario
                                    , "@Fecha_Inicial", dtpFechaInicio.EditValue
                                    , "@Fecha_Final", dtpFechaFinal.EditValue
                                    , "@Fecha_Regreso", dtpFechaRegreso.EditValue);
                controlVacaciones.Refrescar();
                this.Close();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private DataTable PeriodosVacaciones()
        {
            CargarPeriodos();

            gdvDatos.Columns["Periodo"].SortOrder = DevExpress.Data.ColumnSortOrder.Ascending;
            gdvDatos.RefreshData();

            DataTable resultado = new DataTable();
            int diasDisponibles = 0;
            int diasSolicitados = Convert.ToInt32(txtDiasTomar.Text);
            int periodoActual = 0;

            try
            {
                resultado.Columns.Add("Periodo",typeof(int));
                resultado.Columns.Add("Dias",typeof(int));

                for (int i = 0; i < gdvDatos.RowCount; i++)
                {
                    diasDisponibles = Convert.ToInt32(gdvDatos.GetRowCellValue(i, "Dias Disponibles")); //dias disponibles del periodo de la fila actual en base a i
                    periodoActual = Convert.ToInt32(gdvDatos.GetRowCellValue(i, "Periodo")); //periodo de la fila actual 

                    if (diasSolicitados > 0)
                    {
                        if (diasSolicitados <= diasDisponibles) //Si la cantidad de dias solicitados es menor o igual a los disponibles del primer periodo entonces solo se utilizará ese periodo
                        {
                            resultado.Rows.Add(periodoActual, diasSolicitados);
                            break;
                        }
                        else //de lo contrario se deberan tomar mas dias de otros periodos.
                        {
                            resultado.Rows.Add(periodoActual, diasDisponibles);
                            diasSolicitados = diasSolicitados - diasDisponibles;                            
                        }
                    }
                    else
                    {
                        break;
                    }                    
                }
            }
            catch (Exception ex)
            {
                frmprincipal.MostrarError(ex.Message);
                throw;
            }
            return resultado;
        }

        private bool AnioValido()
        {
            bool valido = true;
            try
            {
                //determinar el año del periodo mas antiguo disponible
                int anioAntiguo = 0;
                int anioEvaluar = 0;

                for (int i = 0; i < gdvDatos.RowCount; i++)
                {
                    anioEvaluar = Convert.ToInt32(gdvDatos.GetRowCellValue(i, "Periodo"));
                    if (i == 0)
                    {
                        anioAntiguo = anioEvaluar;                       
                    }
                    if (anioEvaluar < anioAntiguo) {
                        anioAntiguo = anioEvaluar;
                    }
                }
                //Si el año de la fecha inicial de la vacacion a solicitar es menor que el año mas antiguo de los periodos habilitados del empleado entonces no permitir
                if (Convert.ToDateTime(dtpFechaInicio.EditValue).Year < anioAntiguo)
                {
                    valido = false;
                    frmprincipal.MostrarError("El año de la fecha inicial de la vacacion es menor a el periodo mas antiguo habilitado para el empleado. Seleccione una fecha inicial valida.");
                }
            }
            catch (Exception ex)
            {
                frmprincipal.MostrarError(ex.Message);
                valido = false;
            }
            return valido;
        }


        private void CargarDatosEmpleado()
        {
            try
            {
                DataTable dataTable = new DataTable();
                dataTable = datos.ConsultaTabla("[dbo].[p_ConsultarEmpleadoPorIdentidadVacaciones]", "@Numero_Identidad", lkeEmpleado.EditValue);

                if (dataTable.Rows.Count > 0)
                {
                    txtRelojMarcador.Text = dataTable.Rows[0].ItemArray[dataTable.Columns["No. Reloj Marcador"].Ordinal].ToString();
                    txtUnidad.Text = dataTable.Rows[0].ItemArray[dataTable.Columns["Unidad"].Ordinal].ToString();
                    txtPuestos.Text = dataTable.Rows[0].ItemArray[dataTable.Columns["Puestos"].Ordinal].ToString();
                    txtDiasDisponibles.Text = dataTable.Rows[0].ItemArray[dataTable.Columns["Vacaciones Disponibles"].Ordinal].ToString();
                    FechaInicioValidaVacaciones = Convert.ToDateTime(dataTable.Rows[0].ItemArray[dataTable.Columns["Fecha Valida Inicio Vacaciones"].Ordinal].ToString());
                    dtpFechaInicio.Properties.MinValue = FechaInicioValidaVacaciones;
                }

            }
            catch (Exception ex)
            {
                frmprincipal.MostrarError(ex.Message);
            }
        }

        private void lkeEmpleado_EditValueChanged(object sender, EventArgs e)
        {
            CargarDatosEmpleado();
            CargarPeriodos();
            txtDiasDisponibles_Validating(null, null);
        }

        private void bbiGuardarVacaciones_ItemClick(object sender, ItemClickEventArgs e)
        {
            GuardarVacacion();
        }

        private void SolicitudVacaciones_Load(object sender, EventArgs e)
        {
            try
            {
                dtpFechaInicio.EditValue = DateTime.Now;
                dtpFechaFinal.EditValue = DateTime.Now;
                CargaCompleta = true;
                CalculaVacacionesenBaseaFechaFinal();
            }
            catch (Exception ex)
            {
                frmprincipal.MostrarError(ex.Message);
            }
        }

        private void CalculaVacacionesenBaseaFechaFinal()
        {
            try
            {
                if (CargaCompleta == true)
                {
                    if (dtpFechaInicio.EditValue != null && dtpFechaFinal.EditValue != null)
                    {
                        //Comprobar Fecha Inicial
                        if (Convert.ToDateTime(dtpFechaInicio.EditValue).Date.DayOfWeek == DayOfWeek.Saturday)
                        {
                            dtpFechaInicio.EditValue = Convert.ToDateTime(Convert.ToDateTime(dtpFechaInicio.EditValue).Date.AddDays(-1)).Date;
                        }
                        else if (Convert.ToDateTime(dtpFechaInicio.EditValue).Date.DayOfWeek == DayOfWeek.Sunday)
                        {
                            dtpFechaInicio.EditValue = Convert.ToDateTime(Convert.ToDateTime(dtpFechaInicio.EditValue).Date.AddDays(-2)).Date;
                        }

                        //Verificar Fecha Final
                        if (Convert.ToDateTime(dtpFechaFinal.EditValue).Date < Convert.ToDateTime(dtpFechaInicio.EditValue).Date)
                        {
                            dtpFechaFinal.EditValue = Convert.ToDateTime(dtpFechaInicio.EditValue).Date;
                        }

                        //Calcular fecha final
                        DateTime fechaInicial = Convert.ToDateTime(dtpFechaInicio.EditValue).Date;
                        DateTime fechaFinal = Convert.ToDateTime(dtpFechaFinal.EditValue).Date;
                        DateTime fechaRegreso = new DateTime();
                        int diasRango = Convert.ToInt32((fechaFinal - fechaInicial).TotalDays.ToString());
                        int diasNoHabiles = 0; int diasHabiles = 0;

                        //Comprobar fecha final
                        if (fechaFinal.DayOfWeek == DayOfWeek.Saturday)
                        {
                            dtpFechaFinal.EditValue = Convert.ToDateTime(fechaFinal.AddDays(-1)).Date;
                        }
                        else if (fechaFinal.DayOfWeek == DayOfWeek.Sunday)
                        {
                            dtpFechaFinal.EditValue = Convert.ToDateTime(fechaFinal.AddDays(-2)).Date;
                        }

                        //Calcular los dias no habiles en las fechas especificadas
                        while (fechaInicial <= fechaFinal)
                        {
                            if (fechaInicial.DayOfWeek == DayOfWeek.Saturday || fechaInicial.DayOfWeek == DayOfWeek.Sunday)
                            {
                                diasNoHabiles += 1;
                            }
                            else
                            {
                                diasHabiles += 1;
                            }

                            fechaInicial = fechaInicial.AddDays(1);
                        }

                        txtDiasTomar.Text = diasHabiles.ToString();

                        //Establecer fecha de regreso
                        fechaRegreso = fechaFinal.AddDays(1);
                        if (fechaRegreso.DayOfWeek == DayOfWeek.Friday)
                        {
                            dtpFechaRegreso.EditValue = fechaRegreso.AddDays(3);
                        }
                        if (fechaRegreso.DayOfWeek == DayOfWeek.Saturday)
                        {
                            dtpFechaRegreso.EditValue = fechaRegreso.AddDays(2);
                        }
                        else if (fechaRegreso.DayOfWeek == DayOfWeek.Sunday)
                        {
                            dtpFechaRegreso.EditValue = fechaRegreso.AddDays(1);
                        }
                        else
                        {
                            dtpFechaRegreso.EditValue = fechaRegreso;
                        }
                    }
                    else
                    {
                        frmprincipal.MostrarError("Ingrese una fecha inicial valida.");
                    }
                }
            }
            catch (Exception ex)
            {
                frmprincipal.MostrarError(ex.Message);
            }
        }

        private void CalculaVacacionesenBaseaDiasTomar()
        {
            try
            {
                if (CargaCompleta == true)
                {
                    if (txtDiasTomar.Text != "")
                    {
                        if (Convert.ToInt32(txtDiasTomar.Text) > 0)
                        {
                            if (dtpFechaInicio.EditValue != null && dtpFechaFinal.EditValue != null)
                            {
                                DateTime fechaInicial = Convert.ToDateTime(dtpFechaInicio.EditValue).Date;

                                //Comprobar Fecha Inicial
                                if (fechaInicial.DayOfWeek == DayOfWeek.Saturday)
                                {
                                    dtpFechaInicio.EditValue = Convert.ToDateTime(Convert.ToDateTime(dtpFechaInicio.EditValue).Date.AddDays(-1)).Date;
                                }
                                else if (Convert.ToDateTime(dtpFechaInicio.EditValue).Date.DayOfWeek == DayOfWeek.Sunday)
                                {
                                    dtpFechaInicio.EditValue = Convert.ToDateTime(Convert.ToDateTime(dtpFechaInicio.EditValue).Date.AddDays(-2)).Date;
                                }

                                //Asignar valores a variables                       
                                DateTime fechaFinal = Convert.ToDateTime(dtpFechaFinal.EditValue).Date.AddDays(Convert.ToInt32(txtDiasTomar.Text));
                                DateTime fechaRegreso = new DateTime().Date;

                                //Comprobar dia de la fecha final
                                if (fechaFinal.DayOfWeek == DayOfWeek.Saturday)
                                {
                                    dtpFechaFinal.EditValue = Convert.ToDateTime(fechaFinal.AddDays(-1)).Date;
                                }
                                else if (fechaFinal.DayOfWeek == DayOfWeek.Sunday)
                                {
                                    dtpFechaFinal.EditValue = Convert.ToDateTime(fechaFinal.AddDays(-2)).Date;
                                }

                                //Establecer fecha de regreso
                                fechaRegreso = fechaFinal.AddDays(1);
                                if (fechaRegreso.DayOfWeek == DayOfWeek.Friday)
                                {
                                    dtpFechaRegreso.EditValue = fechaRegreso.AddDays(3);
                                }
                                if (fechaRegreso.DayOfWeek == DayOfWeek.Saturday)
                                {
                                    dtpFechaRegreso.EditValue = fechaRegreso.AddDays(2);
                                }
                                else if (fechaRegreso.DayOfWeek == DayOfWeek.Sunday)
                                {
                                    dtpFechaRegreso.EditValue = fechaRegreso.AddDays(1);
                                }
                                else
                                {
                                    dtpFechaRegreso.EditValue = fechaRegreso;
                                }
                            }
                            else
                            {
                                frmprincipal.MostrarError("Ingrese una fecha inicial valida.");
                            }

                        }
                        else
                        {
                            frmprincipal.MostrarError("Introduzca un numero de dias a tomar mayor a 0.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                frmprincipal.MostrarError(ex.Message);
            }
        }

        private void dtpFechaFinal_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                CalculaVacacionesenBaseaFechaFinal();
            }
            catch (Exception ex)
            {
                frmprincipal.MostrarError(ex.Message);
            }
        }

        private void txtDiasTomar_Validating(object sender, CancelEventArgs e)
        {
            //CalculaVacacionesenBaseaDiasTomar();
        }

        private void dtpFechaInicio_EditValueChanged(object sender, EventArgs e)
        {
            CalculaVacacionesenBaseaFechaFinal();
        }

        private void txtDiasTomar_EditValueChanged(object sender, EventArgs e)
        {
            //CalculaVacacionesenBaseaDiasTomar();
        }

        private void txtDiasDisponibles_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                if (Convert.ToInt32(txtDiasDisponibles.Text) <= 0)
                {
                    txtDiasDisponibles.ForeColor = Color.Red;
                }
                else
                {
                    txtDiasDisponibles.ForeColor = Color.Black;
                }
            }
            catch (Exception ex)
            {
                frmprincipal.MostrarError(ex.Message);
            }
        }

        private void bbiCancelar_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Close();
        }

        private void CargarPeriodos()
        {
            try
            {
                if (lkeEmpleado.EditValue != null)
                {
                    gdcDatos.DataSource = datos.ConsultaTabla("[dbo].[p_ConsultarPeriodosVacacionesDisponiblesPorEmpleado]", "@Numero_Identidad", lkeEmpleado.EditValue);
                    gdvDatos.BestFitColumns();
                }

            }
            catch (Exception ex)
            {
                frmprincipal.MostrarError(ex.Message);
            }
        }
        
      
    }
}
