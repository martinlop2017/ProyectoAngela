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
        private string title;

        public AltaLineaFactura(List<string> products, string title)
        {
            this.title = title;
            this.Products = products;
            InitializeComponent();
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            if (Validate())
            {
                var precio = decimal.Parse(this.textBoxPrecio.Text.Replace(".", ","));
                var kgs = decimal.Parse(this.textBoxKgs.Text.Replace(".", ","));
                this.lineaFactura = new LineaFacturaViewModel()
                {
                    Cajas = int.Parse(this.textBoxCajas.Text),
                    Kgs = kgs,
                    Precio = precio,
                    SelectedProduct = comboBoxProducto.Text,
                    Importe = Decimal.Round(kgs * precio, 2),
                    Lote = this.textBoxLote.Text
                };

                this.DialogResult = DialogResult.OK;
                this.Close();
            }

        }
        private bool Validate()
        {
            return
                string.IsNullOrEmpty(this.validationProvider1.ValidationMessages(!this.validationProvider1.Validate()));
        }
        private void AltaLineaFactura_Load(object sender, EventArgs e)
        {
            this.labelTitle.Text = title;
            this.comboBoxProducto.DataSource = this.Products;
            this.textBoxLote.Text = DateTime.Today.ToString("ddMMyyyy");
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
            var precio = this.textBoxPrecio.Text.Replace(".", ",");
            var kgs = this.textBoxKgs.Text.Replace(".", ",");

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

        private void AltaLineaFactura_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(13))
            {
                e.Handled = true; SendKeys.Send("{TAB}");
            }
        }
    }
}
