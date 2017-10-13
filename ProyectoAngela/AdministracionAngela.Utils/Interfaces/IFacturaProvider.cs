﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdministracionAngela.Utils.Models.Factura;

namespace AdministracionAngela.Utils.Interfaces
{
    public interface IFacturaProvider
    {
        AltaFacturaViewModel GetFacturaViewModel();
        List<LineaIVAViewModel> CalculateIVAs(AltaFacturaViewModel altaFacturaViewModel);
        void SaveFactura(AltaFacturaViewModel viewModel);
        GestionFacturaViewModel GetGestionFactura();
        void DeleteFacturas(List<FacturaViewModel> mappedSelectedRows);
        AltaFacturaViewModel GetFacturaViewModelById(long facturaId);
        void UpdateFactura(AltaFacturaViewModel viewModel);
        List<ImpresionFactura> GetImpresionFactura(List<long> selectedFacturaIds);
        void SetFacturaImpresa(List<long> selectedFacturaIds);
    }
}
