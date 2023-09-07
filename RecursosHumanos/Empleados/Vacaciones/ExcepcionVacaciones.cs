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
    public partial class ExcepcionVacaciones : DevExpress.XtraBars.Ribbon.RibbonForm
    {

        frmPrincipal principal = new frmPrincipal();
        DataTable tipoExcepcion = new DataTable();
        Datos datos = new Datos();
        public ControlVacaciones controlVacaciones;

        public ExcepcionVacaciones()
        {
            InitializeComponent();
        }

        private void ExcepcionVacaciones_Load(object sender, EventArgs e)
        {
            txteDias.Text = "0";
            CargarTiposExcepcion();
            CargarEmpleados();
        }

        private void bbiGuardar_ItemClick(object sender, ItemClickEventArgs e)
        {
            Guardar();
        }

        private void bbiCancelar_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Close();
        }

        private void CargarEmpleados()
        {
            try
            {
                gdcDatos.DataSource = null;
                gdcDatos.DataSource = datos.ConsultaVista("[dbo].[v_EmpleadosActivosExcepcion]");

                

                gdvDatos.BestFitColumns();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void CargarTiposExcepcion()
        {
            try
            {
                lkeTipoExcepcion.Properties.DataSource = datos.ConsultaTabla("[dbo].[p_ConsultarTiposExcepcionVacaciones]");
                lkeTipoExcepcion.Properties.DisplayMember = "Tipo";
                lkeTipoExcepcion.Properties.ValueMember = "ID";
                lkeTipoExcepcion.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
                lkeTipoExcepcion.Properties.BestFit();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void Guardar()
        {
            try
            {
                if (txteDias.Text != "")
                {
                    if (Convert.ToInt32(txteDias.Text) != 0)
                    {
                        if (lkeTipoExcepcion.EditValue != null)
                        {
                            if (txteComentarios.Text != "")
                            {
                                if (gdvDatos.SelectedRowsCount > 0)
                                {
                                    DataTable tablaSeleccion = new DataTable();
                                    tablaSeleccion.Columns.Add("ID");

                                    int[] id = gdvDatos.GetSelectedRows();

                                    for (int i = 0; i < id.Length; i++)
                                    {
                                        tablaSeleccion.Rows.Add(gdvDatos.GetRowCellValue(id[i],"Numero de Identidad"));
                                    }

                                    datos.Procedimiento("[dbo].[p_InsertarExcepcionEmpleado]",
                                                        "@tablaEmpleados", tablaSeleccion,
                                                        "@Codigo_Tipo_Excepcion", lkeTipoExcepcion.EditValue,
                                                        "@Dias",txteDias.Text,
                                                        "@Comentarios", txteComentarios.Text,
                                                        "@Id_Usuario",Global.IDUsuario);
                                    this.Close();
                                    controlVacaciones.Refrescar();
                                }
                                else
                                {
                                    principal.MostrarError("Seleccione al menos un empleado para proceder.");
                                }
                            }
                            else
                            {
                                principal.MostrarError("Ingrese los comentarios de la excepcion.");
                                txteComentarios.Focus();
                            }
                        }
                        else
                        {
                            principal.MostrarError("Seleccione el tipo de excepcion.");
                            lkeTipoExcepcion.Focus();
                        }
                    } else
                    {
                        principal.MostrarError("Ingrese una cantidad de dias valida.");
                        txteDias.Focus();
                    }
                }
                else
                {
                    principal.MostrarError("Ingrese una cantidad de dias valida.");
                    txteDias.Focus();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        
    }
}