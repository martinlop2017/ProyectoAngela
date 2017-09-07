using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdministracionAngela.Utils.Interfaces;
using AdministracionAngela.Utils.Mappers;
using AdministracionAngela.Utils.Models.Articulo;

namespace AdministracionAngela.Servicios.ServicioDatos
{
    public class ArticuloProvider : IArticuloProvider
    {
        public ArticuloProvider()
        {
            
        }

        public void SaveArticulo(AltaArticuloViewModel nuevoArticulo)
        {
            var articuloRepositorio = MapToRepository.MapAltaArticuloViewModel(nuevoArticulo);
        }
    }
}
