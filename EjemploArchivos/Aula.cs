using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EjemploArchivos
{
    public class Aula
    {
        public string nombre;
        public Persona profesor;
        public List<Persona> listaAlumnos;

        public Aula()
        { }

        public Aula(string Nombre, Persona Profe)
        {
            this.nombre = Nombre;
            this.profesor = Profe;
            this.listaAlumnos = new List<Persona>();
        }
    }
}
