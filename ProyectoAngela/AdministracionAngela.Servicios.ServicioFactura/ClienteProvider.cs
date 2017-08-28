using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdministracionAngela.Servicios.ServicioDatos.Repositorios;
using AdministracionAngela.Domain.Interfaces;
using AdministracionAngela.Domain;

namespace AdministracionAngela.Servicios.ServicioDatos
{
    public class ClienteProvider : IClienteProvider
    {
        IRepositorioCliente repositorioCliente;

        public ClienteProvider(IRepositorioCliente repositorioCliente)
        {
            this.repositorioCliente = repositorioCliente;
        }

        public GestionCliente GetGestionCliente()
        {
            this.repositorioCliente.GetAllClients();

            return new GestionCliente();
        }
    }
}
