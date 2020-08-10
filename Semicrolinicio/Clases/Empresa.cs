using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semicrolinicio.Clases
{
    class Empresa
    {
        public List<Alquiler> ListaAlquileres { get; set; }

        public Empresa()
        {
            ListaAlquileres = new List<Alquiler>();
        }

        public void AddAlquiler(Alquiler alquiler)
        {
            ListaAlquileres.Add(alquiler);
        }

        public double ImporteTotalAlquileres()
        {
            double total = 0;
            foreach(Alquiler a in ListaAlquileres)
            {
                total += a.ImporteFinal();
            }
            return total;
        }

        public Alquiler AlquilerMayor()
        {
            Alquiler alquilerMayor = ListaAlquileres[0];
            foreach (Alquiler a in ListaAlquileres)
            {
                if (a.ImporteFinal() > alquilerMayor.ImporteFinal())
                {
                    alquilerMayor = a;
                }
            }
            return alquilerMayor;
        }

        public void EliminarAlquiler(Alquiler a)
        {
            ListaAlquileres.Remove(a);
        }

        public int NumeroAlquileres()
        {
            return ListaAlquileres.Count;
        }

        public bool ContieneAlquiler(Alquiler a)
        {
            return ListaAlquileres.Contains(a);
        }
    }
}
