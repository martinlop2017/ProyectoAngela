using AdministracionAngela.CapaDePersistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdministracionAngela.Domain;


namespace AdministracionAngela.Domain.Interfaces
{
    public interface IClienteProvider
    {
        GestionCliente GetGestionCliente();
    }
}
