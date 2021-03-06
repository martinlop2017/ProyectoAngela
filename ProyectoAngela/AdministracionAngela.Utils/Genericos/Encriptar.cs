﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministracionAngela.Utils.Genericos
{
    public static class Encriptar
    {
        /// Esta clase contiene funciones para encriptar/desencriptar
        /// El ser estática no es necesario instanciar un objeto para 
        /// usar las funciones Encriptar y DesEncriptar



        /// Encripta una cadena
        public static string codificar(this string _cadenaAencriptar)
        {
            if (string.IsNullOrEmpty(_cadenaAencriptar))
            {
                return string.Empty;
            }

            string result = string.Empty;
            byte[] encryted = System.Text.Encoding.Unicode.GetBytes(_cadenaAencriptar);
            result = Convert.ToBase64String(encryted);
            return result;
        }

        /// Esta función desencripta la cadena que le envíamos en el parámentro de entrada.
        public static string Descodificar(this string _cadenaAdesencriptar)
        {
            if(string.IsNullOrEmpty(_cadenaAdesencriptar))
            {
                return string.Empty;
            }

            string result = string.Empty;
            byte[] decryted = Convert.FromBase64String(_cadenaAdesencriptar);
            result = System.Text.Encoding.Unicode.GetString(decryted);
            return result;
        }
    }
}
