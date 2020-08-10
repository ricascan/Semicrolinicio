using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semicrolinicio
{
    class Nota
    {
        public Nota(double valor)
        {
            Valor = valor;
        }

        public double Valor
        {
            get; set;
        }

        public String Tipo()
        {
            if (Valor < 5)
            {
                return "Insuficiente";
            }
            else if (Valor >= 5 && Valor < 6)
            {
                return "Aprobado";
            }
            else if (Valor >= 6 && Valor < 7)
            {
                return "Bien";
            }
            else if (Valor >= 7 && Valor < 9)
            {
                return "Notable";
            }
            else
            {
                return "Sobresaliente";
            }

        }

        public Nota ElegirMayor(Nota nota2)
        {
            return Nota.ElegirMayor(nota2, this);
        }

        public static Nota ElegirMayor(Nota nota1, Nota nota2)
        {
            if(nota1.Valor > nota2.Valor)
            {
                return nota1;
            }else
            {
                return nota2;
            }
        }



    }
}
