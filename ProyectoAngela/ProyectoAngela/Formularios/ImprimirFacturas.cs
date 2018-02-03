using AdministracionAngela.Utils.Interfaces;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
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
    public partial class ImprimirFacturas : Form
    {
        private long numeroDocumentoInicial;
        private IFormOpener formOpener;
        private IDocumentoGestion documentoGestion;
        private string reportName;
        private string variableName;
        private bool isDocumento;

        public ImprimirFacturas(IFormOpener formOpener, IDocumentoGestion documentoGestion, long numeroDocumentoInicial, string reportName, string variableName, bool isDocumento)
        {
            this.numeroDocumentoInicial = numeroDocumentoInicial;
            this.formOpener = formOpener;
            this.documentoGestion = documentoGestion;
            this.isDocumento = isDocumento;

            InitializeComponent();
            this.textBoxDocumentoInicial.Text = numeroDocumentoInicial.ToString();
            this.textBoxDocumentoFinal.Text = numeroDocumentoInicial.ToString();


            this.reportName = reportName;
            this.variableName = variableName;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            bool impreso = false;
            var form = new FormEsperar("Imprimiendo");
            CheckForIllegalCrossThreadCalls = false;
            var test = Task.Factory.StartNew(() =>
            {
                var documentoInicial = int.Parse(this.textBoxDocumentoInicial.Text);
                var documentoFinal = int.Parse(this.textBoxDocumentoFinal.Text);

                IEnumerable<int> documentosAImprimir = Enumerable.Range(documentoInicial, documentoFinal - documentoInicial + 1).Select(x => x);
                ExportarFacturas(documentosAImprimir.ToList());

                var longDocumentosAImprimir = documentosAImprimir.ToList().Select(x => Convert.ToInt64(x)).ToList();
                this.documentoGestion.SetDocumentoImpresa(longDocumentosAImprimir);

                form.Close();
            }
            );

            form.ShowDialog();

            test.Dispose();
            CheckForIllegalCrossThreadCalls = true;
            this.Close();
        }

        private void ExportarFacturas(List<int> selectedFacturaIds)
        {
            using (var formImpresion = this.formOpener.GetForm<FormImpresion>() as FormImpresion)
            {
                foreach (var numeroFactura in selectedFacturaIds)
                {

                    DataSetFacturaImpresion dataset = new DataSetFacturaImpresion();
                    DataSetIvaFactura datasetIva = new DataSetIvaFactura();

                    var tableFactura = documentoGestion.GetDatosImpresion(numeroFactura, isDocumento);
                    var tableIva = documentoGestion.GatDatosIva(numeroFactura, isDocumento);

                    dataset.Tables.Add(tableFactura);
                    datasetIva.Tables.Add(tableIva);

                    ReportDocument oRep = new ReportDocument();

                    var reportPath = string.Format(@"{0}\..\..\Formularios\{1}.rpt", Directory.GetCurrentDirectory(), reportName);
                    oRep.Load(reportPath);
                    oRep.SetDataSource(dataset.Tables[1]);
                    oRep.Subreports[0].SetDataSource(datasetIva.Tables[1]);

                    var path = this.documentoGestion.GetExportPath(numeroFactura);
                    oRep.ExportToDisk(ExportFormatType.PortableDocFormat, path);
                }
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ImprimirFacturas_Load(object sender, EventArgs e)
        {

        }

        private void ImprimirFacturas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(13))
            {
                e.Handled = true; SendKeys.Send("{TAB}");
            }
        }
    }
}
