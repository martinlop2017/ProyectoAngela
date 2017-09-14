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
    public partial class Menu : Form
    {
        IClienteProvider clienteProvider;
        private IFormOpener formOpener;

        public Menu(IClienteProvider clienteProvider, IFormOpener formOpener)
        {
            this.clienteProvider = clienteProvider;
            this.formOpener = formOpener;
            InitializeComponent();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.formOpener.ShowModalForm<Clientes>();
        }

        private void factruasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.formOpener.ShowModalForm<GestionFacturas>();
        }

        private void misDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.formOpener.ShowModalForm<MisDatos>();
        }

        private void tiposDeIvaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.formOpener.ShowModalForm<TipoIVA>();
        }

        private void articulosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.formOpener.ShowModalForm<GestionArticulos>();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            //inicia la fecha al cargar la forma
       
          FechaInicio.Text = "    Fecha : " + DateTime.Now.ToString("dd/MM/yyyy") + "   -   Hora: " + DateTime.Now.ToShortTimeString() + "  "; 

        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void seguridadToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            buttonMisdatos.Visible = true;
            buttonUsusarios.Visible = true;
            buttonIva.Visible = true;
        }

        private void buttonSistema_MouseEnter(object sender, EventArgs e)
        {
            
        }

        private void buttonSistema_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void buttonCliente_Click(object sender, EventArgs e)
        {
            
            buttonMisdatos.Visible = false;
            buttonUsusarios.Visible = false;
            buttonIva.Visible = false;
            this.formOpener.ShowModalForm<Clientes>();
        }

        private void buttonArticulos_Click(object sender, EventArgs e)
        {
            buttonMisdatos.Visible = false;
            buttonUsusarios.Visible = false;
            buttonIva.Visible = false;
            this.formOpener.ShowModalForm<GestionArticulos>();
        }

        private void buttonAlbaranes_Click(object sender, EventArgs e)
        {
            buttonMisdatos.Visible = false;
            buttonUsusarios.Visible = false;
            buttonIva.Visible = false;
        }

        private void buttonFactura_Click(object sender, EventArgs e)
        {
            buttonMisdatos.Visible = false;
            buttonUsusarios.Visible = false;
            buttonIva.Visible = false;
            this.formOpener.ShowModalForm<GestionFacturas>();
        }

        private void buttonListados_Click(object sender, EventArgs e)
        {
            buttonMisdatos.Visible = false;
            buttonUsusarios.Visible = false;
            buttonIva.Visible = false;
        }

        private void buttonSeguridad_Click(object sender, EventArgs e)
        {
            buttonMisdatos.Visible = false;
            buttonUsusarios.Visible = false;
            buttonIva.Visible = false;
        }

        private void buttonAvisos_Click(object sender, EventArgs e)
        {
            buttonMisdatos.Visible = false;
            buttonUsusarios.Visible = false;
            buttonIva.Visible = false;
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void buttonMisdatos_Click(object sender, EventArgs e)
        {
            this.formOpener.ShowModalForm<MisDatos>();
        }

        private void buttonIva_Click(object sender, EventArgs e)
        {
            this.formOpener.ShowModalForm<TipoIVA>();
        }

        private void buttonAlbaranes_MouseEnter(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel2_Click(object sender, EventArgs e)
        {

        }

        private void buttonUsusarios_Click(object sender, EventArgs e)
        {
            this.formOpener.ShowModalForm<GestionUsusarios>();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.formOpener.ShowModalForm<GestionUsusarios>();
        }
    }
}
