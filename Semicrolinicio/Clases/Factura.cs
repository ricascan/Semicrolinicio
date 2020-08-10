using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semicrolinicio
{
    class Factura
    {
        private int _numero;
        private string _concepto;
        private double _importe;

        public Factura(int numero, string concepto, double importe)
        {
            _numero = numero;
            _concepto = concepto;
            _importe = importe;
        }

        public Factura(int numero)
        {
            _numero = numero;            
        }

        public Factura()
        {
        }

        public int Numero { get => _numero; set => _numero = value; }
        public string Concepto { get => _concepto; set => _concepto = value; }
        public double Importe { get => _importe; set => _importe = value; }

        public double ImporteConIVA()
        {
            return Importe * 1.21;
        }

        public double ImporteConIVA(double porcentaje)
        {
            return Importe * (porcentaje/100 + 1);
        }
    }
}
