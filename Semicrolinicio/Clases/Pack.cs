using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semicrolinicio.Clases
{
    class Pack<T, K> where T:IPrecio where K:IPrecio
    {
        public Pack(T elemento1, K elemento2)
        {
            Elemento1 = elemento1;
            Elemento2 = elemento2;
        }

        public double Total()
        {
            
            return Elemento1.Importe + Elemento2.Importe;
            
        }

        public T Elemento1 { get; set; }
        public K Elemento2 { get; set; }       
    }
}
