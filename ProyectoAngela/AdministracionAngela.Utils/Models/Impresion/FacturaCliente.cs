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
    }
}
