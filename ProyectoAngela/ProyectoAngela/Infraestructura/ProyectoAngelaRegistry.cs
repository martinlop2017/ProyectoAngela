using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StructureMap;
using AdministracionAngela.Servicios.ServicioDatos.Repositorios;
using AdministracionAngela.Servicios.ServicioDatos;
using AdministracionAngela.ProyectoAngela.Utils;
using AdministracionAngela.Utils.Interfaces;
using AdministracionAngela.EFRepository;

namespace AdministracionAngela.ProyectoAngela.Infraestructura
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
            For<IRepositorioArticulo>().Use<RepositorioArticulo>();
            For<IArticuloProvider>().Use<ArticuloProvider>();
            For<IRepositoryIVA>().Use<IVARepository>();
            For<IIVAProvider>().Use<IVAProvider>();
            For<IPerfilProvider>().Use<PerfilProvider>();
            For<IRepositorioPerfil>().Use<RepositorioPerfil>();
            For<IFacturaProvider>().Use<FacturaProvider>();
            For<IRepositorioFactura>().Use<RepositorioFactura>();
            For<IAdministracionAngelaContext>().Use<AdministracionAngelaContext>();
            For<IFormOpener>().Use<FormOpener>();
        }
    }
}
