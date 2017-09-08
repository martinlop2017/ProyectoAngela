using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AdministracionAngela.Utils.Extensions;
using AdministracionAngela.Utils.Interfaces;
using AdministracionAngela.Utils.Models.Cliente;

namespace AdministracionAngela.ProyectoAngela.Formularios
{
    public partial class Clientes : Form
    {
        private IFormOpener formOpener;
        private IClienteProvider clienteProvider;
        private GestionClienteViewModel viewModel;

        public Clientes(IFormOpener formOpener, IClienteProvider clienteProvider)
        {
            this.formOpener = formOpener;
            this.clienteProvider = clienteProvider;

            InitializeComponent();
        }

        private void FillControls()
        {
            viewModel = clienteProvider.GetGestionCliente();

            this.dataGridViewClientes.DataSource = viewModel.Clientes;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var selectedRows = this.dataGridViewClientes.SelectedRows;

            var mappedSelectedRows = selectedRows.ToList<ClienteViewModel>();

            //this.clienteProvider.DeleteClients(mappedSelectedRows);

            //this.FillControls();
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
            label1.Visible = true;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            label1.Visible = false;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            label2.Visible = false;
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            label2.Visible = true;
        }

        private void button3_MouseEnter(object sender, EventArgs e)
        {
            label3.Visible = true;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.formOpener.ShowModalForm<AltaCliente2>();
        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            //FillControls();
        }

        private void dataGridViewClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonModify_Click(object sender, EventArgs e)
        {
            var selectedRows = this.dataGridViewClientes.SelectedRows;

            if (selectedRows.Count == 0)
            {
                MessageBox.Show("Debe seleccionar un cliente para modificarlo");
            }
            else if (selectedRows.Count > 1)
            {
                MessageBox.Show("Solo se puede modificar un cliente al mismo tiempo");
            }
            else
            {
                var selectedClient = (ClienteViewModel)selectedRows[0].DataBoundItem;

                this.OpenFormToModify(selectedClient);
            }
        }

        private void OpenFormToModify(ClienteViewModel selectedClient)
        {
            var formAltaCliente = this.formOpener.GetForm<AltaCliente2>() as AltaCliente2;
            formAltaCliente.IsUpdate(selectedClient.Id);
            formAltaCliente.ShowDialog();
        }
    }
}
