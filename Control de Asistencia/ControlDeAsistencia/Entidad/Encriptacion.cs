using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public static class Encriptacion
    {
        public static string Encriptado(String cadena)
        {
            String resultado = String.Empty;
            byte[] encriptado = System.Text.Encoding.Unicode.GetBytes(cadena);
            resultado = Convert.ToBase64String(encriptado);
            return resultado;
        }

        public static string Desencriptado(String cadena)
        {

            String resultado = String.Empty;

            byte[] desencriptar = Convert.FromBase64String(cadena);
            resultado = System.Text.Encoding.Unicode.GetString(desencriptar);
            return resultado;
        }
    }
}
