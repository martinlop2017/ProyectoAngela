using AdministracionAngela.Utils.Enumerados;
using AdministracionAngela.Utils.Models.Factura;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministracionAngela.Utils.Interfaces
{
    public interface IDocumentoGestion
    {
        void DeleteDocumentos(List<FacturaViewModel> mappedSelectedRows);
        GestionFacturaViewModel GetDocumentos();
        void SetDocumentoImpresa(List<long> selectedFacturaIds);
        string GetExportPath(long numeroDocumento);
        string GetTitulo();
        EnumDocumentosGestion GetTipoDocumento();
    }
}
