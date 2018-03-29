using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public static class EnvioCorreo
    {
        public static bool Enviar()
        {
            bool blResuktado = false;
            try
            {
                blResuktado = true;

            }
            catch (Exception ex)
            {
                blResuktado = false;
                throw new Exception(ex.Message);
            }
            return blResuktado;
        }
    }
}
