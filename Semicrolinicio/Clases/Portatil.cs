using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semicrolinicio.Clases
{
    class Portatil : Ordenador
    {
        public Portatil(CPU cPU): base(cPU, new Monitor(15))
        {
            PorcentajeBateria = 0;            
        }

        public int PorcentajeBateria { get; set; }



        public void CargarBateria()
        {
            Console.WriteLine("La batería se ha cargado.");
            PorcentajeBateria = 100;
        }

        public override void Encender()
        {
            if (PorcentajeBateria > 0)
            {
                Console.WriteLine("El portátil de enciende despacio.");
                base.Encender();
                Console.WriteLine("El portátil terminó de encender.");
            }
            else
            {
                Console.WriteLine("El ordenador no tiene suficiente batería para encenderse.");
            }
        }
    }
}
