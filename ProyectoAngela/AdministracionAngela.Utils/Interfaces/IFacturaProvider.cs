using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdministracionAngela.Utils.Models.Factura;

namespace AdministracionAngela.Utils.Interfaces
{
    public interface IFacturaProvider
    {
        FacturaViewModel GetFacturaViewModel();
        List<LineaIVAViewModel> CalculateIVAs(List<LineaIVAViewModel> lineasIVA);
    }
}
