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
using AdministracionAngela.Utils.Enumerados;

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
            this.pictureBox1.Visible = this.documentoGestion.CanBeDocumento();
            this.buttonFacturar.Visible = this.documentoGestion.PuedeFacturar();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var typeDocumento = this.documentoGestion.GetTipoDocumento();
            if(typeDocumento == EnumDocumentosGestion.Albaran)
            {
                var formAltaAlbaran = this.formOpener.GetForm<Albaranes>() as Albaranes;
                formAltaAlbaran.SetIsAlbaran(IsDocumento);
                formAltaAlbaran.ShowDialog();
            }
            else
            {
                this.formOpener.ShowModalForm<Facturacion>();
            }

            this.FillControls();
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
            if(!this.documentoGestion.PuedeFacturar())
            {
                this.dataGridViewFacturas.Columns["ColumnFacturado"].Visible = false;
            }
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
            this.FillControls();
        }

        private void OpenFormToModify(FacturaViewModel selectedFactura)
        {
            var typeDocumento = this.documentoGestion.GetTipoDocumento();
            if(typeDocumento == EnumDocumentosGestion.Factura)
            {
                var formAltaCliente = this.formOpener.GetForm<Facturacion>() as Facturacion;
                formAltaCliente.IsUpdate(selectedFactura.Codigo);
                formAltaCliente.ShowDialog();
            }
            else
            {
                var formAltaCliente = this.formOpener.GetForm<Albaranes>() as Albaranes;
                formAltaCliente.IsUpdate(selectedFactura.Codigo, IsDocumento);
                formAltaCliente.ShowDialog();
            }
            //using (var formAltaCliente = this.formOpener.GetForm<Facturacion>() as Facturacion)
            //{
            //    formAltaCliente.IsUpdate(selectedFactura.CodigoFactura);
            //    formAltaCliente.ShowDialog();
            //}

            this.FillControls();
        }

        private void buttonImprimir_Click(object sender, EventArgs e)
        {
            var selectedRow = this.dataGridViewFacturas.SelectedRows;
            var mappedSelectedRows = selectedRow.ToList<FacturaViewModel>();
            var selectedDocumentosIds = mappedSelectedRows.Select(f => f.Codigo).ToList();

            var reportImpresion = this.documentoGestion.GetReportImpresion(IsDocumento);
            var variableImpresion = this.documentoGestion.GetVariableImpresion();

            var formImprimir = new ImprimirFacturas( this.formOpener, this.documentoGestion, selectedDocumentosIds.First(), reportImpresion, variableImpresion, IsDocumento);
            formImprimir.ShowDialog();
            
            this.FillControls();
        }

        private void buttonFacturar_Click(object sender, EventArgs e)
        {
            var selectedRow = this.dataGridViewFacturas.SelectedRows;
            var mappedSelectedRows = selectedRow.ToList<FacturaViewModel>();
            var selectedDocumentosIds = mappedSelectedRows.Select(f => f.Codigo).ToList();
            this.documentoGestion.Facturar(selectedDocumentosIds);

            FillControls();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.IsDocumento = !this.IsDocumento;
            this.dataGridViewFacturas.BackgroundColor = this.IsDocumento ? Color.White : Color.LemonChiffon;
            this.dataGridViewFacturas.RowHeadersDefaultCellStyle .BackColor = this.IsDocumento ? Color.White : Color.Yellow;
            this.dataGridViewFacturas.RowTemplate.DefaultCellStyle.BackColor = this.IsDocumento ? Color.White : Color.LemonChiffon;
    
            
            this.FillControls();
        }

        private void buttonFacturar_MouseEnter(object sender, EventArgs e)
        {
            labelFacturar.Visible = true;
        }

        private void buttonFacturar_MouseLeave(object sender, EventArgs e)
        {
            labelFacturar.Visible = false;
        }
    }
}
