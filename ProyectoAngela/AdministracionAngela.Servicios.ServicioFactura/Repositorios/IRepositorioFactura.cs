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
        void SaveFactura(Factura factura);
        List<Factura> GetAllFacturas();
        void DeleteLineasFacturaByNumeroFactura(List<Factura> repositoryFacturasToDelete);
        void DeleteFacturas(List<Factura> repositoryFacturasToDelete);
        Factura GetFacturaById(long facturaId);
        void UpdateFactura(Factura facturaToRepository);
    }
}
