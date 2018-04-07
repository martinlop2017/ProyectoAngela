using AdministracionAngela.EFRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdministracionAngela.Utils.Models.Usuario;

namespace AdministracionAngela.Servicios.ServicioDatos.Repositorios
{
    public interface IRepositorioSeguridad
    {
        User GetUser(string userName);
        void SaveUser(User newUser);
        void UpdateUser(User newUser);
        List<User> GetAllUsers();
    }
}
