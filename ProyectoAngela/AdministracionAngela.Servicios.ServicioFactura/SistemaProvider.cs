using AdministracionAngela.Servicios.ServicioDatos.Repositorios;
using AdministracionAngela.Utils.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdministracionAngela.Utils.Mappers;
using AdministracionAngela.Utils.Models.FormaDePago;

namespace AdministracionAngela.Servicios.ServicioDatos
{
    public class SistemaProvider : ISistemaProvider
    {
        private IRepositorioSistema repositorioSistema;

        public SistemaProvider(IRepositorioSistema reposirotioSistema)
        {
            this.repositorioSistema = reposirotioSistema;
        }

        public GestionFormaDePagoViewModel GetGestionFormasDePago()
        {
            var formasDePagoFromRepository = this.repositorioSistema.GetAllFormasDePago();
            return MapToViewModel.MapListToGestionFormaDePago(formasDePagoFromRepository);
        }

        public void SaveFormaDePago(List<FormaDePagoViewModel> mappedRows)
        {
            var formasDePagoToSave = MapToRepository.MapListOfFormaDePagoViewModel(mappedRows);
            foreach (var formaDePago in formasDePagoToSave)
            {
                var isUpdate = formaDePago.Id != 0;
                if (isUpdate)
                {
                    this.repositorioSistema.UpdateFormaDePago(formaDePago);
                }
                else
                {
                    this.repositorioSistema.SaveFormaDePago(formaDePago);
                }
            }
        }
    }
}
