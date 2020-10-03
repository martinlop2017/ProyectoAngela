using System;
using System.Collections.Generic;
using System.Linq;
using AdministracionAngela.Servicios.ServicioDatos.Repositorios;
using AdministracionAngela.Utils.Interfaces;
using AdministracionAngela.Utils.Mappers;
using AdministracionAngela.Utils.Models.Factura;
using AdministracionAngela.Utils.Models.Liquidaciones;
using AdministracionAngela.EFRepository;
using AdministracionAngela.Utils.Models.Albaran;
using AdministracionAngela.Utils.Models.Impresion;
using AdministracionAngela.Utils.Models.Avisos;
using AdministracionAngela.Utils.Models.Exports;

namespace AdministracionAngela.Servicios.ServicioDatos
{
    public class FacturaProvider : IFacturaProvider
    {
        private IRepositorioFactura repositorioFactura;
        private IRepositorioCliente repositorioCliente;
        private IRepositoryIVA repositorioIVA;
        private IRepositorioArticulo repositorioArticulo;
        private IRepositorioPerfil repositorioPerfil;

        public FacturaProvider(IRepositorioFactura repositorioFactura, IRepositorioCliente repositorioCliente, IRepositoryIVA repositorioIVA, IRepositorioArticulo repositorioArticulo, IRepositorioPerfil repositorioPerfil)
        {
            this.repositorioFactura = repositorioFactura;
            this.repositorioCliente = repositorioCliente;
            this.repositorioIVA = repositorioIVA;
            this.repositorioArticulo = repositorioArticulo;
            this.repositorioPerfil = repositorioPerfil;
        }

        public AltaFacturaViewModel GetFacturaViewModel()
        {
            var clientes = this.repositorioCliente.GetAllClients();
            var articulos = this.repositorioArticulo.GetAllArticulos();

            var lastFactura = this.repositorioFactura.GetLastFactura();
            var numeroFactura = lastFactura != null ? lastFactura.NumeroFactura + 1 : 1;

            var ivas = this.repositorioIVA.GetAllIVAs();

            return MapToViewModel.MapToAltaFacturaViewModel(clientes, articulos, Convert.ToInt32(numeroFactura), ivas);
        }

        public AltaAlbaranViewModel GetAlbaranViewModel(bool isAlbaran)
        {
            var clientes = this.repositorioCliente.GetAllClients();
            var articulos = this.repositorioArticulo.GetAllArticulos();

            var lastAlbaran = this.repositorioFactura.GetLastAlbaran(isAlbaran);
            var numeroAlbaran = lastAlbaran != null ? lastAlbaran.NumeroAlbaran + 1 : 1;

            var ivas = this.repositorioIVA.GetAllIVAs();

            return MapToViewModel.MapToAltaAlbaranViewModel(clientes, articulos, Convert.ToInt32(numeroAlbaran), ivas);
        }

        public List<LineaIVAViewModel> CalculateIVAs(AltaFacturaViewModel altaFacturaViewModel)
        {
            //reset baseIva, ya que va a ser recalculado
            altaFacturaViewModel.LineasIVA.ForEach(l => l.BaseIVA = 0);
            foreach(var lineaFactura in altaFacturaViewModel.LineasFactura)
            {
                var iva = repositorioArticulo.GetArticuloById(lineaFactura.ProductoId).IVA;
                //Guarda Id de IVA para el mapeo a la hora de guardar la altaFactura
                lineaFactura.PorcentajeIVA = iva.Porcentaje.Value;
                lineaFactura.PorcentajeRE = iva.PorcentanjeRE.Value;
                var lineaIva = altaFacturaViewModel.LineasIVA.SingleOrDefault(i => i.PorcentajeIVA == iva.Porcentaje.Value);
                if(lineaIva != null)
                    lineaIva.BaseIVA += lineaFactura.Importe;
            }

            return altaFacturaViewModel.LineasIVA;
        }

        public List<LineaIVAViewModel> CalculateIVAs(AltaAlbaranViewModel altaAlbaranViewModel)
        {
            //reset baseIva, ya que va a ser recalculado
            altaAlbaranViewModel.LineasIVA.ForEach(l => l.BaseIVA = 0);
            foreach (var lineaFactura in altaAlbaranViewModel.LineasAlbaran)
            {
                var iva = repositorioArticulo.GetArticuloById(lineaFactura.ProductoId).IVA;
                //Guarda Id de IVA para el mapeo a la hora de guardar la altaFactura
                lineaFactura.PorcentajeIVA = iva.Porcentaje.Value;
                lineaFactura.PorcentajeRE = iva.PorcentanjeRE.Value;
                var lineaIva = altaAlbaranViewModel.LineasIVA.SingleOrDefault(i => i.PorcentajeIVA == iva.Porcentaje.Value);
                if (lineaIva != null)
                    lineaIva.BaseIVA += lineaFactura.Importe;
            }

            return altaAlbaranViewModel.LineasIVA;
        }

        public bool ClienteExcedeRiesgo(AltaFacturaViewModel viewModel)
        {
            var cliente = this.repositorioCliente.GetClientById(viewModel.SelectedClientId);
            var facturas = this.repositorioFactura.GetAllFacurasByClienteId(viewModel.SelectedClientId);
            var totalFacturas = facturas.Sum(x => x.Total) + viewModel.Total;

            return totalFacturas > cliente.RiesgoMaximo;
        }

        public void SaveFactura(AltaFacturaViewModel viewModel)
        {
            var facturaToRepository = MapToRepository.MapAltaFacturaViewModel(viewModel);
            var diasVencimiento = repositorioCliente.GetClientById(viewModel.SelectedClientId).FormaPago.Dias;

            facturaToRepository.FechaVencimiento = diasVencimiento > 0 ? facturaToRepository.Fecha.Value.AddDays(diasVencimiento.Value) : (DateTime?)null;

            foreach(var lineaFactura in facturaToRepository.LineaFactura)
            {
                var producto = this.repositorioArticulo.GetArticuloById(lineaFactura.ProductoId);
                lineaFactura.FAO = producto.FAO;
                lineaFactura.ZonaCaptura = producto.ZonaCaptura;
                lineaFactura.ArtePesca = producto.ArtePesca;
                lineaFactura.NombreCientifico = producto.NombreCientifico;
                lineaFactura.Lote = string.Format("{0}/{1}", producto.Abreviacion, lineaFactura.Lote);
            }
            this.repositorioFactura.SaveFactura(facturaToRepository);
        }

        public void SaveAlbaran(AltaAlbaranViewModel viewModel)
        {
            var albaranToRepository = MapToRepository.MapAltaAlbaranViewModel(viewModel);
            foreach (var lineaAlbaran in albaranToRepository.LineaAlbaran)
            {
                var producto = this.repositorioArticulo.GetArticuloById(lineaAlbaran.ProductoId);
                lineaAlbaran.FAO = producto.FAO;
                lineaAlbaran.ZonaCaptura = producto.ZonaCaptura;
                lineaAlbaran.ArtePesca = producto.ArtePesca;
                lineaAlbaran.NombreCientifico = producto.NombreCientifico;
                lineaAlbaran.Lote = string.Format("{0}/{1}", producto.Abreviacion, albaranToRepository.Fecha.Value.ToString("ddMMyyy"));
            }
            this.repositorioFactura.SaveAlbaran(albaranToRepository);
        }

        public GestionFacturaViewModel GetGestionFactura()
        {
            var facturas = this.repositorioFactura.GetAllFacturas();
            return MapToViewModel.MapToGestionFactura(facturas);
        }

        public GestionFacturaViewModel GetGestionFacturaAlbaranes(bool isAlbaran)
        {
            var albaranes = this.repositorioFactura.GetAllAlbaranes().Where(a => a.IsAlbaran == isAlbaran).ToList();
            return MapToViewModel.MapToGestionAlbaran(albaranes);
        }

        public void DeleteFacturas(List<FacturaViewModel> facturasToDelete)
        {
            var repositoryFacturasToDelete = MapToRepository.MapListOfFacturaViewModel(facturasToDelete);

            this.repositorioFactura.DeleteLineasFacturaByNumeroFactura(repositoryFacturasToDelete);
            this.repositorioFactura.DeleteFacturas(repositoryFacturasToDelete);
        }

        public void DeleteAlbaranes(List<FacturaViewModel> albaranesToDelete)
        {
            var repositoryAlbaranesToDelete = MapToRepository.MapListOfAlbaranViewModel(albaranesToDelete);

            this.repositorioFactura.DeleteLineasAlbaranByNumeroAlbaran(repositoryAlbaranesToDelete);
            this.repositorioFactura.DeleteAlbaranes(repositoryAlbaranesToDelete);
        }

        public AltaFacturaViewModel GetFacturaViewModelById(long numeroFActura)
        {
            var clientes = this.repositorioCliente.GetAllClients();
            var articulos = this.repositorioArticulo.GetAllArticulos();

            var facturaFromRepository = this.repositorioFactura.GetFacturaById(numeroFActura);

            var ivas = this.repositorioIVA.GetAllIVAs();

            return MapToViewModel.MapToUpdateAltaFacturaViewModel(clientes, articulos, facturaFromRepository, ivas);
        }

        //public AltaAlbaranViewModel GetAlbaranViewModelById(long AlbaranId)
        //{
        //    var clientes = this.repositorioCliente.GetAllClients();
        //    var articulos = this.repositorioArticulo.GetAllArticulos();

        //    var albaranFromRepository = this.repositorioFactura.GetAlbaranById(AlbaranId);

        //    var ivas = this.repositorioIVA.GetAllIVAs();

        //    return MapToViewModel.MapToUpdateAltaAlbaranViewModel(clientes, articulos, albaranFromRepository, ivas);
        //}

        public AltaAlbaranViewModel GetAlbaranViewModelById(long numeroAlbaran, bool isAlbaran)
        {
            var clientes = this.repositorioCliente.GetAllClients();
            var articulos = this.repositorioArticulo.GetAllArticulos();

            var albaranFromRepository = this.repositorioFactura.GetAlbaranById(numeroAlbaran, isAlbaran);

            var ivas = this.repositorioIVA.GetAllIVAs();

            return MapToViewModel.MapToUpdateAltaAlbaranViewModel(clientes, articulos, albaranFromRepository, ivas);
        }

        public void UpdateFactura(AltaFacturaViewModel viewModel)
        {
            var facturaToRepository = MapToRepository.MapAltaFacturaViewModel(viewModel);

            var diasVencimiento = repositorioCliente.GetClientById(viewModel.SelectedClientId).FormaPago.Dias;

            facturaToRepository.FechaVencimiento = facturaToRepository.Fecha.Value.AddDays(diasVencimiento.Value);

            foreach (var lineaFactura in facturaToRepository.LineaFactura)
            {
                var producto = this.repositorioArticulo.GetArticuloById(lineaFactura.ProductoId);
                lineaFactura.FAO = producto.FAO;
                lineaFactura.ZonaCaptura = producto.ZonaCaptura;
                lineaFactura.ArtePesca = producto.ArtePesca;
                lineaFactura.NombreCientifico = producto.NombreCientifico;
                var loteOnlyWithNumbers = lineaFactura.Lote.Replace(string.Format("{0}/" ,producto.Abreviacion), "");
                lineaFactura.Lote = string.Format("{0}/{1}", producto.Abreviacion, loteOnlyWithNumbers);
            }

            this.repositorioFactura.UpdateFactura(facturaToRepository);
        }

        public void UpdateAlbaran(AltaAlbaranViewModel viewModel)
        {
            var albaranToRepository = MapToRepository.MapAltaAlbaranViewModel(viewModel);
            this.repositorioFactura.UpdateAlbaran(albaranToRepository);
        }

        public List<ImpresionFactura> GetImpresionFactura(List<long> selectedFacturaIds)
        {
            List<ImpresionFactura> impresionFacturas = new List<ImpresionFactura>();
            var facturas = selectedFacturaIds.Select(f => this.repositorioFactura.GetFacturaById(f)).ToList();
            var perfil = this.repositorioPerfil.GetPerfil();

            foreach (var factura in facturas)
            {
                foreach (var lineaFactura in factura.LineaFactura)
                {

                    impresionFacturas.Add(new ImpresionFactura()
                    {
                        NumeroFactura = (int)factura.NumeroFactura,
                        NombreCliente = factura.Cliente.Nombre,
                        DescripcionProducto = lineaFactura.Producto.Descripcion,
                        Precio = lineaFactura.Precio.Value,
                        NombreEmisor = perfil.Nombre,
                        DNIEmisor = perfil.NIF,
                        DireccionEmisor = perfil.Direccion.LineaDireccion,
                        TelefonoEmisor = perfil.Contacto.Telefono1.ToString()
                    });
                }
            }

            return impresionFacturas;
        }

        public void SetFacturaImpresa(List<long> selectedFacturaIds)
        {
            this.repositorioFactura.SetFacturaImpresa(selectedFacturaIds);
        }

        public void SetAlbaranImpresa(List<long> selectedAlbaranIds)
        {
            this.repositorioFactura.SetAlbaranImpresa(selectedAlbaranIds);
        }

        public LiquidacionesViewModel GetLiquidacionesParaFechas(DateTime startDate, DateTime endDate)
        {
            var lineasFactura = new List<LineaFactura>();
            var facturas = this.repositorioFactura.GetAllFacturas().Where(f => f.Fecha.Value >= startDate && f.Fecha.Value <= endDate.AddDays(1)).ToList();
            facturas.ForEach(f => lineasFactura.AddRange(f.LineaFactura));

            var albaranesSinFacturar = this.repositorioFactura.GetAllAlbaranes().Where(a => a.IsAlbaran && !a.Facturado.Value && a.Fecha.Value > startDate && a.Fecha.Value < endDate).ToList();
            var otrosAlbaranes = this.repositorioFactura.GetAllAlbaranes().Where(a => !a.IsAlbaran & a.Fecha.Value > startDate && a.Fecha.Value < endDate).ToList();
            var lineasAlbaranes = new List<LineaAlbaran>();

            albaranesSinFacturar.ForEach(x => lineasAlbaranes.AddRange(x.LineaAlbaran));
            otrosAlbaranes.ForEach(x => lineasAlbaranes.AddRange(x.LineaAlbaran));

            return MapToViewModel.MapToLiquidacion(lineasFactura, lineasAlbaranes);
        }

        public LiquidacionesViewModel GetLineasAlbaranParaFechas(DateTime startDate, DateTime endDate)
        {
            var lineasAlbaran = new List<LineaAlbaran>();
            var albaranes = this.repositorioFactura.GetAllAlbaranes().Where(f => f.Fecha.Value > startDate && f.Fecha.Value < endDate).ToList();
            albaranes.ForEach(f => lineasAlbaran.AddRange(f.LineaAlbaran));

            return MapToViewModel.MapToLiquidacion(lineasAlbaran);
        }

        public void Facturar(List<long> albaranesIds)
        {
            var albaranes = this.repositorioFactura.GetAlbaranesByIds(albaranesIds);
            var facturas = FacturarAlbaranes(albaranes);

            facturas.ForEach( f => repositorioFactura.SaveFactura(f));
            albaranes.ForEach(a => repositorioFactura.SetFacturado(a.NumeroAlbaran));
        }

        private List<Factura> FacturarAlbaranes(List<Albaran> albaranes)
        {
            List<Factura> facturas = new List<Factura>();
            foreach(var albaran in albaranes)
            {
                facturas.Add(FacturarAlbaran(albaran));
            }

            return facturas;
        }

        private Factura FacturarAlbaran(Albaran albaran)
        {
            var lastFactura = repositorioFactura.GetLastFactura();
            var numeroFactura = lastFactura != null ? lastFactura.NumeroFactura + 1 : 1;
            return new Factura()
            {
                NumeroFactura = numeroFactura,
                ClienteId = albaran.ClienteId.Value,
                Cliente = albaran.Cliente,
                Fecha = albaran.Fecha,
                TotalRecargoEquivalencia = albaran.TotalRecargoEquivalencia,
                TotalBase = albaran.TotalBase,
                Total = albaran.Total,
                TotalIVA = albaran.TotalIVA,
                Impreso = false,
                EtiquetaLote = albaran.EtiquetaLote,
                LineaFactura = FacturarLineasAlbaran(albaran.LineaAlbaran)
            };
        }

        private ICollection<LineaFactura> FacturarLineasAlbaran(ICollection<LineaAlbaran> lineasAlbaran)
        {
            return lineasAlbaran.Select(la => new LineaFactura()
            {
                ProductoId = la.ProductoId,
                Producto = la.Producto,
                PorcentajeIVA = la.PorcentajeIVA,
                PorcentajeRE = la.PorcentajeRE,
                Kgs = la.Kgs,
                Precio = la.Precio,
                Cajas = la.Cajas,
                FAO = la.FAO,
                ZonaCaptura = la.ZonaCaptura,
                NombreCientifico = la.NombreCientifico,
                ArtePesca = la.ArtePesca,
                Lote = la.Lote,
                Importe = la.Importe,
                ImporteIVA = la.ImporteIVA,
                ImporteRE = la.ImporteRE
            })
            .ToList();
        }

        public List<FacturaIva> GetFacturaIva(int numerFactura)
        {
            var result = new List<FacturaIva>();
            var factura = repositorioFactura.GetFacturaById(numerFactura);
            var lineasFActura = repositorioFactura.GetLineasFactura(factura.Id);

            var ivas = repositorioIVA.GetAllIVAs();
            foreach(var iva in ivas)
            {
                var misLineas = lineasFActura.Where(x => x.Producto.IVAId == iva.Id);
                if(misLineas.Count() > 0)
                {
                    result.Add(new FacturaIva()
                    {
                        BaseImponible = misLineas.Sum(x => x.Importe.Value),
                        PorcentajeIVA = iva.Porcentaje.Value,
                        ImporteIVA = misLineas.Sum(x => x.ImporteIVA.Value),
                        PorcentajeRE = iva.PorcentanjeRE.Value,
                        ImporteRE = misLineas.Sum(x => x.ImporteRE.Value),
                    });
                }
            }

            return result;
        }

        public List<FacturaIva> GetAlbaranIva(int numerFactura, bool isAlbaran)
        {
            var result = new List<FacturaIva>();
            var albaran = repositorioFactura.GetAlbaranById(numerFactura, isAlbaran);
            var lineasAlbaran = repositorioFactura.GetLineasAlbaran(albaran.Id);

            var ivas = repositorioIVA.GetAllIVAs();
            foreach (var iva in ivas)
            {
                var misLineas = lineasAlbaran.Where(x => x.Producto.IVAId == iva.Id);
                result.Add(new FacturaIva()
                {
                    BaseImponible = misLineas.Sum(x => x.Importe.Value),
                    PorcentajeIVA = iva.Porcentaje.Value,
                    ImporteIVA = misLineas.Sum(x => x.ImporteIVA.Value),
                    PorcentajeRE = iva.PorcentanjeRE.Value,
                    ImporteRE = misLineas.Sum(x => x.ImporteRE.Value),
                });
            }

            return result;
        }

        public List<FacturaCliente> GetAlbaranCliente(int numeroAlbaran, bool isAlbaran)
        {
            var albaranClientes = new List<FacturaCliente>();
            var albaran = this.repositorioFactura.GetAlbaranById(numeroAlbaran, isAlbaran);
            var cliente = this.repositorioCliente.GetClientById(albaran.ClienteId.Value);
            var lineas = repositorioFactura.GetLineasAlbaran(albaran.Id);
            var perfil = this.repositorioPerfil.GetPerfil();

            foreach (var linea in lineas)
            {
                var albaranCliente = new FacturaCliente()
                {
                    NumeroFactura = numeroAlbaran,
                    Fecha = albaran.Fecha.Value,
                    Dni = cliente.NIF,
                    CodigoArticulo = linea.ProductoId,
                    Descripcion = linea.Producto.Descripcion,
                    Bultos = linea.Cajas.Value,
                    Importe = linea.Importe.Value,
                    Kgs = linea.Kgs.Value,
                    Precio = linea.Precio.Value,
                    Total = albaran.Total.Value,
                    LineaDireccion = cliente.Direccion.LineaDireccion,
                    Provincia = cliente.Direccion.Provincia,
                    Poblacion = cliente.Direccion.Poblacion,
                    CodigoPostal = cliente.Direccion.CodigoPostal.ToString(),
                    NombreEmpresa = perfil.Nombre,
                    DniPerfil = perfil.NIF,
                    CodigoPostalPerfil = perfil.Direccion.CodigoPostal.ToString(),
                    PoblacionPerfil = perfil.Direccion.Poblacion,
                    ProvinciaPerfil = perfil.Direccion.Provincia,
                    LineaDireccionPerfil = perfil.Direccion.LineaDireccion,
                    EmailPerfil = perfil.Contacto.Email,
                    FaxPerfil = perfil.Contacto.Fax.Value,
                    TelefonoPerfil = perfil.Contacto.Telefono1.Value,
                    ZonaCAptura = linea.Producto.ZonaCaptura,
                    Arte = linea.Producto.ArtePesca,
                    FAO = linea.Producto.FAO,
                    NombreCientifico = linea.Producto.NombreCientifico,
                    Abreviacion = linea.Producto.Abreviacion,
                    NombreCliente = cliente.Nombre,
                    EtiquetaLote = albaran.EtiquetaLote,
                    FormaPago = cliente.FormaPago.Concepto
                };

                albaranClientes.Add(albaranCliente);
            }

            return albaranClientes;
        }

        public List<FacturaExport> GetFacturasToExport(List<long> numerosFactura)
        {
            var facturas = this.repositorioFactura.GetFacturas(numerosFactura);
            return MapToViewModel.MapToFacturaExport(facturas);
        }

        public List<FacturaCliente> GetFacturaCliente(int numeroFactura)
        {
            var facturasClientes = new List<FacturaCliente>();
            var factura = this.repositorioFactura.GetFacturaById(numeroFactura);
            var cliente = this.repositorioCliente.GetClientById(factura.ClienteId);
            var lineas = repositorioFactura.GetLineasFactura(factura.Id);
            var perfil = this.repositorioPerfil.GetPerfil();

            foreach(var linea in lineas)
            {
                var facturaCliente = new FacturaCliente()
                {
                    NumeroFactura = numeroFactura,
                    Fecha = factura.Fecha.Value,
                    Dni = cliente.NIF,
                    CodigoArticulo = linea.ProductoId,
                    Descripcion = linea.Producto.Descripcion,
                    Bultos = linea.Cajas.Value,
                    Importe = linea.Importe.Value,
                    Kgs = linea.Kgs.Value,
                    Precio = linea.Precio.Value,
                    Total = factura.Total.Value,
                    LineaDireccion = cliente.Direccion.LineaDireccion,
                    Provincia = cliente.Direccion.Provincia,
                    Poblacion = cliente.Direccion.Poblacion,
                    CodigoPostal = cliente.Direccion.CodigoPostal.ToString(),
                    NombreEmpresa = perfil.Nombre,
                    DniPerfil = perfil.NIF,
                    CodigoPostalPerfil = perfil.Direccion.CodigoPostal.ToString(),
                    PoblacionPerfil = perfil.Direccion.Poblacion,
                    ProvinciaPerfil = perfil.Direccion.Provincia,
                    LineaDireccionPerfil = perfil.Direccion.LineaDireccion,
                    EmailPerfil = perfil.Contacto.Email,
                    FaxPerfil = perfil.Contacto.Fax.Value,
                    TelefonoPerfil = perfil.Contacto.Telefono1.Value,
                    ZonaCAptura = linea.Producto.ZonaCaptura,
                    Arte = linea.Producto.ArtePesca,
                    FAO = linea.Producto.FAO,
                    NombreCientifico = linea.Producto.NombreCientifico,
                    Abreviacion = linea.Producto.Abreviacion,
                    NombreCliente = cliente.Nombre,
                    EtiquetaLote = linea.Lote,
                    FormaPago = cliente.FormaPago.Concepto,
                    NumeroCuenta = string.Format("{0} - {1} - {2} - {3} - {4} - {5}", perfil.Iban1.Trim(), perfil.Iban2.Trim(), perfil.Iban3.Trim(), perfil.Iban4.Trim(), perfil.Iban5.Trim(), perfil.Iban6.Trim())
                };

                facturasClientes.Add(facturaCliente);
            }

            return facturasClientes;
        }

        public bool ExisteFactura(int numeroDocumento)
        {
            return this.repositorioFactura.ExisteFactura(numeroDocumento);
        }

        public bool ExisteAlbaran(int numeroDocumento, bool isDocumento)
        {
            return this.repositorioFactura.ExisteAlbaran(numeroDocumento, isDocumento);
        }

        public void SetCobrado(int numeroDocumento, bool cobrado)
        {
            this.repositorioFactura.SetCobrado(numeroDocumento, cobrado);
        }

        public void LoadIVAAndREBy(AltaFacturaViewModel viewModel)
        {
            var clienteID = viewModel.ClienteIdsAndDescripciones[viewModel.SelectedClient];
            viewModel.FillIVA = repositorioCliente.GetIsIVASelected(clienteID);
            viewModel.FillRE = repositorioCliente.GetIsRESelected(clienteID);

            var ivas = this.repositorioIVA.GetAllIVAs();

            foreach(var lineaIva in viewModel.LineasIVA)
            {
                var iva = ivas.Single(x => x.Id == lineaIva.IvaId);
                lineaIva.PorcentajeIVA = iva.Porcentaje.Value;
                lineaIva.PorcentajeRecargoEquivalencia = iva.PorcentanjeRE.Value;
            }

            if (!viewModel.FillRE)
            {
                viewModel.LineasIVA.ForEach(x => x.PorcentajeRecargoEquivalencia = 0);
            }
            if (!viewModel.FillIVA)
            {
                viewModel.LineasIVA.ForEach(x => x.PorcentajeIVA = 0);
            }
        }

        public void LoadIVAAndREBy(AltaAlbaranViewModel viewModel)
        {
            var clienteID = viewModel.ClienteIdsAndDescripciones[viewModel.SelectedClient];
            viewModel.FillIVA = repositorioCliente.GetIsIVASelected(clienteID);
            viewModel.FillRE = repositorioCliente.GetIsRESelected(clienteID);

            var ivas = this.repositorioIVA.GetAllIVAs();

            foreach (var lineaIva in viewModel.LineasIVA)
            {
                var iva = ivas.Single(x => x.Id == lineaIva.IvaId);
                lineaIva.PorcentajeIVA = iva.Porcentaje.Value;
                lineaIva.PorcentajeRecargoEquivalencia = iva.PorcentanjeRE.Value;
            }

            if (!viewModel.FillRE)
            {
                viewModel.LineasIVA.ForEach(x => x.PorcentajeRecargoEquivalencia = 0);
            }
            if (!viewModel.FillIVA)
            {
                viewModel.LineasIVA.ForEach(x => x.PorcentajeIVA = 0);
            }
        }

        public GestionAvisosViewModel GetGestionFacturasVencidas(long fromClientCode, long toClientCode, DateTime fromFehaFactura, DateTime toFechaFactura, bool checkForPendientes, bool checkForCobradas)
        {
            var facturas = new List<Factura>();
            if (checkForPendientes)
            {
                var facturasPendientes = this.repositorioFactura.GetFacturaPendientes(fromClientCode, toClientCode, fromFehaFactura, toFechaFactura);
                facturas.AddRange(facturasPendientes);
            }
            if (checkForCobradas)
            {
                var facturasCobradas = this.repositorioFactura.GetFacturasCobradas(fromClientCode, toClientCode, fromFehaFactura, toFechaFactura);
                facturas.AddRange(facturasCobradas);
            }
            var sortedFacturas = facturas.OrderBy(x => x.ClienteId).ThenBy(x => x.NumeroFactura).ToList();
            return MapToViewModel.MapToGestionAvisos(sortedFacturas);
        }

        public void SetFacturaCobrada(long codigoFactura, bool cobrada, DateTime fechaCobro)
        {
            this.repositorioFactura.SetFacturaCobrada(codigoFactura, cobrada, fechaCobro);
        }

        public List<ListadoFactura> GetAllFacturasFromDateRange(DateTime from, DateTime to)
        {
            var facturas = repositorioFactura.GetFacturasByDateRange(from, to.AddDays(1).AddSeconds(-1));

            return MapToImpresion.MapListaFactura(facturas);
        }

        public List<ListadoFactura> GetAllFacturasFromClienteRange(int fromCodigo, int toCodigo)
        {
            var facturas = repositorioFactura.GetFacturasByClienteRange(fromCodigo, toCodigo);

            return MapToImpresion.MapListaFactura(facturas);
        }

        public List<ListadoFactura> GetAllFacturasFromClienteAndDateRange(DateTime from, DateTime to, int fromCodigo, int toCodigo)
        {
            var facturasByDateAndCliente = repositorioFactura.GetFacturasByDateRange(from, to.AddDays(1).AddSeconds(-1)).Where(x => x.Cliente.CodigoCliente >= fromCodigo && x.Cliente.CodigoCliente <= toCodigo).ToList();

            return MapToImpresion.MapListaFactura(facturasByDateAndCliente);
        }

        public List<ListadoFactura> GetAllListaFacturas()
        {
            var facturas = repositorioFactura.GetAllFacturas();

            return MapToImpresion.MapListaFactura(facturas);
        }

        public List<ListadoAlbaran> GetAllListaAlbaranes()
        {
            var albaranes = repositorioFactura.GetAllAlbaranes();

            return MapToImpresion.MapListaAlbaran(albaranes);
        }

        public List<ListadoAlbaran> GetAllAlbaranesFromDateRange(DateTime from, DateTime to)
        {
            var albaranes = repositorioFactura.GetAlbaranesByDateRange(from, to.AddDays(1).AddSeconds(-1));

            return MapToImpresion.MapListaAlbaran(albaranes);
        }

        public List<ListadoAlbaran> GetAllAlbaranesFromClienteRange(int fromCodigo, int toCodigo)
        {
            var albaranes = repositorioFactura.GetAlbaranesByClienteRange(fromCodigo, toCodigo);

            return MapToImpresion.MapListaAlbaran(albaranes);
        }

        public List<ListadoAlbaran> GetAllAlbaranesFromClienteAndDateRange(DateTime from, DateTime to, int fromCodigo, int toCodigo)
        {
            var albaranesByDateAndCliente = repositorioFactura.GetAlbaranesByDateRange(from, to.AddDays(1).AddSeconds(-1)).Where(x => x.Cliente.CodigoCliente >= fromCodigo && x.Cliente.CodigoCliente <= toCodigo).ToList();

            return MapToImpresion.MapListaAlbaran(albaranesByDateAndCliente);
        }

        public void SetFechaCobro(long numeroFactura, DateTime fechaCobro)
        {
            repositorioFactura.SetFechaCobro(numeroFactura, fechaCobro);
        }
    }
}
