using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semicrolinicio.Clases
{
    class Golosina : IPrecio
    {
        public Golosina(string sabor)
        {
            Sabor = sabor;
        }

        public string Sabor { get; set; }
        public double Importe { get; set; }
    }
}
