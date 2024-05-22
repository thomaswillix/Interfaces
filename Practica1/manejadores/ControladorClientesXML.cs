using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
//importamos estas dependencias
using System.Xml.Serialization;
using Practica1.Modelo;

namespace Practica1.Manejadores
{
    //Importante que los métodos de las clases controladoras y las clases sean public y static
    public static class ControladorClientesXML
    {
        public static List<Cliente> listaClientes = new List<Cliente>();

        public static void escribirClientesXML()
        {
            try
            {
                using (var writer = new StreamWriter("clientes.xml"))
                {
                    // Do this to avoid the serializer inserting default XML namespaces.
                    var namespaces = new XmlSerializerNamespaces();
                    namespaces.Add(string.Empty, string.Empty);
                    var serializer = new XmlSerializer(listaClientes.GetType());
                    serializer.Serialize(writer, listaClientes, namespaces);
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Error al escribir los clientes mediante el controlador");
            }
        }

        public static void cargarClientesXML()
        {
            try
            {
                string xml = File.ReadAllText("clientes.xml");
                using (var reader = new StringReader(xml))
                {
                    XmlSerializer serializer = new XmlSerializer(listaClientes.GetType());
                    listaClientes = (List<Cliente>)serializer.Deserialize(reader);
                }
            }

            catch (Exception)
            {

            }
        }

        public static void crearClientes()
        {
            Image i = null;
            DateTime d = DateTime.Now;
            Empleado e = ControladorEmpleadosJSON.listaEmpleados[0];
            Cliente c = new Cliente("67378864L", "Natalia Sales", "Avenida de Canarias 3", "Madrid", e, "natalia.sales@gmail.com", "C10483436", "658947512",
                "Zimbawe", "Pequeño", 5, "Comentarios muy comentados", i, d);
            listaClientes.Add(c);
            c = new Cliente("54875412A", "Pepe Lopez", "Avenida de Portugal 2", "Madrid", e, "pepe.lopez@gmail.com", "C10326365", "655458215",
                "Marruecos", "Muy grande", 2, "Comentarios poco comentados", i, d);
            listaClientes.Add(c);
            c = new Cliente("45975612D", "Juana Magán", "Calle de Barcelona 35", "Fuanlabrada", e, "juana@gmail.com", "C16547521", "645875695",
                "Portugal", "Grande", 5, "Comentarios comentados", i, d);
            listaClientes.Add(c);
            c = new Cliente("987654123V", "No Se", "Calle de Tokyo 4", "Coslada", e, "nose.nose@gmail.com", "H54876521", "654487694",
                "Nose", "Pequeño", 5, "Comentarios", i, d);
            listaClientes.Add(c);
        }
    }
}
