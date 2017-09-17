using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdministracionAngela.EFRepository;

namespace AdministracionAngela.Servicios.ServicioDatos.Repositorios
{
    public interface IRepositoryIVA
    {
        void SaveListOfIVA(List<IVA> ivastoSave);
        void DeleteIVAs(List<IVA> ivastoSave);
        List<IVA> GetAllIVAs();
        IVA GetIVAByDescription(string selectedIVA);
    }
}
