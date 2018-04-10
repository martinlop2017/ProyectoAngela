using AdministracionAngela.Utils.Interfaces;
using System;
using System.Windows.Forms;
using AdministracionAngela.Utils.Enumerados;
using AdministracionAngela.Utils.Genericos;
using System.Drawing;

namespace AdministracionAngela.ProyectoAngela.Formularios
{
    public partial class Menu : Form
    {
        IClienteProvider clienteProvider;
        ISistemaProvider sistemaProvider;
        private IFormOpener formOpener;

        public Menu(IClienteProvider clienteProvider, ISistemaProvider sistemaProvider, IFormOpener formOpener)
        {
            this.clienteProvider = clienteProvider;
            this.sistemaProvider = sistemaProvider;
            this.formOpener = formOpener;
            InitializeComponent();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.formOpener.ShowModalForm<Clientes>();
        }

        private void factruasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formOpener.ShowDocumentoGestionForm(EnumDocumentosGestion.Factura);
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
            if(NivelUsuario.Nivel.Equals("Usuario"))
            {
                buttonSistema.Visible = false;
                buttonCliente.Visible = false;
                buttonArticulos.Visible = false;
                buttonFactura.Visible = false;
                buttonListados.Visible = false;
                buttonSeguridad.Visible = false;
                buttonLiq.Visible = false;
                buttonAvisos.Visible = false;
                //desactiva el menu superior
                menuStrip1.Visible = false;
                buttonAlbaranes.Location = new Point(26, 43);

            }
            var hayFacturasCaducadas = sistemaProvider.HayFacturasCaducadas();
            buttonAvisos.BackgroundImage = hayFacturasCaducadas ? Properties.Resources.Avisos_Rojos : Properties.Resources.Avisos;

            this.timer1.Start();
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void seguridadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.formOpener.ShowModalForm<Liquidaciones>();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            buttonMisdatos.Visible = true;
            buttonUsusarios.Visible = true;
            buttonIva.Visible = true;
            buttonCobro.Visible = true;
            buttonRutas.Visible = true;
        }

        private void buttonSistema_MouseEnter(object sender, EventArgs e)
        {
            buttonSistema.BackgroundImage = AdministracionAngela.ProyectoAngela.Properties.Resources.Sistema_Azul;
        }

        private void buttonSistema_MouseLeave(object sender, EventArgs e)
        {
            buttonSistema.BackgroundImage = AdministracionAngela.ProyectoAngela.Properties.Resources.Sistema;
        }

        private void buttonCliente_Click(object sender, EventArgs e)
        {
            
            buttonMisdatos.Visible = false;
            buttonUsusarios.Visible = false;
            buttonIva.Visible = false;
            buttonCobro.Visible = false;
            buttonRutas.Visible = false;
            this.formOpener.ShowModalForm<Clientes>();
        }

        private void buttonArticulos_Click(object sender, EventArgs e)
        {
            buttonMisdatos.Visible = false;
            buttonUsusarios.Visible = false;
            buttonIva.Visible = false;
            buttonCobro.Visible = false;
            buttonRutas.Visible = false;
            this.formOpener.ShowModalForm<GestionArticulos>();
        }

        private void buttonAlbaranes_Click(object sender, EventArgs e)
        {
            buttonMisdatos.Visible = false;
            buttonUsusarios.Visible = false;
            buttonIva.Visible = false;
            buttonCobro.Visible = false;
            buttonRutas.Visible = false;

            this.formOpener.ShowDocumentoGestionForm(EnumDocumentosGestion.Albaran);
        }

        private void buttonFactura_Click(object sender, EventArgs e)
        {
            buttonMisdatos.Visible = false;
            buttonUsusarios.Visible = false;
            buttonIva.Visible = false;
            buttonRutas.Visible = false;
            buttonCobro.Visible = false;

            this.formOpener.ShowDocumentoGestionForm(EnumDocumentosGestion.Factura);
        }

        private void buttonListados_Click(object sender, EventArgs e)
        {
            buttonMisdatos.Visible = false;
            buttonUsusarios.Visible = false;
            buttonIva.Visible = false;
            buttonCobro.Visible = false;
            buttonRutas.Visible = false;
        }

        private void buttonSeguridad_Click(object sender, EventArgs e)
        {
            buttonMisdatos.Visible = false;
            buttonUsusarios.Visible = false;
            buttonIva.Visible = false;
            buttonCobro.Visible = false;
            buttonRutas.Visible = false;

            var backUpOk = this.sistemaProvider.BackUp();
            var message = backUpOk ? "Copia de seguridad realizada correctamente" : "Fallo al realizar la copia de seguridad";

            MessageBox.Show(message);
        }

        private void buttonAvisos_Click(object sender, EventArgs e)
        {
            buttonMisdatos.Visible = false;
            buttonUsusarios.Visible = false;
            buttonIva.Visible = false;
            buttonCobro.Visible = false;
            buttonRutas.Visible = false;
            this.formOpener.ShowModalForm<GestionAvisos>();
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
            buttonAlbaranes.BackgroundImage = AdministracionAngela.ProyectoAngela.Properties.Resources.Albaranes_Azul;
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

        private void buttonCliente_MouseEnter(object sender, EventArgs e)
        {
            buttonCliente.BackgroundImage = AdministracionAngela.ProyectoAngela.Properties.Resources.Clientes_Azul;
        }

        private void buttonCliente_MouseLeave(object sender, EventArgs e)
        {
            buttonCliente.BackgroundImage = AdministracionAngela.ProyectoAngela.Properties.Resources.Clientes;
        }

        private void buttonArticulos_MouseEnter(object sender, EventArgs e)
        {
            buttonArticulos.BackgroundImage = AdministracionAngela.ProyectoAngela.Properties.Resources.Articulos_Azul;
        }

        private void buttonArticulos_MouseLeave(object sender, EventArgs e)
        {
            buttonArticulos.BackgroundImage = AdministracionAngela.ProyectoAngela.Properties.Resources.Articulos;
        }

        private void buttonAlbaranes_MouseLeave(object sender, EventArgs e)
        {
            buttonAlbaranes.BackgroundImage = AdministracionAngela.ProyectoAngela.Properties.Resources.Albaranes;
        }

        private void buttonFactura_MouseEnter(object sender, EventArgs e)
        {
            buttonFactura.BackgroundImage = AdministracionAngela.ProyectoAngela.Properties.Resources.Facturass_Azul;
        }

        private void buttonFactura_MouseLeave(object sender, EventArgs e)
        {
            buttonFactura.BackgroundImage = AdministracionAngela.ProyectoAngela.Properties.Resources.Facturass;
        }

        private void buttonListados_MouseEnter(object sender, EventArgs e)
        {
            buttonListados.BackgroundImage = AdministracionAngela.ProyectoAngela.Properties.Resources.Listados_Azul;
        }

        private void buttonListados_MouseLeave(object sender, EventArgs e)
        {
            buttonListados.BackgroundImage = AdministracionAngela.ProyectoAngela.Properties.Resources.Listados;
        }

        private void buttonSeguridad_MouseEnter(object sender, EventArgs e)
        {
            buttonSeguridad.BackgroundImage = AdministracionAngela.ProyectoAngela.Properties.Resources.Copias_Seguridad_Azul;
        }

        private void buttonSeguridad_MouseLeave(object sender, EventArgs e)
        {
            buttonSeguridad.BackgroundImage = AdministracionAngela.ProyectoAngela.Properties.Resources.Copias_Seguridad;
        }  

        private void buttonMisdatos_MouseEnter(object sender, EventArgs e)
        {
            buttonMisdatos.BackgroundImage = AdministracionAngela.ProyectoAngela.Properties.Resources.Mis_Datos_Azul;
        }

        private void buttonMisdatos_MouseLeave(object sender, EventArgs e)
        {
            buttonMisdatos.BackgroundImage = AdministracionAngela.ProyectoAngela.Properties.Resources.Mis_Datos;
        }

        private void buttonUsusarios_MouseEnter(object sender, EventArgs e)
        {
            buttonUsusarios.BackgroundImage = AdministracionAngela.ProyectoAngela.Properties.Resources.Usuarios_Azul;
        }

        private void buttonUsusarios_MouseLeave(object sender, EventArgs e)
        {
            buttonUsusarios.BackgroundImage = AdministracionAngela.ProyectoAngela.Properties.Resources.Usuarios;
        }

        private void buttonIva_MouseEnter(object sender, EventArgs e)
        {
            buttonIva.BackgroundImage = AdministracionAngela.ProyectoAngela.Properties.Resources.Impuestos_Azul;
        }

        private void buttonIva_MouseLeave(object sender, EventArgs e)
        {
            buttonIva.BackgroundImage = AdministracionAngela.ProyectoAngela.Properties.Resources.Impuestos;
        }

        private void formasDePagoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.formOpener.ShowModalForm<Rutas>();
        }

        private void buttonCobro_MouseEnter(object sender, EventArgs e)
        {
            buttonCobro.BackgroundImage = AdministracionAngela.ProyectoAngela.Properties.Resources.Cobros_Azul;
        }

        private void buttonCobro_Click(object sender, EventArgs e)
        {
            this.formOpener.ShowModalForm<FormaPago>();
        }

        private void buttonCobro_MouseLeave(object sender, EventArgs e)
        {
            buttonCobro.BackgroundImage = AdministracionAngela.ProyectoAngela.Properties.Resources.Cobros;
        }

        private void buttonRutas_MouseEnter(object sender, EventArgs e)
        {
            buttonRutas.BackgroundImage = AdministracionAngela.ProyectoAngela.Properties.Resources.Rutas_Azul;
        }

        private void buttonRutas_MouseLeave(object sender, EventArgs e)
        {
            buttonRutas.BackgroundImage = AdministracionAngela.ProyectoAngela.Properties.Resources.Rutas;
        }

        private void buttonRutas_Click(object sender, EventArgs e)
        {
            this.formOpener.ShowModalForm<Rutas>();
        }

        private void rutasExportaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            this.formOpener.ShowModalForm<FormaPago>();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            buttonMisdatos.Visible = false;
            buttonUsusarios.Visible = false;
            buttonIva.Visible = false;
            buttonCobro.Visible = false;
            buttonRutas.Visible = false;
            this.formOpener.ShowModalForm<Liquidaciones>();
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            buttonLiq.BackgroundImage = AdministracionAngela.ProyectoAngela.Properties.Resources.Liquidaciones_Azul;
        }

        private void buttonLiq_MouseLeave(object sender, EventArgs e)
        {
            buttonLiq.BackgroundImage = AdministracionAngela.ProyectoAngela.Properties.Resources.Liquidaciones;
        }

        private void Menu_FormClosed(object sender, FormClosedEventArgs e)
        {
           Application.Exit();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void albaranesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.formOpener.ShowDocumentoGestionForm(EnumDocumentosGestion.Albaran);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            FechaInicio.Text = "    Fecha : " + DateTime.Now.ToString("dd/MM/yyyy") + "   -   Hora: " + DateTime.Now.ToShortTimeString() + "  ";

            var hayFacturasCaducadas = sistemaProvider.HayFacturasCaducadas();
            buttonAvisos.BackgroundImage = hayFacturasCaducadas ? Properties.Resources.Avisos_Rojos : Properties.Resources.Avisos;
        }
    }
}
