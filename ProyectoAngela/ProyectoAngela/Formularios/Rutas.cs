using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using AdministracionAngela.Utils.Interfaces;
using AdministracionAngela.Utils.Models.RutasSalida;
using AdministracionAngela.Utils.Genericos;

namespace AdministracionAngela.ProyectoAngela.Formularios
{
    public partial class Rutas : Form
    {
        private ISistemaProvider sistemaProvider;

        public Rutas(ISistemaProvider sistemaProvider)
        {
            this.sistemaProvider = sistemaProvider;
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog buscar = new FolderBrowserDialog();

            if (buscar.ShowDialog() == DialogResult.OK)
            {
                textFactura.Text = buscar.SelectedPath;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog buscar = new FolderBrowserDialog();

            if (buscar.ShowDialog() == DialogResult.OK)
            {
                textAlbaranes.Text = buscar.SelectedPath;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog buscar = new FolderBrowserDialog();

            if (buscar.ShowDialog() == DialogResult.OK)
            {
                textListados.Text = buscar.SelectedPath;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog buscar = new FolderBrowserDialog();

            if (buscar.ShowDialog() == DialogResult.OK)
            {
                textLiquidaciones.Text = buscar.SelectedPath;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog buscar = new FolderBrowserDialog();

            if (buscar.ShowDialog() == DialogResult.OK)
            {
                textAlbaranes2.Text = buscar.SelectedPath;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            var viewModel = ReadFromForm();

            this.sistemaProvider.SaveRutasSalida(viewModel);

            Close();
        }

        private RutasSalidaViewModel ReadFromForm()
        {
            return new RutasSalidaViewModel()
            {
                PathFacturas = textFactura.Text,
                PathAlbaranes = textAlbaranes.Text,
                PathAlbaranes2 = textAlbaranes2.Text,
                PathListados = textListados.Text,
                PathLiquidaciones= textLiquidaciones.Text,
                PathSeguridad = textBoxSeguridad.Text
            };
        }

        private void Rutas_Load(object sender, EventArgs e)
        {
            this.textFactura.Text = RutasSalida.RutaFacturacion;
            this.textAlbaranes.Text = RutasSalida.RutaAlbaranes;
            this.textAlbaranes2.Text = RutasSalida.RutaAlbaranes2;
            this.textLiquidaciones.Text = RutasSalida.RutaLiquidaciones;
            this.textListados.Text = RutasSalida.RutaLiquidaciones;
            this.textBoxSeguridad.Text = RutasSalida.RutaSeguridad;
        }

        private void Rutas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(13))
            {
                e.Handled = true; SendKeys.Send("{TAB}");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog buscar = new FolderBrowserDialog();

            if (buscar.ShowDialog() == DialogResult.OK)
            {
                textBoxSeguridad.Text = buscar.SelectedPath;
            }
        }

        private void buttonExcel_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog buscar = new FolderBrowserDialog();

            if (buscar.ShowDialog() == DialogResult.OK)
            {
                textBoxExcel.Text = buscar.SelectedPath;
            }
        }
    }
}
