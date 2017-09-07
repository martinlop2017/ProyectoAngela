using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdministracionAngela.Servicios.ServicioDatos.Repositorios;
using AdministracionAngela.Utils.Interfaces;
using AdministracionAngela.Utils.Models.IVA;

namespace AdministracionAngela.Servicios.ServicioDatos
{
    public class IVAProvider : IIVAProvider
    {
        private IRepositoryIVA repositoryIVA;

        public IVAProvider(IRepositoryIVA repositoryIva)
        {
            this.repositoryIVA = repositoryIva;
        }

        public GestionIVAViewModel GetGestionIVA()
        {
            return new GestionIVAViewModel();
        }
    }
}
