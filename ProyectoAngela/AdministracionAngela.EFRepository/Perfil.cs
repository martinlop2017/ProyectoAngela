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
    
    public partial class Perfil
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string NIF { get; set; }
        public string CIF { get; set; }
        public Nullable<int> DireccionId { get; set; }
        public Nullable<int> ContactoId { get; set; }
        public string Iban { get; set; }
        public string LogoPath { get; set; }
        public string Iban1 { get; set; }
        public string Iban2 { get; set; }
        public string Iban3 { get; set; }
        public string Iban4 { get; set; }
        public string Iban5 { get; set; }
        public string Iban6 { get; set; }
    
        public virtual Contacto Contacto { get; set; }
        public virtual Direccion Direccion { get; set; }
    }
}
