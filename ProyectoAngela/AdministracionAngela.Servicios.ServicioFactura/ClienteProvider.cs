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
        IRepositorioSistema repositorioSistema;

        public ClienteProvider(IRepositorioCliente repositorioCliente, IRepositorioSistema repositorioSistema)
        {
            this.repositorioCliente = repositorioCliente;
            this.repositorioSistema = repositorioSistema;
        }

        public bool DeleteClients(List<ClienteViewModel> clientsToDelete)
        {
            var repositoryClientstoDelete = MapToRepository.MapListOfClienteViewModel(clientsToDelete);

            this.repositorioCliente.DeleteAddressByClientIds(repositoryClientstoDelete);
            this.repositorioCliente.DeleteContactsByClientIds(repositoryClientstoDelete);
            return this.repositorioCliente.DeleteClients(repositoryClientstoDelete);
        }

        public AltaClienteViewModel GetAltaClienteById(long clienteId)
        {
            var clientFromRepository = this.repositorioCliente.GetClientById(clienteId);
            var formasDePago = this.repositorioSistema.GetAllFormasDePago();

            return MapToViewModel.MapAltaClient(clientFromRepository);
        }

        public GestionClienteViewModel GetGestionCliente()
        {
            var clientsFromRepository = this.repositorioCliente.GetAllClients();
            return MapToViewModel.MapToGestionCliente(clientsFromRepository);
        }

        public bool SaveClient(AltaClienteViewModel newClient)
        {
            var clientRepository = MapToRepository.MapAltaClienteViewModel(newClient);
            return this.repositorioCliente.SaveClient(clientRepository);
        }

        public bool UpdateClient(AltaClienteViewModel newClient)
        {
            var clientRepository = MapToRepository.MapAltaClienteViewModel(newClient);
            return this.repositorioCliente.UpdateClient(clientRepository);
        }
    }
}
