using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministracionAngela.Utils.Models.Cliente
{
    public class ClienteViewModel
    {
        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public string NIF { get; set; }

        public ClienteViewModel()
        {
        }
    }
}
