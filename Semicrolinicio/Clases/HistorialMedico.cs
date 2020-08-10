using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semicrolinicio
{
    class HistorialMedico
    {
        public HistorialMedico(int numHistorial, DateTime fecha)
        {
            NumHistorial = numHistorial;
            Fecha = fecha;
            
        }

        public override string ToString()
        {
            return "Numero de historial: " + NumHistorial + ", Fecha: " + Fecha;
        }

        public int NumHistorial { get; set; }
        public DateTime Fecha { get; set; }
        
    }
}
