﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using AdministracionAngela.EFRepository;
using AdministracionAngela.Utils.Models.Cliente;


namespace AdministracionAngela.Utils.Interfaces
{
    public interface IClienteProvider
    {
        GestionClienteViewModel GetGestionCliente();
        bool SaveClient(AltaClienteViewModel newClient);
        bool DeleteClients(List<ClienteViewModel> clientsToDelete);
        AltaClienteViewModel GetAltaClienteById(long clienteId);
        AltaClienteViewModel GetAltaCliente();
        bool UpdateClient(AltaClienteViewModel newClient);
        List<AltaClienteViewModel> GetAllClientes();
    }
}
