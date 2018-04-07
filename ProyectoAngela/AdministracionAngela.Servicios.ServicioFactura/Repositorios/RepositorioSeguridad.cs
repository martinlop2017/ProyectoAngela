using System.Collections.Generic;
using System.Linq;
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

        public List<User> GetAllUsers()
        {
            return this.dbContext.Users.ToList();
        }

        public User GetUser(string userName)
        {
            return dbContext.Users.SingleOrDefault(u => u.UserName.Equals(userName));
        }

        public void RemoveUser(string userToRemove)
        {
            var user = this.dbContext.Users.FirstOrDefault(x => x.UserName.Equals(userToRemove));
            this.dbContext.Users.Remove(user);

            this.dbContext.SaveChanges();
        }

        public void SaveUser(User newUser)
        {
            this.dbContext.Users.Add(newUser);
            this.dbContext.SaveChanges();
        }

        public void UpdateUser(User newUser)
        {
            var user = this.dbContext.Users.FirstOrDefault(x => x.UserName.Equals(newUser.UserName));

            user.Password = newUser.Password;
            user.Nivel = newUser.Nivel;
            user.Activo = newUser.Activo;

            this.dbContext.SaveChanges();
        }
    }
}
