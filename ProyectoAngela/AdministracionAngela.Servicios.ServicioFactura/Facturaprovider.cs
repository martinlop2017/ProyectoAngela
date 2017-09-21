using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdministracionAngela.Servicios.ServicioDatos.Repositorios;
using AdministracionAngela.Utils.Interfaces;
using AdministracionAngela.Utils.Mappers;
using AdministracionAngela.Utils.Models.Factura;

namespace AdministracionAngela.Servicios.ServicioDatos
{
    public class FacturaProvider : IFacturaProvider
    {
        private IRepositorioFactura repositorioFactura;
        private IRepositorioCliente repositorioCliente;
        private IRepositoryIVA repositorioIVA;
        private IRepositorioArticulo repositorioArticulo;

        public FacturaProvider(IRepositorioFactura repositorioFactura, IRepositorioCliente repositorioCliente, IRepositoryIVA repositorioIVA, IRepositorioArticulo repositorioArticulo)
        {
            this.repositorioFactura = repositorioFactura;
            this.repositorioCliente = repositorioCliente;
            this.repositorioIVA = repositorioIVA;
            this.repositorioArticulo = repositorioArticulo;
        }

        public FacturaViewModel GetFacturaViewModel()
        {
            var clientes = this.repositorioCliente.GetAllClients();
            var articulos = this.repositorioArticulo.GetAllArticulos();

            var lastFactura = this.repositorioFactura.GetLastFactura();
            var numeroFactura = lastFactura != null ? lastFactura.NumeroFactura + 1 : 1;

            var ivas = this.repositorioIVA.GetAllIVAs();

            return MapToViewModel.MapToFacturaViewModel(clientes, articulos, Convert.ToInt32(numeroFactura), ivas);
        }

        public List<LineaIVAViewModel> CalculateIVAs(FacturaViewModel facturaViewModel)
        {
            //reset baseIva, ya que va a ser recalculado
            facturaViewModel.LineasIVA.ForEach(l => l.BaseIVA = 0);
            foreach(var lineaFactura in facturaViewModel.LineasFactura)
            {
                var iva = repositorioArticulo.GetArticuloById(lineaFactura.ProductoId).IVA;
                //Guarda Id de IVA para el mapeo a la hora de guardar la factura
                lineaFactura.IVAId = iva.Id;
                var lineaIva = facturaViewModel.LineasIVA.Single(i => i.PorcentajeIVA == iva.Porcentaje.Value);
                lineaIva.BaseIVA += lineaFactura.Importe;
            }

            return facturaViewModel.LineasIVA;
        }

        public void SaveFactura(FacturaViewModel viewModel)
        {
            var facturaToRepository = MapToRepository.MapFacturaViewModel(viewModel);
            this.repositorioFactura.SaveFactura(facturaToRepository);
        }
    }
}
