using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semicrolinicio.Clases
{
    /// <summary>
    /// Clase que contiene todos los parametros y métodos de un ordenador.
    /// </summary>
    class Ordenador
    {
        public Ordenador(CPU cpu, Monitor monitor)
        {
            Cpu = cpu;
            Monitor = monitor;
        }

        /// <summary>
        /// Microprocesador del ordenador con todas sus propiedades
        /// </summary>
        public CPU Cpu { get; set; }
        /// <summary>
        /// Monitor del ordenador con todas sus propiedades
        /// </summary>
        public Monitor Monitor { get; set; }

        /// <summary>
        /// Enciende el ordenador.
        /// </summary>
        public virtual void Encender()
        {
            EncenderCPU();
            EncenderMonitor();
        }

        /// <summary>
        /// Enciende la CPU.
        /// </summary>
        protected virtual void EncenderCPU()
        {
            Cpu.Encender();
        }

        /// <summary>
        /// Enciende el monitor.
        /// </summary>
        protected virtual void EncenderMonitor()
        {
            Monitor.Encender();
        }


        /// <summary>
        /// Apaga el ordenador.
        /// </summary>
        public virtual void Apagar()
        {
            Cpu.Apagar();
            Monitor.Apagar();
        }
        
    }
}
