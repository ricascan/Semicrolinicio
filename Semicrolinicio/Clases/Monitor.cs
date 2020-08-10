using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semicrolinicio.Clases
{
    class Monitor
    {
        public Monitor(double pulgadas)
        {
            Pulgadas = pulgadas;
        }

        public double Pulgadas { get; set; }

        public void Encender()
        {
            Console.WriteLine("El monitor se ha encendido");
        }

        public void Apagar()
        {
            Console.WriteLine("El monitor se ha apagado");
        }
    }
}
