using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministracionAngela.Domain
{
    public class GestionCliente
    {
        public BindingList<ClienteDomain> clientes { get; set; }

        public GestionCliente()
        {
            clientes = new BindingList<ClienteDomain>();
        }
    }
}
