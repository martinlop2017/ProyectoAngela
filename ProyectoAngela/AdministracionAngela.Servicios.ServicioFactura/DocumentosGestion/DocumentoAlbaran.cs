using AdministracionAngela.Utils.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdministracionAngela.Utils.Models.Factura;

namespace AdministracionAngela.Servicios.ServicioDatos.DocumentosGestion
{
    public class DocumentoAlbaran : IDocumentoGestion
    {
        public void DeleteDocumentos(List<FacturaViewModel> mappedSelectedRows)
        {
            throw new NotImplementedException();
        }

        public GestionFacturaViewModel GetDocumentos()
        {
            throw new NotImplementedException();
        }

        public string GetExportPath(long numeroDocumento)
        {
            throw new NotImplementedException();
        }

        public string GetTitulo()
        {
            return "Gestion Albaranes";
        }

        public void SetDocumentoImpresa(List<long> selectedFacturaIds)
        {
            throw new NotImplementedException();
        }
    }
}
