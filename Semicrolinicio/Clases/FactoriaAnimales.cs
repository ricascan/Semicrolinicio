﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semicrolinicio.Clases
{
    class FactoriaAnimales
    {
        public static Animal GetAnimal(string tipo, double peso, string color)
        {
            if (tipo.Equals("Gato"))
            {
                return new Gato(peso, color);
            }
            else
            {
                return new Perro(peso, color);
            }
        }
    }
}
