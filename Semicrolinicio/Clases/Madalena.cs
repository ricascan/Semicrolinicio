﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semicrolinicio
{
    class Madalena
    {
        private string _color;
        private int _peso;
        private int _precio;

        //public string Color { get => _color; set => _color = value; }
        //public int Peso { get => _peso; set => _peso = value; }
        //public int Precio { get => _precio; set => _precio = value; }

        public string Color
        {
            get
            {
                return _color;
            }

            set
            {
                if (!value.Equals("azul")) _color = value; 
                
            }
        }

        public int Peso
        {
            get
            {
                return _peso;
            }

            set
            {
                if (value <= 4) _peso = value;

            }
        }

        public int Precio
        {
            get
            {
                return _precio;
            }

            set
            {
                if (value <= 4) _precio = value;

            }
        }
    }
}
