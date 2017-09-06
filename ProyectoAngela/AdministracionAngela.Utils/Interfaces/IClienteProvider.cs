using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdministracionAngela.Utils.Models.Cliente;


namespace AdministracionAngela.Utils.Interfaces
{
    public interface IClienteProvider
    {
        GestionClienteViewModel GetGestionCliente();
        void SaveClient(AltaClienteViewModel newClient);
        int GetNextCodigoCliente();
    }
}
