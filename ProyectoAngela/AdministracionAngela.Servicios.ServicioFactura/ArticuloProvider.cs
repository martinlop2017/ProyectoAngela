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
        private IRepositoryIVA repositorioIVA;

        public ArticuloProvider(IRepositorioArticulo repositoryArticulo, IRepositoryIVA repositorioIVA)
        {
            this.repositoryArticulo = repositoryArticulo;
            this.repositorioIVA = repositorioIVA;
        }

        public bool DeleteArticulos(List<ArticuloViewModel> articulosToDelete)
        {
            var repositoryArticulosToDelete = MapToRepository.MapListOfArticuloViewModel(articulosToDelete);

            return this.repositoryArticulo.DeleteArticulos(repositoryArticulosToDelete);
        }

        public AltaArticuloViewModel GetAltaArticuloById(long articuloId)
        {
            var ivas = this.repositorioIVA.GetAllIVAs();
            var articuloFromRepository = this.repositoryArticulo.GetArticuloById(articuloId);

            return MapToViewModel.MapAltaArticulo(articuloFromRepository, ivas);
        }

        public AltaArticuloViewModel GetAltaArticulo()
        {
            var ivas = this.repositorioIVA.GetAllIVAs();
            return new AltaArticuloViewModel()
            {
                IVAs = ivas.Select(iva => iva.Descripcion).ToList()
            };
        }

        public GestionArticuloViewModel GetGestionArticulo()
        {
            var articulosFromRepository = this.repositoryArticulo.GetAllArticulos();
            return MapToViewModel.MapToGestionArticulo(articulosFromRepository);
        }

        public bool SaveArticulo(AltaArticuloViewModel nuevoArticulo)
        {
            var iva = this.repositorioIVA.GetIVAByDescription(nuevoArticulo.SelectedIVA);
            var articuloRepositorio = MapToRepository.MapAltaArticuloViewModel(nuevoArticulo, iva);

            return this.repositoryArticulo.SaveArticulo(articuloRepositorio);
        }

        public bool UpdateArticulo(AltaArticuloViewModel nuevoArticulo)
        {
            var iva = this.repositorioIVA.GetIVAByDescription(nuevoArticulo.SelectedIVA);
            var articuloRepository = MapToRepository.MapAltaArticuloViewModel(nuevoArticulo, iva);
            return this.repositoryArticulo.UpdateArticulo(articuloRepository);
        }
    }
}
