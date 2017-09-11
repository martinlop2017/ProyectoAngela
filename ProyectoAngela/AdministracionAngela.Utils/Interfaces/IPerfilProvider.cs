using AdministracionAngela.Utils.Models.Perfil;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministracionAngela.Utils.Interfaces
{
    public interface IPerfilProvider
    {
        PerfilViewModel GetPerfil();
        void UpdatePerfil(PerfilViewModel nuevoPerfil);
        void SavePerfil(PerfilViewModel nuevoPerfil);
    }
}
