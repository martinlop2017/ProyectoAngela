using AdministracionAngela.Domain.Interfaces;
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

        public Menu(IClienteProvider clienteProvider)
        {
            this.clienteProvider = clienteProvider;
            InitializeComponent();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clientes myForm = new ProyectoAngela.Formularios.Clientes();
            myForm.ShowDialog();
        }

        private void factruasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GestionFacturas myForm = new ProyectoAngela.Formularios.GestionFacturas();
            myForm.ShowDialog();
        }
    }
}
