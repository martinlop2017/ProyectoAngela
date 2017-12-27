using AdministracionAngela.Utils.Extensions;
using AdministracionAngela.Utils.Models.Factura;
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
    public partial class AltaLineaFactura : Form
    {
        public LineaFacturaViewModel lineaFactura { get; set; }
        public List<string> Products { get; set; }

        public AltaLineaFactura(List<string> products)
        {
            this.Products = products;
            InitializeComponent();
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            var precio = decimal.Parse(this.textBoxPrecio.Text);
            var kgs = decimal.Parse(this.textBoxKgs.Text);
            this.lineaFactura = new LineaFacturaViewModel()
            {
                Cajas = int.Parse(this.textBoxCajas.Text),
                Kgs = kgs,
                Precio = precio,
                SelectedProduct = comboBoxProducto.Text,
                Importe = kgs * precio
            };

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void AltaLineaFactura_Load(object sender, EventArgs e)
        {
            this.comboBoxProducto.DataSource = this.Products;
        }

        private void comboBoxProducto_TextUpdate(object sender, EventArgs e)
        {
            this.comboBoxProducto.FilterByTextIntroduced(Products);
        }

        private void comboBoxProducto_SelectedValueChanged(object sender, EventArgs e)
        {
            var text = this.comboBoxProducto.Text;
            if(!string.IsNullOrEmpty(text))
            {
                var codigo = text.Substring(0, text.IndexOf(' '));
                this.textBoxCodigo.Text = codigo;
            }
        }

        private void textBoxKgs_TextChanged(object sender, EventArgs e)
        {
            RecalculateImporte();
        }

        private void textBoxPrecio_TextChanged(object sender, EventArgs e)
        {
            RecalculateImporte();
        }

        private void RecalculateImporte()
        {
            var precio = this.textBoxPrecio.Text;
            var kgs = this.textBoxKgs.Text;

            if (!string.IsNullOrEmpty(precio) && !string.IsNullOrEmpty(kgs) && precio.IsDecimal() && kgs.IsDecimal())
            {
                var decimalPrecio = decimal.Parse(precio);
                var decimalKgs = decimal.Parse(kgs);

                var importe = decimal.Round(decimalPrecio * decimalKgs, 2);
                this.labelTotal.Text = importe.ToString();
            }
        }

        private void comboBoxProducto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
