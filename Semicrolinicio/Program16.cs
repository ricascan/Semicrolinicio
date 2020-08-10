using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Semicrolinicio.Clases;

namespace Semicrolinicio
{
    class Program16
    {
        static void Main(string[] args)
        {

            Ordenador ordenador = new Ordenador(new CPU(), new Monitor(15));
            ordenador.Encender();

            

            

            Portatil portatil = new Portatil(new CPU());

            portatil.CargarBateria();
            portatil.Encender();
            

            Console.ReadLine();
        }

        
        
    }
}
