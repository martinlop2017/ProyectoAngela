using AdministracionAngela.Utils.Models.RutasSalida;

namespace AdministracionAngela.Servicios.ServicioDatos.Repositorios
{
    public interface IAppConfigRepositorio
    {
        void SaveRutasSalida(RutasSalidaViewModel viewModel);
    }
}
