using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdministracionAngela.Utils.Models.RutasSalida;
using System.Configuration;
using AdministracionAngela.Utils.Genericos;

namespace AdministracionAngela.Servicios.ServicioDatos.Repositorios
{
    public class AppConfigRepositorio : IAppConfigRepositorio
    {
        ConfigurationSettings appSetting;

        public AppConfigRepositorio()
        {
        }

        public void SaveRutasSalida(RutasSalidaViewModel viewModel)
        {
            RutasSalida.RutaFacturacion = viewModel.PathFacturas;
            RutasSalida.RutaAlbaranes = viewModel.PathAlbaranes;
            RutasSalida.RutaAlbaranes2 = viewModel.PathAlbaranes2;
            RutasSalida.RutaLiquidaciones = viewModel.PathLiquidaciones;
            RutasSalida.RutaListados = viewModel.PathListados;
            RutasSalida.RutaSeguridad = viewModel.PathSeguridad;
            RutasSalida.RutaExcel = viewModel.PathExcel;
        }
    }
}
