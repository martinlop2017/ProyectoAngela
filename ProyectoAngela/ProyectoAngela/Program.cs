using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using AdministracionAngela.Servicios.ServicioDatos;
using AdministracionAngela.Servicios.ServicioDatos.Repositorios;
using AdministracionAngela.CapaDePersistencia;
using StructureMap;
using AdministracionAngela.ProyectoAngela.Infraestructura;
using AdministracionAngela.ProyectoAngela.Utils;
using AdministracionAngela.ProyectoAngela.Formularios;

namespace AdministracionAngela.ProyectoAngela
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Prepara el contenedor para las dependencias
            var container = Container.For<ProyectoAngelaRegistry>();
            //Resuelve las dependencias para ControlUsuarios
            var form = container.GetInstance<ControlUsusarios>();

            Application.Run(form);
        }
    }
}
