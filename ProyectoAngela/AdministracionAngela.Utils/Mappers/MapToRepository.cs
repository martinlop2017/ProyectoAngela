using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdministracionAngela.EFRepository;
using AdministracionAngela.Utils.Models.Articulo;
using AdministracionAngela.Utils.Models.Cliente;
using AdministracionAngela.Utils.Models.Factura;
using AdministracionAngela.Utils.Models.IVA;
using AdministracionAngela.Utils.Models.Perfil;
using AdministracionAngela.Utils.Models.Usuario;

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
                    LineaDireccion = nuevoClienteViewModel.Direccion,
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

        public static Producto MapAltaArticuloViewModel(AltaArticuloViewModel nuevoArticuloViewModel, IVA iva)
        {
            return new Producto()
            {
                Id = nuevoArticuloViewModel.Id,
                CodigoProducto = nuevoArticuloViewModel.CodigoArticulo,
                Descripcion = nuevoArticuloViewModel.Descripcion,
                IVAId = iva.Id
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
                    LineaDireccion = perfil.Direccion,
                    Poblacion = perfil.Poblacion,
                    Provincia = perfil.Provincia
                },
                Iban = perfil.Iban
            };
        }
        #endregion

        #region Mapeo de IVA

        public static IVA MapIVAViewModel(IVAViewModel iva)
        {
            return new IVA()
            {
                Id = iva.Id,
                Descripcion = iva.Descripcion,
                Porcentaje = iva.Porcentaje,
                PorcentanjeRE = iva.RecargoEquivalencia
            };
        }

        public static List<IVA> MapListOfIVAViewModel(List<IVAViewModel> ivas)
        {
            return ivas.Select(iva => MapIVAViewModel(iva)).ToList<IVA>();
        }

        #endregion

        #region Mapeo de Factura

        public static Factura MapAltaFacturaViewModel(AltaFacturaViewModel altaFactura)
        {
            return new Factura()
            {
                NumeroFactura = altaFactura.Id,
                ClienteId = altaFactura.ClienteIdsAndDescripciones[altaFactura.SelectedClient],
                Fecha = Convert.ToDateTime(altaFactura.Fecha),
                LineaFactura = MapLineasFacturaViewModel(altaFactura.LineasFactura, altaFactura.Id),
                TotalBase = altaFactura.TotalBase,
                TotalRecargoEquivalencia = altaFactura.TotalRecargoEquivalencia,
                TotalIVA = altaFactura.TotalIVA,
                Total = altaFactura.Total,
                Impreso = false
            };
        }

        public static List<LineaFactura> MapLineasFacturaViewModel(List<LineaFacturaViewModel> lineasFactura, long numeroFactura)
        {
            return lineasFactura.Select(linea => new LineaFactura()
            {
                NumeroFactura = numeroFactura,
                ProductoId = linea.ProductoId,
                PorcentajeIVA = linea.PorcentajeIVA,
                PorcentajeRE = linea.PorcentajeRE,
                Precio = linea.Precio,
                Kgs = linea.Kgs
            }).ToList();
        }

        public static List<Factura> MapListOfFacturaViewModel(List<FacturaViewModel> facturas)
        {
            return facturas.Where(f => f != null).Select(factura => MapFacturaViewModel(factura)).ToList<Factura>();
        }

        public static Factura MapFacturaViewModel(FacturaViewModel factura)
        {
            return new Factura()
            {
                NumeroFactura = factura.CodigoFactura,
            };
        }
        #endregion

        #region Mapeo de Usuario
        public static User MapAltaUsuarioViewModel(AltaUsuarioViewModel altaUsuario)
        {
            return new User()
            {
                UserName = altaUsuario.UserName,
                Password = altaUsuario.Password
            };
        }
        #endregion
    }
}
