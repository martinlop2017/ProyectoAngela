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
    public partial class Facturacion : Form
    {
        int linea = 0;
        private IFacturaProvider facturaProvider;

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

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            label8.Visible = true;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            label8.Visible = false;
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            label7.Visible = true;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            label7.Visible = false;
        }

        private void button3_MouseEnter(object sender, EventArgs e)
        {
            label6.Visible = true;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            label6.Visible = false;
        }

        private void button5_MouseEnter(object sender, EventArgs e)
        {
            label5.Visible = true;
        }

        private void button5_MouseLeave(object sender, EventArgs e)
        {
            label5.Visible = false;

        }

        private void Facturacion_Load(object sender, EventArgs e)
        {
            
        }

        private void button11_Click_2(object sender, EventArgs e)
        {
            linea = 1;
        }
    }
}
