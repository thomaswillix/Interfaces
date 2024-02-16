using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;
using Practica1.Modelo;
using Practica1.manejadores;

namespace Practica1.Manejadores
{
    public class ControladorComponentesProyecto
    {
        public static List<ComponentesProyecto> listaComponentes= new List<ComponentesProyecto>();
        
        public static void leerComponentes()
        {
            try
            {
                if (File.Exists("componentes.Json"))
                {
                    string jsonString = File.ReadAllText("componentes.Json");
                    
                    listaComponentes = JsonSerializer.Deserialize<List<ComponentesProyecto>>(jsonString);
                }

            }
            catch (Exception)
            {
                throw;
            }
        }
        public static void escribirComponentes()
        {
            try
            {
                if (File.Exists("empleados.Json"))
                {
                    string jsonString = JsonSerializer.Serialize(listaComponentes);
                    File.WriteAllText("empleados.Json", jsonString);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        public static void cargarComponentes()
        {
            //Cargamos las listas que utilizaremos
            ControladorProyectosBin.cargarProyectos();
            ControladorEmpleadosJSON.cargarEmpleados();
            //Creamos una Tupla o Diccionario (nose) de forma que Proyecto --> Empleado
            var ProyectosYEmpleados = ControladorProyectosBin.listaProyectos.Zip(ControladorEmpleadosJSON.listaEmpleados, (p, e)
                => new { Proyecto = p, Empleado = e });
            //Creamos cada Objeto ComponentesProyecto con valores por defecto y lo añadimos a la listaComponentes
            foreach (var pe in ProyectosYEmpleados)
            {
                ComponentesProyecto cp = new ComponentesProyecto(pe.Proyecto.Descripcion, pe.Empleado.Id, pe.Empleado.Puesto, 3.9f, 2.4m);
                listaComponentes.Add(cp);
            }
        }
    }
}
