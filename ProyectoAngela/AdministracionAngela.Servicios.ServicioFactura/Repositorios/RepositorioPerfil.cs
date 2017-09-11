using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdministracionAngela.EFRepository;
using AdministracionAngela.Utils.Models.Perfil;

namespace AdministracionAngela.Servicios.ServicioDatos.Repositorios
{
    public class RepositorioPerfil : IRepositorioPerfil
    {
        IAdministracionAngelaContext dbContext;

        public RepositorioPerfil(IAdministracionAngelaContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public Perfil GetPerfil()
        {
            try
            {
                return this.dbContext.Perfiles.FirstOrDefault();

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public void SavePerfil(Perfil nuevoPerfil)
        {
            try
            {
                this.dbContext.Perfiles.Add(nuevoPerfil);
                this.dbContext.SaveChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public void UpdatePerfil(Perfil nuevoPerfil)
        {
            try
            {
                var perfilToUpdate = this.dbContext.Perfiles.Find(nuevoPerfil.Id);

                if (perfilToUpdate != null)
                {
                    perfilToUpdate.Nombre = nuevoPerfil.Nombre;
                    perfilToUpdate.NIF = nuevoPerfil.NIF;
                    perfilToUpdate.Direccion.Direccion1 = nuevoPerfil.Direccion.Direccion1;
                    perfilToUpdate.Direccion.Poblacion = nuevoPerfil.Direccion.Poblacion;
                    perfilToUpdate.Direccion.Provincia = nuevoPerfil.Direccion.Provincia;
                    perfilToUpdate.Direccion.CodigoPostal = nuevoPerfil.Direccion.CodigoPostal;
                    perfilToUpdate.Contacto.Email = nuevoPerfil.Contacto.Email;
                    perfilToUpdate.Contacto.Fax = nuevoPerfil.Contacto.Fax;
                    perfilToUpdate.Contacto.Telefono1 = nuevoPerfil.Contacto.Telefono1;
                    perfilToUpdate.Contacto.Telefono2 = nuevoPerfil.Contacto.Telefono2;

                    this.dbContext.SaveChanges();
                }
            }
            catch (Exception exp)
            {

            }
        }
    }
}
