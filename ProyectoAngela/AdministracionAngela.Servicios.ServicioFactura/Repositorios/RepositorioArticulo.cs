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

        public void SaveArticulo(Producto articuloRepositorio)
        {
            throw new NotImplementedException();
        }
    }
}
