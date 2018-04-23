using AdministracionAngela.Utils.Interfaces;
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
    public partial class GestionListados : Form
    {
        IArticuloProvider articuloProvider;
        IClienteProvider clienteProvider;
        IFacturaProvider facturaProvider;         

        public GestionListados(IArticuloProvider articuloProvider, IClienteProvider clienteProvider, IFacturaProvider facturaProvider)
        {
            this.articuloProvider = articuloProvider;
            this.clienteProvider = clienteProvider;
            this.facturaProvider = facturaProvider;
            InitializeComponent();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void treeView1_Click(object sender, EventArgs e)
        {

        }

        private void treeView1_MouseCaptureChanged(object sender, EventArgs e)
        {

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            var nodoSeleccionado = treeView1.SelectedNode.Name;
            var nodoHijoGestionSeleccionado = (nodoSeleccionado.Equals("Facturas") || nodoSeleccionado.Equals("Albaranes"));

            HabilitarFiltros(nodoHijoGestionSeleccionado);
        }

        private void HabilitarFiltros(bool enable)
        {
            textBoxClienteInicial.Enabled = enable;
            textBoxClienteFinal.Enabled = enable;
            textBoxFechaInicial.Enabled = enable;
            textBoxFechaFinal.Enabled = enable;

            if(!enable)
            {
                textBoxClienteInicial.Text = "";
                textBoxClienteFinal.Text = "";
                textBoxFechaInicial.Text = "";
                textBoxFechaFinal.Text = "";
            }
        }

        private void buttonImprimir_Click(object sender, EventArgs e)
        {
            var nodoSeleccionado = treeView1.SelectedNode.Name;
            if(nodoSeleccionado.Equals("Articulos"))
            {
                var articulos = articuloProvider.GetAllArticulos();
                if(articulos.Any())
                {
                    var form = new ReportViewerListadoArticulos();
                    form.ExportarToPdf(articulos);
                }
            }
            else if(nodoSeleccionado.Equals("Clientes"))
            {
                var clientes = clienteProvider.GetAllClientes();
                if(clientes.Any())
                {
                    var form = new ReportViewerListadoClientes();
                    form.ExportarToPdf(clientes);
                }
            }
            else if(nodoSeleccionado.Equals("Facturas"))
            {
                var from = Convert.ToDateTime(textBoxClienteInicial.Text);
                var to = Convert.ToDateTime(textBoxFechaFinal.Text);
                var facturas = facturaProvider.GetAllFacturasFromDateRange(from, to);

                foreach(var factura in facturas)
                {
                    factura.DeFecha = textBoxClienteInicial.Text;
                    factura.DeFecha = textBoxClienteInicial.Text;
                }

                if(facturas.Any())
                {
                    var form = new ReportViewerListadoFactura();
                    form.ExportarToPdf(facturas);
                }
            }
        }
    }
}
