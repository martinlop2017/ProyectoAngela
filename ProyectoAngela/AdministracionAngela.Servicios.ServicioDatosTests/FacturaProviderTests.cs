using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdministracionAngela.Servicios.ServicioDatos;
using AdministracionAngela.Servicios.ServicioDatos.Repositorios;
using Xunit;
using AdministracionAngela.Utils.Interfaces;
using Moq;

namespace AdministracionAngela.Servicios.ServicioDatosTests
{
    public class FacturaProviderTests
    {
        private IFacturaProvider facturaProvider;
        public FacturaProviderTests()
        {
        }

        [Fact]
        public void ShouldReturnClientsInComboFormat()
        {
            var mockRepositorioFactura = new Mock<IRepositorioFactura>();
            this.facturaProvider = new FacturaProvider(mockRepositorioFactura.Object);

            this.facturaProvider.GetFacturaViewModel();
        }
    }
}
