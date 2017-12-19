using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdministracionAngela.EFRepository;

namespace AdministracionAngela.Servicios.ServicioDatos.Repositorios
{
    public class RepositorioArticulo : IRepositorioArticulo
    {
        IAdministracionAngelaContext dbContext;

        public RepositorioArticulo(IAdministracionAngelaContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public bool DeleteArticulos(List<Producto> repositoryArticulosToDelete)
        {
            try
            {
                var idsToDelete = repositoryArticulosToDelete.Select(a => a.Id);
                var articulostoDelete = this.dbContext.Productos.Where(a => idsToDelete.Contains(a.Id));

                this.dbContext.Productos.RemoveRange(articulostoDelete);
                this.dbContext.SaveChanges();
                return true;
            }
            catch (Exception exp)
            {
                return false;
            }
        }

        public List<Producto> GetAllArticulos()
        {
            this.dbContext.ReloadEntities<Producto>();
            return this.dbContext.Productos.ToList<Producto>();
        }

        public Producto GetArticuloById(long articuloId)
        {
            return this.dbContext.Productos.Find(articuloId);
        }

        public bool SaveArticulo(Producto articuloRepositorio)
        {
            var Ok = true;
            try
            {
                this.dbContext.Productos.Add(articuloRepositorio);
                this.dbContext.SaveChanges();
            }
            catch(Exception exp)
            {
                Ok = false;
            }

            return Ok;
        }

        public bool UpdateArticulo(Producto articuloRepository)
        {
            var Ok = true;

            try
            {
                var articuloToupdate = this.dbContext.Productos.Find(articuloRepository.Id);

                if (articuloToupdate != null)
                {
                    articuloToupdate.CodigoProducto = articuloRepository.CodigoProducto;
                    articuloToupdate.Descripcion = articuloRepository.Descripcion;
                    articuloToupdate.ZonaCaptura = articuloRepository.ZonaCaptura;
                    articuloToupdate.ArtePesca = articuloRepository.ArtePesca;
                    articuloToupdate.FAO = articuloRepository.FAO;
                    articuloToupdate.NombreCientifico = articuloRepository.NombreCientifico;

                    this.dbContext.SaveChanges();
                }
            }
            catch(Exception exp)
            {
                Ok = false;
            }

            return Ok;
        }
    }
}
