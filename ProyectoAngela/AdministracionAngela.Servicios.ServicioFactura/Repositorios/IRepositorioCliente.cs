using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdministracionAngela.EFRepository;

namespace AdministracionAngela.Servicios.ServicioDatos.Repositorios
{
    public interface IRepositorioCliente
    {
        List<Cliente> GetAllClients();
        bool SaveClient(Cliente newClient);
        Cliente GetLastClient();
        bool DeleteClients(List<Cliente> repositoryClientstoDelete);
        Cliente GetClientById(long clienteId);
        bool UpdateClient(Cliente newClient);
        void DeleteAddressByClientIds(List<Cliente> repositoryClientstoDelete);
        void DeleteContactsByClientIds(List<Cliente> repositoryClientstoDelete);
        bool GetIsIVASelected(long clienteId);
        bool GetIsRESelected(long clienteId);
    }
}
