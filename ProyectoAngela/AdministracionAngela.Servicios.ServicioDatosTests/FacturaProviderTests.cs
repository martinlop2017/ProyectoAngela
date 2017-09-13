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
using AdministracionAngela.EFRepository;

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
            var mockRepositorioCliente = new Mock<IRepositorioCliente>();

            var clientList = new List<Cliente>()
            {
                new Cliente()
                {
                    Id = 1,
                    Nombre = "Test1"
                },
                new Cliente()
                {
                    Id = 2,
                    Nombre = "Test2"
                },
                new Cliente()
                {
                    Id = 3,
                    Nombre = "Test3"
                }
            };

            mockRepositorioCliente.Setup(mock => mock.GetAllClients()).Returns(clientList);

            this.facturaProvider = new FacturaProvider(mockRepositorioFactura.Object, mockRepositorioCliente.Object);

            var facturaViewModel = this.facturaProvider.GetFacturaViewModel();

            Assert.Equal(3, facturaViewModel.ClienteIdsAndDescripciones.Count);
            Assert.Equal("1 - Test1", facturaViewModel.ClienteIdsAndDescripciones.Keys.ElementAt(0));
            Assert.Equal("2 - Test2", facturaViewModel.ClienteIdsAndDescripciones.Keys.ElementAt(1));
            Assert.Equal("3 - Test3", facturaViewModel.ClienteIdsAndDescripciones.Keys.ElementAt(2));
        }
    }
}
