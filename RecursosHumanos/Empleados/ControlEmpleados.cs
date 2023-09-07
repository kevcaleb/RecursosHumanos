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
    public partial class ControlEmpleados : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        Datos datos = new Datos();
        frmPrincipal frmPrincipal = new frmPrincipal();
        
        public ControlEmpleados()
        {
            InitializeComponent();
        }
        
        private void ControlEmpleados_Load(object sender, EventArgs e)
        {
            Refrescar();
            gdcEmpleadosActivos.Show();
        }

        public ControlEmpleados control;

        public void Refrescar()
        {
            try
            {
                gdcEmpleadosActivos.DataSource = datos.ConsultaTabla("[dbo].[p_ConsultarEmpleadosActivos]");
                gdvEmpleadosActivos.BestFitColumns();
                gdcEmpleadosInactivos.DataSource = datos.ConsultaTabla("[dbo].[p_ConsultarEmpleadosInactivos]");
                gdvEmpleadosInactivos.BestFitColumns();
            }
            catch (Exception ex)
            {

                frmPrincipal.MostrarError(ex.Message);
            }
        }

        private void bbiNuevoEmpleado_ItemClick(object sender, ItemClickEventArgs e)
        {
            EdicionEmpleado edicionEmpleado = new EdicionEmpleado();//Aqui se crea una nueva instancia de edicion de empleados
            edicionEmpleado.MdiParent = this.MdiParent;
            edicionEmpleado.controlEmpleados = this;
            edicionEmpleado.Show();
        }

        private void bbiEditarEmpleado_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                if(tncEmpelados.SelectedPage == tnpEmpleadosActivos)
                {
                    if (gdvEmpleadosActivos.FocusedRowHandle >=0)
                    {
                        EdicionEmpleado edicionEmpleado = new EdicionEmpleado(gdvEmpleadosActivos.GetRowCellValue(gdvEmpleadosActivos.FocusedRowHandle, "Numero de Identidad").ToString());
                        edicionEmpleado.MdiParent = this.MdiParent;
                        edicionEmpleado.controlEmpleados = this;
                        edicionEmpleado.Show();
                    }
                    else
                    {
                        frmPrincipal.MostrarError("Seleccione el empleado a modificar.");
                    }
                }
                else
                {
                    frmPrincipal.MostrarError("No se pueden modificar empleados inactivos.");
                }
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

        private void bbiEliminarEmpleado_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                if (tncEmpelados.SelectedPage == tnpEmpleadosActivos)
                {
                    frmPrincipal.MostrarError("No se permite eliminar empleados activos. ");
                }
                else
                {
                    if (gdvEmpleadosInactivos.FocusedRowHandle >=0)
                    {
                        if (MessageBox.Show("Esta seguro que desea eliminar este empleado " + gdvEmpleadosInactivos.GetRowCellValue(gdvEmpleadosInactivos.FocusedRowHandle, "Nombre del Empleado"), "Eliminar Empleado", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            datos.Procedimiento("[dbo].[p_EliminarEmpleado]", "@Numero_Identidad", gdvEmpleadosInactivos.GetRowCellValue(gdvEmpleadosInactivos.FocusedRowHandle, "Numero de Identidad"));
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

        private void bbiInactivarEmpleado_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                if (tncEmpelados.SelectedPage == tnpEmpleadosInactivos)
                {
                    frmPrincipal.MostrarError("No se permite inactivar empleados inactivos. ");
                }
                else
                {
                    if (gdvEmpleadosActivos.FocusedRowHandle >= 0)
                    {
                        if (MessageBox.Show("Esta seguro que desea inactivar este empleado " + gdvEmpleadosActivos.GetRowCellValue(gdvEmpleadosActivos.FocusedRowHandle, "Nombre del Empleado"), "Inactivar Empleado", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            datos.Procedimiento("[dbo].[p_InactivarEmpleado]", "@Numero_Identidad", gdvEmpleadosActivos.GetRowCellValue(gdvEmpleadosActivos.FocusedRowHandle, "Numero de Identidad"));
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

        private void ribbon_Click(object sender, EventArgs e)
        {

        }
    }
}