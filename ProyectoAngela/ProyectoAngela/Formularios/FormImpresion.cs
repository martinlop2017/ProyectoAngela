using AdministracionAngela.Utils.Models.Factura;
using Microsoft.Reporting.WinForms;
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
    public partial class FormImpresion : Form
    {
        List<ImpresionFactura> facturas;

        public FormImpresion()
        {
            InitializeComponent();
            facturas = new List<ImpresionFactura>();
        }

        public void SetFacturas(List<ImpresionFactura> facturasParaImprimir)
        {
            this.facturas = facturasParaImprimir;
        }

        private void Form20_Load(object sender, EventArgs e)
        {
           

        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
