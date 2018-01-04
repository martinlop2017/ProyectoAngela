using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AdministracionAngela.Utils.Models.Cliente;
using AdministracionAngela.EFRepository;
using AdministracionAngela.Utils.Extensions;
using AdministracionAngela.Utils.Models.Articulo;
using AdministracionAngela.Utils.Models.Factura;
using AdministracionAngela.Utils.Models.IVA;
using AdministracionAngela.Utils.Models.Perfil;
using AdministracionAngela.Utils.Models.Usuario;
using AdministracionAngela.Utils.Models.FormaDePago;
using AdministracionAngela.Utils.Models.Liquidaciones;
using AdministracionAngela.Utils.Models.Albaran;

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

        public static AltaClienteViewModel MapAltaClient(Cliente clienteFromRepository, List<FormaPago> formasDePago)
        {
            return new AltaClienteViewModel()
            {
                Id = clienteFromRepository.Id,
                CodigoCliente = clienteFromRepository.CodigoCliente,
                NombreComercial = clienteFromRepository.Nombre,
                NIF = clienteFromRepository.NIF,
                Direccion = clienteFromRepository.Direccion.LineaDireccion,
                Provincia = clienteFromRepository.Direccion.Provincia,
                Poblacion = clienteFromRepository.Direccion.Poblacion,
                CodigoPostal = clienteFromRepository.Direccion.CodigoPostal.Value,
                Telefono1 = clienteFromRepository.Contacto.Telefono1.Value,
                Telefono2 = clienteFromRepository.Contacto.Telefono2.Value,
                Fax = clienteFromRepository.Contacto.Fax.Value,
                Email1 = clienteFromRepository.Contacto.Email,
                Email2 = clienteFromRepository.Contacto.Email2,
                Email3 = clienteFromRepository.Contacto.Email3,
                Email4 = clienteFromRepository.Contacto.Email4,
                PersonaDeContacto = clienteFromRepository.Contacto.PersonaContacto,
                RiesgoMaximo = Convert.ToInt32(clienteFromRepository.RiesgoMaximo),
                FormasDePago = formasDePago.Select(fp => fp.Concepto).ToList(),
                FormaDePagoSelected = clienteFromRepository.FormaPago.Concepto,
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

        public static AltaArticuloViewModel MapAltaArticulo(Producto articuloFromRepository, List<IVA> ivas)
        {
            return new AltaArticuloViewModel()
            {
                CodigoArticulo = articuloFromRepository.CodigoProducto,
                Descripcion = articuloFromRepository.Descripcion,
                ArtePesca = articuloFromRepository.ArtePesca,
                CodigoFAO = articuloFromRepository.FAO,
                ZonaCaptura = articuloFromRepository.ZonaCaptura,
                NombreCientifico = articuloFromRepository.NombreCientifico,
                IVAs = ivas.Select(iva => iva.Descripcion).ToList(),
                Abreviacion = articuloFromRepository.Abreviacion,
                SelectedIVA = articuloFromRepository.IVA.Descripcion
            };
        }

        #endregion

        #region Mapeo Perfil

        public static PerfilViewModel MapToPerfilViewModel(Perfil perfilFromRepository)
        {
            PerfilViewModel perfil = null;
            if(perfilFromRepository != null)
            {
                perfil = new PerfilViewModel()
                {
                    Id = perfilFromRepository.Id,
                    NIF = perfilFromRepository.NIF,
                    Nombre = perfilFromRepository.Nombre,
                    CodigoPostal = perfilFromRepository.Direccion.CodigoPostal.Value,
                    Direccion = perfilFromRepository.Direccion.LineaDireccion,
                    Poblacion = perfilFromRepository.Direccion.Poblacion,
                    Provincia = perfilFromRepository.Direccion.Provincia,
                    Email = perfilFromRepository.Contacto.Email,
                    Fax = perfilFromRepository.Contacto.Fax.Value,
                    Telefono1 = perfilFromRepository.Contacto.Telefono1.Value,
                    Telefono2 = perfilFromRepository.Contacto.Telefono2.Value,
                    Iban = perfilFromRepository.Iban,
                };
            }

            return perfil;
        }

        #endregion

        #region Mapeo IVA

        public static IVAViewModel MapIVA(IVA iva)
        {
            return new IVAViewModel()
            {
                Id = iva.Id,
                Descripcion = iva.Descripcion,
                Porcentaje = iva.Porcentaje.Value,
                RecargoEquivalencia = iva.PorcentanjeRE.Value
            };
        }

        public static List<IVAViewModel> MapIVAList(List<IVA> ivaListFromRepository)
        {
            return ivaListFromRepository.Select(iva => MapIVA(iva)).ToList<IVAViewModel>();
        }

        public static GestionIVAViewModel MapListToGestionIVA(List<IVA> ivas)
        {
            var ivasViewModel = MapIVAList(ivas);

            return new GestionIVAViewModel()
            {
                IVAs = new BindingList<IVAViewModel>(ivasViewModel)
            };
        }

        #endregion

        #region Mapeo Albaranes

        public static AltaAlbaranViewModel MapToAltaAlbaranViewModel(List<Cliente> clientes, List<Producto> articulos, int numeroAlbaran, List<IVA> ivas)
        {
            return new AltaAlbaranViewModel()
            {
                Id = numeroAlbaran,
                ClienteIdsAndDescripciones = clientes.ToDictionary(cliente => string.Format("{0} - {1}", cliente.Id, cliente.Nombre), c => c.Id),
                ArticuloIdsAndDescripciones = articulos.ToDictionary(articulo => string.Format("{0} - {1}", articulo.CodigoProducto, articulo.Descripcion), a => a.Id),
                Fecha = DateTime.Today.ToString("yyyy MM dd"),
                Lote = DateTime.Today.ToString("ddMMyyyy"),
                LineasIVA = MapListToLineaIVAViewModel(ivas)
            };
        }

        public static AltaAlbaranViewModel MapToUpdateAltaAlbaranViewModel(List<Cliente> clientes, List<Producto> articulos, Albaran albaran, List<IVA> ivas)
        {
            return new AltaAlbaranViewModel()
            {
                Id = (int)albaran.NumeroAlbaran,
                ClienteIdsAndDescripciones = clientes.ToDictionary(cliente => string.Format("{0} - {1}", cliente.Id, cliente.Nombre), c => c.Id),
                ArticuloIdsAndDescripciones = articulos.ToDictionary(articulo => string.Format("{0} - {1}", articulo.CodigoProducto, articulo.Descripcion), a => a.Id),
                SelectedClient = string.Format("{0} - {1}", albaran.Cliente.Id, albaran.Cliente.Nombre),
                Fecha = albaran.Fecha.ToString(),
                LineasAlbaran = MapListToLineaAlbaranViewModel(albaran.LineaAlbaran.ToList()),
                LineasIVA = MapListToLineaIVAViewModel(ivas),
                Lote = albaran.EtiquetaLote
            };
        }

        public static List<LineaAlbaranViewModel> MapListToLineaAlbaranViewModel(List<LineaAlbaran> lineasAlbaran)
        {
            return lineasAlbaran.Select(lf => MapToLineaAlbaranViewModel(lf)).ToList();
        }

        public static LineaAlbaranViewModel MapToLineaAlbaranViewModel(LineaAlbaran lineaAlbaran)
        {
            return new LineaAlbaranViewModel()
            {
                SelectedProduct = string.Format("{0} - {1}", lineaAlbaran.Producto.CodigoProducto, lineaAlbaran.Producto.Descripcion),
                ProductoId = lineaAlbaran.ProductoId,
                PorcentajeIVA = lineaAlbaran.PorcentajeIVA,
                PorcentajeRE = lineaAlbaran.PorcentajeRE.Value,
                Kgs = lineaAlbaran.Kgs.Value,
                Precio = lineaAlbaran.Precio.Value,
                Importe = lineaAlbaran.Kgs.Value * lineaAlbaran.Precio.Value,
                Cajas = lineaAlbaran.Cajas.Value
            };
        }

        public static List<LineaAlbaranViewModel> MapDataGridViewRowsToLineasAlbaranViewModel(DataGridViewRowCollection rows, Dictionary<string, long> ArticuloIdsAndDescripciones)
        {
            List<LineaAlbaranViewModel> lineasAlbaran = new List<LineaAlbaranViewModel>(rows.Count);
            foreach (DataGridViewRow row in rows)
            {
                if (!row.HasNullValues())
                {
                    lineasAlbaran.Add(new LineaAlbaranViewModel()
                    {
                        ProductoId = ArticuloIdsAndDescripciones[row.Cells["ColumnProducto"].Value.ToString()],
                        Cajas = Convert.ToInt32(row.Cells["ColumnCajas"].Value),
                        Kgs = Convert.ToDecimal(row.Cells["ColumnKgs"].Value),
                        Precio = Convert.ToDecimal(row.Cells["ColumnPrecio"].Value),
                        Importe = Convert.ToDecimal(row.Cells["ColumnImporte"].Value)
                    });
                }
            }

            return lineasAlbaran;
        }

        public static GestionFacturaViewModel MapToGestionAlbaran(List<Albaran> albaranes)
        {
            var albaranesViewModel = MapToFacturaList(albaranes);

            return new GestionFacturaViewModel()
            {
                Facturas = new BindingList<FacturaViewModel>(albaranesViewModel)
            };
        }

        public static List<FacturaViewModel> MapToFacturaList(List<Albaran> albaranes)
        {
            return albaranes.Select(f => new FacturaViewModel()
            {
                Cliente = f.Cliente.Nombre,
                CodigoFactura = f.NumeroAlbaran,
                Base = f.TotalBase.HasValue ? Decimal.Round(f.TotalBase.Value, 2) : 0,
                IVA = f.TotalIVA.HasValue ? Decimal.Round(f.TotalIVA.Value, 2) : 0,
                RecargoEquivalencia = f.TotalRecargoEquivalencia.HasValue ? Decimal.Round(f.TotalRecargoEquivalencia.Value, 2) : 0,
                Total = f.Total.HasValue ? Decimal.Round(f.Total.Value, 2) : 0,
                Impreso = f.Impreso.HasValue ? f.Impreso.Value : false
            }).ToList();
        }

        #endregion
        #region Mapeo Facturas

        public static AltaFacturaViewModel MapToAltaFacturaViewModel(List<Cliente> clientes, List<Producto> articulos, int numeroFactura, List<IVA> ivas )
        {
            return new AltaFacturaViewModel()
            {
                Id = numeroFactura,
                ClienteIdsAndDescripciones = clientes.ToDictionary(cliente => string.Format("{0} - {1}", cliente.Id, cliente.Nombre), c => c.Id),
                ArticuloIdsAndDescripciones = articulos.ToDictionary(articulo => string.Format("{0} - {1}", articulo.CodigoProducto, articulo.Descripcion), a => a.Id),
                Fecha = DateTime.Today.ToString("yyyy MM dd"),
                Lote = DateTime.Today.ToString("ddMMyyyy"),
                LineasIVA = MapListToLineaIVAViewModel(ivas)
            };
        }

        public static AltaFacturaViewModel MapToUpdateAltaFacturaViewModel(List<Cliente> clientes, List<Producto> articulos, Factura factura, List<IVA> ivas)
        {
            return new AltaFacturaViewModel()
            {
                Id = (int)factura.NumeroFactura,
                ClienteIdsAndDescripciones = clientes.ToDictionary(cliente => string.Format("{0} - {1}", cliente.Id, cliente.Nombre), c => c.Id),
                ArticuloIdsAndDescripciones = articulos.ToDictionary(articulo => string.Format("{0} - {1}", articulo.CodigoProducto, articulo.Descripcion), a => a.Id),
                SelectedClient = string.Format("{0} - {1}", factura.Cliente.Id, factura.Cliente.Nombre),
                Fecha = factura.Fecha.ToString(),
                LineasFactura = MapListToLineaFacturaViewModel(factura.LineaFactura.ToList()),
                LineasIVA = MapListToLineaIVAViewModel(ivas),
                Lote = factura.EtiquetaLote
            };
        }

        public static List<LineaFacturaViewModel> MapListToLineaFacturaViewModel(List<LineaFactura> lineasFactura)
        {
            return lineasFactura.Select(lf => MapToLineaFacturaViewModel(lf)).ToList();
        }

        public static LineaFacturaViewModel MapToLineaFacturaViewModel(LineaFactura lineaFactura)
        {
            return new LineaFacturaViewModel()
            {
                SelectedProduct = string.Format("{0} - {1}", lineaFactura.Producto.CodigoProducto, lineaFactura.Producto.Descripcion),
                ProductoId = lineaFactura.ProductoId,
                PorcentajeIVA = lineaFactura.PorcentajeIVA,
                PorcentajeRE = lineaFactura.PorcentajeRE.Value,
                Kgs = lineaFactura.Kgs.Value,
                Precio = lineaFactura.Precio.Value,
                Importe = lineaFactura.Kgs.Value * lineaFactura.Precio.Value,
                Cajas = lineaFactura.Cajas.Value
            };
        }

        public static List<LineaIVAViewModel> MapListToLineaIVAViewModel(List<IVA> ivas)
        {
            return ivas.Select(iva => new LineaIVAViewModel()
            {
                PorcentajeIVA = iva.Porcentaje.Value,
                PorcentajeRecargoEquivalencia = iva.PorcentanjeRE.Value
            })
            .ToList();
        }

        public static List<LineaFacturaViewModel> MapDataGridViewRowsToLineasFacturaViewModel(DataGridViewRowCollection rows, Dictionary<string, long> ArticuloIdsAndDescripciones)
        {
            List<LineaFacturaViewModel> lineasFactura = new List<LineaFacturaViewModel>(rows.Count);
            foreach (DataGridViewRow row in rows)
            {
                if (!row.HasNullValues())
                {
                    lineasFactura.Add(new LineaFacturaViewModel()
                    {
                        ProductoId = ArticuloIdsAndDescripciones[row.Cells["ColumnProducto"].Value.ToString()],
                        Cajas = Convert.ToInt32(row.Cells["ColumnCajas"].Value),
                        Kgs = Convert.ToDecimal(row.Cells["ColumnKgs"].Value),
                        Precio = Convert.ToDecimal(row.Cells["ColumnPrecio"].Value),
                        Importe = Convert.ToDecimal(row.Cells["ColumnImporte"].Value)
                    });
                }
            }

            return lineasFactura;
        }

        public static GestionFacturaViewModel MapToGestionFactura(List<Factura> facturas)
        {
            var facturasViewModel = MapToFacturaList(facturas);

            return new GestionFacturaViewModel()
            {
                Facturas = new BindingList<FacturaViewModel>(facturasViewModel)
            };
        }

        public static List<FacturaViewModel> MapToFacturaList(List<Factura> facturas)
        {
            return facturas.Select(f => new FacturaViewModel()
            {
                Cliente = f.Cliente.Nombre,
                CodigoFactura = f.NumeroFactura,
                Base = f.TotalBase.HasValue ? Decimal.Round(f.TotalBase.Value, 2) : 0,
                IVA = f.TotalIVA.HasValue ? Decimal.Round(f.TotalIVA.Value, 2) : 0,
                RecargoEquivalencia = f.TotalRecargoEquivalencia.HasValue ? Decimal.Round(f.TotalRecargoEquivalencia.Value, 2) : 0,
                Total = f.Total.HasValue ? Decimal.Round(f.Total.Value, 2) : 0,
                Impreso = f.Impreso.HasValue ? f.Impreso.Value : false
            }).ToList();
        }

        #endregion

        #region Mapeo Usuarios
        public static GestionUsuarioViewModel MapToGestionUsuario(List<User> usersFromRepository)
        {
            var usuariosViewModel = MapUserList(usersFromRepository);

            return new GestionUsuarioViewModel()
            {
                Usuarios = new BindingList<UsuarioViewModel>(usuariosViewModel)
            };
        }

        public static List<UsuarioViewModel> MapUserList(List<User> usuariosFromRepositoryList)
        {
            return usuariosFromRepositoryList.Select(user => MapUser(user)).ToList<UsuarioViewModel>();
        }

        public static UsuarioViewModel MapUser(User usuario)
        {
            return new UsuarioViewModel()
            {
                Usuario = usuario.UserName,
                Password = usuario.Password
            };
        }
        #endregion

        #region Mapeo Formas de pago
        public static FormaDePagoViewModel MapFormaDePAgo(FormaPago formaDePago)
        {
            return new FormaDePagoViewModel()
            {
                Codigo = formaDePago.Id,
                Concepto = formaDePago.Concepto,
                Dias = formaDePago.Dias.Value
            };
        }
        public static List<FormaDePagoViewModel> MapFormaPagoList(List<FormaPago> formasDePagoFromRepository)
        {
            return formasDePagoFromRepository.Select(formaDePago => MapFormaDePAgo(formaDePago)).ToList<FormaDePagoViewModel>();
        }
        public static GestionFormaDePagoViewModel MapListToGestionFormaDePago(List<FormaPago> formasDePago)
        {
            var formasDePagosViewModel = MapFormaPagoList(formasDePago);

            return new GestionFormaDePagoViewModel()
            {
                FormasDePago = new BindingList<FormaDePagoViewModel>(formasDePagosViewModel)
            };
        }
        #endregion

        #region Mapeo Liquidacion

        public static LineaLiquidacionViewModel MapLineaLiquidacion(LineaFactura lineaFactura)
        {
            return new LineaLiquidacionViewModel()
            {
                Bultos = lineaFactura.Cajas.Value,
                Kilos = lineaFactura.Kgs.Value
            };
        }

        public static List<LineaLiquidacionViewModel> MapLineaLiquidacionesList(List<LineaFactura> lineasFactura)
        {
            return lineasFactura.Select(lf => MapLineaLiquidacion(lf)).ToList<LineaLiquidacionViewModel>();
        }

        public static LiquidacionesViewModel MapToLiquidacion(List<LineaFactura> repositoryLineasFactura)
        {
            var groupedLineas = repositoryLineasFactura.GroupBy(lf => lf.ProductoId);

            var lineasLiquidacionViewModel = new List<LineaLiquidacionViewModel>();
            foreach(var groupedLinea in groupedLineas)
            {
                var lineas = groupedLinea.ToList();

                var sumatorioprecios = lineas.Sum(l => l.Precio);
                var numeroLineas = lineas.Count();
                var precioMedio = decimal.Round((sumatorioprecios.Value / numeroLineas), 2);
                var sumatorioKilos = decimal.Round(lineas.Sum(l => l.Kgs.Value), 2);

                lineasLiquidacionViewModel.Add(new LineaLiquidacionViewModel()
                {
                    Bultos = lineas.Sum(l => l.Cajas.Value),
                    CodigoArticulo = groupedLinea.Key.ToString(),
                    Kilos = sumatorioKilos,
                    PrecioMedio = precioMedio,
                    Total = decimal.Round(sumatorioKilos * precioMedio, 2) 
                });
            }

            return new LiquidacionesViewModel()
            {
                Total = lineasLiquidacionViewModel.Sum(l => l.Total),
                LineasLiquidacion = new BindingList<LineaLiquidacionViewModel>(lineasLiquidacionViewModel)
            };
        }

        public static LiquidacionesViewModel MapToLiquidacion(List<LineaAlbaran> repositoryLineasAlbaran)
        {
            var groupedLineas = repositoryLineasAlbaran.GroupBy(lf => lf.ProductoId);

            var lineasLiquidacionViewModel = new List<LineaLiquidacionViewModel>();
            foreach (var groupedLinea in groupedLineas)
            {
                var lineas = groupedLinea.ToList();

                var sumatorioprecios = lineas.Sum(l => l.Precio);
                var numeroLineas = lineas.Count();
                var precioMedio = decimal.Round((sumatorioprecios.Value / numeroLineas), 2);
                var sumatorioKilos = decimal.Round(lineas.Sum(l => l.Kgs.Value), 2);

                lineasLiquidacionViewModel.Add(new LineaLiquidacionViewModel()
                {
                    Bultos = lineas.Sum(l => l.Cajas.Value),
                    CodigoArticulo = groupedLinea.Key.ToString(),
                    Kilos = sumatorioKilos,
                    PrecioMedio = precioMedio,
                    Total = decimal.Round(sumatorioKilos * precioMedio, 2)
                });
            }

            return new LiquidacionesViewModel()
            {
                Total = lineasLiquidacionViewModel.Sum(l => l.Total),
                LineasLiquidacion = new BindingList<LineaLiquidacionViewModel>(lineasLiquidacionViewModel)
            };
        }

        #endregion
    }
}
