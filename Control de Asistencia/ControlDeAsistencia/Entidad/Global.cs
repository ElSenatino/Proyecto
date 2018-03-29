using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public static class Global 
    {
        public static  Seguridad.ESesion SesionActiva = new Seguridad.ESesion();

        public static int CalcularEdad(DateTime añoIngresado)
        {
            if (añoIngresado.Year == DateTime.Today.Year)
                return 0;

            return 1 + CalcularEdad(añoIngresado.AddYears(1));
        }
        public static bool ValidarCorreo(String email)
        {
            try
            {
                new MailAddress(email);
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }

        [DllImport("user32.Dll")]
        public static extern IntPtr RemoveMenu(int hMenu, int nPosition, int wFlags);

        //Obtener el menú de sistema
        [DllImport("User32.Dll")]
        public static extern IntPtr GetSystemMenu(int hWnd, bool bRevert);

        //Obtener el número de elementos del menú de sistema
        [DllImport("User32.Dll")]
        public static extern IntPtr GetMenuItemCount(int hMenu);

        //Redibujar la barra de título de la ventana
        [DllImport("User32.Dll")]
        public static extern IntPtr DrawMenuBar(int hwnd);

        private const int MF_BYPOSITION = 0x0400;
        private const int MF_DISABLED = 0x0002;
        public static  void DeshabilitarBotonCerrar(int hWnd)
        {
            IntPtr hMenu;
            IntPtr menuItemCount;
            //Obtener el manejador del menú de sistema del formulario
            hMenu = GetSystemMenu(hWnd, false);
            //Obtener la cuenta de los ítems del menú de sistema.
            //Es el menú que aparece al pulsar sobre el icono a la izquierda
            //de la Barra de título de la ventana, consta de los ítems: Restaurar, Mover,
            //Tamaño,Minimizar, Maximizar, Separador, Cerrar
            menuItemCount = GetMenuItemCount(hMenu.ToInt32());
            //Quitar el ítem Close (Cerrar), que es el último de ese menú
            RemoveMenu(hMenu.ToInt32(), menuItemCount.ToInt32() - 1, MF_DISABLED | MF_BYPOSITION);
            //Quitar el ítem Separador, el penúltimo de ese menú, entre Maximizar y Cerrar
            RemoveMenu(hMenu.ToInt32(), menuItemCount.ToInt32() - 2, MF_DISABLED | MF_BYPOSITION);
            //Redibujar la barra de menú
            DrawMenuBar(hWnd);
        }
       

    }
}
