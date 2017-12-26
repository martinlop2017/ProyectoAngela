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

        public void SaveFactura(AltaFacturaViewModel viewModel)
        {
            var facturaToRepository = MapToRepository.MapAltaFacturaViewModel(viewModel);
            this.repositorioFactura.SaveFactura(facturaToRepository);
        }

        public GestionFacturaViewModel GetGestionFactura()
        {
            var facturas = this.repositorioFactura.GetAllFacturas();
            return MapToViewModel.MapToGestionFactura(facturas);
        }

        public void DeleteFacturas(List<FacturaViewModel> facturasToDelete)
        {
            var repositoryFacturasToDelete = MapToRepository.MapListOfFacturaViewModel(facturasToDelete);

            this.repositorioFactura.DeleteLineasFacturaByNumeroFactura(repositoryFacturasToDelete);
            this.repositorioFactura.DeleteFacturas(repositoryFacturasToDelete);
        }

        public AltaFacturaViewModel GetFacturaViewModelById(long facturaId)
        {
            var clientes = this.repositorioCliente.GetAllClients();
            var articulos = this.repositorioArticulo.GetAllArticulos();

            var facturaFromRepository = this.repositorioFactura.GetFacturaById(facturaId);

            var ivas = this.repositorioIVA.GetAllIVAs();

            return MapToViewModel.MapToUpdateAltaFacturaViewModel(clientes, articulos, facturaFromRepository, ivas);
        }

        public void UpdateFactura(AltaFacturaViewModel viewModel)
        {
            var facturaToRepository = MapToRepository.MapAltaFacturaViewModel(viewModel);
            this.repositorioFactura.UpdateFactura(facturaToRepository);
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

        public LiquidacionesViewModel GetLineasFacturaParaFechas(DateTime startDate, DateTime endDate)
        {
            var lineasFactura = new List<LineaFactura>();
            var facturas = this.repositorioFactura.GetAllFacturas().Where(f => f.Fecha.Value > startDate && f.Fecha.Value < endDate).ToList();
            facturas.ForEach(f => lineasFactura.AddRange(f.LineaFactura));

            return MapToViewModel.MapToLiquidacion(lineasFactura);
        }
    }
}
