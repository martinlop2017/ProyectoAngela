using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdministracionAngela.EFRepository;

namespace AdministracionAngela.Servicios.ServicioDatos.Repositorios
{
    public interface IRepositorioArticulo
    {
        bool SaveArticulo(Producto articuloRepositorio);
        List<Producto> GetAllArticulos();
        bool DeleteArticulos(List<Producto> repositoryArticulosToDelete);
        Producto GetArticuloById(long articuloId);
        bool UpdateArticulo(Producto articuloRepository);
    }
}
