﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AdministracionAngela.EFRepository
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;

    public partial class AdministracionAngelaContext : DbContext, IAdministracionAngelaContext
    {
        public AdministracionAngelaContext()
            : base("name=AdministracionAngelaContext")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }

        public virtual DbSet<Cliente> Clientes { get; set; }
        public virtual DbSet<Factura> Facturas { get; set; }
        public virtual DbSet<Albaran> Albaranes { get; set; }
        public virtual DbSet<IVA> IVAs { get; set; }
        public virtual DbSet<LineaFactura> LineasFactura { get; set; }
        public virtual DbSet<LineaAlbaran> LineasAlbaran { get; set; }
        public virtual DbSet<Producto> Productos { get; set; }
        public virtual DbSet<Direccion> Direcciones { get; set; }
        public virtual DbSet<Contacto> Contactos { get; set; }
        public virtual DbSet<Perfil> Perfiles { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<FormaPago> FormasPago { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }

        public override int SaveChanges()
        {
            return base.SaveChanges();
        }

        /// <summary>
        /// Reloads all elements for the given Entity
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public void ReloadEntities<T>() where T : class
        {
            
            var properties = this.GetType().GetProperties();
            foreach (var property in properties)
            {
                var value = property.GetValue(this);
                if (value.GetType() == typeof(DbSet<T>))
                {
                    foreach (var element in value as DbSet<T>)
                    {
                        base.Entry<T>(element).Reload();
                    }
                }
            }
        }

        public void BackUp(string path)
        {
            string sqlCommand = string.Format(@"BACKUP DATABASE [AdministracionAngela] TO  DISK = N'{0}\BackUp {1}.bak'", path, DateTime.Now.ToString("dd-MM-yyyy-HH-mm-ss"));
            Database.ExecuteSqlCommand(TransactionalBehavior.DoNotEnsureTransaction, sqlCommand);
        }
    }
}