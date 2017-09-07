using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministracionAngela.Utils.Models.IVA
{
    public class GestionIVAViewModel
    {
        public BindingList<IVAViewModel> IVAs { get; set; }

        public GestionIVAViewModel()
        {
            this.IVAs = new BindingList<IVAViewModel>();
        }
    }
}
