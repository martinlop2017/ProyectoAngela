using System;

namespace AdministracionAngela.Utils.Models.Avisos
{
    public class AvisoViewModel
    {
        public long CodigoFactura { get; set; }
        public string Cliente { get; set; }
        public string FechaFactura { get; set; }
        public string FechaVencimiento { get; set; }
        public decimal Importe { get; set; }
        public string FechaCobro { get; set; }
        public bool Cobrada { get; set; }
    }
}
