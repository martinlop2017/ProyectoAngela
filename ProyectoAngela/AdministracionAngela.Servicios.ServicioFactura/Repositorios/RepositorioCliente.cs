using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdministracionAngela.CapaDePersistencia;
using System.Linq;

namespace AdministracionAngela.Servicios.ServicioDatos.Repositorios
{
    public class RepositorioCliente : IRepositorioCliente
    {
        DBAdministracionAngela db;
        public RepositorioCliente()
        {
            db = new DBAdministracionAngela();
        }
        public Cliente GetClientePorNombre(string nombreCliente)
        {
            return db.Cliente.SingleOrDefault(c => c.Nombre.Equals(nombreCliente));
        }
    }
}
