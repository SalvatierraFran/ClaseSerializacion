using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EjemploArchivos
{
    public class Camioneta:Motorizados
    {
        public int altura;

        public Camioneta()
        { }

        public Camioneta(int Altu, string Motor):base(Motor)
        {
            this.altura = Altu;
        }
    }
}
