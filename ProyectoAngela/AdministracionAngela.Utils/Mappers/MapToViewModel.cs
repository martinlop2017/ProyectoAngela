using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdministracionAngela.Utils.Models.Cliente;
using AdministracionAngela.EFRepository;

namespace AdministracionAngela.Utils.Mappers
{
    public static class MapToViewModel
    {
        #region Mapeo de Cliente
        public static ClienteViewModel MapClient(Cliente clienteFromRepository)
        {
            return new ClienteViewModel()
            {
                Codigo = clienteFromRepository.Id,
                Nombre = clienteFromRepository.Nombre,
                //NIF = clienteFromRepository.NIF.HasValue ? clienteFromRepository.NIF.Value : clienteFromRepository.CIF.Value
            };
        }
        public static List<ClienteViewModel> MapClientList(List<Cliente> clienteFromRepositoryList)
        {
            return clienteFromRepositoryList.Select(cliente => MapClient(cliente)).ToList<ClienteViewModel>();
        }

        public static GestionClienteViewModel MapToGestionCliente(List<Cliente> repositoryClients)
        {
            var clientesViewModel = MapClientList(repositoryClients);

            return new GestionClienteViewModel()
            {
                Clientes = new BindingList<ClienteViewModel>(clientesViewModel)
            };
        }
        #endregion
    }
}
