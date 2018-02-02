﻿using AdministracionAngela.Utils.Interfaces;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdministracionAngela.ProyectoAngela.Formularios
{
    public partial class ImprimirFacturas : Form
    {
        private long numeroDocumentoInicial;
        private IFormOpener formOpener;
        private IDocumentoGestion documentoGestion;
        private string reportName;
        private string variableName;

        public ImprimirFacturas(IFormOpener formOpener, IDocumentoGestion documentoGestion, long numeroDocumentoInicial, string reportName, string variableName)
        {
            this.numeroDocumentoInicial = numeroDocumentoInicial;
            this.formOpener = formOpener;
            this.documentoGestion = documentoGestion;

            InitializeComponent();
            this.textBoxDocumentoInicial.Text = numeroDocumentoInicial.ToString();
            this.textBoxDocumentoFinal.Text = numeroDocumentoInicial.ToString();


            this.reportName = reportName;
            this.variableName = variableName;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            bool impreso = false;
            var form = new FormEsperar("Imprimiendo");
            CheckForIllegalCrossThreadCalls = false;
            var test = Task.Factory.StartNew(() =>
            {
                var documentoInicial = int.Parse(this.textBoxDocumentoInicial.Text);
                var documentoFinal = int.Parse(this.textBoxDocumentoFinal.Text);

                IEnumerable<int> documentosAImprimir = Enumerable.Range(documentoInicial, documentoFinal - documentoInicial + 1).Select(x => x);
                ExportarFacturas(documentosAImprimir.ToList());

                var longDocumentosAImprimir = documentosAImprimir.ToList().Select(x => Convert.ToInt64(x)).ToList();
                this.documentoGestion.SetDocumentoImpresa(longDocumentosAImprimir);

                form.Close();
            }
            );

            form.ShowDialog();

            test.Dispose();
            CheckForIllegalCrossThreadCalls = true;
            this.Close();
        }

        private void ExportarFacturas(List<int> selectedFacturaIds)
        {
            using (var formImpresion = this.formOpener.GetForm<FormImpresion>() as FormImpresion)
            {

                DataSetFacturaImpresion dataset = new DataSetFacturaImpresion();
                DataTable table = dataset.Tables.Add("FacturaCliente");
                table.Columns.Add("NumeroFactura", Type.GetType("System.Int32"));
                table.Columns.Add("Dni", Type.GetType("System.String"));
                table.Columns.Add("Descripcion", Type.GetType("System.String"));

                DataRow row = table.NewRow();
                row[0] = 1;
                row[1] = "442";
                row[2] = "aaaa";
                table.Rows.Add(row);

                DataRow row1 = table.NewRow();
                row1[0] = 1;
                row1[1] = "442";
                row1[2] = "bbbbb";
                table.Rows.Add(row1);

                DataSetFacturaImpresion dataset2 = new DataSetFacturaImpresion();
                DataTable table3 = dataset2.Tables.Add("Iva");
                table3.Columns.Add("Porcentaje", Type.GetType("System.Int32"));

                DataRow row3 = table3.NewRow();
                row3[0] = 5;
                table3.Rows.Add(row3);

                DataRow row4 = table3.NewRow();
                row4[0] = 5;
                table3.Rows.Add(row4);


                ReportDocument oRep = new ReportDocument();
                //ParameterField pf = new ParameterField();
                //ParameterFields pfs = new ParameterFields();
                //ParameterDiscreteValue pdv = new ParameterDiscreteValue();
                //pf.Name = variableName;
                //pf.CurrentValues.Add(pdv);
                //pfs.Add(pf);
                //formImpresion.crystalReportViewer1.ParameterFieldInfo = pfs;
                var reportPath = string.Format(@"{0}\..\..\Formularios\{1}.rpt", Directory.GetCurrentDirectory(), reportName);
                oRep.Load(reportPath);
                oRep.SetDataSource(dataset.Tables[1]);
                oRep.Subreports[0].SetDataSource(dataset2.Tables[1]);

                var path = this.documentoGestion.GetExportPath(1);
                oRep.ExportToDisk(ExportFormatType.PortableDocFormat, path);
                //foreach (var numeroFactura in selectedFacturaIds)
                //{
                //    oRep.SetParameterValue(variableName, numeroFactura);
                //    formImpresion.crystalReportViewer1.ReportSource = oRep;
                //    var path = this.documentoGestion.GetExportPath(numeroFactura);
                //    oRep.ExportToDisk(ExportFormatType.PortableDocFormat, path);
                //}
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ImprimirFacturas_Load(object sender, EventArgs e)
        {

        }

        private void ImprimirFacturas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(13))
            {
                e.Handled = true; SendKeys.Send("{TAB}");
            }
        }
    }
}
