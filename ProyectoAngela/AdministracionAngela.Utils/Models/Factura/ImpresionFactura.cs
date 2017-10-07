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
        public decimal Precio { get; set; }

        //fecha, realizador: dni, nombre, direccion, 
        //receptor: dni, nombre, direccion
        //nombreProducto, unidades, precio, total
        //base, iva, RE, total

        public ImpresionFactura()
        {

        }
    }
}
