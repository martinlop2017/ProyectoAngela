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
    public partial class GestionArticulos : Form
    {
        private IFormOpener formOpener;
        private IArticuloProvider articuloProvider;

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
            FillControls();
        }

        private void FillControls()
        {
            throw new NotImplementedException();
        }
    }
}
