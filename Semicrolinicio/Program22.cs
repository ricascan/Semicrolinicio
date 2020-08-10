using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibreriaFundanet;
using Semicrolinicio.Clases;

namespace Semicrolinicio
{
    class Program22
    {
        static void Main(string[] args)
        {
            Cocina cocina = new Cocina();
            for(int i = 0; i<=4; i++)
                cocina.AddEncendible(new Bombilla());
            //cocina.AddEncendible(new Frigorifico());
            //cocina.AddEncendible(new BombillaSmart("1"));
            //cocina.AddEncendible(new EnchufeSmartAdaptador("2", new Frigorifico()));
            //cocina.EncenderElectrodomesticos();
            cocina.EncenderPorVoz("2");
            Console.ReadLine();
        }

        

    }
}
