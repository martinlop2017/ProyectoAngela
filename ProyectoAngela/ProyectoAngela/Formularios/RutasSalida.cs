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
    public partial class RutasSalida : Form
    {
        public RutasSalida()
        {
            InitializeComponent();
        }

        private void buttonFacturas_Click(object sender, EventArgs e)
        {
            if(this.folderBrowserDialogFacturas.ShowDialog() == DialogResult.OK)
            {
                this.textBoxFacturas.Text = folderBrowserDialogFacturas.SelectedPath;
            }
        }

        private void buttonAlbaranes_Click(object sender, EventArgs e)
        {
            if (this.folderBrowserDialogAlbaranes.ShowDialog() == DialogResult.OK)
            {
                this.textBoxAlbaranes.Text = folderBrowserDialogAlbaranes.SelectedPath;
            }
        }

        private void buttonListados_Click(object sender, EventArgs e)
        {
            if (this.folderBrowserDialogListados.ShowDialog() == DialogResult.OK)
            {
                this.textBoxListados.Text = folderBrowserDialogListados.SelectedPath;
            }
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {

        }
    }
}
