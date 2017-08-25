using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdministracionAngela.CapaDePersistencia;

namespace AdministracionAngela.Servicios.ServicioDatos.Repositorios
{
    public class RepositorioCliente : IRepositorioCliente
    {
        IAdministracionAngelaContext dbContext;

        public RepositorioCliente(IAdministracionAngelaContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public List<Cliente> GetAllClients()
        {
            return this.dbContext.Clientes.ToList<Cliente>();
        }
    }
}
