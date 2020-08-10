using System;

namespace Semicrolinicio.Clases
{
    public class Lavadora : IEncendible
    {
        public void Apagar()
        {
            Console.WriteLine("La lavadora se apaga");
        }

        public void Encender()
        {
            Console.WriteLine("La lavadora se enciende");
        }
    }
}