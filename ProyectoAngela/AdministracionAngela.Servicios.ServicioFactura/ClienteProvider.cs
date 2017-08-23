using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdministracionAngela.Servicios.ServicioDatos.Repositorios;

namespace AdministracionAngela.Servicios.ServicioDatos
{
    public class ClienteProvider
    {
        IRepositorioCliente repositorioCliente;

        public ClienteProvider(IRepositorioCliente repositorioCliente)
        {
            this.repositorioCliente = repositorioCliente;
        }

        //necesito crear el modelo de dominio para que aqui se devuelva el cliente del dominio y para que se haga un mapeo si es necesario
        public long GetClientePorNombre(string nombreCliente)
        {
            var cliente = this.repositorioCliente.GetClientePorNombre(nombreCliente);

            return cliente.NIF.Value;
        }
    }
}
