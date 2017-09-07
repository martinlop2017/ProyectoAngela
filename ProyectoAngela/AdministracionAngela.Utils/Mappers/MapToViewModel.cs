using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdministracionAngela.Utils.Models.Cliente;
using AdministracionAngela.EFRepository;
using AdministracionAngela.Utils.Models.Articulo;

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
                NIF = !string.IsNullOrEmpty(clienteFromRepository.NIF) ? clienteFromRepository.NIF : clienteFromRepository.CIF
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

        #region Mapeo de articulos

        public static ArticuloViewModel MapArticulo(Producto articuloFromRepository)
        {
            return new ArticuloViewModel()
            {
               Descripcion = articuloFromRepository.Descripcion
            };
        }

        public static List<ArticuloViewModel> MapArticuloList(List<Producto> articuloFromRepositoryList)
        {
            return articuloFromRepositoryList.Select(articulo => MapArticulo(articulo)).ToList<ArticuloViewModel>();
        }

        public static GestionArticuloViewModel MapToGestionArticulo(List<Producto> repositoryArticulos)
        {
            var articulosViewModel = MapArticuloList(repositoryArticulos);

            return new GestionArticuloViewModel()
            {
                Articulos = new BindingList<ArticuloViewModel>(articulosViewModel)
            };
        }

        #endregion
    }
}
