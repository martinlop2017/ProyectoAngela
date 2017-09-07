using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministracionAngela.Utils.Models.IVA
{
    public class IVAViewModel
    {
        public decimal Porcentaje { get; set; }
        public decimal RecargoEquivalencia { get; set; }
        public string Descripcion { get; set; }

        public IVAViewModel()
        {
            
        }
    }
}
