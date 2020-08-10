using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semicrolinicio
{
    class Program6
    {
        static void Main(string[] args)
        {
            Madalena madalena1 = new Madalena();
            madalena1.Color = "amarilla";
            madalena1.Peso = 5;
            madalena1.Precio = 3;

            Console.WriteLine(madalena1.Precio);
            Console.WriteLine(madalena1.Color);
            Console.WriteLine(madalena1.Peso);
            Console.ReadLine();
        }
        
    }
}
