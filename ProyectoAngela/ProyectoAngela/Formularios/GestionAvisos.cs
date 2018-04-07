﻿using AdministracionAngela.Utils.Interfaces;
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
            this.avisos = viewModel.Avisos;
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
            if (comboBoxBusqueda.Text.Equals("Codigo"))
            {
                dataGridViewAvisos.DataSource = avisos.Where(x => x.CodigoFactura.ToString().Contains(textBoxBusqueda.Text)).ToList();
            }

            if (comboBoxBusqueda.Text.Equals("Cliente"))
            {
                dataGridViewAvisos.DataSource = avisos.Where(x => x.Cliente.Contains(textBoxBusqueda.Text.ToUpper())).ToList();
            }
        }
    }
}
