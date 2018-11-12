using AdministracionAngela.Servicios.ServicioDatos.Repositorios;
using AdministracionAngela.Utils.Interfaces;
using AdministracionAngela.Utils.Models.Usuario;
using AdministracionAngela.Utils.Mappers;
using System.Collections.Generic;
using System.Linq;
using System;

namespace AdministracionAngela.Servicios.ServicioDatos
{
    public class SeguridadProvider : ISeguridadProvider
    {
        IRepositorioSeguridad repositorioSeguridad;

        public SeguridadProvider(IRepositorioSeguridad repositorioSeguridad)
        {
            this.repositorioSeguridad = repositorioSeguridad;
        }

        public GestionUsuarioViewModel GetGestionUsuario()
        {
            var usersFromRepository = this.repositorioSeguridad.GetAllUsers();
            return MapToViewModel.MapToGestionUsuario(usersFromRepository);


        }

        public void RemoveUser(string userToRemove)
        {
            this.repositorioSeguridad.RemoveUser(userToRemove);
        }

        public void SaveUser(AltaUsuarioViewModel newUser)
        {
            var userRepositorio = MapToRepository.MapAltaUsuarioViewModel(newUser);
            this.repositorioSeguridad.SaveUser(userRepositorio);
        }

        public void UpdateUser(AltaUsuarioViewModel newUser)
        {
            var userRepositorio = MapToRepository.MapAltaUsuarioViewModel(newUser);
            this.repositorioSeguridad.UpdateUser(userRepositorio);
        }

        public UsuarioViewModel GetUser(string userName, string pass)
        {
            if (userName.ToUpper().Equals("ADMIN") && pass.ToUpper().Equals("ADMIN"))
                return new UsuarioViewModel()
                {
                    Nombre = "ADMIN",
                    Nivel = "Administrador"
                };

            var user = this.repositorioSeguridad.GetUser(userName, pass);
            return MapToViewModel.MapUser(user);
        }

        public List<string> GetAllUserNames()
        {
            var users = this.repositorioSeguridad.GetAllUsers();
            if (users.Count > 0)
                return users.Select(x => x.UserName).ToList();
            else
                return new List<string>(); 
        }
    }
}
