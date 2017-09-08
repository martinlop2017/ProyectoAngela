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

        public void SaveClient(AltaClienteViewModel newClient)
        {
            var clientRepository = MapToRepository.MapAltaClienteViewModel(newClient);
            this.repositorioCliente.SaveClient(clientRepository);
        }
    }
}
