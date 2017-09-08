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
using AdministracionAngela.Utils.Models.Articulo;
using AdministracionAngela.Utils.Extensions;

namespace AdministracionAngela.ProyectoAngela.Formularios
{
    public partial class GestionArticulos : Form
    {
        private IFormOpener formOpener;
        private IArticuloProvider articuloProvider;
        private GestionArticuloViewModel viewModel;

        public GestionArticulos(IFormOpener formOpener, IArticuloProvider articuloProvider)
        {
            this.formOpener = formOpener;
            this.articuloProvider = articuloProvider;

            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.formOpener.ShowModalForm<AltaArticulo>();
        }

        private void GestionArticulos_Load(object sender, EventArgs e)
        {
            //FillControls();
        }

        private void FillControls()
        {
            viewModel = articuloProvider.GetGestionArticulo();
            this.dataGridViewArticulos.DataSource = viewModel.Articulos;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            var selectedRows = this.dataGridViewArticulos.SelectedRows;

            var mappedSelectedRows = selectedRows.ToList<ArticuloViewModel>();

            //this.articuloProvider.DeleteArticulos(mappedSelectedRows);

            //this.FillControls();
        }

        private void buttonModify_Click(object sender, EventArgs e)
        {
            var selectedRows = this.dataGridViewArticulos.SelectedRows;

            if (selectedRows.Count == 0)
            {
                MessageBox.Show("Debe seleccionar un articulo para modificarlo");
            }
            else if (selectedRows.Count > 1)
            {
                MessageBox.Show("Solo se puede modificar un articulo al mismo tiempo");
            }
            else
            {
                var selectedArticulo = (ArticuloViewModel)selectedRows[0].DataBoundItem;

                this.OpenFormToModify(selectedArticulo);

            }
        }

        private void OpenFormToModify(ArticuloViewModel selectedArticulo)
        {
            var formAltaCliente = this.formOpener.GetForm<AltaArticulo>() as AltaArticulo;
            formAltaCliente.IsUpdate(selectedArticulo.Id);
            formAltaCliente.ShowDialog();
        }
    }
}
