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

        public AltaUsuario(ISeguridadProvider seguridadProvider)
        {
            this.seguridadProvider = seguridadProvider;

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

            this.seguridadProvider.SaveUser(newUser);
        }

        private AltaUsuarioViewModel ReadNewUserFromForm()
        {
            return new AltaUsuarioViewModel()
            {
                UserName = this.textBoxUserName.Text,
                Password = this.maskedTextBoxPassword.Text
            };
        }
    }
}
