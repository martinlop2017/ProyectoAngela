using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdministracionAngela.Servicios.ServicioDatos.Repositorios;
using AdministracionAngela.Utils.Interfaces;
using AdministracionAngela.Utils.Mappers;
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
            var ivasFromRepository = this.repositoryIVA.GetAllIVAs();
            return MapToViewModel.MapListToGestionIVA(ivasFromRepository);
        }

        public void SaveIVA(List<IVAViewModel> mappedRows)
        {
            var ivastoSave = MapToRepository.MapListOfIVAViewModel(mappedRows);
            //this.repositoryIVA.DeleteIVAs(ivastoSave);
            foreach(var iva in ivastoSave)
            {
                var isUpdate = iva.Id != 0;
                if(isUpdate)
                {
                    this.repositoryIVA.UpdateIVA(iva);
                }
                else
                {
                    this.repositoryIVA.SaveIVA(iva);
                }
            }
            //this.repositoryIVA.SaveListOfIVA(ivastoSave);
        }
    }
}
