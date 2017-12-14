using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdministracionAngela.EFRepository;

namespace AdministracionAngela.Servicios.ServicioDatos.Repositorios
{
    public class RepositorioSeguridad : IRepositorioSeguridad
    {
        IAdministracionAngelaContext dbContext;

        public RepositorioSeguridad(IAdministracionAngelaContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public User GetUser(string userName)
        {
            return dbContext.Users.SingleOrDefault(u => u.UserName.Equals(userName));
        }

        public void SaveUser(User newUser)
        {
            this.dbContext.Users.Add(newUser);
            this.dbContext.SaveChanges();
        }
    }
}
