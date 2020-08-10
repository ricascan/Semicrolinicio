using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semicrolinicio
{
    class Program13
    {
        static void Main(string[] args)
        {
            Alumno alumno1 = new Alumno("Pedro");
            alumno1.AddNota(new Nota(7));
            alumno1.AddNota(new Nota(10));

            

            Console.WriteLine(alumno1.Media().Valor);
            Console.WriteLine(alumno1.NotaMayor().Valor);

            Console.ReadLine();
        }

        
        
    }
}
