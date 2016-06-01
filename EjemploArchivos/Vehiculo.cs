using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace EjemploArchivos
{
    [XmlInclude(typeof(Moto))]
    [XmlInclude(typeof(Auto))]
    [XmlInclude(typeof(Camioneta))]
    public abstract class Vehiculo
    {

    }
}
