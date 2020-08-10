using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semicrolinicio.Clases
{
    class Segway : IConducible, IConectable
    {
        public void Arrancar()
        {
            Console.WriteLine("El segway arranca.");
        }

        public void Avanzar()
        {
            Console.WriteLine("El segway avanza.");
        }

        public void Desenchufar()
        {
            Console.WriteLine("El segway ha sido desenchufado.");
        }

        public void Enchufar()
        {
            Console.WriteLine("El segway ha sido enchufado.");
        }

        public void Girar()
        {
            Console.WriteLine("El segway gira.");
        }

        public void Parar()
        {
            Console.WriteLine("El segway para.");
        }
    }
}
