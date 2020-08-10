using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semicrolinicio.Clases
{
    interface IEncendibleSmart : IEncendible
    {
        string Id { get; set; }
        void EncenderVoz();
        void ApagarVoz();
    }
}
