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
            return this.dbContext.Productos.ToList<Producto>();
        }

        public void SaveArticulo(Producto articuloRepositorio)
        {
            try
            {
                this.dbContext.Productos.Add(articuloRepositorio);
                this.dbContext.SaveChanges();
            }
            catch(Exception exp)
            {

            }
        }
    }
}
