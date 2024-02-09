using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Practica1.manejadores;

namespace Practica1.Modelo
{
    public class ComponentesProyecto
    {
        string codigoProyecto;
        int idEmpleado;
        string puesto;
        float porcentajeDedicacion;
        decimal extras;

        public ComponentesProyecto(string codigoProyecto, int idEmpleado, string puesto, float porcentajeDedicacion, decimal extras)
        {
            this.codigoProyecto = codigoProyecto;
            this.idEmpleado = idEmpleado;
            this.puesto = puesto;
            this.porcentajeDedicacion = porcentajeDedicacion;
            this.extras = extras;
        }

        public ComponentesProyecto(string codigoProyecto, int idEmpleado, string puesto, float porcentajeDedicacion)
        {
            this.codigoProyecto = codigoProyecto;
            this.idEmpleado = idEmpleado;
            this.puesto = puesto;
            this.porcentajeDedicacion = porcentajeDedicacion;
        }
        public bool esJefedeProyecto()
        {
            if (ControladorEmpleadosJSON.listaEmpleados.Contains(new Empleado { Id = idEmpleado}))
            {
                return true;
            }
            return false;
        }
    }
}
