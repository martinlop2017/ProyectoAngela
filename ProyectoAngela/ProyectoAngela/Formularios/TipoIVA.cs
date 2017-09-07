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

namespace AdministracionAngela.ProyectoAngela.Formularios
{
    public partial class TipoIVA : Form
    {
        private IIVAProvider ivaProvider;

        public TipoIVA(IIVAProvider ivaProvider)
        {
            this.ivaProvider = ivaProvider;
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TipoIVA_Load(object sender, EventArgs e)
        {
            FillControls();
        }

        private void FillControls()
        {
            var viewModel = ivaProvider.GetGestionIVA();
            this.dataGridViewIVAs.DataSource = viewModel.IVAs;
            //this.dataGridViewArticulos.DataSource = viewModel.Articulos;
        }
    }
}
