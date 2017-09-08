using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using AdministracionAngela.Utils.Models.Cliente;


namespace AdministracionAngela.Utils.Interfaces
{
    public interface IClienteProvider
    {
        GestionClienteViewModel GetGestionCliente();
        void SaveClient(AltaClienteViewModel newClient);
        bool DeleteClients(List<ClienteViewModel> clientsToDelete);
    }
}
