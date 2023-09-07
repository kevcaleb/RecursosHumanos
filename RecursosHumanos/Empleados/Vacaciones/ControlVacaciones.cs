using DevExpress.XtraBars;
using System;
using System.Windows.Forms;

namespace RecursosHumanos.Empleados
{
    public partial class ControlVacaciones : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        frmPrincipal frmPrincipal = new frmPrincipal();
        Datos datos = new Datos();

        public ControlVacaciones()
        {
            InitializeComponent();
        }

        private void ControlVacaciones_Load(object sender, EventArgs e)
        {
            try
            {
                Refrescar();
            }
            catch (Exception ex)
            {
                frmPrincipal.MostrarError(ex.Message);
            }
        }

        public void Refrescar()
        {
            try
            {
                //Cargar solicitudes
                gdcSolicitudesVacaciones.DataSource = datos.ConsultaTabla("[dbo].[p_ConsultarVacacionesSolicitud]", "@Id_Usuario", Global.IDUsuario);
                gdvSolicitudesVacaciones.Columns["Fecha de Verificacion"].DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
                gdvSolicitudesVacaciones.Columns["Fecha de Verificacion"].DisplayFormat.FormatString = "dd/MM/yyyy hh:mm tt";
                gdvSolicitudesVacaciones.Columns["Fecha de Verificacion"].Visible = false;
                gdvSolicitudesVacaciones.Columns["Usuario Verificador"].Visible = false;
                gdvSolicitudesVacaciones.BestFitColumns();

                //Cargar vacaciones autorizadas Jefe
                gdcVacacionesAutorizadasJefe.DataSource = datos.ConsultaTabla("[dbo].[p_ConsultarVacacionesAutorizadaJefe]", "@Id_Usuario", Global.IDUsuario);
                gdvSolicitudesVacaciones.Columns["Fecha de Verificacion"].DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
                gdvSolicitudesVacaciones.Columns["Fecha de Verificacion"].DisplayFormat.FormatString = "dd/MM/yyyy hh:mm tt";
                gdvVacacionesAutorizadasJefe.BestFitColumns();

                //Cargar vacaciones autorizadas RRHH
                gdcVacacionesAutorizadasRRHH.DataSource = datos.ConsultaTabla("[dbo].[p_ConsultarVacacionesAutorizadaRRHH]", "@Id_Usuario", Global.IDUsuario);
                gdvSolicitudesVacaciones.Columns["Fecha de Verificacion"].DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
                gdvSolicitudesVacaciones.Columns["Fecha de Verificacion"].DisplayFormat.FormatString = "dd/MM/yyyy hh:mm tt";
                gdvVacacionesAutorizadasRRHH.BestFitColumns();

                //Cargar vacaciones rechazadas
                gdcVacacionesRechazadas.DataSource = datos.ConsultaTabla("[dbo].[p_ConsultarVacacionesAutorizadaRechazadas]", "@Id_Usuario", Global.IDUsuario);
                gdvSolicitudesVacaciones.Columns["Fecha de Verificacion"].DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
                gdvSolicitudesVacaciones.Columns["Fecha de Verificacion"].DisplayFormat.FormatString = "dd/MM/yyyy hh:mm tt";
                gdvVacacionesRechazadas.BestFitColumns();

                //Cargar Vacaciones Suspendidas
                gdcVacacionesSuspendidas.DataSource = datos.ConsultaTabla("[dbo].[p_ConsultarVacacionesSuspendidas]", "@Id_Usuario", Global.IDUsuario);
                gdvVacacionesSuspendidas.Columns["Fecha de Verificacion"].DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
                gdvVacacionesSuspendidas.Columns["Fecha de Verificacion"].DisplayFormat.FormatString = "dd/MM/yyyy hh:mm tt";
                gdvVacacionesSuspendidas.BestFitColumns();

                //Cargar Excepciones
                gdcExcepciones.DataSource = datos.ConsultaTabla("[dbo].[p_ConsultarExcepciones]");
                gdvExcepciones.Columns["Fecha de Creacion"].DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
                gdvExcepciones.Columns["Fecha de Creacion"].DisplayFormat.FormatString = "dd/MM/yyyy hh:mm tt";
                gdvExcepciones.BestFitColumns();

            }
            catch (Exception ex)
            {
                frmPrincipal.MostrarError(ex.Message);
            }
        }

        private void bbiAutorizarSolicitud_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                if (tncVacaciones.SelectedPage == tnpSolicitudesVacaciones)//Privilegio de Aprobacion_Jefe de unidad
                {
                    if (gdvSolicitudesVacaciones.RowCount >= 1)
                    {
                        if (MessageBox.Show("Desea autorizar la solicitud de vacaciones seleccionada?", "Autorizar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            int exito;
                            exito = Convert.ToInt32(datos.ProcedimientoRetorno("[dbo].[p_AutorizarVacacionesJefe]", "@Id_Solicitud_Vacaciones", gdvSolicitudesVacaciones.GetRowCellValue(gdvSolicitudesVacaciones.FocusedRowHandle, "ID"), "@Id_Usuario_Verificador", Global.IDUsuario, "@exito"));
                            Convert.ToInt32(exito);

                            if (exito == 1)
                            {
                                frmPrincipal.MostrarError("Se autorizó correctamente.");
                            }
                            else
                            {
                                frmPrincipal.MostrarError("No se autorizó, verifique el permiso nuevamente.");
                            }
                            Refrescar();
                        }
                    }
                    else
                    {
                        frmPrincipal.MostrarError("Seleccione una solicitud pendiente.");
                    }
                }
                else if (tncVacaciones.SelectedPage == tnpVacacionesAutorizadasJefe)
                {
                    if (gdvVacacionesAutorizadasJefe.RowCount > 0)
                    {
                        if (MessageBox.Show("Desea autorizar la solicitud de vacaciones seleccionada?", "Autorizar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            int resultado = Convert.ToInt32(datos.ProcedimientoRetorno("[dbo].[p_AutorizarVacacionesRRHH]", "@Id_Solicitud_Vacaciones", gdvVacacionesAutorizadasJefe.GetRowCellValue(gdvVacacionesAutorizadasJefe.FocusedRowHandle, "ID"),
                             "@Id_Usuario_Verificador", Global.IDUsuario, "@Exito"));
                            if (resultado == 1)
                            {
                                frmPrincipal.MostrarExito("Solicitud autorizada exitosamente.");
                            }
                            else
                            {
                                frmPrincipal.MostrarError("No se autorizó, verifique el permiso nuevamente.");
                            }
                            Refrescar();
                        }
                    }
                    else
                    {
                        frmPrincipal.MostrarError("Seleccione una solicitud pendiente.");
                    }
                }
            }
            catch (Exception ex)
            {
                frmPrincipal.MostrarError(ex.Message);
            }
        }

        private void bbiSolicitudVacaciones_ItemClick(object sender, ItemClickEventArgs e)
        {
            //bool res = true;
            //crear condicion para evaluar si hay mas de una solicitud por vacacion por empleeado y si ya tiene una ingresada no permitirle crear otra
            //if (gdvSolicitudesVacaciones.RowCount >= 1)
            //{
            //    res = true;
            //}
            //  if(res==true)
            //{
            SolicitudVacaciones solicitudVacaciones = new SolicitudVacaciones();//Aqui se crea una nueva instancia de edicion de empleados
            solicitudVacaciones.MdiParent = this.MdiParent;
            solicitudVacaciones.controlVacaciones = this;
            solicitudVacaciones.Show();
            //}
            //  else
            //{
            //    frmPrincipal.MostrarError("No se permite ingresar mas de una solicitud a la vez.");
            //}


        }

        private void bbiRefrescar_ItemClick(object sender, ItemClickEventArgs e)
        {
            Refrescar();
        }

        private void bbiRechazarSolicitud_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                if (tncVacaciones.SelectedPage == tnpSolicitudesVacaciones)
                {
                    if (gdvSolicitudesVacaciones.FocusedRowHandle >= 0)
                    {
                        RechazoSolicitudVacaciones comentariosRechazos = new RechazoSolicitudVacaciones(gdvSolicitudesVacaciones.GetRowCellValue(gdvSolicitudesVacaciones.FocusedRowHandle, "ID").ToString());//Aqui se crea una nueva instancia de edicion de empleados
                        comentariosRechazos.controlVacaciones = this;
                        comentariosRechazos.MdiParent = this.MdiParent;
                        comentariosRechazos.Show();

                        if (gdvSolicitudesVacaciones.RowCount >= 1)
                        {
                            if (Global.ComprobarPrivilegio(1032) == true || Global.ComprobarPrivilegio(1038) == true)
                            {
                                if (MessageBox.Show("Desea Rechazar la solicitud de vacaciones seleccionada?", "Autorizar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                                {
                                    int exito;
                                    exito = Convert.ToInt32(datos.ProcedimientoRetorno("[dbo].[p_RechazarVacacionesJefe]", "@Id_Solicitud_Vacaciones", gdvSolicitudesVacaciones.GetRowCellValue(gdvSolicitudesVacaciones.FocusedRowHandle, "ID"), "@Id_Usuario_Verificador", Global.IDUsuario, "@exito"));
                                    Convert.ToInt32(exito);

                                    if (exito == 1)
                                    {
                                        frmPrincipal.MostrarError("Se Rechazo correctamente.");
                                    }
                                    else
                                    {
                                        frmPrincipal.MostrarError("No se autorizó, verifique el permiso nuevamente.");
                                    }
                                    Refrescar();
                                }
                            }
                            else if (Global.ComprobarPrivilegio(1033) == true || Global.ComprobarPrivilegio(1038) == true)
                            {
                                if (MessageBox.Show("Desea Rechazar la solicitud de vacaciones seleccionada?", "Autorizar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                                {
                                    int exito;
                                    exito = Convert.ToInt32(datos.ProcedimientoRetorno("[dbo].[p_RechazarVacacionesRRHH]", "@Id_Solicitud_Vacaciones", gdvSolicitudesVacaciones.GetRowCellValue(gdvSolicitudesVacaciones.FocusedRowHandle, "ID"), "@Id_Usuario_Verificador", Global.IDUsuario, "@exito"));
                                    Convert.ToInt32(exito);

                                    if (exito == 1)
                                    {
                                        frmPrincipal.MostrarError("Se autorizó correctamente.");
                                    }
                                    else
                                    {
                                        frmPrincipal.MostrarError("No se autorizó, verifique el permiso nuevamente.");
                                    }
                                    Refrescar();
                                }
                            }
                            else
                            {
                                frmPrincipal.MostrarErrorPrivilegios();
                            }

                        }
                        else
                        {
                            frmPrincipal.MostrarError("Seleccione una solicitud pendiente.");
                        }
                    }
                    else
                    {
                        frmPrincipal.MostrarError("Seleccione una solicitud de vacaciones.");
                    }
                }
                else
                {
                    frmPrincipal.MostrarError("Solo se pueden rechazar solicitudes de vacaciones.");
                }
            }
            catch (Exception ex)
            {
                frmPrincipal.MostrarError(ex.Message);
            }
        }

        private void bbiExportar_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                if (tncVacaciones.SelectedPage == tnpSolicitudesVacaciones)//Cambiar la validacion por la pestana seleccionada
                {
                    Global.ExportarGridExcel(gdcSolicitudesVacaciones);
                }
                else
                if (tncVacaciones.SelectedPage == tnpVacacionesAutorizadasRRHH)
                {
                    Global.ExportarGridExcel(gdcVacacionesAutorizadasRRHH);
                }
                else
                if (tncVacaciones.SelectedPage == tnpVacacionesRechazadas)
                {
                    Global.ExportarGridExcel(gdcVacacionesRechazadas);
                }
                else
                if (tncVacaciones.SelectedPage == tnpVacacionesSuspendidas)
                {
                    Global.ExportarGridExcel(gdcVacacionesSuspendidas);
                }

            }
            catch (Exception ex)
            {
                frmPrincipal.MostrarError(ex.Message);
            }

        }

        private void bbiSuspender_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                if (tncVacaciones.SelectedPage == tnpVacacionesAutorizadasRRHH)
                {
                    if (gdvVacacionesAutorizadasRRHH.FocusedRowHandle >= 0)
                    {
                        SuspensionSolicitudVacaciones suspensionSolicitudVacaciones = new SuspensionSolicitudVacaciones(gdvVacacionesAutorizadasRRHH.GetRowCellValue(gdvVacacionesAutorizadasRRHH.FocusedRowHandle, "ID").ToString());//Aqui se crea una nueva instancia de edicion de empleados
                        suspensionSolicitudVacaciones.controlVacaciones = this;
                        suspensionSolicitudVacaciones.MdiParent = this.MdiParent;
                        suspensionSolicitudVacaciones.Show();
                    }
                    else
                    {
                        frmPrincipal.MostrarError("Seleccione una vacación autorizada por RRHH.");
                    }
                }
                else
                {
                    frmPrincipal.MostrarError("Solo se pueden suspender vacaciones autorizadas por RRHH.");
                }
            }
            catch (Exception ex)
            {
                frmPrincipal.MostrarError(ex.Message);
            }
        }

        private void bbiImprimir_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                int ID = 0;

                if (tncVacaciones.SelectedPage == tnpSolicitudesVacaciones)//Cambiar la validacion por la pestana seleccionada
                {
                    if (gdvSolicitudesVacaciones.FocusedRowHandle >= 0)
                    {
                        ID = Convert.ToInt32(gdvSolicitudesVacaciones.GetRowCellValue(gdvSolicitudesVacaciones.FocusedRowHandle, "ID"));
                    }
                }
                else
                if (tncVacaciones.SelectedPage == tnpVacacionesAutorizadasJefe)//Cambiar la validacion por la pestana seleccionada
                {
                    if (gdvVacacionesAutorizadasJefe.FocusedRowHandle >= 0)
                    {
                        ID = Convert.ToInt32(gdvVacacionesAutorizadasJefe.GetRowCellValue(gdvVacacionesAutorizadasJefe.FocusedRowHandle, "ID"));
                    }
                }
                if (tncVacaciones.SelectedPage == tnpVacacionesAutorizadasRRHH)//Cambiar la validacion por la pestana seleccionada
                {
                    if (gdvVacacionesAutorizadasRRHH.FocusedRowHandle >= 0)
                    {
                        ID = Convert.ToInt32(gdvVacacionesAutorizadasRRHH.GetRowCellValue(gdvVacacionesAutorizadasRRHH.FocusedRowHandle, "ID"));
                    }
                }
                else
                if (tncVacaciones.SelectedPage == tnpVacacionesRechazadas)//Cambiar la validacion por la pestana seleccionada
                {
                    if (gdvVacacionesRechazadas.FocusedRowHandle >= 0)
                    {
                        ID = Convert.ToInt32(gdvVacacionesRechazadas.GetRowCellValue(gdvVacacionesRechazadas.FocusedRowHandle, "ID"));
                    }
                }
                else
                if (tncVacaciones.SelectedPage == tnpVacacionesSuspendidas)//Cambiar la validacion por la pestana seleccionada
                {
                    if (gdvVacacionesSuspendidas.FocusedRowHandle >= 0)
                    {
                        ID = Convert.ToInt32(gdvVacacionesSuspendidas.GetRowCellValue(gdvVacacionesSuspendidas.FocusedRowHandle, "ID"));
                    }
                }
                else
                {
                    if (ID == 0)
                    {
                        frmPrincipal.MostrarError("Seleccione una solicitud de vacaciones valida.");
                    }
                }

                if (ID != 0)
                {
                    Reportes.ImpresionSolicitudVacaciones impresionSolicitudVacaciones = new Reportes.ImpresionSolicitudVacaciones();
                    impresionSolicitudVacaciones.ID = ID;
                    impresionSolicitudVacaciones.MdiParent = this.MdiParent;
                    impresionSolicitudVacaciones.Show();
                }

            }
            catch (Exception ex)
            {
                frmPrincipal.MostrarError(ex.Message);
            }
        }

        private void bbiAgregarExepcion_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                ExcepcionVacaciones excepcionVacaciones = new ExcepcionVacaciones();
                excepcionVacaciones.controlVacaciones = this;
                excepcionVacaciones.MdiParent = this.MdiParent;
                excepcionVacaciones.Show();
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}