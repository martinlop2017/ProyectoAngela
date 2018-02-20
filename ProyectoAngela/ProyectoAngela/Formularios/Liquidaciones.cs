using AdministracionAngela.Utils.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AdministracionAngela.Utils.Models.Liquidaciones;

namespace AdministracionAngela.ProyectoAngela.Formularios
{
    public partial class Liquidaciones : Form
    {
        IFacturaProvider facturaProvider;

        public Liquidaciones(IFacturaProvider facturaProvider)
        {
            this.facturaProvider = facturaProvider;
            InitializeComponent();
        }

        private void Liquidaciones_Load(object sender, EventArgs e)
        {
            dateTimePickerStart.Value = DateTime.Now;
            dateTimePickerEnd.Value = DateTime.Now;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void buttonEjecutar_Click(object sender, EventArgs e)
        {
            var startDate = this.dateTimePickerStart.Value;
            var endDate = this.dateTimePickerEnd.Value;

            if(startDate > endDate)
            {
                MessageBox.Show("Las fechas introducidas son incorrectas.");
            }
            else
            {
                var viewModel = this.facturaProvider.GetLiquidacionesParaFechas(startDate, endDate);
                this.FillForm(viewModel);
            }
        }

        private void FillForm(LiquidacionesViewModel viewModel)
        {
            this.labelTotalLiquidaciones.Text = viewModel.Total.ToString();
            this.dataGridViewLiquidaciones.AutoGenerateColumns = false;
            this.dataGridViewLiquidaciones.DataSource = viewModel.LineasLiquidacion;
        }

        private void dataGridViewLiquidaciones_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            var columnName = dataGridViewLiquidaciones.Columns[e.ColumnIndex].Name;
            if (e.RowIndex != -1 && columnName.Equals("ColumnPrecioMedio"))
            {
                var changedRow = this.dataGridViewLiquidaciones.Rows[e.RowIndex];
                var rowTotal = this.RecalcularTotalRow(changedRow);
                changedRow.Cells["ColumnTotal"].Value = rowTotal.ToString();

                var total = this.RecalcularTotal();
                this.labelTotalLiquidaciones.Text = total.ToString();
            }
        }

        private decimal RecalcularTotal()
        {
            decimal total = 0;
            for(int i = 0; i < this.dataGridViewLiquidaciones.Rows.Count; i++)
            {
                var row = this.dataGridViewLiquidaciones.Rows[i];
                var rowTotal = decimal.Parse(row.Cells["ColumnTotal"].Value.ToString());
                total += rowTotal;
            }

            return decimal.Round(total, 2);
        }

        private decimal RecalcularTotalRow(DataGridViewRow changedRow)
        {
            var kilos = decimal.Parse(changedRow.Cells["ColumnKilos"].Value.ToString());
            var precioMedio = decimal.Parse(changedRow.Cells["ColumnPrecioMedio"].Value.ToString());

            return kilos * precioMedio;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            List<ClaseLiquidacion > lista = new List<ClaseLiquidacion>();



            foreach (DataGridViewRow row in dataGridViewLiquidaciones.Rows)

            {
                ClaseLiquidacion datosalistar = new ClaseLiquidacion();

                //      datosalistar.liqemisor = 
                datosalistar.liqdefecha = dateTimePickerStart.Text;
                datosalistar.liqdafecha = dateTimePickerEnd.Text;
                datosalistar.liqtotalliquidacion = labelTotalLiquidaciones.Text;
                datosalistar.liqarticulo = Convert.ToString(row.Cells["ColumnConcepto"].Value);
                datosalistar.liqbultos = Convert.ToString(row.Cells["ColumnBultos"].Value);
                datosalistar.liqkilos = Convert.ToString(row.Cells["ColumnKilos"].Value);
                datosalistar.liqmedio = Convert.ToString(row.Cells["ColumnPrecioMedio"].Value);
                datosalistar.liqtotal = Convert.ToString(row.Cells["ColumnTotal"].Value);



                lista.Add(datosalistar);

            }

            var form = new ReportViewerLiquidaciones(lista);
            form.ShowDialog();
        }
    }
}
