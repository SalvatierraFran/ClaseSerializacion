using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EjemploArchivos
{
    public class Profesor:Persona
    {
        public string materia;
        public string nombres;

        public Profesor()
        { }

        public Profesor(string Nombre, string Mat)
        {
            this.materia = Mat;
            this.nombres = Nombre;
        }
    }
}
