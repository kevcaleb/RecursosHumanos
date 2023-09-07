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
using RecursosHumanos.Configuracion.Usuarios;

namespace RecursosHumanos.Empleados
{
    public partial class ControlUsuarios : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        frmPrincipal frmPrincipal = new frmPrincipal();
        Datos datos = new Datos();
        bool EsNuevo = false;


        public ControlUsuarios()
        {          
            InitializeComponent();
            Refrescar();
        }

        private void bbiAgregarUsuario_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Global.ComprobarPrivilegio(22) == true)
            {
                EdicionUsuario edicionUsuario = new EdicionUsuario();//Aqui se crea una nueva instancia de edicion de Usuarios
                edicionUsuario.MdiParent = this.MdiParent;
                edicionUsuario.controlUsuarios = this;
                edicionUsuario.Show();
            }
            else
            {
                frmPrincipal.MostrarError("El Usuario no cuenta con los privilegios.");
            }
        }

        private void bbiEditarUsuario_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Global.ComprobarPrivilegio(19) == true)
            {
                try
                 {
                     if (tncUsuarios.SelectedPage == tnpUsuariosActivos)
                     {
                         if (gdvUsuariosActivos.FocusedRowHandle >= 0)
                         {
                             EdicionUsuario edicionUsuario = new EdicionUsuario(gdvUsuariosActivos.GetRowCellValue(gdvUsuariosActivos.FocusedRowHandle, "ID de Usuario").ToString());
                             edicionUsuario.MdiParent = this.MdiParent;
                             edicionUsuario.controlUsuarios = this;
                             edicionUsuario.Show();
                         }
                         else
                         {
                             frmPrincipal.MostrarError("Seleccione el Usuario a modificar.");
                         }
                     }
                     else
                     {
                         frmPrincipal.MostrarError("No se pueden modificar Usuarios inactivos.");
                     }
                 }
                 catch (Exception ex)
                 {

                     frmPrincipal.MostrarError(ex.Message);
                 }
            }
            else
            {
                frmPrincipal.MostrarError("El Usuario no cuenta con los privilegios.");
            }
        }

        public void Refrescar()
        {
            try
            {
                gdcUsuariosActivos.DataSource = datos.ConsultaTabla("[dbo].[p_ConsultarUsuariosActivos]");
                gdvUsuariosActivos.BestFitColumns();
                gdcUsuariosInactivos.DataSource = datos.ConsultaTabla("[dbo].[p_ConsultarUsuariosInactivos]");
                gdvUsuariosInactivos.BestFitColumns();
            }
            catch (Exception ex)
            {

                frmPrincipal.MostrarError(ex.Message);
            }
        }
        
        private void bbiRefrescar_ItemClick(object sender, ItemClickEventArgs e)
        {
            Refrescar();
        }

        private void bbiInactivarUsuario_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Global.ComprobarPrivilegio(25) == true)
            {
                try
                {
                    if (tncUsuarios.SelectedPage == tnpUsuariosInactivos)
                    {
                        frmPrincipal.MostrarError("No se permite inactivar empleados inactivos. ");
                    }
                    else
                    {
                        if (gdvUsuariosActivos.FocusedRowHandle >= 0)
                        {
                            if (MessageBox.Show("Esta seguro que desea inactivar este empleado " + gdvUsuariosActivos.GetRowCellValue(gdvUsuariosActivos.FocusedRowHandle, "Nombre del Usuario"), "Inactivar Usuario", MessageBoxButtons.YesNo) == DialogResult.Yes)
                            {
                                datos.Procedimiento("[dbo].[p_InactivarUsuario]", "@Id_Usuario", gdvUsuariosActivos.GetRowCellValue(gdvUsuariosActivos.FocusedRowHandle, "ID de Usuario"));
                                Refrescar();
                            }
                        }
                        else
                        {
                            frmPrincipal.MostrarError("Seleccione un empleado.");
                        }
                    }

                }
                catch (Exception ex)
                {

                    frmPrincipal.MostrarError(ex.Message);
                }
            }
            else
            {
                frmPrincipal.MostrarError("El Usuario no cuenta con los privilegios.");
            }
        }

        private void bbitActivar_Usuario_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Global.ComprobarPrivilegio(18) == true)
            {
                try
                {
                    if (tncUsuarios.SelectedPage == tnpUsuariosActivos)
                    {
                        frmPrincipal.MostrarError("No se permite activar empleados activos. ");
                    }
                    else
                    {
                        if (gdvUsuariosInactivos.FocusedRowHandle >= 0)
                        {
                            if (MessageBox.Show("Esta seguro que desea activar a este empleado? " + gdvUsuariosInactivos.GetRowCellValue(gdvUsuariosInactivos.FocusedRowHandle, "Nombre del Usuario"), "Inactivar Usuario", MessageBoxButtons.YesNo) == DialogResult.Yes)
                            {
                                datos.Procedimiento("[dbo].[p_ActivarUsuario]", "@Id_Usuario", gdvUsuariosInactivos.GetRowCellValue(gdvUsuariosInactivos.FocusedRowHandle, "ID de Usuario"));
                                Refrescar();
                            }
                        }
                        else
                        {
                            frmPrincipal.MostrarError("Seleccione un empleado.");
                        }
                    }

                }
                catch (Exception ex)
                {

                    frmPrincipal.MostrarError(ex.Message);
                }
            }
            else
            {
                frmPrincipal.MostrarError("El Usuario no cuenta con los privilegios.");
            }
        }

        private void bbitModificarPermisos_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Global.ComprobarPrivilegio(23) == true)
            {
                try
                {
                    if (tncUsuarios.SelectedPage == tnpUsuariosActivos)
                    {
                        if (gdvUsuariosActivos.FocusedRowHandle >= 0)
                        {
                            string Id_Usuario = gdvUsuariosActivos.GetRowCellValue(gdvUsuariosActivos.FocusedRowHandle, "ID de Usuario").ToString();
                            ControlPrivilegios controlPrivilegios = new ControlPrivilegios(Id_Usuario);
                            controlPrivilegios.MdiParent = this.MdiParent;
                            controlPrivilegios.Show();
                        }
                        else
                        {
                            frmPrincipal.MostrarError("Seleccione un usuario.");
                        }
                    }
                    else
                    {
                        frmPrincipal.MostrarError("Seleccione un usuario activo.");
                    }
                }
                catch (Exception ex)
                {
                    frmPrincipal.MostrarError(ex.Message);
                }
            }
            else
            {
                frmPrincipal.MostrarError("El Usuario no cuenta con los privilegios.");
            }
        }

        private void bbiEliminarUsuario_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (Global.ComprobarPrivilegio(21) == true)
            {
                try
                {
                    if (tncUsuarios.SelectedPage == tnpUsuariosActivos)
                    {
                        frmPrincipal.MostrarError("No se permite eliminar usuarios activos. ");
                    }
                    else
                    {
                        if (gdvUsuariosInactivos.FocusedRowHandle >= 0)
                        {
                            if (MessageBox.Show("Esta seguro que desea eliminar este Usuario " + gdvUsuariosInactivos.GetRowCellValue(gdvUsuariosInactivos.FocusedRowHandle, "ID de Usuario"), "Eliminar Empleado", MessageBoxButtons.YesNo) == DialogResult.Yes)
                            {
                                datos.Procedimiento("[dbo].[p_EliminarUsuario]", "@Id_Usuario", gdvUsuariosInactivos.GetRowCellValue(gdvUsuariosInactivos.FocusedRowHandle, "ID de Usuario"));
                                Refrescar();
                            }
                        }
                        else
                        {
                            frmPrincipal.MostrarError("Seleccione un Usuario.");
                        }
                    }

                }
                catch (Exception ex)
                {
                    frmPrincipal.MostrarError(ex.Message);
                }
            }
            else
            {
                frmPrincipal.MostrarError("El Usuario no cuenta con los privilegios.");
            }

        }

        private void ControlUsuarios_Load(object sender, EventArgs e)
        {

        }
    }
    
}