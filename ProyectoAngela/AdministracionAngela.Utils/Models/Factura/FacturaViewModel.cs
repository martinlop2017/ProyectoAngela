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
        public long ClienteId { get; set; }
        public Dictionary<string, long> ClienteIdsAndDescripciones { get; set; }
        public Dictionary<string, long> ArticuloIdsAndDescripciones { get; set; }
        public string SelectedClient { get; set; }
        public string Fecha { get; set; }
        public List<LineaFacturaViewModel> LineasFactura { get; set; }
        public List<LineaIVAViewModel> LineasIVA { get; set; }
        public decimal TotalBase
        {
            get
            {
                return LineasIVA.Sum(i => i.BaseIVA);
            }
            set { }
        }
        public decimal TotalIVA
        {
            get
            {
                return LineasIVA.Sum(i => i.ImporteIVA);
            }
            set { }
        }
        public decimal TotalRecargoEquivalencia
        {
            get
            {
                return LineasIVA.Sum(i => i.ImporteRecargoEquivalencia);
            }
            set { }
        }

        public decimal Total
        {
            get { return TotalBase + TotalIVA + TotalRecargoEquivalencia; }
            set { }
        }

        public FacturaViewModel()
        {
            
        }
    }
}
