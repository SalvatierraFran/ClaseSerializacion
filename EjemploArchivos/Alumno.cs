using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EjemploArchivos
{
    public class Alumno:Persona
    {
        public int materiasAprobadas;
        public string nombres;

        public Alumno()
        { }

        public Alumno(string Nombre, int Aprobadas)
        {
            this.materiasAprobadas = Aprobadas;
            this.nombres = Nombre;
        }
    }
}
