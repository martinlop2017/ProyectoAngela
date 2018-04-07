using AdministracionAngela.Utils.Models.Usuario;

namespace AdministracionAngela.Utils.Interfaces
{
    public interface ISeguridadProvider
    {
        bool UsuarioEsValido(string userName, string pass);
        void SaveUser(AltaUsuarioViewModel newUser);
        void UpdateUser(AltaUsuarioViewModel newUser);
        GestionUsuarioViewModel GetGestionUsuario();
        void RemoveUser(string userToRemove);
    }
}
