using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semicrolinicio
{
    class Televisor:Electrodomestico
    {
        public int Pulgadas { get; set; }

        public override void Encender()
        {
            Console.WriteLine("La televisión se ha encendido.");
        }

        public override void Apagar()
        {
            Console.WriteLine("La televisión se ha apagado.");
        }
    }
}
