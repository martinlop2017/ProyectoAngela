using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministracionAngela.Domain
{
    public class ClienteDomain
    {
        public long Codigo { get; set; }
        public string Nombre { get; set; }
        public long NIF { get; set; }

        public ClienteDomain()
        {
        }
    }
}
