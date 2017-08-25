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
        DbSet<Cliente> Cliente { get; set; }
        DbSet<Factura> Factura { get; set; }
        DbSet<IVA> IVA { get; set; }
        DbSet<LineaFactura> LineaFactura { get; set; }
        DbSet<Producto> Producto { get; set; }
    }
}
