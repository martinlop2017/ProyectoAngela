using AdministracionAngela.Utils.Interfaces;
using AdministracionAngela.Utils.Models.Avisos;
using AdministracionAngela.Utils.Models.Impresion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace AdministracionAngela.ProyectoAngela.Formularios
{
    public partial class GestionAvisos : Form
    {
        private IFacturaProvider facturaProvider;
        private BindingList<AvisoViewModel> avisos;

        public GestionAvisos(IFacturaProvider facturaProvider)
        {
            this.facturaProvider = facturaProvider;
            this.avisos = new BindingList<AvisoViewModel>();
            InitializeComponent();
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

        private void GestionAvisos_Load(object sender, EventArgs e)
        {
            //var viewModel = facturaProvider.GetGestionFacturasVencidas();
            this.dataGridViewAvisos.DataSource = new BindingList<AvisoViewModel>();
            this.avisos = new BindingList<AvisoViewModel>();
        }

        private void dataGridViewAvisos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dataGridViewAvisos.CurrentCell.OwningColumn.Name.Equals("ColumnCobrada"))
            {
                var selectedRow = this.dataGridViewAvisos.SelectedRows[0];
                selectedRow.Cells["ColumnCobrada"].Value = !(bool)selectedRow.Cells["ColumnCobrada"].Value;
                var cobrada = (bool)(selectedRow.Cells["ColumnCobrada"] as DataGridViewCheckBoxCell).Value;
                var codigoFactura = selectedRow.Cells["ColumnCodigoFactura"].Value;

                this.facturaProvider.SetFacturaCobrada((long)codigoFactura);
            }
        }

        private void textBoxBusqueda_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void botonfiltrar_Click(object sender, EventArgs e)
        {
            var fromCode = long.Parse(this.textBoxFromCodigo.Text);
            var toCode = long.Parse(this.textBoxToCodigo.Text);
            var fromDate = this.dateTimePickerFromFecha.Value.Date;
            var toDate = this.dateTimePickerToFecha.Value.Date.AddDays(1).AddSeconds(-1);
            var checkForPendientes = this.checkBoxPendientes.Checked;
            var checkForCobradas = this.checkBoxCobradas.Checked;

            var viewModel = facturaProvider.GetGestionFacturasVencidas(fromCode, toCode, fromDate, toDate, checkForPendientes, checkForCobradas);
            this.dataGridViewAvisos.DataSource = viewModel.Avisos;
        }

        private void button1_Click(object sender, EventArgs e)
        {



            var listaMorososParaImprimir = new List<Moroso>();
            foreach (DataGridViewRow row in dataGridViewAvisos.Rows)
            {
                var moroso = new Moroso();
                moroso.desdecliente = textBoxFromCodigo.Text;
                moroso.hastacliente = textBoxToCodigo.Text;
                moroso.CodigoFactura = Convert.ToString(row.Cells["ColumnCodigoFactura"].Value);
                moroso.FechaFactura = Convert.ToString(row.Cells["ColumnFecha"].Value);
                moroso.FechaCobro = Convert.ToString(row.Cells["ColumnCobro"].Value);
                moroso.FechaVencimiento = Convert.ToString(row.Cells["ColumnVencimiento"].Value);
                moroso.Importe = Convert.ToDecimal(row.Cells["ColumnImporte"].Value);
                moroso.NombreCliente = Convert.ToString(row.Cells["ColumnCliente"].Value);
                moroso.Cobrada = Convert.ToBoolean(row.Cells["ColumnCobrada"].Value);

                listaMorososParaImprimir.Add(moroso);
            }

            if(listaMorososParaImprimir.Count > 0)
            {
                VisorMororsos form = new VisorMororsos();
                form.ExportarToPdf(listaMorososParaImprimir);
            }
        }
    }
}
