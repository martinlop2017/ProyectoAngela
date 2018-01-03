using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdministracionAngela.Utils.Models.Factura;
using AdministracionAngela.Utils.Models.Liquidaciones;
using AdministracionAngela.Utils.Models.Albaran;

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
        LiquidacionesViewModel GetLineasFacturaParaFechas(DateTime startDate, DateTime endDate);
        AltaFacturaViewModel GetAlbaranViewModel();
        void SaveAlbaran(AltaAlbaranViewModel viewModel);
        void DeleteAlbaranes(List<AlbaranViewModel> albaranesToDelete);
        AltaAlbaranViewModel GetAlbaranViewModelById(long AlbaranId);
        void UpdateAlbaran(AltaAlbaranViewModel viewModel);
        void SetAlbaranImpresa(List<long> selectedAlbaranIds);
        LiquidacionesViewModel GetLineasAlbaranParaFechas(DateTime startDate, DateTime endDate);
    }
}
