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

        public void DeleteFacturas(List<Factura> repositoryFacturasToDelete)
        {
            try
            {
                var numerosFactura = repositoryFacturasToDelete.Select(f => f.NumeroFactura);
                var facturasToDelete = this.dbContext.Facturas.Where(f => numerosFactura.Contains(f.NumeroFactura));

                this.dbContext.Facturas.RemoveRange(facturasToDelete);
                this.dbContext.SaveChanges();
            }
            catch(Exception exp)
            {

            }
        }

        public void DeleteAlbaranes(List<Albaran> repositoryAlbaranesToDelete)
        {
            try
            {
                var numerosAlbaran = repositoryAlbaranesToDelete.Select(f => f.NumeroAlbaran);
                var albaranesToDelete = this.dbContext.Albaranes.Where(f => numerosAlbaran.Contains(f.NumeroAlbaran));

                this.dbContext.Albaranes.RemoveRange(albaranesToDelete);
                this.dbContext.SaveChanges();
            }
            catch (Exception exp)
            {

            }
        }

        public void DeleteLineasFacturaByNumeroFactura(List<Factura> repositoryFacturasToDelete)
        {
            try
            {
                var numerosFactura = repositoryFacturasToDelete.Select(f => f.NumeroFactura);
                var lineasFacturaToDelete = this.dbContext.LineasFactura.Where(lf => numerosFactura.Contains(lf.NumeroFactura)).ToList();

                this.dbContext.LineasFactura.RemoveRange(lineasFacturaToDelete);
                this.dbContext.SaveChanges();
            }
            catch(Exception exp)
            {

            }
        }

        public void DeleteLineasAlbaranByNumeroAlbaran(List<Albaran> repositoryAlbaranesToDelete)
        {
            try
            {
                var numerosAlbaran = repositoryAlbaranesToDelete.Select(f => f.NumeroAlbaran);
                var lineasAlbaranToDelete = this.dbContext.LineasAlbaran.Where(lf => numerosAlbaran.Contains(lf.NumeroAlbaran)).ToList();

                this.dbContext.LineasAlbaran.RemoveRange(lineasAlbaranToDelete);
                this.dbContext.SaveChanges();
            }
            catch (Exception exp)
            {

            }
        }

        public List<Factura> GetAllFacturas()
        {
            return this.dbContext.Facturas.ToList();
        }

        public List<Albaran> GetAllAlbaranes()
        {
            return this.dbContext.Albaranes.ToList();
        }

        public Factura GetFacturaById(long facturaId)
        {
            try
            {
                return this.dbContext.Facturas.Find(facturaId);
            }
            catch(Exception exp)
            {
                return null;
            }
        }

        public Albaran GetAlbaranById(long albaranId)
        {
            try
            {
                return this.dbContext.Albaranes.Find(albaranId);
            }
            catch (Exception exp)
            {
                return null;
            }
        }

        public Albaran GetLastAlbaran()
        {
            try
            {
                return this.dbContext.Albaranes.OrderByDescending(albaran => albaran.NumeroAlbaran).FirstOrDefault();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
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

        public void SaveAlbaran(Albaran albaran)
        {
            try
            {
                this.dbContext.Albaranes.Add(albaran);
                this.dbContext.SaveChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public void SetFacturaImpresa(List<long> selectedFacturaIds)
        {
            try
            {
                var facturas = dbContext.Facturas.Where(f => selectedFacturaIds.Contains(f.NumeroFactura)).ToList();
                facturas.ForEach(f => f.Impreso = true);
                this.dbContext.SaveChanges();
            }
            catch(Exception exp)
            {

            }
        }

        public void SetAlbaranImpresa(List<long> selectedAlbaranIds)
        {
            try
            {
                var albaranes = dbContext.Albaranes.Where(f => selectedAlbaranIds.Contains(f.NumeroAlbaran)).ToList();
                albaranes.ForEach(f => f.Impreso = true);
                this.dbContext.SaveChanges();
            }
            catch (Exception exp)
            {

            }
        }

        public void UpdateFactura(Factura facturaToRepository)
        {
            try
            {
                var facturaToupdate = this.dbContext.Facturas.Find(facturaToRepository.NumeroFactura);

                facturaToupdate.Cliente = facturaToRepository.Cliente;
                facturaToupdate.Fecha = facturaToRepository.Fecha;
                facturaToupdate.LineaFactura = facturaToRepository.LineaFactura;
                facturaToupdate.Total = facturaToRepository.Total;
                facturaToupdate.TotalBase = facturaToRepository.TotalBase;
                facturaToupdate.EtiquetaLote = facturaToRepository.EtiquetaLote;

                dbContext.SaveChanges();
            }
            catch(Exception exp)
            {

            }
        }

        public void UpdateAlbaran(Albaran AlbaranToRepository)
        {
            try
            {
                var albaranToupdate = this.dbContext.Albaranes.Find(AlbaranToRepository.NumeroAlbaran);

                albaranToupdate.Cliente = AlbaranToRepository.Cliente;
                albaranToupdate.Fecha = AlbaranToRepository.Fecha;
                albaranToupdate.LineaAlbaran = AlbaranToRepository.LineaAlbaran;
                albaranToupdate.Total = AlbaranToRepository.Total;
                albaranToupdate.TotalBase = AlbaranToRepository.TotalBase;
                albaranToupdate.EtiquetaLote = AlbaranToRepository.EtiquetaLote;
                albaranToupdate.IsAlbaran = AlbaranToRepository.IsAlbaran;

                dbContext.SaveChanges();
            }
            catch (Exception exp)
            {

            }
        }
    }
}
