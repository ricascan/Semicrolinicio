using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semicrolinicio.Clases
{
    class CPU
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Arquitectura { get; set; }
        public double Frecuencia { get; set; }
        public int NumeroNucleos { get; set; }
        public double Cache { get; set; }
        public string Socket { get; set; }

        public void Encender()
        {
            Console.WriteLine("Se ha encendido la CPU");
        }
        public void Apagar()
        {
            Console.WriteLine("La CPU se ha apagado");
        }
    }
}
