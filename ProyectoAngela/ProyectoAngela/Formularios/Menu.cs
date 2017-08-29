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
    public partial class Menu : Form
    {
        IClienteProvider clienteProvider;
        private IFormOpener formOpener;

        public Menu(IClienteProvider clienteProvider, IFormOpener formOpener)
        {
            this.clienteProvider = clienteProvider;
            this.formOpener = formOpener;
            InitializeComponent();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.formOpener.ShowModalForm<Clientes>();
        }

        private void factruasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.formOpener.ShowModalForm<GestionFacturas>();
        }
    }
}
