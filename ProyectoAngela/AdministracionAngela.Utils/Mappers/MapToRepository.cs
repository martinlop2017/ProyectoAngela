using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdministracionAngela.EFRepository;
using AdministracionAngela.Utils.Models.Cliente;

namespace AdministracionAngela.Utils.Mappers
{
    public static class MapToRepository
    {
        #region Mapeo de Cliente
        public static Cliente MapAltaClienteViewModel(AltaClienteViewModel nuevoClienteViewModel)
        {
            return new Cliente()
            {
                Id = nuevoClienteViewModel.CodigoCliente,
                NIF = nuevoClienteViewModel.NIF,
                CIF = string.Empty,
                Direccion = nuevoClienteViewModel.Direccion,
                Nombre = nuevoClienteViewModel.NombreComercial
            };
        }

        public static Cliente MapClienteViewModel(ClienteViewModel cliente)
        {
            return new Cliente()
            {
                Id = cliente.Codigo,
                Nombre = cliente.Nombre,
                NIF = cliente.NIF
            };
        }

        public static List<Cliente> MapListOfClienteViewModel(List<ClienteViewModel> clientes)
        {
            return clientes.Where(c => c != null).Select(cliente => MapClienteViewModel(cliente)).ToList<Cliente>();
        }

        #endregion
    }
}
