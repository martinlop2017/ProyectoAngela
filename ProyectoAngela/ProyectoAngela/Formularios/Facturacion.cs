using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AdministracionAngela.Utils.Extensions;
using AdministracionAngela.Utils.Interfaces;
using AdministracionAngela.Utils.Models.Factura;

namespace AdministracionAngela.ProyectoAngela.Formularios
{
    public partial class Facturacion : Form
    {
        int linea = 0;
        private IFacturaProvider facturaProvider;
        /// <summary>
        /// Lo usamos para poder aplicar el filtro inteligente
        /// </summary>
        private List<string> originalClientValues;

        public Facturacion(IFacturaProvider facturaProvider)
        {
            this.facturaProvider = facturaProvider;
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Facturacion_Load(object sender, EventArgs e)
        {
            var viewModel = this.facturaProvider.GetFacturaViewModel();
            this.FillControls(viewModel);
        }

        private void button11_Click_2(object sender, EventArgs e)
        {
            linea = 1;
        }

        private void comboBoxClientes_TextUpdate(object sender, EventArgs e)
        {
            comboBoxClientes.FilterByTextIntroduced(originalClientValues);
        }

        private void FillControls(FacturaViewModel viewModel)
        {
            this.originalClientValues = viewModel.ClienteIdsAndDescripciones.Keys.ToList<string>();
            this.comboBoxClientes.DataSource = originalClientValues;
            this.labelNumeroFactura.Text = viewModel.Id.ToString();
            this.labelFecha.Text = viewModel.Fecha;
        }
    }
}
