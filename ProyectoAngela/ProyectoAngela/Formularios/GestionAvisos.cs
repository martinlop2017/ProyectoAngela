using AdministracionAngela.Utils.Interfaces;
using AdministracionAngela.Utils.Models.Avisos;
using AdministracionAngela.Utils.Models.Impresion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace AdministracionAngela.ProyectoAngela.Formularios
{
    public partial class GestionAvisos : Form
    {
        private IFacturaProvider facturaProvider;
        private BindingList<AvisoViewModel> avisos;

        public GestionAvisos(IFacturaProvider facturaProvider)
        {
            this.facturaProvider = facturaProvider;
            this.avisos = new BindingList<AvisoViewModel>();
            InitializeComponent();
        }

  

        private void button5_MouseEnter(object sender, EventArgs e)
        {
            label5.Visible = true;
        }

        private void button5_MouseLeave(object sender, EventArgs e)
        {
            label5.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void GestionAvisos_Load(object sender, EventArgs e)
        {
        // /   dateTimePickerFromFecha.Text = DateTime.Now.ToString("dd/mm/aaaa");
        //    dateTimePickerToFecha.Text = DateTime.Now.ToString("dd/mm/aaaa");
            //var viewModel = facturaProvider.GetGestionFacturasVencidas();
            this.dataGridViewAvisos.DataSource = new BindingList<AvisoViewModel>();
            this.avisos = new BindingList<AvisoViewModel>();
            // INICA A LA FECHA ACTUAL LOS SELECTORESS DE FECHAS
            dateTimePickerFromFecha.Value = DateTime.Now;
            dateTimePickerToFecha.Value = DateTime.Now;



        }

        private void dataGridViewAvisos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dataGridViewAvisos.CurrentCell.OwningColumn.Name.Equals("ColumnCobrada"))
            {
                var selectedRow = this.dataGridViewAvisos.SelectedRows[0];
                selectedRow.Cells["ColumnCobrada"].Value = !(bool)selectedRow.Cells["ColumnCobrada"].Value;
                var cobrada = (bool)(selectedRow.Cells["ColumnCobrada"] as DataGridViewCheckBoxCell).Value;
                var codigoFactura = selectedRow.Cells["ColumnCodigoFactura"].Value;

                var fechaCobroSeleccionada = selectedRow.Cells["ColumnCobro"].Value.ToString();
                DateTime fechaCobro = DateTime.Today;

                if (ValidarFecha(fechaCobroSeleccionada))
                {
                    DateTime.TryParse(fechaCobroSeleccionada, out fechaCobro);
                }

                this.facturaProvider.SetFacturaCobrada((long)codigoFactura, cobrada, fechaCobro);

                if(cobrada)
                {
                    selectedRow.Cells["ColumnCobro"].Value = fechaCobro.ToString("dd/MM/yyyy");
                }
                else
                {
                    selectedRow.Cells["ColumnCobro"].Value = string.Empty;
                }
            }
        }

        private bool ValidarFecha(string fecha)
        {
            var valida = false;

            try
            {
                DateTime.Parse(fecha);
            }
            catch(Exception exp)
            {
                return false;
            }

            if (!string.IsNullOrEmpty(fecha))
            {
                valida = true;
            }

            return valida;
        }

        private void textBoxBusqueda_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void botonfiltrar_Click(object sender, EventArgs e)
        {
            var fromCode = long.Parse(this.textBoxFromCodigo.Text);
            var toCode = long.Parse(this.textBoxToCodigo.Text);
            var fromDate = this.dateTimePickerFromFecha.Value.Date;
            var toDate = this.dateTimePickerToFecha.Value.Date.AddDays(1).AddSeconds(-1);
            var checkForPendientes = this.checkBoxPendientes.Checked;
            var checkForCobradas = this.checkBoxCobradas.Checked;

            var viewModel = facturaProvider.GetGestionFacturasVencidas(fromCode, toCode, fromDate, toDate, checkForPendientes, checkForCobradas);
            this.dataGridViewAvisos.DataSource = viewModel.Avisos;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var listaMorososParaImprimir = new List<Moroso>();
            foreach (DataGridViewRow row in dataGridViewAvisos.Rows)
            {
                var moroso = new Moroso();
                moroso.desdecliente = textBoxFromCodigo.Text;
                moroso.hastacliente = textBoxToCodigo.Text;
                moroso.CodigoFactura = Convert.ToString(row.Cells["ColumnCodigoFactura"].Value);
                moroso.FechaFactura = Convert.ToString(row.Cells["ColumnFecha"].Value);
                moroso.FechaCobro = Convert.ToString(row.Cells["ColumnCobro"].Value);
                moroso.FechaVencimiento = Convert.ToString(row.Cells["ColumnVencimiento"].Value);
                moroso.Importe = Convert.ToDecimal(row.Cells["ColumnImporte"].Value);
                moroso.NombreCliente = Convert.ToString(row.Cells["ColumnCliente"].Value);
                moroso.Cobrada = Convert.ToBoolean(row.Cells["ColumnCobrada"].Value);
                moroso.Base = Convert.ToDecimal(row.Cells["ColumnBase"].Value);
                moroso.Iva = Convert.ToDecimal(row.Cells["ColumnIva"].Value);
                moroso.RE = Convert.ToDecimal(row.Cells["ColumnRE"].Value);

                listaMorososParaImprimir.Add(moroso);
            }

            if(listaMorososParaImprimir.Count > 0)
            {
                VisorMororsos form = new VisorMororsos();
                form.ExportarToPdf(listaMorososParaImprimir);
            }
        }

        private void dataGridViewAvisos_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if(this.dataGridViewAvisos.Columns[e.ColumnIndex].Name == "ColumnCobro")
            {
                var selectedRow = this.dataGridViewAvisos.Rows[e.RowIndex];
                var codigoFactura = (long)selectedRow.Cells["ColumnCodigoFactura"].Value;
                var fechaCobroSeleccionada = selectedRow.Cells["ColumnCobro"].Value.ToString();
                DateTime fechaCobro = DateTime.Today;

                if (ValidarFecha(fechaCobroSeleccionada))
                {
                    DateTime.TryParse(fechaCobroSeleccionada, out fechaCobro);
                }

                this.facturaProvider.SetFechaCobro(codigoFactura, fechaCobro);
            }
        }
    }
}
