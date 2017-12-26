using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministracionAngela.Utils.Models.Liquidaciones
{
    public class LineaFacturaLiquidacion
    {
        public string CodigoArticulo { get; set; }
        public string Concepto { get; set; }
        public int Bultos { get; set; }
        public int Kilos { get; set; }
        public decimal PrecioMedio { get; set; }
        public decimal Total { get; set; }

        public LineaFacturaLiquidacion()
        {

        }
    }
}
