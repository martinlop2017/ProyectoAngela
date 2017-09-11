using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdministracionAngela.EFRepository;
using AdministracionAngela.Utils.Models.Articulo;
using AdministracionAngela.Utils.Models.Cliente;
using AdministracionAngela.Utils.Models.Perfil;

namespace AdministracionAngela.Utils.Mappers
{
    public static class MapToRepository
    {
        #region Mapeo de Cliente

        public static Cliente MapAltaClienteViewModel(AltaClienteViewModel nuevoClienteViewModel)
        {
            return new Cliente()
            {
                Id = nuevoClienteViewModel.Id,
                CodigoCliente = nuevoClienteViewModel.CodigoCliente,
                NIF = nuevoClienteViewModel.NIF,
                CIF = string.Empty,
                Direccion = new Direccion()
                {
                    Direccion1 = nuevoClienteViewModel.Direccion,
                    Poblacion = nuevoClienteViewModel.Poblacion,
                    Provincia = nuevoClienteViewModel.Provincia,
                    CodigoPostal = nuevoClienteViewModel.CodigoPostal
                },
                Nombre = nuevoClienteViewModel.NombreComercial,
                Contacto = new Contacto()
                {
                    Telefono1 = nuevoClienteViewModel.Telefono1,
                    Telefono2 = nuevoClienteViewModel.Telefono2,
                    Fax = nuevoClienteViewModel.Fax,
                    Email = nuevoClienteViewModel.Email,
                    PersonaContacto = nuevoClienteViewModel.PersonaDeContacto
                },
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
                Id = cliente.Id,
                CodigoCliente = cliente.Codigo,
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
                Id = nuevoArticuloViewModel.Id,
                CodigoProducto = nuevoArticuloViewModel.CodigoArticulo,
                Descripcion = nuevoArticuloViewModel.Descripcion
            };
        }

        public static Producto MapArticuloViewModel(ArticuloViewModel articulo)
        {
            return new Producto()
            {
                Id = articulo.Id,
                CodigoProducto = articulo.Codigo,
                Descripcion = articulo.Descripcion
            };
        }

        public static List<Producto> MapListOfArticuloViewModel(List<ArticuloViewModel> articulos)
        {
            return articulos.Where(c => c != null).Select(articulo => MapArticuloViewModel(articulo)).ToList<Producto>();
        }

        #endregion

        #region Mapeo de Perfil

        public static Perfil mapPerfilViewModel(PerfilViewModel perfil)
        {
            return new Perfil()
            {
                Id = perfil.Id,
                NIF = perfil.NIF,
                Nombre = perfil.Nombre,
                Contacto = new Contacto()
                {
                    Email = perfil.Email,
                    Fax = perfil.Fax,
                    Telefono1 = perfil.Telefono1,
                    Telefono2 = perfil.Telefono2
                },
                Direccion = new Direccion()
                {
                    CodigoPostal = perfil.CodigoPostal,
                    Direccion1 = perfil.Direccion,
                    Poblacion = perfil.Poblacion,
                    Provincia = perfil.Provincia
                },
                Iban = perfil.Iban
            };
        }
        #endregion
    }
}
