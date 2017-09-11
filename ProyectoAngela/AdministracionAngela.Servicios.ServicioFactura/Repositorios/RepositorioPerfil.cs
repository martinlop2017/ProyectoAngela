using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdministracionAngela.EFRepository;

namespace AdministracionAngela.Servicios.ServicioDatos.Repositorios
{
    public class RepositorioPerfil : IRepositorioPerfil
    {
        IAdministracionAngelaContext dbContext;

        public RepositorioPerfil(IAdministracionAngelaContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public Perfil GetPerfil()
        {
            try
            {
                return this.dbContext.Perfiles.FirstOrDefault();

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}
