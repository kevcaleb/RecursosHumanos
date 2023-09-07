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
using DevExpress.XtraGrid.Views.Grid;
using RecursosHumanos.Empleados.Reportes;

namespace RecursosHumanos.Empleados
{
    public partial class ControlPermisos : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        frmPrincipal frmprincipal = new frmPrincipal();
        Datos datos = new Datos();

        public ControlPermisos()
        {
            InitializeComponent();
            Refrescar();
        }

        public void Refrescar()
        {
            
                try
                {
                    //Cargar Permisos Pendientes
                    gdcPendientes.DataSource = datos.ConsultaTabla("[dbo].[p_ConsultarPermisosPendientes]");
                    gdvPendientes.Columns["Fecha de Creacion"].DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
                    gdvPendientes.Columns["Fecha de Creacion"].DisplayFormat.FormatString = "dd/MM/yyyy hh:mm:ss tt";
                    gdvPendientes.BestFitColumns();

                    //Cargar Permisos Autorizados
                    gdcAutorizados.DataSource = datos.ConsultaTabla("[dbo].[p_ConsultarPermisosAutorizados]");
                    gdvAutorizados.Columns["Fecha de Creacion"].DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
                    gdvAutorizados.Columns["Fecha de Creacion"].DisplayFormat.FormatString = "dd/MM/yyyy hh:mm:ss tt";
                    gdvAutorizados.Columns["Fecha de Verificacion"].DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
                    gdvAutorizados.Columns["Fecha de Verificacion"].DisplayFormat.FormatString = "dd/MM/yyyy hh:mm:ss tt";
                    gdvAutorizados.BestFitColumns();

                    //Cargar Permisos Rechazados
                    gdcRechazados.DataSource = datos.ConsultaTabla("[dbo].[p_ConsultarPermisosRechazados]");
                    gdvRechazados.Columns["Fecha de Creacion"].DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
                    gdvRechazados.Columns["Fecha de Creacion"].DisplayFormat.FormatString = "dd/MM/yyyy hh:mm:ss tt";
                    gdvRechazados.Columns["Fecha de Verificacion"].DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
                    gdvRechazados.Columns["Fecha de Verificacion"].DisplayFormat.FormatString = "dd/MM/yyyy hh:mm:ss tt";
                    gdvRechazados.BestFitColumns();
                }
                catch (Exception ex)
                {
                    frmprincipal.MostrarError(ex.Message);
                }            
        }

        private void bbiNuevoPermiso_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Global.ComprobarPrivilegio(9) == true)
            {
                try
                {
                    if (Global.NumeroIdentidad != "")
                    {
                        SolicitudPermiso solicitudPermiso = new SolicitudPermiso();

                        solicitudPermiso.MdiParent = this.MdiParent;
                        solicitudPermiso.ControlPermisos = this;
                        solicitudPermiso.Show();
                    }
                    else
                    {
                        frmprincipal.MostrarError("El usuario actual no cuenta con un empleado. No puede proceder a solicitar permisos.");
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
        
        private void bbiAprobar_ItemClick(object sender, ItemClickEventArgs e)
        {
            
            try
            {
                if (tncPermisos.SelectedPage == tnpPendientes)
                {
                    if (gdvPendientes.RowCount >= 1)//Validacion para saber que hay una fila seleccionada de la pesta;a pendientes
                    {
                        if (Global.ComprobarPrivilegio(11) == true)
                        {

                            string idpermiso = gdvPendientes.GetRowCellValue(gdvPendientes.FocusedRowHandle, "Codigo de Permiso").ToString();//Alamcenamos codigo de permiso obtenido de la fila seleccionada y queda guardado en id de permiso y luego lo convertimos a string

                            if (MessageBox.Show("Desea proceder con la autorizacion del permiso " + idpermiso + "?", "Confirmar autorizacion", MessageBoxButtons.YesNo) == DialogResult.Yes)
                            {
                                datos.Procedimiento("[dbo].[p_AutorizarPermiso]", "@Codigo_Permiso", idpermiso, "@Usuario_Verificador", Global.IDUsuario);
                                Refrescar();


                                int exito;
                                exito = Convert.ToInt32(datos.ProcedimientoRetorno("[dbo].[p_AutorizarPermisosJefe]", "@Id_Solicitud_Vacaciones", gdvPendientes.GetRowCellValue(gdvPendientes.FocusedRowHandle, "ID"), "@Id_Usuario_Verificador", Global.IDUsuario, "@exito"));
                                Convert.ToInt32(exito);

                                if (exito == 1)
                                {
                                    frmprincipal.MostrarError("Se autorizó correctamente.");
                                }
                                else
                                {
                                    frmprincipal.MostrarError("No se autorizó, verifique el permiso nuevamente.");
                                }
                                Refrescar();
                            }
                            else
                            {
                                frmprincipal.MostrarError("El Usuario no cuenta con los privilegios.");
                            }
                        }
                        else
                        {
                            frmprincipal.MostrarError("Seleccione el permiso que desea autorizar.");
                        }

                    }
                    else
                    {
                        frmprincipal.MostrarError("Seleccion el permiso que desea autorizar.");
                    }
                }
            }
            catch (Exception ex)
            {
             frmprincipal.MostrarError(ex.Message);
            }
            
        }

        private void bbiRechazar_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Global.ComprobarPrivilegio(11) == true)
            {
                try
                {
                    if (tncPermisos.SelectedPage == tnpPendientes)
                    {
                        if (gdvPendientes.FocusedRowHandle >= 0)
                        {

                            if (gdvPendientes.FocusedRowHandle > -1)//Validacion para saber que hay una fila seleccionada de la pesta;a pendientes
                            {
                                string idpermiso = gdvPendientes.GetRowCellValue(gdvPendientes.FocusedRowHandle, "Codigo de Permiso").ToString();//Alamcenamos codigo de permiso obtenido de la fila seleccionada y queda guardado en id de permiso y luego lo convertimos a string

                                if (MessageBox.Show("Desea proceder con el Rachazo del permiso " + idpermiso + "?", "Confirmar Rechazo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                                {
                                    datos.Procedimiento("[dbo].[p_RechazarPermiso]", "@Codigo_Permiso", idpermiso, "@Usuario_Verificador", Global.IDUsuario);
                                    Refrescar();
                                }
                            }
                            else
                            {
                                frmprincipal.MostrarError("Seleccione el permiso que desea rechazar.");
                            }
                        }
                        else
                        {
                            frmprincipal.MostrarError("Seleccione el permiso que desea rechazar.");
                        }

                    }
                    else
                    {
                        frmprincipal.MostrarError("Seleccion el permiso que desea rechazar.");
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

        private void bbiExportar_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {

                
                if (tncPermisos.SelectedPage == tnpPendientes)

                {
                    Global.ExportarGridExcel(gdcPendientes);
                }
                else
                if (tncPermisos.SelectedPage == tnpAutorizados)//Validacion para saber que hay una fila seleccionada de la pesta;a pendientes
                {
                    Global.ExportarGridExcel(gdcAutorizados);
                }
                else
                if (tncPermisos.SelectedPage == tnpRechazados)
                {
                    Global.ExportarGridExcel(gdcRechazados);
                }
                    
             
            }
            catch (Exception ex)
            {
                frmprincipal.MostrarError(ex.Message);
            }
        }

        private void bbiImprimir_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                GridView gridView = new GridView();
                if (tncPermisos.SelectedPage == tnpPendientes)
                {
                    gridView = gdvPendientes;
                }else if (tncPermisos.SelectedPage == tnpAutorizados)
                {
                    gridView = gdvAutorizados;
                }else if (tncPermisos.SelectedPage == tnpRechazados)
                {
                    gridView = gdvRechazados;
                } else { gridView = null; }

                if (gridView.FocusedRowHandle > -1)
                {
                    ImpresionPermiso impresionPermiso = new ImpresionPermiso();
                    impresionPermiso.id = Convert.ToInt32(gridView.GetRowCellValue(gridView.FocusedRowHandle,"Codigo de Permiso"));
                    impresionPermiso.MdiParent = this.MdiParent;
                    impresionPermiso.Show();
                }
                else
                {
                    frmprincipal.MostrarError("Seleccione un permiso para imprimir.");
                }
                
            }
            catch (Exception ex)
            {
                frmprincipal.MostrarError(ex.Message);
            }
        }
    }
}
