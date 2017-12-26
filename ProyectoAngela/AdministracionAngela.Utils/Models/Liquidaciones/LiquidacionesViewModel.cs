using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministracionAngela.Utils.Models.Liquidaciones
{
    public class LiquidacionesViewModel
    {
        public BindingList<LineaLiquidacionViewModel> LineasLiquidacion { get; set; }

        public LiquidacionesViewModel()
        {
            this.LineasLiquidacion = new BindingList<LineaLiquidacionViewModel>();
        }
    }
}
