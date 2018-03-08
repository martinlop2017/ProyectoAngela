using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdministracionAngela.ProyectoAngela.Formularios
{
    public partial class ReportViewerFacturacion_Nuevo : Form
    {
        public ReportViewerFacturacion_Nuevo()
        {
            InitializeComponent();
        }

        private void ReportViewerFacturacion_Nuevo_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
    }
}
