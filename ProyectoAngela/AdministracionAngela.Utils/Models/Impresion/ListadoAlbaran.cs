using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministracionAngela.Utils.Models.Impresion
{
    public class ListadoAlbaran
    {
        public int DeNumeroAlbaran { get; set; }
        public int ANumeroAlbaran { get; set; }
        public string DeFecha { get; set; }
        public string AFecha { get; set; }
        public string EmpresaEmisora { get; set; }
        public string FechaListado { get; set; }
        public long NumeroAlbaran { get; set; }
        public string FechaAlbaran { get; set; }
        public string Cliente { get; set; }
        public decimal Total { get; set; }
    }
}
