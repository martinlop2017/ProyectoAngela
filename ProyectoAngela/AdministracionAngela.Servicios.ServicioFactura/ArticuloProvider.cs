using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdministracionAngela.Servicios.ServicioDatos.Repositorios;
using AdministracionAngela.Utils.Interfaces;
using AdministracionAngela.Utils.Mappers;
using AdministracionAngela.Utils.Models.Articulo;

namespace AdministracionAngela.Servicios.ServicioDatos
{
    public class ArticuloProvider : IArticuloProvider
    {
        private IRepositorioArticulo repositoryArticulo;

        public ArticuloProvider(IRepositorioArticulo repositoryArticulo)
        {
            this.repositoryArticulo = repositoryArticulo;
        }

        public void SaveArticulo(AltaArticuloViewModel nuevoArticulo)
        {
            var articuloRepositorio = MapToRepository.MapAltaArticuloViewModel(nuevoArticulo);
        }
    }
}
