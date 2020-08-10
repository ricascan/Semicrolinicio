using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semicrolinicio
{
    class Program9
    {
        static void Main(string[] args)
        {
            Rectangulo rectangulo = new Rectangulo(12.3, 8.1);

            Console.WriteLine("Área = " + rectangulo.Area());
            Console.WriteLine("Perímetro = " + rectangulo.Perimetro());

            Console.ReadLine();
        }

        
        
    }
}
