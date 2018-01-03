﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministracionAngela.Utils.Models.Factura
{
    public class FacturaViewModel
    {
        public long CodigoFactura { get; set; }
        public string Cliente { get; set; }
        public decimal Base { get; set; }
        public decimal IVA { get; set; }
        public decimal RecargoEquivalencia { get; set; }
        public decimal Total { get; set; }
        public bool Impreso { get; set; }
        public bool IsAlbaran { get; set; }
    }
}
