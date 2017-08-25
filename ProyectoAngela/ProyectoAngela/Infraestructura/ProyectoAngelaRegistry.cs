using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StructureMap;
using AdministracionAngela.Servicios.ServicioDatos.Repositorios;
using AdministracionAngela.Domain.Interfaces;
using AdministracionAngela.Servicios.ServicioDatos;
using AdministracionAngela.CapaDePersistencia;
using ProyectoAngela.Utils;

namespace ProyectoAngela.Infraestructura
{
    public class ProyectoAngelaRegistry : Registry
    {
        public ProyectoAngelaRegistry()
        {
            Scan(scan =>
            {
                scan.TheCallingAssembly();
                scan.WithDefaultConventions();
            });

            this.SetUp();
        }

        private void SetUp()
        {
            For<IRepositorioCliente>().Use<RepositorioCliente>();
            For<IClienteProvider>().Use<ClienteProvider>();
            For<IAdministracionAngelaContext>().Use<AdministracionAngelaContext>();
            For<IFormOpener>().Use<FormOpener>();
        }
    }
}
