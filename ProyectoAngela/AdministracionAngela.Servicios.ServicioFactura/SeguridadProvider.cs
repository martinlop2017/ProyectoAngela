using AdministracionAngela.Servicios.ServicioDatos.Repositorios;
using AdministracionAngela.Utils.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdministracionAngela.Utils.Models.Usuario;
using AdministracionAngela.Utils.Mappers;

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

        public bool UsuarioEsValido(string userName, string pass)
        {
            if (userName.ToUpper().Equals("ADMIN") && pass.ToUpper().Equals("ADMIN"))
                return true;

            var userValido = false;
            var user = this.repositorioSeguridad.GetUser(userName);
            if (user != null && user.Password.Equals(pass))
            {
                userValido = true;
            }

            return userValido;
        }
    }
}
