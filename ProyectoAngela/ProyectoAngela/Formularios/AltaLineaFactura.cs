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
            this.lineaFactura = new LineaFacturaViewModel()
            {
                Cajas = int.Parse(this.textBoxCajas.Text),
                Importe = decimal.Parse(this.textBoxImporte.Text),
                Kgs = decimal.Parse(this.textBoxKgs.Text),
                Precio = decimal.Parse(this.textBoxPrecio.Text),
                SelectedProduct = comboBoxProducto.Text
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
                this.labelCodigo.Text = codigo;
            }
        }
    }
}
