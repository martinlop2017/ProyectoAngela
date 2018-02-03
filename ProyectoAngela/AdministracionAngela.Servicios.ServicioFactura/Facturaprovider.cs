using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdministracionAngela.Servicios.ServicioDatos.Repositorios;
using AdministracionAngela.Utils.Interfaces;
using AdministracionAngela.Utils.Mappers;
using AdministracionAngela.Utils.Models.Factura;
using AdministracionAngela.Utils.Models.Liquidaciones;
using AdministracionAngela.EFRepository;
using AdministracionAngela.Utils.Models.Albaran;
using AdministracionAngela.Utils.Models.Impresion;

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

        public AltaAlbaranViewModel GetAlbaranViewModel()
        {
            var clientes = this.repositorioCliente.GetAllClients();
            var articulos = this.repositorioArticulo.GetAllArticulos();

            var lastAlbaran = this.repositorioFactura.GetLastAlbaran();
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
                var lineaIva = altaFacturaViewModel.LineasIVA.Single(i => i.PorcentajeIVA == iva.Porcentaje.Value);
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
                var lineaIva = altaAlbaranViewModel.LineasIVA.Single(i => i.PorcentajeIVA == iva.Porcentaje.Value);
                lineaIva.BaseIVA += lineaFactura.Importe;
            }

            return altaAlbaranViewModel.LineasIVA;
        }

        public void SaveFactura(AltaFacturaViewModel viewModel)
        {
            var facturaToRepository = MapToRepository.MapAltaFacturaViewModel(viewModel);
            foreach(var lineaFactura in facturaToRepository.LineaFactura)
            {
                var producto = this.repositorioArticulo.GetArticuloById(lineaFactura.ProductoId);
                lineaFactura.FAO = producto.FAO;
                lineaFactura.ZonaCaptura = producto.ZonaCaptura;
                lineaFactura.ArtePesca = producto.ArtePesca;
                lineaFactura.NombreCientifico = producto.NombreCientifico;
                lineaFactura.Lote = string.Format("{0}/{1}", producto.Abreviacion, facturaToRepository.Fecha.Value.ToString("ddMMyyy"));
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

        public LiquidacionesViewModel GetLineasFacturaParaFechas(DateTime startDate, DateTime endDate)
        {
            var lineasFactura = new List<LineaFactura>();
            var facturas = this.repositorioFactura.GetAllFacturas().Where(f => f.Fecha.Value > startDate && f.Fecha.Value < endDate).ToList();
            facturas.ForEach(f => lineasFactura.AddRange(f.LineaFactura));

            return MapToViewModel.MapToLiquidacion(lineasFactura);
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
                    Abreviacion = linea.Producto.Abreviacion
                };

                facturasClientes.Add(facturaCliente);
            }

            return facturasClientes;
        }
    }
}
