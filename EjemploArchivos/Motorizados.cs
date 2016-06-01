using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace EjemploArchivos
{
    public class Motorizados:Vehiculo
    {
        public string TipoMotor;

        public Motorizados()
        { }

        public Motorizados(string Motor)
        {
            this.TipoMotor = Motor;
        }
    }
}
