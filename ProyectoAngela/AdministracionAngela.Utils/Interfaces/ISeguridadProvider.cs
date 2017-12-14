using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdministracionAngela.Utils.Models.Usuario;

namespace AdministracionAngela.Utils.Interfaces
{
    public interface ISeguridadProvider
    {
        bool UsuarioEsValido(string userName, string pass);
        void SaveUser(AltaUsuarioViewModel newUser);
        GestionUsuarioViewModel GetGestionUsuario();
    }
}
