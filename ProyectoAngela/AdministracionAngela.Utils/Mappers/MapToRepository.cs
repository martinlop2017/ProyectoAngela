﻿using System;
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
using AdministracionAngela.Utils.Models.FormaDePago;
using AdministracionAngela.Utils.Models.Albaran;

namespace AdministracionAngela.Utils.Mappers
{
    public static class MapToRepository
    {
        #region Mapeo de Cliente

        public static Cliente MapAltaClienteViewModel(AltaClienteViewModel nuevoClienteViewModel, FormaPago formaDePago)
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
                    Telefono1 = Convert.ToInt32(nuevoClienteViewModel.Telefono1),
                    Telefono2 = Convert.ToInt32(nuevoClienteViewModel.Telefono2),
                    Fax = Convert.ToInt32(nuevoClienteViewModel.Fax),
                    Email = nuevoClienteViewModel.Email1,
                    Email2 = nuevoClienteViewModel.Email2,
                    Email3 = nuevoClienteViewModel.Email3,
                    Email4 = nuevoClienteViewModel.Email4,
                    PersonaContacto = nuevoClienteViewModel.PersonaDeContacto
                },
                RiesgoMaximo = nuevoClienteViewModel.RiesgoMaximo,
                FormaDePagoId = formaDePago.Id,
                FormaPago = formaDePago,
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
                ArtePesca = nuevoArticuloViewModel.ArtePesca,
                ZonaCaptura = nuevoArticuloViewModel.ZonaCaptura,
                FAO = nuevoArticuloViewModel.CodigoFAO,
                NombreCientifico = nuevoArticuloViewModel.NombreCientifico,
                IVAId = iva.Id,
                Abreviacion = nuevoArticuloViewModel.Abreviacion
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
                LogoPath = perfil.LogoPath,
                Contacto = new Contacto()
                {
                    Email = perfil.Email,
                    Fax = perfil.Fax,
                    Telefono1 = perfil.Telefono1,
                    Telefono2 = perfil.Telefono2,
                    PersonaContacto = perfil.PersonaContacto
                },
                Direccion = new Direccion()
                {
                    CodigoPostal = perfil.CodigoPostal,
                    LineaDireccion = perfil.Direccion,
                    Poblacion = perfil.Poblacion,
                    Provincia = perfil.Provincia
                },
                Iban1 = perfil.Iban1,
                Iban2 = perfil.Iban2,
                Iban3 = perfil.Iban3,
                Iban4 = perfil.Iban4,
                Iban5 = perfil.Iban5,
                Iban6 = perfil.Iban6,
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

        #region Mapeo de Albaran

        public static Albaran MapAltaAlbaranViewModel(AltaAlbaranViewModel altaAlbaran)
        {
            return new Albaran()
            {
                NumeroAlbaran = altaAlbaran.Id,
                ClienteId = altaAlbaran.ClienteIdsAndDescripciones[altaAlbaran.SelectedClient],
                Fecha = Convert.ToDateTime(altaAlbaran.Fecha),
                LineaAlbaran = MapLineasAlbaranViewModel(altaAlbaran.LineasAlbaran, altaAlbaran.Id, altaAlbaran.FillIVA, altaAlbaran.FillRE),
                TotalBase = altaAlbaran.TotalBase,
                TotalRecargoEquivalencia = altaAlbaran.FillRE ? altaAlbaran.TotalRecargoEquivalencia : 0,
                TotalIVA = altaAlbaran.FillIVA ? altaAlbaran.TotalIVA : 0,
                Total = altaAlbaran.Total,
                Impreso = false,
                EtiquetaLote = altaAlbaran.Lote,
                IsAlbaran = altaAlbaran.IsAlbaran,
                Facturado = false
            };
        }

        public static List<LineaAlbaran> MapLineasAlbaranViewModel(List<LineaAlbaranViewModel> lineasAlbaran, long numeroAlbaran, bool fillIva, bool fillRE)
        {
            return lineasAlbaran.Select(linea => new LineaAlbaran()
            {
                ProductoId = linea.ProductoId,
                PorcentajeIVA = fillIva ? linea.PorcentajeIVA : 0,
                ImporteIVA = fillIva ? linea.ImporteIVA : 0,
                PorcentajeRE = fillRE ? linea.PorcentajeRE : 0,
                ImporteRE = fillRE ? linea.ImporteRE : 0,
                Precio = linea.Precio,
                Kgs = linea.Kgs,
                Cajas = linea.Cajas,
                Importe = linea.Importe,
            }).ToList();
        }

        public static List<Albaran> MapListOfAlbaranViewModel(List<FacturaViewModel> albaranes)
        {
            return albaranes.Where(f => f != null).Select(albaran => MapAlbaranViewModel(albaran)).ToList<Albaran>();
        }

        public static Albaran MapAlbaranViewModel(FacturaViewModel albaran)
        {
            return new Albaran()
            {
                NumeroAlbaran = albaran.Codigo
            };
        }
        #endregion

        #region Mapeo de Factura

        public static Factura MapAltaFacturaViewModel(AltaFacturaViewModel altaFactura)
        {
            return new Factura()
            {
                NumeroFactura = altaFactura.NumeroFactura,
                ClienteId = altaFactura.ClienteIdsAndDescripciones[altaFactura.SelectedClient],
                Fecha = Convert.ToDateTime(altaFactura.Fecha),
                LineaFactura = MapLineasFacturaViewModel(altaFactura.LineasFactura, altaFactura.FillIVA, altaFactura.FillRE),
                TotalBase = altaFactura.TotalBase,
                TotalRecargoEquivalencia = altaFactura.FillRE ? altaFactura.TotalRecargoEquivalencia : 0,
                TotalIVA = altaFactura.FillIVA ? altaFactura.TotalIVA : 0,
                Total = altaFactura.Total,
                Impreso = false,
                Cobrada = false
            };
        }

        public static List<LineaFactura> MapLineasFacturaViewModel(List<LineaFacturaViewModel> lineasFactura, bool fillIVA, bool fillRE)
        {
            return lineasFactura.Select(linea => new LineaFactura()
            {
                ProductoId = linea.ProductoId,
                PorcentajeIVA = fillIVA ? linea.PorcentajeIVA : 0,
                ImporteIVA = fillIVA ? linea.ImporteIVA : 0,
                PorcentajeRE = fillRE ? linea.PorcentajeRE : 0,
                ImporteRE = fillRE ?  linea.ImporteRE: 0,
                Precio = linea.Precio,
                Kgs = linea.Kgs,
                Cajas = linea.Cajas,
                Importe = linea.Importe,
                Lote = linea.Lote
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
                NumeroFactura = factura.Codigo,
            };
        }
        #endregion

        #region Mapeo de Usuario
        public static User MapAltaUsuarioViewModel(AltaUsuarioViewModel altaUsuario)
        {
            return new User()
            {
                UserName = altaUsuario.UserName,
                Password = altaUsuario.Password,
                Nivel = altaUsuario.Nivel,
                Activo = altaUsuario.Activo
            };
        }
        #endregion

        #region Mapeo Formas de Pago
        public static List<FormaPago> MapListOfFormaDePagoViewModel(List<FormaDePagoViewModel> formasDePago)
        {
            return formasDePago.Select(formaDePAgo => MapFormaDePagoViewModel(formaDePAgo)).ToList<FormaPago>();
        }

        public static FormaPago MapFormaDePagoViewModel(FormaDePagoViewModel viewModel)
        {
            return new FormaPago()
            {
                Id = viewModel.Codigo,
                Concepto = viewModel.Concepto,
                Dias = viewModel.Dias
            };
        }
        #endregion
    }
}
