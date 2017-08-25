using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdministracionAngela.CapaDePersistencia;

namespace AdministracionAngela.Servicios.ServicioDatos.Repositorios
{
    public class RepositorioCliente : IRepositorioCliente
    {
        AdministracionAngelaContext db;
        public RepositorioCliente()
        {
            db = new AdministracionAngelaContext();
        }
        public Cliente GetClientePorNombre(string nombreCliente)
        {
            return db.Cliente.SingleOrDefault(c => c.Nombre.Equals(nombreCliente));
        }
    }
}
