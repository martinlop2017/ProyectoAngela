using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdministracionAngela.Utils.Models.Factura;
using AdministracionAngela.Utils.Models.Liquidaciones;
using AdministracionAngela.Utils.Models.Albaran;
using AdministracionAngela.Utils.Models.Impresion;
using AdministracionAngela.Utils.Models.Avisos;

namespace AdministracionAngela.Utils.Interfaces
{
    public interface IFacturaProvider
    {
        bool ClienteExcedeRiesgo(AltaFacturaViewModel viewModel);
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
        void SetFacturaCobrada(long codigoFactura, bool cobrada, DateTime fechaCobro);
        void LoadIVAAndREBy(AltaFacturaViewModel viewModel);
        void LoadIVAAndREBy(AltaAlbaranViewModel viewModel);
        GestionAvisosViewModel GetGestionFacturasVencidas(long fromClientCode, long toClientCode, DateTime fromFehaFactura, DateTime toFechaFactura, bool checkForPendientes, bool checkForCobradas);
        //List<AltaAlbaranViewModel> GetAllAlbaranes();
        List<ListadoFactura> GetAllFacturasFromDateRange(DateTime from, DateTime to);
        List<ListadoFactura> GetAllFacturasFromClienteRange(int fromCodigo, int toCodigo);
        List<ListadoFactura> GetAllFacturasFromClienteAndDateRange(DateTime from, DateTime to, int fromCodigo, int toCodigo);
        List<ListadoAlbaran> GetAllAlbaranesFromDateRange(DateTime from, DateTime to);
        List<ListadoAlbaran> GetAllAlbaranesFromClienteRange(int fromCodigo, int toCodigo);
        List<ListadoAlbaran> GetAllAlbaranesFromClienteAndDateRange(DateTime from, DateTime to, int fromCodigo, int toCodigo);
        List<ListadoFactura> GetAllListaFacturas();
        List<ListadoAlbaran> GetAllListaAlbaranes();
    }
}
