using AdministracionAngela.Utils.Extensions;
using AdministracionAngela.Utils.Interfaces;
using AdministracionAngela.Utils.Models.FormaDePago;
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
    public partial class FormaPago : Form
    {
        private ISistemaProvider sistemaProvider;
        private bool IsUpdate = false;

        public FormaPago(ISistemaProvider sistemaProvider)
        {
            this.sistemaProvider = sistemaProvider;
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            var rows = this.dataGridViewFormasDePago.Rows;

            var mappedRows = rows.ToList<FormaDePagoViewModel>();

            this.sistemaProvider.SaveFormaDePago(mappedRows);

            Close();
        }

        private void FormaPago_Load(object sender, EventArgs e)
        {
            var viewModel = this.sistemaProvider.GetGestionFormasDePago();
            FillControls(viewModel);
        }

        private void FillControls(GestionFormaDePagoViewModel viewModel)
        {
            this.dataGridViewFormasDePago.DataSource = viewModel.FormasDePago;
        }
    }
}
