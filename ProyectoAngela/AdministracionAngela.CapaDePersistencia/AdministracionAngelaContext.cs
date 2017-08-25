namespace AdministracionAngela.CapaDePersistencia
{
    using System.Data.Entity;

    public partial class AdministracionAngelaContext : DbContext, IAdministracionAngelaContext
    {
        public AdministracionAngelaContext()
            : base("name=AdministracionAngela")
        {
        }

        public AdministracionAngelaContext(string connectionString)
            :base(string.Format("name={0}",connectionString))
        {

        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Factura> Facturas { get; set; }
        public DbSet<IVA> IVAs { get; set; }
        public DbSet<LineaFactura> LineasFactura { get; set; }
        public DbSet<Producto> Productos { get; set; }

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
