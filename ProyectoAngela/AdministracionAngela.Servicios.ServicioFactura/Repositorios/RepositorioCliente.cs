using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdministracionAngela.EFRepository;
using AdministracionAngela.Utils.Models.Cliente;

namespace AdministracionAngela.Servicios.ServicioDatos.Repositorios
{
    public class RepositorioCliente : IRepositorioCliente
    {
        IAdministracionAngelaContext dbContext;

        public RepositorioCliente(IAdministracionAngelaContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public bool DeleteClients(List<Cliente> repositoryClientstoDelete)
        {
            try
            {
                var idsToDelete = repositoryClientstoDelete.Select(c => c.Id);
                var clientestoDelete = this.dbContext.Clientes.Where(c => idsToDelete.Contains(c.Id));

                this.dbContext.Clientes.RemoveRange(clientestoDelete);
                this.dbContext.SaveChanges();
                return true;
            }
            catch (Exception exp)
            {
                return false;
            }
        }

        public List<Cliente> GetAllClients()
        {
            return this.dbContext.Clientes.ToList<Cliente>();
        }

        public Cliente GetClientById(long clienteId)
        {
            return this.dbContext.Clientes.SingleOrDefault(c => c.Id == clienteId);
        }

        public Cliente GetLastClient()
        {
            return this.dbContext.Clientes.OrderByDescending(c => c.Id).FirstOrDefault();
        }

        public void SaveClient(Cliente newClient)
        {
            try
            {
                this.dbContext.Clientes.Add(newClient);
                this.dbContext.SaveChanges();
            }
            catch(Exception exp)
            {

            }
        }
    }
}
