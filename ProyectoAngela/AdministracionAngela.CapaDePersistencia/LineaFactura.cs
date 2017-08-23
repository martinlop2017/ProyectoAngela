namespace AdministracionAngela.CapaDePersistencia
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LineaFactura")]
    public partial class LineaFactura
    {
        public long Id { get; set; }

        public long NumeroFactura { get; set; }

        public long CodigoProducto { get; set; }

        public int IVAId { get; set; }

        public int? Unidades { get; set; }

        public decimal? Precio { get; set; }

        public string Descripcion { get; set; }

        public virtual Factura Factura { get; set; }

        public virtual IVA IVA { get; set; }

        public virtual Producto Producto { get; set; }
    }
}
