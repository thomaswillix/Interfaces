using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Practica1.Manejadores;

namespace Practica1.Modelo
{
    public class ComponentesProyecto
    {
        string codigoProyecto;
        int idEmpleado;
        string puesto;
        float porcentajeDedicacion;
        decimal extras;

        public string CodigoProyecto { get => codigoProyecto; set => codigoProyecto = value; }
        public int IdEmpleado { get => idEmpleado; set => idEmpleado = value; }
        public string Puesto { get => puesto; set => puesto = value; }
        public float PorcentajeDedicacion { get => porcentajeDedicacion; set => porcentajeDedicacion = value; }
        public decimal Extras { get => extras; set => extras = value; }

        public ComponentesProyecto(string codigoProyecto, int idEmpleado, string puesto, float porcentajeDedicacion, decimal extras)
        {
            this.codigoProyecto = codigoProyecto;
            this.idEmpleado = idEmpleado;
            this.puesto = puesto;
            this.porcentajeDedicacion = porcentajeDedicacion;
            this.extras = extras;
        }

        public ComponentesProyecto(int idEmpleado, string puesto, float porcentajeDedicacion)
        {
            this.idEmpleado = idEmpleado;
            this.puesto = puesto;
            this.porcentajeDedicacion = porcentajeDedicacion;
        }
        public ComponentesProyecto() { }
        public bool esJefedeProyecto()
        {
            if (puesto.ToLower().Trim()== "jefe")
            {
                return true;
            }
            return false;
        }
        public void setPorcentajeDedicacion(float porcentaje)
        {
            this.porcentajeDedicacion = porcentaje;
        }
    }
}
