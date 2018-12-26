using AdministracionAngela.Utils.Interfaces;
using AdministracionAngela.Utils.Models.Impresion;
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

        private bool FiltrandoPorCliente()
        {
            if (string.IsNullOrEmpty(textBoxClienteInicial.Text) || string.IsNullOrEmpty(textBoxClienteFinal.Text))
                return false;

            int n = 0;
            var esNumero = int.TryParse(textBoxClienteInicial.Text, out n) && int.TryParse(textBoxClienteFinal.Text, out n);

            return esNumero;
        }

        private bool FiltrandoPorFecha()
        {
            if (string.IsNullOrEmpty(textBoxFechaInicial.Text) || string.IsNullOrEmpty(textBoxFechaFinal.Text))
                return false;

            DateTime n;
            var esFecha = DateTime.TryParse(textBoxFechaInicial.Text, out n) && DateTime.TryParse(textBoxFechaFinal.Text, out n);

            return esFecha;
        }

        private void buttonImprimir_Click(object sender, EventArgs e)
        {
            var nodoSeleccionado = treeView1.SelectedNode.Name;

            switch (nodoSeleccionado)
            {
                case "Articulos":
                    var articulos = articuloProvider.GetAllArticulos();
                    if (articulos.Any())
                    {
                        
                        var form = new ReportViewerListadoArticulos();
                        form.ExportarToPdf(articulos);
                    }
                    break;
                case "Clientes":
                    var clientes = clienteProvider.GetAllClientes();
                    if (clientes.Any())
                    {
                        var form = new ReportViewerListadoClientes();
                        form.ExportarToPdf(clientes);
                    }
                    break;
                case "Facturas":

                    List<ListadoFactura> facturas;
                    if(FiltrandoPorCliente() && FiltrandoPorFecha())
                    {
                        DateTime from = Convert.ToDateTime(textBoxFechaInicial.Text);
                        DateTime to = Convert.ToDateTime(textBoxFechaFinal.Text);
                        int fromCodigoCliente = Convert.ToInt32(textBoxClienteInicial.Text);
                        int toCodigoCliente = Convert.ToInt32(textBoxClienteFinal.Text);

                        facturas = facturaProvider.GetAllFacturasFromClienteAndDateRange(from, to, fromCodigoCliente, toCodigoCliente);
                    }
                    else if(FiltrandoPorFecha())
                    {
                        DateTime from = Convert.ToDateTime(textBoxFechaInicial.Text);
                        DateTime to = Convert.ToDateTime(textBoxFechaFinal.Text);
                        facturas = facturaProvider.GetAllFacturasFromDateRange(from, to);
                    }
                    else if(FiltrandoPorCliente())
                    {
                        int fromCodigoCliente = Convert.ToInt32(textBoxClienteInicial.Text);
                        int toCodigoCliente = Convert.ToInt32(textBoxClienteFinal.Text);
                        facturas = facturaProvider.GetAllFacturasFromClienteRange(fromCodigoCliente, toCodigoCliente);
                    }
                    else
                    {
                        facturas = facturaProvider.GetAllListaFacturas();
                    }

                    foreach (var factura in facturas)
                    {
                        factura.DeFecha = textBoxFechaInicial.Text;
                        factura.AFecha = textBoxFechaFinal.Text;
                    }

                    if (facturas.Any())
                    {
                        var form = new ReportViewerListadoFactura();
                        form.ExportarToPdf(facturas);
                    }
                    break;
                case "Albaranes":
                    List<ListadoAlbaran> albaranes;
                    if (FiltrandoPorCliente() && FiltrandoPorFecha())
                    {
                        DateTime from = Convert.ToDateTime(textBoxFechaInicial.Text);
                        DateTime to = Convert.ToDateTime(textBoxFechaFinal.Text);
                        int fromCodigoCliente = Convert.ToInt32(textBoxClienteInicial.Text);
                        int toCodigoCliente = Convert.ToInt32(textBoxClienteFinal.Text);

                        albaranes = facturaProvider.GetAllAlbaranesFromClienteAndDateRange(from, to, fromCodigoCliente, toCodigoCliente);
                    }
                    else if (FiltrandoPorFecha())
                    {
                        DateTime from = Convert.ToDateTime(textBoxFechaInicial.Text);
                        DateTime to = Convert.ToDateTime(textBoxFechaFinal.Text);
                        albaranes = facturaProvider.GetAllAlbaranesFromDateRange(from, to);
                    }
                    else if (FiltrandoPorCliente())
                    {
                        int fromCodigoCliente = Convert.ToInt32(textBoxClienteInicial.Text);
                        int toCodigoCliente = Convert.ToInt32(textBoxClienteFinal.Text);
                        albaranes = facturaProvider.GetAllAlbaranesFromClienteRange(fromCodigoCliente, toCodigoCliente);
                    }
                    else
                    {
                        albaranes = facturaProvider.GetAllListaAlbaranes();
                    }

                    foreach (var albaran in albaranes)
                    {
                        albaran.DeFecha = textBoxFechaInicial.Text;
                        albaran.AFecha = textBoxFechaFinal.Text;
                    }

                    if (albaranes.Any())
                    {
                        var form = new ReportViewerListadoAlbaran();
                        form.ExportarToPdf(albaranes);
                    }
                    break;
            }
        }
    }
}
