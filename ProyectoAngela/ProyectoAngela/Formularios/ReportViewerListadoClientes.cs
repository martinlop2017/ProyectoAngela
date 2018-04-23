using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AdministracionAngela.Utils.Models.Cliente;
using Microsoft.Reporting.WinForms;
using AdministracionAngela.Utils.Genericos;
using System.IO;

namespace AdministracionAngela.ProyectoAngela.Formularios
{
    public partial class ReportViewerListadoClientes : Form
    {
        public ReportViewerListadoClientes()
        {
            InitializeComponent();
        }

        private void ReportViewerListadoClientes_Load(object sender, EventArgs e)
        {

            this.reportViewerListadoCliente.RefreshReport();
        }

        public void ExportarToPdf(List<AltaClienteViewModel> clientes)
        {
            this.AltaClienteViewModelBindingSource.DataSource = clientes;
            //this.reportViewer1.RefreshReport();
            string mimeType = string.Empty;
            string encoding = string.Empty;
            string extension = string.Empty;
            Warning[] warnings;
            string[] streamIds;

            var form = new FormEsperar("Imprimiendo");
            CheckForIllegalCrossThreadCalls = false;
            var test = Task.Factory.StartNew(() =>
            {
                byte[] bytes = reportViewerListadoCliente.LocalReport.Render("PDF", null, out mimeType, out encoding,
                out extension, out streamIds, out warnings);

                var exportPath = string.Format(@"{0}\Listado Articulos.pdf", RutasSalida.RutaLiquidaciones);
                File.WriteAllBytes(exportPath, bytes);

                form.Close();
            });

            form.ShowDialog();

            test.Dispose();
            CheckForIllegalCrossThreadCalls = true;

        }
    }
}
