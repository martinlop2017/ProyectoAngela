using AdministracionAngela.Utils.Interfaces;
using AdministracionAngela.Utils.Models.Usuario;
using System;
using System.Windows.Forms;
using AdministracionAngela.Utils.Genericos;

namespace AdministracionAngela.ProyectoAngela.Formularios
{
    public partial class AltaUsuario : Form
    {
        ISeguridadProvider seguridadProvider;
        private UsuarioViewModel userToUpdate;
        

        public AltaUsuario(ISeguridadProvider seguridadProvider, UsuarioViewModel userToUpdate = null)
        {
            this.seguridadProvider = seguridadProvider;
            this.userToUpdate = userToUpdate;

            InitializeComponent();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            var newUser = this.ReadNewUserFromForm();

            if(userToUpdate != null)
            {
                this.seguridadProvider.UpdateUser(newUser);
            }
            else
            {
                this.seguridadProvider.SaveUser(newUser);
            }

            this.Close();
        }

        private AltaUsuarioViewModel ReadNewUserFromForm()
        {
            return new AltaUsuarioViewModel()
            {
                UserName = this.textBoxUserName.Text,
                Password = Encriptar.codificar( this.maskedTextBoxPassword.Text),
                Nivel = this.comboBoxNivel.Text,
                Activo = radioButton1.Checked
            };
        }

        private void FillFormWithUser(AltaUsuarioViewModel viewModel)
        {
            this.textBoxUserName.Text = viewModel.UserName;
            this.maskedTextBoxPassword.Text = Encriptar.Descodificar(viewModel.Password);
            this.maskedTextBox2.Text = Encriptar.Descodificar(viewModel.Password);
            this.comboBoxNivel.Text = viewModel.Nivel;
            this.radioButton1.Checked = viewModel.Activo;
            this.radioButton2.Checked = !viewModel.Activo;
        }

        private void AltaUsuario_Load(object sender, EventArgs e)
        {
            var viewModel = new AltaUsuarioViewModel();
            if(userToUpdate != null)
            {
                this.textBoxUserName.Enabled = false;
                viewModel.UserName = userToUpdate.Nombre;
                viewModel.Password = userToUpdate.Password;
                viewModel.Nivel = userToUpdate.Nivel;
                viewModel.Activo = userToUpdate.Activo;
            }

            this.FillFormWithUser(viewModel);
        }

        private void AltaUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(13))
            {
                e.Handled = true; SendKeys.Send("{TAB}");
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
          
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            maskedTextBoxPassword.UseSystemPasswordChar = false;
            maskedTextBox2.UseSystemPasswordChar = false;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Leave(object sender, EventArgs e)
        {

        }

        private void maskedTextBox2_Leave(object sender, EventArgs e)
        {
            if (maskedTextBoxPassword.Text != maskedTextBox2.Text)
            {
                MessageBox.Show("Los valores no coinciden.");
                maskedTextBox2.Text = "";
                maskedTextBoxPassword.Text = "";
                maskedTextBoxPassword.Focus();
            }
        }

        private void panel2_MouseLeave(object sender, EventArgs e)
        {
            maskedTextBoxPassword.UseSystemPasswordChar = true;
            maskedTextBox2.UseSystemPasswordChar = true;
        }
    }
}
