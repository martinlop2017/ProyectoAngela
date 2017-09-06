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
        public string CIF { get; set; }
        public string NIF { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Poblacion { get; set; }
        public string Provincia { get; set; }
        public int CodigoPostal { get; set; }
        public int Telefono1 { get; set; }
        public Nullable<int> Telefono2 { get; set; }
        public Nullable<int> Fax { get; set; }
        public string Email { get; set; }
        public string PersonaDeContacto { get; set; }
        public decimal RiesgoMaximo { get; set; }
        public string FormaDePago { get; set; }
        public bool IsGeneral { get; set; }
        public bool RecargoEquivalencia { get; set; }
        public bool UnionEuropea { get; set; }
        public bool Excento { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Factura> Factura { get; set; }
    }
}
