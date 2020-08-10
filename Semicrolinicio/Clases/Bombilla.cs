using System;

namespace Semicrolinicio.Clases
{
    public class Bombilla : IEncendible
    {
        public void Apagar()
        {
            Console.WriteLine("La bombilla se apaga");
        }

        public void Encender()
        {
            Console.WriteLine("La bombilla se enciende");
        }
    }
}