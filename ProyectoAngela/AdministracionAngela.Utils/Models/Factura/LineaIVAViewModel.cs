using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministracionAngela.Utils.Models.Factura
{
    public class LineaIVAViewModel
    {
        public int IvaId { get; set; }
        public decimal BaseIVA { get; set; }
        public decimal PorcentajeIVA { get; set; }
        public decimal ImporteIVA
        {
            get
            {
                return Decimal.Round(BaseIVA * (PorcentajeIVA / 100), 2);
            }
            set { }
        }
        public decimal PorcentajeRecargoEquivalencia { get; set; }
        public decimal ImporteRecargoEquivalencia
        {
            get
            {
                return Decimal.Round(BaseIVA * (PorcentajeRecargoEquivalencia / 100), 2);
            }
            set { }
        }

        public LineaIVAViewModel()
        {

        }
    }
}
