using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Semicrolinicio.Clases;

namespace Semicrolinicio
{
    class Program17
    {
        static void Main(string[] args)
        {
            Perro perro = new Perro(30, "Blanco");
            VacunarAnimal(perro);
            
            Animal gato = FactoriaAnimales.GetAnimal("Gato", 30, "Blanco");
            VacunarAnimal(gato);

            if(gato.Equals(perro))
            {
                Console.WriteLine("Son iguales");
            }
            Console.Error.WriteLine("Jaja salu2 xd");

            Console.ReadLine();
        }

        public static void VacunarAnimal(Animal a)
        {
            a.Vacunar();
            Console.WriteLine(a.EstaVacunado);
        }
        
    }
}
