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

namespace RecursosHumanos.Empleados.Consultas
{
    public partial class ConsultaVacacionesEmpleado : DevExpress.XtraBars.Ribbon.RibbonForm
    {

        Datos datos = new Datos();

        public string idEmpleado { get; set; }

        public ConsultaVacacionesEmpleado()
        {
            InitializeComponent();
        }

        private void ConsultaVacacionesEmpleado_Load(object sender, EventArgs e)
        {
            CargarInformacion();
        }

        private void bbiCerrar_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Close();
        }

        private void bbiActualizar_ItemClick(object sender, ItemClickEventArgs e)
        {
            CargarInformacion();
        }

        private void CargarInformacion()
        {
            try
            {
                if (idEmpleado != null)
                {
                    DataTable dataTable = new DataTable();
                    dataTable = datos.ConsultaTabla("[dbo].[p_ConsultarEmpleadoPorIdentidadVacaciones]", "@Numero_Identidad", idEmpleado);

                    if (dataTable.Rows.Count > 0)
                    {
                        txteEmpleado.Text = dataTable.Rows[0].ItemArray[dataTable.Columns["Nombre del Empleado"].Ordinal].ToString();
                        txtRelojMarcador.Text = dataTable.Rows[0].ItemArray[dataTable.Columns["No. Reloj Marcador"].Ordinal].ToString();
                        txtUnidad.Text = dataTable.Rows[0].ItemArray[dataTable.Columns["Unidad"].Ordinal].ToString();
                        txtPuestos.Text = dataTable.Rows[0].ItemArray[dataTable.Columns["Puestos"].Ordinal].ToString();
                        txtDiasDisponibles.Text = dataTable.Rows[0].ItemArray[dataTable.Columns["Vacaciones Disponibles"].Ordinal].ToString();
                        
                    }
                    gdcDatos.DataSource = datos.ConsultaTabla("[dbo].[p_ConsultarPeriodosVacacionesDisponiblesPorEmpleado]", "@Numero_Identidad", idEmpleado);
                    gdvDatos.BestFitColumns();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}