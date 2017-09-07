using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdministracionAngela.Utils.Models.IVA;

namespace AdministracionAngela.Utils.Interfaces
{
    public interface IIVAProvider
    {
        GestionIVAViewModel GetGestionIVA();
    }
}
