using AdministracionAngela.Utils.Interfaces;
using AdministracionAngela.Utils.Models.Usuario;
using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Linq;


namespace AdministracionAngela.ProyectoAngela.Formularios
{
    public partial class GestionUsusarios : Form
    {
        private ISeguridadProvider seguridadProvider;
        private IFormOpener formOpener;
        private GestionUsuarioViewModel viewModel;
        private BindingList<UsuarioViewModel> usuarios;

        public GestionUsusarios(IFormOpener formOpener, ISeguridadProvider seguridadProvider)
        {
            this.formOpener = formOpener;
            this.seguridadProvider = seguridadProvider;
            usuarios = new BindingList<UsuarioViewModel>();
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
            usuarios = viewModel.Usuarios;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonModify_Click(object sender, EventArgs e)
        {
            var selectedRows = this.dataGridViewUsuarios.SelectedRows;

            if (selectedRows.Count == 0)
            {
                MessageBox.Show("Debe seleccionar un usuario para modificarlo");
            }
            else if (selectedRows.Count > 1)
            {
                MessageBox.Show("Solo se puede modificar un usuario al mismo tiempo");
            }
            else
            {
                var selectedUser = (UsuarioViewModel)selectedRows[0].DataBoundItem;

                this.OpenFormToModify(selectedUser);
            }
        }

        private void OpenFormToModify(UsuarioViewModel selectedUser)
        {
            var formularioAlta = new AltaUsuario(this.seguridadProvider, selectedUser);
            formularioAlta.ShowDialog();

            this.FillControls();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var formulario = new AltaUsuario(this.seguridadProvider);
            formulario.ShowDialog();

            this.FillControls();
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

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Va a proceder a eliminar el registro seleccionado.\n                     Desea Eliminar el registro?"
    , "Eliminar Registro.", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes) ;
            {
                var selectedRow = this.dataGridViewUsuarios.SelectedRows[0];
                var userToRemove = selectedRow.Cells["ColumnNombre"].Value.ToString();

                this.seguridadProvider.RemoveUser(userToRemove);
                this.FillControls();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void panel1_MouseEnter(object sender, EventArgs e)
        {
            label4.Visible = true;
        }

        private void panel1_MouseLeave(object sender, EventArgs e)
        {
            label4.Visible = false;
        }

        private void comboBoxClientes_MouseEnter(object sender, EventArgs e)
        {
            label4.Visible = true;
        }

        private void comboBoxClientes_MouseLeave(object sender, EventArgs e)
        {
            label4.Visible = false;
        }

        private void textBoxBusqueda_TextChanged(object sender, EventArgs e)
        {
            if (comboBoxBusqueda.Text.Equals("Nombre"))
            {
                this.dataGridViewUsuarios.DataSource = usuarios.Where(x => x.Nombre.ToUpper().Contains(textBoxBusqueda.Text.ToUpper())).ToList();
            }

            if (comboBoxBusqueda.Text.Equals("Nivel"))
            {
                dataGridViewUsuarios.DataSource = usuarios.Where(x => x.Nivel.ToUpper().Contains(textBoxBusqueda.Text.ToUpper())).ToList();
            }
        }
    }
}
