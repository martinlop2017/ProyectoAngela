using AdministracionAngela.Utils.Interfaces;
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
    public partial class GestionAvisos : Form
    {
        private IFacturaProvider facturaProvider;
        public GestionAvisos(IFacturaProvider facturaProvider)
        {
            this.facturaProvider = facturaProvider;
            InitializeComponent();
        }

        private void panel1_MouseEnter(object sender, EventArgs e)
        {
            label4.Visible = true;
        }

        private void panel1_MouseLeave(object sender, EventArgs e)
        {
            label4.Visible = false;
        }

        private void textBoxBusqueda_MouseEnter(object sender, EventArgs e)
        {
            label4.Visible = true;
        }

        private void textBoxBusqueda_MouseLeave(object sender, EventArgs e)
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

        private void GestionAvisos_Load(object sender, EventArgs e)
        {
            var viewModel = facturaProvider.GetGestionFacturasVencidas();
            this.dataGridViewAvisos.DataSource = viewModel.Avisos;
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
    }
}
