using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdministracionAngela.EFRepository;

namespace AdministracionAngela.Servicios.ServicioDatos.Repositorios
{
    public class IVARepository : IRepositoryIVA
    {
        private IAdministracionAngelaContext dbContext;

        public IVARepository(IAdministracionAngelaContext dbContext)
        {
            this.dbContext = dbContext;
        }
    }
}
