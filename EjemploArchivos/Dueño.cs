using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EjemploArchivos
{
    class Dueño:Persona
    {
        public string cuit;
        public DateTime FechaInscripcion;

        public Dueño()
        { }

        public Dueño(string Cuit, DateTime Fecha, string Nombre, string Apellido, string dni):base(Nombre, Apellido, dni)
        {
            this.cuit = Cuit;
            this.FechaInscripcion = Fecha;
        }
    }
}
