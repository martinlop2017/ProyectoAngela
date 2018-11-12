using AdministracionAngela.Utils.Models.Usuario;
using System.Collections.Generic;

namespace AdministracionAngela.Utils.Interfaces
{
    public interface ISeguridadProvider
    {
        void SaveUser(AltaUsuarioViewModel newUser);
        void UpdateUser(AltaUsuarioViewModel newUser);
        GestionUsuarioViewModel GetGestionUsuario();
        void RemoveUser(string userToRemove);
        UsuarioViewModel GetUser(string userName, string pass);
        List<string> GetAllUserNames();
    }
}
