using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semicrolinicio
{
    class Program5
    {
        static void Main(string[] args)
        {
            Console.WriteLine(sumarNumeros(5, 5));
            Console.WriteLine(sumarNumeros(56.21458741, 23.101487));
            Console.ReadLine();
        }
        static double sumarNumeros(double a, double b)
        {
            return a + b;
        }
    }
}
