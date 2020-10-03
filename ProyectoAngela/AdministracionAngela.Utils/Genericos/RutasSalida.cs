using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministracionAngela.Utils.Genericos
{
    public static class RutasSalida
    {
        public static string RutaFacturacion
        { 
            get
            {
                return "C:\\ByMartin\\Factufish\\Facturacion";
            }
            set { } }
        public static string RutaAlbaranes
        {
            get
            {
                return "C:\\ByMartin\\Factufish\\Albaranes";
            }
            set { } }
        public static string RutaAlbaranes2
        {
            get
            {
                return "C:\\ByMartin\\Factufish\\Albaranes 2";
            }
            set { }
        }
        public static string RutaListados
        {
            get
            {
                return "C:\\ByMartin\\Factufish\\Listados";
            }
            set { }
        }
        public static string RutaLiquidaciones
        {
            get
            {
                return "C:\\ByMartin\\Factufish\\Liquidaciones";
            }
            set { }
        }
        public static string RutaSeguridad
        {
            get
            {
                return "C:\\ByMartin\\Factufish\\BackUp";
            }
            set { }
        }
        public static string RutaExcel
        {
            get
            {
                return "C:\\ByMartin\\Factufish\\Excel";
            }
            set { }
        }
    }
}
