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

namespace RecursosHumanos.Configuracion.Usuarios
{
    public partial class ControlPrivilegios : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        Datos datos = new Datos();
        frmPrincipal frmPrincipal = new frmPrincipal();
        public string ID { get; set; }

        /// <summary>
        /// Actualiza los privilegios del usuario
        /// </summary>
        /// <param name="ID_Usuario">El ID del usuario que se desea modificar</param>
        public ControlPrivilegios(string ID_Usuario)
        {
            InitializeComponent();
            
            ComprobarExistenciaPrivilegios(ID_Usuario);
            this.Text = "Control de Privilegios del Usuario " + ID_Usuario;
            ID = ID_Usuario;
        }

        public void ComprobarExistenciaPrivilegios(string ID_Usuario)
        {
            try
            {
                datos.Procedimiento("[dbo].[p_ComprobarExistenciaPrivilegios]", "@Id_Usuario", ID_Usuario);
            }
            catch (Exception ex)
            {
                frmPrincipal.MostrarError(ex.Message);
            }
        }


        private void ControlPrivilegios_Load(object sender, EventArgs e)
        {
            Refrescar();
        }

        public void Refrescar()
        {
            try
            {
                gdcPrivilegios.DataSource = datos.ConsultaTabla("[dbo].[p_ConsultarPrivilegiosPorUsuario]", "@Id_Usuario", ID);
                gdvPrivilegios.BestFitColumns();

                for (int i = 0; i < gdvPrivilegios.Columns.Count; i++)
                {
                    if (gdvPrivilegios.Columns[i].FieldName != "Habilitado")
                    {
                        gdvPrivilegios.Columns[i].OptionsColumn.ReadOnly = true;
                    }
                }
            }
            catch (Exception ex)
            {
                frmPrincipal.MostrarError(ex.Message);
            }
        }

        private void bbiCancelar_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Close();
        }

        private void bbiModificarPrivilegios_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                if (MessageBox.Show("Desea modificar los permisos del usuario?","Confirmar",MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    for (int i = 0; i < gdvPrivilegios.RowCount; i++)
                    {
                        datos.Procedimiento("[dbo].[p_ActualizarPrivilegiosDeUsuario]", "@Id_Usuario", ID,
                                            "@Codigo_Privilegio", gdvPrivilegios.GetRowCellValue(i,"ID"),
                                            "@Habilitado", gdvPrivilegios.GetRowCellValue(i, "Habilitado"));                        
                    }
                    this.Close();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}