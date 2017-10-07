using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministracionAngela.Utils.Models.Factura
{
    public class ImpresionFactura
    {
        public int NumeroFactura { get; set; }
        public string NombreCliente { get; set; }
        public string DescripcionProducto { get; set; }
        public int precio { get; set; }

        public ImpresionFactura()
        {

        }
    }
}
