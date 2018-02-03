using AdministracionAngela.Utils.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdministracionAngela.Utils.Models.Factura;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using AdministracionAngela.Utils.Genericos;
using AdministracionAngela.Utils.Enumerados;
using System.Data;

namespace AdministracionAngela.Servicios.ServicioDatos.DocumentosGestion
{
    public class DocumentoFactura : IDocumentoGestion
    {
        IFacturaProvider facturaProvider;
        IFormOpener formOpener;

        public DocumentoFactura(IFormOpener formOpener, IFacturaProvider facturaProvider)
        {
            this.formOpener = formOpener;
            this.facturaProvider = facturaProvider;
        }

        public void DeleteDocumentos(List<FacturaViewModel> mappedSelectedRows)
        {
            this.facturaProvider.DeleteFacturas(mappedSelectedRows);
        }

        public GestionFacturaViewModel GetDocumentos(bool Isdocumento)
        {
            return this.facturaProvider.GetGestionFactura();
        }

        public void Exportar()
        {
        }

        public void SetDocumentoImpresa(List<long> selectedFacturaIds)
        {
            this.facturaProvider.SetFacturaImpresa(selectedFacturaIds);
        }

        public string GetExportPath(long numeroDocumento)
        {
            return string.Format(@"{0}\factura{1}.pdf", RutasSalida.RutaFacturacion, numeroDocumento);
        }

        public string GetTitulo()
        {
            return "Gestion de Facturas";
        }

        public EnumDocumentosGestion GetTipoDocumento()
        {
            return EnumDocumentosGestion.Factura;
        }

        public bool CanBeDocumento()
        {
            return false;
        }

        public void Facturar(List<long> albaranesIds)
        {
        }

        public bool PuedeFacturar()
        {
            return false;
        }

        public string GetReportImpresion()
        {
            return "CrystalReportImpresionFactura";
        }

        public string GetVariableImpresion()
        {
            return "@NumeroFactura";
        }

        public DataTable GatDatosIva(int numeroDocumento)
        {
            DataTable table = new DataTable("FacturaIVA");
            table.Columns.Add("BaseImponible", Type.GetType("System.String"));
            table.Columns.Add("PorcentajeIVA", Type.GetType("System.String"));
            table.Columns.Add("ImporteIVA", Type.GetType("System.String"));
            table.Columns.Add("PorcentajeRE", Type.GetType("System.String"));
            table.Columns.Add("ImporteRE", Type.GetType("System.String"));
            table.Columns.Add("GastosSuplidos", Type.GetType("System.String"));

            var ivas = this.facturaProvider.GetFacturaIva(numeroDocumento);
            foreach(var iva in ivas)
            {
                DataRow row = table.NewRow();
                row[0] = iva.BaseImponible;
                row[1] = iva.PorcentajeIVA.ToString();
                row[2] = iva.ImporteIVA.ToString();
                row[3] = iva.PorcentajeRE.ToString();
                row[4] = iva.ImporteRE.ToString();
                row[4] = iva.GastosSuplidos.ToString();
                table.Rows.Add(row);
            }

            return table;
        }

        public DataTable GetDatosImpresion(int numeroDocumento)
        {
            DataTable table = new DataTable("FacturaCliente");
            table.Columns.Add("NumeroFactura", Type.GetType("System.Int32"));
            table.Columns.Add("Dni", Type.GetType("System.String"));
            table.Columns.Add("Descripcion", Type.GetType("System.String"));
            table.Columns.Add("Fecha", Type.GetType("System.String"));
            table.Columns.Add("Codigo", Type.GetType("System.Int32"));
            table.Columns.Add("Bultos", Type.GetType("System.Int32"));
            table.Columns.Add("Kgs", Type.GetType("System.String"));
            table.Columns.Add("Precio", Type.GetType("System.String"));
            table.Columns.Add("Importe", Type.GetType("System.String"));

            var lineas = this.facturaProvider.GetFacturaCliente(numeroDocumento);
            foreach (var linea in lineas)
            {
                DataRow row = table.NewRow();
                row[0] = numeroDocumento;
                row[1] = linea.Dni;
                row[2] = linea.Descripcion;
                row[3] = linea.Fecha.ToString("dd/MM/yyyy");
                row[4] = linea.CodigoArticulo;
                row[5] = linea.Bultos;
                row[6] = linea.Kgs.ToString();
                row[7] = linea.Precio.ToString();
                row[8] = linea.Importe.ToString();
                table.Rows.Add(row);
            }

            return table;
        }
    }
}
