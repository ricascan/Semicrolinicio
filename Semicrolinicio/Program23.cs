using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibreriaFundanet;
using Semicrolinicio.Clases;

namespace Semicrolinicio
{
    class Program23
    {
        static void Main(string[] args)
        {
            List<Frigorifico> lista = new List<Frigorifico>
            {
                new Frigorifico(20),
                new Frigorifico(10),
                new Frigorifico(30),
                new Frigorifico(60)
            };
            lista.Sort(new ComparadorPotencia());
            Predicate<Frigorifico> predicado = delegate(Frigorifico f) { return f.Potencia < 40; };
            List<Frigorifico> listaMas20 = lista.FindAll(predicado);
            foreach(Frigorifico f in listaMas20)
            {
                Console.WriteLine(f.Potencia);
            }


            Console.ReadLine();
        }

        

    }
}
