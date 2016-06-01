using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace EjemploArchivos
{
    public class ManejadorXml
    {
        public static bool GuardarPersona(Persona unaPersona)
        {
            try
            {
                using (XmlTextWriter Escritor = new XmlTextWriter("Persona.Xml", Encoding.UTF8))
                {
                    XmlSerializer Serializador = new XmlSerializer(typeof(Persona));

                    Serializador.Serialize(Escritor, unaPersona);
                }
            }
            catch (Exception)
            {
                return false;
                //Console.WriteLine(ex.Message);
            }
            return true;
        }

        public static bool GuardarAula(Aula unAula)
        {
            try
            {
                using (XmlTextWriter Escritor = new XmlTextWriter("Aula.Xml", Encoding.UTF8))
                {
                    XmlSerializer Serializador = new XmlSerializer(typeof(Aula));

                    Serializador.Serialize(Escritor, unAula);
                }
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        public static bool GuardarLista(List<Persona> unaLista)
        {
            try
            {
                using (XmlTextWriter Escritor = new XmlTextWriter("Lista.Xml", Encoding.UTF8))
                {
                    XmlSerializer Serializador = new XmlSerializer(typeof(List<Persona>));

                    Serializador.Serialize(Escritor, unaLista);
                }
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        public static bool GuardarAula2(Aula unAula)
        {
            try
            {
                using (XmlTextWriter Escritor = new XmlTextWriter("Aula2.Xml", Encoding.UTF8))
                {
                    XmlSerializer Serializador = new XmlSerializer(typeof(Aula));

                    Serializador.Serialize(Escritor, unAula);
                }
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        public static bool GuardarAula3(Aula unAula)
        {
            try
            {
                using (XmlTextWriter Escritor = new XmlTextWriter("Aula3.Xml", Encoding.UTF8))
                {
                    XmlSerializer Serializador = new XmlSerializer(typeof(Aula));

                    Serializador.Serialize(Escritor, unAula);
                }
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        public static Aula CargarAula()
        {
            Aula AulaAuxiliar=null;
            try
            {
                using (XmlTextReader Lector = new XmlTextReader("Aula2.Xml"))
                {
                    XmlSerializer Serializador = new XmlSerializer(typeof(Aula));

                    AulaAuxiliar = (Aula)Serializador.Deserialize(Lector);
                    
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return AulaAuxiliar;
        }

        public static bool GuardarEstacionamiento(Estacionamiento UnEstacionamiento)
        {
            try
            {
                using (XmlTextWriter Escritor = new XmlTextWriter("Estacionamiento.Xml", Encoding.UTF8))
                {
                    XmlSerializer Serializador = new XmlSerializer(typeof(Estacionamiento));

                    Serializador.Serialize(Escritor, UnEstacionamiento);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return true;
        }
    }
}
