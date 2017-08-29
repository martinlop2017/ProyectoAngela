using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdministracionAngela.Servicios.ServicioDatos.Repositorios;
using AdministracionAngela.Utils.Mappers;
using AdministracionAngela.Utils.Models.Cliente;
using AdministracionAngela.Utils.Interfaces;

namespace AdministracionAngela.Servicios.ServicioDatos
{
    public class ClienteProvider : IClienteProvider
    {
        IRepositorioCliente repositorioCliente;

        public ClienteProvider(IRepositorioCliente repositorioCliente)
        {
            this.repositorioCliente = repositorioCliente;
        }

        public GestionClienteViewModel GetGestionCliente()
        {
            var clientsFromRepository = this.repositorioCliente.GetAllClients();
            return MapToDomain.MapToGestionCliente(clientsFromRepository);
        }
    }
}
