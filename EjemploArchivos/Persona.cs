using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace EjemploArchivos
{
    [XmlInclude(typeof(Profesor))]
    [XmlInclude(typeof(Alumno))]
    public class Persona:SerHumano
    {
        /*Atributos*/
        public string nombre;
        public string apellido;

        public Persona()
        { }

        public Persona(string Nombre, string Apellido, string dni):base(dni)
        {
            this.apellido = Apellido;
            this.nombre = Nombre;
        }
    }
}
