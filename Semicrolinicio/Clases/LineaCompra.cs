using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semicrolinicio
{
    class LineaCompra
    {
        public LineaCompra(int iD, string concepto, double importe)
        {
            ID = iD;
            Concepto = concepto;
            Importe = importe;
        }

        public int ID { get; set; }
        public string Concepto { get; set; }
        public double Importe { get; set; }

        public double ImporteConIVA()
        {
            return Importe * 1.21;
        }

    }
}
