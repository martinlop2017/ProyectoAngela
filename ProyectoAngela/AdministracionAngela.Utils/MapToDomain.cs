using AdministracionAngela.CapaDePersistencia;
using AdministracionAngela.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministracionAngela.Utils
{
    public static class MapToDomain
    {
        #region Mapeo de Cliente
        public static ClienteDomain MapClient(Cliente clienteFromRepository)
        {
            return new ClienteDomain()
            {
                Codigo = clienteFromRepository.Id,
                Nombre = clienteFromRepository.Nombre,
                NIF = clienteFromRepository.NIF.HasValue ? clienteFromRepository.NIF.Value : clienteFromRepository.CIF.Value
            };
        }
        public static List<ClienteDomain> MapClientList(List<Cliente> clienteFromRepositoryList)
        {
            return clienteFromRepositoryList.Select(cliente => MapClient(cliente)).ToList<ClienteDomain>();
        }

        public static GestionCliente MapToGestionCliente(List<Cliente> repositoryClients)
        {
            var clientesDomain = MapClientList(repositoryClients);

            return new GestionCliente()
            {
                Clientes = new BindingList<ClienteDomain>(clientesDomain)
            };
        }
        #endregion
    }
}
