using AdministracionAngela.Utils.Genericos;
using AdministracionAngela.Utils.Models.Impresion;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdministracionAngela.ProyectoAngela.Formularios
{
    public partial class ReportViewerListadoFactura : Form
    {
        public ReportViewerListadoFactura()
        {
            InitializeComponent();
        }

        private void ReportViewerListadoFactura_Load(object sender, EventArgs e)
        {

            this.reportViewerListadoFacturas.RefreshReport();
        }

        public void ExportarToPdf(List<ListadoFactura> facturas)
        {
            this.ImpresionFacturaBindingSource.DataSource = facturas;
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
                byte[] bytes = reportViewerListadoFacturas.LocalReport.Render("PDF", null, out mimeType, out encoding,
                out extension, out streamIds, out warnings);

                var exportPath = string.Format(@"{0}\Listado Facturas.pdf", RutasSalida.RutaListados);
                File.WriteAllBytes(exportPath, bytes);

                form.Close();
            });

            form.ShowDialog();

            test.Dispose();
            CheckForIllegalCrossThreadCalls = true;

        }
    }
}
