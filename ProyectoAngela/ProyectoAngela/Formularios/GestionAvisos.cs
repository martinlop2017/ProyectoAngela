using AdministracionAngela.Utils.Interfaces;
using AdministracionAngela.Utils.Models.Avisos;
using System;
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
            var toDate = this.dateTimePickerToFecha.Value.Date;
            var checkForPendientes = this.checkBoxPendientes.Checked;
            var checkForCobradas = this.checkBoxCobradas.Checked;

            var viewModel = facturaProvider.GetGestionFacturasVencidas(fromCode, toCode, fromDate, toDate, checkForPendientes, checkForCobradas);
            this.dataGridViewAvisos.DataSource = viewModel.Avisos;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            VisorMororsos form = new VisorMororsos();
            form.Show();


        }
    }
}
