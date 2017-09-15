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
            this.FillIVAs(viewModel.LineasIVA);
            
        }

        public void FillIVAs(List<LineaIVAViewModel> lineasIVA)
        {
            tableLayoutPanel1.Controls.Add(new Label() { Text = "Bases IVA" }, 0, 0);
            tableLayoutPanel1.Controls.Add(new Label() { Text = "% IVA" }, 1, 0);
            tableLayoutPanel1.Controls.Add(new Label() { Text = "IVA" }, 2, 0);
            tableLayoutPanel1.Controls.Add(new Label() { Text = "% RE" }, 3, 0);
            tableLayoutPanel1.Controls.Add(new Label() { Text = "RE" }, 4, 0);

            for (int i = 1; i < lineasIVA.Count + 1; i++)
            {
                var lineaIVA = lineasIVA[i - 1];
                tableLayoutPanel1.Controls.Add(new Label() { Text = "99" }, 0, i);
                tableLayoutPanel1.Controls.Add(new Label() { Text = lineaIVA.PorcentajeIVA.ToString() }, 1, i);
                tableLayoutPanel1.Controls.Add(new Label() { Text = "99" }, 2, i);
                tableLayoutPanel1.Controls.Add(new Label() { Text = "99" }, 3, i);
                tableLayoutPanel1.Controls.Add(new Label() { Text = "99" }, 4, i);
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
