namespace AdministracionAngela.CapaDePersistencia
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Factura")]
    public partial class Factura
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Factura()
        {
            LineaFactura = new HashSet<LineaFactura>();
        }

        [Key]
        public long NumeroFactura { get; set; }

        public long ClienteId { get; set; }

        public DateTime? Fecha { get; set; }

        public decimal? RecargoEquivalencia { get; set; }

        public long? Base { get; set; }

        public long? Total { get; set; }

        public virtual Cliente Cliente { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LineaFactura> LineaFactura { get; set; }
    }
}
