using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdministracionAngela.EFRepository;
using AdministracionAngela.Utils.Models.Perfil;

namespace AdministracionAngela.Servicios.ServicioDatos.Repositorios
{
    public interface IRepositorioPerfil
    {
        Perfil GetPerfil();
        void UpdatePerfil(Perfil nuevoPerfil);
        void SavePerfil(Perfil nuevoPerfil);
    }
}
