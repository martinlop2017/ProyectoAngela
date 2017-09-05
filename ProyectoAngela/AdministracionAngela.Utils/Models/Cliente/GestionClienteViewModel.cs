using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministracionAngela.Utils.Models.Cliente
{
    public class GestionClienteViewModel
    {
        public BindingList<ClienteViewModel> Clientes { get; set; }

        public GestionClienteViewModel()
        {
            Clientes = new BindingList<ClienteViewModel>();
        }
    }
}
