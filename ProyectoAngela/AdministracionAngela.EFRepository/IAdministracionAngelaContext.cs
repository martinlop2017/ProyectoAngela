using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministracionAngela.EFRepository
{
    public interface IAdministracionAngelaContext
    {
        DbSet<Cliente> Clientes { get; set; }
        DbSet<Factura> Facturas { get; set; }
        DbSet<Albaran> Albaranes { get; set; }
        DbSet<IVA> IVAs { get; set; }
        DbSet<LineaFactura> LineasFactura { get; set; }
        DbSet<LineaAlbaran> LineasAlbaran { get; set; }
        DbSet<Producto> Productos { get; set; }
        DbSet<Direccion> Direcciones { get; set; }
        DbSet<Contacto> Contactos { get; set; }
        DbSet<Perfil> Perfiles { get; set; }
        DbSet<User> Users { get; set; }
        DbSet<FormaPago> FormasPago { get; set; }

        int SaveChanges();
        void ReloadEntities<T>() where T : class;
        void BackUp(string path);
    }
}
