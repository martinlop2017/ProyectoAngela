using AdministracionAngela.Servicios.ServicioDatos.Repositorios;
using AdministracionAngela.Utils.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdministracionAngela.Utils.Mappers;
using AdministracionAngela.Utils.Models.Perfil;

namespace AdministracionAngela.Servicios.ServicioDatos
{
    public class PerfilProvider : IPerfilProvider
    {
        private IRepositorioPerfil repositorioPerfil;

        public PerfilProvider(IRepositorioPerfil repositorioPerfil)
        {
            this.repositorioPerfil = repositorioPerfil;
        }

        public PerfilViewModel GetPerfil()
        {
            var perfilFromRepository = this.repositorioPerfil.GetPerfil();
            return MapToViewModel.MapToPerfilViewModel(perfilFromRepository);
        }
    }
}
