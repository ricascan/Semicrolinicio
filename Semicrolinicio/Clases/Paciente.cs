using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semicrolinicio
{
    class Paciente
    {
        public Paciente(string nombre, string dNI)
        {
            Nombre = nombre;
            DNI = dNI;
        }

        public Paciente(string nombre, string dNI, HistorialMedico historial):this(nombre, dNI)
        {            
            Historial = historial;
        }

        public override string ToString()
        {
            return "Nombre: " + Nombre + ", DNI: " + DNI + ", Historial Médico: "+ Historial;
        }

        public string Nombre { get; set; }
        public string DNI { get; set; }
        public HistorialMedico Historial { get; set; }
    }
}
