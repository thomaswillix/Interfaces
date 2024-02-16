using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//dependencias
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;


namespace Practica1.manejadores
{
    public static class ControladorProyectosBin
    {
        public static List<Proyecto> listaProyectos = new List<Proyecto>();

        public static void cargarProyectos()
        {
            try
            {
                Stream OpenFileStream = File.OpenRead("proyectos.bin");
                BinaryFormatter deserializer = new BinaryFormatter();
                listaProyectos = (List<Proyecto>)deserializer.Deserialize(OpenFileStream);
                OpenFileStream.Close();
            }
            catch (Exception)
            {
                Console.WriteLine("Error al cargar los proyectos del archivo binario");
            }
        }
        public static bool escribirProyectos()
        {
            try
            {
                Stream SaveFileStream = File.Create("proyectos.bin");
                BinaryFormatter serializer = new BinaryFormatter();
                serializer.Serialize(SaveFileStream, listaProyectos);
                SaveFileStream.Close();
                return true;

            }
            catch (Exception)
            {
                Console.WriteLine("Error al escribir la lista de Proyectos mediante el controlador");
                return false;
            }
        }
        //Carga de proyectos de prueba
        public static void crearProyectos()
        {
            DateTime fechaIni = new DateTime(2011, 2, 3, 13, 0, 0);
            DateTime fechaFin = DateTime.Today;
            Proyecto p = new Proyecto("Proyecto Antiguo", fechaIni, fechaFin);
            listaProyectos.Add(p);
            fechaIni = new DateTime(2015, 5, 21, 8, 0, 0);
            fechaFin = new DateTime(2023, 9, 30, 9, 0, 0);
            p = new Proyecto("Segundo Proyecto", fechaIni, fechaFin);
            listaProyectos.Add(p);
            fechaIni = new DateTime(2022, 7, 14, 6, 0, 0);
            fechaFin = new DateTime(2020, 10, 3, 10, 0, 0);
            p = new Proyecto("Most Recent", fechaIni, fechaFin);
            listaProyectos.Add(p);
            fechaIni = new DateTime(2018, 9, 21, 19, 0, 0);
            fechaFin = DateTime.Today;
            p = new Proyecto("Tercero", fechaIni, fechaFin);
            listaProyectos.Add(p);
            fechaIni = new DateTime(2015, 9, 21, 19, 0, 0);
            fechaFin = new DateTime(2022, 10, 3, 10, 0, 0);
            p = new Proyecto("Cuato", fechaIni, fechaFin);
            listaProyectos.Add(p);
        }
    }
}
