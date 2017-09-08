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
        private AltaClienteViewModel viewModel = new AltaClienteViewModel();
        private IClienteProvider clienteProvider;
        private bool isUpdate = false;
        private long clienteId;

        public AltaCliente2(IClienteProvider clienteProvider)
        {
            this.clienteProvider = clienteProvider;

            InitializeComponent();
        }

        public void IsUpdate(long clienteId)
        {
            this.isUpdate = true;
            this.clienteId = clienteId;
        }

        private void customGroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.Validate())
            {
                var newClient = this.ReadNewClientFromForm();

                if(!isUpdate)
                {
                    this.clienteProvider.SaveClient(newClient);
                }
                else
                {
                    this.clienteProvider.UpdateClient(newClient);
                }
            }
        }

        private bool Validate()
        {
            return
                string.IsNullOrEmpty(this.validationProvider1.ValidationMessages(!this.validationProvider1.Validate()));
        }

        private AltaClienteViewModel ReadNewClientFromForm()
        {
            return new AltaClienteViewModel()
            {
                Id = isUpdate ? clienteId : 0,
                CodigoCliente = Convert.ToInt32(textBoxCodigoCliente.Text),
                NombreComercial = textBoxNombreComercial.Text,
                NIF = textBoxNIF.Text,
                Direccion = textBoxDireccion.Text,
                Poblacion = textBoxPoblacion.Text,
                Provincia = textBoxProvincia.Text,
                CodigoPostal = Convert.ToInt32(textBoxCodigoPostal.Text),
                Telefono1 = Convert.ToInt32(textBoxTelefono1.Text),
                Telefono2 = Convert.ToInt32(textBoxTelefono2.Text),
                Fax = Convert.ToInt32(textBoxFax.Text),
                Email = textBoxEmail.Text,
                PersonaDeContacto = textBoxPersonaContacto.Text,
                RiesgoMaximo = Convert.ToInt32(textBoxRiesgoMaximo.Text),
                FormaDePago = textBoxFormaPago.Text,
                isGeneral = checkBoxIVAGeneral.Checked,
                RecargoEquivalencia = checkBoxRE.Checked,
                UnionEuropea = checkBoxUE.Checked,
                Excento = checkBoxExcento.Checked
            };
        }

        private void FillFormWithClient(AltaClienteViewModel cliente)
        {
            this.textBoxCodigoCliente.Text = cliente.CodigoCliente.ToString();
            this.textBoxNombreComercial.Text = cliente.NombreComercial;
            this.textBoxNIF.Text = cliente.NIF.ToString();
            this.textBoxDireccion.Text = cliente.Direccion;
            this.textBoxPoblacion.Text = cliente.Poblacion;
            this.textBoxProvincia.Text = cliente.Provincia;
            this.textBoxCodigoPostal.Text = cliente.CodigoPostal.ToString();
            this.textBoxTelefono1.Text = cliente.Telefono1.ToString();
            this.textBoxTelefono2.Text = cliente.Telefono2.ToString();
            this.textBoxFax.Text = cliente.Fax.ToString();
            this.textBoxEmail.Text = cliente.Email;
            this.textBoxPersonaContacto.Text = cliente.PersonaDeContacto;
            this.textBoxRiesgoMaximo.Text = cliente.RiesgoMaximo.ToString();
            this.textBoxFormaPago.Text = cliente.FormaDePago;
            this.checkBoxIVAGeneral.Checked = cliente.isGeneral;
            this.checkBoxRE.Checked = cliente.RecargoEquivalencia;
            this.checkBoxUE.Checked = cliente.UnionEuropea;
            this.checkBoxExcento.Checked = cliente.Excento;
        }

        /// <summary>
        /// Importante usar evento Click y no CheckChanged, porque sino, cuando cambias el valor checked, vuelve a dispararse el evento
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkBoxIVA_Click(object sender, EventArgs e)
        {
            this.AdjustIVAcheckBoxes(sender);
        }

        /// <summary>
        /// Uncheck los otros checkBoxes en funcion del que se haya clickado
        /// </summary>
        /// <param name="checkBoxChecked"></param>
        private void AdjustIVAcheckBoxes(object checkBoxChecked)
        {
            if (checkBoxChecked == this.checkBoxIVAGeneral || checkBoxChecked == this.checkBoxRE)
            {
                checkBoxUE.Checked = false;
                checkBoxExcento.Checked = false;
            }
            else if (checkBoxChecked == this.checkBoxUE)
            {
                checkBoxIVAGeneral.Checked = false;
                checkBoxRE.Checked = false;
                checkBoxExcento.Checked = false;
            }
            else
            {
                checkBoxIVAGeneral.Checked = false;
                checkBoxRE.Checked = false;
                checkBoxUE.Checked = false;
            }
        }

        private void AltaCliente2_Load(object sender, EventArgs e)
        {
            if(this.isUpdate)
            {
                var client = this.clienteProvider.GetAltaClienteById(clienteId);
                this.FillFormWithClient(client);
            }
        }
    }
}
