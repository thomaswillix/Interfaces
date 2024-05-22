using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
//importamos estas dependencias
using System.Xml.Serialization;

namespace Practica1.Manejadores
{
    //Importante que los métodos de las clases controladoras y las clases sean public y static
    public static class ControladorUsuariosXML
    {
        public static List<Usuario> listaUsuarios = new List<Usuario>();

        public static void escribirUsuariosXML()
        {
            try
            {
                using (var writer = new StreamWriter("usuarios.xml"))
                {
                    // Do this to avoid the serializer inserting default XML namespaces.
                    var namespaces = new XmlSerializerNamespaces();
                    namespaces.Add(string.Empty, string.Empty);
                    var serializer = new XmlSerializer(listaUsuarios.GetType());
                    serializer.Serialize(writer, listaUsuarios, namespaces);
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Error al escribir el usuairo");
            }
        }

        public static void cargarUsuariosXML()
        {
            try
            {
                string xml = File.ReadAllText("usuarios.xml");
                using (var reader = new StringReader(xml))
                {
                    XmlSerializer serializer = new XmlSerializer(listaUsuarios.GetType());
                    listaUsuarios = (List<Usuario>)serializer.Deserialize(reader);
                }
            }

            catch (Exception)
            {

            }
        }

        public static bool validaLogin(ref string usuario, ref string clave)
        {
            for (int i = 0; i < listaUsuarios.Count; i++)
            {
                if ((usuario == listaUsuarios[i].User.ToLower())
                    && (clave == listaUsuarios[i].Pass))
                {
                    Usuario.u = new Usuario(usuario, clave, listaUsuarios[i].EsAdmin);
                    return true;
                }
                else if ((usuario != listaUsuarios[i].User.ToLower())
                    || (clave != listaUsuarios[i].Pass.ToLower()))
                {
                    continue;
                }
            }
            MessageBox.Show("Usuario o contraseña incorrectos");
            return false;
        }

        public static bool buscarUsuario(string usuario, string pass)
        {
            for (int i = 0; i < listaUsuarios.Count; i++)
            {
                if (usuario.ToLower() == listaUsuarios[i].User.ToLower())
                {
                    if (pass == listaUsuarios[i].Pass)
                    {
                        return true;
                    }
                    return true;
                }
            }
            return false;
        }
        public static void crearUsuarios()
        {
            Usuario u = new Usuario("root", "1234", true);
            listaUsuarios.Add(u);
            u = new Usuario("jorge", "4321", false);
            listaUsuarios.Add(u);
            u = new Usuario("jaime", "4444", false);
            listaUsuarios.Add(u);
            u = new Usuario("jose", "1111", false);
            listaUsuarios.Add(u);
            u = new Usuario("thomas", "2222", false);
            listaUsuarios.Add(u);
        }
    }
}
