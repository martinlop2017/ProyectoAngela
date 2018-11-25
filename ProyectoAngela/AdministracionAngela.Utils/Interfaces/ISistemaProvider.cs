using AdministracionAngela.Utils.Models.FormaDePago;
using System.Collections.Generic;
using AdministracionAngela.Utils.Models.RutasSalida;

namespace AdministracionAngela.Utils.Interfaces
{
    public interface ISistemaProvider
    {
        void SaveFormaDePago(List<FormaDePagoViewModel> mappedRows);
        GestionFormaDePagoViewModel GetGestionFormasDePago();
        void SaveRutasSalida(RutasSalidaViewModel viewModel);
        bool HayFacturasCaducadas();
        bool BackUp();
        bool IsNewYear();
        void ReiniciarBaseDatos();
    }
}
