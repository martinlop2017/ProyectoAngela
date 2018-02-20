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
    public partial class ReportViewerLiquidaciones : Form
    {
        private List<ClaseLiquidacion> liquidaciones;
        public ReportViewerLiquidaciones(List<ClaseLiquidacion> liquidaciones)
        {
            this.liquidaciones = liquidaciones;
            InitializeComponent();
        }

        private void viwLiquidaciones_Load(object sender, EventArgs e)
        {
            this.ClaseLiquidacionBindingSource.DataSource = liquidaciones;
            this.reportViewer1.RefreshReport();
        }
    }
}
