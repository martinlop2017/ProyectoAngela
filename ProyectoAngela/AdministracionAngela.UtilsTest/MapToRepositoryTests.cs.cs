using AdministracionAngela.Utils.Mappers;
using AdministracionAngela.Utils.Models.Cliente;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace AdministracionAngela.UtilsTest
{
    public class MapToRepositoryTests
    {
        public MapToRepositoryTests()
        {

        }

        [Fact]
        public void Should_Map_Client_From_ViewModel()
        {
            var clienteViewModel = new AltaClienteViewModel()
            {
                CodigoCliente = 1,
                NIF = "49083366L",
                CodigoPostal = 21045,
                Direccion = "TestAddress",
                Email = "TestEmail@gmail.com",
                Fax = "TestFax",
                FormaDePago = "TestFormaDePago",
                NombreComercial = "TestNombreComercial",
                PersonaDeContacto = "TestPersonaDeContacto",
                Poblacion = "TestPoblacion",
                Provincia = "TestProvincia",
                RiesgoMaximo = 50,
                Telefono1 = 61234567,
                Telefono2 = 67654321
            };

            var newClientRepository = MapToRepository.MapNewClient(clienteViewModel);

            Assert.Equal(1, newClientRepository.Id);
            Assert.Equal(null, newClientRepository.CIF);
            Assert.Equal("49083366L", newClientRepository.NIF);
            Assert.Equal("TestNombreComercial", newClientRepository.Nombre);
            Assert.Equal("TestAddress", newClientRepository.Direccion);
        }
    }
}
