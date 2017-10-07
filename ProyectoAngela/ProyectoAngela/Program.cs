﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using AdministracionAngela.Servicios.ServicioDatos;
using AdministracionAngela.Servicios.ServicioDatos.Repositorios;
using StructureMap;
using AdministracionAngela.ProyectoAngela.Infraestructura;
using AdministracionAngela.ProyectoAngela.Utils;
using AdministracionAngela.ProyectoAngela.Formularios;
using ProyectoAngela;

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
            var form = container.GetInstance<Form20>();

            Application.Run(form);
        }
    }
}
