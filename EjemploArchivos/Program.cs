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
            ManejadorDeArchivos.Escribir();
            ManejadorDeArchivos.Leer();

            Persona unaPersona = new Persona("Alan", "Pinola");
            Persona otraPersona = new Persona("Franco", "Salvatierra");
            Persona anotherPerson= new Persona("Lucas", "Alario");
            Persona anotherPersonMore= new Persona("Lionel", "Messi");
            Persona PersonMore = new Persona("Marcelo", "Barovero");

            Aula unAula = new Aula("Primer Aula", otraPersona);

            List<Persona> listado = new List<Persona>();

            listado.Add(unaPersona);
            listado.Add(otraPersona);

            unAula.listaAlumnos.Add(anotherPerson);
            unAula.listaAlumnos.Add(anotherPersonMore);
            unAula.listaAlumnos.Add(PersonMore);

            //try
            //{
            //    using(XmlTextWriter Escritor= new XmlTextWriter("Persona.Xml", Encoding.UTF8))
            //    {
            //        XmlSerializer Serializador = new XmlSerializer(typeof(Persona));

            //        Serializador.Serialize(Escritor, unaPersona);
            //    }
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}

            ManejadorXml.GuardarPersona(unaPersona);
            ManejadorXml.GuardarAula(unAula);
            ManejadorXml.GuardarLista(listado);
            ManejadorXml.GuardarAula2(unAula);

            Console.ReadKey();
        }
    }
}
