using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semicrolinicio
{
    class Program10
    {
        static void Main(string[] args)
        {
            Nota nota = new Nota(6.21);
            nota.Valor = 6.21;

            Console.WriteLine(nota.Tipo());
            

            Console.ReadLine();
        }

        
        
    }
}
