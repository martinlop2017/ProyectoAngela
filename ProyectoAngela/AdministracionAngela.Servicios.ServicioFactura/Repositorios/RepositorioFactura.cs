using System;
using System.Collections.Generic;
using System.Linq;
using AdministracionAngela.EFRepository;
using System.Data.Entity.Core.Objects;
using System.Data.Entity;

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
                var facturasToDelete = this.dbContext.Facturas.Where(f => numerosFactura.Contains(f.NumeroFactura)).ToList();

                DeleteLineasFacturaByNumeroFactura(facturasToDelete);
                this.dbContext.Facturas.RemoveRange(facturasToDelete);
                this.dbContext.SaveChanges();
                //this.dbContext.ReloadEntities<Albaran>();

            }
            catch (Exception exp)
            {

            }
        }

        public void DeleteAlbaranes(List<Albaran> repositoryAlbaranesToDelete)
        {
            try
            {
                var numerosAlbaran = repositoryAlbaranesToDelete.Select(f => f.NumeroAlbaran);
                var albaranesToDelete = this.dbContext.Albaranes.Where(f => numerosAlbaran.Contains(f.NumeroAlbaran)).ToList();

                DeleteLineasAlbaranByNumeroAlbaran(albaranesToDelete);
                this.dbContext.Albaranes.RemoveRange(albaranesToDelete);
                this.dbContext.SaveChanges();
            }
            catch (Exception exp)
            {

            }
        }
        
        public bool ReiniciarBaseDAtos()
        {
            return this.dbContext.ReiniciarBaseDatos();
        }
         

        public void DeleteLineasFacturaByNumeroFactura(List<Factura> repositoryFacturasToDelete)
        {
            try
            {
                var facturasID = repositoryFacturasToDelete.Select(f => f.Id);
                var lineasFacturaToDelete = this.dbContext.LineasFactura.Where(lf => facturasID.Contains(lf.FacturaId)).ToList();

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
                var albaranId = repositoryAlbaranesToDelete.Select(f => f.Id);
                var lineasAlbaranToDelete = this.dbContext.LineasAlbaran.Where(lf => albaranId.Contains(lf.AlbaranId)).ToList();

                this.dbContext.LineasAlbaran.RemoveRange(lineasAlbaranToDelete);
                this.dbContext.SaveChanges();
            }
            catch (Exception exp)
            {

            }
        }

        public List<LineaFactura> GetLineasFactura(long facturaId)
        {
            return this.dbContext.LineasFactura.Where(x => x.FacturaId == facturaId).ToList();
        }

        public List<LineaAlbaran> GetLineasAlbaran(long albaranId)
        {
            return this.dbContext.LineasAlbaran.Where(x => x.AlbaranId == albaranId).ToList();
        }

        public List<Factura> GetAllFacturas()
        {
            //this.dbContext.ReloadEntities<Factura>();
            return this.dbContext.Facturas.ToList();
        }

        public List<Factura> GetFacturasByDateRange(DateTime from, DateTime to)
        {
            //this.dbContext.ReloadEntities<Factura>();
            return this.dbContext.Facturas.Where(x => x.Fecha.Value >= from && x.Fecha.Value <= to).ToList();
        }

        public List<Factura> GetFacturasByClienteRange(int fromCodigo, int toCodigo)
        {
            //this.dbContext.ReloadEntities<Factura>();
            return this.dbContext.Facturas.Where(x => x.Cliente.CodigoCliente >= fromCodigo && x.Cliente.CodigoCliente<= toCodigo).ToList();
        }

        public List<Albaran> GetAlbaranesByDateRange(DateTime from, DateTime to)
        {
            //this.dbContext.ReloadEntities<Albaran>();
            return this.dbContext.Albaranes.Where(x => x.Fecha.Value >= from && x.Fecha.Value <= to).ToList();
        }

        public List<Albaran> GetAlbaranesByClienteRange(int fromCodigo, int toCodigo)
        {
            //this.dbContext.ReloadEntities<Albaran>();
            return this.dbContext.Albaranes.Where(x => x.Cliente.CodigoCliente >= fromCodigo && x.Cliente.CodigoCliente <= toCodigo).ToList();
        }

        public List<Factura> GetAllFacurasByClienteId(long clienteId)
        {
            //this.dbContext.ReloadEntities<Factura>();
            return this.dbContext.Facturas.Where(x => x.ClienteId == clienteId).ToList();
        }

        public List<Albaran> GetAllAlbaranes()
        {
            //this.dbContext.ReloadEntities<Albaran>();
            return this.dbContext.Albaranes.ToList();
        }

        public Factura GetFacturaById(long numeroFActura)
        {
            try
            {
                return this.dbContext.Facturas.Single(f => f.NumeroFactura == numeroFActura);
            }
            catch(Exception exp)
            {
                return null;
            }
        }

        public Albaran GetAlbaranById(long numeroAlbaran, bool isAlbaran)
        {
            try
            {
                return this.dbContext.Albaranes.First(a=> a.NumeroAlbaran == numeroAlbaran && a.IsAlbaran == isAlbaran);
            }
            catch (Exception exp)
            {
                return null;
            }
        }

        public Albaran GetLastAlbaran(bool isAlbaran)
        {
            try
            {
                return this.dbContext.Albaranes.OrderByDescending(albaran => albaran.NumeroAlbaran).FirstOrDefault(x => x.IsAlbaran == isAlbaran);
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
                var facturaToupdate = this.dbContext.Facturas.Single(f => f.NumeroFactura == facturaToRepository.NumeroFactura);

                facturaToupdate.ClienteId = facturaToRepository.ClienteId;
                facturaToupdate.Fecha = facturaToRepository.Fecha;
                facturaToupdate.Total = facturaToRepository.Total;
                facturaToupdate.TotalBase = facturaToRepository.TotalBase;
                facturaToupdate.EtiquetaLote = facturaToRepository.EtiquetaLote;
                facturaToupdate.TotalIVA = facturaToRepository.TotalIVA;
                facturaToupdate.TotalRecargoEquivalencia = facturaToRepository.TotalRecargoEquivalencia;
                facturaToupdate.FechaVencimiento = facturaToRepository.FechaVencimiento;

                dbContext.SaveChanges();

                UpdateLineasFactura(facturaToupdate, facturaToRepository.LineaFactura);

            }
            catch(Exception exp)
            {

            }
        }

        private void UpdateLineasFactura(Factura factura, ICollection<LineaFactura> lineas)
        {
            var lineasToDelete = this.dbContext.LineasFactura.Where(x => x.FacturaId.Equals(factura.Id));
            this.dbContext.LineasFactura.RemoveRange(lineasToDelete);
            foreach(var linea in lineas)
            {
                linea.FacturaId = factura.Id;
            }

            this.dbContext.LineasFactura.AddRange(lineas);
            factura.LineaFactura = lineas;

            dbContext.SaveChanges();
        }

        public void UpdateAlbaran(Albaran albaranToRepository)
        {
            try
            {
                var albaranToupdate = this.dbContext.Albaranes.First(f => f.NumeroAlbaran == albaranToRepository.NumeroAlbaran && f.IsAlbaran == albaranToRepository.IsAlbaran);

                albaranToupdate.ClienteId = albaranToRepository.ClienteId;
                albaranToupdate.Fecha = albaranToRepository.Fecha;
                albaranToupdate.Total = albaranToRepository.Total;
                albaranToupdate.TotalBase = albaranToRepository.TotalBase;
                albaranToupdate.EtiquetaLote = albaranToRepository.EtiquetaLote;
                albaranToupdate.IsAlbaran = albaranToRepository.IsAlbaran;

                dbContext.SaveChanges();

                UpdateLineasAlbaran(albaranToupdate.Id, albaranToRepository.LineaAlbaran);
            }
            catch (Exception exp)
            {

            }
        }

        private void UpdateLineasAlbaran(long albaranId, ICollection<LineaAlbaran> lineas)
        {
            var lineasToDelete = this.dbContext.LineasAlbaran.Where(x => x.AlbaranId == albaranId);
            this.dbContext.LineasAlbaran.RemoveRange(lineasToDelete);
            foreach (var linea in lineas)
            {
                linea.AlbaranId = albaranId;
            }

            this.dbContext.LineasAlbaran.AddRange(lineas);

            dbContext.SaveChanges();
        }

        public List<Albaran> GetAlbaranesByIds(List<long> albaranesIds)
        {
            return this.dbContext.Albaranes.Where(a => albaranesIds.Contains(a.NumeroAlbaran) && a.IsAlbaran).ToList();
        }

        public void SetFacturado(long numeroAlbaran)
        {
            var albaranToUpdate = this.dbContext.Albaranes.Single(a => a.NumeroAlbaran == numeroAlbaran && a.IsAlbaran);
            albaranToUpdate.Facturado = true;

            this.dbContext.SaveChanges();
        }

        public bool ExisteFactura(int numeroDocumento)
        {
            return this.dbContext.Facturas.Any(x => x.NumeroFactura == numeroDocumento);
        }

        public bool ExisteAlbaran(int numeroDocumento, bool isDocumento)
        {
            return this.dbContext.Albaranes.Any(x => x.NumeroAlbaran == numeroDocumento && x.IsAlbaran == isDocumento);
        }

        public void SetCobrado(int numeroDocumento, bool cobrado)
        {
            var albaran = this.dbContext.Albaranes.FirstOrDefault(x => x.NumeroAlbaran == numeroDocumento && !x.IsAlbaran);
            if(albaran != null)
            {
                albaran.Cobrado = cobrado;
                this.dbContext.SaveChanges();
            }
        }

        public List<Factura> GetFacturasCaducadas(long fromClientCode, long toClientCode, DateTime fromFehaFactura, DateTime toFechaFactura)
        {
            var facturasCaducadas = this.dbContext.Facturas.Where(x =>
            x.ClienteId >= fromClientCode
            && x.ClienteId <= toClientCode
            && x.Fecha.Value >= fromFehaFactura
            && x.Fecha.Value <= toFechaFactura
            && x.FechaVencimiento.HasValue
            && DbFunctions.TruncateTime(x.FechaVencimiento.Value) < DateTime.Today.Date)
            .ToList();
            return facturasCaducadas;
        }

        public List<Factura> GetFacturasCobradas(long fromClientCode, long toClientCode, DateTime fromFehaFactura, DateTime toFechaFactura)
        {
            var facturasCaducadas = this.dbContext.Facturas.Where(x =>
            x.ClienteId >= fromClientCode
            && x.ClienteId <= toClientCode
            && x.Fecha.Value >= fromFehaFactura
            && x.Fecha.Value <= toFechaFactura
            && !x.FechaVencimiento.HasValue)
            .ToList();
            return facturasCaducadas;
        }

        public List<Factura> GetAllFacturasCaducadas()
        {
            return this.dbContext.Facturas.Where(x =>
            x.FechaVencimiento.HasValue &&
            DbFunctions.TruncateTime(x.FechaVencimiento.Value) < DateTime.Today.Date)
            .ToList();
        }

        public void SetFacturaCobrada(long codigoFactura)
        {
            var factura = this.dbContext.Facturas.FirstOrDefault(x => x.NumeroFactura == codigoFactura);
            factura.FechaVencimiento = null;

            this.dbContext.SaveChanges();
        }
    }
}
