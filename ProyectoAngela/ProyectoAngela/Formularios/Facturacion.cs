using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AdministracionAngela.Utils.Extensions;
using AdministracionAngela.Utils.Interfaces;
using AdministracionAngela.Utils.Mappers;
using AdministracionAngela.Utils.Models.Factura;

namespace AdministracionAngela.ProyectoAngela.Formularios
{
    public partial class Facturacion : Form
    {
        int linea = 0;
        private IFacturaProvider facturaProvider;
        /// <summary>
        /// Lo usamos para poder aplicar el filtro inteligente
        /// </summary>
        private List<string> originalClientValues;
        private List<string> originalProductValues;
        int counting = 0;
        private FacturaViewModel viewModel;

        public Facturacion(IFacturaProvider facturaProvider)
        {
            this.facturaProvider = facturaProvider;
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Facturacion_Load(object sender, EventArgs e)
        {
            viewModel = this.facturaProvider.GetFacturaViewModel();
            this.FillControls(viewModel);
        }

        private void button11_Click_2(object sender, EventArgs e)
        {
            linea = 1;
        }

        private void comboBoxClientes_TextUpdate(object sender, EventArgs e)
        {
            comboBoxClientes.FilterByTextIntroduced(originalClientValues);
        }

        private void FillControls(FacturaViewModel viewModel)
        {
            this.originalClientValues = viewModel.ClienteIdsAndDescripciones.Keys.ToList<string>();
            this.originalProductValues = viewModel.ArticuloIdsAndDescripciones.Keys.ToList<string>();
            this.comboBoxClientes.DataSource = originalClientValues;
            this.labelNumeroFactura.Text = viewModel.Id.ToString();
            this.FillIVAs(viewModel.LineasIVA);
        }

        public void FillIVAs(List<LineaIVAViewModel> lineasIVA)
        {
            this.tableLayoutPanel1.Controls.Clear();
            tableLayoutPanel1.Controls.Add(new Label() { Text = "Bases IVA" }, 0, 0);
            tableLayoutPanel1.Controls.Add(new Label() { Text = "% IVA" }, 1, 0);
            tableLayoutPanel1.Controls.Add(new Label() { Text = "IVA" }, 2, 0);
            tableLayoutPanel1.Controls.Add(new Label() { Text = "% RE" }, 3, 0);
            tableLayoutPanel1.Controls.Add(new Label() { Text = "RE" }, 4, 0);

            for (int i = 1; i < lineasIVA.Count + 1; i++)
            {
                var lineaIVA = lineasIVA[i - 1];
                tableLayoutPanel1.Controls.Add(new Label() { Text = lineaIVA.BaseIVA.ToString() }, 0, i);
                tableLayoutPanel1.Controls.Add(new Label() { Text = lineaIVA.PorcentajeIVA.ToString() }, 1, i);
                tableLayoutPanel1.Controls.Add(new Label() { Text = lineaIVA.ImporteIVA.ToString() }, 2, i);
                tableLayoutPanel1.Controls.Add(new Label() { Text = lineaIVA.PorcentajeRecargoEquivalencia.ToString() }, 3, i);
                tableLayoutPanel1.Controls.Add(new Label() { Text = lineaIVA.ImporteRecargoEquivalencia.ToString() }, 4, i);
            }
        }

        private void dataGridViewLineasFactura_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (e.Control.GetType() == typeof(DataGridViewComboBoxEditingControl))
            {
                if (((ComboBox)e.Control).SelectedIndex == 0)
                {
                    ((ComboBox)e.Control).DropDownStyle = ComboBoxStyle.DropDown;
                }

                var combo = e.Control as ComboBox;
                if (combo != null)
                {
                    combo.TextChanged += new EventHandler(ComboInGrid_TextChanged);
                }
            }
        }

        private void ComboInGrid_TextChanged(object sender, EventArgs e)
        {
            var combo = sender as ComboBox;
            combo.TextChanged -= new EventHandler(ComboInGrid_TextChanged);

            (sender as ComboBox).FilterByTextIntroduced(originalProductValues);
            combo.TextChanged += new EventHandler(ComboInGrid_TextChanged);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.dataGridViewLineasFactura.Rows.Add();
            var indexOFLastRow = this.dataGridViewLineasFactura.Rows.Count - 1;

            var cell = this.dataGridViewLineasFactura.Rows[indexOFLastRow].Cells["ColumnProducto"] as DataGridViewComboBoxCell;
            cell.DataSource = originalProductValues;
        }

        private void dataGridViewLineasFactura_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var currentColumnName = this.dataGridViewLineasFactura.CurrentCell.OwningColumn.Name;
            var Ok = this.ValidateCell(currentColumnName);

            if (Ok && (currentColumnName.Equals("ColumnKgs") || currentColumnName.Equals("ColumnPrecio")))
            {
                this.RecalcularImporteDeLinea();
            }
            else if(!Ok)
            {
                this.dataGridViewLineasFactura.CurrentCell.Value = null;
            }

            this.Recalculate();
        }

        private void Recalculate()
        {
            this.viewModel.LineasFactura = MapToViewModel.MapDataGridViewRowsToLineasFacturaViewModel(this.dataGridViewLineasFactura.Rows, this.viewModel.ArticuloIdsAndDescripciones);
            this.facturaProvider.CalculateIVAs(viewModel);
            this.FillIVAs(this.viewModel.LineasIVA);
            this.UpdateTotals();
        }

        private void UpdateTotals()
        {
            this.labelTotalBase.Text = this.viewModel.TotalBase.ToString();
            this.labelTotalIVA.Text = this.viewModel.TotalIVA.ToString();
            this.labelTotalRE.Text = this.viewModel.TotalRecargoEquivalencia.ToString();
            this.labelTotal.Text = this.viewModel.Total.ToString();
        }

        /// <summary>
        /// Recalcula el importe de la linea (Importe = Kgs * Precio)
        /// </summary>
        private void RecalcularImporteDeLinea()
        {
            var cellKgs = this.dataGridViewLineasFactura.CurrentRow.Cells["ColumnKgs"];
            var cellPrecio = this.dataGridViewLineasFactura.CurrentRow.Cells["ColumnPrecio"];

            if (cellKgs.Value != null && cellPrecio.Value != null)
            {
                var kgs = Convert.ToDecimal(cellKgs.Value);
                var precio = Convert.ToDecimal(cellPrecio.Value);
                var importe = kgs * precio;

                this.dataGridViewLineasFactura.CurrentRow.Cells["ColumnImporte"].Value = Decimal.Round(importe, 2);
            }
        }

        /// <summary>
        /// Valida la celda que se acaba de terminar de editar
        /// </summary>
        /// <param name="currentColumnName"></param>
        /// <returns></returns>
        private bool ValidateCell(string currentColumnName)
        {
            bool Ok = false;
            var currentCell = this.dataGridViewLineasFactura.CurrentCell;

            if (currentCell.Value != null)
            {
                switch (currentColumnName)
                {
                    case "ColumnKgs":
                    case "ColumnPrecio":
                        {
                            if (currentCell.Value.ToString().IsDecimal())
                            {
                                Ok = true;
                                //reemplaza puntos por comas para que el convert to decimal funcione y no tengamos que obligar al usuario a usar comas
                                var valueFormatted = currentCell.Value.ToString().Replace('.', ',');
                                var decimalValue = Convert.ToDecimal(valueFormatted);

                                currentCell.Value = Decimal.Round(decimalValue, 2);
                            }
                            break;
                        }

                    case "ColumnProducto":
                        {
                            Ok = true;
                            break;
                        }
                }
            }

            return Ok;
        }
    }
}
