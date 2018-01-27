using AdministracionAngela.Utils.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdministracionAngela.Utils.Models.Factura;
using AdministracionAngela.Utils.Enumerados;
using AdministracionAngela.Utils.Genericos;

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
            return "CrystalReportImpresionAlbaran";
        }

        public string GetVariableImpresion()
        {
            return "@NumeroAlbaran";
        }
    }
}
