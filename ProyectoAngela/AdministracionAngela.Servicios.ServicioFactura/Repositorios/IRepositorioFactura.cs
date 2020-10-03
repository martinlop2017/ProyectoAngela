using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdministracionAngela.EFRepository;

namespace AdministracionAngela.Servicios.ServicioDatos.Repositorios
{
    public interface IRepositorioFactura
    {
        List<Factura> GetAllFacurasByClienteId(long clienteId);
        Factura GetLastFactura();
        Albaran GetLastAlbaran(bool isAlbaran);
        void SaveFactura(Factura factura);
        List<Factura> GetAllFacturas();
        void DeleteLineasFacturaByNumeroFactura(List<Factura> repositoryFacturasToDelete);
        void DeleteFacturas(List<Factura> repositoryFacturasToDelete);
        Factura GetFacturaById(long facturaId);
        List<Albaran> GetAlbaranesByIds(List<long> albaranesIds);
        Albaran GetAlbaranById(long albaranId, bool isAlbaran);
        void UpdateFactura(Factura facturaToRepository);
        void SetFacturaImpresa(List<long> selectedFacturaIds);
        void SaveAlbaran(Albaran albaranToRepository);
        void DeleteLineasAlbaranByNumeroAlbaran(List<Albaran> repositoryAlbaranesToDelete);
        void DeleteAlbaranes(List<Albaran> repositoryAlbaranesToDelete);
        void UpdateAlbaran(Albaran albaranToRepository);
        void SetAlbaranImpresa(List<long> selectedAlbaranIds);
        List<Albaran> GetAllAlbaranes();
        void SetFacturado(long numeroAlbaran);
        List<LineaFactura> GetLineasFactura(long facturaId);
        List<LineaAlbaran> GetLineasAlbaran(long albaranId);
        bool ExisteFactura(int numeroDocumento);
        bool ExisteAlbaran(int numeroDocumento, bool isDocumento);
        void SetCobrado(int numeroDocumento, bool cobrado);
        List<Factura> GetFacturasCaducadas(long fromClientCode, long toClientCode, DateTime fromFehaFactura, DateTime toFechaFactura);
        List<Factura> GetFacturasCobradas(long fromClientCode, long toClientCode, DateTime fromFehaFactura, DateTime toFechaFactura);
        List<Factura> GetAllFacturasCaducadas();
        void SetFacturaCobrada(long codigoFactura, bool cobrada, DateTime fechaCobro);
        List<Factura> GetFacturasByDateRange(DateTime from, DateTime to);
        List<Factura> GetFacturasByClienteRange(int from, int to);
        List<Albaran> GetAlbaranesByDateRange(DateTime from, DateTime to);
        List<Albaran> GetAlbaranesByClienteRange(int from, int to);
        bool ReiniciarBaseDAtos();
        List<Factura> GetFacturaPendientes(long fromClientCode, long toClientCode, DateTime fromFehaFactura, DateTime toFechaFactura);
        void SetFechaCobro(long codigoFactura, DateTime fechaCobro);
        List<Factura> GetFacturas(List<long> numerosFactura);
    }
}
