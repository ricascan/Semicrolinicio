using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semicrolinicio
{
    class Alumno
    {
        public Alumno(string nombre)
        {
            Nombre = nombre;
        }

        public string Nombre { get; set; }
        public List<Nota> ListaNotas { get => _listaNotas; set => _listaNotas = value; }

        private List<Nota> _listaNotas = new List<Nota>();

        public void AddNota(Nota nota)
        {
            ListaNotas.Add(nota);
        }

        public Nota Media()
        {
            double media = 0;
            foreach (Nota n in ListaNotas)
            {            
                media += n.Valor;
            }
            return new Nota(media / ListaNotas.Count);
        }

        public Nota NotaMayor()
        {
            Nota notaMayor = new Nota(0);
            foreach (Nota n in ListaNotas)
            {
                notaMayor = n.ElegirMayor(notaMayor);              
            }
            return notaMayor;
        }
        
    }
}
