using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semicrolinicio
{
    class Program2
    {
        static void Main(string[] args)
        {
            int numero;

            Console.Write("Introduce tu nota: ");
            numero = int.Parse(Console.ReadLine());

            if(numero > 0 && numero < 3)
            {
                Console.WriteLine("Has sacado muy deficiente");
                
            }else if (numero >= 3 && numero < 5)
            {
                Console.WriteLine("Has sacado un insuficiente");
            }
            else if (numero >= 5 && numero < 6)
            {
                Console.WriteLine("Has sacado un aprobado");
            }
            else if (numero >= 6 && numero < 7)
            {
                Console.WriteLine("Has sacado un bien");
            }
            else if (numero >= 7 && numero < 9)
            {
                Console.WriteLine("Has sacado un notable");
            }       
            else
            {
                Console.WriteLine("Has sacado un sobresaliente");                
            }


            Console.ReadLine();
        }
    }
}
