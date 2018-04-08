﻿using AdministracionAngela.Utils.Models.Usuario;

namespace AdministracionAngela.Utils.Interfaces
{
    public interface ISeguridadProvider
    {
        void SaveUser(AltaUsuarioViewModel newUser);
        void UpdateUser(AltaUsuarioViewModel newUser);
        GestionUsuarioViewModel GetGestionUsuario();
        void RemoveUser(string userToRemove);
        UsuarioViewModel GetUser(string userName, string pass);
    }
}
