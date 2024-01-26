using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1.Modelo
{

    public class Cliente
    {
        private string dni;
        private string nombre;
        private string direccion;
        private string ciudad;
        private Empleado representante;
        private string correo;
        private int cif;
        private int telefono;
        private string pais;
        private int descuento;
        private string comentarios;
        private Image logo;
        private DateTime cita;
        private string tipoCli;
        /*private enum TipoCliente
        {   
            Pequenio,
            Mediano, 
            Grande,
            Multinacional
        }*/
        public Cliente(string dni,string nombre, string direccion, string ciudad, Empleado representante, 
            string correo, int cif, int telefono, string pais, string tipoCli, int descuento, string comentarios, 
            Image logo, DateTime cita)
        {
            this.Dni = dni;
            this.Nombre = nombre;
            this.Direccion = direccion;
            this.Ciudad = ciudad;
            this.Representante = representante;
            this.Correo = correo;
            this.Cif = cif;
            this.Telefono = telefono;
            this.Pais = pais;
            this.Descuento = descuento;
            this.Comentarios = comentarios;
            this.Logo = logo;
            this.Cita = cita;
            this.TipoCli = tipoCli;
        }

        public string Dni { get => dni; set => dni = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Ciudad { get => ciudad; set => ciudad = value; }
        public Empleado Representante { get => representante; set => representante = value; }
        public string Correo { get => correo; set => correo = value; }
        public int Cif { get => cif; set => cif = value; }
        public int Telefono { get => telefono; set => telefono = value; }
        public string Pais { get => pais; set => pais = value; }
        public int Descuento { get => descuento; set => descuento = value; }
        public string Comentarios { get => comentarios; set => comentarios = value; }
        public Image Logo { get => logo; set => logo = value; }
        public DateTime Cita { get => cita; set => cita = value; }
        public string TipoCli { get => tipoCli; set => tipoCli = value; }
        public string Nombre { get => nombre; set => nombre = value; }
    }
}
