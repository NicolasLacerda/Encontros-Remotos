using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Encontros_Remotos.Classes
{
    public static class Utils
    {
        public static void BarraDeCarregamento(string texto)
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Write(texto);

            for(var i = 0; i < 3; i++) 
            {
                Console.Write(".");
                Thread.Sleep(300);
            }
            Console.Write("Ok");
            Thread.Sleep(1500);
            Console.ResetColor();
        }
    }
}