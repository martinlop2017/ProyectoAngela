//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class Albaran
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Albaran()
        {
            this.LineaAlbaran = new HashSet<LineaAlbaran>();
        }
    
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
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LineaAlbaran> LineaAlbaran { get; set; }
        public virtual Cliente Cliente { get; set; }
    }
}
