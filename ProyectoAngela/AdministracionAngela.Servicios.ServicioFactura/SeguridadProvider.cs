using AdministracionAngela.Servicios.ServicioDatos.Repositorios;
using AdministracionAngela.Utils.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministracionAngela.Servicios.ServicioDatos
{
    public class SeguridadProvider : ISeguridadProvider
    {
        IRepositorioSeguridad repositorioSeguridad;

        public SeguridadProvider(IRepositorioSeguridad repositorioSeguridad)
        {
            this.repositorioSeguridad = repositorioSeguridad;
        }

        public bool UsuarioEsValido(string userName, string pass)
        {
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
