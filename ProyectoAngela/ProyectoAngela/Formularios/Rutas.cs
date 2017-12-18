using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace AdministracionAngela.ProyectoAngela.Formularios
{
    public partial class Rutas : Form
    {
        public Rutas()
        {
            InitializeComponent();
        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void textsubcuenta_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog buscar = new FolderBrowserDialog();

            if (buscar.ShowDialog() == DialogResult.OK)
            {
                textfactura.Text = buscar.SelectedPath;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog buscar = new FolderBrowserDialog();

            if (buscar.ShowDialog() == DialogResult.OK)
            {
                textalb.Text = buscar.SelectedPath;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog buscar = new FolderBrowserDialog();

            if (buscar.ShowDialog() == DialogResult.OK)
            {
                textlist.Text = buscar.SelectedPath;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog buscar = new FolderBrowserDialog();

            if (buscar.ShowDialog() == DialogResult.OK)
            {
                textliq.Text = buscar.SelectedPath;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog buscar = new FolderBrowserDialog();

            if (buscar.ShowDialog() == DialogResult.OK)
            {
                textsegu.Text = buscar.SelectedPath;
            }
        }

        private void textlist_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
