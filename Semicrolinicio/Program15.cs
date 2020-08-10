using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semicrolinicio
{
    class Program15
    {
        static void Main(string[] args)
        {
            Televisor televisor = new Televisor();
            televisor.NumeroSerie = 4556;
            televisor.Pulgadas = 36;

            televisor.Encender();
            televisor.Apagar();

            

            Console.ReadLine();
        }

        
        
    }
}
