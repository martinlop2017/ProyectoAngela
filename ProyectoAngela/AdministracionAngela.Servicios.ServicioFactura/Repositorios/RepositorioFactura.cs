using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdministracionAngela.EFRepository;

namespace AdministracionAngela.Servicios.ServicioDatos.Repositorios
{
    public class RepositorioFactura : IRepositorioFactura
    {
        IAdministracionAngelaContext dbContext;

        public RepositorioFactura(IAdministracionAngelaContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public List<Factura> GetAllFacturas()
        {
            return this.dbContext.Facturas.ToList();
        }

        public Factura GetLastFactura()
        {
            try
            {
                return this.dbContext.Facturas.OrderByDescending(factura => factura.NumeroFactura).FirstOrDefault();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public void SaveFactura(Factura factura)
        {
            try
            {
                this.dbContext.Facturas.Add(factura);
                this.dbContext.SaveChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}
