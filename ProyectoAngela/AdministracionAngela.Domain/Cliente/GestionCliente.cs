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
        public BindingList<ClienteDomain> Clientes { get; set; }

        public GestionCliente()
        {
            Clientes = new BindingList<ClienteDomain>();
        }
    }
}
