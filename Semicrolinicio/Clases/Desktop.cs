using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semicrolinicio.Clases
{
    class Desktop:Ordenador
    {
        public Desktop(CPU cpu, Monitor monitor) : base(cpu, monitor)
        {
        }

        public string Monitor { get; set; }
        public string Teclado { get; set; }
        public string Raton { get; set; }

        public override void Encender()
        {
            base.Encender();
            Console.WriteLine("Se ha encendido el monitor.");
        }
    }
}
