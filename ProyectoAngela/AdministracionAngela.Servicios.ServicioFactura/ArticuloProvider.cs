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

        public bool DeleteArticulos(List<ArticuloViewModel> articulosToDelete)
        {
            var repositoryArticulosToDelete = MapToRepository.MapListOfArticuloViewModel(articulosToDelete);

            return this.repositoryArticulo.DeleteArticulos(repositoryArticulosToDelete);
        }

        public AltaArticuloViewModel GetAltaArticuloById(long articuloId)
        {
            var articuloFromRepository = this.repositoryArticulo.GetArticuloById(articuloId);

            return MapToViewModel.MapAltaArticulo(articuloFromRepository);
        }

        public GestionArticuloViewModel GetGestionArticulo()
        {
            var articulosFromRepository = this.repositoryArticulo.GetAllArticulos();
            return MapToViewModel.MapToGestionArticulo(articulosFromRepository);
        }

        public void SaveArticulo(AltaArticuloViewModel nuevoArticulo)
        {
            var articuloRepositorio = MapToRepository.MapAltaArticuloViewModel(nuevoArticulo);

            this.repositoryArticulo.SaveArticulo(articuloRepositorio);
        }

        public void UpdateArticulo(AltaArticuloViewModel nuevoArticulo)
        {
            var articuloRepository = MapToRepository.MapAltaArticuloViewModel(nuevoArticulo);
            this.repositoryArticulo.UpdateArticulo(articuloRepository);
        }
    }
}
