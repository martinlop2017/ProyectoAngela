using AdministracionAngela.EFRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministracionAngela.Servicios.ServicioDatos.Repositorios
{
    public class RepositorioSistema : IRepositorioSistema
    {
        IAdministracionAngelaContext dbContext;

        public RepositorioSistema(IAdministracionAngelaContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public List<FormaPago> GetAllFormasDePago()
        {
            return this.dbContext.FormasPago.ToList();
        }

        public void SaveFormaDePago(FormaPago formaDePago)
        {
            this.dbContext.FormasPago.Add(formaDePago);
            this.dbContext.SaveChanges();
        }

        public void UpdateFormaDePago(FormaPago formaDePago)
        {
            var formaDePagoToUpdate = this.dbContext.FormasPago.Find(formaDePago.Id);

            if (formaDePagoToUpdate != null)
            {
                formaDePagoToUpdate.Id = formaDePago.Id;
                formaDePagoToUpdate.Concepto = formaDePago.Concepto;
                formaDePagoToUpdate.Dias = formaDePago.Dias;
                this.dbContext.SaveChanges();
            }
        }
    }
}
