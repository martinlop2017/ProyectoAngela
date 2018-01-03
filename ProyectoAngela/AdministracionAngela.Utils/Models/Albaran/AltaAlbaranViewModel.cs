using AdministracionAngela.Utils.Models.Factura;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministracionAngela.Utils.Models.Albaran
{
    public class AltaAlbaranViewModel
    {
        public int Id { get; set; }
        public long ClienteId { get; set; }
        public Dictionary<string, long> ClienteIdsAndDescripciones { get; set; }
        public Dictionary<string, long> ArticuloIdsAndDescripciones { get; set; }
        public string SelectedClient { get; set; }
        public string Fecha { get; set; }
        public string Lote { get; set; }
        public bool IsAlbaran { get; set; }
        public List<LineaAlbaranViewModel> LineasAlbaran { get; set; }
        public List<LineaIVAViewModel> LineasIVA { get; set; }
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
            get { return TotalBase + TotalIVA + TotalRecargoEquivalencia; }
        }

        public int TotalCajas
        {
            get { return LineasAlbaran.Sum(lf => lf.Cajas); }
        }

        public AltaAlbaranViewModel()
        {

        }
    }
}
