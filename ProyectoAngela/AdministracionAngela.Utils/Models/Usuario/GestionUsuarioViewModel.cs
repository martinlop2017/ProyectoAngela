using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministracionAngela.Utils.Models.Usuario
{
    public class GestionUsuarioViewModel
    {
        public BindingList<UsuarioViewModel> Usuarios { get; set; }

        public GestionUsuarioViewModel()
        {
            this.Usuarios = new BindingList<UsuarioViewModel>();
        }
    }
}
