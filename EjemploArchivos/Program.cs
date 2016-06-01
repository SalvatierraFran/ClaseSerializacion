using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace EjemploArchivos
{
    class Program
    {
        static void Main(string[] args)
        {
            //ManejadorDeArchivos.Escribir();
            //ManejadorDeArchivos.Leer();

            //Persona unaPersona = new Persona("Alan", "Pinola", "35159875");
            //Persona otraPersona = new Persona("Franco", "Salvatierra", "37710062");
            //Persona anotherPerson = new Persona("Lucas", "Alario", "3487699");
            //Persona anotherPersonMore = new Persona("Lionel", "Messi", "30025855");
            //Persona PersonMore = new Persona("Marcelo", "Barovero", "25555998");

            //Aula unAula = new Aula("Primer Aula", otraPersona);
            //Aula otraAula = new Aula("Segundo Aula", PersonMore);

            //List<Persona> listado = new List<Persona>();

            //listado.Add(unaPersona);
            //listado.Add(otraPersona);

            //unAula.listaAlumnos.Add(anotherPerson);
            //unAula.listaAlumnos.Add(anotherPersonMore);
            //unAula.listaAlumnos.Add(PersonMore);

            //Alumno Alumnito = new Alumno("Emanuel", 5);
            //Alumno AlumnitoMas = new Alumno("Tomas", 6);

            //Profesor Professor = new Profesor("Octavio", "Programacion");

            //otraAula.listaAlumnos.Add(Alumnito);
            //otraAula.listaAlumnos.Add(AlumnitoMas);
            //otraAula.listaAlumnos.Add(Professor);            

            //ManejadorXml.GuardarPersona(unaPersona);
            //ManejadorXml.GuardarAula(unAula);
            //ManejadorXml.GuardarLista(listado);
            //ManejadorXml.GuardarAula2(unAula);
            //ManejadorXml.GuardarAula3(otraAula);

            //Aula MiAula = new Aula();

            //MiAula = ManejadorXml.CargarAula();

            Dueño unDueño = new Dueño("20-37710062-5", DateTime.Now, "Franco", "Salvatierra", "37710062");

            Estacionamiento MiEstacionamiento = new Estacionamiento(unDueño);

            Auto Auto1 = new Auto(4, "Audi");
            Moto Moto1 = new Moto(110, "Kawasaki");
            Camioneta Camioneta1 = new Camioneta(150, "Toyota");

            MiEstacionamiento.ListaVehiculo.Add(Auto1);
            MiEstacionamiento.ListaVehiculo.Add(Moto1);
            MiEstacionamiento.ListaVehiculo.Add(Camioneta1);

            ManejadorXml.GuardarEstacionamiento(MiEstacionamiento);

            Console.ReadKey();
        }
    }
}
