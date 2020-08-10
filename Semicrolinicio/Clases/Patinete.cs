using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semicrolinicio.Clases
{
    class Patinete : IConducibleConectable
    {
        public void Arrancar()
        {
            Console.WriteLine("El patinete arranca.");
        }

        public void Avanzar()
        {
            Console.WriteLine("El patinete avanza.");
        }

        public void Desenchufar()
        {
            Console.WriteLine("El patinete se ha desenchufado");
        }

        public void Enchufar()
        {
            Console.WriteLine("El patinete se ha enchufado");
        }

        public void Girar()
        {
            Console.WriteLine("El patinete gira.");
        }

        public void Parar()
        {
            Console.WriteLine("El patinete para.");
        }
    }
}
