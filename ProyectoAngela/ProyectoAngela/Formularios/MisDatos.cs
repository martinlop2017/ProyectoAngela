using AdministracionAngela.Utils.Interfaces;
using AdministracionAngela.Utils.Models.Perfil;
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
    public partial class MisDatos : Form
    {
        IPerfilProvider perfilProvider;

        public MisDatos(IPerfilProvider perfilProvider)
        {
            this.perfilProvider = perfilProvider;

            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MisDatos_Load(object sender, EventArgs e)
        {
            var viewModel = this.perfilProvider.GetPerfil();
            this.FillControls(viewModel);
        }

        private void FillControls(PerfilViewModel perfil)
        {
            this.textBoxNombre.Text = perfil.Nombre;
            this.textBoxNIF.Text = perfil.NIF;
            this.textBoxDireccion.Text = perfil.Direccion;
            this.textBoxCodigoPostal.Text = perfil.CodigoPostal.ToString();
            this.textBoxProvincia.Text = perfil.Provincia;
            this.textBoxPoblacion.Text = perfil.Poblacion;
            this.textBoxTelefono1.Text = perfil.Telefono1.ToString();
            this.textBoxTelefono2.Text = perfil.Telefono2.ToString();
            this.textBoxFax.Text = perfil.Fax.ToString();
            this.textBoxEmail.Text = perfil.Email;
        }
    }
}
