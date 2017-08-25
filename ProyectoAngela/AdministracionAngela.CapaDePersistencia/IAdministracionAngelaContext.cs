using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministracionAngela.CapaDePersistencia
{
    public interface IAdministracionAngelaContext : IDisposable
    {
        DbSet<Cliente> Clientes { get; set; }
        DbSet<Factura> Facturas { get; set; }
        DbSet<IVA> IVAs { get; set; }
        DbSet<LineaFactura> LineasFactura { get; set; }
        DbSet<Producto> Productos { get; set; }
    }
}
