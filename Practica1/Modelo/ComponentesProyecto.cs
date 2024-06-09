namespace Practica1.Modelo
{
    public class ComponentesProyecto
    {
        int codP;
        string descripcionP;
        int idEmpleado;
        string puesto;
        float porcentajeDedicacion;
        decimal extras;


        public int CodigoP { get => codP; set => codP = value; }
        public string DescripcionP { get => descripcionP; set => descripcionP = value; }
        public int IdEmpleado { get => idEmpleado; set => idEmpleado = value; }
        public string Puesto { get => puesto; set => puesto = value; }
        public float PorcentajeDedicacion { get => porcentajeDedicacion; set => porcentajeDedicacion = value; }
        public decimal Extras { get => extras; set => extras = value; }

        public ComponentesProyecto(int codP, string codigoProyecto, int idEmpleado, string puesto, float porcentajeDedicacion, decimal extras)
        {
            this.codP = codP;
            this.descripcionP = codigoProyecto;
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
            if (puesto.ToLower().Trim() == "jefe")
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
