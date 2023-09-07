using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecursosHumanos.Empleados.Reportes
{
    public partial class ImpresionPermiso : Form
    {
        frmPrincipal frmPrincipal = new frmPrincipal();
        public ImpresionPermiso()
        {
            InitializeComponent();
        }

        private void ImpresionPermiso_Load(object sender, EventArgs e)
        {
            try
            {
                this.Text = this.Text + " - " + id.ToString().Trim();
                ReportePermiso reporte = new ReportePermiso();
                reporte.Parameters["ID"].Value = id;
                reporte.CreateDocument();
                documentViewer1.DocumentSource = reporte;
                documentViewer1.Show();
            }
            catch (Exception ex)
            {
                frmPrincipal.MostrarError(ex.Message);
            }
        }

        public int id { get; set; }
    }

}
