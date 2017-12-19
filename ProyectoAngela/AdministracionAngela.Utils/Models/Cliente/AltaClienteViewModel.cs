using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministracionAngela.Utils.Models.Cliente
{
    public class AltaClienteViewModel
    {
        #region Datos Generales

        public long Id { get; set; }
        public int CodigoCliente { get; set; }
        public string NombreComercial { get; set; }
        public string NIF { get; set; }

        #region Direccion

        public string Direccion { get; set; }
        public string Poblacion { get; set; }
        public string Provincia { get; set; }
        public int CodigoPostal { get; set; }

        #endregion

        #region Contacto

        public int Telefono1 { get; set; }
        public int Telefono2 { get; set; }
        public int Fax { get; set; }
        public string Email { get; set; }
        public string PersonaDeContacto { get; set; }

        #endregion

        #endregion

        #region Datos Comerciales

        public int RiesgoMaximo { get; set; }
        public List<string> FormasDePago { get; set; }
        public string FormaDePagoSelected { get; set; }

        #endregion

        #region IVA

        public bool isGeneral { get; set; }
        public bool RecargoEquivalencia { get; set; }
        public bool UnionEuropea { get; set; }
        public bool Excento { get; set; }

        #endregion

        public AltaClienteViewModel()
        {

        }
    }
}
