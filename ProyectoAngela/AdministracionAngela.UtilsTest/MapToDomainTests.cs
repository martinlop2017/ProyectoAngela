using AdministracionAngela.Utils;
using AdministracionAngela.Utils.Mappers;
using AdministracionAngela.EFRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace AdministracionAngela.UtilsTest
{
    public class MapToDomainTests
    {
        public MapToDomainTests()
        {

        }

        [Fact]
        public void Should_Map_Client_From_Repository()
        {
            Cliente repositoryClient = new Cliente();
            repositoryClient.Id = 1;
            repositoryClient.NIF = 1;
            repositoryClient.Nombre = "TestClient1";
            repositoryClient.Direccion = "TestDireccion1";

            var clienteViewModel = MapToViewModel.MapClient(repositoryClient);

            Assert.Equal(1, clienteViewModel.Codigo);
            Assert.Equal("TestClient1", clienteViewModel.Nombre);
            //Assert.Equal(1, clienteViewModel.NIF);
        }

        [Fact]
        public void Should_Map_List_Of_Client_From_Repository()
        {
            var repositoryClients = this.GenerateTestClientList(3);

            var listClientDomain = MapToViewModel.MapClientList(repositoryClients);

            Assert.Equal(3, listClientDomain.Count);
            Assert.Equal(0, listClientDomain[0].Codigo);
            Assert.Equal("TestClient1", listClientDomain[1].Nombre);
            //Assert.Equal(2, listClientDomain[2].NIF);
        }

        [Fact]
        public void Should_Map_To_GestionCliente()
        {
            var repositoryClients = this.GenerateTestClientList(3);

            var gestionCliente = MapToViewModel.MapToGestionCliente(repositoryClients);

            Assert.Equal(3, gestionCliente.Clientes.Count);
            Assert.Equal(0, gestionCliente.Clientes[0].Codigo);
            Assert.Equal("TestClient1", gestionCliente.Clientes[1].Nombre);
            //Assert.Equal(2, gestionCliente.Clientes[2].NIF);
        }

        /// <summary>
        /// Generates a list of test clients with the given length
        /// </summary>
        /// <param name="length"></param>
        /// <returns></returns>
        private List<Cliente> GenerateTestClientList(int length)
        {
            List<Cliente> testList = new List<Cliente>();
            for (int i = 0; i < length; i++)
            {
                testList.Add(new Cliente()
                {
                    Id = i,
                    NIF = i,
                    Nombre = string.Format("TestClient{0}", i),
                    Direccion = string.Format("TestDireccion{0}", i)
                });
            }

            return testList;
        }
    }
}
