using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministracionAngela.Utils.Models.Impresion
{
    public class FacturaIva
    {
        public string BaseImponible { get; set; }
        public decimal PorcentajeIVA { get; set; }
        public decimal ImporteIVA { get; set; }
        public decimal PorcentajeRE { get; set; }
        public decimal ImporteRE { get; set; }
        public decimal GastosSuplidos { get; set; }
    }
}
