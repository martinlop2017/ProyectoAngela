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
    public partial class Facturacion : Form
    {
        int linea = 0;

        public Facturacion()
        {
            InitializeComponent();
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            LineaFacturacion.Visible = true;
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label36_Click(object sender, EventArgs e)
        {

        }

        private void label33_Click(object sender, EventArgs e)
        {

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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            BusquedaClientes.Visible = false;

        }

        private void button8_Click(object sender, EventArgs e)
        {
            BusquedaClientes.Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            BusquedaClientes.Visible = true;
        }

        private void label46_Click(object sender, EventArgs e)
        {

        }

        private void label49_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            
        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            
        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            LineaFacturacion.Visible = false;
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            LineaFacturacion.Visible = false;
        }

        private void button11_Click_1(object sender, EventArgs e)
        {
            BusquedaClientes.Visible = true;
            LineaFacturacion.Visible = false;
        }

        private void Facturacion_Load(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {
            BusquedaClientes.Visible = false;
            LineaFacturacion.Visible = true;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            BusquedaClientes.Visible = false;
            LineaFacturacion.Visible = true;
        }

        private void button11_Click_2(object sender, EventArgs e)
        {
            BusquedaClientes.Visible = true;
            LineaFacturacion.Visible = false;
            linea = 1;
        }

        private void button10_Click_2(object sender, EventArgs e)
        {
            LineaFacturacion.Visible = false;
        }

        private void button9_Click_2(object sender, EventArgs e)
        {
            LineaFacturacion.Visible = false;
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            BusquedaClientes.Visible = false;
            if (linea == 1)
            {
                LineaFacturacion.Visible = true;
            }
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            BusquedaClientes.Visible = false;
            if (linea == 1)
            {
                LineaFacturacion.Visible = true;
            }
        }
    }
}
