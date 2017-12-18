using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdministracionAngela.Utils.Models.RutasSalida;
using System.Configuration;

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
        }
    }
}
