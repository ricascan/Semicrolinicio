using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semicrolinicio.Clases
{
    class Cocina
    {
        public Cocina()
        {
            
            Encendibles = new List<IEncendible>();
        }

        public void EncenderElectrodomesticos()
        {
            foreach(IEncendible e in Encendibles)
            {
                e.Encender();               
            }
        }

        public void EncenderPorVoz(string id)
        {
            
            foreach (IEncendible e in Encendibles)
            {
                if (e is IEncendibleSmart otro)
                {
                    if (otro.Id == id)
                    {
                        otro.EncenderVoz();
                    }
                }
            }
        }

        public void AddEncendible(IEncendible b)
        {
            Encendibles.Add(b);
            
        }

        
        public List<IEncendible> Encendibles { get; set; }
        


    }
}
