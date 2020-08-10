using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibreriaFundanet;
using Semicrolinicio.Clases;

namespace Semicrolinicio
{
    class Program20
    {
        static void Main(string[] args)
        {
            Dictionary<String, Persona> diccionario = new Dictionary<String, Persona>();
            Persona p1 = new Persona
            {
                Nombre = "Pedro",
                Apellidos = "Gomez",
                Edad = 50
            };

            Persona p2 = new Persona
            {
                Nombre = "Ana",
                Apellidos = "Perez",
                Edad = 30
            };

            diccionario.Add(p1.Nombre, p1);
            diccionario.Add(p2.Nombre, p2);
            
            foreach (Persona p in diccionario.Values)
            {
                Console.WriteLine(p);
            }

            foreach (String p in diccionario.Keys)
            {
                Console.WriteLine(p);
            }

            Telefono telefono = new Telefono();
            telefono.Numero = 123456789;
            Console.WriteLine(telefono.Numero);

            Console.ReadLine();

        }



    }
}
