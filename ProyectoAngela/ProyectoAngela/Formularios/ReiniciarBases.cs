using AdministracionAngela.Utils.Interfaces;
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
    public partial class ReiniciarBases : Form
    {
        ISistemaProvider sistemaProvider;

        public ReiniciarBases(ISistemaProvider sistemaProvider)
        {
            this.sistemaProvider = sistemaProvider;
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.sistemaProvider.ReiniciarBaseDatos();
            DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
