﻿using System;
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
                var facturasToDelete = this.dbContext.Facturas.Where(f => numerosFactura.Contains(f.NumeroFactura)).ToList();

                DeleteLineasFacturaByNumeroFactura(facturasToDelete);
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
            this.dbContext.ReloadEntities<Factura>();
            return this.dbContext.Facturas.ToList();
        }

        public List<Albaran> GetAllAlbaranes()
        {
            this.dbContext.ReloadEntities<Albaran>();
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

        public Albaran GetAlbaranById(long albaranId, bool isAlbaran)
        {
            try
            {
                return this.dbContext.Albaranes.Find(albaranId, isAlbaran);
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
                var facturaToupdate = this.dbContext.Facturas.Single(f => f.NumeroFactura == facturaToRepository.NumeroFactura);

                facturaToupdate.ClienteId = facturaToRepository.ClienteId;
                facturaToupdate.Fecha = facturaToRepository.Fecha;
                facturaToupdate.Total = facturaToRepository.Total;
                facturaToupdate.TotalBase = facturaToRepository.TotalBase;
                facturaToupdate.EtiquetaLote = facturaToRepository.EtiquetaLote;

                dbContext.SaveChanges();

                UpdateLineasFactura(facturaToupdate.Id, facturaToRepository.LineaFactura);

            }
            catch(Exception exp)
            {

            }
        }

        private void UpdateLineasFactura(long facturaId, ICollection<LineaFactura> lineas)
        {
            var lineasToDelete = this.dbContext.LineasFactura.Where(x => x.FacturaId.Equals(facturaId));
            this.dbContext.LineasFactura.RemoveRange(lineasToDelete);
            foreach(var linea in lineas)
            {
                linea.FacturaId = facturaId;
            }

            this.dbContext.LineasFactura.AddRange(lineas);

            dbContext.SaveChanges();
        }

        public void UpdateAlbaran(Albaran albaranToRepository)
        {
            try
            {
                var albaranToupdate = this.dbContext.Albaranes.Find(albaranToRepository.NumeroAlbaran, albaranToRepository.IsAlbaran);

                albaranToupdate.ClienteId = albaranToRepository.ClienteId;
                albaranToupdate.Fecha = albaranToRepository.Fecha;
                albaranToupdate.Total = albaranToRepository.Total;
                albaranToupdate.TotalBase = albaranToRepository.TotalBase;
                albaranToupdate.EtiquetaLote = albaranToRepository.EtiquetaLote;
                albaranToupdate.IsAlbaran = albaranToRepository.IsAlbaran;

                dbContext.SaveChanges();

                UpdateLineasAlbaran(albaranToRepository);
            }
            catch (Exception exp)
            {

            }
        }

        private void UpdateLineasAlbaran(Albaran albaranToRepository)
        {
            var lineasToDelete = this.dbContext.LineasAlbaran.Where(x => x.NumeroAlbaran.Equals(albaranToRepository.NumeroAlbaran) && x.IsAlbaran == albaranToRepository.IsAlbaran);
            this.dbContext.LineasAlbaran.RemoveRange(lineasToDelete);
            this.dbContext.LineasAlbaran.AddRange(albaranToRepository.LineaAlbaran);

            dbContext.SaveChanges();
        }

        public List<Albaran> GetAlbaranesByIds(List<long> albaranesIds)
        {
            return this.dbContext.Albaranes.Where(a => albaranesIds.Contains(a.NumeroAlbaran) && a.IsAlbaran).ToList();
        }

        public void SetFacturado(long numeroAlbaran)
        {
            var albaranToUpdate = this.dbContext.Albaranes.Find(numeroAlbaran, true);
            albaranToUpdate.Facturado = true;

            this.dbContext.SaveChanges();
        }
    }
}
