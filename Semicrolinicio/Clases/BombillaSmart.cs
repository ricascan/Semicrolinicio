using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semicrolinicio.Clases
{
    class BombillaSmart : Bombilla, IEncendibleSmart
    {
        public BombillaSmart(string id)
        {
            Id = id;
        }

        public string Id { get; set; }

        public void ApagarVoz()
        {
            Console.WriteLine("La bombilla se apaga atendiendo al comando por voz.");
        }

        public void EncenderVoz()
        {
            Console.WriteLine("La bombilla se enciende atendiendo al comando por voz.");
        }

        public override bool Equals(object obj)
        {
            var smart = obj as BombillaSmart;
            return smart != null &&
                   Id == smart.Id;
        }

        public override int GetHashCode()
        {
            return 2108858624 + EqualityComparer<string>.Default.GetHashCode(Id);
        }
    }
}
