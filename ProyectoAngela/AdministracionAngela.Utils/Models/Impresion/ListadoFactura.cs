using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministracionAngela.Utils.Models.Impresion
{
    public class ListadoFactura
    {
        public int DeNumeroFactura { get; set; }
        public int ANumeroFactura { get; set; }
        public string DeFecha { get; set; }
        public string AFecha { get; set; }
        public string EmpresaEmisora { get; set; }
        public string FechaListado { get; set; }
        public long NumeroFactura { get; set; }
        public string FechaFactura { get; set; }
        public string Cliente { get; set; }
        public decimal Total { get; set; }
    }
}
