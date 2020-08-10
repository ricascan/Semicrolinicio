﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semicrolinicio.Clases
{
    class EnchufeSmartAdaptador : IEncendibleSmart
    {
        public EnchufeSmartAdaptador(string id, IEncendible encendible)
        {
            Id = id;
            Encendible = encendible;
        }

        public string Id { get; set; }

        public IEncendible Encendible { get; set; }



        public void Apagar()
        {
            Encendible.Apagar();
        }

        public void ApagarVoz()
        {
            Encendible.Apagar();
        }

        public void Encender()
        {
            Encendible.Encender();
        }

        public void EncenderVoz()
        {
            Encendible.Encender();
        }
    }
}
