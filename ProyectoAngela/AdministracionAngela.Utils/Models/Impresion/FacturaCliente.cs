using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministracionAngela.Utils.Models.Impresion
{
    
    public class FacturaCliente
    {
        public int NumeroFactura { get; set; }
        public DateTime Fecha { get; set; }
        public string Dni { get; set; }
        public long CodigoArticulo { get; set; }
        public string Descripcion { get; set; }
        public int Bultos { get; set; }
        public decimal Kgs { get; set; }
        public decimal Precio { get; set; }
        public decimal Importe { get; set; }
        public decimal Total { get; set; }
        public string LineaDireccion { get; set; }
        public string Provincia { get; set; }
        public string Poblacion { get; set; }
        public string CodigoPostal { get; set; }
        public string NombreEmpresa { get; set; }
        public string DniPerfil { get; set; }
        public string CodigoPostalPerfil { get; set; }
        public string ProvinciaPerfil { get; set; }
        public string PoblacionPerfil { get; set; }
        public string LineaDireccionPerfil { get; set; }
        public string EmailPerfil { get; set; }
        public long TelefonoPerfil { get; set; }
        public long FaxPerfil { get; set; }
        public string ZonaCAptura { get; set; }
        public string Arte { get; set; }
        public string FAO { get; set; }
        public string NombreCientifico { get; set; }
        public string Abreviacion { get; set; }
        public string NombreCliente { get; set; }
        public string EtiquetaLote { get; set; }
        public string NumeroCuenta { get; set; }
        public string FormaPago { get; set; }
    }
}
