﻿using AdministracionAngela.CapaDePersistencia;
using AdministracionAngela.Utils;
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
        public void ShouldMapClientFromRepository()
        {
            Cliente repositoryClient = new Cliente();
            repositoryClient.Id = 1;
            repositoryClient.NIF = 1;
            repositoryClient.Nombre = "TestClient1";
            repositoryClient.Direccion = "TestDireccion1";

            var clienteDomain = MapToDomain.MapClient(repositoryClient);

            Assert.Equal(1, clienteDomain.Codigo);
            Assert.Equal("TestClient1", clienteDomain.Nombre);
            Assert.Equal(1, clienteDomain.NIF);
        }

        [Fact]
        public void ShouldMapListOfClientFromRepository()
        {
            var repositoryClients = this.GenerateTestClientList(3);

            var listClientDomain = MapToDomain.MapClientList(repositoryClients);

            Assert.Equal(3, listClientDomain.Count);
            Assert.Equal(listClientDomain[0].Codigo, 0);
            Assert.Equal(listClientDomain[1].Codigo, 1);
            Assert.Equal(listClientDomain[2].Codigo, 2);
            Assert.Equal(listClientDomain[0].Nombre, "TestClient0");
            Assert.Equal(listClientDomain[1].Nombre, "TestClient1");
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
