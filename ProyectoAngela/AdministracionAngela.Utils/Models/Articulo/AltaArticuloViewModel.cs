using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministracionAngela.Utils.Models.Articulo
{
    public class AltaArticuloViewModel
    {
        public long Id { get; set; }
        public int CodigoArticulo { get; set; }
        public string Descripcion { get; set; }
        public List<string> IVAs { get; set; }
        public string SelectedIVA { get; set; }
        public string CodigoFAO { get; set; }
        public string NombreCientifico { get; set; }
        public string ArtePesca { get; set; }
        public string ZonaCaptura { get; set; }
        public string Abreviacion { get; set; }
    }
}
