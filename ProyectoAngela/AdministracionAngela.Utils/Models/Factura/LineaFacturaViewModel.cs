using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministracionAngela.Utils.Models.Factura
{
    public class LineaFacturaViewModel
    {
        public int ProductoId { get; set; }
        public string NombreProducto { get; set; }
        public int Unidades { get; set; }
        public decimal Precio { get; set; }
        public decimal Importe { get; set; }

        public LineaFacturaViewModel()
        {
            
        }
    }
}
