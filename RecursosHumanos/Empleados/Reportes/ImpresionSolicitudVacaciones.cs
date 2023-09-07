using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace RecursosHumanos.Empleados.Reportes
{
    public partial class ImpresionSolicitudVacaciones : DevExpress.XtraEditors.XtraForm
    {

        frmPrincipal frmprincipal = new frmPrincipal();

        public ImpresionSolicitudVacaciones()
        {
            InitializeComponent();
        }

        public int ID { get; set; }

        private void ImpresionSolicitudVacaciones_Load(object sender, EventArgs e)
        {
            try
            {
                ReporteSolicitudVacaciones reporteSolicitudVacaciones = new ReporteSolicitudVacaciones();
                reporteSolicitudVacaciones.Parameters["ID"].Value = ID;
                reporteSolicitudVacaciones.CreateDocument();
                documentViewer1.DocumentSource = reporteSolicitudVacaciones;
                documentViewer1.Show();


            }
            catch (Exception ex)
            {
                frmprincipal.MostrarError(ex.Message);
            }
        }
    }
}