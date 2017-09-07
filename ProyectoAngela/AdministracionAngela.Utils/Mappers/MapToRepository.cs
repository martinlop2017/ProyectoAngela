using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdministracionAngela.EFRepository;
using AdministracionAngela.Utils.Models.Articulo;
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
                Nombre = nuevoClienteViewModel.NombreComercial,
                Poblacion = nuevoClienteViewModel.Poblacion,
                Provincia = nuevoClienteViewModel.Provincia,
                CodigoPostal = nuevoClienteViewModel.CodigoPostal,
                Telefono1 = nuevoClienteViewModel.Telefono1,
                Telefono2 = nuevoClienteViewModel.Telefono2,
                Fax = nuevoClienteViewModel.Fax,
                Email = nuevoClienteViewModel.Email,
                PersonaDeContacto = nuevoClienteViewModel.PersonaDeContacto,
                RiesgoMaximo = nuevoClienteViewModel.RiesgoMaximo,
                FormaDePago = nuevoClienteViewModel.FormaDePago,
                IsGeneral = nuevoClienteViewModel.isGeneral,
                RecargoEquivalencia = nuevoClienteViewModel.RecargoEquivalencia,
                UnionEuropea = nuevoClienteViewModel.UnionEuropea,
                Excento = nuevoClienteViewModel.Excento
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

        #region Mapeo de Articulo

        public static Producto MapAltaArticuloViewModel(AltaArticuloViewModel nuevoArticuloViewModel)
        {
            return new Producto()
            {
                Descripcion = nuevoArticuloViewModel.Descripcion
            };
        }

        public static Producto MapArticuloViewModel(ArticuloViewModel articulo)
        {
            return new Producto()
            {
                Codigo = articulo.Codigo,
                Descripcion = articulo.Descripcion
            };
        }

        public static List<Producto> MapListOfArticuloViewModel(List<ArticuloViewModel> articulos)
        {
            return articulos.Where(c => c != null).Select(articulo => MapArticuloViewModel(articulo)).ToList<Producto>();
        }

        #endregion
    }
}
