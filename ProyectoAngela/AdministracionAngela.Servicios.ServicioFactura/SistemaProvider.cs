using AdministracionAngela.Servicios.ServicioDatos.Repositorios;
using AdministracionAngela.Utils.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministracionAngela.Servicios.ServicioDatos
{
    public class SistemaProvider : ISistemaProvider
    {
        private IRepositorioSistema repositorioSistema;

        public SistemaProvider(IRepositorioSistema reposirotiorSistema)
        {
            this.repositorioSistema = repositorioSistema;
        }


    }
}
