using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semicrolinicio
{
    class Program8
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Factura factura = new Factura(1, "Compra", 23.99);
            

            Console.WriteLine("Concepto con IVA: " + String.Format("{0:0.00}", factura.ImporteConIVA(21)) + "€");
            Console.ReadLine();
        }

        
        
    }
}
