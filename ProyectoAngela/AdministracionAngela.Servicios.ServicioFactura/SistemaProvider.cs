﻿using AdministracionAngela.Servicios.ServicioDatos.Repositorios;
using AdministracionAngela.Utils.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdministracionAngela.Utils.Mappers;
using AdministracionAngela.Utils.Models.FormaDePago;
using AdministracionAngela.Utils.Models.RutasSalida;

namespace AdministracionAngela.Servicios.ServicioDatos
{
    public class SistemaProvider : ISistemaProvider
    {
        private IRepositorioSistema repositorioSistema;
        private IAppConfigRepositorio appConfigRepositorio;
        private IRepositorioFactura repositorioFactura;

        public SistemaProvider(IRepositorioSistema reposirotioSistema, IRepositorioFactura repositorioFactura, IAppConfigRepositorio appConfigRepositorio)
        {
            this.repositorioSistema = reposirotioSistema;
            this.appConfigRepositorio = appConfigRepositorio;
            this.repositorioFactura = repositorioFactura;
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

        public void SaveRutasSalida(RutasSalidaViewModel viewModel)
        {
            this.appConfigRepositorio.SaveRutasSalida(viewModel);
        }

        public bool HayFacturasCaducadas()
        {
            var facturasCaducadas = repositorioFactura.GetFacturasCaducadas();
            return facturasCaducadas != null && facturasCaducadas.Count > 0;
        }
    }
}
