using AdministracionAngela.Utils.Interfaces;
using AdministracionAngela.Utils.Models.Cliente;
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
    public partial class AltaCliente2 : Form
    {
        AltaClienteViewModel viewModel = new AltaClienteViewModel();
        IClienteProvider clienteProvider;

        public AltaCliente2(IClienteProvider clienteProvider)
        {
            this.clienteProvider = clienteProvider;
            InitializeComponent();
        }

        private void customGroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.validationProvider1.ValidationMessages(!this.validationProvider1.Validate());

            var newClient = this.ReadNewClientFromForm();

            this.clienteProvider.SaveClient(newClient);
        }

        private AltaClienteViewModel ReadNewClientFromForm()
        {
            return new AltaClienteViewModel()
            {
                //CodigoCliente = labelCodigoCliente.Text,
                NombreComercial = textBoxNombreComercial.Text,
                NIF = textBoxNIF.Text,
                Direccion = textBoxDireccion.Text,
                Poblacion = textBoxPoblacion.Text,
                Provincia = textBoxProvincia.Text,
                CodigoPostal = Convert.ToInt32(textBoxCodigoPostal.Text),
                Telefono1 = Convert.ToInt32(textBoxTelefono1.Text),
                Telefono2 = Convert.ToInt32(textBoxTelefono2.Text),
                Fax = textBoxFax.Text,
                Email = textBoxEmail.Text,
                PersonaDeContacto = textBoxPersonaContacto.Text,
                RiesgoMaximo = Convert.ToInt32(textBoxRiesgoMaximo.Text),
                FormaDePago = textBoxFormaPago.Text
            };
        }
    }
}
