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

namespace Practica1.manejadores
{
    //Importante que los métodos de las clases controladoras y las clases sean public y static
    public static class ControladorClientesXML
    {
        public static List<Usuario> listaClientes = new List<Cliente>();

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
            catch (Exception e)
            {

            }
        }

        public static void leerUsuariosXML()
        {
            try
            {
                string xml = File.ReadAllText("usuarios.xml");
                using (var reader = new StringReader(xml))
                {
                    XmlSerializer serializer = new XmlSerializer(listaClientes.GetType());
                    listaClientes = (List<Usuario>)serializer.Deserialize(reader);
                }
            }

            catch (Exception)
            {

            }
        }

        public static bool validaLogin(ref string usuario, ref string clave)
        {
            for (int i = 0; i < listaClientes.Count; i++)
            {
                if ((usuario == listaClientes[i].User.ToLower())
                    && (clave == listaClientes[i].Pass))
                {
                    Usuario.u = new Usuario(usuario, clave);
                    return true;
                }
                else if ((usuario != listaClientes[i].User.ToLower())
                    || (clave != listaClientes[i].Pass.ToLower()))
                {
                    continue;
                }
            }
            MessageBox.Show("Usuario o contraseña incorrectos");
            return false;
        }

        public static bool buscarUsuario(string usuario, string pass)
        {
            for (int i = 0; i < listaClientes.Count; i++)
            {
                if (usuario.ToLower() == listaClientes[i].User.ToLower())
                {
                    if (pass == listaClientes[i].Pass)
                    {
                        return true;
                    }
                    return true;
                }
            }
            return false;
        }
        public static void cargarUsuarios()
        {
            ControladorEmpleadosJSON.cargarEmpleados();
            //Image i;
            Empleado e = ControladorEmpleadosJSON.listaEmpleados[0];
            //c = new Cliente("67378864L", "Natalia Sales", "Avenida de Canarias 3", "Madrid", e, "natalia.sales@gmail.com", "C10483436", 658947512,
                "Zimbawe","Pequeño",5, "Comentarios muy comentados",  );
            listaClientes.Add(c);
           
        }
    }
}
