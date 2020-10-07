using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministracionAngela.Utils.Models.Exports
{
    public class FacturaExport
    {
        public string Cliente { get; set; }
        public string CodigoPostal { get; set; }
        public decimal Base { get; set; }
        public decimal IVA { get; set; }
        public decimal Total { get; set; }
    }
}
