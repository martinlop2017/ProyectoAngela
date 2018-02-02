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
using AdministracionAngela.Utils.Models.Factura;

namespace AdministracionAngela.Servicios.ServicioDatosTests
{
    public class FacturaProviderTests
    {
        private IFacturaProvider facturaProvider;
        Mock<IRepositorioFactura> mockRepositorioFactura;
        Mock<IRepositorioCliente> mockRepositorioCliente;
        Mock<IRepositoryIVA> mockRepositorioIVA;
        Mock<IRepositorioArticulo> mockRepositorioArticulo;
        Mock<IRepositorioPerfil> mockRepositorioPerfil;

        public FacturaProviderTests()
        {
            mockRepositorioFactura = new Mock<IRepositorioFactura>();
            mockRepositorioCliente = new Mock<IRepositorioCliente>();
            mockRepositorioIVA = new Mock<IRepositoryIVA>();
            mockRepositorioArticulo = new Mock<IRepositorioArticulo>();
            mockRepositorioPerfil = new Mock<IRepositorioPerfil>();
        }

        [Fact]
        public void ShouldReturnClientsInComboFormat()
        {
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
            mockRepositorioFactura.Setup(mock => mock.GetLastFactura()).Returns(new Factura());
            mockRepositorioIVA.Setup(mock => mock.GetAllIVAs()).Returns(new List<IVA>());
            mockRepositorioArticulo.Setup(mock => mock.GetAllArticulos()).Returns(new List<Producto>());

            this.facturaProvider = new FacturaProvider(mockRepositorioFactura.Object, mockRepositorioCliente.Object, mockRepositorioIVA.Object, mockRepositorioArticulo.Object, mockRepositorioPerfil.Object);

            var facturaViewModel = this.facturaProvider.GetFacturaViewModel();

            Assert.Equal(3, facturaViewModel.ClienteIdsAndDescripciones.Count);
            Assert.Equal("1 - Test1", facturaViewModel.ClienteIdsAndDescripciones.Keys.ElementAt(0));
            Assert.Equal("2 - Test2", facturaViewModel.ClienteIdsAndDescripciones.Keys.ElementAt(1));
            Assert.Equal("3 - Test3", facturaViewModel.ClienteIdsAndDescripciones.Keys.ElementAt(2));
        }

        [Fact]
        public void Should_Return_Correct_IdFactura()
        {
            var facturaReturned = new Factura()
            {
                NumeroFactura = 4
            };

            mockRepositorioCliente.Setup(mock => mock.GetAllClients()).Returns(new List<Cliente>());
            mockRepositorioFactura.Setup(mock => mock.GetLastFactura()).Returns(facturaReturned);
            mockRepositorioIVA.Setup(mock => mock.GetAllIVAs()).Returns(new List<IVA>());
            mockRepositorioArticulo.Setup(mock => mock.GetAllArticulos()).Returns(new List<Producto>());

            this.facturaProvider = new FacturaProvider(mockRepositorioFactura.Object, mockRepositorioCliente.Object, mockRepositorioIVA.Object, mockRepositorioArticulo.Object, mockRepositorioPerfil.Object);

            var facturaViewModel = this.facturaProvider.GetFacturaViewModel();

            Assert.Equal(5, facturaViewModel.NumeroFactura);
        }

        [Fact]
        public void Should_Get_As_Many_Lines_Of_IVA_As_IVAs_Present()
        {
            var facturaReturned = new Factura()
            {
                NumeroFactura = 4
            };

            var ivasReturned = new List<IVA>()
            {
                new IVA() {Porcentaje = 5},
                new IVA() {Porcentaje = 1}
            };

            mockRepositorioCliente.Setup(mock => mock.GetAllClients()).Returns(new List<Cliente>());
            mockRepositorioFactura.Setup(mock => mock.GetLastFactura()).Returns(facturaReturned);
            mockRepositorioIVA.Setup(mock => mock.GetAllIVAs()).Returns(ivasReturned);
            mockRepositorioArticulo.Setup(mock => mock.GetAllArticulos()).Returns(new List<Producto>());

            this.facturaProvider = new FacturaProvider(mockRepositorioFactura.Object, mockRepositorioCliente.Object, mockRepositorioIVA.Object, mockRepositorioArticulo.Object, mockRepositorioPerfil.Object);

            var facturaViewModel = this.facturaProvider.GetFacturaViewModel();

            Assert.Equal(2, facturaViewModel.LineasIVA.Count);
        }

        [Fact]
        public void Should_Calculate_IVAs_With_Two_Different_IVAs()
        {
            IVA iva1 = new IVA()
            {
                Id = 1,
                Porcentaje = 21
            };

            IVA iva2 = new IVA()
            {
                Id = 2,
                Porcentaje = 10,
            };

            Producto p1 = new Producto()
            {
                Id = 1,
                CodigoProducto = 1,
                IVAId = 1,
                IVA = iva1
            };

            Producto p2 = new Producto()
            {
                Id = 2,
                CodigoProducto = 2,
                IVAId = 1,
                IVA = iva1
            };

            Producto p3 = new Producto()
            {
                Id = 3,
                CodigoProducto = 3,
                IVAId = 2,
                IVA = iva2
            };

            AltaFacturaViewModel altaFacturaViewModel = new AltaFacturaViewModel()
            {
                LineasFactura = new List<LineaFacturaViewModel>()
                {
                    new LineaFacturaViewModel()
                    {
                        Importe = 5,
                        ProductoId = Convert.ToInt32(p1.Id)
                    },
                    new LineaFacturaViewModel()
                    {
                        Importe = 10,
                        ProductoId = Convert.ToInt32(p2.Id)
                    },
                    new LineaFacturaViewModel()
                    {
                        Importe= 7,
                        ProductoId = Convert.ToInt32(p3.Id)
                    }
                },
                LineasIVA = new List<LineaIVAViewModel>()
                {
                    new LineaIVAViewModel()
                    {
                        PorcentajeIVA = 21
                    },
                    new LineaIVAViewModel()
                    {
                        PorcentajeIVA = 10
                    }
                }
            };

            mockRepositorioArticulo.Setup(m => m.GetArticuloById(1)).Returns(p1);
            mockRepositorioArticulo.Setup(m => m.GetArticuloById(2)).Returns(p2);
            mockRepositorioArticulo.Setup(m => m.GetArticuloById(3)).Returns(p3);

            this.facturaProvider = new FacturaProvider(mockRepositorioFactura.Object, mockRepositorioCliente.Object, mockRepositorioIVA.Object, mockRepositorioArticulo.Object, mockRepositorioPerfil.Object);

            var result = this.facturaProvider.CalculateIVAs(altaFacturaViewModel);

            //P1 and P2 has the same IVA, P3 has a different IVA
            Assert.Equal(2, result.Count);
            Assert.Equal(15, result[0].BaseIVA);
            Assert.Equal(21, result[0].PorcentajeIVA);
            Assert.Equal(Convert.ToDecimal(15 * 0.21), result[0].ImporteIVA);
            Assert.Equal(7, result[1].BaseIVA);
            Assert.Equal(10, result[1].PorcentajeIVA);
            Assert.Equal(Convert.ToDecimal(7 * 0.1), result[1].ImporteIVA);
        }
    }
}
