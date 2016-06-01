using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EjemploArchivos
{
    public class Estacionamiento
    {
        public Persona eldueño;
        public List<Vehiculo> ListaVehiculo;

        public Estacionamiento(Persona Dueño)
        {
            this.eldueño = Dueño;
            ListaVehiculo = new List<Vehiculo>();
        }
    }
}
