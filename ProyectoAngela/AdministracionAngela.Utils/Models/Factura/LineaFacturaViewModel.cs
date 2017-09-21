using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministracionAngela.Utils.Models.Factura
{
    public class LineaFacturaViewModel
    {
        public long ProductoId;
        public Dictionary<string, long> ProductoIdAndName { get; set; }
        public decimal Kgs { get; set; }
        public decimal Precio { get; set; }
        public decimal Importe { get; set; }

        public LineaFacturaViewModel()
        {
            
        }
    }
}
