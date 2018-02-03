using AdministracionAngela.Utils.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdministracionAngela.Utils.Models.Factura;
using AdministracionAngela.Utils.Enumerados;
using AdministracionAngela.Utils.Genericos;
using System.Data;

namespace AdministracionAngela.Servicios.ServicioDatos.DocumentosGestion
{
    public class DocumentoAlbaran : IDocumentoGestion
    {
        IFacturaProvider facturaProvider;

        public DocumentoAlbaran(IFacturaProvider facturaProvider)
        {
            this.facturaProvider = facturaProvider;
        }

        public bool CanBeDocumento()
        {
            return true;
        }

        public void DeleteDocumentos(List<FacturaViewModel> mappedSelectedRows)
        {
            this.facturaProvider.DeleteAlbaranes(mappedSelectedRows);
        }

        public void Facturar(List<long> albaranesIds)
        {
            this.facturaProvider.Facturar(albaranesIds);
        }

        public GestionFacturaViewModel GetDocumentos(bool IsDocumento)
        {
            return this.facturaProvider.GetGestionFacturaAlbaranes(IsDocumento);
        }

        public string GetExportPath(long numeroDocumento)
        {
            return string.Format(@"{0}\albaran{1}.pdf", RutasSalida.RutaAlbaranes, numeroDocumento);
        }

        public EnumDocumentosGestion GetTipoDocumento()
        {
            return EnumDocumentosGestion.Albaran;
        }

        public string GetTitulo()
        {
            return "Gestion Albaranes";
        }

        public void SetDocumentoImpresa(List<long> selectedDocumentoIds)
        {
            this.facturaProvider.SetAlbaranImpresa(selectedDocumentoIds);
        }

        public bool PuedeFacturar()
        {
            return true;
        }

        public string GetReportImpresion()
        {
            return "CrystalReportImpresionFactura";
        }

        public string GetVariableImpresion()
        {
            return "@NumeroAlbaran";
        }

        public DataTable GetDatosImpresion(int numeroDocumento, bool isDocumento = true)
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
            table.Columns.Add("Total", Type.GetType("System.String"));
            table.Columns.Add("LineaDireccionCliente", Type.GetType("System.String"));
            table.Columns.Add("Provincia", Type.GetType("System.String"));
            table.Columns.Add("Poblacion", Type.GetType("System.String"));
            table.Columns.Add("CodigoPostal", Type.GetType("System.String"));
            table.Columns.Add("NombreEmpresa", Type.GetType("System.String"));
            table.Columns.Add("DniPerfil", Type.GetType("System.String"));
            table.Columns.Add("CodigoPostalPerfil", Type.GetType("System.String"));
            table.Columns.Add("PoblacionPerfil", Type.GetType("System.String"));
            table.Columns.Add("ProvinciaPerfil", Type.GetType("System.String"));
            table.Columns.Add("LineaDireccionPerfil", Type.GetType("System.String"));
            table.Columns.Add("TelefonoPerfil", Type.GetType("System.String"));
            table.Columns.Add("EmailPerfil", Type.GetType("System.String"));
            table.Columns.Add("FaxPerfil", Type.GetType("System.String"));
            table.Columns.Add("ZonaCaptura", Type.GetType("System.String"));
            table.Columns.Add("FAO", Type.GetType("System.String"));
            table.Columns.Add("Arte", Type.GetType("System.String"));
            table.Columns.Add("NombreCientifico", Type.GetType("System.String"));
            table.Columns.Add("Abreviacion", Type.GetType("System.String"));
            table.Columns.Add("NombreCliente", Type.GetType("System.String"));
            table.Columns.Add("NombreDocumento", Type.GetType("System.String"));

            var lineas = this.facturaProvider.GetAlbaranCliente(numeroDocumento, isDocumento);
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
                row[9] = linea.Total.ToString();
                row[10] = linea.LineaDireccion.ToString();
                row[11] = linea.Provincia.ToString();
                row[12] = linea.Poblacion.ToString();
                row[13] = linea.CodigoPostal.ToString();
                row[14] = linea.NombreEmpresa;
                row[15] = linea.DniPerfil;
                row[16] = linea.CodigoPostalPerfil.ToString();
                row[17] = linea.PoblacionPerfil;
                row[18] = linea.ProvinciaPerfil;
                row[19] = linea.LineaDireccionPerfil;
                row[20] = linea.TelefonoPerfil.ToString();
                row[21] = linea.EmailPerfil;
                row[22] = linea.FaxPerfil.ToString();
                row[23] = linea.ZonaCAptura;
                row[24] = linea.FAO;
                row[25] = linea.Arte;
                row[26] = linea.NombreCientifico;
                row[27] = linea.Abreviacion;
                row[28] = linea.NombreCliente;
                row[29] = "A L B A R A N";
                table.Rows.Add(row);
            }

            return table;
        }

        public DataTable GatDatosIva(int numeroDocumento, bool isDocumento = true)
        {
            DataTable table = new DataTable("FacturaIVA");
            table.Columns.Add("BaseImponible", Type.GetType("System.String"));
            table.Columns.Add("PorcentajeIVA", Type.GetType("System.String"));
            table.Columns.Add("ImporteIVA", Type.GetType("System.String"));
            table.Columns.Add("PorcentajeRE", Type.GetType("System.String"));
            table.Columns.Add("ImporteRE", Type.GetType("System.String"));
            table.Columns.Add("GastosSuplidos", Type.GetType("System.String"));

            var ivas = this.facturaProvider.GetAlbaranIva(numeroDocumento, isDocumento);
            foreach (var iva in ivas)
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
    }
}
