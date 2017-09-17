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

        public IVA GetIVAByDescription(string selectedIVA)
        {
            try
            {
                return this.dbContext.IVAs.SingleOrDefault(iva => iva.Descripcion.Equals(selectedIVA));
            }
            catch(Exception exp)
            {
                throw;
            }
        }

        public bool IVAExists(IVA iva)
        {
            return this.dbContext.IVAs.Any(i => i.Id == iva.Id);
        }

        public void SaveIVA(IVA iva)
        {
            this.dbContext.IVAs.Add(iva);
            this.dbContext.SaveChanges();
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

        public void UpdateIVA(IVA iva)
        {
            var ivaToUpdate = this.dbContext.IVAs.Find(iva.Id);

            if(ivaToUpdate != null)
            {
                ivaToUpdate.Descripcion = iva.Descripcion;
                ivaToUpdate.Porcentaje = iva.Porcentaje;
                ivaToUpdate.PorcentanjeRE = iva.PorcentanjeRE;
                this.dbContext.SaveChanges();
            }
        }
    }
}
