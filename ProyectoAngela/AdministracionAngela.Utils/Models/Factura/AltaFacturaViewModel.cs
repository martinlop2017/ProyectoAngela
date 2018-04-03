using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdministracionAngela.Utils.Models.Factura
{
    public class AltaFacturaViewModel
    {
        public int NumeroFactura { get; set; }
        public long ClienteId { get; set; }
        public Dictionary<string, long> ClienteIdsAndDescripciones { get; set; }
        public Dictionary<string, long> ArticuloIdsAndDescripciones { get; set; }
        public long SelectedClientId => ClienteIdsAndDescripciones[SelectedClient];
        public string SelectedClient { get; set; }
        public string Fecha { get; set; }
        public string Lote { get; set; }
        public List<LineaFacturaViewModel> LineasFactura { get; set; }
        public List<LineaIVAViewModel> LineasIVA { get; set; }
        public bool FillIVA { get; set; }
        public bool FillRE { get; set; }
        public decimal TotalBase
        {
            get
            {
                return LineasIVA.Sum(i => i.BaseIVA);
            }
        }
        public decimal TotalIVA
        {
            get
            {
                return LineasIVA.Sum(i => i.ImporteIVA);
            }
        }
        public decimal TotalRecargoEquivalencia
        {
            get
            {
                return LineasIVA.Sum(i => i.ImporteRecargoEquivalencia);
            }
        }

        public decimal Total
        {
            get
            {
                if(TotalIVA == 0 && TotalBase == 0)
                {
                    return LineasFactura.Sum(x => x.Importe);
                }
                return TotalBase + TotalIVA + TotalRecargoEquivalencia;
            }
        }

        public int TotalCajas
        {
            get { return LineasFactura.Sum(lf => lf.Cajas); }
        }

        public AltaFacturaViewModel()
        {
            
        }
    }
}
