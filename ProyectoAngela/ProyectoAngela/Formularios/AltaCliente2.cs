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

        public AltaCliente2()
        {
            InitializeComponent();
        }

        private void customGroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.ReadNewClientFromForm();
        }

        private AltaClienteViewModel ReadNewClientFromForm()
        {
            return new AltaClienteViewModel()
            {
                
            }
        }
    }
}
