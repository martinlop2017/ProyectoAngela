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
    }
}
