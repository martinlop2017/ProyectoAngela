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
    
    public partial class Cliente
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Cliente()
        {
            this.Factura = new HashSet<Factura>();
        }
    
        public long Id { get; set; }
        public int CodigoCliente { get; set; }
        public Nullable<int> DireccionId { get; set; }
        public Nullable<int> ContactoId { get; set; }
        public string CIF { get; set; }
        public string NIF { get; set; }
        public string Nombre { get; set; }
        public decimal RiesgoMaximo { get; set; }
        public string FormaDePago { get; set; }
        public bool IsGeneral { get; set; }
        public bool RecargoEquivalencia { get; set; }
        public bool UnionEuropea { get; set; }
        public bool Excento { get; set; }
    
        public virtual Contacto Contacto { get; set; }
        public virtual Direccion Direccion { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Factura> Factura { get; set; }
    }
}
