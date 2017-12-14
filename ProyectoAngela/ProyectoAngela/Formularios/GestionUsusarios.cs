using AdministracionAngela.Utils.Interfaces;
using AdministracionAngela.Utils.Models.Usuario;
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
    public partial class GestionUsusarios : Form
    {
        private ISeguridadProvider seguridadProvider;
        private IFormOpener formOpener;
        private GestionUsuarioViewModel viewModel;

        public GestionUsusarios(IFormOpener formOpener, ISeguridadProvider seguridadProvider)
        {
            this.formOpener = formOpener;
            this.seguridadProvider = seguridadProvider;
            InitializeComponent();
        }

        private void GestionUsusarios_Load(object sender, EventArgs e)
        {
            FillControls();
        }

        private void FillControls()
        {
            viewModel = seguridadProvider.GetGestionUsuario();
            this.dataGridViewUsuarios.DataSource = viewModel.Usuarios;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void buttonModify_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.formOpener.ShowModalForm<AltaUsuario>();
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            label1.Visible = true;

        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            label1.Visible = false;
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            label2.Visible = true;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            label2.Visible = false;
        }

        private void buttonModify_MouseEnter(object sender, EventArgs e)
        {
            label3.Visible = true;
        }

        private void buttonModify_MouseLeave(object sender, EventArgs e)
        {
            label3.Visible = false;
        }

        private void button4_MouseEnter(object sender, EventArgs e)
        {
            label4.Visible = true;
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            label4.Visible = false;
        }

        private void button5_MouseEnter(object sender, EventArgs e)
        {
            label5.Visible = true;
        }

        private void button5_MouseLeave(object sender, EventArgs e)
        {
            label5.Visible = false;
        }
    }
}
