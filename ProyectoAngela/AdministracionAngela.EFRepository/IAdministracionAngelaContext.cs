﻿using System;
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
        DbSet<IVA> IVAs { get; set; }
        DbSet<LineaFactura> LineasFactura { get; set; }
        DbSet<Producto> Productos { get; set; }
        DbSet<Direccion> Direcciones { get; set; }
        DbSet<Contacto> Contactos { get; set; }

        int SaveChanges();
    }
}
