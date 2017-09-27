using AdministracionAngela.ProyectoAngela.Infraestructura;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StructureMap;
using AdministracionAngela.ProyectoAngela.Utils;
using AdministracionAngela.Utils.Interfaces;

namespace AdministracionAngela.ProyectoAngela.Formularios
{
    public partial class ControlUsusarios : Form
    {
        IClienteProvider clienteProvider;
        IFormOpener formOpener;

        public ControlUsusarios(IClienteProvider clienteProvider, IFormOpener formOpener)
        {
            this.clienteProvider = clienteProvider;
            this.formOpener = formOpener;
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.formOpener.ShowModalForm<Menu>();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackgroundImage = AdministracionAngela.ProyectoAngela.Properties.Resources.Llave_azul;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackgroundImage = AdministracionAngela.ProyectoAngela.Properties.Resources.Llave;
        }

        private void button1_Enter(object sender, EventArgs e)
        {
         
        }

        private void button1_Leave(object sender, EventArgs e)
        {
            
        }
    }
}
