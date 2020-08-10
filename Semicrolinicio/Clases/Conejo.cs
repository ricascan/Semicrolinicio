using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semicrolinicio.Clases
{
    class Conejo : Animal
    {
        public Conejo(double peso, string color) : base(peso, color)
        {
        }

        public override void Vacunar()
        {
            throw new NotImplementedException();
        }
    }
}
