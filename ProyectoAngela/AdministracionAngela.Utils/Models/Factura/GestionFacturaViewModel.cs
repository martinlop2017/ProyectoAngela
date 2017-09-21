using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministracionAngela.Utils.Models.Factura
{
    public class GestionFacturaViewModel
    {
        public BindingList<FacturaDataGridViewModel> Facturas { get; set; }

        public GestionFacturaViewModel()
        {
            this.Facturas = new BindingList<FacturaDataGridViewModel>();
        }
    }
}
