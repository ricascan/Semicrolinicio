using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibreriaFundanet;
using Semicrolinicio.Clases;

namespace Semicrolinicio
{
    class Program21
    {
        static void Main(string[] args)
        {
            IConducible moto = new Moto();
            moto.Avanzar();
            Patinete patinete = new Patinete();
            IConducibleConectable patinete2 = new Patinete();
            patinete.Avanzar();
            Mover(patinete);
            patinete2.Enchufar();
            patinete2.Desenchufar();
            patinete2.Arrancar();
            Segway segway = new Segway();

            Console.ReadLine();
        }

        public static void Mover(IConducible c)
        {
            c.Arrancar();
            c.Avanzar();
            c.Girar();
            c.Arrancar();
            c.Parar();
        }

    }
}
