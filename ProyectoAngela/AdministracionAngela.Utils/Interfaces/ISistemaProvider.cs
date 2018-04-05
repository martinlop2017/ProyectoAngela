using AdministracionAngela.Utils.Models.FormaDePago;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdministracionAngela.Utils.Models.RutasSalida;

namespace AdministracionAngela.Utils.Interfaces
{
    public interface ISistemaProvider
    {
        void SaveFormaDePago(List<FormaDePagoViewModel> mappedRows);
        GestionFormaDePagoViewModel GetGestionFormasDePago();
        void SaveRutasSalida(RutasSalidaViewModel viewModel);
        bool HayFacturasCaducadas();
    }
}
