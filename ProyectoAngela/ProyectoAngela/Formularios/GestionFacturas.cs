using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AdministracionAngela.Utils.Interfaces;
using AdministracionAngela.Utils.Models.Factura;
using AdministracionAngela.Utils.Extensions;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using AdministracionAngela.Utils.Genericos;

namespace AdministracionAngela.ProyectoAngela.Formularios
{
    public partial class GestionFacturas : Form
    {
        private IFormOpener formOpener;
        private IDocumentoGestion documentoGestion;
        private bool IsDocumento = true;

        public GestionFacturas(IFormOpener formOpener, IDocumentoGestion documentoGestion)
        {
            this.formOpener = formOpener;
            this.documentoGestion = documentoGestion;
            InitializeComponent();
            this.labelTitulo.Text = this.documentoGestion.GetTitulo();
            this.button1.Enabled = this.documentoGestion.CanBeDocumento();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var typeDocumento = this.documentoGestion.GetTipoDocumento();
            this.formOpener.ShowDocumentoForm(typeDocumento);
        }

        private void button6_MouseEnter(object sender, EventArgs e)
        {
            label7.Visible = true;
        }

        private void button6_MouseLeave(object sender, EventArgs e)
        {
            label7.Visible = false;
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            label1.Visible = true;
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            label2.Visible = true;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            label2.Visible = false;
        }

        private void button3_MouseEnter(object sender, EventArgs e)
        {
            label3.Visible = true;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            label3.Visible = false;
        }

        private void button4_MouseEnter(object sender, EventArgs e)
        {
            label4.Visible = true;
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            label4.Visible = false;
        }

        private void button5_MouseEnter(object sender, EventArgs e)
        {
            label5.Visible = true;
        }

        private void button5_MouseLeave(object sender, EventArgs e)
        {
            label5.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void GestionFacturas_Load(object sender, EventArgs e)
        {
            this.FillControls();
        }

        private void buttonBorrar_Click(object sender, EventArgs e)
        {
            var selectedRow = this.dataGridViewFacturas.SelectedRows;
            var mappedSelectedRows = selectedRow.ToList<FacturaViewModel>();

            this.documentoGestion.DeleteDocumentos(mappedSelectedRows);
            this.FillControls();
        }

        private void FillControls()
        {
            var viewModel = this.documentoGestion.GetDocumentos(IsDocumento);
            this.dataGridViewFacturas.DataSource = viewModel.Facturas;
        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            var selectedRows = this.dataGridViewFacturas.SelectedRows;
            if (selectedRows.Count > 1)
                MessageBox.Show("Debe seleccionar una única factura");
            else if (selectedRows.Count < 1)
                MessageBox.Show("Debe seleccionar una factura");
            else
            {
                var selectedFactura = (FacturaViewModel)selectedRows[0].DataBoundItem;
                this.OpenFormToModify(selectedFactura);
            }
        }

        private void OpenFormToModify(FacturaViewModel selectedFactura)
        {
            using (var formAltaCliente = this.formOpener.GetForm<Facturacion>() as Facturacion)
            {
                formAltaCliente.IsUpdate(selectedFactura.CodigoFactura);
                formAltaCliente.ShowDialog();
            }

            this.FillControls();
        }

        private void buttonImprimir_Click(object sender, EventArgs e)
        {
            var selectedRow = this.dataGridViewFacturas.SelectedRows;
            var mappedSelectedRows = selectedRow.ToList<FacturaViewModel>();
            var selectedFacturaIds = mappedSelectedRows.Select(f => f.CodigoFactura).ToList();

            ExportarFacturas(selectedFacturaIds);
            this.documentoGestion.SetDocumentoImpresa(selectedFacturaIds);
            this.FillControls();
        }

        private void ExportarFacturas(List<long> selectedFacturaIds)
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

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.IsDocumento = false;
            this.FillControls();
        }

        private void buttonFacturar_Click(object sender, EventArgs e)
        {
            var selectedRow = this.dataGridViewFacturas.SelectedRows;
            var mappedSelectedRows = selectedRow.ToList<FacturaViewModel>();
            var selectedDocumentosIds = mappedSelectedRows.Select(f => f.CodigoFactura).ToList();

        }
    }
}
