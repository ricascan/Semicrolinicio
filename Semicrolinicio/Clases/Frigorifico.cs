using System;

namespace Semicrolinicio.Clases
{
    public class Frigorifico : IEncendible, IComparable<Frigorifico>
    {
        public Frigorifico(int potencia)
        {
            Potencia = potencia;
        }

        public int Potencia { get; set; }
        public void Apagar()
        {
            Console.WriteLine("El frigorifico se apaga");
        }


        public int CompareTo(Frigorifico other)
        {
            if (other.Potencia < Potencia)
            {
                return -1;
            }
            else if (other.Potencia == Potencia)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }

        public void Encender()
        {
            Console.WriteLine("El frigorifico se enciende");
        }
    }
}