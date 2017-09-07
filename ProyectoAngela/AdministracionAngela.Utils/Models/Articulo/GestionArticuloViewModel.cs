using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministracionAngela.Utils.Models.Articulo
{
    public class GestionArticuloViewModel
    {
        public BindingList<ArticuloViewModel> Articulos { get; set; }

        public GestionArticuloViewModel()
        {
            
        }
    }
}
