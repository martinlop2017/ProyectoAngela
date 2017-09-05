using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdministracionAngela.EFRepository;
using AdministracionAngela.Utils.Models.Cliente;

namespace AdministracionAngela.Utils.Mappers
{
    public static class MapToRepository
    {
        #region Mapeo de Cliente
        public static Cliente MapNewClient(AltaClienteViewModel nuevoClienteViewModel)
        {
            return new Cliente()
            {

            };
        }
        #endregion
    }
}
