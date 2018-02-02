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
        private IPerfilProvider perfilProvider;
        private bool isUpdate = false;
        private int perfilId;

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

        private PerfilViewModel ReadForm()
        {
            return new PerfilViewModel()
            {
                Nombre = textBoxMiNombre.Text,
                NIF = textBoxMiCif.Text,
                Direccion = textBoxMiDireccion.Text,
                Provincia = textBoxMiProvincia.Text,
                Poblacion = textBoxMiPoblacion.Text,
                PersonaContacto = textBoxMiPersonaContacto.Text,
                Fax = Convert.ToInt32(textBoxMiFax.Text),
                Telefono1 = Convert.ToInt32(textBoxMiTLF1.Text),
                Telefono2 = Convert.ToInt32(textBoxMiTLF2.Text),
                CodigoPostal = Convert.ToInt32(textBoxMiCP.Text),
                Email = textBoxMiMail.Text,
                LogoPath = textBoxLogoPath.Text,
                Iban1 = textBoxIBAN1.Text,
                Iban2 = textBoxIBAN3.Text,
                Iban3 = textBoxIBAN3.Text,
                Iban4 = textBoxIBAN4.Text,
                Iban5 = textBoxIBAN5.Text,
                Iban6 = textBoxIBAN6.Text,
            };
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MisDatos_Load(object sender, EventArgs e)
        {
            var viewModel = this.perfilProvider.GetPerfil();

            //Si tenemos un perfil relleno en base de datos significa que se va a actualizar
            if (viewModel != null)
            {
                this.isUpdate = true;
                this.perfilId = viewModel.Id;
                this.FillControls(viewModel);
            }
        }

        private void FillControls(PerfilViewModel perfil)
        {
            this.textBoxMiNombre.Text = perfil.Nombre;
            this.textBoxMiCif.Text = perfil.NIF;
            this.textBoxMiDireccion.Text = perfil.Direccion;
            this.textBoxMiCP.Text = perfil.CodigoPostal.ToString();
            this.textBoxMiProvincia.Text = perfil.Provincia;
            this.textBoxMiPoblacion.Text = perfil.Poblacion;
            this.textBoxMiTLF1.Text = perfil.Telefono1.ToString();
            this.textBoxMiTLF2.Text = perfil.Telefono2.ToString();
            this.textBoxMiFax.Text = perfil.Fax.ToString();
            this.textBoxMiMail.Text = perfil.Email;
            this.textBoxLogoPath.Text = perfil.LogoPath;
            this.textBoxMiPersonaContacto.Text = perfil.PersonaContacto;
            this.textBoxIBAN1.Text = perfil.Iban1;
            this.textBoxIBAN2.Text = perfil.Iban2;
            this.textBoxIBAN3.Text = perfil.Iban3;
            this.textBoxIBAN4.Text = perfil.Iban4;
            this.textBoxIBAN5.Text = perfil.Iban5;
            this.textBoxIBAN6.Text = perfil.Iban6;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            var nuevoPerfil = this.ReadForm();
            if (isUpdate)
            {
                this.perfilProvider.UpdatePerfil(nuevoPerfil);
            }
            else
            {
                this.perfilProvider.SavePerfil(nuevoPerfil);
            }
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog buscar = new OpenFileDialog();

            if (buscar.ShowDialog() == DialogResult.OK)
            {
                textBoxLogoPath.Text = buscar.FileName;
                Bitmap Picture = new Bitmap(buscar.FileName);
                pictureBox1.Image = (Image)Picture;
            }

        }

        private void MisDatos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(13))
            {
                e.Handled = true; SendKeys.Send("{TAB}");
            }
        }
    }
}
