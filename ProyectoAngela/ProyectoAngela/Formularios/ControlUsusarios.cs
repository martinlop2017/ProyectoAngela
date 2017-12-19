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
using AdministracionAngela.Utils.Genericos;

namespace AdministracionAngela.ProyectoAngela.Formularios
{
    public partial class ControlUsusarios : Form
    {
        ISeguridadProvider seguridadProvider;
        IFormOpener formOpener;

        public ControlUsusarios(IClienteProvider clienteProvider, ISeguridadProvider seguridadProvider, IFormOpener formOpener)
        {
            this.seguridadProvider = seguridadProvider;
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
            var userValido = this.seguridadProvider.UsuarioEsValido(this.textBoxUser.Text, this.textBoxPassword.Text);
            if(userValido)
            {
                this.formOpener.ShowModalForm<Menu>();
            }
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

        private void ControlUsusarios_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.RutaFacturacion = RutasSalida.RutaFacturacion;
            Properties.Settings.Default.RutaAlbaranes = RutasSalida.RutaAlbaranes;
            Properties.Settings.Default.RutaLiquidaciones = RutasSalida.RutaLiquidaciones;
            Properties.Settings.Default.RutaListados = RutasSalida.RutaListados;
            Properties.Settings.Default.RutaSeguridad = RutasSalida.RutaSeguridad;

            Properties.Settings.Default.Save();
        }

        private void ControlUsusarios_Load(object sender, EventArgs e)
        {
            RutasSalida.RutaFacturacion = Properties.Settings.Default.RutaFacturacion;
            RutasSalida.RutaAlbaranes = Properties.Settings.Default.RutaAlbaranes;
            RutasSalida.RutaLiquidaciones = Properties.Settings.Default.RutaLiquidaciones;
            RutasSalida.RutaListados = Properties.Settings.Default.RutaListados;
            RutasSalida.RutaSeguridad = Properties.Settings.Default.RutaSeguridad;
        }
    }
}
