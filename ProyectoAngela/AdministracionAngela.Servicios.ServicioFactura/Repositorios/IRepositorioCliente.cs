using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdministracionAngela.CapaDePersistencia;

namespace AdministracionAngela.Servicios.ServicioDatos.Repositorios
{
    public interface IRepositorioCliente
    {
        Cliente GetClientePorNombre(string nombreCliente);
    }
}
