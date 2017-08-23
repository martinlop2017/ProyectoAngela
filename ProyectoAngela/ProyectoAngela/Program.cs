using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using AdministracionAngela.Servicios.ServicioDatos;
using AdministracionAngela.Servicios.ServicioDatos.Repositorios;

namespace ProyectoAngela
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ClienteProvider clienteProvider = new ClienteProvider(new RepositorioCliente());
            //var dni = clienteProvider.GetClientePorNombre("Alvaro");
            //Console.WriteLine(string.Format("Nombre: Alvaro,  DNI: {0}", dni));

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ControlUsusarios());

            
        }
    }
}
