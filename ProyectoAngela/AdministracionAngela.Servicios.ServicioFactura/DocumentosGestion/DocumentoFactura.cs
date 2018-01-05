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
    }
}
