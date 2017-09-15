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
        int counting = 0;

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
            var viewModel = this.facturaProvider.GetFacturaViewModel();
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
            this.comboBoxClientes.DataSource = originalClientValues;
            this.labelNumeroFactura.Text = viewModel.Id.ToString();
            this.FillIVAs(viewModel.LineasIVA);

            
        }

        public void FillIVAs(List<LineaIVAViewModel> lineasIVA)
        {
            tableLayoutPanel1.Controls.Add(new Label() { Text = "Bases IVA" }, 0, 0);
            tableLayoutPanel1.Controls.Add(new Label() { Text = "% IVA" }, 1, 0);
            tableLayoutPanel1.Controls.Add(new Label() { Text = "IVA" }, 2, 0);
            tableLayoutPanel1.Controls.Add(new Label() { Text = "% RE" }, 3, 0);
            tableLayoutPanel1.Controls.Add(new Label() { Text = "RE" }, 4, 0);

            for (int i = 1; i < lineasIVA.Count + 1; i++)
            {
                var lineaIVA = lineasIVA[i - 1];
                tableLayoutPanel1.Controls.Add(new Label() { Text = "99" }, 0, i);
                tableLayoutPanel1.Controls.Add(new Label() { Text = lineaIVA.PorcentajeIVA.ToString() }, 1, i);
                tableLayoutPanel1.Controls.Add(new Label() { Text = "99" }, 2, i);
                tableLayoutPanel1.Controls.Add(new Label() { Text = "99" }, 3, i);
                tableLayoutPanel1.Controls.Add(new Label() { Text = "99" }, 4, i);
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridViewLineasFactura_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
        //    DataGridView dataGridView = sender as DataGridView;
        //    if (dataGridView == null || dataGridView.CurrentCell.ColumnIndex != 0) return;
        //    var dataGridViewComboBoxCell = dataGridView.CurrentCell as DataGridViewComboBoxCell;
        //    if (dataGridViewComboBoxCell != null)
        //    {
        //            //Here we move focus to second cell of current row
        //            dataGridView.CurrentCell = dataGridView.Rows[dataGridView.CurrentCell.RowIndex].Cells[1];
        //            //Return focus to Combobox cell
        //            dataGridView.CurrentCell = dataGridView.Rows[dataGridView.CurrentCell.RowIndex].Cells[0];
        //            //Initiate Edit mode
        //            dataGridView.BeginEdit(true);
        //            return;
        //    }
        //    dataGridView.CurrentCell = dataGridView.Rows[dataGridView.CurrentCell.RowIndex].Cells[1];
        //    dataGridView.BeginEdit(true);
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
                if(combo != null)
                {
                    combo.TextChanged += new EventHandler(ComboInGrid_TextChanged);
                }
            }
        }

        private void ComboInGrid_TextChanged(object sender, EventArgs e)
        {
            var combo = sender as ComboBox;
            combo.TextChanged -= new EventHandler(ComboInGrid_TextChanged);

            (sender as ComboBox).FilterByTextIntroduced(originalClientValues);
            combo.TextChanged += new EventHandler(ComboInGrid_TextChanged);
        }

        private void dataGridViewLineasFactura_CurrentCellChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.dataGridViewLineasFactura.Rows.Add();
            var indexOFLastRow = this.dataGridViewLineasFactura.Rows.Count - 1;

            var cell = this.dataGridViewLineasFactura.Rows[indexOFLastRow].Cells["ColumnProducto"] as DataGridViewComboBoxCell;
            cell.DataSource = originalClientValues;
        }

        private void dataGridViewLineasFactura_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var columnName = this.dataGridViewLineasFactura.CurrentCell.OwningColumn.Name;

            if (columnName.Equals("ColumnKgs") || columnName.Equals("ColumnPrecio"))
            {
                this.RecalcularImporteDeLinea();
            }
        }

        private void RecalcularImporteDeLinea()
        {
            if (this.ValidateCells())
            {
                var cellKgs = this.dataGridViewLineasFactura.CurrentRow.Cells["ColumnKgs"];
                var cellPrecio = this.dataGridViewLineasFactura.CurrentRow.Cells["ColumnPrecio"];

                if (cellKgs.Value != null && cellPrecio.Value != null)
                {
                    this.dataGridViewLineasFactura.CurrentRow.Cells["ColumnImporte"].Value = Convert.ToInt32(cellKgs.Value) * Convert.ToInt32(cellPrecio.Value);
                }
            }
            else
            {
                this.dataGridViewLineasFactura.CurrentCell.Value = null;
                this.dataGridViewLineasFactura.CurrentRow.Cells["ColumnImporte"].Value = null;
            }
        }

        private bool ValidateCells()
        {
            bool Ok = false;

            var currentCell = this.dataGridViewLineasFactura.CurrentCell;
            if (currentCell.Value != null && currentCell.Value.ToString().IsInt())
            {
                Ok = true;
            }

            return Ok;
        }
    }
}
