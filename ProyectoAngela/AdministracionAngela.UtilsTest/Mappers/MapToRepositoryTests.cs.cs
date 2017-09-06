using AdministracionAngela.Utils.Mappers;
using AdministracionAngela.Utils.Models.Cliente;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace AdministracionAngela.UtilsTest.Mappers
{
    public class MapToRepositoryTests
    {
        public MapToRepositoryTests()
        {

        }

        [Fact]
        public void Should_Map_AltaClienteViewModel()
        {
            var clienteViewModel = new AltaClienteViewModel()
            {
                CodigoCliente = 1,
                NIF = "49083366L",
                CodigoPostal = 21045,
                Direccion = "TestAddress",
                Email = "TestEmail@gmail.com",
                Fax = 11,
                FormaDePago = "TestFormaDePago",
                NombreComercial = "TestNombreComercial",
                PersonaDeContacto = "TestPersonaDeContacto",
                Poblacion = "TestPoblacion",
                Provincia = "TestProvincia",
                RiesgoMaximo = 50,
                Telefono1 = 61234567,
                Telefono2 = 67654321
            };

            var newClientRepository = MapToRepository.MapAltaClienteViewModel(clienteViewModel);

            Assert.Equal(1, newClientRepository.Id);
            Assert.Equal(string.Empty, newClientRepository.CIF);
            Assert.Equal("49083366L", newClientRepository.NIF);
            Assert.Equal("TestNombreComercial", newClientRepository.Nombre);
            Assert.Equal("TestAddress", newClientRepository.Direccion);
        }

        [Fact]
        public void Should_Map_ClienteViewModel()
        {
            var clienteViewModel = new ClienteViewModel()
            {
                Nombre = "TestName",
                NIF = "TestNIF",
                Codigo = 1
            };

            var clientRepository = MapToRepository.MapClienteViewModel(clienteViewModel);

            Assert.Equal(1, clientRepository.Id);
            Assert.Equal("TestNIF", clientRepository.NIF);
            Assert.Equal("TestName", clientRepository.Nombre);
        }

        [Fact]
        public void Should_Map_List_Of_ClienteViewModel()
        {
            var listOfClienteViewModel = this.GenerateTestList(3);

            var clientesRepository = MapToRepository.MapListOfClienteViewModel(listOfClienteViewModel);

            Assert.Equal(3, clientesRepository.Count);

            Assert.Equal(0, clientesRepository[0].Id);
            Assert.Equal("TestNIF0", clientesRepository[0].NIF);
            Assert.Equal("TestName0", clientesRepository[0].Nombre);

            Assert.Equal(1, clientesRepository[1].Id);
            Assert.Equal("TestNIF1", clientesRepository[1].NIF);
            Assert.Equal("TestName1", clientesRepository[1].Nombre);

            Assert.Equal(2, clientesRepository[2].Id);
            Assert.Equal("TestNIF2", clientesRepository[2].NIF);
            Assert.Equal("TestName2", clientesRepository[2].Nombre);
        }

        [Fact]
        public void Should_Map_List_Of_ClienteViewModel_With_A_Null_Element()
        {
            var listOfClienteViewModel = this.GenerateTestList(3);

            listOfClienteViewModel.Insert(0, null);

            var clientesRepository = MapToRepository.MapListOfClienteViewModel(listOfClienteViewModel);

            Assert.Equal(3, clientesRepository.Count);

            Assert.Equal(0, clientesRepository[0].Id);
            Assert.Equal("TestNIF0", clientesRepository[0].NIF);
            Assert.Equal("TestName0", clientesRepository[0].Nombre);

            Assert.Equal(1, clientesRepository[1].Id);
            Assert.Equal("TestNIF1", clientesRepository[1].NIF);
            Assert.Equal("TestName1", clientesRepository[1].Nombre);

            Assert.Equal(2, clientesRepository[2].Id);
            Assert.Equal("TestNIF2", clientesRepository[2].NIF);
            Assert.Equal("TestName2", clientesRepository[2].Nombre);
        }

        private List<ClienteViewModel> GenerateTestList(int length)
        {
            List<ClienteViewModel> testList = new List<ClienteViewModel>();
            for (int i = 0; i < length; i++)
            {
                testList.Add(new ClienteViewModel()
                {
                    Nombre = string.Format("TestName{0}", i),
                    NIF = string.Format("TestNIF{0}", i),
                    Codigo = i
                });
            }

            return testList;
        }
    }
}
