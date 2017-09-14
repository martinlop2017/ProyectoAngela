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

        public FacturaProvider(IRepositorioFactura repositorioFactura, IRepositorioCliente repositorioCliente)
        {
            this.repositorioFactura = repositorioFactura;
            this.repositorioCliente = repositorioCliente;
        }

        public FacturaViewModel GetFacturaViewModel()
        {
            var clientes = this.repositorioCliente.GetAllClients();
            var lastFactura = this.repositorioFactura.GetLastFactura();
            var numeroFactura = lastFactura != null ? lastFactura.NumeroFactura + 1 : 1;
            return MapToViewModel.MapToFacturaViewModel(clientes, Convert.ToInt32(numeroFactura));
        }
    }
}
