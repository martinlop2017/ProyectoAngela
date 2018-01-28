using AdministracionAngela.Utils.Extensions;
using AdministracionAngela.Utils.Interfaces;
using AdministracionAngela.Utils.Mappers;
using AdministracionAngela.Utils.Models.Albaran;
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
    public partial class Albaranes : Form
    {
        int linea = 0;
        private IFacturaProvider facturaProvider;
        /// <summary>
        /// Lo usamos para poder aplicar el filtro inteligente
        /// </summary>
        private List<string> originalClientValues;
        private List<string> originalProductValues;
        private AltaAlbaranViewModel viewModel;
        private bool isUpdate = false;
        private long AlbaranId;
        private bool IsAlbaran = true;

        public Albaranes(IFacturaProvider facturaProvider)
        {
            this.facturaProvider = facturaProvider;
            InitializeComponent();
        }

        public void IsUpdate(long albaranId, bool isAlbaran)
        {
            this.IsAlbaran = IsAlbaran;
            this.isUpdate = true;
            this.AlbaranId= albaranId;
        }

        private void Albaranes_Load(object sender, EventArgs e)
        {
            if (!this.isUpdate)
            {
                viewModel = this.facturaProvider.GetAlbaranViewModel();
            }
            else
            {
                viewModel = this.facturaProvider.GetAlbaranViewModelById(this.AlbaranId, IsAlbaran);
            }

            this.FillControls(viewModel);
        }

        private void FillControls(AltaAlbaranViewModel viewModel)
        {
            try
            {
                this.originalClientValues = viewModel.ClienteIdsAndDescripciones.Keys.ToList<string>();
                this.originalProductValues = viewModel.ArticuloIdsAndDescripciones.Keys.ToList<string>();
                this.comboBoxClientes.DataSource = originalClientValues;
                this.labelNumeroFactura.Text = viewModel.Id.ToString();
                this.textBoxLote.Text = viewModel.Lote;
                this.FillIVAs(viewModel.LineasIVA);

                if (this.isUpdate)
                {
                    this.comboBoxClientes.Text = viewModel.SelectedClient;
                    foreach (var lineaAlbaran in viewModel.LineasAlbaran)
                    {
                        this.dataGridViewLineasFactura.Rows.Add();
                        var indexOFLastRow = this.dataGridViewLineasFactura.Rows.Count - 1;

                        var codigoArticulo = lineaAlbaran.SelectedProduct.Substring(0, lineaAlbaran.SelectedProduct.IndexOf("-")).Trim();

                        this.dataGridViewLineasFactura.Rows[indexOFLastRow].Cells["ColumnProducto"].Value = lineaAlbaran.SelectedProduct;
                        this.dataGridViewLineasFactura.Rows[indexOFLastRow].Cells["ColumnCodigo"].Value = codigoArticulo;
                        this.dataGridViewLineasFactura.Rows[indexOFLastRow].Cells["ColumnCajas"].Value = lineaAlbaran.Cajas;
                        this.dataGridViewLineasFactura.Rows[indexOFLastRow].Cells["ColumnKgs"].Value = lineaAlbaran.Kgs;
                        this.dataGridViewLineasFactura.Rows[indexOFLastRow].Cells["ColumnPrecio"].Value = lineaAlbaran.Precio;
                        this.dataGridViewLineasFactura.Rows[indexOFLastRow].Cells["ColumnImporte"].Value = lineaAlbaran.Importe;
                    }

                    this.Recalculate();
                }
            }
            catch (Exception exp)
            {

            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBoxClientes_TextUpdate(object sender, EventArgs e)
        {
            comboBoxClientes.FilterByTextIntroduced(originalClientValues);
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

        private void UpdateIVAs(List<LineaIVAViewModel> lineasIVA)
        {
            for (int i = 0; i < lineasIVA.Count; i++)
            {
                var lineaIVA = lineasIVA[i];

                (tableLayoutPanel1.GetControlFromPosition(0, i + 1) as Label).Text = lineaIVA.BaseIVA.ToString();
                (tableLayoutPanel1.GetControlFromPosition(1, i + 1) as Label).Text = lineaIVA.PorcentajeIVA.ToString();
                (tableLayoutPanel1.GetControlFromPosition(2, i + 1) as Label).Text = lineaIVA.ImporteIVA.ToString();
                (tableLayoutPanel1.GetControlFromPosition(3, i + 1) as Label).Text = lineaIVA.PorcentajeRecargoEquivalencia.ToString();
                (tableLayoutPanel1.GetControlFromPosition(4, i + 1) as Label).Text = lineaIVA.ImporteRecargoEquivalencia.ToString();
            }
        }

        private void buttonAñadirLinea_Click(object sender, EventArgs e)
        {
            NuevaLineaFactura();
        }

        private void NuevaLineaFactura()
        {
            using (var form = new AltaLineaFactura(this.originalProductValues, "Linea de Albaran"))
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    var lineaFactura = form.lineaFactura;
                    lineaFactura.ProductoId = this.viewModel.ArticuloIdsAndDescripciones[lineaFactura.SelectedProduct];
                    this.AddLineaFActura(lineaFactura);
                }
            }
        }

        private void dataGridViewLineasFactura_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var currentColumnName = this.dataGridViewLineasFactura.CurrentCell.OwningColumn.Name;
            var Ok = this.ValidateCell(currentColumnName);

            if (Ok && (currentColumnName.Equals("ColumnKgs") || currentColumnName.Equals("ColumnPrecio")))
            {
                this.RecalcularImporteDeLinea();
            }
            else if (!Ok)
            {
                this.dataGridViewLineasFactura.CurrentCell.Value = null;
            }

            this.Recalculate();
        }

        private void Recalculate()
        {
            this.viewModel.LineasAlbaran = MapToViewModel.MapDataGridViewRowsToLineasAlbaranViewModel(this.dataGridViewLineasFactura.Rows, this.viewModel.ArticuloIdsAndDescripciones);
            this.facturaProvider.CalculateIVAs(viewModel);
            this.UpdateIVAs(this.viewModel.LineasIVA);
            this.UpdateTotals();
        }

        private void UpdateTotals()
        {
            this.labelTotalBase.Text = this.viewModel.TotalBase.ToString();
            this.labelTotalIVA.Text = this.viewModel.TotalIVA.ToString();
            this.labelTotalRE.Text = this.viewModel.TotalRecargoEquivalencia.ToString();
            this.labelTotal.Text = this.viewModel.Total.ToString();
            this.labelTotalCajas.Text = this.viewModel.TotalCajas.ToString();
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
                    case "ColumnCajas":
                        {
                            if (currentCell.Value.ToString().IsInt())
                            {
                                Ok = true;
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

        private void buttonSave_Click(object sender, EventArgs e)
        {
            ReadGenericDataFromForm();
            if (this.isUpdate)
            {
                this.facturaProvider.UpdateAlbaran(this.viewModel);
            }
            else
            {
                this.facturaProvider.SaveAlbaran(this.viewModel);
            }

            this.Close();
        }

        /// <summary>
        /// Reads numeroFactura, Cliente and Fecha (LineasFactura, LineasIVA y Totales son calculados conforme se rellenan las lineas de factura)
        /// </summary>
        private void ReadGenericDataFromForm()
        {
            this.viewModel.Id = Convert.ToInt32(this.labelNumeroFactura.Text);
            this.viewModel.SelectedClient = this.comboBoxClientes.Text;
            this.viewModel.Fecha = this.dateTimePickerFecha.Value.ToString();
            this.viewModel.Lote = this.textBoxLote.Text;
            this.viewModel.IsAlbaran = this.IsAlbaran;
        }

        private void buttonEliminarLinea_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridViewLineasFactura.SelectedRows)
            {
                if (!row.IsNewRow)
                {
                    this.dataGridViewLineasFactura.Rows.Remove(row);
                }
            }

            this.Recalculate();
        }

        private void dataGridViewLineasFactura_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (this.dataGridViewLineasFactura.CurrentCell.ColumnIndex == this.dataGridViewLineasFactura.Columns.Count - 1 && e.KeyChar.ToString().Equals("+"))
            {
                this.AddNewLineaFactura();
            }
        }

        private void AddLineaFActura(LineaFacturaViewModel lineaFactura)
        {
            this.dataGridViewLineasFactura.Rows.Add(lineaFactura.SelectedProduct, lineaFactura.ProductoId, lineaFactura.Cajas, lineaFactura.Kgs, lineaFactura.Precio, lineaFactura.Importe);
            this.Recalculate();
        }
        private void AddNewLineaFactura()
        {
            this.dataGridViewLineasFactura.Rows.Add();
        }

        private void Albaranes_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString().Equals("+"))
            {
                this.NuevaLineaFactura();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.IsAlbaran = false;
        }
    }
}
