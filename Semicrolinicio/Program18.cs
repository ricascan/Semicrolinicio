using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Semicrolinicio.Clases;

namespace Semicrolinicio
{
    class Program18
    {
        static void Main(string[] args)
        {
            Empresa empresa = new Empresa();
            empresa.AddAlquiler(new Alquiler(1, 400));
            empresa.AddAlquiler(new AlquilerJoven(2, 500));
            empresa.AddAlquiler(new AlquilerVip(3, 800));

            foreach (Alquiler a in empresa.ListaAlquileres)
            {
                Console.WriteLine(a.ImporteFinal());
            }
            Console.WriteLine(empresa.ImporteTotalAlquileres());
            Console.WriteLine("Alquiler mayor: " + empresa.AlquilerMayor().ImporteFinal());
            Console.WriteLine(empresa.NumeroAlquileres());
            empresa.EliminarAlquiler(new Alquiler(1, 400));
            Console.WriteLine(empresa.NumeroAlquileres());
            Console.WriteLine(empresa.ContieneAlquiler(new Alquiler(1, 400)));

            Console.ReadLine();
        }

        
        
    }
}
