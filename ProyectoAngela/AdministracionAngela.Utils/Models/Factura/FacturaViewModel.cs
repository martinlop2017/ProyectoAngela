using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdministracionAngela.Utils.Models.Factura
{
    public class FacturaViewModel
    {
        public int Id { get; set; }
        public int ClienteId { get; set; }
        public Dictionary<string, long> ClienteIdsAndDescripciones { get; set; }
        public DateTime Fecha { get; set; }
        public List<LineaFacturaViewModel> LineasFactura { get; set; }
        public decimal TotalBase { get; set; }
        public decimal TotalIVA { get; set; }
        public decimal TotalRecargoEquivalencia { get; set; }

        public FacturaViewModel()
        {
            
        }
    }
}
