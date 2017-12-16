using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdministracionAngela.EFRepository;

namespace AdministracionAngela.Servicios.ServicioDatos.Repositorios
{
    public interface IRepositorioSistema
    {
        void UpdateFormaDePago(FormaPago formaDePago);
        void SaveFormaDePago(FormaPago formaDePago);
        List<FormaPago> GetAllFormasDePago();
    }
}
