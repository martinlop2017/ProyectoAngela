using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministracionAngela.Utils.Models.Factura
{
    public class ImpresionFactura
    {
        public string NombreEmisor { get; set; }
        public string DNIEmisor { get; set; }
        public string DireccionEmisor { get; set; }
        public string TelefonoEmisor { get; set; }
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
