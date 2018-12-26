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

            return MapToViewModel.MapAltaClient(clientFromRepository, formasDePago);
        }

        public AltaClienteViewModel GetAltaCliente()
        {
            var formasDePago = this.repositorioSistema.GetAllFormasDePago();
            return new AltaClienteViewModel()
            {
                FormasDePago = formasDePago.Select(fp => fp.Concepto).ToList()
            };
        }

        public GestionClienteViewModel GetGestionCliente()
        {
            var clientsFromRepository = this.repositorioCliente.GetAllClients();
            return MapToViewModel.MapToGestionCliente(clientsFromRepository);
        }

        public bool SaveClient(AltaClienteViewModel newClient)
        {
            var formaDePago = this.repositorioSistema.GetAllFormasDePagoByDescription(newClient.FormaDePagoSelected);
            var clientRepository = MapToRepository.MapAltaClienteViewModel(newClient, formaDePago);
            return this.repositorioCliente.SaveClient(clientRepository);
        }

        public bool UpdateClient(AltaClienteViewModel newClient)
        {
            var formaDePago = this.repositorioSistema.GetAllFormasDePagoByDescription(newClient.FormaDePagoSelected);
            var clientRepository = MapToRepository.MapAltaClienteViewModel(newClient, formaDePago);
            return this.repositorioCliente.UpdateClient(clientRepository);
        }

        public List<AltaClienteViewModel> GetAllClientes()
        {
            var clientes = repositorioCliente.GetAllClients();
            var formasDePago = this.repositorioSistema.GetAllFormasDePago();

            return clientes.Select(x => MapToViewModel.MapAltaClient(x, formasDePago)).ToList();
        }
    }
}
