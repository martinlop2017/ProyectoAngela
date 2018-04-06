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
    public partial class GestionListados : Form
    {
        public GestionListados()
        {
            InitializeComponent();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void treeView1_Click(object sender, EventArgs e)
        {

        }

        private void treeView1_MouseCaptureChanged(object sender, EventArgs e)
        {

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (treeView1.Nodes[1].Nodes[0].IsSelected || treeView1.Nodes[1].Nodes[1].IsSelected)
            {
                textBoxClienteInicial.Enabled = true;
                textBoxClienteFinal.Enabled = true;
                textBoxFechaInicial.Enabled = true;
                textBoxFechaFinal.Enabled = true;
            }
            else
            {
                textBoxClienteInicial.Enabled = false;
                textBoxClienteInicial.Text= "";
                textBoxClienteFinal.Enabled = false;
                textBoxClienteFinal.Text = "";
                textBoxFechaInicial.Enabled = false;
                textBoxFechaInicial.Text = "";
                textBoxFechaFinal.Enabled = false;
                textBoxFechaFinal.Text = "";
            }
        }
    }
}
