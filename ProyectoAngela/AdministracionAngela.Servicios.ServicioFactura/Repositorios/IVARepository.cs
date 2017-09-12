using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdministracionAngela.EFRepository;

namespace AdministracionAngela.Servicios.ServicioDatos.Repositorios
{
    public class IVARepository : IRepositoryIVA
    {
        private IAdministracionAngelaContext dbContext;

        public IVARepository(IAdministracionAngelaContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public void DeleteIVAs(List<IVA> ivastoSave)
        {
            try
            {
                var IdsToDelete = ivastoSave.Select(iva => iva.Id).ToList();

                var ivasToDelete = this.dbContext.IVAs.Where(iva => IdsToDelete.Contains(iva.Id));

                if (ivasToDelete.Count() > 0)
                {
                    this.dbContext.IVAs.RemoveRange(ivasToDelete);
                    this.dbContext.SaveChanges();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public List<IVA> GetAllIVAs()
        {
            try
            {
                return this.dbContext.IVAs.ToList<IVA>();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public void SaveListOfIVA(List<IVA> ivastoSave)
        {
            try
            {
                this.dbContext.IVAs.AddRange(ivastoSave);
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
