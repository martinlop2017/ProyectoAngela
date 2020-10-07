using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using AdministracionAngela.Utils.Interfaces;
using AdministracionAngela.Utils.Models.Factura;
using AdministracionAngela.Utils.Extensions;
using AdministracionAngela.Utils.Enumerados;
using System.ComponentModel;
using AdministracionAngela.Utils.Genericos;
using System.Collections.Generic;
using System.Reflection;
using AdministracionAngela.Utils.Models.Exports;
using System.Globalization;

namespace AdministracionAngela.ProyectoAngela.Formularios
{
    public partial class GestionFacturas : Form
    {
        private IFormOpener formOpener;
        private IDocumentoGestion documentoGestion;
        private bool IsDocumento = true;
        private BindingList<FacturaViewModel> documentos;

        public GestionFacturas(IFormOpener formOpener, IDocumentoGestion documentoGestion)
        {
            this.formOpener = formOpener;
            this.documentoGestion = documentoGestion;
            InitializeComponent();
            this.labelTitulo.Text = this.documentoGestion.GetTitulo();
            this.pictureBox1.Visible = this.documentoGestion.CanBeDocumento();
            this.buttonFacturar.Visible = this.documentoGestion.PuedeFacturar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var typeDocumento = this.documentoGestion.GetTipoDocumento();
            if(typeDocumento == EnumDocumentosGestion.Albaran)
            {
                var formAltaAlbaran = this.formOpener.GetForm<Albaranes>() as Albaranes;
                formAltaAlbaran.SetIsAlbaran(IsDocumento);
                formAltaAlbaran.ShowDialog();
            }
            else
            {
                this.formOpener.ShowModalForm<Facturacion>();
            }

            this.FillControls();
        }

        private void button6_MouseEnter(object sender, EventArgs e)
        {
            label7.Visible = true;
        }

        private void button6_MouseLeave(object sender, EventArgs e)
        {
            label7.Visible = false;
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            label1.Visible = true;
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            label2.Visible = true;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            label2.Visible = false;
        }

        private void button3_MouseEnter(object sender, EventArgs e)
        {
            label3.Visible = true;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            label3.Visible = false;
        }

        private void button4_MouseEnter(object sender, EventArgs e)
        {
            label4.Visible = true;
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            label4.Visible = false;
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

        private void GestionFacturas_Load(object sender, EventArgs e)
        {
            if(NivelUsuario.Nivel.Equals("Usuario"))
            {
                buttonBorrar.Visible = false;
                buttonModificar.Visible = false;
                buttonImprimir.Visible = false;
                buttonFacturar.Visible = false;
            }
            this.FillControls();
            var typeDocumento = this.documentoGestion.GetTipoDocumento();
            if (typeDocumento == EnumDocumentosGestion.Factura)
            {
                panel1.Width = 470;
                panel1.Location = new Point(310, 120);
                label4.Location = new Point(374, 104);
                //comboBoxClientes.Width = 505;
            }

            if (typeDocumento == EnumDocumentosGestion.Albaran)
            {
                this.Text = "Gestion de Albaranes.";
            }
        }
        private void buttonBorrar_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Va a proceder a eliminar el registro seleccionado.\n                     Desea Eliminar el registro?"
                                 , "Eliminar Registro.", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes) ;
            {

                var selectedRow = this.dataGridViewFacturas.SelectedRows;
                var mappedSelectedRows = selectedRow.ToList<FacturaViewModel>();

                this.documentoGestion.DeleteDocumentos(mappedSelectedRows);
                this.FillControls();

            }
        }

        private void FillControls()
        {
            var viewModel = this.documentoGestion.GetDocumentos(IsDocumento);
            this.dataGridViewFacturas.DataSource = viewModel.Facturas;
            this.documentos = viewModel.Facturas;
            if(!this.documentoGestion.PuedeFacturar())
            {
                this.dataGridViewFacturas.Columns["ColumnFacturado"].Visible = false;
                this.dataGridViewFacturas.Columns["ColumnCobrado"].Visible = false;
            }
            this.dataGridViewFacturas.Columns["ColumnCobrado"].Visible = !IsDocumento;
            this.dataGridViewFacturas.Columns["ColumnFecha"].Visible = false;
        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            var selectedRows = this.dataGridViewFacturas.SelectedRows;
            if (selectedRows.Count > 1)
                MessageBox.Show("Debe seleccionar una única factura");
            else if (selectedRows.Count < 1)
                MessageBox.Show("Debe seleccionar una factura");
            else
            {
                var selectedFactura = (FacturaViewModel)selectedRows[0].DataBoundItem;
                this.OpenFormToModify(selectedFactura);
            }
            this.FillControls();
        }

        private void OpenFormToModify(FacturaViewModel selectedFactura)
        {
            var typeDocumento = this.documentoGestion.GetTipoDocumento();
            if(typeDocumento == EnumDocumentosGestion.Factura)
            {
                var formAltaCliente = this.formOpener.GetForm<Facturacion>() as Facturacion;
                formAltaCliente.IsUpdate(selectedFactura.Codigo);
                formAltaCliente.ShowDialog();
            }
            else
            {
                var formAltaCliente = this.formOpener.GetForm<Albaranes>() as Albaranes;
                formAltaCliente.IsUpdate(selectedFactura.Codigo, IsDocumento);
                formAltaCliente.ShowDialog();
            }

            this.FillControls();
        }

        private void buttonImprimir_Click(object sender, EventArgs e)
        {
            var selectedRow = this.dataGridViewFacturas.SelectedRows;
            var mappedSelectedRows = selectedRow.ToList<FacturaViewModel>();
            var selectedDocumentosIds = mappedSelectedRows.Select(f => f.Codigo).ToList();

            var reportImpresion = this.documentoGestion.GetReportImpresion(IsDocumento);
            var variableImpresion = this.documentoGestion.GetVariableImpresion();

            var formImprimir = new ImprimirFacturas( this.formOpener, this.documentoGestion, selectedDocumentosIds.First(), reportImpresion, variableImpresion, IsDocumento);
            formImprimir.ShowDialog();
            
            this.FillControls();
        }

        private void buttonFacturar_Click(object sender, EventArgs e)
        {
            var selectedRow = this.dataGridViewFacturas.SelectedRows;
            var mappedSelectedRows = selectedRow.ToList<FacturaViewModel>();
            var selectedDocumentosIds = mappedSelectedRows.Select(f => f.Codigo).ToList();
            this.documentoGestion.Facturar(selectedDocumentosIds);

            FillControls();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.IsDocumento = !this.IsDocumento;
            this.dataGridViewFacturas.BackgroundColor = this.IsDocumento ? Color.White : Color.LemonChiffon;
            this.dataGridViewFacturas.RowHeadersDefaultCellStyle .BackColor = this.IsDocumento ? Color.White : Color.Yellow;
            this.dataGridViewFacturas.RowTemplate.DefaultCellStyle.BackColor = this.IsDocumento ? Color.White : Color.LemonChiffon;
    
            
            this.FillControls();
        }

        private void buttonFacturar_MouseEnter(object sender, EventArgs e)
        {
            labelFacturar.Visible = true;
        }

        private void buttonFacturar_MouseLeave(object sender, EventArgs e)
        {
            labelFacturar.Visible = false;
        }

        private void dataGridViewFacturas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dataGridViewFacturas.CurrentCell.OwningColumn.Name.Equals("ColumnCobrado"))
            {
                var selectedRow = this.dataGridViewFacturas.SelectedRows[0];
                selectedRow.Cells[8].Value = !(bool)selectedRow.Cells[8].Value;
                var value = (bool)(selectedRow.Cells[8] as DataGridViewCheckBoxCell).Value;
                var num = (long)selectedRow.Cells[0].Value;

                documentoGestion.SetCobrado((int)num, value);
            }
        }

        private void panel1_MouseEnter(object sender, EventArgs e)
        {
            label4.Visible = true;
        }

        private void panel1_MouseLeave(object sender, EventArgs e)
        {
            label4.Visible = false;
        }

        private void comboBoxClientes_MouseEnter(object sender, EventArgs e)
        {
            label4.Visible = true;
        }

        private void comboBoxClientes_MouseLeave(object sender, EventArgs e)
        {
            label4.Visible = false;
        }

        private void buttonAñadir_MouseLeave(object sender, EventArgs e)
        {
            label1.Visible = false;
        }

        private void textBoxBusqueda_TextChanged(object sender, EventArgs e)
        {
            if(comboBoxBusqueda.Text.Equals("Numero"))
            {
                dataGridViewFacturas.DataSource = documentos.Where(x => x.Codigo.ToString().Contains(textBoxBusqueda.Text)).ToList();
            }

            if (comboBoxBusqueda.Text.Equals("Cliente"))
            {
                dataGridViewFacturas.DataSource = documentos.Where(x => x.Cliente.Contains(textBoxBusqueda.Text.ToUpper())).ToList();
            }
        }

        public static void GenerateExcel(DataTable dataTable, string path)
        {

            DataSet dataSet = new DataSet();
            dataSet.Tables.Add(dataTable);

            // create a excel app along side with workbook and worksheet and give a name to it  
            Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook excelWorkBook = excelApp.Workbooks.Add();
            Microsoft.Office.Interop.Excel._Worksheet xlWorksheet = excelWorkBook.Sheets[1];
            Microsoft.Office.Interop.Excel.Range xlRange = xlWorksheet.UsedRange;
            foreach (DataTable table in dataSet.Tables)
            {
                //Add a new worksheet to workbook with the Datatable name  
                Microsoft.Office.Interop.Excel.Worksheet excelWorkSheet = excelWorkBook.Sheets.Add();
                excelWorkSheet.Name = table.TableName;

                // add all the columns  
                for (int i = 1; i < table.Columns.Count + 1; i++)
                {
                    excelWorkSheet.Cells[1, i] = table.Columns[i - 1].ColumnName;
                }

                // add all the rows  
                for (int j = 0; j < table.Rows.Count; j++)
                {
                    for (int k = 0; k < table.Columns.Count; k++)
                    {
                        excelWorkSheet.Cells[j + 2, k + 1] = table.Rows[j].ItemArray[k].ToString();
                    }
                }
            }

            var today = DateTime.Now.Date.ToString("dd-MM-yyyy", CultureInfo.InvariantCulture);
            var fullPath = $"{path}\\FacturasExportadas_{today}";
            excelWorkBook.SaveAs(fullPath); // -> this will do the custom  
            excelWorkBook.Close();
            excelApp.Quit();
        }

        // T is a generic class  
        private DataTable ConvertToDataTable<T>(List<T> models)
        {
            // creating a data table instance and typed it as our incoming model   
            // as I make it generic, if you want, you can make it the model typed you want.  
            DataTable dataTable = new DataTable(typeof(T).Name);

            //Get all the properties of that model  
            PropertyInfo[] Props = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);

            // Loop through all the properties              
            // Adding Column name to our datatable  
            foreach (PropertyInfo prop in Props)
            {
                //Setting column names as Property names    
                dataTable.Columns.Add(prop.Name);
            }
            // Adding Row and its value to our dataTable  
            foreach (T item in models)
            {
                var values = new object[Props.Length];
                for (int i = 0; i < Props.Length; i++)
                {
                    //inserting property values to datatable rows    
                    values[i] = Props[i].GetValue(item, null);
                }
                // Finally add value to datatable    
                dataTable.Rows.Add(values);
            }
            return dataTable;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            var codigosFactura = this.dataGridViewFacturas.Rows.OfType<DataGridViewRow>().Select(r => Convert.ToInt64(r.Cells["ClumnCodigo"].Value.ToString())).ToList();
            var documentosToExport = this.documentoGestion.GetFacturasToExport(codigosFactura);


            var dataTable = ConvertToDataTable<FacturaExport>(documentosToExport);
            GenerateExcel(dataTable, RutasSalida.RutaExcel);
        }

        private void buttonExportar_MouseEnter(object sender, EventArgs e)
        {
            labelExportar.Visible = true;
        }

        private void buttonExportar_MouseLeave(object sender, EventArgs e)
        {
            labelExportar.Visible = false;
        }

        private void comboBoxBusqueda_SelectedValueChanged(object sender, EventArgs e)
        {
            if(comboBoxBusqueda.Text.Equals("Fecha"))
            {
                textBoxBusqueda.Visible = false;
                dateTimePickerFrom.Visible = true;
                dateTimePickerTo.Visible = true;
            }
            else
            {
                dateTimePickerFrom.Visible = false;
                dateTimePickerTo.Visible = false;
                textBoxBusqueda.Visible = true;
            }
        }

        private void dateTimePickerFrom_ValueChanged(object sender, EventArgs e)
        {
                dataGridViewFacturas.DataSource = documentos.Where(x => x.FechaFactura >= dateTimePickerFrom.Value && x.FechaFactura <= dateTimePickerTo.Value).ToList();
        }

        private void dateTimePickerTo_ValueChanged(object sender, EventArgs e)
        {
                dataGridViewFacturas.DataSource = documentos.Where(x => x.FechaFactura >= dateTimePickerFrom.Value && x.FechaFactura <= dateTimePickerTo.Value).ToList();
        }
    }
}
