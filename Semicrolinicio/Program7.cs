using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semicrolinicio
{
    class Program7
    {
        static void Main(string[] args)
        {
            Persona p1 = new Persona();
            p1.Nombre = "Pedro";
            p1.Apellidos = "Alvarez";
            p1.Edad = 20;
            Console.WriteLine("Nombre: " + p1.Nombre + ", Apellidos: " + p1.Apellidos + ", Edad: " + p1.Edad + ", Tiempo para jubilarse: " + p1.TiempoParaJubilarse());
            Console.ReadLine();
        }

        
        
    }
}
