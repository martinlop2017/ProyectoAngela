using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministracionAngela.Utils.Models.FormaDePago
{
    public class GestionFormaDePagoViewModel
    {
        public BindingList<FormaDePagoViewModel> FormasDePago { get; set; }

        public GestionFormaDePagoViewModel()
        {
            this.FormasDePago = new BindingList<FormaDePagoViewModel>();
        }
    }
}
