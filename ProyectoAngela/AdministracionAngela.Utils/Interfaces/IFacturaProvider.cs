using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdministracionAngela.Utils.Models.Factura;
using AdministracionAngela.Utils.Models.Liquidaciones;
using AdministracionAngela.Utils.Models.Albaran;
using AdministracionAngela.Utils.Models.Impresion;

namespace AdministracionAngela.Utils.Interfaces
{
    public interface IFacturaProvider
    {
        AltaFacturaViewModel GetFacturaViewModel();
        List<LineaIVAViewModel> CalculateIVAs(AltaFacturaViewModel altaFacturaViewModel);
        List<LineaIVAViewModel> CalculateIVAs(AltaAlbaranViewModel altaAlbaranViewModel);
        void SaveFactura(AltaFacturaViewModel viewModel);
        GestionFacturaViewModel GetGestionFactura();
        GestionFacturaViewModel GetGestionFacturaAlbaranes(bool IsAlbaran);
        void DeleteFacturas(List<FacturaViewModel> mappedSelectedRows);
        AltaFacturaViewModel GetFacturaViewModelById(long facturaId);
        void UpdateFactura(AltaFacturaViewModel viewModel);
        void Facturar(List<long> albaranesIds);
        List<ImpresionFactura> GetImpresionFactura(List<long> selectedFacturaIds);
        void SetFacturaImpresa(List<long> selectedFacturaIds);
        LiquidacionesViewModel GetLiquidacionesParaFechas(DateTime startDate, DateTime endDate);
        AltaAlbaranViewModel GetAlbaranViewModel(bool isAlbaran);
        void SaveAlbaran(AltaAlbaranViewModel viewModel);
        void DeleteAlbaranes(List<FacturaViewModel> albaranesToDelete);
        AltaAlbaranViewModel GetAlbaranViewModelById(long AlbaranId, bool isAlbaran);
        void UpdateAlbaran(AltaAlbaranViewModel viewModel);
        void SetAlbaranImpresa(List<long> selectedAlbaranIds);
        LiquidacionesViewModel GetLineasAlbaranParaFechas(DateTime startDate, DateTime endDate);
        List<FacturaCliente> GetFacturaCliente(int numeroFactura);
        List<FacturaIva> GetFacturaIva(int numerFactura);
        List<FacturaCliente> GetAlbaranCliente(int numeroAlbaran, bool isAlbaran);
        List<FacturaIva> GetAlbaranIva(int numerFactura, bool isAlbaran);
        bool ExisteFactura(int numeroDocumento);
        bool ExisteAlbaran(int numeroDocumento, bool isDocumento);
        void SetCobrado(int numeroDocumento, bool cobrado);
        void LoadIVAAndREBy(AltaFacturaViewModel viewModel);
        void LoadIVAAndREBy(AltaAlbaranViewModel viewModel);
    }
}
