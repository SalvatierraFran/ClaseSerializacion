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

        //public Aula(string Nombre, Profesor unProfesor)
        //{
        //    this.nombre = Nombre;
        //    this.unProfe = unProfesor;
        //    ListaAlumnitos = new List<Alumno>();
        //}
    }
}
