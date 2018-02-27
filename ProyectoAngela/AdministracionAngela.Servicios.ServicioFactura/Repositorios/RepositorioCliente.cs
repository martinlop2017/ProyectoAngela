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

        public void DeleteAddressByClientIds(List<Cliente> repositoryClientstoDelete)
        {
            try
            {
                var clientIds = repositoryClientstoDelete.Select(c => c.Id);
                var addressesToDelete = this.dbContext.Clientes.Where(c => clientIds.Contains(c.Id)).Select(c => c.Direccion).ToList();

                this.dbContext.Direcciones.RemoveRange(addressesToDelete);
                this.dbContext.SaveChanges();
            }
            catch (Exception exp)
            {

            }
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

        public void DeleteContactsByClientIds(List<Cliente> repositoryClientstoDelete)
        {
            try
            {
                var clientIds = repositoryClientstoDelete.Select(c => c.Id);
                var contactsToDelete = this.dbContext.Clientes.Where(c => clientIds.Contains(c.Id)).Select(c => c.Contacto).ToList();

                this.dbContext.Contactos.RemoveRange(contactsToDelete);
                this.dbContext.SaveChanges();
            }
            catch (Exception exp)
            {

            }
        }

        public List<Cliente> GetAllClients()
        {
            this.dbContext.ReloadEntities<Cliente>();
            return this.dbContext.Clientes.ToList<Cliente>();
        }

        public Cliente GetClientById(long clienteId)
        {
            return this.dbContext.Clientes.Find(clienteId);
        }

        public Cliente GetLastClient()
        {
            return this.dbContext.Clientes.OrderByDescending(c => c.Id).FirstOrDefault();
        }

        public bool SaveClient(Cliente newClient)
        {
            var returned = false;
            try
            {
                this.dbContext.Clientes.Add(newClient);
                this.dbContext.SaveChanges();
                returned = true;
            }
            catch (Exception exp)
            {
                returned = false;
            }

            return returned;
        }

        public bool UpdateClient(Cliente newClient)
        {
            var Ok = false;

            try
            {
                var clientToUpdate = this.dbContext.Clientes.Find(newClient.Id);
                if (clientToUpdate != null)
                {
                    clientToUpdate.CodigoCliente = newClient.CodigoCliente;
                    clientToUpdate.NIF = newClient.NIF;
                    clientToUpdate.CIF = string.Empty;
                    if(clientToUpdate.Direccion == null)
                    {
                        clientToUpdate.Direccion = newClient.Direccion;
                        clientToUpdate.DireccionId = newClient.DireccionId;
                    }
                    else
                    {
                        clientToUpdate.Direccion.LineaDireccion = newClient.Direccion.LineaDireccion;
                        clientToUpdate.Direccion.Poblacion = newClient.Direccion.Poblacion;
                        clientToUpdate.Direccion.Provincia = newClient.Direccion.Provincia;
                        clientToUpdate.Direccion.CodigoPostal = newClient.Direccion.CodigoPostal;
                    }
                    clientToUpdate.Nombre = newClient.Nombre;
                    if(clientToUpdate.Contacto == null)
                    {
                        clientToUpdate.Contacto = newClient.Contacto;
                        clientToUpdate.ContactoId = newClient.ContactoId;
                    }
                    else
                    {
                        clientToUpdate.Contacto.Telefono1 = newClient.Contacto.Telefono1;
                        clientToUpdate.Contacto.Telefono2 = newClient.Contacto.Telefono2;
                        clientToUpdate.Contacto.Fax = newClient.Contacto.Fax;
                        clientToUpdate.Contacto.Email = newClient.Contacto.Email;
                        clientToUpdate.Contacto.Email2 = newClient.Contacto.Email2;
                        clientToUpdate.Contacto.Email3 = newClient.Contacto.Email3;
                        clientToUpdate.Contacto.Email4 = newClient.Contacto.Email4;
                        clientToUpdate.Contacto.PersonaContacto = newClient.Contacto.PersonaContacto;
                    }
                    clientToUpdate.RiesgoMaximo = newClient.RiesgoMaximo;
                    clientToUpdate.FormaDePagoId = newClient.FormaDePagoId;
                    clientToUpdate.FormaPago = newClient.FormaPago;
                    clientToUpdate.IsGeneral = newClient.IsGeneral;
                    clientToUpdate.RecargoEquivalencia = newClient.RecargoEquivalencia;
                    clientToUpdate.UnionEuropea = newClient.UnionEuropea;
                    clientToUpdate.Excento = newClient.Excento;

                    dbContext.SaveChanges();

                    Ok = true;
                }
            }
            catch (Exception exp)
            {
                Ok = false;
            }

            return Ok;
        }
    }
}
