using System;
using System.Windows.Forms;
using StructureMap;
using AdministracionAngela.ProyectoAngela.Infraestructura;

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
            var form = container.GetInstance<Formularios.GestionAvisos>();

            Application.Run(form);
        }
    }
}
