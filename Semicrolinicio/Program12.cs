using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semicrolinicio
{
    class Program12
    {
        static void Main(string[] args)
        {
            List<Nota> listaNotas = new List<Nota>();

            listaNotas.Add(new Nota(3));
            listaNotas.Add(new Nota(4));
            listaNotas.Add(new Nota(5));
            listaNotas.Add(new Nota(6));
            listaNotas.Add(new Nota(7));
            listaNotas.Add(new Nota(8));

            Nota notaMayor = new Nota(0);
            Double suma = 0;
            Double media;

            

            foreach (Nota n in listaNotas)
            {               
                notaMayor = n.ElegirMayor(notaMayor);         
                suma += n.Valor;
            }

            media = suma / listaNotas.Count;

            

            Console.WriteLine("Nota mayor: " + notaMayor.Valor);
            Console.WriteLine("Media: " + media);



            Console.ReadLine();
        }

        
        
    }
}
