using AdministracionAngela.EFRepository;
using AdministracionAngela.Utils.Models.Impresion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministracionAngela.Utils.Mappers
{
    public static class MapToImpresion
    {
        public static List<ListadoFactura> MapListaFactura(List<Factura> facturas)
        {
            return facturas.Select(x => MapFactura(x)).ToList();
        }

        public static ListadoFactura MapFactura(Factura factura)
        {
            return new ListadoFactura()
            {
                Cliente = factura.Cliente.Nombre,
                FechaFactura = factura.Fecha.Value.ToString("d"),
                FechaListado = DateTime.Today.ToString("d"),
                NumeroFactura = factura.NumeroFactura,
                Total = factura.Total.Value
            };
        }

        public static List<ListadoAlbaran> MapListaAlbaran(List<Albaran> albaranes)
        {
            return albaranes.Select(x => MapAlbaran(x)).ToList();
        }

        public static ListadoAlbaran MapAlbaran(Albaran albaran)
        {
            return new ListadoAlbaran()
            {
                Cliente = albaran.Cliente.Nombre,
                FechaAlbaran = albaran.Fecha.Value.ToString("d"),
                FechaListado = DateTime.Today.ToString("d"),
                NumeroAlbaran = albaran.NumeroAlbaran,
                Total = albaran.Total.Value
            };
        }
    }
}
