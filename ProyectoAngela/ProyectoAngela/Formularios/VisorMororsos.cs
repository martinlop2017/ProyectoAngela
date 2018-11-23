using AdministracionAngela.Utils.Interfaces;
using AdministracionAngela.Utils.Models.Impresion;
using Microsoft.Reporting.WinForms;
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
    public partial class VisorMororsos : Form
    {
        public VisorMororsos()
        {            
            InitializeComponent();
        }

        private void VisorMororsos_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();            
        }

        public void ExportarToPdf(List<Moroso> morosos)
        {
            this.MorosoBindingSource.DataSource = morosos;
            //this.reportViewer1.RefreshReport();
            string mimeType = string.Empty;
            string encoding = string.Empty;
            string extension = string.Empty;
            Warning[] warnings;
            string[] streamIds;

            var form = new FormEsperar("Imprimiendo");
            CheckForIllegalCrossThreadCalls = false;
            var test = Task.Factory.StartNew(() =>
            {
                byte[] bytes = reportViewer1.LocalReport.Render("PDF", null, out mimeType, out encoding,
                out extension, out streamIds, out warnings);

                var exportPath = string.Format(@"C:\martin\Impresiones\Listado Morosos.pdf");
                //var exportPath = string.Format(@"{0}\Liquidacion {1} - {2}.pdf", RutasSalida.RutaLiquidaciones, liquidaciones.First().liqdefecha, liquidaciones.First().liqdafecha);
                File.WriteAllBytes(exportPath, bytes);

                form.Close();
            });

            form.ShowDialog();

            test.Dispose();
            CheckForIllegalCrossThreadCalls = true;

        }

        private void MorosoBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void morosoBindingSource_CurrentChanged_1(object sender, EventArgs e)
        {

        }
    }
}
