﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministracionAngela.Utils.Models.Factura
{
    public class LineaIVAViewModel
    {
        public decimal BaseIVA { get; set; }
        public decimal PorcentajeIVA { get; set; }
        public decimal ImporteIVA { get; set; }
        public decimal PorcentajeRecargoEquivalencia { get; set; }
        public decimal ImporteRecargoEquivalencia { get; set; }

        public LineaIVAViewModel()
        {
            
        }
    }
}