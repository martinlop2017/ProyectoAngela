using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdministracionAngela.Servicios.ServicioDatos.Repositorios;
using AdministracionAngela.Utils.Mappers;
using AdministracionAngela.Utils.Models.Cliente;
using AdministracionAngela.Utils.Interfaces;

namespace AdministracionAngela.Servicios.ServicioDatos
{
    public class ClienteProvider : IClienteProvider
    {
        IRepositorioCliente repositorioCliente;

        public ClienteProvider(IRepositorioCliente repositorioCliente)
        {
            this.repositorioCliente = repositorioCliente;
        }

        public bool DeleteClients(List<ClienteViewModel> clientsToDelete)
        {
            var repositoryClientstoDelete = MapToRepository.MapListOfClienteViewModel(clientsToDelete);

            return this.repositorioCliente.DeleteClients(repositoryClientstoDelete);
        }

        public GestionClienteViewModel GetGestionCliente()
        {
            var clientsFromRepository = this.repositorioCliente.GetAllClients();
            return MapToViewModel.MapToGestionCliente(clientsFromRepository);
        }

        /// <summary>
        /// Devuelve el Proximo codigo de cliente: comprueba cual es el ultimmo id de cliente y le suma 1. En caso de noexistir clientes, devuelve 1.
        /// </summary>
        /// <returns></returns>
        public int GetNextCodigoCliente()
        {
            var lastClient = this.repositorioCliente.GetLastClient();
            var lastClientId = lastClient != null ? (int)lastClient.Id + 1 : 1;

            return lastClientId;
        }

        public void SaveClient(AltaClienteViewModel newClient)
        {
            var clientRepository = MapToRepository.MapAltaClienteViewModel(newClient);
            this.repositorioCliente.SaveClient(clientRepository);
        }
    }
}
