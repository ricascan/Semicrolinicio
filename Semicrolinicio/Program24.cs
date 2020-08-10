using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibreriaFundanet;
using Semicrolinicio.Clases;

namespace Semicrolinicio
{
    class Program24
    {
        static void Main(string[] args)
        {
            Pack<Golosina, Golosina> pack = new Pack<Golosina, Golosina>(new Golosina("Limón"), new Golosina("Fresa"));
            Console.WriteLine(pack.Elemento1.Sabor);
            Console.WriteLine(pack.Elemento2.Sabor);
            Console.ReadLine();
        }

        

    }
}
