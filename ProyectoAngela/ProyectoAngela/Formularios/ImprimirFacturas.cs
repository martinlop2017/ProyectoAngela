using AdministracionAngela.Utils.Interfaces;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
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
    public partial class ImprimirFacturas : Form
    {
        private long numeroDocumentoInicial;
        private IFormOpener formOpener;
        private IDocumentoGestion documentoGestion;

        public ImprimirFacturas(IFormOpener formOpener, IDocumentoGestion documentoGestion, long numeroDocumentoInicial)
        {
            this.numeroDocumentoInicial = numeroDocumentoInicial;
            this.formOpener = formOpener;
            this.documentoGestion = documentoGestion;

            InitializeComponent();
            this.textBoxDocumentoInicial.Text = numeroDocumentoInicial.ToString();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            var documentoInicial = int.Parse(this.textBoxDocumentoInicial.Text);
            var documentoFinal = int.Parse(this.textBoxDocumentoFinal.Text);

            IEnumerable<int> documentosAImprimir = Enumerable.Range(documentoInicial, documentoFinal-documentoInicial + 1).Select(x => x);
            ExportarFacturas(documentosAImprimir.ToList());

            var longDocumentosAImprimir = documentosAImprimir.ToList().Select(x => Convert.ToInt64(x)).ToList();
            this.documentoGestion.SetDocumentoImpresa(longDocumentosAImprimir);

            this.Close();
        }

        private void ExportarFacturas(List<int> selectedFacturaIds)
        {
            using (var formImpresion = this.formOpener.GetForm<FormImpresion>() as FormImpresion)
            {
                ReportDocument oRep = new ReportDocument();
                ParameterField pf = new ParameterField();
                ParameterFields pfs = new ParameterFields();
                ParameterDiscreteValue pdv = new ParameterDiscreteValue();
                pf.Name = "@NumeroFactura";
                pf.CurrentValues.Add(pdv);
                pfs.Add(pf);
                formImpresion.crystalReportViewer1.ParameterFieldInfo = pfs;
                oRep.Load(@"C:\MyProjects\ProyectoAngela\ProyectoAngela\ProyectoAngela\Formularios\CrystalReportImpresionFactura.rpt");
                foreach (var numeroFactura in selectedFacturaIds)
                {
                    oRep.SetParameterValue("@NumeroFactura", numeroFactura);
                    formImpresion.crystalReportViewer1.ReportSource = oRep;
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
    }
}
