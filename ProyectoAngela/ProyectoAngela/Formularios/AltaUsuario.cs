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
    public partial class AltaUsuario : Form
    {
        ISeguridadProvider seguridadProvider;
        private bool isUpdate = false;
        private string userId;

        public AltaUsuario(ISeguridadProvider seguridadProvider)
        {
            this.seguridadProvider = seguridadProvider;

            InitializeComponent();
        }

        public void IsUpdate(string userId)
        {
            this.isUpdate = true;
            this.userId = userId;
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

            this.seguridadProvider.SaveUser(newUser);

            this.Close();
        }

        private AltaUsuarioViewModel ReadNewUserFromForm()
        {
            return new AltaUsuarioViewModel()
            {
                UserName = this.textBoxUserName.Text,
                Password = this.maskedTextBoxPassword.Text
            };
        }

        private void FillFormWithArticulo(AltaUsuarioViewModel viewModel)
        {
            this.textBoxUserName.Text = viewModel.UserName;
        }

        private void AltaUsuario_Load(object sender, EventArgs e)
        {
            var viewModel = new AltaUsuarioViewModel();
            if(isUpdate)
            {
                viewModel.UserName = this.userId;
            }

            this.FillFormWithArticulo(viewModel);
        }

        private void AltaUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(13))
            {
                e.Handled = true; SendKeys.Send("{TAB}");
            }
        }
    }
}
