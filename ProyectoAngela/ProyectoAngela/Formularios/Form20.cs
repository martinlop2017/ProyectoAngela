using AdministracionAngela.Utils.Models.Factura;
using Microsoft.Reporting.WinForms;
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
    public partial class Form20 : Form
    {
        List<ImpresionFactura> facturas;

        public Form20()
        {
            InitializeComponent();
            facturas = new List<ImpresionFactura>();

            //ReportParameter parameter = new ReportParameter("NumeroFacturaParameter", "1");
            //this.reportViewer1.LocalReport.SetParameters(parameter);
        }

        public void SetFacturas(List<ImpresionFactura> facturasParaImprimir)
        {
            this.facturas = facturasParaImprimir;
        }

        private void Form20_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSetnUEVO.LineaFactura' table. You can move, or remove it, as needed.
            //this.LineaFacturaTableAdapter.Fill(this.DataSetnUEVO.LineaFactura);

            //this.reportViewer1.RefreshReport();

            //ImpresionFacturaBindingSource.DataSource = new List<ImpresionFactura>()
            //{
            //    new ImpresionFactura()
            //    {
            //    NumeroFactura = 1,
            //    DescripcionProducto = "Sardinas",
            //    NombreCliente = "Pepe",
            //    Precio = 10
            //},
            //    new ImpresionFactura()
            //    {
            //    NumeroFactura = 1,
            //    DescripcionProducto = "Boquerones",
            //    NombreCliente = "Papa",
            //    Precio = 14
            //},
            //    new ImpresionFactura()
            //    {
            //    NumeroFactura = 2,
            //    DescripcionProducto = "Caballa",
            //    NombreCliente = "Alvaro",
            //    Precio = 20
            //}
            //};

            ImpresionFacturaBindingSource.DataSource = this.facturas;
            this.reportViewer1.RefreshReport();

        }
    }
}
