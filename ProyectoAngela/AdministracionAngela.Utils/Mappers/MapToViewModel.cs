using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdministracionAngela.Utils.Models.Cliente;
using AdministracionAngela.EFRepository;
using AdministracionAngela.Utils.Models.Articulo;
using AdministracionAngela.Utils.Models.Perfil;

namespace AdministracionAngela.Utils.Mappers
{
    public static class MapToViewModel
    {
        #region Mapeo de Cliente

        public static ClienteViewModel MapClient(Cliente clienteFromRepository)
        {
            return new ClienteViewModel()
            {
                Id = clienteFromRepository.Id,
                Codigo = clienteFromRepository.CodigoCliente,
                Nombre = clienteFromRepository.Nombre,
                NIF =
                    !string.IsNullOrEmpty(clienteFromRepository.NIF)
                        ? clienteFromRepository.NIF
                        : clienteFromRepository.CIF
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

        public static AltaClienteViewModel MapAltaClient(Cliente clienteFromRepository)
        {
            return new AltaClienteViewModel()
            {
                Id = clienteFromRepository.Id,
                CodigoCliente = clienteFromRepository.CodigoCliente,
                NombreComercial = clienteFromRepository.Nombre,
                NIF = clienteFromRepository.NIF,
                Direccion = clienteFromRepository.Direccion.Direccion1,
                Provincia = clienteFromRepository.Direccion.Provincia,
                Poblacion = clienteFromRepository.Direccion.Poblacion,
                CodigoPostal = clienteFromRepository.Direccion.CodigoPostal.Value,
                Telefono1 = clienteFromRepository.Contacto.Telefono1.Value,
                Telefono2 = clienteFromRepository.Contacto.Telefono2.Value,
                Fax = clienteFromRepository.Contacto.Fax.Value,
                Email = clienteFromRepository.Contacto.Email,
                PersonaDeContacto = clienteFromRepository.Contacto.PersonaContacto,
                RiesgoMaximo = Convert.ToInt32(clienteFromRepository.RiesgoMaximo),
                FormaDePago = clienteFromRepository.FormaDePago,
                isGeneral = clienteFromRepository.IsGeneral,
                RecargoEquivalencia = clienteFromRepository.RecargoEquivalencia,
                UnionEuropea = clienteFromRepository.UnionEuropea,
                Excento = clienteFromRepository.Excento
            };
        }
        #endregion

        #region Mapeo de articulos

        public static ArticuloViewModel MapArticulo(Producto articuloFromRepository)
        {
            return new ArticuloViewModel()
            {
                Id = articuloFromRepository.Id,
                Codigo = articuloFromRepository.CodigoProducto,
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

        public static AltaArticuloViewModel MapAltaArticulo(Producto articuloFromRepository)
        {
            return new AltaArticuloViewModel()
            {
                CodigoArticulo = articuloFromRepository.CodigoProducto,
                Descripcion = articuloFromRepository.Descripcion
            };
        }

        #endregion

        #region Mapeo Perfil

        public static PerfilViewModel MapToPerfilViewModel(Perfil perfilFromRepository)
        {
            return new PerfilViewModel()
            {
                Id = perfilFromRepository.Id,
                NIF = perfilFromRepository.NIF,
                Nombre = perfilFromRepository.Nombre,
                CodigoPostal = perfilFromRepository.Direccion.CodigoPostal.Value,
                Direccion = perfilFromRepository.Direccion.Direccion1,
                Poblacion = perfilFromRepository.Direccion.Poblacion,
                Provincia = perfilFromRepository.Direccion.Provincia,
                Email = perfilFromRepository.Contacto.Email,
                Fax = perfilFromRepository.Contacto.Fax.Value,
                Telefono1 = perfilFromRepository.Contacto.Telefono1.Value,
                Telefono2 = perfilFromRepository.Contacto.Telefono2.Value,
                Iban = perfilFromRepository.Iban,
            };
        }
        #endregion
    }
}
