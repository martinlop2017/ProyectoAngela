using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministracionAngela.Utils.Models.Usuario
{
    public class AltaUsuarioViewModel
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Nivel { get; set; }
        public bool Activo { get; set; }

        public AltaUsuarioViewModel()
        {

        }
    }
}
