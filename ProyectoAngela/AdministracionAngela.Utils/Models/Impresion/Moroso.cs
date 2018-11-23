using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministracionAngela.Utils.Models.Impresion
{
    public class Moroso
    {
        public string CodigoFactura { get; set; }
        public string NombreCliente { get; set; }
        public string FechaFactura { get; set; }
        public string FechaVencimiento { get; set; }
        public decimal Importe { get; set; }
        public string FechaCobro { get; set; }
        public bool Cobrada { get; set; }
        public string desdecliente { get; set; }
        public string hastacliente { get; set; }
        public string desdefecha { get; set; }
        public string hastafecha { get; set; }
    }
}
