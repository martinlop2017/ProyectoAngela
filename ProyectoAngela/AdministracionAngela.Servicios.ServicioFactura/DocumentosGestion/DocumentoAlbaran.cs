﻿using AdministracionAngela.Utils.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdministracionAngela.Utils.Models.Factura;
using AdministracionAngela.Utils.Enumerados;

namespace AdministracionAngela.Servicios.ServicioDatos.DocumentosGestion
{
    public class DocumentoAlbaran : IDocumentoGestion
    {
        IFacturaProvider facturaProvider;

        public DocumentoAlbaran(IFacturaProvider facturaProvider)
        {
            this.facturaProvider = facturaProvider;
        }

        public void DeleteDocumentos(List<FacturaViewModel> mappedSelectedRows)
        {
            throw new NotImplementedException();
        }

        public GestionFacturaViewModel GetDocumentos()
        {
            return this.facturaProvider.GetGestionFactura();
        }

        public string GetExportPath(long numeroDocumento)
        {
            throw new NotImplementedException();
        }

        public EnumDocumentosGestion GetTipoDocumento()
        {
            return EnumDocumentosGestion.Albaran;
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
