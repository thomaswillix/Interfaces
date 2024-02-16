using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//importamos estas dependencias
using System.Xml.Serialization;
using System.IO;
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
            //ControladorEmpleadosJSON.cargarEmpleados();
            //Image i;
            Empleado e = ControladorEmpleadosJSON.listaEmpleados[0];
            /*c = new Cliente("67378864L", "Natalia Sales", "Avenida de Canarias 3", "Madrid", e, "natalia.sales@gmail.com", "C10483436", 658947512,
                "Zimbawe","Pequeño",5, "Comentarios muy comentados",  );
            listaClientes.Add(c);*/
           
        }
    }
}
