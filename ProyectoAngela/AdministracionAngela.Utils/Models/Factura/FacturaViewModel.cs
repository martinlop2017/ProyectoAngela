using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministracionAngela.Utils.Models.Factura
{
    public class FacturaViewModel
    {
        public long CodigoFactura { get; set; }
        public string Cliente { get; set; }
        public decimal Base { get; set; }
        public string IVA { get; set; }
        public string Importe { get; set; }
        public bool Impreso { get; set; }
    }
}
