using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdministracionAngela.Utils.Models.Articulo;

namespace AdministracionAngela.Utils.Interfaces
{
    public interface IArticuloProvider
    {
        void SaveArticulo(AltaArticuloViewModel nuevoArticulo);
        GestionArticuloViewModel GetGestionArticulo();
        bool DeleteArticulos(List<ArticuloViewModel> articulosToDelete);
        AltaArticuloViewModel GetAltaArticuloById(long articuloId);
        void UpdateArticulo(AltaArticuloViewModel nuevoArticulo);
        AltaArticuloViewModel GetAltaArticulo();
    }
}
