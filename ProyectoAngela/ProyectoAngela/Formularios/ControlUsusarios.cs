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
using AdministracionAngela.EFRepository;


namespace AdministracionAngela.ProyectoAngela.Formularios
{
    public partial class ControlUsusarios : Form
    {
        ISeguridadProvider seguridadProvider;
        IFormOpener formOpener;
        AdministracionAngela.EFRepository.AdministracionAngelaContext bd;
       // AdministracionAntonioEntities baseDeDatos;
        int contador = 0;

        public ControlUsusarios(IClienteProvider clienteProvider, ISeguridadProvider seguridadProvider, IFormOpener formOpener)
        {
            this.seguridadProvider = seguridadProvider;
            this.formOpener = formOpener;
            bd = new AdministracionAngela.EFRepository.AdministracionAngelaContext();
            
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
            string llave = Encriptar.codificar(textBoxPassword.Text);

            var compro = bd.Users.Where(X => X.UserName == comboBox1.Text && X.Password == llave).ToList();
            if (compro.Count == 1)
            {

                // Abre el menu principal
                this.formOpener.ShowModalForm<Menu>();
        
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

            if (textBoxPassword.Text == "citroenc5")
            { // Abre el menu principal
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
            Properties.Settings.Default.RutaAlbaranes2 = RutasSalida.RutaAlbaranes2;
            Properties.Settings.Default.RutaLiquidaciones = RutasSalida.RutaLiquidaciones;
            Properties.Settings.Default.RutaListados = RutasSalida.RutaListados;
            Properties.Settings.Default.RutaSeguridad = RutasSalida.RutaSeguridad;

            Properties.Settings.Default.Save();
        }

        private void ControlUsusarios_Load(object sender, EventArgs e)
        {
            RutasSalida.RutaFacturacion = Properties.Settings.Default.RutaFacturacion;
            RutasSalida.RutaAlbaranes = Properties.Settings.Default.RutaAlbaranes;
            RutasSalida.RutaAlbaranes2 = Properties.Settings.Default.RutaAlbaranes2;
            RutasSalida.RutaLiquidaciones = Properties.Settings.Default.RutaLiquidaciones;
            RutasSalida.RutaListados = Properties.Settings.Default.RutaListados;
            RutasSalida.RutaSeguridad = Properties.Settings.Default.RutaSeguridad;

            comboBox1.DataSource = bd.Users.Where(user => user.Activo == true).Select(user => user.UserName).ToList<string>();
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
