using AdministracionAngela.EFRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministracionAngela.Servicios.ServicioDatos.Repositorios
{
    public class RepositorioSistema : IRepositorioSistema
    {
        IAdministracionAngelaContext dbContext;

        public RepositorioSistema(IAdministracionAngelaContext dbContext)
        {
            this.dbContext = dbContext;
        }
    }
}
