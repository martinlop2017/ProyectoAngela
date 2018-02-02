using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministracionAngela.Utils.Models.Perfil
{
    public class PerfilViewModel
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string NIF { get; set; }
        public string Direccion { get; set; }
        public int CodigoPostal { get; set; }
        public string Poblacion { get; set; }
        public string Provincia { get; set; }
        public string PersonaContacto { get; set; }
        public int Telefono1 { get; set; }
        public int Telefono2 { get; set; }
        public int Fax { get; set; }
        public string Email { get; set; }
        public string Iban1 { get; set; }
        public string Iban2 { get; set; }
        public string Iban3 { get; set; }
        public string Iban4 { get; set; }
        public string Iban5 { get; set; }
        public string Iban6 { get; set; }
        public string LogoPath { get; set; }

        public PerfilViewModel()
        {

        }

    }
}
