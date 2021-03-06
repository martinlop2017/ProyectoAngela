//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AdministracionAngela.EFRepository
{
    using System;
    using System.Collections.Generic;
    
    public partial class Albaran
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Albaran()
        {
            this.LineaAlbaran = new HashSet<LineaAlbaran>();
        }
    
        public long Id { get; set; }
        public long NumeroAlbaran { get; set; }
        public Nullable<long> ClienteId { get; set; }
        public Nullable<System.DateTime> Fecha { get; set; }
        public Nullable<decimal> TotalRecargoEquivalencia { get; set; }
        public Nullable<decimal> TotalBase { get; set; }
        public Nullable<decimal> Total { get; set; }
        public Nullable<bool> Impreso { get; set; }
        public string EtiquetaLote { get; set; }
        public bool IsAlbaran { get; set; }
        public Nullable<decimal> TotalIVA { get; set; }
        public Nullable<bool> Facturado { get; set; }
        public Nullable<bool> Cobrado { get; set; }
    
        public virtual Cliente Cliente { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LineaAlbaran> LineaAlbaran { get; set; }
    }
}
