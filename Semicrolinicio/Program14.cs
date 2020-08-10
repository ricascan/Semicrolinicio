using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semicrolinicio
{
    class Program14
    {
        static void Main(string[] args)
        {
            Compra compra = new Compra(1, "Compra por la mañana");
            compra.AddLinea(new LineaCompra(1, "Manzana", 1));
            compra.AddLinea(new LineaCompra(1, "Queso", 3));
            compra.AddLinea(new LineaCompra(1, "Pan", 0.70));
            compra.AddLinea(new LineaCompra(1, "Galletas", 2.5));

            Console.WriteLine(compra.Importe);
            Console.WriteLine(compra.ImporteIva());

            Console.ReadLine();
        }

        
        
    }
}
