﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semicrolinicio.Clases
{
    class Alquiler
    {
        public Alquiler(int numero, double importe)
        {
            Numero = numero;
            Importe = importe;
        }

        public int Numero { get; set; }
        public double Importe { get; set; }

        public override bool Equals(object obj)
        {
            var alquiler = obj as Alquiler;
            return alquiler != null &&
                   Numero == alquiler.Numero;
        }

        public override int GetHashCode()
        {
            return -1449941195 + Numero.GetHashCode();
        }

        public virtual double ImporteFinal()
        {
            return Importe * 1.21;
        }

    }
}
