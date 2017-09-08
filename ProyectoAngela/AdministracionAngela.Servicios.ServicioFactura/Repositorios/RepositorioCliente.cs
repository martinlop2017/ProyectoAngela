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
            catch (Exception exp)
            {

            }
        }

        public void UpdateClient(Cliente newClient)
        {
            try
            {
                var clientToUpdate = this.dbContext.Clientes.Find(newClient.Id);
                if (clientToUpdate != null)
                {
                    clientToUpdate.CodigoCliente = newClient.CodigoCliente;
                    clientToUpdate.NIF = newClient.NIF;
                    clientToUpdate.CIF = string.Empty;
                    clientToUpdate.Direccion = newClient.Direccion;
                    clientToUpdate.Nombre = newClient.Nombre;
                    clientToUpdate.Poblacion = newClient.Poblacion;
                    clientToUpdate.Provincia = newClient.Provincia;
                    clientToUpdate.CodigoPostal = newClient.CodigoPostal;
                    clientToUpdate.Telefono1 = newClient.Telefono1;
                    clientToUpdate.Telefono2 = newClient.Telefono2;
                    clientToUpdate.Fax = newClient.Fax;
                    clientToUpdate.Email = newClient.Email;
                    clientToUpdate.PersonaDeContacto = newClient.PersonaDeContacto;
                    clientToUpdate.RiesgoMaximo = newClient.RiesgoMaximo;
                    clientToUpdate.FormaDePago = newClient.FormaDePago;
                    clientToUpdate.IsGeneral = newClient.IsGeneral;
                    clientToUpdate.RecargoEquivalencia = newClient.RecargoEquivalencia;
                    clientToUpdate.UnionEuropea = newClient.UnionEuropea;
                    clientToUpdate.Excento = newClient.Excento;

                    dbContext.SaveChanges();
                }
            }
            catch (Exception exp)
            {

            }
        }
    }
}
