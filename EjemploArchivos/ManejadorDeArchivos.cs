using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace EjemploArchivos
{
    public class ManejadorDeArchivos
    {
        /*Estructura estandarizada*/

        /*Metodos*/
        public static void Leer()
        {
            try
            {
                StreamReader Lector = new StreamReader("Archivo/Ejemplo.txt");
                string dato;

                dato = Lector.ReadToEnd();

                Console.WriteLine(dato);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static void Escribir()
        {
            try
            {
                StreamWriter Escritor = new StreamWriter("Archivo/Ejemplo.txt", false);

                Escritor.WriteLine("Hola mundo");
                Escritor.Write("C Sharp");
                Escritor.WriteLine("Escritura en archivo");

                Escritor.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static void Escribir2()
        {
            try
            {
                using (StreamWriter Escritor = new StreamWriter("Archivo/Ejemplo.txt"))//Escribimos el Objeto que toma el recurso.
                {
                    Escritor.WriteLine("Hola mundo");
                    Escritor.Write("C Sharp");
                    Escritor.WriteLine("Escritura en archivo");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
