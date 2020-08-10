using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semicrolinicio
{
    class Compra
    {
        public Compra(int iD, string concepto)
        {
            ID = iD;
            Concepto = concepto;
            Importe = 0;
            Lineas = new List<LineaCompra>();
        }

        public int ID { get; set; }
        public string Concepto { get; set; }
        public double Importe { get; private set; }
        public List<LineaCompra> Lineas { get; set; }

        

        public void AddLinea(LineaCompra linea)
        {
            Lineas.Add(linea);
            Importe += linea.Importe;
        }

        public double ImporteIva()
        {
            double total = 0;
            foreach(LineaCompra l in Lineas)
            {
                total += l.ImporteConIVA();
            }
            return total;
        }
    }
}
