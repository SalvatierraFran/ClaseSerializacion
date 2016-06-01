using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EjemploArchivos
{
    public class Auto:Motorizados
    {
        public int puertas;

        public Auto()
        { }

        public Auto(int Puerta, string Motor):base(Motor)
        {
            this.puertas = Puerta;
        }
    }
}
