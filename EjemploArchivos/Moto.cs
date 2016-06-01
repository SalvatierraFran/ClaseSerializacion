using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace EjemploArchivos
{
    public class Moto:Motorizados
    {
        public int cilindrada;

        public Moto()
        { }

        public Moto(int Cilin, string Motor):base(Motor)
        {
            this.cilindrada = Cilin;
        }
    }
}
