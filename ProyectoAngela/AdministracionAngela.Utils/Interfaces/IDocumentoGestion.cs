using AdministracionAngela.Utils.Enumerados;
using AdministracionAngela.Utils.Models.Exports;
using AdministracionAngela.Utils.Models.Factura;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministracionAngela.Utils.Interfaces
{
    public interface IDocumentoGestion
    {
        void DeleteDocumentos(List<FacturaViewModel> mappedSelectedRows);
        GestionFacturaViewModel GetDocumentos(bool IsDocumento);
        void SetDocumentoImpresa(List<long> selectedFacturaIds);
        string GetExportPath(long numeroDocumento, bool isDocumento = true);
        string GetTitulo();
        EnumDocumentosGestion GetTipoDocumento();
        bool CanBeDocumento();
        void Facturar(List<long> albaranesIds);
        bool PuedeFacturar();
        string GetReportImpresion(bool isDocumento = true);
        string GetVariableImpresion();
        DataTable GetDatosImpresion(int numeroDocumento, bool isDocumento = true);
        DataTable GatDatosIva(int numeroDocumento, bool isDocumento = true);
        bool DocumentoExiste(int numeroDocumento, bool isDocumento = true);
        void SetCobrado(int numeroDocumento, bool cobrado);
        List<FacturaExport> GetFacturasToExport(List<long> numeroFacturas);
    }
}
