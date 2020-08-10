﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semicrolinicio.Clases
{
    class AlquilerJoven:Alquiler
    {
        public AlquilerJoven(int numero, double importe) : base(numero, importe)
        {
        }

        public override double ImporteFinal()
        {
            return base.ImporteFinal() - 200;
        }
    }
}
