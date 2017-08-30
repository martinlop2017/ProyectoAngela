using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministracionAngela.Utils.Models.Cliente
{
    public class AltaClienteViewModel
    {
        #region Datos Generales
        public long CodigoCliente { get; set; }
        public string NombreComercial { get; set; }
        public long NIF { get; set; }
        #region Direccion
        public string Direccion { get; set; }
        public string Poblacion { get; set; }
        public string Provincia { get; set; }
        public int CodigoPostal { get; set; }
        #endregion
        #region Contacto
        public int Telefono1 { get; set; }
        public int Telefono2 { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public string PersonaDeContacto { get; set; }
        #endregion
        #endregion
        #region Datos Comerciales
        public Decimal RiesgoMaximo { get; set; }
        public string FormaDePago { get; set; }
        //Falta por meter el IVA
        #endregion
    }
}
