namespace AdministracionAngela.CapaDePersistencia
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DBAdministracionAngela : DbContext
    {
        public DBAdministracionAngela()
            : base("name=DBAdministracionAngela")
        {
        }

        public virtual DbSet<Cliente> Cliente { get; set; }
        public virtual DbSet<Factura> Factura { get; set; }
        public virtual DbSet<IVA> IVA { get; set; }
        public virtual DbSet<LineaFactura> LineaFactura { get; set; }
        public virtual DbSet<Producto> Producto { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cliente>()
                .HasMany(e => e.Factura)
                .WithRequired(e => e.Cliente)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Factura>()
                .HasMany(e => e.LineaFactura)
                .WithRequired(e => e.Factura)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<IVA>()
                .HasMany(e => e.LineaFactura)
                .WithRequired(e => e.IVA)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<LineaFactura>()
                .Property(e => e.Precio)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Producto>()
                .HasMany(e => e.LineaFactura)
                .WithRequired(e => e.Producto)
                .HasForeignKey(e => e.CodigoProducto)
                .WillCascadeOnDelete(false);
        }
    }
}
