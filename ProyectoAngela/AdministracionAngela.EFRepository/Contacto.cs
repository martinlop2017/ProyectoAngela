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
    
    public partial class Contacto
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Contacto()
        {
            this.Cliente = new HashSet<Cliente>();
        }
    
        public int Id { get; set; }
        public Nullable<int> Telefono1 { get; set; }
        public Nullable<int> Telefono2 { get; set; }
        public Nullable<int> Fax { get; set; }
        public string Email { get; set; }
        public string PersonaContacto { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cliente> Cliente { get; set; }
    }
}