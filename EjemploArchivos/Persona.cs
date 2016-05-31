using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EjemploArchivos
{
    public class Persona
    {
        /*Atributos*/
        public string nombre;
        public string apellido;

        public Persona()
        { }

        public Persona(string Nombre, string Apellido)
        {
            this.apellido = Apellido;
            this.nombre = Nombre;
        }
    }
}
