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

namespace AdministracionAngela.ProyectoAngela.Formularios
{
    public partial class GestionFacturas : Form
    {
        private IFormOpener formOpener;
        private IFacturaProvider facturaProvider;

        public GestionFacturas(IFormOpener formOpener, IFacturaProvider facturaProvider)
        {
            this.formOpener = formOpener;
            this.facturaProvider = facturaProvider;
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.formOpener.ShowModalForm<Facturacion>();
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

            this.facturaProvider.DeleteFacturas(mappedSelectedRows);
            this.FillControls();
        }

        private void FillControls()
        {
            var viewModel = this.facturaProvider.GetGestionFactura();
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

            List<ImpresionFactura> facturasParaImprimir = this.facturaProvider.GetImpresionFactura(selectedFacturaIds);

            using (var formImpresion = this.formOpener.GetForm<Form20>() as Form20)
            {
                formImpresion.SetFacturas(facturasParaImprimir);
                formImpresion.ShowDialog();
            }
        }
    }
}
